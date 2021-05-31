<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroDP.aspx.cs" Inherits="BolsaExamenASF.RegistroDP" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Datos Personales</title>
    <script src="Scripts/jquery-3.6.0.js"></script>
    <script src="Scripts/jquery.validate.min.js"></script>
    <script src="Scripts/additional-methods.min.js"></script>
    <script src="Scripts/extendsvalidate.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <link href="Content/bootstrap.css" rel="stylesheet" />    
    <link href="CSS/styles.css" rel="stylesheet" />
    <script src="js/RegDP.js"></script>
</head>
<body>

     <nav class="navbar navbar-expand-lg navbar-dark bg-primary">
        <div class="container-fluid">
            <a class="navbar-brand" href="#">Bolsa de Exámen</a>
            <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarText" aria-controls="navbarText" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarText">
                <ul class="navbar-nav me-auto mb-2 mb-lg-0">
                    <li class="nav-item">
                        <a class="nav-link active" aria-current="page" href="#">Registro</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#">Consulta Usuarios</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#">Salir</a>
                    </li>
                </ul>
                <span class="navbar-text">ASF
                </span>
            </div>
        </div>
    </nav>
    <form id="SecDP" method="post" action="RegistroEL.aspx">
        <div class="container form-container">
            <div class=" form-control modal-content">
                <div class="modal-body row">
                    <div class="row col-form-label "><span>Los campos marcados con <span style="color:red">*</span> son requeridos</span></div>
                    <div class="row col-form-label "></div>
                    <div class="row">
                        <label for="Nombre" class="col-sm-2 col-form-label text-sm-end"><span style="color:red">*</span>Nombre</label>
                        <div class="col-sm-8">
                            <input type="text" class="form-control input-group-sm" id="Nombre" name="Nombre" placeholder="Nombre" minlength="3" maxlength="250" required="required"/>
                        </div>
                    </div>
                    <div class="row col-form-label "></div>
                    <div class="row">
                        <label for="APaterno" class="col-sm-2 col-form-label text-sm-end"><span style="color:red">*</span>Apellido Paterno</label>
                        <div class="col-sm-8">
                            <input type="text" class="form-control input-group-sm" id="APaterno" name="APaterno" placeholder="Apellido Paterno" minlength="3" maxlength="250" required="required" />
                        </div>

                    </div>
                    <div class="row col-form-label "></div>
                    <div class="row">
                        <label for="AMaterno" class="col-sm-2 col-form-label text-sm-end">Apellido Materno</label>
                        <div class="col-sm-8">
                            <input type="text" class="form-control input-group-sm" id="AMaterno" name="AMaterno" placeholder="Apellido Materno"/>
                        </div>
                    </div>
                    <div class="row col-form-label "></div>
                    <div class="row">
                        <label for="ciudad" class="col-sm-2 col-form-label text-sm-end"><span style="color:red">*</span>Ciudad</label>
                        <div class="col-sm-3">
                            <input type="text" class="form-control input-group-sm" id="ciudad" name="ciudad" placeholder="Ciudad" minlength="3" maxlength="250" required="required" />

                        </div>
                        <label for="calle" class="col-sm-2 col-form-label text-sm-end"><span style="color:red">*</span>Calle</label>
                        <div class="col-sm-3">
                            <input type="text" class="form-control input-group-sm" id="calle" name="calle" placeholder="Calle" minlength="3" maxlength="250" required="required" />

                        </div>

                    </div>
                    <div class="row col-form-label "></div>
                    <div class="row">
                        <label for="num" class="col-sm-2 col-form-label text-sm-end">Número</label>
                        <div class="col-sm-3">
                            <input type="text" class="form-control input-group-sm" id="num" name="num" placeholder="Número" />

                        </div>
                        <label for="colonia" class="col-sm-2 col-form-label text-sm-end"><span style="color:red">*</span>Colonia</label>
                        <div class="col-sm-3">
                            <input type="text" class="form-control input-group-sm" id="colonia" name="colonia" placeholder="Colonia" minlength="3" maxlength="250" required="required" />

                        </div>

                    </div>
                    <div class="row col-form-label "></div>
                    <div class="row">
                        <label for="municipio" class="col-sm-2 col-form-label text-sm-end"><span style="color:red">*</span>Municipio</label>
                        <div class="col-sm-3">
                            <input type="text" class="form-control input-group-sm" id="municipio" name="municipio" placeholder="Municipio"  minlength="3" maxlength="250" required="required"/>

                        </div>
                        <label for="edo" class="col-sm-2 col-form-label text-sm-end"><span style="color:red">*</span>Estado</label>
                        <div class="col-sm-3">
                            <input type="text" class="form-control input-group-sm" id="edo" name="edo" placeholder="Estado" minlength="3" maxlength="250" required="required" />

                        </div>

                    </div>

                    <div class="row col-form-label "></div>
                    <div class="row">
                        <label for="telefono" class="col-sm-2 col-form-label text-sm-end"><span style="color:red">*</span>Telefono</label>
                        <div class="col-sm-3">
                            <input type="tel" class="form-control input-group-sm" id="telefono" name="telefono" placeholder="Telefono"  minlength="10" maxlength="10" required="required"/>

                        </div>
                        <label for="tel2" class="col-sm-2 col-form-label text-sm-end">Celular</label>
                        <div class="col-sm-3">
                            <input type="tel" class="form-control input-group-sm" id="tel2" name="tel2" placeholder="Celular" minlength="10" maxlength="10"/>

                        </div>

                    </div>
                    <div class="row col-form-label "></div>
                    <div class="row">
                        <label for="fechaNac" class="col-sm-2 col-form-label text-sm-end"><span style="color:red">*</span>Fecha de Nacimiento</label>
                        <div class="col-sm-3">
                            <input type="date" class="form-control input-group-sm" id="fechaNac" name="fechaNac" required="required"/>

                        </div>
                        <label for="curp" class="col-sm-2 col-form-label text-sm-end"><span style="color:red">*</span>CURP</label>
                        <div class="col-sm-3">
                            <input type="text" class="form-control input-group-sm" id="curp" name="curp" placeholder="CURP"  minlength="18" maxlength="18" required="required"/>

                        </div>

                    </div>
                    <div class="row col-form-label "></div>
                    <div class="row">
                        <label for="rfc" class="col-sm-2 col-form-label text-sm-end"><span style="color:red">*</span>RFC</label>
                        <div class="col-sm-3">
                            <input type="text" class="form-control input-group-sm" id="rfc" name="rfc" placeholder="RFC"  minlength="13" maxlength="13" required="required" />

                        </div>
                        <label for="pasaporte" class="col-sm-2 col-form-label text-sm-end">Pasaporte</label>
                        <div class="col-sm-3">
                            <input type="text" class="form-control input-group-sm" id="pasaporte" name="pasaporte" placeholder="Pasaporte" />

                        </div>

                    </div>
                        <div class="row col-form-label "></div>
                    <div class="row">
                        <label for="cartilla" class="col-sm-2 col-form-label text-sm-end">Cartilla</label>
                        <div class="col-sm-3">
                            <input type="text" class="form-control input-group-sm" id="cartilla" name="cartilla" placeholder="Cartilla"/>

                        </div>
                        <label for="edoCivil" class="col-sm-2 col-form-label text-sm-end">Estado Civil</label>
                        <div class="col-sm-3">
                            <input type="text" class="form-control input-group-sm" id="edoCivil" name="edoCivil" placeholder="Estado Civil" />

                        </div>

                    </div>
                    <div class="row col-form-label "></div>

                    <div class="row">
                        <label for="Genero" class="col-sm-2 col-form-label text-sm-end">Genero</label>
                        <div class="col-sm-8">

                            <div class="col-sm-3">
                                <input class="form-check-input" type="radio" name="genero" id="GeneroM" value="Masculino" checked />
                                <label class="col-sm-2 form-check-label" for="GeneroM">
                                    Masculino
                                </label>
                            </div>
                            <div class="col-sm-3">
                                <input class="form-check-input" type="radio" name="genero" id="generoF" value="Femenino" />
                                <label class="col-sm-2 form-check-label" for="GeneroF">
                                    Femenino
                                </label>
                            </div>
                            <div class="col-sm-3">
                                <input class="form-check-input" type="radio" name="genero" id="generoO" value="Otro" />
                                <label class="col-sm-2 form-check-label" for="GeneroO">
                                    Otro
                                </label>
                            </div>
                        </div>
                    </div>

                    <div class="row col-form-label ">
                    </div>
                    <div class="modal-footer">
                        <div class="row">
                            <div class="col-sm-10">
                                <button type="submit" class="btn btn-primary" id="btnGDP">Continuar</button>
                            </div>
                            <div class="col-sm-2"></div>

                        </div>
                    </div>
                    <input type="hidden" id="idU" name="idU" value="17"/>
                    <input type="hidden" id="idDp" name="idDp" value="1"/>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
