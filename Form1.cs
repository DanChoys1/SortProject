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

            dataGridView3.Rows.Add();
            dataGridView3.Rows.Add();
            dataGridView3.Rows.Add();

            dataGridView3[0, 0].Value = "Sort1";
            dataGridView3[0, 1].Value = "Sort2";
            dataGridView3[0, 2].Value = "Sort3";
            dataGridView3[0, 3].Value = "Sort4";
        }

        private List<int> arr = new List<int>();

        private void button1_Click(object sender, EventArgs e)
        {
            arr.Add(Convert.ToInt32(numericUpDown1.Value));

            if (arr.Count <= dataGridView1.Columns.Count)
            {
                dataGridView1.Rows[0].Cells[arr.Count - 1].Value = arr[arr.Count - 1];
            }

            if (arr.Count > dataGridView1.Columns.Count)
            {
                dataGridView1.Columns.Add("Column" + arr.Count.ToString(), arr.Count.ToString());
                dataGridView1.Rows[0].Cells[arr.Count - 1].Value = arr[arr.Count - 1];
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (arr.Count > 0) {
                arr.Sort();

                for (int i = 0; i < arr.Count; i++) {

                    if (i < dataGridView2.ColumnCount) {
                        dataGridView2.Rows[0].Cells[i].Value = arr[i];
                    }

                    if (i >= dataGridView2.ColumnCount) {
                        dataGridView2.Columns.Add("Column" + (i + 1).ToString(), (i + 1).ToString());
                        dataGridView2.Rows[0].Cells[i].Value = arr[i];
                    }
                }

                while (dataGridView1.Columns.Count < dataGridView2.Columns.Count) {
                    dataGridView2.Columns.RemoveAt(dataGridView2.Columns.Count - 1);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (arr.Count > 0) {
                arr.RemoveAt(Convert.ToInt32(numericUpDown2.Value) - 1);

                dataGridView1.Columns.RemoveAt(dataGridView1.Columns.Count - 1);

                for (int i = 0; i < arr.Count; i++) {
                    dataGridView1[i, 0].Value = arr[i];
                }
            }
        }
    }
}
