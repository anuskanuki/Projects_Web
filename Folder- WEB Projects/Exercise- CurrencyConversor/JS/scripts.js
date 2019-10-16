$(document).ready(
    function () {
        $('#amount').mask('#.##0.00', { reverse: true });

        $('button[type="button"]').click(function () {
            var reais = $('input[name="reais"]').val();
            var dolares = $('input[name="dolares"]').val();


            if (reais.length > 1) {
                alert("O formulario foi preenchido com sucesso");
                $('input[name="reais"]').val("");
                $('input[name="dolares"]').val("");

            } else {
                alert("Preencha os dados corretamente");
            }
        });
    }
);

function realConverter() {
    document.converter.dollar.value = document.converter.reais.value / 4.10
}
function dollarConverter() {
    document.converter.reais.value = document.converter.dollar.value * 0.24
}


var crrncy = { 'BRL': { 'USD': 0.23 }, 'USD': { 'BRL': 4.12 } }
var btn = document.querySelector('.calculate-btn');
var baseCurrencyInput = document.getElementById('currency-1');
var secondCurrencyInput = document.getElementById('currency-2');
var amountInput = document.getElementById('amount');
var toShowAmount = document.querySelector('.given-amount');
var toShowBase = document.querySelector('.base-currency');
var toShowSecond = document.querySelector('.second-currency');
var toShowResult = document.querySelector('.final-result');

function convertCurrency(event) {
    event.preventDefault();
    var amount = amountInput.value;
    var from = baseCurrencyInput.value;
    var to = secondCurrencyInput.value;
    var result = 0;

    try {
        if (from == to) {
            result = amount;
        } else {
            result = amount * crrncy[from][to];
        }
    }
    catch (err) {
        result = amount * (1 / crrncy[to][from]);
    }

    toShowAmount.innerHTML = amount;
    toShowBase.textContent = from + ' = ';
    toShowSecond.textContent = to;
    toShowResult.textContent = result;
}

btn.addEventListener('click', convertCurrency);
