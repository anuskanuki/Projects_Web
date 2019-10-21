var Dog =
{
    Name: "Doguinho",
    Color: "Caramelinho",
    Breed: "Tomba",
    Age: 15
}

var ArrayDogs = [Dog];

$(document).ready(
    function () {
        $('#show').click(function () {

            //alert(JSON.stringify(ArrayDogs));

            var stringTemplate = "Registered Dogs:\n\n";

            for (var i = 0; i < ArrayDogs.length; i++) {
                stringTemplate += ArrayDogs[i].Name + "\r\n";
            }

            alert(stringTemplate);
            ClearScreen();
        });

        $('#save').click(function () {
            var NewDog =
            {
                Name: $('#name').val(),
                Color: $('#color').val(),
                Breed: $('#breed').val(),
                Age: $('#age').val(),
               
            }
            
            ArrayDogs.push(NewDog);
            var stringResult = "Dog sucessfully saved!\r\nName: " + NewDog.Name + "\r\nBreed: " + NewDog.Breed + "\r\nColor: " + NewDog.Color + "\r\n" + NewDog.Age+" years";
            alert(stringResult);
            ClearScreen();
           
        });

    });
function ClearScreen() {
    var myInputs = $('input[type="text"]');
        myInputs.val("");
}







