$(document).ready(function () {
  
    $("#SecDP").validate({
        highlight: function (element, errorClass) {
            $(element).fadeOut(function () {
                $(element).fadeIn();
            });
        }
    });
    jQuery.validator.setDefaults({
        debug: true,
        success: "valid"
    });
    $("#SecDP").validate({
        rules: {
            fechaNac: {
                required: true,
                date: true
            },
            telefono: {
                required: true,
                digits: true
            },
            tel2: {
                digits: true
            }
        }
    });   

});
function enviardatos() {
    var iDP = new Object();
    iDP._Nombre = $("#calle").val();
    iDP._APaterno = $("#calle").val();
    iDP._AMaterno = $("#calle").val();
    iDP._ciudad = $("#calle").val();
    iDP._calle = $("#calle").val();
    iDP._num = $("#num").val();
    iDP._colonia = $("#colonia").val();
    iDP._municipio = $("#municipio").val();
    iDP._edo = $("#edo").val();
    iDP._telefono = $("#telefono").val();
    iDP._tel2 = $("#tel2=").val();
    iDP._fechaNac = $("#fechaNac").val();
    iDP._curp = $("#curp").val();
    iDP._rfc = $("#rfc").val();
    iDP._pasaporte = $("#pasaporte").val();
    iDP._genero = $("#genero").val();
    iDP._IdUsr = gblIdU;
    $.ajax({
        type: "POST",
        url: "webservices/RegistroDP.svc/RegDP",
        data: JSON.stringify(iDP),
        contentType: "application/json",
        dataType: "json",
        success:
            function (ResbuscaClas) {
                var arreglo = ResbuscaClas.d.split("/");
                var resultado = arreglo[0];
                if (resultado === "OK") {
                   
                    alert("Los Datos han sido guardados correctamente.");
                   //aqui va el href
                }
                else {
                    alert(arreglo[1]);

                }
            },
        error:
            function (XmlHttpError, error, description) {
                alert(XmlHttpError.responseText);
            },
        async: true
    });
}





