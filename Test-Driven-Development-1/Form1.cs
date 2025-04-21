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

        }

        public void button3_Click(object sender, EventArgs e)
        {

        }

        public void button4_Click(object sender, EventArgs e)
        {

        }

        public void button5_Click(object sender, EventArgs e)
        {

        }

        public void button6_Click(object sender, EventArgs e)
        {

        }

        public void button7_Click(object sender, EventArgs e)
        {

        }

        public void button8_Click(object sender, EventArgs e)
        {

        }

        public void button9_Click(object sender, EventArgs e)
        {

        }

        public void button0_Click(object sender, EventArgs e)
        {

        }

        public void buttonC_Click(object sender, EventArgs e)
        {
            display.Text = string.Empty;
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
