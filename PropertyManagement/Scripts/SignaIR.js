(function () {
    var chat = $.connection.myHub;
    $.connection.hub.start()
        .done(function () {
            $.connection.hub.logging = true;
            writeToPage("IT WORKED!3");
            chat.server.announceToEverybody("Connected!");
            chat.server.GetServerDateTime()
                .done(function (data) {
                    writeToPage(data);
                })
                .fail(function (e) {
                    writeToPage(e);
                });
        })
        .fail(function () { writeToPage("ERROR!!!!"); });

    chat.client.announce = function (message)
    {
        writeToPage(message);
    }

    var writeToPage = function (message)
    {
        $("#welcome-message").append(message + "<br />");
    }
})()
