using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Business
{    public class UsuariosManager : CommonDataAccess
    {
        protected DataSet dsUsuariosManager;
        private string _strInsert;
        private Int32 _idCurrent;
        public Int32 idCurrent
        {
            get { return _idCurrent; }
            set { _idCurrent = value; }
        }
        public UsuariosManager()
        {
            dsUsuariosManager = new DataSet();
        }

        public void Add(Usuarios _Usuarios)
        {
            SqlCommand cmd = new SqlCommand();
            SqlParameter param = new SqlParameter();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "stp_Ins_Usuarios";

            param = new SqlParameter();
            param.ParameterName = "@USUARIO";
           param.SqlDbType = SqlDbType.NVarChar;
           param.Value = _Usuarios.USUARIO;
           param.Direction = ParameterDirection.Input;
           cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@PASS";
           param.SqlDbType = SqlDbType.NVarChar;
           param.Value = _Usuarios.PASS;
           param.Direction = ParameterDirection.Input;
           cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@EMAIL";
           param.SqlDbType = SqlDbType.NVarChar;
           param.Value = _Usuarios.EMAIL;
           param.Direction = ParameterDirection.Input;
           cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@FECHA_ALTA";
           param.SqlDbType = SqlDbType.;
           param.Value = _Usuarios.FECHA_ALTA;
           param.Direction = ParameterDirection.Input;
           cmd.Parameters.Add(param);

          base.Add(ref cmd);
        }
        public void Delete(Usuarios _Usuarios, string _Criterio)
{
    SqlCommand cmd = new SqlCommand();
    cmd.CommandType = CommandType.StoredProcedure;
    cmd.CommandText = "stp_Eli_Usuarios";

    SqlParameter param = new SqlParameter();
    param.ParameterName = "@Criterio";
    param.SqlDbType = SqlDbType.NVarChar;
    param.Size = 4000;
    param.Value = " " + _Criterio;
    param.Direction = ParameterDirection.Input;
    cmd.Parameters.Add(param);
    base.Delete(ref cmd);
}
public void Modify(Usuarios _Usuarios, string _Criterio)
{
    SqlCommand cmd = new SqlCommand();
    SqlParameter param = new SqlParameter();
    cmd.CommandType = CommandType.StoredProcedure;
    cmd.CommandText = "stp_Mod_Usuarios";
    param = new SqlParameter();
    param.ParameterName = "@USUARIO";
    param.SqlDbType = SqlDbType.NVarChar;
    param.Value = _Usuarios.USUARIO;
    param.Direction = ParameterDirection.Input;
    cmd.Parameters.Add(param);
    
    param = new SqlParameter();
    param.ParameterName = "@PASS";
    param.SqlDbType = SqlDbType.NVarChar;
    param.Value = _Usuarios.PASS;
    param.Direction = ParameterDirection.Input;
    cmd.Parameters.Add(param);
    
    param = new SqlParameter();
    param.ParameterName = "@EMAIL";
    param.SqlDbType = SqlDbType.NVarChar;
    param.Value = _Usuarios.EMAIL;
    param.Direction = ParameterDirection.Input;
    cmd.Parameters.Add(param);
    
    param = new SqlParameter();
    param.ParameterName = "@FECHA_ALTA";
    param.SqlDbType = SqlDbType.DateTime;
    param.Value = _Usuarios.FECHA_ALTA;
    param.Direction = ParameterDirection.Input;
    cmd.Parameters.Add(param);
    
    param = new SqlParameter();
    param.ParameterName = "@Criterio";
    param.SqlDbType = SqlDbType.NVarChar;
    param.Size = 4000;
    param.Value = " " + _Criterio;
    param.Direction = ParameterDirection.Input;
    cmd.Parameters.Add(param);
   base.Modify(ref cmd);
}
public void Find(ref Usuarios _Usuarios, string _where)
{
     _blnStatus = false;
    SqlDataAdapter adapter = new SqlDataAdapter("SELECT Usuarios.LLAVE_USUARIO,Usuarios.USUARIO,Usuarios.PASS,Usuarios.EMAIL,Usuarios.FECHA_ALTA FROM Usuarios "  + _where  , _strConexionString);

    adapter.Fill(dsUsuariosManager, "Usuarios");

    foreach (DataRow row in dsUsuariosManager.Tables["Usuarios"].Rows)
    {
        _Usuarios.USUARIO = (string)row["USUARIO"];
        _Usuarios.PASS = (string)row["PASS"];
        _Usuarios.EMAIL = (string)row["EMAIL"];
        
    }
}
public List<Usuarios> GetUsuarioss()
{
    List<Usuarios> items = new List<Usuarios>();
    SqlDataAdapter adapter = new SqlDataAdapter("SELECT Usuarios.LLAVE_USUARIO,Usuarios.USUARIO,Usuarios.PASS,Usuarios.EMAIL,Usuarios.FECHA_ALT FROM Usuarios  ", _strConexionString);
    adapter.Fill(dsUsuariosManager, "Usuarios");

    foreach (DataRow row in dsUsuariosManager.Tables["Usuarios"].Rows)
    {
        Usuarios item = new Usuarios();
        item.USUARIO = (string)row["USUARIO"];
        item.PASS = (string)row["PASS"];
        item.EMAIL = (string)row["EMAIL"];
          
        items.Add(item);
    }
    return items;
}
public void createXmlDataSetByTable(string _Path)
{
    ActionResult = true;
    //Crea el directorio si no existe
    FileSystem x = new FileSystem();
    x.CreaDirectorio(_Path);
    if (!String.IsNullOrEmpty(x.error))
    {
        ActionResult = false;
        _strMessage = x.error;
        return;
    }
    //Elimina el archivo XML
    x.EliminaArchivoExistente(@_Path + "Usuarios.xml");

    DataSet dsTbm_Layouts = new DataSet();
    SqlDataAdapter adapter = new SqlDataAdapter("SELECT Usuarios.LLAVE_USUARIO,Usuarios.USUARIO,Usuarios.PASS,Usuarios.EMAIL,Usuarios.FECHA_ALT FROM Usuarios  ", _strConexionString);

    adapter.Fill(dsUsuariosManager, "Row");

    System.IO.StreamWriter xmlSW = new System.IO.StreamWriter(@_Path + "Usuarios.xml");
    dsTbm_Layouts.WriteXml(xmlSW, XmlWriteMode.IgnoreSchema);
    xmlSW.Close();
}
}
}
