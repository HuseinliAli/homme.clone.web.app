using System;
using System.Collections.Generic;
using System.Text;

namespace irshad.clone.core.Utilities.Results.Abstract
{
    public interface IDataResult<T> : IResult
    {
        T Data { get; }
    }
}
