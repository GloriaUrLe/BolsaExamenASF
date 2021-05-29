using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Business
{    public class Exp_LaboralManager : CommonDataAccess
    {
        protected DataSet dsExp_LaboralManager;
        private string _strInsert;
        private Int32 _idCurrent;
        public Int32 idCurrent
        {
            get { return _idCurrent; }
            set { _idCurrent = value; }
        }
        public Exp_LaboralManager()
        {
            dsExp_LaboralManager = new DataSet();
        }

        public void Add(Exp_Laboral _Exp_Laboral)
        {
            SqlCommand cmd = new SqlCommand();
            SqlParameter param = new SqlParameter();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "stp_Ins_Exp_Laboral";

            param = new SqlParameter();
            param.ParameterName = "@LLAVE_USUARIO";
           param.SqlDbType = SqlDbType.;
           param.Value = _Exp_Laboral.LLAVE_USUARIO;
           param.Direction = ParameterDirection.Input;
           cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@PUESTO";
           param.SqlDbType = SqlDbType.NVarChar;
           param.Value = _Exp_Laboral.PUESTO;
           param.Direction = ParameterDirection.Input;
           cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@FUNCIONES";
           param.SqlDbType = SqlDbType.NVarChar;
           param.Value = _Exp_Laboral.FUNCIONES;
           param.Direction = ParameterDirection.Input;
           cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@EMPRESA";
           param.SqlDbType = SqlDbType.NVarChar;
           param.Value = _Exp_Laboral.EMPRESA;
           param.Direction = ParameterDirection.Input;
           cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@NO_EMPLEADOS";
           param.SqlDbType = SqlDbType.Int;
           param.Value = _Exp_Laboral.NO_EMPLEADOS;
           param.Direction = ParameterDirection.Input;
           cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@FECHA_INICIO";
           param.SqlDbType = SqlDbType.NVarChar;
           param.Value = _Exp_Laboral.FECHA_INICIO;
           param.Direction = ParameterDirection.Input;
           cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@FECHA_FIN";
           param.SqlDbType = SqlDbType.NVarChar;
           param.Value = _Exp_Laboral.FECHA_FIN;
           param.Direction = ParameterDirection.Input;
           cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@RET_MENS_BRUTA";
           param.SqlDbType = SqlDbType.;
           param.Value = _Exp_Laboral.RET_MENS_BRUTA;
           param.Direction = ParameterDirection.Input;
           cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@RET_MENS_NETA";
           param.SqlDbType = SqlDbType.;
           param.Value = _Exp_Laboral.RET_MENS_NETA;
           param.Direction = ParameterDirection.Input;
           cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@FECHA_ALTA";
           param.SqlDbType = SqlDbType.;
           param.Value = _Exp_Laboral.FECHA_ALTA;
           param.Direction = ParameterDirection.Input;
           cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@PAIS";
           param.SqlDbType = SqlDbType.NVarChar;
           param.Value = _Exp_Laboral.PAIS;
           param.Direction = ParameterDirection.Input;
           cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@LLAVE_DATO_PERSONAL";
           param.SqlDbType = SqlDbType.;
           param.Value = _Exp_Laboral.LLAVE_DATO_PERSONAL;
           param.Direction = ParameterDirection.Input;
           cmd.Parameters.Add(param);

          base.Add(ref cmd);
        }
        public void Delete(Exp_Laboral _Exp_Laboral, string _Criterio)
{
    SqlCommand cmd = new SqlCommand();
    cmd.CommandType = CommandType.StoredProcedure;
    cmd.CommandText = "stp_Eli_Exp_Laboral";

    SqlParameter param = new SqlParameter();
    param.ParameterName = "@Criterio";
    param.SqlDbType = SqlDbType.NVarChar;
    param.Size = 4000;
    param.Value = " " + _Criterio;
    param.Direction = ParameterDirection.Input;
    cmd.Parameters.Add(param);
    base.Delete(ref cmd);
}
public void Modify(Exp_Laboral _Exp_Laboral, string _Criterio)
{
    SqlCommand cmd = new SqlCommand();
    SqlParameter param = new SqlParameter();
    cmd.CommandType = CommandType.StoredProcedure;
    cmd.CommandText = "stp_Mod_Exp_Laboral";
    param = new SqlParameter();
    param.ParameterName = "@LLAVE_USUARIO";
    param.SqlDbType = SqlDbType.;
    param.Value = _Exp_Laboral.LLAVE_USUARIO;
    param.Direction = ParameterDirection.Input;
    cmd.Parameters.Add(param);
    
    param = new SqlParameter();
    param.ParameterName = "@PUESTO";
    param.SqlDbType = SqlDbType.NVarChar;
    param.Value = _Exp_Laboral.PUESTO;
    param.Direction = ParameterDirection.Input;
    cmd.Parameters.Add(param);
    
    param = new SqlParameter();
    param.ParameterName = "@FUNCIONES";
    param.SqlDbType = SqlDbType.NVarChar;
    param.Value = _Exp_Laboral.FUNCIONES;
    param.Direction = ParameterDirection.Input;
    cmd.Parameters.Add(param);
    
    param = new SqlParameter();
    param.ParameterName = "@EMPRESA";
    param.SqlDbType = SqlDbType.NVarChar;
    param.Value = _Exp_Laboral.EMPRESA;
    param.Direction = ParameterDirection.Input;
    cmd.Parameters.Add(param);
    
    param = new SqlParameter();
    param.ParameterName = "@NO_EMPLEADOS";
    param.SqlDbType = SqlDbType.Int;
    param.Value = _Exp_Laboral.NO_EMPLEADOS;
    param.Direction = ParameterDirection.Input;
    cmd.Parameters.Add(param);
    
    param = new SqlParameter();
    param.ParameterName = "@FECHA_INICIO";
    param.SqlDbType = SqlDbType.NVarChar;
    param.Value = _Exp_Laboral.FECHA_INICIO;
    param.Direction = ParameterDirection.Input;
    cmd.Parameters.Add(param);
    
    param = new SqlParameter();
    param.ParameterName = "@FECHA_FIN";
    param.SqlDbType = SqlDbType.NVarChar;
    param.Value = _Exp_Laboral.FECHA_FIN;
    param.Direction = ParameterDirection.Input;
    cmd.Parameters.Add(param);
    
    param = new SqlParameter();
    param.ParameterName = "@RET_MENS_BRUTA";
    param.SqlDbType = SqlDbType.;
    param.Value = _Exp_Laboral.RET_MENS_BRUTA;
    param.Direction = ParameterDirection.Input;
    cmd.Parameters.Add(param);
    
    param = new SqlParameter();
    param.ParameterName = "@RET_MENS_NETA";
    param.SqlDbType = SqlDbType.;
    param.Value = _Exp_Laboral.RET_MENS_NETA;
    param.Direction = ParameterDirection.Input;
    cmd.Parameters.Add(param);
    
    param = new SqlParameter();
    param.ParameterName = "@FECHA_ALTA";
    param.SqlDbType = SqlDbType.;
    param.Value = _Exp_Laboral.FECHA_ALTA;
    param.Direction = ParameterDirection.Input;
    cmd.Parameters.Add(param);
    
    param = new SqlParameter();
    param.ParameterName = "@PAIS";
    param.SqlDbType = SqlDbType.NVarChar;
    param.Value = _Exp_Laboral.PAIS;
    param.Direction = ParameterDirection.Input;
    cmd.Parameters.Add(param);
    
    param = new SqlParameter();
    param.ParameterName = "@LLAVE_DATO_PERSONAL";
    param.SqlDbType = SqlDbType.;
    param.Value = _Exp_Laboral.LLAVE_DATO_PERSONAL;
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
public void Find(ref Exp_Laboral _Exp_Laboral, string _where)
{
     _blnStatus = false;
    SqlDataAdapter adapter = new SqlDataAdapter("SELECT Exp_Laboral.LLAVE_EXP_LAB,Exp_Laboral.LLAVE_USUARIO,Exp_Laboral.PUESTO,Exp_Laboral.FUNCIONES,Exp_Laboral.EMPRESA,Exp_Laboral.NO_EMPLEADOS,Exp_Laboral.FECHA_INICIO,Exp_Laboral.FECHA_FIN,Exp_Laboral.RET_MENS_BRUTA,Exp_Laboral.RET_MENS_NETA,Exp_Laboral.FECHA_ALTA,Exp_Laboral.PAIS,Exp_Laboral.LLAVE_DATO_PERSONAL FROM Exp_Laboral "  + _where  , _strConexionString);

    adapter.Fill(dsExp_LaboralManager, "Exp_Laboral");

    foreach (DataRow row in dsExp_LaboralManager.Tables["Exp_Laboral"].Rows)
    {
        _Exp_Laboral.PUESTO = (string)row["PUESTO"];
        _Exp_Laboral.FUNCIONES = (string)row["FUNCIONES"];
        _Exp_Laboral.EMPRESA = (string)row["EMPRESA"];
        _Exp_Laboral.NO_EMPLEADOS = String.IsNullOrEmpty(row["NO_EMPLEADOS"].ToString()) ? 0 : Int32.Parse(row["NO_EMPLEADOS"].ToString());
        _Exp_Laboral.FECHA_INICIO = (string)row["FECHA_INICIO"];
        _Exp_Laboral.FECHA_FIN = (string)row["FECHA_FIN"];
        _Exp_Laboral.PAIS = (string)row["PAIS"];
        
    }
}
public List<Exp_Laboral> GetExp_Laborals()
{
    List<Exp_Laboral> items = new List<Exp_Laboral>();
    SqlDataAdapter adapter = new SqlDataAdapter("SELECT Exp_Laboral.LLAVE_EXP_LAB,Exp_Laboral.LLAVE_USUARIO,Exp_Laboral.PUESTO,Exp_Laboral.FUNCIONES,Exp_Laboral.EMPRESA,Exp_Laboral.NO_EMPLEADOS,Exp_Laboral.FECHA_INICIO,Exp_Laboral.FECHA_FIN,Exp_Laboral.RET_MENS_BRUTA,Exp_Laboral.RET_MENS_NETA,Exp_Laboral.FECHA_ALTA,Exp_Laboral.PAIS,Exp_Laboral.LLAVE_DATO_PERSONA FROM Exp_Laboral  ", _strConexionString);
    adapter.Fill(dsExp_LaboralManager, "Exp_Laboral");

    foreach (DataRow row in dsExp_LaboralManager.Tables["Exp_Laboral"].Rows)
    {
        Exp_Laboral item = new Exp_Laboral();
        item.PUESTO = (string)row["PUESTO"];
        item.FUNCIONES = (string)row["FUNCIONES"];
        item.EMPRESA = (string)row["EMPRESA"];
        item.NO_EMPLEADOS = String.IsNullOrEmpty(row["NO_EMPLEADOS"].ToString()) ? 0 : (Int32)row["NO_EMPLEADOS"];
        item.FECHA_INICIO = (string)row["FECHA_INICIO"];
        item.FECHA_FIN = (string)row["FECHA_FIN"];
        item.PAIS = (string)row["PAIS"];
          
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
    x.EliminaArchivoExistente(@_Path + "Exp_Laboral.xml");

    DataSet dsTbm_Layouts = new DataSet();
    SqlDataAdapter adapter = new SqlDataAdapter("SELECT Exp_Laboral.LLAVE_EXP_LAB,Exp_Laboral.LLAVE_USUARIO,Exp_Laboral.PUESTO,Exp_Laboral.FUNCIONES,Exp_Laboral.EMPRESA,Exp_Laboral.NO_EMPLEADOS,Exp_Laboral.FECHA_INICIO,Exp_Laboral.FECHA_FIN,Exp_Laboral.RET_MENS_BRUTA,Exp_Laboral.RET_MENS_NETA,Exp_Laboral.FECHA_ALTA,Exp_Laboral.PAIS,Exp_Laboral.LLAVE_DATO_PERSONA FROM Exp_Laboral  ", _strConexionString);

    adapter.Fill(dsExp_LaboralManager, "Row");

    System.IO.StreamWriter xmlSW = new System.IO.StreamWriter(@_Path + "Exp_Laboral.xml");
    dsTbm_Layouts.WriteXml(xmlSW, XmlWriteMode.IgnoreSchema);
    xmlSW.Close();
}
}
}
