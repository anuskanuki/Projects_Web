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
            alert(JSON.stringify(ArrayDogs));
        });

        $('#save').click(function () {
            var NewDog =
            {
                Name: $('#name').val(),
                Color: $('#color').val(),
                Breed: $('#breed').val(),
                Age: $('#age').val(),
            }
            ArrayDoguinhos.push(NewDog);
            alert("Dog saved!");
        });

    });








