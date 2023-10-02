using HrProperty.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Setups
{
   public class Feedback_DAL: DBInteraction
    {
        AKU_UserIncidentFeedback_Property objfeedbackproperty;


        public Feedback_DAL()
        {

        }
        public Feedback_DAL(AKU_UserIncidentFeedback_Property obj_feedbackproperty)
        {
            objfeedbackproperty = obj_feedbackproperty;
        }

        public override bool Insert()
        {
            SqlCommand cmdToExecute = new SqlCommand();
         ///   cmdToExecute.CommandText = "dbo.[sp_LOCATIONS_SETUP_Insert]";
           // cmdToExecute.CommandType = CommandType.StoredProcedure;

            // Use base class' connection object
            cmdToExecute.Connection = _mainConnection;

            try
            {
                //cmdToExecute.Parameters.Add(new SqlParameter("@Location_Code", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Location_Code));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Location_Short_Name", SqlDbType.VarChar, 100, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Location_Short_Name));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Location_Name", SqlDbType.VarChar, 200, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Location_Name));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Parent_Location_ID", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Parent_Location_ID));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Company_ID", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Company_ID));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Pos_Type_ID", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Pos_Type_ID));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Sub_Pos_Type_ID", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Sub_Pos_Type_ID));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Shop_No", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Shop_No));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Market_Name", SqlDbType.NVarChar, 30, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Market_Name));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Street", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Street));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Police_Station", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Police_Station));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Post_Code", SqlDbType.NVarChar, 10, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Post_Code));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Phone_No", SqlDbType.NVarChar, 20, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Phone_No));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Fax_No", SqlDbType.NVarChar, 20, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Fax_No));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Email", SqlDbType.NVarChar, 20, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Email));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Company_Turnover", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Company_Turnover));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Total_Turnover", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Total_Turnover));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Amount_Limit", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Amount_Limit));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Owner_Name", SqlDbType.NVarChar, 30, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Owner_Name));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Owner_NIC", SqlDbType.NVarChar, 17, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Owner_NIC));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Counter_Sale", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Counter_Sale));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Is_Location_POS", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Is_Location_POS));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Status", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Status));
                //cmdToExecute.Parameters.Add(new SqlParameter("@iID", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.ID));
                //cmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, _errorCode));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Record_Table_Name", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.TableName));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Operation", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Operation));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Operated_By", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Operated_By));
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

                this.StartTransaction();
               // cmdToExecute.Transaction = this.Transaction;
                // Execute query.
                //_rowsAffected = cmdToExecute.ExecuteNonQuery();
                // _iD = (Int32)cmdToExecute.Parameters["@iID"].Value;
                //_errorCode = cmdToExecute.Parameters["@ErrorCode"].Value;

                if (objfeedbackproperty.DetailData != null)
                {
                    //foreach (DataRow row in objPurchaseRequisitionMaster_Property.DetailData.Rows)
                    //    row["PurchaseMaster_Id"] = cmdToExecute.Parameters["@ID"].Value.ToString();

                    objfeedbackproperty.DetailData.AcceptChanges();

                    SqlBulkCopy sbc = new SqlBulkCopy(_mainConnection, SqlBulkCopyOptions.Default, this.Transaction);
                    objfeedbackproperty.DetailData.TableName = "AKU_UserIncidentFeedback";

                    sbc.ColumnMappings.Clear();
                    sbc.ColumnMappings.Add("UserSID", "UserSID");
                    //sbc.ColumnMappings.Add(2, 1);
                    sbc.ColumnMappings.Add("IncidentSID", "IncidentSID");
                    sbc.ColumnMappings.Add("IncidentCloseDate", "IncidentCloseDate");
                    sbc.ColumnMappings.Add("IncidentDeptSID", "IncidentDeptSID");
                    sbc.ColumnMappings.Add("LogonId", "LogonId");
                    sbc.ColumnMappings.Add("StatusFg", "StatusFg");
                    sbc.ColumnMappings.Add("CreateDate", "CreateDate");
                    sbc.ColumnMappings.Add("UpateByNm", "UpateByNm");
                    sbc.ColumnMappings.Add("UserStatisfyFg", "UserStatisfyFg");
                    sbc.ColumnMappings.Add("RequesterFeedback", "RequesterFeedback");
                    sbc.ColumnMappings.Add("ClosuerFeedback", "ClosuerFeedback");
                    sbc.ColumnMappings.Add("IncidentReOpenFg", "IncidentReOpenFg");
                    sbc.ColumnMappings.Add("RequestorFg", "RequestorFg");

                    sbc.DestinationTableName = objfeedbackproperty.DetailData.TableName;
                    sbc.WriteToServer(objfeedbackproperty.DetailData);

                }

                this.Commit();
                if (_errorCode != (int)LLBLError.AllOk)
                {
                    // Throw error.
                    this.RollBack();
                    throw new Exception("Stored Procedure 'sp_TRANSACTION_MASTER_Insert' reported the ErrorCode: " + _errorCode);

                }

                return true;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                //throw new Exception("LOCATIONS_SETUP::Insert::Error occured.", ex);
                return false;
            }
            finally
            {
                if (_mainConnectionIsCreatedLocal)
                {
                    // Close connection.
                    _mainConnection.Close();
                }
                cmdToExecute.Dispose();
            }
        }

        public  bool InsertAttachment(AKU_UserIncidentFeedbackAttmnt_Property objattachmnt)
        {
            SqlCommand cmdToExecute = new SqlCommand();
            ///   cmdToExecute.CommandText = "dbo.[sp_LOCATIONS_SETUP_Insert]";
            // cmdToExecute.CommandType = CommandType.StoredProcedure;

            // Use base class' connection object
            cmdToExecute.Connection = _mainConnection;

            try
            {
                //cmdToExecute.Parameters.Add(new SqlParameter("@Location_Code", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Location_Code));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Location_Short_Name", SqlDbType.VarChar, 100, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Location_Short_Name));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Location_Name", SqlDbType.VarChar, 200, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Location_Name));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Parent_Location_ID", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Parent_Location_ID));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Company_ID", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Company_ID));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Pos_Type_ID", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Pos_Type_ID));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Sub_Pos_Type_ID", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Sub_Pos_Type_ID));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Shop_No", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Shop_No));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Market_Name", SqlDbType.NVarChar, 30, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Market_Name));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Street", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Street));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Police_Station", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Police_Station));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Post_Code", SqlDbType.NVarChar, 10, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Post_Code));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Phone_No", SqlDbType.NVarChar, 20, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Phone_No));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Fax_No", SqlDbType.NVarChar, 20, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Fax_No));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Email", SqlDbType.NVarChar, 20, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Email));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Company_Turnover", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Company_Turnover));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Total_Turnover", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Total_Turnover));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Amount_Limit", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Amount_Limit));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Owner_Name", SqlDbType.NVarChar, 30, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Owner_Name));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Owner_NIC", SqlDbType.NVarChar, 17, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Owner_NIC));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Counter_Sale", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Counter_Sale));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Is_Location_POS", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Is_Location_POS));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Status", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Status));
                //cmdToExecute.Parameters.Add(new SqlParameter("@iID", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.ID));
                //cmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, _errorCode));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Record_Table_Name", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.TableName));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Operation", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Operation));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Operated_By", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Operated_By));
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

                this.StartTransaction();
                // cmdToExecute.Transaction = this.Transaction;
                // Execute query.
                //_rowsAffected = cmdToExecute.ExecuteNonQuery();
                // _iD = (Int32)cmdToExecute.Parameters["@iID"].Value;
                //_errorCode = cmdToExecute.Parameters["@ErrorCode"].Value;

                if (objattachmnt.DetailData != null)
                {
                    //foreach (DataRow row in objPurchaseRequisitionMaster_Property.DetailData.Rows)
                    //    row["PurchaseMaster_Id"] = cmdToExecute.Parameters["@ID"].Value.ToString();

                    objattachmnt.DetailData.AcceptChanges();

                    SqlBulkCopy sbc = new SqlBulkCopy(_mainConnection, SqlBulkCopyOptions.Default, this.Transaction);
                    objattachmnt.DetailData.TableName = "AKU_UserFeedbackAttachments";

                    sbc.ColumnMappings.Clear();
                    sbc.ColumnMappings.Add("AttachementID", "AttachementID");
                    sbc.ColumnMappings.Add("LogonId", "LogonId");
                    //sbc.ColumnMappings.Add(2, 1);
                    sbc.ColumnMappings.Add("IncidentSID", "IncidentSID");
                    sbc.ColumnMappings.Add("IncidentCloseDate", "IncidentCloseDate");
                    sbc.ColumnMappings.Add("AttachementDescription", "AttachementDescription");
                    sbc.ColumnMappings.Add("AttachmentPath", "AttachmentPath");
                    //sbc.ColumnMappings.Add("IncidentDeptSID", "IncidentDeptSID");
                    //sbc.ColumnMappings.Add("LogonId", "LogonId");
                    //sbc.ColumnMappings.Add("StatusFg", "StatusFg");
                    //sbc.ColumnMappings.Add("CreateDate", "CreateDate");
                    //sbc.ColumnMappings.Add("UpateByNm", "UpateByNm");
                    //sbc.ColumnMappings.Add("UserStatisfyFg", "UserStatisfyFg");
                    //sbc.ColumnMappings.Add("RequesterFeedback", "RequesterFeedback");
                    //sbc.ColumnMappings.Add("ClosuerFeedback", "ClosuerFeedback");
                    //sbc.ColumnMappings.Add("IncidentReOpenFg", "IncidentReOpenFg");


                    sbc.DestinationTableName = objattachmnt.DetailData.TableName;
                    sbc.WriteToServer(objattachmnt.DetailData);

                }

                this.Commit();
                if (_errorCode != (int)LLBLError.AllOk)
                {
                    // Throw error.
                    this.RollBack();
                    throw new Exception("Stored Procedure 'sp_TRANSACTION_MASTER_Insert' reported the ErrorCode: " + _errorCode);

                }

                return true;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("LOCATIONS_SETUP::Insert::Error occured.", ex);
            }
            finally
            {
                if (_mainConnectionIsCreatedLocal)
                {
                    // Close connection.
                    _mainConnection.Close();
                }
                cmdToExecute.Dispose();
            }
        }
        public DataTable GetAllFeedback()
        {
            string query = "select case when A.StatusFg='C' then 'Completed' else 'Pending' end  'FSTATUS',case when A.RequestorFg='Y' then 'Yes' else 'NO' end  'FeedbackbyRequestor',* from AKU_UserIncidentFeedback A inner join User_Info B on A.UserSID=B.UserSID";
            //query = query + "ISNULL((replace(replace(replace(cast(C.RootCause as nvarchar(4000)), CHAR(13), ' '), char(10), ' '), CHAR(9), ' ')), '') as 'RootCause',";
            //query = query + "ISNULL((replace(replace(replace(cast(C.CorrectiveActions as nvarchar(4000)), CHAR(13), ' '), char(10), ' '), CHAR(9), ' ')), '') as 'CorrectiveActions',";
            //query = query + "ISNULL((replace(replace(replace(cast(C.PreventiveActions as nvarchar(4000)), CHAR(13), ' '), char(10), ' '), CHAR(9), ' ')), '') as 'PreventiveActions',";
            //query = query + "ISNULL((replace(replace(replace(cast(C.LessonsLearned as nvarchar(4000)), CHAR(13), ' '), char(10), ' '), CHAR(9), ' ')), '') as 'LessonsLearned',";
            //query = query + "ISNULL((replace(replace(replace(cast(B.NewValue as nvarchar(4000)), CHAR(13), ' '), char(10), ' '), CHAR(9), ' ')), '') as 'Comment'";
            //query = query + " from AKU$_Event_Summary A left join AKU_IRItemAnswer_Info C on A.EventID = C.IncidentID Left join[dbo].[IncidentComments_Aud] B on A.EventID = B.EventID left join User_Info D on D.LogonName=A.CreatedByUser Where ";
            //query = query + "A.EventID=" + objIncidentInfo.IncidentSid;//+ " and A.EventDate>(SELECT DATEADD(DD,"+ _PostIncidentClosedFeedbackPeriodInDays + ",CAST( GETDATE() AS Date )))";

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
                    //objIncidentInfo.IncidentSid = Convert.ToInt32(toReturn.Rows[0]["EventID"].ToString());
                    //objIncidentInfo.ReportedByEmailAddress = toReturn.Rows[0]["ReportedByEmail"].ToString();
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
        public DataTable CheckFfedBackByID(int id)
        {
            string query = "select  * from AKU_UserIncidentFeedback A left join AKU_UserFeedbackAttachments B on A.IncidentSID=B.IncidentSID and A.IncidentCloseDate=B.IncidentCloseDate where A.IncidentSID=" + id;
            //query = query + "ISNULL((replace(replace(replace(cast(C.RootCause as nvarchar(4000)), CHAR(13), ' '), char(10), ' '), CHAR(9), ' ')), '') as 'RootCause',";
            //query = query + "ISNULL((replace(replace(replace(cast(C.CorrectiveActions as nvarchar(4000)), CHAR(13), ' '), char(10), ' '), CHAR(9), ' ')), '') as 'CorrectiveActions',";
            //query = query + "ISNULL((replace(replace(replace(cast(C.PreventiveActions as nvarchar(4000)), CHAR(13), ' '), char(10), ' '), CHAR(9), ' ')), '') as 'PreventiveActions',";
            //query = query + "ISNULL((replace(replace(replace(cast(C.LessonsLearned as nvarchar(4000)), CHAR(13), ' '), char(10), ' '), CHAR(9), ' ')), '') as 'LessonsLearned',";
            //query = query + "ISNULL((replace(replace(replace(cast(B.NewValue as nvarchar(4000)), CHAR(13), ' '), char(10), ' '), CHAR(9), ' ')), '') as 'Comment'";
            //query = query + " from AKU$_Event_Summary A left join AKU_IRItemAnswer_Info C on A.EventID = C.IncidentID Left join[dbo].[IncidentComments_Aud] B on A.EventID = B.EventID left join User_Info D on D.LogonName=A.CreatedByUser Where ";
            //query = query + "A.EventID=" + objIncidentInfo.IncidentSid;//+ " and A.EventDate>(SELECT DATEADD(DD,"+ _PostIncidentClosedFeedbackPeriodInDays + ",CAST( GETDATE() AS Date )))";

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
                    //objIncidentInfo.IncidentSid = Convert.ToInt32(toReturn.Rows[0]["EventID"].ToString());
                    //objIncidentInfo.ReportedByEmailAddress = toReturn.Rows[0]["ReportedByEmail"].ToString();
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

        public DataTable GetLastAttachmentID()
        {
            string query = "select Top 1 AttachementID from[dbo].[AKU_UserFeedbackAttachments] order by AttachementID desc";
            //query = query + "ISNULL((replace(replace(replace(cast(C.RootCause as nvarchar(4000)), CHAR(13), ' '), char(10), ' '), CHAR(9), ' ')), '') as 'RootCause',";
            //query = query + "ISNULL((replace(replace(replace(cast(C.CorrectiveActions as nvarchar(4000)), CHAR(13), ' '), char(10), ' '), CHAR(9), ' ')), '') as 'CorrectiveActions',";
            //query = query + "ISNULL((replace(replace(replace(cast(C.PreventiveActions as nvarchar(4000)), CHAR(13), ' '), char(10), ' '), CHAR(9), ' ')), '') as 'PreventiveActions',";
            //query = query + "ISNULL((replace(replace(replace(cast(C.LessonsLearned as nvarchar(4000)), CHAR(13), ' '), char(10), ' '), CHAR(9), ' ')), '') as 'LessonsLearned',";
            //query = query + "ISNULL((replace(replace(replace(cast(B.NewValue as nvarchar(4000)), CHAR(13), ' '), char(10), ' '), CHAR(9), ' ')), '') as 'Comment'";
            //query = query + " from AKU$_Event_Summary A left join AKU_IRItemAnswer_Info C on A.EventID = C.IncidentID Left join[dbo].[IncidentComments_Aud] B on A.EventID = B.EventID left join User_Info D on D.LogonName=A.CreatedByUser Where ";
            //query = query + "A.EventID=" + objIncidentInfo.IncidentSid;//+ " and A.EventDate>(SELECT DATEADD(DD,"+ _PostIncidentClosedFeedbackPeriodInDays + ",CAST( GETDATE() AS Date )))";

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
                    //objIncidentInfo.IncidentSid = Convert.ToInt32(toReturn.Rows[0]["EventID"].ToString());
                    //objIncidentInfo.ReportedByEmailAddress = toReturn.Rows[0]["ReportedByEmail"].ToString();
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

        public override bool Update()
        {
            SqlCommand cmdToExecute = new SqlCommand();
             cmdToExecute.CommandText = "update AKU_UserIncidentFeedback set StatusFg='"+objfeedbackproperty.StatusFg+ "' , UpateByNm='"+objfeedbackproperty.LogonId+ "', UpdateDate='"+DateTime.Now+ "' , RequesterFeedback='"+objfeedbackproperty.RequesterFeedback+ "', ClosuerReOpenFg='"+objfeedbackproperty.ClosuerReOpenFg+"' where IncidentSID='" + objfeedbackproperty.IncidentSID+ "' and IncidentCloseDate='"+objfeedbackproperty.IncidentCloseDate+ "' and UserSID='"+objfeedbackproperty.UserSID+"'";
            cmdToExecute.CommandType = CommandType.Text;

            // Use base class' connection object
            cmdToExecute.Connection = _mainConnection;

            try
            {
                //cmdToExecute.Parameters.Add(new SqlParameter("@Location_Code", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Location_Code));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Location_Short_Name", SqlDbType.VarChar, 100, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Location_Short_Name));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Location_Name", SqlDbType.VarChar, 200, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Location_Name));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Parent_Location_ID", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Parent_Location_ID));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Company_ID", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Company_ID));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Pos_Type_ID", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Pos_Type_ID));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Sub_Pos_Type_ID", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Sub_Pos_Type_ID));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Shop_No", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Shop_No));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Market_Name", SqlDbType.NVarChar, 30, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Market_Name));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Street", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Street));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Police_Station", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Police_Station));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Post_Code", SqlDbType.NVarChar, 10, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Post_Code));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Phone_No", SqlDbType.NVarChar, 20, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Phone_No));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Fax_No", SqlDbType.NVarChar, 20, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Fax_No));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Email", SqlDbType.NVarChar, 20, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Email));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Company_Turnover", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Company_Turnover));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Total_Turnover", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Total_Turnover));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Amount_Limit", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Amount_Limit));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Owner_Name", SqlDbType.NVarChar, 30, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Owner_Name));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Owner_NIC", SqlDbType.NVarChar, 17, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Owner_NIC));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Counter_Sale", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Counter_Sale));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Is_Location_POS", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Is_Location_POS));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Status", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Status));
                //cmdToExecute.Parameters.Add(new SqlParameter("@iID", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.ID));
                //cmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, _errorCode));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Record_Table_Name", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.TableName));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Operation", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Operation));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Operated_By", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Operated_By));
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

                //this.StartTransaction();
                //// cmdToExecute.Transaction = this.Transaction;
                //// Execute query.
                ////_rowsAffected = cmdToExecute.ExecuteNonQuery();
                //// _iD = (Int32)cmdToExecute.Parameters["@iID"].Value;
                ////_errorCode = cmdToExecute.Parameters["@ErrorCode"].Value;

                //if (objfeedbackproperty.DetailData != null)
                //{
                //    //foreach (DataRow row in objPurchaseRequisitionMaster_Property.DetailData.Rows)
                //    //    row["PurchaseMaster_Id"] = cmdToExecute.Parameters["@ID"].Value.ToString();

                //    objfeedbackproperty.DetailData.AcceptChanges();

                //    SqlBulkCopy sbc = new SqlBulkCopy(_mainConnection, SqlBulkCopyOptions.Default, this.Transaction);
                //    objfeedbackproperty.DetailData.TableName = "AKU_UserIncidentFeedback";

                //    sbc.ColumnMappings.Clear();
                //    sbc.ColumnMappings.Add("UserSID", "UserSID");
                //    //sbc.ColumnMappings.Add(2, 1);
                //    sbc.ColumnMappings.Add("IncidentSID", "IncidentSID");
                //    sbc.ColumnMappings.Add("IncidentCloseDate", "IncidentCloseDate");
                //    sbc.ColumnMappings.Add("IncidentDeptSID", "IncidentDeptSID");
                //    sbc.ColumnMappings.Add("LogonId", "LogonId");
                //    sbc.ColumnMappings.Add("StatusFg", "StatusFg");
                //    sbc.ColumnMappings.Add("CreateDate", "CreateDate");
                //    sbc.ColumnMappings.Add("UpateByNm", "UpateByNm");
                //    sbc.ColumnMappings.Add("UserStatisfyFg", "UserStatisfyFg");
                //    sbc.ColumnMappings.Add("RequesterFeedback", "RequesterFeedback");
                //    sbc.ColumnMappings.Add("ClosuerFeedback", "ClosuerFeedback");
                //    sbc.ColumnMappings.Add("IncidentReOpenFg", "IncidentReOpenFg");


                //    sbc.DestinationTableName = objfeedbackproperty.DetailData.TableName;
                //    sbc.WriteToServer(objfeedbackproperty.DetailData);

                //}
                cmdToExecute.ExecuteNonQuery();
              //  this.Commit();
                if (_errorCode != (int)LLBLError.AllOk)
                {
                    // Throw error.
                  //  this.RollBack();
                    throw new Exception("Stored Procedure 'sp_TRANSACTION_MASTER_Insert' reported the ErrorCode: " + _errorCode);

                }

                return true;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("LOCATIONS_SETUP::Insert::Error occured.", ex);
            }
            finally
            {
                if (_mainConnectionIsCreatedLocal)
                {
                    // Close connection.
                    _mainConnection.Close();
                }
                cmdToExecute.Dispose();
            }
        }

        public DataTable CheckFeedbackExists()
        {
            string query = "Select * from AKU_UserIncidentFeedback A where A.IncidentSID='" + objfeedbackproperty.IncidentSID + "' and A.IncidentCloseDate='" + objfeedbackproperty.IncidentCloseDate + "'";
            //query = query + "ISNULL((replace(replace(replace(cast(C.RootCause as nvarchar(4000)), CHAR(13), ' '), char(10), ' '), CHAR(9), ' ')), '') as 'RootCause',";
            //query = query + "ISNULL((replace(replace(replace(cast(C.CorrectiveActions as nvarchar(4000)), CHAR(13), ' '), char(10), ' '), CHAR(9), ' ')), '') as 'CorrectiveActions',";
            //query = query + "ISNULL((replace(replace(replace(cast(C.PreventiveActions as nvarchar(4000)), CHAR(13), ' '), char(10), ' '), CHAR(9), ' ')), '') as 'PreventiveActions',";
            //query = query + "ISNULL((replace(replace(replace(cast(C.LessonsLearned as nvarchar(4000)), CHAR(13), ' '), char(10), ' '), CHAR(9), ' ')), '') as 'LessonsLearned',";
            //query = query + "ISNULL((replace(replace(replace(cast(B.NewValue as nvarchar(4000)), CHAR(13), ' '), char(10), ' '), CHAR(9), ' ')), '') as 'Comment'";
            //query = query + " from AKU$_Event_Summary A left join AKU_IRItemAnswer_Info C on A.EventID = C.IncidentID Left join[dbo].[IncidentComments_Aud] B on A.EventID = B.EventID left join User_Info D on D.LogonName=A.CreatedByUser Where ";
            //query = query + "A.EventID=" + objIncidentInfo.IncidentSid;//+ " and A.EventDate>(SELECT DATEADD(DD,"+ _PostIncidentClosedFeedbackPeriodInDays + ",CAST( GETDATE() AS Date )))";

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
                    //objIncidentInfo.IncidentSid = Convert.ToInt32(toReturn.Rows[0]["EventID"].ToString());
                    //objIncidentInfo.ReportedByEmailAddress = toReturn.Rows[0]["ReportedByEmail"].ToString();
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
        public bool CheckFeedbackAlready()
        {
            SqlCommand cmdToExecute = new SqlCommand();
            string query = "Select * from AKU_UserIncidentFeedback A where A.IncidentSID='" + objfeedbackproperty.IncidentSID + "' and A.IncidentCloseDate='" + objfeedbackproperty.IncidentCloseDate + "'";
            cmdToExecute.CommandText = query;// "update AKU_UserIncidentFeedback set StatusFg='" + objfeedbackproperty.StatusFg + "' , UpateByNm='" + objfeedbackproperty.LogonId + "', UpdateDate='" + DateTime.Now + "' , RequesterFeedback='" + objfeedbackproperty.RequesterFeedback + "', ClosuerReOpenFg='" + objfeedbackproperty.ClosuerReOpenFg + "' where IncidentSID='" + objfeedbackproperty.IncidentSID + "' and IncidentCloseDate='" + objfeedbackproperty.IncidentCloseDate + "' and UserSID='" + objfeedbackproperty.UserSID + "'";
            cmdToExecute.CommandType = CommandType.Text;

            // Use base class' connection object
            cmdToExecute.Connection = _mainConnection;

            try
            {
                //cmdToExecute.Parameters.Add(new SqlParameter("@Location_Code", SqlDbType.VarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Location_Code));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Location_Short_Name", SqlDbType.VarChar, 100, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Location_Short_Name));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Location_Name", SqlDbType.VarChar, 200, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Location_Name));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Parent_Location_ID", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Parent_Location_ID));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Company_ID", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Company_ID));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Pos_Type_ID", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Pos_Type_ID));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Sub_Pos_Type_ID", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Sub_Pos_Type_ID));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Shop_No", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Shop_No));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Market_Name", SqlDbType.NVarChar, 30, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Market_Name));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Street", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Street));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Police_Station", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Police_Station));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Post_Code", SqlDbType.NVarChar, 10, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Post_Code));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Phone_No", SqlDbType.NVarChar, 20, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Phone_No));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Fax_No", SqlDbType.NVarChar, 20, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Fax_No));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Email", SqlDbType.NVarChar, 20, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Email));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Company_Turnover", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Company_Turnover));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Total_Turnover", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Total_Turnover));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Amount_Limit", SqlDbType.Decimal, 9, ParameterDirection.Input, false, 18, 1, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Amount_Limit));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Owner_Name", SqlDbType.NVarChar, 30, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Owner_Name));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Owner_NIC", SqlDbType.NVarChar, 17, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Owner_NIC));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Counter_Sale", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Counter_Sale));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Is_Location_POS", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Is_Location_POS));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Status", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Status));
                //cmdToExecute.Parameters.Add(new SqlParameter("@iID", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.ID));
                //cmdToExecute.Parameters.Add(new SqlParameter("@iErrorCode", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, _errorCode));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Record_Table_Name", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.TableName));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Operation", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Operation));
                //cmdToExecute.Parameters.Add(new SqlParameter("@Operated_By", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, ObjLocationSetupProperty.Operated_By));
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

                //this.StartTransaction();
                //// cmdToExecute.Transaction = this.Transaction;
                //// Execute query.
                ////_rowsAffected = cmdToExecute.ExecuteNonQuery();
                //// _iD = (Int32)cmdToExecute.Parameters["@iID"].Value;
                ////_errorCode = cmdToExecute.Parameters["@ErrorCode"].Value;

                //if (objfeedbackproperty.DetailData != null)
                //{
                //    //foreach (DataRow row in objPurchaseRequisitionMaster_Property.DetailData.Rows)
                //    //    row["PurchaseMaster_Id"] = cmdToExecute.Parameters["@ID"].Value.ToString();

                //    objfeedbackproperty.DetailData.AcceptChanges();

                //    SqlBulkCopy sbc = new SqlBulkCopy(_mainConnection, SqlBulkCopyOptions.Default, this.Transaction);
                //    objfeedbackproperty.DetailData.TableName = "AKU_UserIncidentFeedback";

                //    sbc.ColumnMappings.Clear();
                //    sbc.ColumnMappings.Add("UserSID", "UserSID");
                //    //sbc.ColumnMappings.Add(2, 1);
                //    sbc.ColumnMappings.Add("IncidentSID", "IncidentSID");
                //    sbc.ColumnMappings.Add("IncidentCloseDate", "IncidentCloseDate");
                //    sbc.ColumnMappings.Add("IncidentDeptSID", "IncidentDeptSID");
                //    sbc.ColumnMappings.Add("LogonId", "LogonId");
                //    sbc.ColumnMappings.Add("StatusFg", "StatusFg");
                //    sbc.ColumnMappings.Add("CreateDate", "CreateDate");
                //    sbc.ColumnMappings.Add("UpateByNm", "UpateByNm");
                //    sbc.ColumnMappings.Add("UserStatisfyFg", "UserStatisfyFg");
                //    sbc.ColumnMappings.Add("RequesterFeedback", "RequesterFeedback");
                //    sbc.ColumnMappings.Add("ClosuerFeedback", "ClosuerFeedback");
                //    sbc.ColumnMappings.Add("IncidentReOpenFg", "IncidentReOpenFg");


                //    sbc.DestinationTableName = objfeedbackproperty.DetailData.TableName;
                //    sbc.WriteToServer(objfeedbackproperty.DetailData);

                //}
                cmdToExecute.ExecuteNonQuery();
                //  this.Commit();
                if (_errorCode != (int)LLBLError.AllOk)
                {
                    // Throw error.
                    //  this.RollBack();
                    throw new Exception("Stored Procedure 'sp_TRANSACTION_MASTER_Insert' reported the ErrorCode: " + _errorCode);

                }

                return true;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("LOCATIONS_SETUP::Insert::Error occured.", ex);
            }
            finally
            {
                if (_mainConnectionIsCreatedLocal)
                {
                    // Close connection.
                    _mainConnection.Close();
                }
                cmdToExecute.Dispose();
            }
        }
    }
}
