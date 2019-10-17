/*this is to when the website completly loaded, it will execute the "document ready" content*/
$(document).ready(
    function () {
        $('input[name="btnconvert"]').click(function () {

            var valuedollar = 4.16;
            var valuereal = $('input[name="valuereal"]').val().replace(".", "").replace(",", ".");

            var convert = valuereal / valuedollar;

            $('input[name="valuedollar"]').val(convert);
        });
        $('input[name="valuereal"]').mask("000.000,00");
    }
);

$(document).on('keypress', function (e) {
    if (e.which === 13) {
        $('input[name="btnconvert"]').click();
    }
});