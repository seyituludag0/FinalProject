using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Temel başlangıçlar için voidler
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}
