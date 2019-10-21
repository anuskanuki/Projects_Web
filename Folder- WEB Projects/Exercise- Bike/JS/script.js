var Bike =
{
    Brand: "Everest",
    Price: 900.00,
    Weight: 15
}
var ArrayBikes = [Bike];

$(document).ready(
    function () {
        $('#show').click(function () {

            var stringTemplate = "Registered Bikes:\r\n\r\n";

            for (var i = 0; i < ArrayBikes.length; i++) {
                stringTemplate += ArrayBikes[i].Brand+"\r\n";
            }

            alert(stringTemplate);
            ClearScreen();
        });

        $('#save').click(function () {
            var NewBike =
            {
                Brand: $('#brand').val(),
                Price: $('#price').val(),
                Weight: $('#weight').val()
            }
            ArrayBikes.push(NewBike);
            var stringResult = "Bike sucessfully saved:\r\n" + NewBike.Brand + "\r\n" + NewBike.Price + "\r\n" + NewBike.Weight;
            alert(stringResult);
            ClearScreen();
        });

    });
function ClearScreen() {
    var myInputs = $('input[type="text"]');//inputs do tipo text (nao dos botão) que quero apagar
    myInputs.val("");
}







