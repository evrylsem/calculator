namespace Calculator
{
    public partial class Form1 : Form
    {
        double result = 0;
        String operatorUsed = "";
        bool isPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }


        private void resetBtn_MouseClick(object sender, MouseEventArgs e)
        {
            output.Clear();
        }

        private void operatorBtn(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            operatorUsed = btn.Text;
            result = Double.Parse(output.Text);
            isPerformed = true;
            output.Clear();
            btn.BackColor = Color.FromArgb(182, 113, 98);
            btn.ForeColor = Color.FromArgb(246, 230, 203);
        }

        private void numBtn(object sender, MouseEventArgs e)
        {
            if (output.Text == "0")
            {
                output.Clear();
            }
            Button btn = (Button)sender;
            output.AppendText(btn.Text);
            isPerformed = false;

        }

        private void equalBtn_MouseClick(object sender, MouseEventArgs e)
        {
            double num = Double.Parse(output.Text);
            switch (operatorUsed)
            {
                case "+":
                    addBtn.BackColor = Color.FromArgb(160, 147, 125);
                    addBtn.ForeColor = Color.FromArgb(118, 69, 59);
                    output.Text = (result + num).ToString();
                    break;
                case "-":
                    subBtn.BackColor = Color.FromArgb(160, 147, 125);
                    subBtn.ForeColor = Color.FromArgb(118, 69, 59);
                    output.Text = (result - num).ToString();
                    break;
                case "*":
                    mulBtn.BackColor = Color.FromArgb(160, 147, 125);
                    mulBtn.ForeColor = Color.FromArgb(118, 69, 59);
                    output.Text = (result * num).ToString();
                    break;
                case "/":
                    divBtn.BackColor = Color.FromArgb(160, 147, 125);
                    divBtn.ForeColor = Color.FromArgb(118, 69, 59);
                    if (result == 0 || num == 0)
                        output.Text = "Error!";
                    else
                        output.Text = (result / num).ToString();
                    break;
                default:
                    break;
            }
        }

        private void clearBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if(output.Text.Length > 0)
            {
                output.Text = output.Text.Remove(output.Text.Length - 1, 1);
            }
        }
    }
}
