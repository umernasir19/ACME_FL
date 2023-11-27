using DAL.Setups;
using HrProperty.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Setups
{
    public class Feedback_BLL
    {
        Feedback_DAL objFeedbackDAL;
        AKU_UserIncidentFeedback_Property objfeedbackproperty;
        public Feedback_BLL()
        {

        }
        public Feedback_BLL(AKU_UserIncidentFeedback_Property obj_feedbackproperty)
        {
            objfeedbackproperty = obj_feedbackproperty;
        }

        public bool Insert()
        {
            objFeedbackDAL = new Feedback_DAL(objfeedbackproperty);
            return objFeedbackDAL.Insert();
        }
        public bool Update()
        {
            objFeedbackDAL = new Feedback_DAL(objfeedbackproperty);
            return objFeedbackDAL.Update();
        }
        public bool InsertAttachment(AKU_UserIncidentFeedbackAttmnt_Property objattachmnt)
        {
            objFeedbackDAL = new Feedback_DAL();
            return objFeedbackDAL.InsertAttachment(objattachmnt);
        }

        public DataTable GetAllFeedback()
        {

            objFeedbackDAL = new Feedback_DAL();
            return objFeedbackDAL.GetAllFeedback();
        }
        public DataTable CheckFfedBackByID(int id)
        {
            objFeedbackDAL = new Feedback_DAL();
            return objFeedbackDAL.CheckFfedBackByID(id);
        }
        public bool CheckFeedbackExists()
        {
            objFeedbackDAL = new Feedback_DAL(objfeedbackproperty);
            if(objFeedbackDAL.CheckFeedbackExists().Rows.Count > 0) {

                return false;
            }
            else
            {
                return true;
            }
        }

        public int GetLastAttachmentID()
        {
            objFeedbackDAL = new Feedback_DAL();
            int id = 1;
            if(objFeedbackDAL.GetLastAttachmentID().Rows.Count > 0)
            {
                foreach(DataRow dr in objFeedbackDAL.GetLastAttachmentID().Rows)
                {
                    id= Convert.ToInt32(dr["AttachementID"].ToString());
                }
                return id;
            }
            else
            {
                return id;
            }
        }
    }
}
