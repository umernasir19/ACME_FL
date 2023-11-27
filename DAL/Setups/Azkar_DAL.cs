using AutoMapper;
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
    public class Azkar_DAL:DBInteraction
    {
        Azkar_Property objazkarproperty;
        FL_AZKAR objdbazkar;
        IMapper mapper;


        public Azkar_DAL()
        {
            //var config = new MapperConfiguration(cfg =>
            //{
            //    cfg.CreateMap<Azkar_Property, FL_AZKAR>();

            //    //cfg.CreateMap<Azkar_Property, FL_AZKAR>()
            //    //    .ForMember(dest => dest., opt => opt.MapFrom(src => src.Customers));
            //});

            //mapper = config.CreateMapper();
        }

        public Azkar_DAL(Azkar_Property obj_azkarproperty)
        {
            objazkarproperty = obj_azkarproperty;

            objdbazkar = new FL_AZKAR();

        }

        public bool Insert()
        {
            SqlCommand cmdToExecute = new SqlCommand();
            cmdToExecute.CommandText = "dbo.[sp_AzkarAddUpdate]";
            cmdToExecute.CommandType = CommandType.StoredProcedure;
            //DataTable toReturn = new DataTable("Azkar");
            //SqlDataAdapter adapter = new SqlDataAdapter(cmdToExecute);

            // Use base class' connection object
            cmdToExecute.Connection = _mainConnection;

            try
            {

                cmdToExecute.Parameters.AddWithValue("@Azkar_ID", objazkarproperty.Azkar_ID);
                cmdToExecute.Parameters.AddWithValue("@Azkar_Name", objazkarproperty.Azkar_Name);
                cmdToExecute.Parameters.AddWithValue("@Azkar_Arabic", objazkarproperty.Azkar_Arabic);
                cmdToExecute.Parameters.AddWithValue("@Azkar_Eng", objazkarproperty.Azkar_Eng);
                cmdToExecute.Parameters.AddWithValue("@Azkar_Urdu", objazkarproperty.Azkar_Urdu);
                cmdToExecute.Parameters.AddWithValue("@Azkar_Count", objazkarproperty.Azkar_Count);
                cmdToExecute.Parameters.AddWithValue("@Status", objazkarproperty.Status);
                cmdToExecute.Parameters.AddWithValue("@CreatedBy", objazkarproperty.CreatedBy);
                cmdToExecute.Parameters.AddWithValue("@DateCreated", objazkarproperty.DateCreated
                    );
                //cmdToExecute.Parameters.AddWithValue("@password", objUserProperty.Password);
                //cmdToExecute.Parameters.AddWithValue("@active", objUserProperty.Active);
                //cmdToExecute.Parameters.AddWithValue("@insertBy", objUserProperty.InsertBy);
                //cmdToExecute.Parameters.AddWithValue("@insertionDate", objUserProperty.InsertionDate);
                //cmdToExecute.Parameters.AddWithValue("@PageNum", objUserProperty.PageNum);
                //cmdToExecute.Parameters.AddWithValue("@PageSize", objUserProperty.PageSize);
                //cmdToExecute.Parameters.AddWithValue("@sortColumn", objUserProperty.SortColumn);
                //cmdToExecute.Parameters.AddWithValue("@Status", objmsjidProperty.Status);
                //cmdToExecute.Parameters.Add(new SqlParameter("@TotalRowsNum", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, objmsjidProperty.TotalRowsNum));


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
                cmdToExecute.ExecuteNonQuery();
                //adapter.Fill(toReturn);
                //_errorCode = (SqlInt32)cmdToExecute.Parameters["@ErrorCode"].Value;
                // objUserProperty.TotalRowsNum = Convert.ToInt32(cmdToExecute.Parameters["@TotalRowsNum"].Value); //Convert.ToInt32(adapter.SelectCommand.Parameters["@TotalRowsNum"].Value);
                //if (_errorCode != (int)LLBLError.AllOk)
                //{
                //    return toReturn;
                //}

                return true;
            }
            catch (Exception ex)
            {

                //objErrorTrace.Error_Msg = (SqlString)ex.Message;
                //objErrorTrace.Error_Proc = "sp_USER_SelectAll";
                //objErrorTrace.Insert();

                //HttpContext.Current.Response.Redirect("~/Error.aspx");


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
               // adapter.Dispose();
            }
        }

        public override DataTable SelectAll()
        {
            SqlCommand cmdToExecute = new SqlCommand();
            cmdToExecute.CommandText = "dbo.[sp_GetAllAzkar]";
            cmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable toReturn = new DataTable("Azkar");
            SqlDataAdapter adapter = new SqlDataAdapter(cmdToExecute);

            // Use base class' connection object
            cmdToExecute.Connection = _mainConnection;

            try
            {
                //cmdToExecute.Parameters.AddWithValue("@id", objUserProperty.ID);
                ////cmdToExecute.Parameters.AddWithValue("@code", objUserProperty.Code);
                ////cmdToExecute.Parameters.AddWithValue("@distributorCode", objUserProperty.DistributorCode);
                ////cmdToExecute.Parameters.AddWithValue("@companyID", objUserProperty.CompanyID);
                //cmdToExecute.Parameters.AddWithValue("@userName", objUserProperty.UserName);
                //cmdToExecute.Parameters.AddWithValue("@firstName", objUserProperty.FirstName);
                //cmdToExecute.Parameters.AddWithValue("@lastName", objUserProperty.LastName);
                //cmdToExecute.Parameters.AddWithValue("@email", objUserProperty.Email);
                //cmdToExecute.Parameters.AddWithValue("@password", objUserProperty.Password);
                //cmdToExecute.Parameters.AddWithValue("@active", objUserProperty.Active);
                //cmdToExecute.Parameters.AddWithValue("@insertBy", objUserProperty.InsertBy);
                //cmdToExecute.Parameters.AddWithValue("@insertionDate", objUserProperty.InsertionDate);
                //cmdToExecute.Parameters.AddWithValue("@PageNum", objUserProperty.PageNum);
                //cmdToExecute.Parameters.AddWithValue("@PageSize", objUserProperty.PageSize);
                //cmdToExecute.Parameters.AddWithValue("@sortColumn", objUserProperty.SortColumn);
                //cmdToExecute.Parameters.AddWithValue("@Status", objmsjidProperty.Status);
                //cmdToExecute.Parameters.Add(new SqlParameter("@TotalRowsNum", SqlDbType.Int, 4, ParameterDirection.Output, true, 10, 0, "", DataRowVersion.Proposed, objmsjidProperty.TotalRowsNum));


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
                // objUserProperty.TotalRowsNum = Convert.ToInt32(cmdToExecute.Parameters["@TotalRowsNum"].Value); //Convert.ToInt32(adapter.SelectCommand.Parameters["@TotalRowsNum"].Value);
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
