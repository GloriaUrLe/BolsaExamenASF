using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace BolsaExamenASF.webservices
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class AdmUsuario
    {
        // Para usar HTTP GET, agregue el atributo [WebGet]. (El valor predeterminado de ResponseFormat es WebMessageFormat.Json)
        // Para crear una operación que devuelva XML,
        //     agregue [WebGet(ResponseFormat=WebMessageFormat.Xml)]
        //     e incluya la siguiente línea en el cuerpo de la operación:
        //         WebOperationContext.Current.OutgoingResponse.ContentType = "text/xml";
       [OperationContract]
        public string AddUsr(string _usr,string _pwd,string _email)
        {
            Data.Usuarios iUsuarios = new Data.Usuarios();
            Business.UsuariosManager iUsuariosManager = new Business.UsuariosManager();
            iUsuariosManager.ConexionString = System.Configuration.ConfigurationManager.ConnectionStrings["BolEx"].ToString();
            iUsuarios.Usuario = _usr;
            iUsuarios.Pass = _pwd;
            iUsuarios.Email = _email;
            iUsuarios.Fecha_Alta = DateTime.Now;
            iUsuariosManager.Add(iUsuarios);
            Int64 idUsr = iUsuarios.Llave_Usuario;
            if (iUsuariosManager.ActionResult)
            {
                return "OK/Proceso completado con éxito/"+ idUsr;

            }
            else
                return "Fail/No se agregó el Registro" + iUsuariosManager.Message + "/0";
        }
        [OperationContract]
        public string AddDP(int _idU,string _nombre, string _paterno, string _materno,string _ciudad,string _calle,string _no,string _colonia,string _tel,string _tel2,string _fecNac, string _curp,string _rfc,string _pasaporte,string _cartilla, string _genero,string _edoCivil,string _mun, string _edo)
        {
            Data.Datos_Personales iDatPer = new Data.Datos_Personales();
            Business.Datos_PersonalesManager iDatPerManager = new Business.Datos_PersonalesManager();
            iDatPerManager.ConexionString = System.Configuration.ConfigurationManager.ConnectionStrings["BolEx"].ToString();

            iDatPer.Llave_Usuario = _idU;
            iDatPer.Nombre = _nombre;
            iDatPer.Paterno = _paterno;
            iDatPer.Materno = _materno;
            iDatPer.Ciudad = _ciudad;
            iDatPer.Calle = _calle;
            iDatPer.Numero = _no;
            iDatPer.Colonia = _colonia;
            iDatPer.Telefono = _tel;
            iDatPer.Otro_Tel = _tel2;
            iDatPer.Fecha_Nac = Convert.ToString(_fecNac);
            iDatPer.CURP = _curp;
            iDatPer.RFC = _rfc;
            iDatPer.Pasaporte = _pasaporte;
            iDatPer.Cartilla = _cartilla;
            iDatPer.Genero = _genero;
            iDatPer.Edo_Civil = _edoCivil;
            iDatPer.Fecha_Alta = DateTime.Now.ToShortDateString();
            iDatPer.Mun = _mun;
            iDatPer.Edo = _edo;
            iDatPerManager.Add(iDatPer);
            Int64 idDp = iDatPer.Llave_Dato_Personal;
            if (iDatPerManager.ActionResult)
            {
                return "OK/Proceso completado con éxito/" + iDatPer.Llave_Usuario + "/"+ idDp;

            }
            else
                return "Fail/No se agregó el Registro" + iDatPerManager.Message + "/0";
        }
        [OperationContract]
        public string AddExpL(int _idU,string _puesto, string _funciones, string _empresa, int _noEmp,string _FeIn,string _FeFin,int _RetMensB,int _RetMensN,string _pais,int _idDP)
        {
            Data.Exp_Laboral iExpLab = new Data.Exp_Laboral();
            Business.Exp_LaboralManager iExpLabManager = new Business.Exp_LaboralManager();
            iExpLabManager.ConexionString = System.Configuration.ConfigurationManager.ConnectionStrings["BolEx"].ToString();
            iExpLab.Llave_Usuario = _idU;
            iExpLab.Puesto = _puesto;
            iExpLab.Funciones = _funciones;
            iExpLab.Empresa = _empresa;
            iExpLab.No_Empleados = _noEmp;
            iExpLab.Fecha_Inicio = _FeIn;
            iExpLab.Fecha_Fin = _FeFin;
            iExpLab.Ret_Mens_Bruta = _RetMensB;
            iExpLab.Ret_Mens_Neta = _RetMensN;
            iExpLab.Fecha_Alta = DateTime.Now.ToShortDateString();
            iExpLab.Pais = _pais;
            iExpLab.Llave_Dato_Personal = _idDP;
            iExpLabManager.Add(iExpLab);
            Int64 idExpL = iExpLab.Llave_Exp_Lab;


            if (iExpLabManager.ActionResult)
            {
                return "OK/La información se guardo correctamente./" + iExpLab.Llave_Usuario + "/" + idExpL;

            }
            else
                return "Fail/No se agregó el Registro" + iExpLabManager.Message + "/0";
        }
    }
}
