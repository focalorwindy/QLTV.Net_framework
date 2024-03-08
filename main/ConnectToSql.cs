using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace quanlithuvientruongdaihoc
{
    class ConnectToSql
    {
        #region Available
        private SqlConnection con;
        private SqlCommand _cmd;
        private string StrCon = null;
        private string _error;

        public string Error
        {
            get { return _error; }
            set { _error = value; }
        }

        public SqlConnection Connection
        {
            get { return con; }
            
        }

        public SqlCommand CMD
        {
            get { return _cmd; }
            set { _cmd = value; }
        }
        #endregion
        #region Constructor
        public ConnectToSql()
        {
            StrCon = @"Data Source=LAPTOP-S8PUTIHQ;Initial Catalog=QLTVsoftware;Integrated Security=True";
            con = new SqlConnection(StrCon);
        }
        #endregion

        #region Methods
        public bool openConn()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
            }
            catch (Exception ex)
            {
                _error = ex.Message;
                return false;
            }
            return true;
        }

        public bool CloseConn()
        {
            try
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            catch (Exception ex)
            {
                _error = ex.Message;
                return false;
            }
            return true;
        }

        public DataTable GetData (string sql)
        {
            DataTable de = new DataTable();
            _cmd.CommandText = sql;
            _cmd.CommandType = CommandType.Text;
            _cmd.Connection = con;
            try
            {
                this.openConn();
                SqlDataAdapter sda = new SqlDataAdapter(_cmd);
                sda.Fill(de);
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                _cmd.Dispose();
                this.CloseConn();
            }
            return de;
        }

        public bool SetData (string sql)
        {
            _cmd.CommandText = sql;
            _cmd.CommandType = CommandType.Text;
            _cmd.Connection = con;
            try
            {
                this.openConn();
                _cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                _cmd.Dispose();
                this.CloseConn();
            }
            return false;
        }
        #endregion
    }
}
