using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DataAccessLayer
{
    public class DataAccessSQL
    {
        public static string sqlcn = ConfigurationManager.ConnectionStrings["NORTHWNDConnectionString1"].ConnectionString;
        
        public static DataTable ExecuteSelectCommand(string CommandName, CommandType cmdType)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(sqlcn))
            {
                SqlCommand cmd = new SqlCommand(CommandName, cn);
                cmd.CommandType = cmdType;
                try
                {
                    cn.Open();
                    SqlDataAdapter da = null;
                    using (da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    cmd.Dispose();
                    cmd = null;
                    cn.Close();
                }
                return dt;
            }
        }

        public static DataTable ExecuteParamSelectCommand(string CommandName, CommandType cmdType, SqlParameter[] param)
        {
            DataTable dt = new DataTable();
            using (SqlConnection cn = new SqlConnection(sqlcn))
            {
                SqlCommand cmd = new SqlCommand(CommandName, cn);
                cmd.CommandType = cmdType;
                cmd.Parameters.AddRange(param);
                try
                {
                    if (cn.State != ConnectionState.Open)
                    {
                        cn.Open();
                    }
                    SqlDataAdapter da = null;
                    using (da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    cmd.Dispose();
                    cmd = null;
                    cn.Close();
                }
                return dt;
            }
        }

        public static bool ExecuteNonQuery(string commandName, CommandType cmdType, SqlParameter[] param)
        {
            int result = 0;
            using (SqlConnection cn = new SqlConnection(sqlcn))
            {
                SqlCommand cmd = new SqlCommand(commandName, cn);
                cmd.CommandType = cmdType;
                cmd.Parameters.AddRange(param);
                try
                {
                    if (cn.State != ConnectionState.Open)
                    {
                        cn.Open();
                    }
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    cmd.Dispose();
                    cmd = null;
                    cn.Close();
                }
            }

            if (result > 0)
            {
                return true;
            }
            return false;
        }

    }
}
