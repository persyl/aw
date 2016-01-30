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