using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Runtime.Serialization;

namespace MediaManager.Tools
{
    public class MediaManagerException : Exception, ISerializable
    {


        public MediaManagerException(string message, ExceptionReturnType type) : base(message)
        {
        }
    }

     [JsonConverter(typeof(StringEnumConverter))]
    public enum ExceptionReturnType
    {
        Error = 1,
        Warning = 2,
        Information = 3,
        Success = 4,
        Fatal = 5
    }
}
