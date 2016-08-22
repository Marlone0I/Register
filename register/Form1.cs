using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace register
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str, machine_code, reg_code;
            str = (textBox1.Text);                                      //str is the machine code
            machine_code = str;

            reg_code = get_reg_code(machine_code);
            textBox2.Text = reg_code;

            if (RegexValidate(machine_code) == false)
            {
                textBox1.Text = string.Empty;
            }
        }
        
        public static bool RegexValidate(string validateString)
        {           
            return Regex.IsMatch(validateString, @"^\d+$");             //判断机器码是否是数字的正则
        }

        public static string get_reg_code(string machine_code)
        {

            if (machine_code == string.Empty)
            {                
                MessageBox.Show("请输入机器码");
                return null;
            }
                    
            else if (RegexValidate(machine_code) == false)
            {
                MessageBox.Show("机器码应该是一串数字");
                return null;                
            }
            
            else
            {
                long num = Convert.ToInt64(machine_code);
                for (int i = 0; i < 100; i++)
                {
                    string text = (num * 2L).ToString();
                    if (text.Length <= 12)
                    {
                        num = Convert.ToInt64(text);
                    }
                    else
                    {
                        num = Convert.ToInt64(text.Substring(0, 12));
                    }
                }
                return num.ToString();
            }
        }
    }
}
