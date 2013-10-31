using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace OfficeManager.WcfService
{
    [DataContract]
    public class WcfResult
    {
        [DataMember]
        public bool Success { get; set; }
        [DataMember]
        public int ResultCode { get; set; }
        [DataMember]
        public string ResultMessage { get; set; }
        [DataMember]
        public ExceptionInfo Exception { get; set; }
    }

    [DataContract]
    public class WcfResult<T> : WcfResult
    {
        protected T genericValue = default (T);
        [DataMember]
        public T Value
        {
            get { return genericValue; }
            set { genericValue = value; }
        }
    }

    [DataContract]
    public class ExceptionInfo
    {
        public ExceptionInfo(Exception ex)
        {
            Message = ex.Message;
            Source = ex.Source;
            StackTrace = ex.StackTrace;
        }

        [DataMember]
        public string Message { get; set; }
        [DataMember]
        public string Source { get; set; }
        [DataMember]
        public string StackTrace { get; set; }

    }
}