using System;
using System.Collections.Generic;
using System.Text;

namespace Mood_Analyzer_Program
{
    public class MoodAnalyzer
    {        
        public string AnalyseMood(string msg)
        {
            if (msg.ToLower().Contains("sad"))
                return "SAD";
           
            else
                return "HAPPY";
        }
    }
}
