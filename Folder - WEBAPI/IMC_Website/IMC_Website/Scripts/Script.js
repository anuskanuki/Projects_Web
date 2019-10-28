
$('#imc').mask("##.00");

$(document).ready(function () {
    $('#show').click(function () {
        var formCampos = $('#form_principal').serialize();

        $.get("http://localhost:59189/api/Imc?" + formCampos, function (data) {
            $('#imc').val(data.ImcValue);
        });

        $.get("http://localhost:59189/api/Imc/Msg?" + formCampos, function (data) {
            $('#msg').val(data)
        });
    });

    $('#clear').click(function () {
        ClearScreen();
    });

});

function ClearScreen() {
    var myInputs = $('input[type="text"]');
    myInputs.val("");
}



