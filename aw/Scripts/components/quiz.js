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
        this.outputElement.innerHTML += '<div class="alternative"><input type="radio" name="altradio" id="alt_' + (aIdx + 1) + '" class="radio"/><label for="alt_' + (aIdx + 1) + '">' + alt + '</label></div>';
    }.bind(this));

    this.outputElement.appendChild(document.createElement("br"));
    var button;
    if (questionCounter < this.config.questions.length) {
        button = createButton('Visa fråga nr ' + (questionCounter + 1), function() {
            this.infoBoard.innerHTML = 'Du har nu svarat på ' + questionCounter + 'st frågor';
            this.nextQuestion();
        }.bind(this));
    } else {
        button = createButton('KLAR', function() {
            this.sendQuiz();
            this.outputElement.innerHTML = '';
        }.bind(this));
    }
    this.outputElement.appendChild(button);
};

Quiz.prototype.sendQuiz = function() {
    ajx.get('/api/result', function(data) {
        console.log('Lyckat API-anrop!', data);
        this.infoBoard.innerHTML = 'Dina svar är nu skickade.';
    }, function() {
        this.infoBoard.innerHTML = 'Något gick tyvärr fel! Dina svar är INTE skickade.';
    }, false);
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

module.exports = function(config) {
    return new Quiz(config);
};
