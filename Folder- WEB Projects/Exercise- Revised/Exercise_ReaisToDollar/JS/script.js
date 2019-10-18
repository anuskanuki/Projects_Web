/*this is to when the website completly loaded, it will execute the "document ready" content*/
$(document).ready(
    function () {
        $('input[name="valuereal"]').mask("000.000,00");

        $('input[name="btnconvert"]').click(function () {

            var url = "https://olinda.bcb.gov.br/olinda/servico/PTAX/versao/v1/odata/CotacaoDolarDia(dataCotacao=@dataCotacao)?@dataCotacao=%2710-16-2019%27&$top=100&$format=json";

            $.getJSON(url, function (date) {

                var valuedollar = date.value[0].cotacaoVenda;

                var valuereal = $('input[name="valuereal"]').val().
                    replace(".", "").
                    replace(",", ".");

                var convert = (valuereal / valuedollar).toLocaleString('en-us', { minimumFractionDigits: 2, currency: 'USD' });

                $('input[name="valuedollar"]').val(convert);
            });

            

        });
        //$('input[name="valorReal"]').maskMoney({
        //    showSymbol: false,
         //   symbol: "R$",
         //   decimal: ",",
         //   thousands: "."
       // }); NAO FUNCIONA ESTA CARAMBOLHA
    });

$(document).on('keypress', function (e) {
    if (e.which === 13) {
        $('input[name="btnconvert"]').click();
    }
});