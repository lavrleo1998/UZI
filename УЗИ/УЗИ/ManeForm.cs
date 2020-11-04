using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using УЗИ.Properties;

namespace УЗИ
{
    public partial class ManeForm : Form
    {
        public ManeForm()
        {
            InitializeComponent();
        }

        public void NewWindows()
        {
            Form1 form1 = new Form1();
            form1.Show();
        }
        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            NewWindows();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConnectDB formdb = new ConnectDB();
            formdb.Show();
        }
    }
}
