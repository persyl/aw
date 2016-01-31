try {
//var $ = require('jquery');
var Quiz = require('./components/quiz');

//$(document).ready(function() {
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
//});
}catch(e){
  document.querySeslector('body').innerHTML += 'Nåt gick fel: ' + e.message;
}