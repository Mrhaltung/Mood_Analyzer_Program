using System;
using System.Collections.Generic;
using System.Text;

namespace Mood_Analyzer_Program
{
    public class MoodAnalyzer
    {
        public string msg;
        public MoodAnalyzer(string message)
        {
            this.msg = msg;
        }

        public string AnalyseMood()
        {
            if (msg.ToLower().Contains("sad"))
                return "SAD";
           
            else
                return "HAPPY";
        }
    }
}
