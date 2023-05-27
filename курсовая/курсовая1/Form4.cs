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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void medicineBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.medicineBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.aptekaDataSet1);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
           this.medicineTableAdapter1.Fill(this.aptekaDataSet1.Medicine);

            ToolTip tip = new ToolTip();
            tip.SetToolTip(TextBox, "Введите название препарата");
            tip.SetToolTip(textBox1, "Введите категорию");
            tip.SetToolTip(maskedTextBox1, "Введите цену");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 m = new Form2();
            m.WindowState = this.WindowState;
            this.Hide();
            m.Show();
        }

        private void InsertB_Click(object sender, EventArgs e)
        {
            medicineBindingSource.AddNew();
            MessageBox.Show("Товар добавлен");
        }

        private void deleteB_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "Удалить товар?",
               "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);

            if (result == DialogResult.Yes)
            {
                medicineBindingSource.RemoveCurrent();
            }
        }

        private void saveB_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.medicineBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.aptekaDataSet1);
            MessageBox.Show("Данные сохранены");
        }
    }
}
