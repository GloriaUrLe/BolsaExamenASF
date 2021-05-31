using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Data;

namespace Business
{
    public class Exp_LaboralManager : CommonDataAccess
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
            param.ParameterName = "@IdCurrent";
            param.SqlDbType = SqlDbType.BigInt;
            param.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@LLAVE_USUARIO";
            param.SqlDbType = SqlDbType.BigInt;
            param.Value = _Exp_Laboral.Llave_Usuario;
            param.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@PUESTO";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = _Exp_Laboral.Puesto;
            param.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@FUNCIONES";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = _Exp_Laboral.Funciones;
            param.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@EMPRESA";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = _Exp_Laboral.Empresa;
            param.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@NO_EMPLEADOS";
            param.SqlDbType = SqlDbType.Int;
            param.Value = _Exp_Laboral.No_Empleados;
            param.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@FECHA_INICIO";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = _Exp_Laboral.Fecha_Inicio;
            param.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@FECHA_FIN";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = _Exp_Laboral.Fecha_Fin;
            param.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@RET_MENS_BRUTA";
            param.SqlDbType = SqlDbType.BigInt;
            param.Value = _Exp_Laboral.Ret_Mens_Bruta;
            param.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@RET_MENS_NETA";
            param.SqlDbType = SqlDbType.BigInt;
            param.Value = _Exp_Laboral.Ret_Mens_Neta;
            param.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@FECHA_ALTA";
            param.SqlDbType = SqlDbType.Date;
            param.Value = _Exp_Laboral.Fecha_Alta;
            param.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@PAIS";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = _Exp_Laboral.Pais;
            param.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@LLAVE_DATO_PERSONAL";
            param.SqlDbType = SqlDbType.BigInt;
            param.Value = _Exp_Laboral.Llave_Dato_Personal;
            param.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param);

            base.Add(ref cmd);
            _Exp_Laboral.Llave_Exp_Lab = long.Parse(cmd.Parameters["@IdCurrent"].Value.ToString());
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
            param.SqlDbType = SqlDbType.BigInt;
            param.Value = _Exp_Laboral.Llave_Usuario;
            param.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@PUESTO";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = _Exp_Laboral.Puesto;
            param.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@FUNCIONES";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = _Exp_Laboral.Funciones;
            param.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@EMPRESA";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = _Exp_Laboral.Empresa;
            param.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@NO_EMPLEADOS";
            param.SqlDbType = SqlDbType.Int;
            param.Value = _Exp_Laboral.No_Empleados;
            param.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@FECHA_INICIO";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = _Exp_Laboral.Fecha_Inicio;
            param.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@FECHA_FIN";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = _Exp_Laboral.Fecha_Fin;
            param.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@RET_MENS_BRUTA";
            param.SqlDbType = SqlDbType.BigInt;
            param.Value = _Exp_Laboral.Ret_Mens_Bruta;
            param.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@RET_MENS_NETA";
            param.SqlDbType = SqlDbType.BigInt;
            param.Value = _Exp_Laboral.Ret_Mens_Neta;
            param.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@FECHA_ALTA";
            param.SqlDbType = SqlDbType.Date;
            param.Value = _Exp_Laboral.Fecha_Alta;
            param.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@PAIS";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = _Exp_Laboral.Pais;
            param.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param);

            param = new SqlParameter();
            param.ParameterName = "@LLAVE_DATO_PERSONAL";
            param.SqlDbType = SqlDbType.BigInt;
            param.Value = _Exp_Laboral.Llave_Dato_Personal;
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
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT Exp_Laboral.LLAVE_EXP_LAB,Exp_Laboral.LLAVE_USUARIO,Exp_Laboral.PUESTO,Exp_Laboral.FUNCIONES,Exp_Laboral.EMPRESA,Exp_Laboral.NO_EMPLEADOS,Exp_Laboral.FECHA_INICIO,Exp_Laboral.FECHA_FIN,Exp_Laboral.RET_MENS_BRUTA,Exp_Laboral.RET_MENS_NETA,Exp_Laboral.FECHA_ALTA,Exp_Laboral.PAIS,Exp_Laboral.LLAVE_DATO_PERSONAL FROM Exp_Laboral " + _where, _strConexionString);

            adapter.Fill(dsExp_LaboralManager, "Exp_Laboral");

            foreach (DataRow row in dsExp_LaboralManager.Tables["Exp_Laboral"].Rows)
            {
                _Exp_Laboral.Puesto = (string)row["PUESTO"];
                _Exp_Laboral.Funciones = (string)row["FUNCIONES"];
                _Exp_Laboral.Empresa = (string)row["EMPRESA"];
                _Exp_Laboral.No_Empleados = String.IsNullOrEmpty(row["NO_EMPLEADOS"].ToString()) ? 0 : Int32.Parse(row["NO_EMPLEADOS"].ToString());
                _Exp_Laboral.Fecha_Inicio = (string)row["FECHA_INICIO"];
                _Exp_Laboral.Fecha_Fin = (string)row["FECHA_FIN"];
                _Exp_Laboral.Pais = (string)row["PAIS"];

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
                item.Puesto = (string)row["PUESTO"];
                item.Funciones = (string)row["FUNCIONES"];
                item.Empresa = (string)row["EMPRESA"];
                item.No_Empleados = String.IsNullOrEmpty(row["NO_EMPLEADOS"].ToString()) ? 0 : (Int32)row["NO_EMPLEADOS"];
                item.Fecha_Inicio = (string)row["FECHA_INICIO"];
                item.Fecha_Fin = (string)row["FECHA_FIN"];
                item.Pais = (string)row["PAIS"];

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
