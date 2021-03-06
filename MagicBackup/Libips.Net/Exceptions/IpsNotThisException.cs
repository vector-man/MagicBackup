﻿using System;
using System.Runtime.Serialization;

namespace CodeIsle.LibIpsNet.Exceptions
{
    [Serializable]
    public class IpsNotThisException : Exception
    {
        #region Public Constructors

        public IpsNotThisException()
            : base() { }

        public IpsNotThisException(string message)
            : base(message) { }

        public IpsNotThisException(string format, params object[] args)
            : base(string.Format(format, args)) { }

        public IpsNotThisException(string message, Exception innerException)
            : base(message, innerException) { }

        public IpsNotThisException(string format, Exception innerException, params object[] args)
            : base(string.Format(format, args), innerException) { }

        #endregion Public Constructors

        #region Protected Constructors

        protected IpsNotThisException(SerializationInfo info, StreamingContext context)
            : base(info, context) { }

        #endregion Protected Constructors
    }
}