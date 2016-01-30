var $ = require('jquery');
var ajx = require('./components/ajax');
var Quiz = require('./components/quiz');

$(document).ready(function() {
    var quizConfig = {
        domSelector: '.js-quiz_output',
        questions: [{

            question: 'Vilket av kodspråk jobbar konsumentteamet för tillfället INTE med?',
            answers: ['Javascript', 'PHP', 'C-sharp']
        }]
    };
    var quiz = new Quiz(quizConfig);
    quiz.start();

    // ajx.get('/api/result', function(data) {
    //     console.log('Lyckat API-anrop!', data);
    // }, function() {
    //     console.log('Misslyckat API-anrop!');
    // }, false);
});
