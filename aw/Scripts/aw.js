
//var $ = require('jquery');
var Quiz = require('./components/quiz');

//$(document).ready(function() {
    var quizConfig = {
        domSelector: '.js-quiz_output',
        questions: [{
            question: 'Fråga nummer 1 test?',
            alternatives: ['Testsvar 1', 'Testsvar 2', 'Testsvar 3']
        }, {
            question: 'Testfråga nummer 2?',
            alternatives: ['Testsvar 1', 'Testsvar 2', 'Testsvar 3']
        }]
    };
    var quiz = new Quiz(quizConfig);
    quiz.start();
    
//});