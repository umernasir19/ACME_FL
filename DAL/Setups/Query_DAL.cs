//using ComplainPortal.Models;
using HrProperty.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Setups
{
   public class Query_DAL:DBInteraction
    {

        QueryProperty objquerymodel;
        public Query_DAL()
        {

        }
        public Query_DAL(QueryProperty obj_querymodel)
        {
            objquerymodel = obj_querymodel;
        }

        public DataTable SelectFromCustomQuery()
        {
            int pagenumber = objquerymodel.PageNumber - 1;
            SqlCommand cmdToExecute = new SqlCommand();
            cmdToExecute.CommandText = objquerymodel.CompleteQuery;// +" OFFSET("+ pagenumber + ") * 10 ROWS FETCH NEXT 50 ROWS ONLY";//"select * from Address_Info ";
            cmdToExecute.CommandType = CommandType.Text;
            DataTable toReturn = new DataTable("CustomQuery");
            SqlDataAdapter adapter = new SqlDataAdapter(cmdToExecute);

            // Use base class' connection object
            cmdToExecute.Connection = _mainConnection;

            try
            {


                if (_mainConnectionIsCreatedLocal)
                {
                    // Open connection.
                    _mainConnection.Open();
                }
                else
                {
                    if (_mainConnectionProvider.IsTransactionPending)
                    {
                        cmdToExecute.Transaction = _mainConnectionProvider.CurrentTransaction;
                    }
                }

                // Execute query.
                adapter.Fill(toReturn);
                //_errorCode = (SqlInt32)cmdToExecute.Parameters["@ErrorCode"].Value;
                //objUserProperty.TotalRowsNum = Convert.ToInt32(cmdToExecute.Parameters["@TotalRowsNum"].Value); //Convert.ToInt32(adapter.SelectCommand.Parameters["@TotalRowsNum"].Value);
                if (_errorCode != (int)LLBLError.AllOk)
                {
                    return toReturn;
                }

                return toReturn;
            }
            catch (Exception ex)
            {

                //objErrorTrace.Error_Msg = (SqlString)ex.Message;
                //objErrorTrace.Error_Proc = "sp_USER_SelectAll";
                //objErrorTrace.Insert();

                //HttpContext.Current.Response.Redirect("~/Error.aspx");


                return toReturn;

            }
            finally
            {
                if (_mainConnectionIsCreatedLocal)
                {
                    // Close connection.
                    _mainConnection.Close();
                }

                cmdToExecute.Dispose();
                adapter.Dispose();
            }
        }
    }
}
