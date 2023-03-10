using irshad.clone.core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace irshad.clone.core.Utilities.Results.Concrete
{
    public class Result : IResult
    {
        public Result(bool success, string message):this(success)
        {
            Message = message;
        }
        public Result(bool success)
        {
            Success = success;
        }
        public Result(string message)
        {

        }
        public Result()
        {

        }
        public bool Success { get; }

        public string Message { get; }
    }
}
