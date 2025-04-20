using NUnit.Framework;
using Test_Driven_Development_1; 

namespace Tests
{
    [TestFixture]
    public class Form1Tests
    {
        [Test]
        public void Write_SetsDisplayTextCorrectly()
        {
            var form = new Form1();
            string input = "1";

            form.write(input);

            Assert.That(input, Is.EqualTo(form.display.Text));
        }
    }
}