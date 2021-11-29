using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace Mood_Analyzer_Program
{
    public class MoodAnalyserFactory
    {
        public static object CreateMoodAnalyse(string className, string constructorName)
        {
            string pattern = "." + constructorName + "$";
            Match result = Regex.Match(className, pattern);

            if (result.Success)
            {
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type moodAnalyseType = executing.GetType(className);
                    return Activator.CreateInstance(moodAnalyseType);

                }

                catch (Exception e)
                {
                    throw new CustomException(CustomException.ExceptionType.NO_SUCH_CLASS, "Class not found");
                }

            }
            else
            {
                throw new CustomException(CustomException.ExceptionType.NO_SUCH_METHOD, "Constructor not found");
            }
        }
    }
}
