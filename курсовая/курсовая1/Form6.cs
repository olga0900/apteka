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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.aptekaDataSet1);

        }
        private void Form6_Load(object sender, EventArgs e)
        {
            this.clientTableAdapter1.Fill(this.aptekaDataSet1.Client);

            ToolTip tip = new ToolTip();
            tip.SetToolTip(clientNameTextBox, "Введите имя");
            tip.SetToolTip(maskedTextBox1, "Введите номер");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Form3 r = new Form3();
            r.WindowState = this.WindowState;

            this.Hide();
            r.Show();
        }

        private void InsertB_Click(object sender, EventArgs e)
        {
            clientBindingSource.AddNew();
            MessageBox.Show("Покупатель добавлен");
        }

        private void deleteB_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
              "Удалить покупателя?",
              "Сообщение",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Information,
               MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes)
            {
                clientBindingSource.RemoveCurrent();
            }
        }

        private void saveB_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.aptekaDataSet1);
            MessageBox.Show("Данные сохранены");
        }

       
    }
}
