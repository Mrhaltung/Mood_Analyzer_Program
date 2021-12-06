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

        [TestMethod]
        public void MoodAnalyseClassName()
        {
            try
            {
                string msg = null;

                object expected = new MoodAnalyzer(msg);
                object obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyzerProblem.MoodAnalyser", "MoodAnalyser");
                expected.Equals(obj);
            }
            catch (CustomException ex)
            {
                Assert.AreEqual("Class not found", ex.Message);
            }
        }

        [TestMethod]
        public void MoodAnalyseWrongClassName()
        {
            try
            {
                string msg = null;
                object expected = new MoodAnalyzer(msg);
                object obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyzerProblem.MoodAnalyserWrong", "MoodAnalyserWrong");
                expected.Equals(obj);
            }
            catch (CustomException ex)
            {
                Assert.AreEqual("Class not found", ex.Message);
            }
        }

        [TestMethod]
        public void MoodAnalyseWrongConstructor()
        {
            try
            {
                string msg = null;
                object expected = new MoodAnalyzer(msg);
                object obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyzerProblem.MoodAnalyser", "MoodAnalyserWrong");
                expected.Equals(obj);
            }

            catch (CustomException ex)
            {
                Assert.AreEqual("Constructor not found", ex.Message);
            }
        }

        [TestMethod]
        public void ParameterisedConstructor_MoodAnalyseClassName()
        {
            object expected = new MoodAnalyzer("HAPPY");
            object obj = MoodAnalyserFactory.MoodAnalyserParameterisedConstructor("MSTestMoodAnalyzerProblem.MoodAnalyser", "MoodAnalyser");
            expected.Equals(obj);
        }

        [TestMethod]
        public void ParameterisedConstructor_WrongClassName()
        {
            try
            {
                object expected = new MoodAnalyzer("HAPPY");
                object obj = MoodAnalyserFactory.MoodAnalyserParameterisedConstructor("MSTestMoodAnalyzerProblem.MoodAnalyserWrong", "MoodAnalyser");
                expected.Equals(obj);
            }

            catch (CustomException ex)
            {
                Assert.AreEqual("Class not found", ex.Message);
            }
        }

        [TestMethod]
        public void ParameterisedConstructor_WrongConstrcutorName()
        {
            try
            {
                object expected = new MoodAnalyzer("HAPPY");
                object obj = MoodAnalyserFactory.MoodAnalyserParameterisedConstructor("MSTestMoodAnalyzerProblem.MoodAnalyser", "MoodAnalyserWrong");
                expected.Equals(obj);
            }

            catch (CustomException ex)
            {
                Assert.AreEqual("Class not found", ex.Message);
            }
        }

        [TestMethod]
        public void GivenHappy_ShouldReturn_Happy_ReflectorInvoke_method()
        {
            string expected = "HAPPY";
            string mood = MoodAnalyserFactory.InvokeAnalyseMood("Happy", "AnalyseMood");
            Assert.AreNotEqual(expected, mood);
        }

        [TestMethod]
        public void GivenHappy_ShouldReturnException_WithWrongMethodName()
        {
            try
            {
                string expected = "method not found";
                string mood = MoodAnalyserFactory.InvokeAnalyseMood("Happy", "AnalyseMoodWrong");
                Assert.AreNotEqual(expected, mood);
            }

            catch (CustomException ex)
            {
                Assert.AreEqual("method not found", ex.Message);
            }
        }

        [TestMethod]
        public void GivenHappy_ShouldReturnHappy_WithReflectorDynamically()
        {
            string result = MoodAnalyserFactory.Setfield("Happy", "message");
            Assert.AreEqual("Happy", result);
        }

        [TestMethod]
        public void GivenWrongFieldShouldReturnException()
        {
            try
            {
                string result = MoodAnalyserFactory.Setfield("Happy", "messageWrong");
                Assert.AreEqual("Happy", result);
            }
            catch (CustomException ex)
            {
                Assert.AreEqual("Field not found", ex.Message);
            }
        }

        [TestMethod]
        public void GivenEmptyMessageShouldReturnException()
        {
            try
            {
                string result = MoodAnalyserFactory.Setfield(null, "messageWrong");
                Assert.AreEqual("Happy", result);
            }
            catch (CustomException ex)
            {
                Assert.AreEqual("Message should not be null", ex.Message);
            }
        }
    }
}