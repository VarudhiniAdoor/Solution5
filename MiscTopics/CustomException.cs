using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscTopics
{
    internal class CustomException : Exception
    {
        public string Message { get; set; }
        public CustomException(string message)
        {
            Message = message;

        }
    }
}
