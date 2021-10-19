using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Services
{
    public class OperationResult
    {
        public enum OperationStatus
        {
            Error = 0,
            Success = 1
            //Unauthorized = 2,
        }


        public bool IsSuccessful => Status == OperationStatus.Success;

        public OperationStatus Status { get; set; }

        public string FieldName { get; set; }

        public string Message { get; set; }

        public object Result { get; set; }

        public static implicit operator OperationResult(ErrorResult error)
        {
            return new OperationResult
            {
                FieldName = error?.FieldName,
                Message = error?.Message,
                Status = OperationStatus.Error
            };
        }

        public static OperationResult Success()
        {
            return new OperationResult
            {
                FieldName = string.Empty,
                Message = string.Empty,
                Status = OperationStatus.Success
            };
        }

        public static OperationResult<T> Success<T>(T result)
        {
            return OperationResult<T>.Success(result);
        }

    }
}
