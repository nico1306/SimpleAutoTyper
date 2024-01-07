namespace SimpleAutoTyper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            String text = tb_inputtext.Text;
            //Wait so user can navigate to window
            Thread.Sleep(3000);

            //used from Password generator
            //So the characters below can be typed without problems
            //they need to be in {}
            string strangeletters = "!§$%&/()=?_:;><|+#{}";
            foreach (char c in text)
            {
                if (strangeletters.Contains(c.ToString()))
                {
                    writeKey("{" + c.ToString() + "}");
                }
                else
                {
                    writeKey(c.ToString());
                }
            }
        }

        void writeKey(string key)
        {
            SendKeys.SendWait(key);
        }
    }
}