using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Data;

namespace Business
{
    public class Datos_PersonalesManager : CommonDataAccess
    {
        protected DataSet dsDatos_PersonalesManager;
        private string _strInsert;
        private Int32 _idCurrent;
        public Int32 idCurrent
        {
            get { return _idCurrent; }
            set { _idCurrent = value; }
        }
        public Datos_PersonalesManager()
        {
            dsDatos_PersonalesManager = new DataSet();
        }

        public void Add(Datos_Personales _Datos_Personales)
        {
            SqlCommand cmd = new SqlCommand();
            SqlParameter param = new SqlParameter();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "stp_Ins_Datos_Personales";

            param = new SqlParameter();
            param.ParameterName = "@IdCurrent";
            param.SqlDbType = SqlDbType.BigInt;
            param.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@LLAVE_USUARIO";
            param.SqlDbType = SqlDbType.BigInt;
            param.Value = _Datos_Personales.Llave_Usuario;
            param.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@NOMBRE";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = _Datos_Personales.Nombre;
            param.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@PATERNO";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = _Datos_Personales.Paterno;
            param.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@MATERNO";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = _Datos_Personales.Materno;
            param.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@CIUDAD";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = _Datos_Personales.Ciudad;
            param.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@CALLE";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = _Datos_Personales.Calle;
            param.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@NUMERO";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = _Datos_Personales.Numero;
            param.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@COLONIA";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = _Datos_Personales.Colonia;
            param.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@TELEFONO";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = _Datos_Personales.Telefono;
            param.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@OTRO_TEL";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = _Datos_Personales.Otro_Tel;
            param.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@FECHA_NAC";
            param.SqlDbType = SqlDbType.Date;
            param.Value = _Datos_Personales.Fecha_Alta;
            param.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@CURP";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = _Datos_Personales.CURP;
            param.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@RFC";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = _Datos_Personales.RFC;
            param.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@PASAPORTE";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = _Datos_Personales.Pasaporte;
            param.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@CARTILLA";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = _Datos_Personales.Cartilla;
            param.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@GENERO";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = _Datos_Personales.Genero;
            param.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@EDO_CIVIL";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = _Datos_Personales.Edo_Civil;
            param.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@FECHA_ALTA";
            param.SqlDbType = SqlDbType.Date;
            param.Value = _Datos_Personales.Fecha_Alta;
            param.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@MUN";
            param.SqlDbType = SqlDbType.VarChar;
            param.Value = _Datos_Personales.Mun;
            param.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@EDO";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = _Datos_Personales.Edo;
            param.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param);

            base.Add(ref cmd);
            _Datos_Personales.Llave_Dato_Personal = long.Parse(cmd.Parameters["@IdCurrent"].Value.ToString());
        }
        public void Delete(Datos_Personales _Datos_Personales, string _Criterio)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "stp_Eli_Datos_Personales";

            SqlParameter param = new SqlParameter();
            param.ParameterName = "@Criterio";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Size = 4000;
            param.Value = " " + _Criterio;
            param.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param);
            base.Delete(ref cmd);
        }
        public void Modify(Datos_Personales _Datos_Personales, string _Criterio)
        {
            SqlCommand cmd = new SqlCommand();
            SqlParameter param = new SqlParameter();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "stp_Mod_Datos_Personales";
            param = new SqlParameter();
            param.ParameterName = "@LLAVE_USUARIO";
            param.SqlDbType = SqlDbType.BigInt;
            param.Value = _Datos_Personales.Llave_Usuario;
            param.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@NOMBRE";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = _Datos_Personales.Nombre;
            param.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@PATERNO";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = _Datos_Personales.Paterno;
            param.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@MATERNO";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = _Datos_Personales.Materno;
            param.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@CIUDAD";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = _Datos_Personales.Ciudad;
            param.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@CALLE";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = _Datos_Personales.Calle;
            param.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@NUMERO";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = _Datos_Personales.Numero;
            param.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@COLONIA";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = _Datos_Personales.Colonia;
            param.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@TELEFONO";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = _Datos_Personales.Telefono;
            param.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@OTRO_TEL";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = _Datos_Personales.Otro_Tel;
            param.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@FECHA_NAC";
            param.SqlDbType = SqlDbType.DateTime;
            param.Value = _Datos_Personales.Fecha_Nac;
            param.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@CURP";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = _Datos_Personales.CURP;
            param.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@RFC";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = _Datos_Personales.RFC;
            param.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@PASAPORTE";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = _Datos_Personales.Pasaporte;
            param.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@CARTILLA";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = _Datos_Personales.Cartilla;
            param.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@GENERO";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = _Datos_Personales.Genero;
            param.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@EDO_CIVIL";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = _Datos_Personales.Edo_Civil;
            param.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@FECHA_ALTA";
            param.SqlDbType = SqlDbType.DateTime;
            param.Value = _Datos_Personales.Fecha_Alta;
            param.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@MUN";
            param.SqlDbType = SqlDbType.VarChar;
            param.Value = _Datos_Personales.Mun;
            param.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@EDO";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = _Datos_Personales.Edo;
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
        public void Find(ref Datos_Personales _Datos_Personales, string _where)
        {
            _blnStatus = false;
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Datos_Personales.LLAVE_DATO_PERSONAL,Datos_Personales.LLAVE_USUARIO,Datos_Personales.NOMBRE,Datos_Personales.PATERNO,Datos_Personales.MATERNO,Datos_Personales.CIUDAD,Datos_Personales.CALLE,Datos_Personales.NUMERO,Datos_Personales.COLONIA,Datos_Personales.TELEFONO,Datos_Personales.OTRO_TEL,Datos_Personales.FECHA_NAC,Datos_Personales.CURP,Datos_Personales.RFC,Datos_Personales.PASAPORTE,Datos_Personales.CARTILLA,Datos_Personales.GENERO,Datos_Personales.EDO_CIVIL,Datos_Personales.FECHA_ALTA,Datos_Personales.MUN,Datos_Personales.EDO FROM Datos_Personales " + _where, _strConexionString);

            adapter.Fill(dsDatos_PersonalesManager, "Datos_Personales");

            foreach (DataRow row in dsDatos_PersonalesManager.Tables["Datos_Personales"].Rows)
            {
                _Datos_Personales.Nombre = (string)row["NOMBRE"];
                _Datos_Personales.Paterno = (string)row["PATERNO"];
                _Datos_Personales.Materno = (string)row["MATERNO"];
                _Datos_Personales.Ciudad = (string)row["CIUDAD"];
                _Datos_Personales.Calle = (string)row["CALLE"];
                _Datos_Personales.Numero = (string)row["NUMERO"];
                _Datos_Personales.Colonia = (string)row["COLONIA"];
                _Datos_Personales.Telefono = (string)row["TELEFONO"];
                _Datos_Personales.Otro_Tel = (string)row["OTRO_TEL"];
                _Datos_Personales.CURP = (string)row["CURP"];
                _Datos_Personales.RFC = (string)row["RFC"];
                _Datos_Personales.Pasaporte = (string)row["PASAPORTE"];
                _Datos_Personales.Cartilla = (string)row["CARTILLA"];
                _Datos_Personales.Genero = (string)row["GENERO"];
                _Datos_Personales.Edo_Civil = (string)row["EDO_CIVIL"];
                _Datos_Personales.Mun = (string)row["MUN"];
                _Datos_Personales.Edo = (string)row["EDO"];

            }
        }
        public List<Datos_Personales> GetDatos_Personaless()
        {
            List<Datos_Personales> items = new List<Datos_Personales>();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Datos_Personales.LLAVE_DATO_PERSONAL,Datos_Personales.LLAVE_USUARIO,Datos_Personales.NOMBRE,Datos_Personales.PATERNO,Datos_Personales.MATERNO,Datos_Personales.CIUDAD,Datos_Personales.CALLE,Datos_Personales.NUMERO,Datos_Personales.COLONIA,Datos_Personales.TELEFONO,Datos_Personales.OTRO_TEL,Datos_Personales.FECHA_NAC,Datos_Personales.CURP,Datos_Personales.RFC,Datos_Personales.PASAPORTE,Datos_Personales.CARTILLA,Datos_Personales.GENERO,Datos_Personales.EDO_CIVIL,Datos_Personales.FECHA_ALTA,Datos_Personales.MUN,Datos_Personales.ED FROM Datos_Personales  ", _strConexionString);
            adapter.Fill(dsDatos_PersonalesManager, "Datos_Personales");

            foreach (DataRow row in dsDatos_PersonalesManager.Tables["Datos_Personales"].Rows)
            {
                Datos_Personales item = new Datos_Personales();
                item.Nombre = (string)row["NOMBRE"];
                item.Paterno = (string)row["PATERNO"];
                item.Materno = (string)row["MATERNO"];
                item.Ciudad = (string)row["CIUDAD"];
                item.Calle = (string)row["CALLE"];
                item.Numero = (string)row["NUMERO"];
                item.Colonia = (string)row["COLONIA"];
                item.Telefono = (string)row["TELEFONO"];
                item.Otro_Tel = (string)row["OTRO_TEL"];
                item.CURP = (string)row["CURP"];
                item.RFC = (string)row["RFC"];
                item.Pasaporte = (string)row["PASAPORTE"];
                item.Cartilla = (string)row["CARTILLA"];
                item.Genero = (string)row["GENERO"];
                item.Edo_Civil = (string)row["EDO_CIVIL"];
                item.Mun = (string)row["MUN"];
                item.Edo = (string)row["EDO"];

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
            x.EliminaArchivoExistente(@_Path + "Datos_Personales.xml");

            DataSet dsTbm_Layouts = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Datos_Personales.LLAVE_DATO_PERSONAL,Datos_Personales.LLAVE_USUARIO,Datos_Personales.NOMBRE,Datos_Personales.PATERNO,Datos_Personales.MATERNO,Datos_Personales.CIUDAD,Datos_Personales.CALLE,Datos_Personales.NUMERO,Datos_Personales.COLONIA,Datos_Personales.TELEFONO,Datos_Personales.OTRO_TEL,Datos_Personales.FECHA_NAC,Datos_Personales.CURP,Datos_Personales.RFC,Datos_Personales.PASAPORTE,Datos_Personales.CARTILLA,Datos_Personales.GENERO,Datos_Personales.EDO_CIVIL,Datos_Personales.FECHA_ALTA,Datos_Personales.MUN,Datos_Personales.ED FROM Datos_Personales  ", _strConexionString);

            adapter.Fill(dsDatos_PersonalesManager, "Row");

            System.IO.StreamWriter xmlSW = new System.IO.StreamWriter(@_Path + "Datos_Personales.xml");
            dsTbm_Layouts.WriteXml(xmlSW, XmlWriteMode.IgnoreSchema);
            xmlSW.Close();
        }
    }
}
