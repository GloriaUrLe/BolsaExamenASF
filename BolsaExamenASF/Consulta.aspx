<%@ Page Language="C#" AutoEventWireup="false" CodeBehind="Consulta.aspx.cs" Inherits="BolsaExamenASF.Consulta" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <title>Consulta</title>
    <script src="Scripts/jquery-3.6.0.js"></script>
    <script src="Scripts/jquery.validate.min.js"></script>
    <script src="Scripts/additional-methods.min.js"></script>
    <script src="Scripts/extendsvalidate.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="CSS/styles.css" rel="stylesheet" />
    <script src="js/Consulta.js"></script>
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
                        <a class="nav-link"  href="RegistroU.aspx">Registro</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link active" aria-current="page" href="#">Consulta Usuarios</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="Salir.aspx">Salir</a>
                    </li>
                </ul>
                <span class="navbar-text">ASF
                </span>
            </div>
        </div>
    </nav>
    <div class="container form-container">
        <div class="container form-container">
            <div class=" form-control modal-content">
                <div class="modal-body row">
                    <form id="formConsulta" method="post" action="Proceso.aspx" >
                        <div class="table-area">
                            <table id="TableUsuarios" class="responsive-table table">
                                <tr>
                                    <th>Seleccione</th>
                                    <th>Usuario</th>
                                    <th>EMail</th>
                                    <th>Fecha Alta</th>
                                </tr>
                            </table>
                        </div>
                    </form>
                    <input type="hidden" id="IdsSelected" />
                    
                </div>
                <div class="row col-form-label "></div>
                <div class="row error-message" id="errorMessage"></div>
                <div class="modal-footer">
                        <div class="row">
                            <div class="col-sm-10">
                                <button type="submit" class="btn btn-primary" id="btnContinue">Continuar</button>
                            </div>
                            <div class="col-sm-2"></div>

                        </div>
                    </div>
            </div>
        </div>
    </div>
</body>
</html>