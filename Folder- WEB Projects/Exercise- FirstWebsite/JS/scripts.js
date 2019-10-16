$(document).ready(
    function () {
        updateDate();
    });


function updateDate() {
    setInterval(function () {
        $('span[name="updated_date"]').text(Date());
    }, 100);
}