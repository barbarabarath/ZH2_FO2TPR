using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZH2_FO2TPR
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl1 userControl1 = new UserControl1();
            panel1.Controls.Add(userControl1);
            userControl1.Dock = DockStyle.Fill;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl2 userControl2 = new UserControl2();
            panel1.Controls.Add(userControl2);
            userControl2.Dock = DockStyle.Fill;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl3 userControl3 = new UserControl3();
            panel1.Controls.Add(userControl3);
            userControl3.Dock = DockStyle.Fill;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Biztos ki szeretne lépni?", "Kilépés", MessageBoxButtons.OKCancel);
            if (result != DialogResult.OK) { e.Cancel = true; }
            else { System.Environment.Exit(1); }
        }
    }
}
