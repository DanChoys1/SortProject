using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SelectionSort;
using Sort;
using BubbleSort;
using Quick;

namespace SortProject
{
    public partial class Form1 : Form {
        private List<int> arr = new List<int>();

        public Form1() {
            InitializeComponent();

            dataGridView3.Rows.Add();
            dataGridView3.Rows.Add();
            dataGridView3.Rows.Add();
            
            dataGridView3[0, 0].Value = "Пузырьком";
            dataGridView3[0, 1].Value = "Быстрая";
            dataGridView3[0, 2].Value = "Выбором";
            dataGridView3[0, 3].Value = "Слиянием";
        }

        private void button1_Click(object sender, EventArgs e) {
            arr.Add(Convert.ToInt32(numericUpDown1.Value));

            if (arr.Count <= dataGridView1.Columns.Count) {
                dataGridView1.Rows[0].Cells[arr.Count - 1].Value = arr[arr.Count - 1];
            }

            if (arr.Count > dataGridView1.Columns.Count) {
                dataGridView1.Columns.Add("Column" + arr.Count.ToString(), arr.Count.ToString());
                dataGridView1.Rows[0].Cells[arr.Count - 1].Value = arr[arr.Count - 1];
            }

        }

        private void button2_Click(object sender, EventArgs e) {
            List<int> bubbleArr = new List<int>(arr);
            List<int> quickArr = new List<int>(arr);
            List<int> selectionArr = new List<int>(arr);
            List<int> margetArr = new List<int>(arr);

            if (arr.Count > 0) {
                ISort []sorter = {new Bubble(), new QuickSort(), new Selection(), new MergeSort()};
                /*  selectionSorter.sort(sortingArr, true);

                  dataGridView3[1, 0].Value = sorter.Comparison;
                  dataGridView3[2, 0].Value = sorter.Permutation;*/

                sorter[0].sort(bubbleArr, radioButton1.Checked);
                dataGridView3[1, 0].Value = sorter[0].Comparison;
                dataGridView3[2, 0].Value = sorter[0].Permutation;

                sorter[1].sort(quickArr, radioButton1.Checked);
                dataGridView3[1, 1].Value = sorter[1].Comparison;
                dataGridView3[2, 1].Value = sorter[1].Permutation;

                sorter[2].sort(selectionArr, radioButton1.Checked);
                dataGridView3[1, 2].Value = sorter[2].Comparison;
                dataGridView3[2, 2].Value = sorter[2].Permutation;

                sorter[3].sort(margetArr, radioButton1.Checked);
                dataGridView3[1, 3].Value = sorter[3].Comparison;
                dataGridView3[2, 3].Value = sorter[3].Permutation;


                for (int i = 0; i < arr.Count; i++) {

                    if (i < dataGridView2.ColumnCount) {
                        dataGridView2.Rows[0].Cells[i].Value = bubbleArr[i];
                    }

                    if (i >= dataGridView2.ColumnCount) {
                        dataGridView2.Columns.Add("Column" + (i + 1).ToString(), (i + 1).ToString());
                        dataGridView2.Rows[0].Cells[i].Value = bubbleArr[i];
                    }
                }

                while (dataGridView1.Columns.Count < dataGridView2.Columns.Count) {
                    dataGridView2.Columns.RemoveAt(dataGridView2.Columns.Count - 1);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (arr.Count > Convert.ToInt32(numericUpDown2.Value) - 1) {
                arr.RemoveAt(Convert.ToInt32(numericUpDown2.Value) - 1);

                dataGridView1.Columns.RemoveAt(Convert.ToInt32(numericUpDown2.Value) - 1);

                for (int i = Convert.ToInt32(numericUpDown2.Value) - 1; i < arr.Count; i++) {
                    dataGridView1.Columns[i].HeaderText = (i + 1).ToString();
                }
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Работу выполнили:\nАзаров Д.К.\nАбрамян Л.К.\nБездудина О.Е.\nГаланов М.Э.", "О программе");
        }
    }
}
