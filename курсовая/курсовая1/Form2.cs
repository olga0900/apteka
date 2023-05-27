using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace курсовая1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aptekaDataSet.Medicine". При необходимости она может быть перемещена или удалена.
            this.medicineTableAdapter.Fill(this.aptekaDataSet.Medicine);
            ToolTip tip = new ToolTip();
        tip.SetToolTip(comboBox1, "Выберете категорию для фильтрации");
            tip.SetToolTip(searchTextBox, "Введите ключевые слова для поиска");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }
        private System.Windows.Forms.DataGridViewColumn COL;

        private void button2_Click(object sender, EventArgs e)
        {
            COL = new System.Windows.Forms.DataGridViewColumn();
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    COL = medicinesNameDataGridViewTextBoxColumn;
                    break;
                case 1:
                    COL = categoryDataGridViewTextBoxColumn;
                    break;
                case 2:
                    COL = priceDataGridViewTextBoxColumn;
                    break;
            }
            if (radioButton1.Checked)
             dataGridView1.Sort(COL,
                 System.ComponentModel.ListSortDirection.Ascending);
            else
                dataGridView1.Sort(COL,
                 System.ComponentModel.ListSortDirection.Descending);
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            bindingSource1.Filter = "Category = '" + comboBox1.Text + "'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bindingSource1.RemoveFilter();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 med = new Form1();
            med.WindowState = this.WindowState;
            this.Hide();
            med.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int count = 0;
            //перебирает все ячейки таблицы и устанавливает в них белый цвет фона
            // и чёрный цвет текста, то есть отменяет результаты предыдущего поиска
            for (int i = 0; i < dataGridView1.ColumnCount - 1; i++)
            {
                for (int j = 0; j < dataGridView1.RowCount - 1; j++)
                {
                    dataGridView1[i, j].Style.BackColor = Color.White;
                    dataGridView1[i, j].Style.ForeColor = Color.Black;
                }
            }
            for (int i = 0; i < dataGridView1.ColumnCount - 1; i++)
            {
                for (int j = 0; j < dataGridView1.RowCount - 1; j++)
                {
                    if (dataGridView1[i, j].Value.ToString().IndexOf(searchTextBox.Text) != -1)
                    {
                        dataGridView1[i, j].Style.BackColor = Color.AliceBlue;
                        dataGridView1[i, j].Style.ForeColor = Color.Blue;
                        count++;
                    }
                }
            }
            if (count == 0)
            {
                MessageBox.Show("К сожалению не нашли такой товар");

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4 me = new Form4();
            me.WindowState = this.WindowState;
            this.Hide();
            me.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            ExcelApp.Application.Workbooks.Add(Type.Missing);
            ExcelApp.Columns.ColumnWidth = 15;

            ExcelApp.Cells[1, 1] = "Название";
            ExcelApp.Cells[1, 2] = "Категория";
            ExcelApp.Cells[1, 3] = "Цена";

            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                for (int j = 0; j < dataGridView1.RowCount; j++)
                {
                    ExcelApp.Cells[j + 2, i + 1] = (dataGridView1[i, j].Value).ToString();
                }
            }
            ExcelApp.Visible = true;
        }
    }
}
   

