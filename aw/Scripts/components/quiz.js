var ajx = require('./ajax');

var questionCounter;
var Quiz = function(config) {
    this.config = config;
    this.outputElement = document.querySelector(config.domSelector);
};

Quiz.prototype.inform = function(msg) {
    this.outputElement.innerHTML = msg;
};


Quiz.prototype.start = function() {
    questionCounter = 0;
    this.savedData = {
        Contestant: '',
        Answers: []
    };
    this.outputElement.innerHTML = '';
    this.createInfoBoard();
    this.nextQuestion();
};

Quiz.prototype.createInfoBoard = function() {
    this.infoBoard = document.createElement('div');
    this.infoBoard.setAttribute('id', 'infoBoard');
    this.outputElement.parentNode.insertBefore(this.infoBoard, this.outputElement);
};

Quiz.prototype.nextQuestion = function() {
    questionCounter++;
    var elmt = this.config.questions[(questionCounter - 1)];
    this.outputElement.innerHTML = '';
    this.outputElement.innerHTML += '<h2>Fråga ' + questionCounter + '.</h2>';
    this.outputElement.innerHTML += elmt.question;
    elmt.alternatives.forEach(function(alt, aIdx, aArr) {
        this.outputElement.innerHTML += '<div class="alternative"><input type="radio" name="altradio" id="alt_' + (aIdx + 1) + '" class="radio" value="' + alt + '"/><label for="alt_' + (aIdx + 1) + '">' + alt + '</label></div>';
    }.bind(this));

    this.outputElement.appendChild(createSpacer());
    var button;
    if (questionCounter < this.config.questions.length) {
        button = createButton('Visa fråga nr ' + (questionCounter + 1), function() {
            window.scrollTo(0, 0);
            if (this.validate()) {
                this.savedData.Answers.push(document.querySelector('input[type="radio"][name="altradio"]:checked').value);
                this.infoBoard.innerHTML = 'Du har nu svarat på ' + questionCounter + 'st frågor';
                this.nextQuestion();
            }
        }.bind(this));
    } else {
        var nameInput = document.createElement('input');
        nameInput.setAttribute('type', 'text');
        nameInput.setAttribute('id', 'quiz_contestant');
        nameInput.setAttribute('value', '');
        nameInput.setAttribute('placeholder', 'Ditt namn?');
        this.outputElement.appendChild(nameInput);
        button = createButton('KLAR', function() {
            window.scrollTo(0, 0);
            if (this.validate(true)) {
                this.savedData.Answers.push(document.querySelector('input[type="radio"][name="altradio"]:checked').value);
                this.savedData.Contestant = document.querySelector('#quiz_contestant').value;
                this.sendQuiz();
                this.outputElement.innerHTML = '';
            }
        }.bind(this));
    }
    this.outputElement.appendChild(button);
};

Quiz.prototype.validate = function(withNameField) {
    var validateName = withNameField ? true : false;
    var errorMsg = 'Du måste markera ett av svaren!';
    var allAlternatives = document.querySelectorAll('[id^="alt_"]');
    var result = Array.from(allAlternatives).some(function(elmt, idx, arr) {
        return elmt.checked;
    });

    if (validateName) {
        var nameField = document.querySelector('#quiz_contestant');
        if (nameField.value.length < 1) {
            errorMsg = 'Vänligen fyll i ditt namn!';
            result = false;
        }
    }
    if (!result) {
        this.infoBoard.innerHTML = errorMsg;
    }
    return result;
};

Quiz.prototype.sendQuiz = function() {
    //TODO: Posta this.savedData
    ajx.get('/api/result', function(data) {
            var parsedData = JSON.parse(data);
            //console.log('Lyckat API-anrop!', data);
            this.infoBoard.innerHTML = parsedData.ServerResponse;
        }, function() {
            this.infoBoard.innerHTML = 'Något gick tyvärr fel! Dina svar är INTE skickade.';
        },
        'POST',
        JSON.stringify(this.savedData)
    );
};

var createButton = function(txt, clickAction) {
    var button = document.createElement("a");
    button.appendChild(document.createTextNode(txt));
    button.setAttribute('href', '');
    button.setAttribute('class', 'quiz_btn');
    button.onclick = function() {
        event.preventDefault();
        clickAction();
    };
    return button;
}

var createSpacer = function(appendTo) {
    var spacer = document.createElement("div");
    spacer.setAttribute('class', 'spacer');
    return spacer;
};

module.exports = function(config) {
    return new Quiz(config);
};
