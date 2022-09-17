using System.Runtime.CompilerServices;

namespace CalculatorDelegate
{
    public partial class Form1 : Form
    {
        public static Form1 formInstance;
        programDelegate doot;
        public Form1()
        {
            InitializeComponent(); formInstance = this;
        }

        private void num1_Click(object sender, EventArgs e)
        {
            doot = new programDelegate(Program.num1);
            present.Text = doot(present.Text.ToString()).ToString();
        }
    }
}