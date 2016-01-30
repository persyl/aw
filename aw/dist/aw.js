(function e(t,n,r){function s(o,u){if(!n[o]){if(!t[o]){var a=typeof require=="function"&&require;if(!u&&a)return a(o,!0);if(i)return i(o,!0);var f=new Error("Cannot find module '"+o+"'");throw f.code="MODULE_NOT_FOUND",f}var l=n[o]={exports:{}};t[o][0].call(l.exports,function(e){var n=t[o][1][e];return s(n?n:e)},l,l.exports,e,t,n,r)}return n[o].exports}var i=typeof require=="function"&&require;for(var o=0;o<r.length;o++)s(r[o]);return s})({1:[function(require,module,exports){
var ajx = require('./components/ajax');

ajx.get('/api/result', function(data){
  console.log('Lyckat API-anrop!', data);
}, function(){
  console.log('Misslyckat API-anrop!');
}, false);
},{"./components/ajax":2}],2:[function(require,module,exports){
'use strict';

const ajax = {};

ajax.get = function (url, onSuccess, onError, forceSync) {
  var xmlhttp;

  if (forceSync === undefined) {
    forceSync = false;
  }

  if (window.XMLHttpRequest) {
    // code for IE7+, Firefox, Chrome, Opera, Safari
    xmlhttp = new XMLHttpRequest();
  } else {
    // code for IE6, IE5
    xmlhttp = new ActiveXObject('Microsoft.XMLHTTP');
  }

  xmlhttp.onreadystatechange = function () {
    if (xmlhttp.readyState === XMLHttpRequest.DONE) {
      var status = xmlhttp.status;
      if (status >= 200 && status < 300 || status === 304) {
        if (onSuccess) {
          onSuccess(xmlhttp.responseText);
        }
      } else {
        if (onError) {
          onError();
        }
      }
    }
  };

  xmlhttp.open('GET', url, !forceSync);
  xmlhttp.withCredentials = true;
  xmlhttp.send();
};

module.exports = ajax;

},{}]},{},[1]);
