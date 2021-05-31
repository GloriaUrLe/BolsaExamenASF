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
    public class Consulta
    {
        [OperationContract]
        public string GetUsers()
        {
            Business.UsuariosManager usuariosManager = new Business.UsuariosManager();
            usuariosManager.ConexionString = System.Configuration.ConfigurationManager.ConnectionStrings["BolEx"].ToString();
            return usuariosManager.GetXmlDataSet();
        }
    }
}
