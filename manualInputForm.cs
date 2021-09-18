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
using QuickSort;

namespace SortProject {
    public partial class manualInputForm : Form {

        private List<int> arr = new List<int>();

        public manualInputForm() {
            InitializeComponent();

            premutationComparisonDataGridView.Rows.Add();
            premutationComparisonDataGridView.Rows.Add();
            premutationComparisonDataGridView.Rows.Add();
            
            premutationComparisonDataGridView[0, 0].Value = "Пузырьком";
            premutationComparisonDataGridView[0, 1].Value = "Быстрая";
            premutationComparisonDataGridView[0, 2].Value = "Выбором";
            premutationComparisonDataGridView[0, 3].Value = "Слиянием";
        }

        private void enterButton_Click(object sender, EventArgs e) {
            arr.Add(Convert.ToInt32(newItemNumeric.Value));

            if (arr.Count <= enterArrayDataGridView.Columns.Count) {
                enterArrayDataGridView.Rows[0].Cells[arr.Count - 1].Value = arr[arr.Count - 1];
            }

            if (arr.Count > enterArrayDataGridView.Columns.Count) {
                enterArrayDataGridView.Columns.Add("Column" + arr.Count.ToString(), arr.Count.ToString());
                enterArrayDataGridView.Rows[0].Cells[arr.Count - 1].Value = arr[arr.Count - 1];
            }

        }

        private void sortButton_Click(object sender, EventArgs e) {
            List<int> bubbleArr = new List<int>(arr);
            List<int> quickArr = new List<int>(arr);
            List<int> selectionArr = new List<int>(arr);
            List<int> margetArr = new List<int>(arr);

            if (arr.Count > 0) {
                ISort []sorter = {new Bubble(), new Quick(), new Selection(), new MergeSort()};

                sorter[0].sort(bubbleArr, upRadioButton.Checked);
                premutationComparisonDataGridView[1, 0].Value = sorter[0].Comparison;
                premutationComparisonDataGridView[2, 0].Value = sorter[0].Permutation;

                sorter[1].sort(quickArr, upRadioButton.Checked);
                premutationComparisonDataGridView[1, 1].Value = sorter[1].Comparison;
                premutationComparisonDataGridView[2, 1].Value = sorter[1].Permutation;

                sorter[2].sort(selectionArr, upRadioButton.Checked);
                premutationComparisonDataGridView[1, 2].Value = sorter[2].Comparison;
                premutationComparisonDataGridView[2, 2].Value = sorter[2].Permutation;

                sorter[3].sort(margetArr, upRadioButton.Checked);
                premutationComparisonDataGridView[1, 3].Value = sorter[3].Comparison;
                premutationComparisonDataGridView[2, 3].Value = sorter[3].Permutation;


                for (int i = 0; i < arr.Count; i++) {

                    if (i < sortArrayDataGridView.ColumnCount) {
                        sortArrayDataGridView.Rows[0].Cells[i].Value = bubbleArr[i];
                    }

                    if (i >= sortArrayDataGridView.ColumnCount) {
                        sortArrayDataGridView.Columns.Add("Column" + (i + 1).ToString(), (i + 1).ToString());
                        sortArrayDataGridView.Rows[0].Cells[i].Value = bubbleArr[i];
                    }
                }

                while (enterArrayDataGridView.Columns.Count < sortArrayDataGridView.Columns.Count) {
                    sortArrayDataGridView.Columns.RemoveAt(sortArrayDataGridView.Columns.Count - 1);
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e) {
            if (arr.Count > Convert.ToInt32(deleteItemNumeric.Value) - 1) {

                arr.RemoveAt(Convert.ToInt32(deleteItemNumeric.Value) - 1);
                enterArrayDataGridView.Columns.RemoveAt(Convert.ToInt32(deleteItemNumeric.Value) - 1);

                for (int i = Convert.ToInt32(deleteItemNumeric.Value) - 1; i < arr.Count; i++) {
                    enterArrayDataGridView.Columns[i].HeaderText = (i + 1).ToString();
                }
            }
        }

        private void manualInputFormButton_Click(object sender, EventArgs e) {
            Control [] manualInputObject = { newItemLabel, deleteLabel, enterButton, deleteButton, 
                                            sortButton, newItemNumeric, deleteItemNumeric};

            Control[] randomInputObject = { amountElementsLabel, selectionArrayBoundariesLabel, rightLabel,
                                            leftBorderLabel, amountElementsNumeric, leftBorderNumeric, rightBorderNumeric, 
                                            inputRandomArrButton, inputSortAscendingRandomArrButton, inputSortDescendingRandomArrButton};

            for (int i = 0; i < randomInputObject.Length; i++) {

                if (randomInputObject[i].Visible) {
                    randomInputObject[i].Visible = false;
                }

            }

            for (int i = 0; i < manualInputObject.Length; i++) {

                if (!manualInputObject[i].Visible) {
                    manualInputObject[i].Visible = true;
                }

            }
        }

        private void randomInputFormButton_Click(object sender, EventArgs e) {
            Control[] manualInputObject = { newItemLabel, deleteLabel, enterButton, deleteButton,
                                            sortButton, newItemNumeric, deleteItemNumeric};

            Control[] randomInputObject = { amountElementsLabel, selectionArrayBoundariesLabel, rightLabel,
                                            leftBorderLabel, amountElementsNumeric, leftBorderNumeric, rightBorderNumeric,
                                            inputRandomArrButton, inputSortAscendingRandomArrButton, inputSortDescendingRandomArrButton};

            for (int i = 0; i < manualInputObject.Length; i++) {

                if (manualInputObject[i].Visible) {
                    manualInputObject[i].Visible = false;
                }

            }

            for (int i = 0; i < randomInputObject.Length; i++) {

                if (!randomInputObject[i].Visible) {
                    randomInputObject[i].Visible = true;
                }

            }
        }

        private void testButton_Click(object sender, EventArgs e) {
            Test test = new Test();

            if (test.Tests()) {
                MessageBox.Show("Все тесты были пройдены.", "Тестирование");
            } else {
                MessageBox.Show("Тестирование не было пройдено.", "Тестирование");
            }
        }

        private void closeProgramButton_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void inputRandomArrButton_Click(object sender, EventArgs e) {   
            Random rand = new Random();

            if(enterArrayDataGridView.Columns.Count > 0) {
                enterArrayDataGridView.Columns.Clear();
            }

            if (arr.Count > 0) {
                arr.Clear();
            }

            for (int i = 0; i < amountElementsNumeric.Value; i++) {
                arr.Add(rand.Next(Convert.ToInt32(leftBorderNumeric.Value), Convert.ToInt32(rightBorderNumeric.Value) + 1));

                enterArrayDataGridView.Columns.Add("Column" + arr.Count.ToString(), arr.Count.ToString());
                enterArrayDataGridView.Rows[0].Cells[i].Value = arr[i];
            }

            sortButton_Click(sender, e);
        }

        private void inputSortAscendingRandomArrButton_Click(object sender, EventArgs e) {
            Random rand = new Random();

            if (enterArrayDataGridView.Columns.Count > 0) {
                enterArrayDataGridView.Columns.Clear();
            }

            if (arr.Count > 0) {
                arr.Clear();
            }

            for (int i = 0; i < amountElementsNumeric.Value; i++) {
                arr.Add(rand.Next(Convert.ToInt32(leftBorderNumeric.Value), Convert.ToInt32(rightBorderNumeric.Value) + 1));
            }

            arr.Sort();

            for (int i = 0; i < amountElementsNumeric.Value; i++) {
                enterArrayDataGridView.Columns.Add("Column" + arr.Count.ToString(), arr.Count.ToString());
                enterArrayDataGridView.Rows[0].Cells[i].Value = arr[i];
            }

            sortButton_Click(sender, e);
        }

        private void inputSortDescendingRandomArrButton_Click(object sender, EventArgs e) {
            Random rand = new Random();

            if (enterArrayDataGridView.Columns.Count > 0) {
                enterArrayDataGridView.Columns.Clear();
            }

            if (arr.Count > 0) {
                arr.Clear();
            }

            for (int i = 0; i < amountElementsNumeric.Value; i++) {
                arr.Add(rand.Next(Convert.ToInt32(leftBorderNumeric.Value), Convert.ToInt32(rightBorderNumeric.Value) + 1));
            }

            arr.Sort();
            arr.Reverse();

            for (int i = 0; i < amountElementsNumeric.Value; i++) {
                enterArrayDataGridView.Columns.Add("Column" + arr.Count.ToString(), arr.Count.ToString());
                enterArrayDataGridView.Rows[0].Cells[i].Value = arr[i];
            }

            sortButton_Click(sender, e);
        }
    }
}