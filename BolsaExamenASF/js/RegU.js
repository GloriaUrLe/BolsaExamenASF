$(document).ready(function () {
    $("#SecUsr").validate({
        submitHandler: function (form) {
         
            var iUsr = new Object();
            iUsr._usr = $("#Usr").val();
            iUsr._pwd = $("#Pass").val();
            iUsr._email = $("#Email").val();
            $.ajax({
                type: "POST",
                url: "webservices/AdmUsuario.svc/AddUsr",
                data: JSON.stringify(iUsr),
                contentType: "application/json",
                dataType: "json",
                success:
                    function (result) {
                        var arreglo = result.d.split("/");
                        var resultado = arreglo[0];
                        $("#idU").val(arreglo[2]);
                        if (resultado === "OK") {

                            alert("Los Datos han sido guardados correctamente.");
                            //aqui va el href
                            //$('#idU').val('tu_md5');
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