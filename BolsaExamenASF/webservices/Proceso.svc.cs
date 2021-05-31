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
    public class Proceso
    {
        [OperationContract]
        public string GetSelectedUsers(string idsSelected)
        {

            Business.UsuariosManager usuariosManager = new Business.UsuariosManager();
            usuariosManager.ConexionString = System.Configuration.ConfigurationManager.ConnectionStrings["BolEx"].ToString();
            return usuariosManager.GetXmlDataSetFilteredById(idsSelected);
        }
    }
}
