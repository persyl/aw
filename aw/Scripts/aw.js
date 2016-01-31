document.querySelector('body').innerHTML += 'Debug 01';
var $ = require('jquery');
var Quiz = require('./components/quiz');
document.querySelector('body').innerHTML += 'Quiz required';
$(document).ready(function() {
    document.querySelector('body').innerHTML += 'Document ready';
    var quizConfig = {
        domSelector: '.js-quiz_output',
        questions: [{
            question: 'Vilket av kodspråk jobbar konsumentteamet för tillfället INTE med?',
            alternatives: ['Javascript', 'PHP', 'C-sharp']
        }, {
            question: 'Vad kallas det när man bygger koden?',
            alternatives: ['Komprimera', 'Kompilera', 'Kontrastera']
        }]
    };
    var quiz = new Quiz(quizConfig);
    quiz.start();
});
