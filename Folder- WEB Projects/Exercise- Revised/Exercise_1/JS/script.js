/*this is to when the website completly loaded, it will execute the "document ready" content*/
$(document).ready(
    function () {
        $('button[name="btnwelcome"]').click(function () {

            /* get the name typed by the user */
            var username = $('input[name="username"]').val();
            /*show the whelcome alert*/
            $('span[name="usertext"]').text(username);

        });

    });

$(document).on('keypress', function (e) {
    if (e.which === 13) {
        $('button[name="btnwelcome"]').click();
    }
});