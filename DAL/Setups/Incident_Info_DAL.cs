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
    public class Incident_Info_DAL:DBInteraction
    {
        Incident_Info_Property objIncidentInfo;
        public Incident_Info_DAL()
        {

        }
        public Incident_Info_DAL(Incident_Info_Property obj_incidentinfo)
        {
            objIncidentInfo = obj_incidentinfo;
        }
        public DataTable CheckIrUserWithLoginUser(LoginProperty objLoginProperty)
        {
            // string query = "select I_Info.IncidentSid,I_Info.CreatedByUserID,I_Info.ReportedByEmailAddress,UI.UserSID,UI.LogonName";
            //  query = query + " from Incident_Info I_Info " + "inner join User_Info UI on I_Info.CreatedByUserID = UI.UserSID where I_Info.IncidentSid=";

            // string query = "select I_Info.IncidentDate, I_Info.IncidentSid,I_Info.CreatedByUserID,I_Info.ReportedByEmailAddress,D.UserSID,D.LogonName, A.DeptID,B.DepartmentLabel,A.FunctionID,A.EmailAddress,A.UserID,D.LogonName as HeadLogon,C.FunctionLabel";
            //query = query + " from DeptFunction_XRef A join Department_Code B on a.DeptID = B.DepartmentSid join FunctionType_Code C on A.FunctionID = C.FunctionSID join User_Info D on A.UserID = D.UserSID inner join Incident_Info I_Info on I_Info.DepartmentId = B.DepartmentSid where I_Info.IncidentSid=";
            // query = query + objLoginProperty.Ir_number;// + " and I_Info.IncidentDate >(SELECT DATEADD(DD," + _PostIncidentClosedFeedbackPeriodInDays + ",CAST( GETDATE() AS Date )))";
            string query = "select * from Incident_Info where IRPhaseId=-3 and IncidentSid=" + objLoginProperty.Ir_number;

            SqlCommand cmdToExecute = new SqlCommand();
            cmdToExecute.CommandText = query;
            cmdToExecute.CommandType = CommandType.Text;
            DataTable toReturn = new DataTable("IrUserCheck");
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmdToExecute;
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

                if (toReturn.Rows.Count > 0)
                {
                    int count = 0;
                    DateTime firstdate = DateTime.Now;
                    foreach(DataRow dr in toReturn.Rows)
                    {
                        firstdate =Convert.ToDateTime(dr["StatusChangeDate"].ToString());
                       

                    }
                    DateTime secnddate = DateTime.Now;
                    count = (secnddate-firstdate  ).Days;
                    int maxday = Convert.ToInt32(_PostIncidentClosedFeedbackPeriodInDays);
                    if (count > maxday)
                    {
                        toReturn= new DataTable();
                    }
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

        public DataTable GetIRInfo()
        {
            string query = "select *, ISNULL((replace (replace(replace(cast(A.[Description]  as nvarchar(4000)),CHAR(13),' '),char(10),' '),CHAR(9),' ')),'') as 'EventDesrciption',A.CreatedByUser,";
            query = query + "ISNULL((replace(replace(replace(cast(C.RootCause as nvarchar(4000)), CHAR(13), ' '), char(10), ' '), CHAR(9), ' ')), '') as 'RootCause',";
            query = query + "ISNULL((replace(replace(replace(cast(C.CorrectiveActions as nvarchar(4000)), CHAR(13), ' '), char(10), ' '), CHAR(9), ' ')), '') as 'CorrectiveActions',";
            query = query + "ISNULL((replace(replace(replace(cast(C.PreventiveActions as nvarchar(4000)), CHAR(13), ' '), char(10), ' '), CHAR(9), ' ')), '') as 'PreventiveActions',";
            query = query + "ISNULL((replace(replace(replace(cast(C.LessonsLearned as nvarchar(4000)), CHAR(13), ' '), char(10), ' '), CHAR(9), ' ')), '') as 'LessonsLearned',";
            query = query + "ISNULL((replace(replace(replace(cast(B.NewValue as nvarchar(4000)), CHAR(13), ' '), char(10), ' '), CHAR(9), ' ')), '') as 'Comment'";
            query = query + " from AKU$_Event_Summary A left join AKU_IRItemAnswer_Info C on A.EventID = C.IncidentID Left join[dbo].[IncidentComments_Aud] B on A.EventID = B.EventID left join User_Info D on D.LogonName=A.CreatedByUser Where ";
            query = query + "A.EventID=" + objIncidentInfo.IncidentSid;// + " and A.EventDate<(SELECT DATEADD(DD,"+ _PostIncidentClosedFeedbackPeriodInDays + ",CAST( GETDATE() AS Date )))";

            SqlCommand cmdToExecute = new SqlCommand();
           cmdToExecute.CommandText = query;
            cmdToExecute.CommandType = CommandType.Text;
            DataTable toReturn = new DataTable("IrUserCheck");
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
                if (toReturn.Rows.Count > 0)
                {
                    objIncidentInfo.IncidentSid =Convert.ToInt32( toReturn.Rows[0]["EventID"].ToString());
                    objIncidentInfo.DEPTSID = Convert.ToInt32(toReturn.Rows[0]["DepartmentID"].ToString());
                    objIncidentInfo.ReportedByEmailAddress= toReturn.Rows[0]["ReportedByEmail"].ToString();
                    objIncidentInfo.CloseDate = Convert.ToDateTime(toReturn.Rows[0]["ReportedByEmail"].ToString());
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
