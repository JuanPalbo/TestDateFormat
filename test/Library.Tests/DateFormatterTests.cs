using TestDateFormat;

namespace Library.Tests
{
    public class DateFormatterTests
    {
        [Test]
        public void CorrectFormatTest()
        {
            const string testDate = "10/11/1997";
            const string expected = "1997-11-10";
            string actual = DateFormatter.ChangeFormat(testDate);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void IncorrectFormatTest()
        {
            const string testDate = "2018-07-01";
            const string expected = "Formato incorrecto";
            string actual = DateFormatter.ChangeFormat(testDate);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void EmptyStringTest()
        {
            const string testDate = "";
            const string expected = "Se ha ingresado una cadena vacía";
            string actual = DateFormatter.ChangeFormat(testDate);
            Assert.AreEqual(expected, actual);
        }
    }
}