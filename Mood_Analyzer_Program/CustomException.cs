using System;
using System.Collections.Generic;
using System.Text;

namespace Mood_Analyzer_Program
{
    public class CustomException:Exception
    {
        public ExceptionType type;

        public enum ExceptionType
        {
            Null_Type_Exception,
            Empty_Type_Exception
        }
        public CustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
