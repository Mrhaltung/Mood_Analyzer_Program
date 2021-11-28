using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mood_Analyzer_Program;
namespace Mood_Analyzer_Test
{
    [TestClass]
    public class TestMood
    {
        [TestMethod]
        public void MsgSadMood()
        {
            string msg = "I am in sad mood";
            string expected = "SAD";

            MoodAnalyzer mood = new MoodAnalyzer();

            string actual = mood.AnalyseMood(msg);

            Assert.AreEqual(expected, actual);
        }

        public void MsgHaapyMood()
        {
            string msg = "I am in Any mood";
            string expected = "HAPPY";

            MoodAnalyzer mood = new MoodAnalyzer();

            string actual = mood.AnalyseMood(msg);

            Assert.AreEqual(expected, actual);
        }
    }
}
