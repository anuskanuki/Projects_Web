$(document).ready(
    function () {
        $('input[type="button"]').click(
            function () {
                var name = $('input[name="name"]').val();
                alert("Hello " + name + "!");
            });
    }
);