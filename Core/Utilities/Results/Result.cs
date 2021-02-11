using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result:IResult
    {

        public Result(bool success, string message):this(success)
        {
            Message = message;
        }

        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; } // get ler readonly dir. Readonly ler constructor da set edilebilirler.
        public string Message { get; }
    }
}
