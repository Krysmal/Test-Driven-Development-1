using NUnit.Framework;
using Test_Driven_Development_1; 

namespace Tests
{
    [TestFixture]
    public class Form1Tests
    {
        [Test]
        public void WriteTest()
        {
            var form = new Form1();
            string input = "1";

            form.write(input);

            Assert.That(input, Is.EqualTo(form.display.Text));
        }
        [Test]
        public void B1Test()
        {
            var form = new Form1();
            int expected = 1;

            form.button1_Click(null, EventArgs.Empty);
            string output = form.display.Text;
            char number = output[^1]; 

            
            int lastDigit1 = (int)form.num1 % 10;
            int lastDigit2 = (int)form.num2 % 10;

            
            int displayed = int.Parse(number.ToString());

            
            Assert.That(lastDigit1 == expected && displayed == expected || lastDigit2 == expected && displayed == expected);
        }
        [Test]
        public void B2Test()
        {
            var form = new Form1();
            int expected = 2;

            form.button2_Click(null, EventArgs.Empty);
            string output = form.display.Text;
            char number = output[^1];


            int lastDigit1 = (int)form.num1 % 10;
            int lastDigit2 = (int)form.num2 % 10;


            int displayed = int.Parse(number.ToString());


            Assert.That(lastDigit1 == expected && displayed == expected || lastDigit2 == expected && displayed == expected);

        }
        [Test]
        public void B3Test()
        {
            var form = new Form1();
            int expected = 3;

            form.button3_Click(null, EventArgs.Empty);
            string output = form.display.Text;
            char number = output[^1];


            int lastDigit1 = (int)form.num1 % 10;
            int lastDigit2 = (int)form.num2 % 10;


            int displayed = int.Parse(number.ToString());


            Assert.That(lastDigit1 == expected && displayed == expected || lastDigit2 == expected && displayed == expected);

        }
        [Test]
        public void B4Test()
        {
            var form = new Form1();
            int expected = 4;

            form.button4_Click(null, EventArgs.Empty);
            string output = form.display.Text;
            char number = output[^1];


            int lastDigit1 = (int)form.num1 % 10;
            int lastDigit2 = (int)form.num2 % 10;


            int displayed = int.Parse(number.ToString());


            Assert.That(lastDigit1 == expected && displayed == expected || lastDigit2 == expected && displayed == expected);

        }
        [Test]
        public void B5Test()
        {
            var form = new Form1();
            int expected = 5;

            form.button5_Click(null, EventArgs.Empty);
            string output = form.display.Text;
            char number = output[^1];


            int lastDigit1 = (int)form.num1 % 10;
            int lastDigit2 = (int)form.num2 % 10;


            int displayed = int.Parse(number.ToString());


            Assert.That(lastDigit1 == expected && displayed == expected || lastDigit2 == expected && displayed == expected);

        }
        [Test]
        public void B6Test()
        {
            var form = new Form1();
            int expected = 6;

            form.button6_Click(null, EventArgs.Empty);
            string output = form.display.Text;
            char number = output[^1];


            int lastDigit1 = (int)form.num1 % 10;
            int lastDigit2 = (int)form.num2 % 10;


            int displayed = int.Parse(number.ToString());


            Assert.That(lastDigit1 == expected && displayed == expected || lastDigit2 == expected && displayed == expected);

        }
        [Test]
        public void B7Test()
        {
            var form = new Form1();
            int expected = 7;

            form.button7_Click(null, EventArgs.Empty);
            string output = form.display.Text;
            char number = output[^1];


            int lastDigit1 = (int)form.num1 % 10;
            int lastDigit2 = (int)form.num2 % 10;


            int displayed = int.Parse(number.ToString());


            Assert.That(lastDigit1 == expected && displayed == expected || lastDigit2 == expected && displayed == expected);

        }
        [Test]
        public void B8Test()
        {
            var form = new Form1();
            int expected = 8;

            form.button8_Click(null, EventArgs.Empty);
            string output = form.display.Text;
            char number = output[^1];


            int lastDigit1 = (int)form.num1 % 10;
            int lastDigit2 = (int)form.num2 % 10;


            int displayed = int.Parse(number.ToString());


            Assert.That(lastDigit1 == expected && displayed == expected || lastDigit2 == expected && displayed == expected);

        }
        [Test]
        public void B9Test()
        {
            var form = new Form1();
            int expected = 9;

            form.button9_Click(null, EventArgs.Empty);
            string output = form.display.Text;
            char number = output[^1];


            int lastDigit1 = (int)form.num1 % 10;
            int lastDigit2 = (int)form.num2 % 10;


            int displayed = int.Parse(number.ToString());


            Assert.That(lastDigit1 == expected && displayed == expected || lastDigit2 == expected && displayed == expected);

        }
        [Test]
        public void B0Test()
        {
            var form = new Form1();
            int expected = 0;

            form.button0_Click(null, EventArgs.Empty);
            string output = form.display.Text;
            char number = output[^1];


            int lastDigit1 = (int)form.num1 % 10;
            int lastDigit2 = (int)form.num2 % 10;


            int displayed = int.Parse(number.ToString());


            Assert.That(lastDigit1 == expected && displayed == expected || lastDigit2 == expected && displayed == expected);

        }
        [Test]
        public void BADD()
        {
            var form = new Form1();
            form.buttonADD_Click(null, EventArgs.Empty);
            string output = form.display.Text;
            string sign = output.Substring(output.Length - 2);
            Assert.That(form.type == 1 || sign=="+ ");
        }
        [Test]
        public void BSUB()
        {
            var form = new Form1();
            form.buttonSUB_Click(null, EventArgs.Empty);
            string output = form.display.Text;
            string sign = output.Substring(output.Length - 2);
            Assert.That(form.type == 2 || sign == "- ");
        }
        [Test]
        public void BMUL()
        {
            var form = new Form1();
            form.buttonMUL_Click(null, EventArgs.Empty);
            string output = form.display.Text;
            string sign = output.Substring(output.Length - 2);
            Assert.That(form.type == 3 || sign == "* ");
        }
        [Test]
        public void BDIV()
        {
            var form = new Form1();
            form.buttonDIV_Click(null, EventArgs.Empty);
            string output = form.display.Text;
            string sign = output.Substring(output.Length - 2);
            Assert.That(form.type == 4 || sign == "/ ");
        }
        [Test]
        public void BPOW()
        {
            var form = new Form1();
            form.buttonPOW_Click(null, EventArgs.Empty);
            string output = form.display.Text;
            string sign = output.Substring(output.Length - 2);
           
            Assert.That(form.type == 5 || sign == "^ ");
        }
        [Test]
        public void BROOT()
        {
            var form = new Form1();
            form.buttonROOT_Click(null, EventArgs.Empty);
            string output = form.display.Text;
            string sign = output.Substring(output.Length - 2);
            Assert.That(form.type == 6 || sign == "√ ");
        }
        [Test]
        public void BLOG()
        {
            var form = new Form1();
            form.buttonLOG_Click(null, EventArgs.Empty);
            string output = form.display.Text;
            string sign = output.Substring(output.Length - 2);
            Assert.That(form.type == 7 || sign == "G ");
        }
        [Test]
        public void BEQ()
        {
            var form = new Form1();
            form.buttonEQ_Click(null, EventArgs.Empty);

            switch (form.type)
            {
                case 1:
                    Assert.That(form.result, Is.EqualTo(form.num1 + form.num2));
                    break;
                case 2:
                    Assert.That(form.result, Is.EqualTo(form.num1 - form.num2));
                    break;
                case 3:
                    Assert.That(form.result, Is.EqualTo(form.num1 * form.num2));
                    break;
                case 4:
                    Assert.That(form.result, Is.EqualTo(form.num1 / form.num2).Within(0.0001));
                    break;
                case 5:
                    Assert.That(form.result, Is.EqualTo(Math.Pow(form.num1, form.num2)).Within(0.0001));
                    break;
                case 6:
                    Assert.That(form.result, Is.EqualTo(Math.Pow(form.num1, 1.0 / form.num2)).Within(0.0001));
                    break;
                case 7:
                    Assert.That(form.result, Is.EqualTo(Math.Log(form.num1) / Math.Log(form.num2)).Within(0.0001));
                    break;
                default:
                    Assert.Fail("Nieznany typ operacji.");
                    break;
            }

        }
        public void BC()
        {
            var form = new Form1();
            form.buttonC_Click(null, EventArgs.Empty);
            string output = form.display.Text;
            
            Assert.That(string.Empty==output);
        }




    }
}