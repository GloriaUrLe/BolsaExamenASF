using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Business
{    public class Datos_PersonaleManager : CommonDataAccess
    {
        protected DataSet dsDatos_PersonaleManager;
        private string _strInsert;
        private Int32 _idCurrent;
        public Int32 idCurrent
        {
            get { return _idCurrent; }
            set { _idCurrent = value; }
        }
        public Datos_PersonaleManager()
        {
            dsDatos_PersonaleManager = new DataSet();
        }

        public void Add(Datos_Personale _Datos_Personale)
        {
            SqlCommand cmd = new SqlCommand();
            SqlParameter param = new SqlParameter();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "stp_Ins_Datos_Personale";

            param = new SqlParameter();
            param.ParameterName = "@LLAVE_USUARIO";
           param.SqlDbType = SqlDbType.;
           param.Value = _Datos_Personale.LLAVE_USUARIO;
           param.Direction = ParameterDirection.Input;
           cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@NOMBRE";
           param.SqlDbType = SqlDbType.NVarChar;
           param.Value = _Datos_Personale.NOMBRE;
           param.Direction = ParameterDirection.Input;
           cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@PATERNO";
           param.SqlDbType = SqlDbType.NVarChar;
           param.Value = _Datos_Personale.PATERNO;
           param.Direction = ParameterDirection.Input;
           cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@MATERNO";
           param.SqlDbType = SqlDbType.NVarChar;
           param.Value = _Datos_Personale.MATERNO;
           param.Direction = ParameterDirection.Input;
           cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@CIUDAD";
           param.SqlDbType = SqlDbType.NVarChar;
           param.Value = _Datos_Personale.CIUDAD;
           param.Direction = ParameterDirection.Input;
           cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@CALLE";
           param.SqlDbType = SqlDbType.NVarChar;
           param.Value = _Datos_Personale.CALLE;
           param.Direction = ParameterDirection.Input;
           cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@NUMERO";
           param.SqlDbType = SqlDbType.NVarChar;
           param.Value = _Datos_Personale.NUMERO;
           param.Direction = ParameterDirection.Input;
           cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@COLONIA";
           param.SqlDbType = SqlDbType.NVarChar;
           param.Value = _Datos_Personale.COLONIA;
           param.Direction = ParameterDirection.Input;
           cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@TELEFONO";
           param.SqlDbType = SqlDbType.NVarChar;
           param.Value = _Datos_Personale.TELEFONO;
           param.Direction = ParameterDirection.Input;
           cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@OTRO_TEL";
           param.SqlDbType = SqlDbType.NVarChar;
           param.Value = _Datos_Personale.OTRO_TEL;
           param.Direction = ParameterDirection.Input;
           cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@FECHA_NAC";
           param.SqlDbType = SqlDbType.;
           param.Value = _Datos_Personale.FECHA_NAC;
           param.Direction = ParameterDirection.Input;
           cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@CURP";
           param.SqlDbType = SqlDbType.NVarChar;
           param.Value = _Datos_Personale.CURP;
           param.Direction = ParameterDirection.Input;
           cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@RFC";
           param.SqlDbType = SqlDbType.NVarChar;
           param.Value = _Datos_Personale.RFC;
           param.Direction = ParameterDirection.Input;
           cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@PASAPORTE";
           param.SqlDbType = SqlDbType.NVarChar;
           param.Value = _Datos_Personale.PASAPORTE;
           param.Direction = ParameterDirection.Input;
           cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@CARTILLA";
           param.SqlDbType = SqlDbType.NVarChar;
           param.Value = _Datos_Personale.CARTILLA;
           param.Direction = ParameterDirection.Input;
           cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@GENERO";
           param.SqlDbType = SqlDbType.NVarChar;
           param.Value = _Datos_Personale.GENERO;
           param.Direction = ParameterDirection.Input;
           cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@EDO_CIVIL";
           param.SqlDbType = SqlDbType.NVarChar;
           param.Value = _Datos_Personale.EDO_CIVIL;
           param.Direction = ParameterDirection.Input;
           cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@FECHA_ALTA";
           param.SqlDbType = SqlDbType.;
           param.Value = _Datos_Personale.FECHA_ALTA;
           param.Direction = ParameterDirection.Input;
           cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@MUN";
           param.SqlDbType = SqlDbType.VarChar;
           param.Value = _Datos_Personale.MUN;
           param.Direction = ParameterDirection.Input;
           cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@EDO";
           param.SqlDbType = SqlDbType.NVarChar;
           param.Value = _Datos_Personale.EDO;
           param.Direction = ParameterDirection.Input;
           cmd.Parameters.Add(param);

          base.Add(ref cmd);
        }
        public void Delete(Datos_Personale _Datos_Personale, string _Criterio)
{
    SqlCommand cmd = new SqlCommand();
    cmd.CommandType = CommandType.StoredProcedure;
    cmd.CommandText = "stp_Eli_Datos_Personale";

    SqlParameter param = new SqlParameter();
    param.ParameterName = "@Criterio";
    param.SqlDbType = SqlDbType.NVarChar;
    param.Size = 4000;
    param.Value = " " + _Criterio;
    param.Direction = ParameterDirection.Input;
    cmd.Parameters.Add(param);
    base.Delete(ref cmd);
}
public void Modify(Datos_Personale _Datos_Personale, string _Criterio)
{
    SqlCommand cmd = new SqlCommand();
    SqlParameter param = new SqlParameter();
    cmd.CommandType = CommandType.StoredProcedure;
    cmd.CommandText = "stp_Mod_Datos_Personale";
    param = new SqlParameter();
    param.ParameterName = "@LLAVE_USUARIO";
    param.SqlDbType = SqlDbType.;
    param.Value = _Datos_Personale.LLAVE_USUARIO;
    param.Direction = ParameterDirection.Input;
    cmd.Parameters.Add(param);
    
    param = new SqlParameter();
    param.ParameterName = "@NOMBRE";
    param.SqlDbType = SqlDbType.NVarChar;
    param.Value = _Datos_Personale.NOMBRE;
    param.Direction = ParameterDirection.Input;
    cmd.Parameters.Add(param);
    
    param = new SqlParameter();
    param.ParameterName = "@PATERNO";
    param.SqlDbType = SqlDbType.NVarChar;
    param.Value = _Datos_Personale.PATERNO;
    param.Direction = ParameterDirection.Input;
    cmd.Parameters.Add(param);
    
    param = new SqlParameter();
    param.ParameterName = "@MATERNO";
    param.SqlDbType = SqlDbType.NVarChar;
    param.Value = _Datos_Personale.MATERNO;
    param.Direction = ParameterDirection.Input;
    cmd.Parameters.Add(param);
    
    param = new SqlParameter();
    param.ParameterName = "@CIUDAD";
    param.SqlDbType = SqlDbType.NVarChar;
    param.Value = _Datos_Personale.CIUDAD;
    param.Direction = ParameterDirection.Input;
    cmd.Parameters.Add(param);
    
    param = new SqlParameter();
    param.ParameterName = "@CALLE";
    param.SqlDbType = SqlDbType.NVarChar;
    param.Value = _Datos_Personale.CALLE;
    param.Direction = ParameterDirection.Input;
    cmd.Parameters.Add(param);
    
    param = new SqlParameter();
    param.ParameterName = "@NUMERO";
    param.SqlDbType = SqlDbType.NVarChar;
    param.Value = _Datos_Personale.NUMERO;
    param.Direction = ParameterDirection.Input;
    cmd.Parameters.Add(param);
    
    param = new SqlParameter();
    param.ParameterName = "@COLONIA";
    param.SqlDbType = SqlDbType.NVarChar;
    param.Value = _Datos_Personale.COLONIA;
    param.Direction = ParameterDirection.Input;
    cmd.Parameters.Add(param);
    
    param = new SqlParameter();
    param.ParameterName = "@TELEFONO";
    param.SqlDbType = SqlDbType.NVarChar;
    param.Value = _Datos_Personale.TELEFONO;
    param.Direction = ParameterDirection.Input;
    cmd.Parameters.Add(param);
    
    param = new SqlParameter();
    param.ParameterName = "@OTRO_TEL";
    param.SqlDbType = SqlDbType.NVarChar;
    param.Value = _Datos_Personale.OTRO_TEL;
    param.Direction = ParameterDirection.Input;
    cmd.Parameters.Add(param);
    
    param = new SqlParameter();
    param.ParameterName = "@FECHA_NAC";
    param.SqlDbType = SqlDbType.;
    param.Value = _Datos_Personale.FECHA_NAC;
    param.Direction = ParameterDirection.Input;
    cmd.Parameters.Add(param);
    
    param = new SqlParameter();
    param.ParameterName = "@CURP";
    param.SqlDbType = SqlDbType.NVarChar;
    param.Value = _Datos_Personale.CURP;
    param.Direction = ParameterDirection.Input;
    cmd.Parameters.Add(param);
    
    param = new SqlParameter();
    param.ParameterName = "@RFC";
    param.SqlDbType = SqlDbType.NVarChar;
    param.Value = _Datos_Personale.RFC;
    param.Direction = ParameterDirection.Input;
    cmd.Parameters.Add(param);
    
    param = new SqlParameter();
    param.ParameterName = "@PASAPORTE";
    param.SqlDbType = SqlDbType.NVarChar;
    param.Value = _Datos_Personale.PASAPORTE;
    param.Direction = ParameterDirection.Input;
    cmd.Parameters.Add(param);
    
    param = new SqlParameter();
    param.ParameterName = "@CARTILLA";
    param.SqlDbType = SqlDbType.NVarChar;
    param.Value = _Datos_Personale.CARTILLA;
    param.Direction = ParameterDirection.Input;
    cmd.Parameters.Add(param);
    
    param = new SqlParameter();
    param.ParameterName = "@GENERO";
    param.SqlDbType = SqlDbType.NVarChar;
    param.Value = _Datos_Personale.GENERO;
    param.Direction = ParameterDirection.Input;
    cmd.Parameters.Add(param);
    
    param = new SqlParameter();
    param.ParameterName = "@EDO_CIVIL";
    param.SqlDbType = SqlDbType.NVarChar;
    param.Value = _Datos_Personale.EDO_CIVIL;
    param.Direction = ParameterDirection.Input;
    cmd.Parameters.Add(param);
    
    param = new SqlParameter();
    param.ParameterName = "@FECHA_ALTA";
    param.SqlDbType = SqlDbType.DateTime;
    param.Value = _Datos_Personale.FECHA_ALTA;
    param.Direction = ParameterDirection.Input;
    cmd.Parameters.Add(param);
    
    param = new SqlParameter();
    param.ParameterName = "@MUN";
    param.SqlDbType = SqlDbType.VarChar;
    param.Value = _Datos_Personale.MUN;
    param.Direction = ParameterDirection.Input;
    cmd.Parameters.Add(param);
    
    param = new SqlParameter();
    param.ParameterName = "@EDO";
    param.SqlDbType = SqlDbType.NVarChar;
    param.Value = _Datos_Personale.EDO;
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
public void Find(ref Datos_Personale _Datos_Personale, string _where)
{
     _blnStatus = false;
    SqlDataAdapter adapter = new SqlDataAdapter("SELECT Datos_Personale.LLAVE_DATO_PERSONAL,Datos_Personale.LLAVE_USUARIO,Datos_Personale.NOMBRE,Datos_Personale.PATERNO,Datos_Personale.MATERNO,Datos_Personale.CIUDAD,Datos_Personale.CALLE,Datos_Personale.NUMERO,Datos_Personale.COLONIA,Datos_Personale.TELEFONO,Datos_Personale.OTRO_TEL,Datos_Personale.FECHA_NAC,Datos_Personale.CURP,Datos_Personale.RFC,Datos_Personale.PASAPORTE,Datos_Personale.CARTILLA,Datos_Personale.GENERO,Datos_Personale.EDO_CIVIL,Datos_Personale.FECHA_ALTA,Datos_Personale.MUN,Datos_Personale.EDO FROM Datos_Personale "  + _where  , _strConexionString);

    adapter.Fill(dsDatos_PersonaleManager, "Datos_Personale");

    foreach (DataRow row in dsDatos_PersonaleManager.Tables["Datos_Personale"].Rows)
    {
        _Datos_Personale.NOMBRE = (string)row["NOMBRE"];
        _Datos_Personale.PATERNO = (string)row["PATERNO"];
        _Datos_Personale.MATERNO = (string)row["MATERNO"];
        _Datos_Personale.CIUDAD = (string)row["CIUDAD"];
        _Datos_Personale.CALLE = (string)row["CALLE"];
        _Datos_Personale.NUMERO = (string)row["NUMERO"];
        _Datos_Personale.COLONIA = (string)row["COLONIA"];
        _Datos_Personale.TELEFONO = (string)row["TELEFONO"];
        _Datos_Personale.OTRO_TEL = (string)row["OTRO_TEL"];
        _Datos_Personale.CURP = (string)row["CURP"];
        _Datos_Personale.RFC = (string)row["RFC"];
        _Datos_Personale.PASAPORTE = (string)row["PASAPORTE"];
        _Datos_Personale.CARTILLA = (string)row["CARTILLA"];
        _Datos_Personale.GENERO = (string)row["GENERO"];
        _Datos_Personale.EDO_CIVIL = (string)row["EDO_CIVIL"];
        _Datos_Personale.MUN = (string)row["MUN"];
        _Datos_Personale.EDO = (string)row["EDO"];
        
    }
}
public List<Datos_Personale> GetDatos_Personales()
{
    List<Datos_Personale> items = new List<Datos_Personale>();
    SqlDataAdapter adapter = new SqlDataAdapter("SELECT Datos_Personale.LLAVE_DATO_PERSONAL,Datos_Personale.LLAVE_USUARIO,Datos_Personale.NOMBRE,Datos_Personale.PATERNO,Datos_Personale.MATERNO,Datos_Personale.CIUDAD,Datos_Personale.CALLE,Datos_Personale.NUMERO,Datos_Personale.COLONIA,Datos_Personale.TELEFONO,Datos_Personale.OTRO_TEL,Datos_Personale.FECHA_NAC,Datos_Personale.CURP,Datos_Personale.RFC,Datos_Personale.PASAPORTE,Datos_Personale.CARTILLA,Datos_Personale.GENERO,Datos_Personale.EDO_CIVIL,Datos_Personale.FECHA_ALTA,Datos_Personale.MUN,Datos_Personale.ED FROM Datos_Personale  ", _strConexionString);
    adapter.Fill(dsDatos_PersonaleManager, "Datos_Personale");

    foreach (DataRow row in dsDatos_PersonaleManager.Tables["Datos_Personale"].Rows)
    {
        Datos_Personale item = new Datos_Personale();
        item.NOMBRE = (string)row["NOMBRE"];
        item.PATERNO = (string)row["PATERNO"];
        item.MATERNO = (string)row["MATERNO"];
        item.CIUDAD = (string)row["CIUDAD"];
        item.CALLE = (string)row["CALLE"];
        item.NUMERO = (string)row["NUMERO"];
        item.COLONIA = (string)row["COLONIA"];
        item.TELEFONO = (string)row["TELEFONO"];
        item.OTRO_TEL = (string)row["OTRO_TEL"];
        item.CURP = (string)row["CURP"];
        item.RFC = (string)row["RFC"];
        item.PASAPORTE = (string)row["PASAPORTE"];
        item.CARTILLA = (string)row["CARTILLA"];
        item.GENERO = (string)row["GENERO"];
        item.EDO_CIVIL = (string)row["EDO_CIVIL"];
         item.MUN = (string)row["MUN"];
        item.EDO = (string)row["EDO"];
          
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
    x.EliminaArchivoExistente(@_Path + "Datos_Personale.xml");

    DataSet dsTbm_Layouts = new DataSet();
    SqlDataAdapter adapter = new SqlDataAdapter("SELECT Datos_Personale.LLAVE_DATO_PERSONAL,Datos_Personale.LLAVE_USUARIO,Datos_Personale.NOMBRE,Datos_Personale.PATERNO,Datos_Personale.MATERNO,Datos_Personale.CIUDAD,Datos_Personale.CALLE,Datos_Personale.NUMERO,Datos_Personale.COLONIA,Datos_Personale.TELEFONO,Datos_Personale.OTRO_TEL,Datos_Personale.FECHA_NAC,Datos_Personale.CURP,Datos_Personale.RFC,Datos_Personale.PASAPORTE,Datos_Personale.CARTILLA,Datos_Personale.GENERO,Datos_Personale.EDO_CIVIL,Datos_Personale.FECHA_ALTA,Datos_Personale.MUN,Datos_Personale.ED FROM Datos_Personale  ", _strConexionString);

    adapter.Fill(dsDatos_PersonaleManager, "Row");

    System.IO.StreamWriter xmlSW = new System.IO.StreamWriter(@_Path + "Datos_Personale.xml");
    dsTbm_Layouts.WriteXml(xmlSW, XmlWriteMode.IgnoreSchema);
    xmlSW.Close();
}
}
}
