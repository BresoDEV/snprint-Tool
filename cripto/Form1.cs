namespace cripto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(textBox1.Text.Length != 0)
            {
                textBox2.Text = "";

                List<string> strings = F.separar(textBox1.Text);
                string porc = "";
                string buf = "";
                foreach (string s in strings)
                {
                    porc += "%s";
                }

                foreach (string s in strings)
                {
                    buf += "_0x157(\"" + F.Cif(s) + "\"), ";
                }


                string g = F.gerar();
                string _1 = "char " + g + "[5000];";
                string _2 = "snprintf(" + g + ", 5000, ";
                string vvv = _1 + Environment.NewLine +
                    _2 + "\"" + porc + "\"," + buf + ");" + Environment.NewLine +
                    "//usa " + g + " onde quiser o texto";

                vvv = vvv.Replace(", );", ");");
                textBox2.Text += vvv;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";

            string A = "std::string _0x157(const std::string& msg){" + Environment.NewLine;
            string C = " std::string r = \"\";" + Environment.NewLine;
            string D = " for(char c : msg) {" + Environment.NewLine;
            string F = "  if(isalpha(c)){" + Environment.NewLine;
            string H = "   char cf =(toupper(c) - 'A' + 7) % 26 + 'A';" + Environment.NewLine;
            string I = "   r += (islower(c) ? tolower(cf) : cf);}" + Environment.NewLine;
            string K = "  else { r += c;}" + Environment.NewLine;
            string O = "  }" + Environment.NewLine;
            string P = " return r;" + Environment.NewLine;
            string Q = "}" + Environment.NewLine;

            textBox2.Text = A + C + D + F + H + I +
                K +  O + P + Q;
        }
    }
}