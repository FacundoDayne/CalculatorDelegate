using System.Runtime.CompilerServices;

namespace CalculatorDelegate
{
    public partial class Form1 : Form
    {
        public static Form1 formInstance;
        programDelegate doot; functionDelegate boot;
        public Form1()
        {
            InitializeComponent(); formInstance = this;
        }

        private void num1_Click(object sender, EventArgs e)
        {
            doot = new programDelegate(Program.num1);
            present.Text = doot(present.Text.ToString()).ToString();
        }

        private void num2_Click(object sender, EventArgs e)
        {
            doot = new programDelegate(Program.num2);
            present.Text = doot(present.Text.ToString()).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            doot = new programDelegate(Program.num3);
            present.Text = doot(present.Text.ToString()).ToString();
        }

        private void num4_Click(object sender, EventArgs e)
        {
            doot = new programDelegate(Program.num4);
            present.Text = doot(present.Text.ToString()).ToString();
        }
        private void num5_Click(object sender, EventArgs e)
        {
            doot = new programDelegate(Program.num5);
            present.Text = doot(present.Text.ToString()).ToString();
        }

        private void num6_Click(object sender, EventArgs e)
        {
            doot = new programDelegate(Program.num6);
            present.Text = doot(present.Text.ToString()).ToString();
        }

        private void num7_Click(object sender, EventArgs e)
        {
            doot = new programDelegate(Program.num7);
            present.Text = doot(present.Text.ToString()).ToString();
        }

        private void num8_Click(object sender, EventArgs e)
        {
            doot = new programDelegate(Program.num8);
            present.Text = doot(present.Text.ToString()).ToString();
        }

        private void num9_Click(object sender, EventArgs e)
        {
            doot = new programDelegate(Program.num9);
            present.Text = doot(present.Text.ToString()).ToString();
        }

        private void plus_Click(object sender, EventArgs e)
        {
            boot = new functionDelegate(Program.plus);
            past.Text = boot(past.Text.ToString(), present.Text.ToString()).ToString();
        }

        private void equals_Click(object sender, EventArgs e)
        {
            
        }
    }
}