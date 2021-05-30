<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroU.aspx.cs" Inherits="BolsaExamenASF.Registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Usuario</title>
    <script src="Scripts/jquery-3.6.0.js"></script>
    <script src="Scripts/jquery.validate.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <link href="Content/bootstrap.css" rel="stylesheet" />
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

    <form id="SecUsr" method="get">
        <div class="container">
            <div class=" form-control modal-content">
                <div class="modal-body row">
                    <div class="row col-form-label "><span>Los campos marcados con <span style="color:red">*</span> son requeridos</span></div>
                    <div class="row col-form-label "></div>
                    <div class="row">
                        <label for="Usr" class="col-sm-2 col-form-label text-sm-end"><span style="color:red">*</span>Usuario</label>
                        <div class="col-sm-8">
                            <input type="text" class="form-control input-group-sm" id="Usr" name="Usr" placeholder="Usuario"  minlength="5" maxlength="250" required="required" />

                        </div>

                    </div>
                    <div class="row col-form-label "></div>
                    <div class="row">
                        <label for="Pass" class="col-sm-2 col-form-label text-sm-end"><span style="color:red">*</span>Password</label>
                        <div class="col-sm-8">
                            <input type="password" class="form-control input-group-sm" id="Pass" placeholder="Password" minlength="8" maxlength="12" required="required" />

                        </div>

                    </div>
                    <div class="row col-form-label ">
                    </div>
                    <div class="row">
                        <label for="Email" class="col-sm-2 col-form-label text-sm-end"><span style="color:red">*</span>Email</label>
                        <div class="col-sm-8">
                            <input type="email" class="form-control" id="Email" placeholder="Email" required="required"/>

                        </div>

                    </div>
                    <div class="row col-form-label ">
                    </div>
                    <div class="modal-footer">
                        <div class="row">
                            <div class="col-sm-10">
                                <button type="submit" class="btn btn-primary" id="btnGUsr">Continuar</button>
                            </div>
                            <div class="col-sm-2"></div>

                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
