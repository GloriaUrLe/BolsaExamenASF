$(document).ready(function () {
    $("#SecDP").validate({
        submitHandler: function (form) {            
            var iDP = new Object();
            iDP._idU = $("#idU").val();
            iDP._nombre = $("#Nombre").val();
            iDP._paterno = $("#APaterno").val();
            iDP._materno = $("#AMaterno").val();
            iDP._ciudad = $("#ciudad").val();
            iDP._calle = $("#calle").val();
            iDP._no = $("#num").val();
            iDP._colonia = $("#colonia").val();           
            iDP._tel = $("#telefono").val();
            iDP._tel2 = $("#tel2").val();
            iDP._fecNac = $("#fechaNac").val();
            iDP._curp = $("#curp").val();
            iDP._rfc = $("#rfc").val();
            iDP._pasaporte = $("#pasaporte").val();
            iDP._cartilla = $("#cartilla").val();
            iDP._genero = $('input:radio[name=genero]:checked').val();
            iDP._edoCivil = $("#edoCivil").val();
            iDP._mun = $("#municipio").val();
            iDP._edo = $("#edo").val();
            $.ajax({
                type: "POST",
                url: "webservices/AdmUsuario.svc/AddDP",
                data: JSON.stringify(iDP),
                contentType: "application/json",
                dataType: "json",
                success:
                    function (result) {
                        var arreglo = result.d.split("/");
                        var resultado = arreglo[0];
                        $("#idU").val(arreglo[2]);
                        $("#idDp").val(arreglo[3]);
                        if (resultado === "OK") {

                            alert("Los Datos han sido guardados correctamente.");
                            form.submit();
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
        },
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






