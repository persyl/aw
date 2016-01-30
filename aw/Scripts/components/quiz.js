var Quiz = function(config) {
    this.config = config;
    this.outputElement = document.querySelector(config.domSelector);
};

Quiz.prototype.inform = function(msg) {
    this.outputElement.innerHTML = msg;
};


Quiz.prototype.start = function() {
    this.outputElement.innerHTML = '';
    var count = 0;
    this.config.questions.forEach(function(elmt, idx, arr) {
        this.outputElement.innerHTML += '<h2>Fråga ' + (idx + 1) + '.</h2>';
        this.outputElement.innerHTML += elmt.question;
        elmt.answers.forEach(function(aElmt, aIdx, aArr) {
            this.outputElement.innerHTML += '<div class="alternative"><input type="radio" name="altradio" id="alt_' + (aIdx + 1) + '" class="radio"/><label for="alt_' + (aIdx + 1) + '">' + aElmt + '</label></div>';
        }.bind(this));


    }.bind(this));


};

module.exports = function(config) {
    return new Quiz(config);
};
