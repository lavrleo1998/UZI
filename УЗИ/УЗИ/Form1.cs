using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace УЗИ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<Shablon> shablons = new List<Shablon>
        {
            new Shablon {Name = "Розовая"},
            new Shablon {Name = "Красная"},
            new Shablon {Name = "Синяя"},
            new Shablon {Name = "Зеленая"},
            new Shablon {Name = "Желтая"}
        };

            comboBox1.DataSource = shablons;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Name";

            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        string NewShablon;

        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NewShablon = textBox1.Text;
            comboBox1.Items.Add(NewShablon);
        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //textBox1.Text = comboBox1.SelectedText.GetType(Name);

            Shablon shablon = (Shablon)comboBox1.SelectedItem;
            //comboBox1.Items.Add(shablon);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        class Shablon
        {
            public string Name { get; set; }
        }
    }
}
