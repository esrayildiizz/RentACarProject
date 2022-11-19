using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Unitilies.Results
{
    class Result : IResult
    {
        public bool Success { get; }

        public string Message { get; }
    }
}
