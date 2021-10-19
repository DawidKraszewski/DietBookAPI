using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Services
{
    public class ErrorResult
    {
        public string FieldName { get; set; }

        public string Message { get; set; }

        public static implicit operator ErrorResult(string message)
        {
            return new ErrorResult { Message = message };
        }

        public static ErrorResult Error (string fieldName, string message)
        {
            return new ErrorResult { FieldName = fieldName, Message = message };
        }

    }
}
