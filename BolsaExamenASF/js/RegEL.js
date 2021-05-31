$(document).ready(function () {
    $("#SecEL").validate({
        submitHandler: function (form) {
            // , string , int , int , string , int )
            var iEL = new Object();
            iEL._idU = $("#idU").val();
            iEL._puesto = $("#puesto").val();
            iEL._funciones = $("#funciones").val();
            iEL._empresa = $("#empresa").val();
            iEL._noEmp = $("#noEmp").val();
            iEL._FeIn = $("#fInicio").val();
            iEL._FeFin = $("#fFin").val();
            iEL._RetMensB = $("#RetMenB").val();
            iEL._RetMensN = $("#RetMenN").val();
            iEL._pais = $("#pais").val();
            iEL._idDP = $("#fechaNac").val();
            
            $.ajax({
                type: "POST",
                url: "webservices/AdmUsuario.svc/AddExpL",
                data: JSON.stringify(iEL),
                contentType: "application/json",
                dataType: "json",
                success:
                    function (result) {
                        var arreglo = result.d.split("/");
                        var resultado = arreglo[0];
                        $("#idU").val(arreglo[2]);
                        $("#idExL").val(arreglo[3]);
                        if (resultado === "OK") {

                            alert("Los Datos han sido guardados correctamente.");
                            //aqui va el href
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
            Pass: "required",
            PassConfirm: {
                equalTo: "#Pass"
            }
        }
    });
});