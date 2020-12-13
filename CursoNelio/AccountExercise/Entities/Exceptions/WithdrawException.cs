using System;
using System.Collections.Generic;
using System.Text;

namespace AccountExercise.Entities.Exceptions
{
    class WithdrawException : Exception
    {
        public WithdrawException(string msg) : base(msg)
        {
        }
    }
}
