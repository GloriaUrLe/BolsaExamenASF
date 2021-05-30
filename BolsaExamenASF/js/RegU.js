$(document).ready(function () {
    //$("#SecUsr").validate({
    //    highlight: function (element, errorClass) {
    //        $(element).fadeOut(function () {
    //            $(element).fadeIn();
    //        });
    //    }
    //});

    jQuery.validator.setDefaults({
        debug: true,
        success: "valid"
    });
    $("#SecUsr").validate({
        rules: {
            Pass: "required",
            PassConfirm: {
                equalTo: "#Pass"
            }
        }
    });
});