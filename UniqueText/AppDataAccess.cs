using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace UniqueText
{
    public class AppDataAccess
    {
        SqlConnection scn;

        public List<string> error { get; set; }

        public AppDataAccess(string dBfilePath)
        {
            string constring = @"Data Source=(LocalDB)\v11.0;AttachDbFilename={0};Integrated Security=True";
            scn = new SqlConnection(string.Format(constring, dBfilePath));
            scn.Open();
            error = new List<string>();
        }

        public bool InsertLine(string line_)
        {
            bool success_flag_ = false;
            try
            {
                string cmdInsertstring = "INSERT INTO tbl_sentence VALUES(N'{0}',N'{1}')";
                line_ = line_.Replace("'","''");
                SqlCommand scmd = new SqlCommand(string.Format(cmdInsertstring,line_.Replace(" ", "").ToLower(), line_),scn);
                //scn.Open();
                scmd.ExecuteNonQuery();
                //scn.Close();
                success_flag_ = true;
            }
            catch (Exception ex)
            {
                //scn.Close();
                error.Add(ex.Message);
                success_flag_ = false;
            }
            return success_flag_;
        }

        ~AppDataAccess()
        {
            if (scn.State == ConnectionState.Open) { scn.Close(); }
        }
    }
}
