var $ = require('jquery');
var ajx = require('./components/ajax');

ajx.get('/api/result', function(data){
  console.log('Lyckat API-anrop!', data);
}, function(){
  console.log('Misslyckat API-anrop!');
}, false);

$(document).ready(function(){
  console.log('jQuery loaded!');
});