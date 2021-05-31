<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroEL.aspx.cs" Inherits="BolsaExamenASF.RegistroEL" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Experiencia Laboral</title>
    <script src="Scripts/jquery-3.6.0.js"></script>
    <script src="Scripts/jquery.validate.min.js"></script>
    <script src="Scripts/additional-methods.min.js"></script>
    <script src="Scripts/extendsvalidate.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="CSS/styles.css" rel="stylesheet" />
    <script src="js/RegEL.js"></script>
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
    <form id="SecEL" method="post" action="Consulta.aspx">
        <div class="container form-container">
            <div class=" form-control modal-content">
                <div class="modal-body row">
                    <div class="row col-form-label "><span>Los campos marcados con <span style="color:red">*</span> son requeridos</span></div>
                    <div class="row col-form-label "></div>
                    <div class="row">
                        <label for="puesto" class="col-sm-2 col-form-label text-sm-end"><span style="color:red">*</span>Puesto</label>
                        <div class="col-sm-8">
                            <input type="text" class="form-control input-group-sm" id="puesto" name="puesto" placeholder="Puesto" minlength="3" maxlength="250" required="required" />

                        </div>

                    </div>
                    <div class="row col-form-label ">
                    </div>
                    <div class="row">
                        <label for="funciones" class="col-sm-2 col-form-label text-sm-end">Funciones</label>
                        <div class="col-sm-8">
                            <textarea class="form-control input-group-sm" id="funciones" name="funciones" placeholder="Funciones" rows="5" cols="36"></textarea>

                        </div>

                    </div>
                    <div class="row col-form-label "></div>
                    <div class="row">
                        <label for="empresa" class="col-sm-2 col-form-label text-sm-end"><span style="color:red">*</span>Empresa</label>
                        <div class="col-sm-8">
                            <input class="form-control input-group-sm" id="empresa" name="empresa" placeholder="Empresa"  minlength="3" maxlength="250" required="required"/>

                        </div>

                    </div>
                    <div class="row col-form-label "></div>
                    <div class="row">
                        <label for="noEmp" class="col-sm-2 col-form-label text-sm-end">Numero de Empleado</label>
                        <div class="col-sm-8">
                            <input class="form-control input-group-sm" id="noEmp" name="noEmp" placeholder="Numero de Empleado"  minlength="3" maxlength="250" required="required"/>

                        </div>

                    </div>
                    <div class="row col-form-label "></div>
                    <div class="row">
                        <label for="fInicio" class="col-sm-2 col-form-label text-sm-end">Fecha de Inicio</label>
                        <div class="col-sm-3">
                            <input type="text" class="form-control input-group-sm" id="fInicio" name="fInicio" placeholder="Fecha de Inicio" />

                        </div>
                        <label for="fFin" class="col-sm-2 col-form-label text-sm-end">Fecha de Fin</label>
                        <div class="col-sm-3">
                            <input type="text" class="form-control input-group-sm" id="fFin" name="fFin" placeholder="Fecha de Fin" />

                        </div>

                    </div>
                    <div class="row col-form-label "></div>
                    <div class="row">
                        <label for="RetMenB" class="col-sm-2 col-form-label text-sm-end">Retribución Mensual Bruta</label>
                        <div class="col-sm-3">
                            <input type="text" class="form-control input-group-sm" id="RetMenB" name="RetMenB" placeholder="Retribución Mensual Bruta" />

                        </div>
                        <label for="RetMenN" class="col-sm-2 col-form-label text-sm-end">Retribución Mensual Neta</label>
                        <div class="col-sm-3">
                            <input type="text" class="form-control input-group-sm" id="RetMenN" name="RetMenN" placeholder="Retribución Mensual Neta" />

                        </div>

                    </div>
                    <div class="row col-form-label "></div>
                    <div class="row">
                        <label for="pais" class="col-sm-2 col-form-label text-sm-end"><span style="color:red">*</span>Pais</label>
                        <div class="col-sm-8">
                            <input class="form-control input-group-sm" id="pais" name="pais" placeholder="Pais"  minlength="3" maxlength="250" required="required"/>

                        </div>

                    </div>
                    <div class="row col-form-label ">
                    </div>
                    <div class="modal-footer">
                        <div class="row">
                            <div class="col-sm-10">
                                <button type="submit" class="btn btn-primary" id="btnGExpL">Continuar</button>
                            </div>
                            <div class="col-sm-2"></div>
                            <input type="hidden" id="idU" name="idU" value="17"/>
                            <input type="hidden" id="idExL" name="idExL"  value="1"/>
                            <input type="hidden" id="idDp" name="idDp" value="3" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
