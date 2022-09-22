namespace CalculatorDelegate
{
    public delegate string programDelegate(String g);
    public delegate string functionDelegate(String g, String p);
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

        private static string last_clicked, v;
        public static string num1(String g)
        {
            v = g + "1";
            return v;
        }

        public static string num2(String g)
        {
            v = g + "2";
            return v;
        }

        public static string num3(String g)
        {
            v = g + "3";
            return v;
        }

        public static string num4(String g)
        {
            v = g + "4";
            return v;
        }

        public static string num5(String g)
        {
            v = g + "5";
            return v;
        }

        public static string num6(String g)
        {
            v = g + "6";
            return v;
        }

        public static string num7(String g)
        {
            v = g + "7";
            return v;
        }

        public static string num8(String g)
        {
            v = g + "8";
            return v;
        }

        public static string num9(String g)
        {
            v = g + "9";
            return v;
        }

        public static string plus(String g, String p)
        {
            Form1.formInstance.present.Text = "";
            last_clicked = "+";
            v = g + p + " + ";
            return v;
        }

    }
}