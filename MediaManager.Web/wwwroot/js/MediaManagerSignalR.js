"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/mediaManagerHub").build();

connection.on("ReceiveData", function (data) {
    $("#containerForSignalRData").append(data);
});

connection.start().then(function () { }).catch(function (err) {
    return console.error(err.toString());
});