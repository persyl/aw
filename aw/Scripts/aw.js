var ajx = require('./components/ajax');

ajx.get('/api/result', function(data){
  console.log('Lyckat API-anrop!', data);
}, function(){
  console.log('Misslyckat API-anrop!');
}, false);