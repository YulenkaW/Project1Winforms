namespace Project1Winforms
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private int totalIncome = 0;
        const int STANDARD_MARRIED_DEDUCTIONS = 27_700;
        const int END_OF_10_PERCENT_BRACKET_MARRIED_2023 = 22_000;
        const int END_OF_12_PERCENT_BRACKET_MARRIED_2023 = 89_450;
        const int END_OF_22_PERCENT_BRACKET_MARRIED_2023 = 190_750;
        const int END_OF_24_PERCENT_BRACKET_MARRIED_2023 = 364_200;
        const int END_OF_32_PERCENT_BRACKET_MARRIED_2023 = 462_500;
        const int END_OF_35_PERCENT_BRACKET_MARRIED_2023 = 693_750;

        double getTaxesOwedAtBracket(int adjustedGrossIncome, double bracketRate, int bracketStart, int bracketEnd)
        {
            if (adjustedGrossIncome > bracketEnd)
            {
                return (bracketEnd - bracketStart) * bracketRate;
            }
            else if (adjustedGrossIncome < bracketStart)
            {
                return 0;
            }
            return (adjustedGrossIncome - bracketStart) * bracketRate;
        }

        int getTotal(string message)
        {
            int input = -1;
            int total = 0;

            while (input != 0)
            {
                total += input;
            }
            return total;
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            InitializeComponent();
            //this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            labelToClickMe.Text = " The standardDeduction = 13850";
        }
        //um gpt:To update the getTotal method for a Windows Forms application to be sure there is a button showing toaland income, when you press income it triggers the total andit shows on the sren

        private void addIncomeButton_Click(object sender, EventArgs e)
        {


            try
            {
                int currentIncome = int.Parse(incomeTextBox.Text);
                totalIncome += currentIncome;
                totalIncomeLabel.Text = $"Total Income: ${totalIncome}";

                incomeTextBox.Text = "";
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number.");
                incomeTextBox.Text = "";
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {


        }

      //  private void textBox1_TextChanged(object sender, EventArgs e)
        //{
            
        //}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            //using a winform textbox how do I trigger an event when the enter key is pressed
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                addIncomeButton_Click(sender, e);
            }

        }

        private void addIncomeButton_Click_1(object sender, EventArgs e)
        {

        }
    }
}