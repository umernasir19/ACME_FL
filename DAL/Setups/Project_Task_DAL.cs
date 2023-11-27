using HrProperty.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Setups
{
   public class Project_Task_DAL:DBInteraction
    {
        Task_Property objTaskProperty;

        public Project_Task_DAL()
        {

        }
        public Project_Task_DAL(Task_Property taskproperty)
        {
            objTaskProperty = taskproperty;
        }

        public override bool Insert()
        {
            SqlCommand cmdToExecute = new SqlCommand();
            //cmdToExecute.CommandText = "dbo.[sp_Attendance_Insert]";
            //cmdToExecute.CommandType = CommandType.StoredProcedure;

            //// Use base class' connection object
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

                this.StartTransaction();

                SqlBulkCopy sbc = new SqlBulkCopy(_mainConnection, SqlBulkCopyOptions.Default, this.Transaction);
                sbc.ColumnMappings.Clear();

                sbc.DestinationTableName = "tbl_Tasks";
                sbc.ColumnMappings.Clear();
                sbc.ColumnMappings.Add("MileStone_ID", "MileStone_Id");
                sbc.ColumnMappings.Add("TaskName", "TaskName");
                sbc.ColumnMappings.Add("TaskDescription", "Task_Description");
                sbc.ColumnMappings.Add("Start_Date", "Start_Date");
                sbc.ColumnMappings.Add("Expected_End_Date", "Expected_End_Date");
                sbc.ColumnMappings.Add("Allocated_Time", "Allocated_Time");
                //sbc.ColumnMappings.Add("CreatedBy", "CreatedBy");
                sbc.ColumnMappings.Add("Date_Created", "Date_Created");
                sbc.ColumnMappings.Add("Status", "Status");
                sbc.ColumnMappings.Add("IsActive", "Is_Active");
                sbc.ColumnMappings.Add("Is_Completed", "Is_Completed");
                sbc.ColumnMappings.Add("Is_Started", "In_Progress");



                //taskitems[i].CreatedBy = (int)SessionManager.CurrentUser.ID;
                //taskitems[i].Date_Created = DateTime.Now;
                //taskitems[i].Status = "Active";
                //taskitems[i].IsActive = true;
                //taskitems[i].Is_Completed = false;
                //taskitems[i].Is_Started = false;

                //sbc.ColumnMappings.Add("Time_Out", "Time_Out");
                //sbc.ColumnMappings.Add("Total_Hours", "Total_hours");
                //sbc.DestinationTableName = dt.TableName;
                sbc.WriteToServer(objTaskProperty.TaskList);

                // Execute query.
                //_rowsAffected = cmdToExecute.ExecuteNonQuery();

                //_errorCode = (SqlInt32)cmdToExecute.Parameters["@iErrorCode"].Value;
                //if (_errorCode != (int)LLBLError.AllOk)
                //{
                //    // Throw error.
                //    //throw new Exception("Stored Procedure 'pr_PRODUCT_SETUP_Insert' reported the ErrorCode: " + _errorCode);
                //    return false;
                //}
                this.Commit();

                //ObjProductSetupProperty.ID = (SqlInt32)cmdToExecute.Parameters["@iID"].Value;
                //ObjProductSetupProperty.ErrorCode = (SqlInt32)cmdToExecute.Parameters["@iErrorCode"].Value;
                return true;
            }
            catch (Exception ex)
            {
                this.RollBack();
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("tbl_Task::Insert::Error occured.", ex);
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
