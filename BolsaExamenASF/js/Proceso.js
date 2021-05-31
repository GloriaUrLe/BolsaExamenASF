$(document).ready(function () {
    var iSelected = new Object();
    iSelected.idsSelected = $('#idSelected').val();
    $.ajax({
        type: "POST",
        url: "webservices/Proceso.svc/GetSelectedUsers",
        data: JSON.stringify(iSelected),
        contentType: "application/json",
        dataType: "json",
        success:
            function (xmlData) {
                $("Row", xmlData.d).each(function () {
                    var id = $(this).find("llave_usuario").text();
                    var usuario = $(this).find("usuario").text();
                    var email = $(this).find("email").text();
                    var fechaAlta = $(this).find("fecha_alta").text();
                    $(TableUsuarios).append(
                        $('<tr/>')
                            .append($('<td/>', { text: id }))
                            .append($('<td/>', { text: usuario }))
                            .append($('<td/>', { text: email }))
                            .append($('<td/>', { text: fechaAlta }))
                    );
                });
            },
        error:
            function (XmlHttpError, error, description) {
                alert(XmlHttpError.responseText);
            },
        async: true
    });

   
});


