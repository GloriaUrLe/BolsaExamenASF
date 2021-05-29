using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Business
{
    public class Rutines : IDisposable
    {

        SqlConnection conn = new SqlConnection();
        public string ConnectionString { get; set; }
        public string Error { get; set; }
        public bool ActionResult { get; set; }
        private bool disposed = false;
       
        private bool abreConexion()
        {
            conn.ConnectionString = ConnectionString;

            try
            {
                conn.Open();
                return true;
            }
            catch (Exception)
            {
                
                return false;
            }
                

        }
        

        private bool cierraConexion()
        {
            try
            {
                conn.Close();
                return true;
            }
            catch (Exception)
            {

                return false;
            }


        }

       

        public void ExecuteStoreProcedure(ref SqlCommand _cmd)
        {
            if (abreConexion())
            {
                _cmd.CommandType = CommandType.StoredProcedure;
                _cmd.Connection = conn;
                try
                {
                    _cmd.ExecuteNonQuery();
                    ActionResult = true;

                }
                catch (Exception ex)
                {

                    ActionResult = false;
                    Error = ex.Message;
                                            
                }
               
                cierraConexion();
            }
                           
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                     conn.Dispose();
                }
                disposed = true;
            }
        }
    }
}
