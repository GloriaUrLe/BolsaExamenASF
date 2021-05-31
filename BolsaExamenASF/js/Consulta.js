$(document).ready(function () {
    $.ajax({
        type: "POST",
        url: "webservices/Consulta.svc/GetUsers",
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
                        $('<tr/>').append($('<td/>')
                            .append($('<input />', {
                                type: 'checkbox',
                                id: 'td' + id,
                                value: id,
                                name: 'seleccion'
                            })
                            ))
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

    $('#btnContinue').click(function (e) {
        e.preventDefault();
        var selected = false;
        var idSelected = "";
        $('#errorMessage').html('');
        $('input[name="seleccion"]:checked').each(function () {
            selected = true;
            idSelected += this.value + ',';
        });
        $('#IdsSelected').val(idSelected);
        if (!selected) {
            $('#errorMessage').add('error-message');
            $('#errorMessage').html('Debe seleccionar un candidato.');
        }
        if (selected) {
            $('#formConsulta').submit();
        }
    });
});