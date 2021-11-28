using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mood_Analyzer_Program;
namespace Mood_Analyzer_Test
{
    [TestClass]
    public class TestMood
    {
        [TestMethod]
        public void NullMood()
        {
            string msg = " ";
            string expected = "HAPPY";

            MoodAnalyzer mood = new MoodAnalyzer(msg);

            string actual = mood.AnalyseMood();

            Assert.AreEqual(expected, actual);
        }
    }
}
