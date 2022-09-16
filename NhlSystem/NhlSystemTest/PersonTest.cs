using NhlSystem;

namespace NhlSystemTest
{
    [TestClass]
    public class PersonTest
    {
        [TestMethod]
        [DataRow("Connor McDavid")]
        [DataRow("Jeff")]
        public void FullName_ValidName_FullNameSet(string fullName)
        {
            var validPerson = new Person(fullName);
            Assert.AreEqual(fullName, validPerson.FullName);
        }

        [TestMethod]
        [DataRow("      ")]
        [DataRow(null)]
        public void FullName_InvalidName_ArgumentNullException(string fullName)
        {
            Assert.ThrowsException<ArgumentNullException>(() => new Person(fullName));
           
        }

        [TestMethod]
        [DataRow("A")]
        [DataRow("AB")]
        public void FullName_InvalidName_ArgumentException(string fullName)
        {
            Assert.ThrowsException<ArgumentException>(() => new Person(fullName));

        }
    }
}