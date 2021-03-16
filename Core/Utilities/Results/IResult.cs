using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IResult
    {
        //temel voidler için bir başlangıç soyut interface
        bool Success { get; }
        string Message { get; }
    }
}
