﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{

    /// <summary>
    /// Purpose: Error Enums used by this LLBL library.
    /// </summary>
    public enum LLBLError
    {
        AllOk
        // Add more here (check the comma's!)
    }

    // <summary>
    /// Purpose: General interface of the API generated. Contains only common methods of all classes.
    /// </summary>

    public interface ICommonDBAccess
    {
        bool Insert();
        bool Update();
        bool Delete();
        DataTable SelectOne();
        DataTable SelectAll();
    }

    public class DBInteraction : IDisposable, ICommonDBAccess
    {






        /// <summary>
        /// Purpose: Abstract base class for Database Interaction classes.
        /// </summary>

        #region Class Member Declarations
        protected SqlConnection _mainConnection;
        protected int _rowsAffected;
        protected SqlInt32 _errorCode;
        protected bool _mainConnectionIsCreatedLocal;
        protected ConnectionProvider _mainConnectionProvider;
        private bool _isDisposed;
        protected SqlTransaction _transaction;
       // protected string _PostIncidentClosedFeedbackPeriodInDays;
        #endregion


        /// <summary>
        /// Purpose: Class constructor.
        /// </summary>
        public DBInteraction()
        {
            // Initialize the class' members.
            InitClass();
        }


        /// <summary>
        /// Purpose: Initializes class members.
        /// </summary>
        private void InitClass()
        {
            // create all the objects and initialize other members.
            _mainConnection = new SqlConnection();
            _mainConnectionIsCreatedLocal = true;
            _mainConnectionProvider = null;
            AppSettingsReader _configReader = new AppSettingsReader();

            // Set connection string of the sqlconnection object
            _mainConnection.ConnectionString =
                        _configReader.GetValue("Main.ConnectionString", typeof(string)).ToString();
           // _PostIncidentClosedFeedbackPeriodInDays= _configReader.GetValue("PostIncidentClosedFeedbackPeriodInDays", typeof(string)).ToString();
            _errorCode = (int)LLBLError.AllOk;
            _isDisposed = false;
        }

        public void StartTransaction()
        {
            _transaction = _mainConnection.BeginTransaction();
        }

        public void OpenConnection()
        {
            if (_mainConnectionIsCreatedLocal)
                _mainConnection.Open();
        }

        public void CloseConnection()
        {
            _mainConnection.Close();
        }

        public void Commit()
        {
            _transaction.Commit();
        }

        public void RollBack()
        {
            _transaction.Rollback();
        }

        /// <summary>
        /// Purpose: Implements the IDispose' method Dispose.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        /// <summary>
        /// Purpose: Implements the Dispose functionality.
        /// </summary>
        protected virtual void Dispose(bool isDisposing)
        {
            // Check to see if Dispose has already been called.
            if (!_isDisposed)
            {
                if (isDisposing)
                {
                    // Dispose managed resources.
                    if (_mainConnectionIsCreatedLocal)
                    {
                        // Object is created in this class, so destroy it here.
                        _mainConnection.Close();
                        _mainConnection.Dispose();
                        _mainConnectionIsCreatedLocal = false;
                    }
                    _mainConnectionProvider = null;
                    _mainConnection = null;
                }
            }
            _isDisposed = true;
        }


        /// <summary>
        /// Purpose: Implements the ICommonDBAccess.Insert() method.
        /// </summary>
        public virtual bool Insert()
        {
            // No implementation, throw exception
            throw new NotImplementedException();
        }


        /// <summary>
        /// Purpose: Implements the ICommonDBAccess.Delete() method.
        /// </summary>
        public virtual bool Delete()
        {
            // No implementation, throw exception
            throw new NotImplementedException();
        }


        /// <summary>
        /// Purpose: Implements the ICommonDBAccess.Update() method.
        /// </summary>
        public virtual bool Update()
        {
            // No implementation, throw exception
            throw new NotImplementedException();
        }


        /// <summary>
        /// Purpose: Implements the ICommonDBAccess.SelectOne() method.
        /// </summary>
        /// All return methods should be Get
        /// Make it generalize so as it can return multiple or single row of any object
        /// 
        public virtual DataTable SelectOne()
        {
            // No implementation, throw exception
            throw new NotImplementedException();
        }


        /// <summary>
        /// Purpose: Implements the ICommonDBAccess.SelectAll() method.
        /// </summary>
        /// return List<propertyBaseclass>
        public virtual DataTable SelectAll()
        {

            // Convert from row to property list


            // No implementation, throw exception
            throw new NotImplementedException();
        }


        #region Class Property Declarations
        public ConnectionProvider MainConnectionProvider
        {
            set
            {
                if (value == null)
                {
                    // Invalid value
                    throw new ArgumentNullException("MainConnectionProvider", "Null passed as value to this property which is not allowed.");
                }

                // A connection provider object is passed to this class.
                // Retrieve the SqlConnection object, if present and create a
                // reference to it. If there is already a MainConnection object
                // referenced by the membervar, destroy that one or simply 
                // remove the reference, based on the flag.
                if (_mainConnection != null)
                {
                    // First get rid of current connection object. Caller is responsible
                    if (_mainConnectionIsCreatedLocal)
                    {
                        // Is local created object, close it and dispose it.
                        _mainConnection.Close();
                        _mainConnection.Dispose();
                    }
                    // Remove reference.
                    _mainConnection = null;
                }
                _mainConnectionProvider = (ConnectionProvider)value;
                _mainConnection = _mainConnectionProvider.DBConnection;
                _mainConnectionIsCreatedLocal = false;
            }
        }

        public SqlTransaction Transaction
        {
            get
            {
                return _transaction;
            }
            set
            {
                _transaction = value;
            }
        }


        public SqlInt32 ErrorCode
        {
            get
            {
                return _errorCode;
            }
        }


        public int RowsAffected
        {
            get
            {
                return _rowsAffected;
            }
        }
        #endregion

    }
}




