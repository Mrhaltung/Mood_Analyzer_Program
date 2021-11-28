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

        [TestMethod]
        public void getCustomNullException()
        {
            string expected = "message should not be null";
            MoodAnalyzer modeAnalyzer = new MoodAnalyzer(" ");

            try
            {
                string actual = modeAnalyzer.AnalyseMood();

            }
            catch (CustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }
        }

        [TestMethod]
        public void getCustomEmptyException()
        {
            string expected = "message should not be empty";
            MoodAnalyzer modeAnalyzer = new MoodAnalyzer(string.Empty);

            try
            {
                string actual = modeAnalyzer.AnalyseMood1();

            }
            catch (CustomException ex)
            {
                Assert.AreEqual(expected, ex.Message);
            }

        }
    }
}
