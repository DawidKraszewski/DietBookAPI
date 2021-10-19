using LOGIC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Services
{
    public class OperationResult<T> : OperationResult
    {
        public new T Result
        {
            get => base.Result is T ? (T)base.Result : default;
            set => base.Result = value;
        }

        public static implicit operator OperationResult<T> (ErrorResult error)
        {
            return Error(error?.FieldName, error?.Message);
        }

        public static implicit operator OperationResult<T> (T value)
        {
            return Success(value);
        }

        public static OperationResult<T> Error (string fieldName = "", string message = "")
        {
            return new OperationResult<T>
            {
                Result = default,
                FieldName = fieldName,
                Message = message,
                Status = OperationStatus.Error
            };
        }

        public static OperationResult<T> Success (T value = default)
        {
            return new OperationResult<T>
            {
                Result = value,
                FieldName = string.Empty,
                Message = string.Empty,
                Status = OperationStatus.Success
            };
        }
    }
}
