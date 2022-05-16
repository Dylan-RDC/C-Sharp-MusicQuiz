using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group1_PRG281_Project
{
    class LogInException : Exception
    {
        public LogInException() { }

        public LogInException(string message) : base(message)
        {

        }
    }
}