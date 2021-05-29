using System.Data.SqlClient;

namespace Business
{
    abstract public class CommonDataAccess
    {
        protected bool _blnStatus;
        protected string _strMessage;
        protected string _strConexionString;
        protected bool _blnFound;

        public string Message
        {
            get
            {
                return _strMessage;
            }
            set
            {
                _strMessage = value;
            }
        }

        public bool ActionResult
        {
            get
            {
                return _blnStatus;
            }
            set
            {
                _blnStatus = value;
            }
        }
        public bool Found
        {
            get
            {
                return _blnFound;
            }
            set
            {
                _blnFound = value;
            }
        }
        public string ConexionString
        {
            get
            {
                return _strConexionString;
            }
            set
            {
                _strConexionString = value;
            }
        }
        public virtual void Add(ref SqlCommand _cmd)
        {
            using (DataBaseLayer.Rutines oData = new DataBaseLayer.Rutines())
            {
                oData.ConnectionString = _strConexionString;
                oData.ExecuteStoreProcedure(ref _cmd);
                ActionResult = oData.ActionResult;
                Message = oData.Error;
            }
        }
        public virtual void Delete(ref SqlCommand _cmd)
        {
            using (DataBaseLayer.Rutines oData = new DataBaseLayer.Rutines())
            {
                oData.ConnectionString = _strConexionString;
                oData.ExecuteStoreProcedure(ref _cmd);
                ActionResult = oData.ActionResult;
                Message = oData.Error;
            }

        }
        public virtual void Modify(ref SqlCommand _cmd)
        {
            using (DataBaseLayer.Rutines oData = new DataBaseLayer.Rutines())
            {
                oData.ConnectionString = _strConexionString;
                oData.ExecuteStoreProcedure(ref _cmd);
                ActionResult = oData.ActionResult;
                Message = oData.Error;
            }

        }


    }
}
