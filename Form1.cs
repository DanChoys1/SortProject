﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SelectionSort;

namespace SortProject
{
    public partial class Form1 : Form {
        private List<int> arr = new List<int>();

        public Form1() {
            InitializeComponent();

            dataGridView3.Rows.Add();
            dataGridView3.Rows.Add();
            dataGridView3.Rows.Add();

            dataGridView3[0, 0].Value = "Выбором";
            dataGridView3[0, 1].Value = "Sort2";
            dataGridView3[0, 2].Value = "Sort3";
            dataGridView3[0, 3].Value = "Sort4";
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
            List<int> sortingArr = new List<int>(arr);

            if (sortingArr.Count > 0) {
                Selection sorter = new Selection();
                sorter.sort(sortingArr);

                dataGridView3[1, 0].Value = sorter.Comparison;
                dataGridView3[2, 0].Value = sorter.Permutation;

                for (int i = 0; i < sortingArr.Count; i++) {

                    if (i < dataGridView2.ColumnCount) {
                        dataGridView2.Rows[0].Cells[i].Value = sortingArr[i];
                    }

                    if (i >= dataGridView2.ColumnCount) {
                        dataGridView2.Columns.Add("Column" + (i + 1).ToString(), (i + 1).ToString());
                        dataGridView2.Rows[0].Cells[i].Value = sortingArr[i];
                    }
                }

                while (dataGridView1.Columns.Count < dataGridView2.Columns.Count) {
                    dataGridView2.Columns.RemoveAt(dataGridView2.Columns.Count - 1);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*            if (arr.Count > Convert.ToInt32(numericUpDown2.Value) - 1) {
                            arr.RemoveAt(Convert.ToInt32(numericUpDown2.Value) - 1);

                            dataGridView1.Columns.RemoveAt(dataGridView1.Columns.Count - 1);

                            for (int i = 0; i < arr.Count; i++) {
                                dataGridView1[i, 0].Value = arr[i];
                            }
                        }*/

            if (arr.Count > Convert.ToInt32(numericUpDown2.Value) - 1) {
                arr.RemoveAt(Convert.ToInt32(numericUpDown2.Value) - 1);

                dataGridView1.Columns.RemoveAt(Convert.ToInt32(numericUpDown2.Value) - 1);

                for (int i = Convert.ToInt32(numericUpDown2.Value) - 1; i < arr.Count; i++) {
                    dataGridView1.Columns[i].HeaderText = (i + 1).ToString();
                }
            }
        }
    }
}
