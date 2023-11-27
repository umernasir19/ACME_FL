using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrProperty.Models
{
    [Serializable()]
   public class User_Property
    {
        #region Class Member Declarations

        int? _id, _roleid;
        string _userName;
        string _firstName;
        string _lastName;
        string _email;
        string _password;
        int? _active;
        int? _insertBy;
        DateTime? _insertionDate;
        string _sortColumn;
        string _distributorCode, _tableName, _status;
        bool _remember_me;
        int? _pageNum, _pageSize, _totalRowsNum, _operatedBy;


        #endregion

        #region Class Property Declarations

        public int? ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        

       

        [Required]
        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                _userName = value;
            }
        }

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }
        [Required]
        [DataType(DataType.Password)]
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }

        public int? Active
        {
            get
            {
                return _active;
            }
            set
            {
                _active = value;
            }
        }

        public int? InsertBy
        {
            get
            {
                return _insertBy;
            }
            set
            {
                _insertBy = value;
            }
        }

        public DateTime? InsertionDate
        {
            get
            {
                return _insertionDate;
            }
            set
            {
                _insertionDate = value;
            }
        }

        public int? PageNum
        {
            get
            {
                return _pageNum;
            }
            set
            {
                _pageNum = value;
            }
        }

        public int? PageSize
        {
            get
            {
                return _pageSize;
            }
            set
            {
                _pageSize = value;
            }
        }

        public int? TotalRowsNum
        {
            get
            {
                return _totalRowsNum;
            }
            set
            {
                _totalRowsNum = value;
            }
        }

        public string SortColumn
        {
            get
            {
                return _sortColumn;
            }
            set
            {
                _sortColumn = value;
            }
        }

       
        public int? Operated_By
        {
            get
            {
                return _operatedBy;
            }
            set
            {
                _operatedBy = value;
            }
        }

        public string TableName
        {
            get
            {
                return _tableName;
            }
            set
            {
                _tableName = value;
            }
        }

        public string Status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
            }
        }
        public bool RemeberMe
        {
            get
            {
                return _remember_me;
            }
            set
            {
                _remember_me = value;
            }
        }

        public int? Roleid
        {
            get
            {
                return _roleid;
            }

            set
            {
                _roleid = value;
            }
        }

        public int EmpID { get; set; }

        public DateTime? LastModified { get; set; }
        #endregion
    }
}
