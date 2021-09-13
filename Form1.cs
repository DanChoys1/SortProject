using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> arr = new List<int>();

        private void button1_Click(object sender, EventArgs e)
        {
            arr.Add(Convert.ToInt32(numericUpDown1.Value));

            if (arr.Count <= 5)
            {
                dataGridView1.Rows[0].Cells[arr.Count - 1].Value = arr[arr.Count - 1];
            }

            if (arr.Count > 5)
            {
                DataGridViewColumn column = new DataGridViewColumn(dataGridView1.Columns[0].CellTemplate);

                column.Name = "Column" + arr.Count.ToString();
                column.HeaderText = arr.Count.ToString();
                column.Tag = arr.Count - 1;

                dataGridView1.Columns.Add(column);

                dataGridView1.Rows[0].Cells[arr.Count - 1].Value = arr[arr.Count - 1];
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            arr.Sort();

            for (int i = 0; i < arr.Count; i++)
            {

                if (i < dataGridView2.ColumnCount)
                {
                    dataGridView2.Rows[0].Cells[i].Value = arr[i];
                }

                if (i >= dataGridView2.ColumnCount)
                {
                    DataGridViewColumn column = new DataGridViewColumn(dataGridView2.Columns[0].CellTemplate);

                    column.Name = "Column" + (i + 1).ToString();
                    column.HeaderText = (i + 1).ToString();
                    column.Tag = i;

                    dataGridView2.Columns.Add(column);

                    dataGridView2.Rows[0].Cells[i].Value = arr[i];
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            arr.Remove(Convert.ToInt32(numericUpDown2.Value));

            /*dataGridView1.Rows.RemoveAt(0);*/

            /*int rowsCount = dataGridView1.Rows.Count;
            for (int i = 0; i < rowsCount; i++)
            {
                dataGridView1.Rows.Remove(dataGridView1.Rows[0]);
            }*/

            this.dataGridView1.Rows.Clear();  // удаление всех строк
            int count = this.dataGridView1.Columns.Count;
            for (int i = 0; i < count; i++)     // цикл удаления всех столбцов
            {
                this.dataGridView1.Columns.RemoveAt(0);
            }

            for (int i = 0; i < arr.Count; i++)
            {
                DataGridViewColumn column = new DataGridViewColumn(dataGridView2.Columns[0].CellTemplate);

                column.Name = "Column" + (i + 1).ToString();
                column.HeaderText = (i + 1).ToString();
                column.Tag = i;

                dataGridView1.Columns.Add(column);

                dataGridView1.Rows[0].Cells[i].Value = arr[i];
            }
        }
    }
}
