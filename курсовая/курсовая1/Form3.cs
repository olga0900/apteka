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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            Form1 med = new Form1();
            med.WindowState = this.WindowState;
            this.Hide();
            med.Show();
        }

       

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.aptekaDataSet1);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.clientTableAdapter1.Fill(this.aptekaDataSet1.Client);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form6 me = new Form6();
            me.WindowState = this.WindowState;

            this.Hide();
            me.Show();
        }
    }
}
