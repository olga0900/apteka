using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace курсовая1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 m = new Form2();
            m.WindowState = this.WindowState;
            this.Hide();
            m.button6.Visible = bool.Parse(Tag.ToString());
            m.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 s = new Form3();
            s.WindowState = this.WindowState;
            this.Hide();
            s.button7.Visible = bool.Parse(Tag.ToString());
            s.Show(); ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            Close();
        }
    }
}
