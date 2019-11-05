var Pessoa =
{
    Login: "Nuki",
    Email:"nuki@gmail.com",
    Senha: "123"
}

var ArrayPessoas = [Pessoa];

$(document).ready(
    function () {
        $('#mostrar').click(function () {

            var stringTemplate = "Pessoas Registradas:\n\n";

            for (var i = 0; i < ArrayPessoas.length; i++) {
                stringTemplate += ArrayPessoas[i].Login + "\r\n";
            }

            alert(stringTemplate);
            ClearScreen();
        });

        $('#logar').click(function () {
            //var NewPessoa =
            //{
            //    Nome: $('#nome').val(),
            //    Login: $('#login').val()
            //}

            //ArrayPessoas.push(NewPessoa);
            //var stringResult = "Pessoa cadastrada com sucesso!\r\nName: "
            //    + NewPessoa.Name + "\r\nBreed: " + NewPessoa.Breed +
            //    "\r\nColor: " + NewPessoa.Color + "\r\n" + NewPessoa.Age + " years";
            //alert(stringResult);
            //ClearScreen();
            alert("BEM-VINDO!");
        });

    });
function ClearScreen() {
    var myInputs = $('input[type="text"]');
    myInputs.val("");
}



