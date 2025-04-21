namespace Test_Driven_Development_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        public bool part = false;
        public string text = string.Empty;
        public float num1 = 0;
        public float num2 = 0;
        public int type = 0;
        public float result = 0;


        public void write(string text)
        {
            display.Text = text;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            text += "1";
            if (part)
            {
                num2 = num2 * 10 + 1;

            }
            else
            {
                num1 = num1 * 10 + 1;
            }
            write(text);


        }

        public void button2_Click(object sender, EventArgs e)
        {
            text += "2";
            if (part)
            {
                num2 = num2 * 10 + 2;

            }
            else
            {
                num1 = num1 * 10 + 2;
            }
            write(text);
        }

        public void button3_Click(object sender, EventArgs e)
        {
            text += "3";
            if (part)
            {
                num2 = num2 * 10 + 3;

            }
            else
            {
                num1 = num1 * 10 + 3;
            }
            write(text);
        }

        public void button4_Click(object sender, EventArgs e)
        {
            text += "4";
            if (part)
            {
                num2 = num2 * 10 + 4;

            }
            else
            {
                num1 = num1 * 10 + 4;
            }
            write(text);
        }

        public void button5_Click(object sender, EventArgs e)
        {
            text += "5";
            if (part)
            {
                num2 = num2 * 10 + 5;

            }
            else
            {
                num1 = num1 * 10 + 5;
            }
            write(text);
        }

        public void button6_Click(object sender, EventArgs e)
        {
            text += "6";
            if (part)
            {
                num2 = num2 * 10 + 6;

            }
            else
            {
                num1 = num1 * 10 + 6;
            }
            write(text);
        }

        public void button7_Click(object sender, EventArgs e)
        {
            text += "7";
            if (part)
            {
                num2 = num2 * 10 + 7;

            }
            else
            {
                num1 = num1 * 10 + 7;
            }
            write(text);
        }

        public void button8_Click(object sender, EventArgs e)
        {
            text += "8";
            if (part)
            {
                num2 = num2 * 10 + 8;

            }
            else
            {
                num1 = num1 * 10 + 8;
            }
            write(text);
        }

        public void button9_Click(object sender, EventArgs e)
        {
            text += "9";
            if (part)
            {
                num2 = num2 * 10 + 9;

            }
            else
            {
                num1 = num1 * 10 + 9;
            }
            write(text);
        }

        public void button0_Click(object sender, EventArgs e)
        {
            text += "0";
            if (part)
            {
                num2 = num2 * 10 + 0;

            }
            else
            {
                num1 = num1 * 10 + 0;
            }
            write(text);
        }

        public void buttonC_Click(object sender, EventArgs e)
        {
            display.Text = string.Empty;
            num1 = 0;
            num2 = 0;
        }

        public void buttonADD_Click(object sender, EventArgs e)
        {

        }

        public void buttonSUB_Click(object sender, EventArgs e)
        {

        }

        public void buttonMUL_Click(object sender, EventArgs e)
        {

        }

        public void buttonDIV_Click(object sender, EventArgs e)
        {

        }

        public void buttonEQ_Click(object sender, EventArgs e)
        {

        }

        public void buttonPOW_Click(object sender, EventArgs e)
        {

        }

        public void buttonROOT_Click(object sender, EventArgs e)
        {

        }

        public void buttonLOG_Click(object sender, EventArgs e)
        {

        }
    }
}
