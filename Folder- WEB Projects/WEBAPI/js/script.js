$(document).ready(
    function () {

        $('#newconsult').click(function () {
            ClearScreen();
        });

        $('#cep').mask("00000-000");

        $('#consult').click(
            function () {



                $.get("https://viacep.com.br/ws/" + $('#cep').val() + "/json", function (data) {

                    if (data.erro) {
                        alert("Invalid CEP");
                        return false;
                    }

                    if (data.complemento == "") {
                        $('#complement').val("uninformed");
                    } else {
                        $('#complement').val(data.complemento);
                    }
                    $('#road').val(data.logradouro);
                    $('#neighborhood').val(data.bairro);
                    $('#city').val(data.localidade);
                    $('#state').val(data.uf);
                    if (data.unidade == "") {
                        $('#unity').val("uninformed");
                    } else {
                        $('#unity').val(data.unidade);
                    }
                    if (data.ibge == "") {
                        $('#ibge').val("uninformed");
                    } else {
                        $('#ibge').val(data.ibge);
                    }
                    if (data.gia == "") {
                        $('#gia').val("uninformed");
                    } else {
                        $('#gia').val(data.gia);
                    }
                });
            }
        );

        $(document).keypress(function (e) {
            if (e.which == "13") {
                $('#consult').click();
            }
        });
    }
);

function ClearScreen() {
    var myInputs = $('input[type="text"]');
    myInputs.val("");
}







