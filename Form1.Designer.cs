
namespace SortProject {
    partial class manualInputForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {

            if (disposing && (components != null))  {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.enterArrayDataGridView = new System.Windows.Forms.DataGridView();
            this.newItemNumeric = new System.Windows.Forms.NumericUpDown();
            this.enterButton = new System.Windows.Forms.Button();
            this.sortArrayDataGridView = new System.Windows.Forms.DataGridView();
            this.sortButton = new System.Windows.Forms.Button();
            this.deleteItemNumeric = new System.Windows.Forms.NumericUpDown();
            this.deleteButton = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newItemLabel = new System.Windows.Forms.Label();
            this.deleteLabel = new System.Windows.Forms.Label();
            this.enterTableLabel = new System.Windows.Forms.Label();
            this.sortedArrayLabel = new System.Windows.Forms.Label();
            this.premutationComparisonDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.label = new System.Windows.Forms.Label();
            this.sortingForGroupBox = new System.Windows.Forms.GroupBox();
            this.downRadioButton = new System.Windows.Forms.RadioButton();
            this.upRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.enterArrayDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newItemNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sortArrayDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteItemNumeric)).BeginInit();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.premutationComparisonDataGridView)).BeginInit();
            this.sortingForGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // enterArrayDataGridView
            // 
            this.enterArrayDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.enterArrayDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.enterArrayDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.enterArrayDataGridView.Location = new System.Drawing.Point(274, 52);
            this.enterArrayDataGridView.Name = "enterArrayDataGridView";
            this.enterArrayDataGridView.RowHeadersVisible = false;
            this.enterArrayDataGridView.RowHeadersWidth = 62;
            this.enterArrayDataGridView.RowTemplate.Height = 25;
            this.enterArrayDataGridView.Size = new System.Drawing.Size(494, 64);
            this.enterArrayDataGridView.TabIndex = 3;
            // 
            // newItemNumeric
            // 
            this.newItemNumeric.Location = new System.Drawing.Point(12, 52);
            this.newItemNumeric.Maximum = new decimal(new int[] {
            -1593835520,
            466537709,
            54210,
            0});
            this.newItemNumeric.Minimum = new decimal(new int[] {
            -1593835520,
            466537709,
            54210,
            -2147483648});
            this.newItemNumeric.Name = "newItemNumeric";
            this.newItemNumeric.Size = new System.Drawing.Size(120, 23);
            this.newItemNumeric.TabIndex = 4;
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(150, 52);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 22);
            this.enterButton.TabIndex = 5;
            this.enterButton.Text = "Ввести";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // sortArrayDataGridView
            // 
            this.sortArrayDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.sortArrayDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sortArrayDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.sortArrayDataGridView.Location = new System.Drawing.Point(274, 148);
            this.sortArrayDataGridView.Name = "sortArrayDataGridView";
            this.sortArrayDataGridView.RowHeadersVisible = false;
            this.sortArrayDataGridView.RowHeadersWidth = 62;
            this.sortArrayDataGridView.RowTemplate.Height = 25;
            this.sortArrayDataGridView.Size = new System.Drawing.Size(494, 64);
            this.sortArrayDataGridView.TabIndex = 6;
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(12, 249);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(213, 46);
            this.sortButton.TabIndex = 7;
            this.sortButton.Text = "Сортировать";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // deleteItemNumeric
            // 
            this.deleteItemNumeric.Location = new System.Drawing.Point(12, 106);
            this.deleteItemNumeric.Maximum = new decimal(new int[] {
            -1593835520,
            466537709,
            54210,
            0});
            this.deleteItemNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.deleteItemNumeric.Name = "deleteItemNumeric";
            this.deleteItemNumeric.Size = new System.Drawing.Size(120, 23);
            this.deleteItemNumeric.TabIndex = 8;
            this.deleteItemNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(150, 106);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 22);
            this.deleteButton.TabIndex = 9;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 10;
            this.menuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.файлToolStripMenuItem.Text = "Тест";
            this.файлToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.aboutProgramToolStripMenuItem_Click);
            // 
            // newItemLabel
            // 
            this.newItemLabel.AutoSize = true;
            this.newItemLabel.Location = new System.Drawing.Point(12, 34);
            this.newItemLabel.Name = "newItemLabel";
            this.newItemLabel.Size = new System.Drawing.Size(132, 15);
            this.newItemLabel.TabIndex = 11;
            this.newItemLabel.Text = "Ввести новый элемент";
            // 
            // deleteLabel
            // 
            this.deleteLabel.AutoSize = true;
            this.deleteLabel.Location = new System.Drawing.Point(12, 88);
            this.deleteLabel.Name = "deleteLabel";
            this.deleteLabel.Size = new System.Drawing.Size(164, 15);
            this.deleteLabel.TabIndex = 12;
            this.deleteLabel.Text = "Удалить элемент по индексу";
            // 
            // enterTableLabel
            // 
            this.enterTableLabel.AutoSize = true;
            this.enterTableLabel.Location = new System.Drawing.Point(274, 34);
            this.enterTableLabel.Name = "enterTableLabel";
            this.enterTableLabel.Size = new System.Drawing.Size(111, 15);
            this.enterTableLabel.TabIndex = 13;
            this.enterTableLabel.Text = "Введённый массив";
            // 
            // sortedArrayLabel
            // 
            this.sortedArrayLabel.AutoSize = true;
            this.sortedArrayLabel.Location = new System.Drawing.Point(274, 130);
            this.sortedArrayLabel.Name = "sortedArrayLabel";
            this.sortedArrayLabel.Size = new System.Drawing.Size(152, 15);
            this.sortedArrayLabel.TabIndex = 14;
            this.sortedArrayLabel.Text = "Отсортированный массив";
            // 
            // premutationComparisonDataGridView
            // 
            this.premutationComparisonDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.premutationComparisonDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.premutationComparisonDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.premutationComparisonDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.premutationComparisonDataGridView.Location = new System.Drawing.Point(274, 249);
            this.premutationComparisonDataGridView.MultiSelect = false;
            this.premutationComparisonDataGridView.Name = "premutationComparisonDataGridView";
            this.premutationComparisonDataGridView.ReadOnly = true;
            this.premutationComparisonDataGridView.RowHeadersVisible = false;
            this.premutationComparisonDataGridView.RowHeadersWidth = 62;
            this.premutationComparisonDataGridView.RowTemplate.Height = 25;
            this.premutationComparisonDataGridView.Size = new System.Drawing.Size(494, 125);
            this.premutationComparisonDataGridView.TabIndex = 15;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Тип сортировки";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 223;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Кол-во сравнений";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 134;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Кол-во перестановок";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 134;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(274, 231);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(85, 15);
            this.label.TabIndex = 16;
            this.label.Text = "Перестановки";
            // 
            // sortingForGroupBox
            // 
            this.sortingForGroupBox.Controls.Add(this.downRadioButton);
            this.sortingForGroupBox.Controls.Add(this.upRadioButton);
            this.sortingForGroupBox.Location = new System.Drawing.Point(12, 148);
            this.sortingForGroupBox.Name = "sortingForGroupBox";
            this.sortingForGroupBox.Size = new System.Drawing.Size(213, 82);
            this.sortingForGroupBox.TabIndex = 17;
            this.sortingForGroupBox.TabStop = false;
            this.sortingForGroupBox.Text = "Сортировать по";
            // 
            // downRadioButton
            // 
            this.downRadioButton.AutoSize = true;
            this.downRadioButton.Location = new System.Drawing.Point(9, 48);
            this.downRadioButton.Name = "downRadioButton";
            this.downRadioButton.Size = new System.Drawing.Size(83, 19);
            this.downRadioButton.TabIndex = 1;
            this.downRadioButton.Text = "убыванию";
            this.downRadioButton.UseVisualStyleBackColor = true;
            // 
            // upRadioButton
            // 
            this.upRadioButton.AutoSize = true;
            this.upRadioButton.Checked = true;
            this.upRadioButton.Location = new System.Drawing.Point(9, 22);
            this.upRadioButton.Name = "upRadioButton";
            this.upRadioButton.Size = new System.Drawing.Size(97, 19);
            this.upRadioButton.TabIndex = 0;
            this.upRadioButton.TabStop = true;
            this.upRadioButton.Text = "возрастанию";
            this.upRadioButton.UseVisualStyleBackColor = true;
            // 
            // manualInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 411);
            this.Controls.Add(this.sortingForGroupBox);
            this.Controls.Add(this.label);
            this.Controls.Add(this.premutationComparisonDataGridView);
            this.Controls.Add(this.sortedArrayLabel);
            this.Controls.Add(this.enterTableLabel);
            this.Controls.Add(this.deleteLabel);
            this.Controls.Add(this.newItemLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.deleteItemNumeric);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.sortArrayDataGridView);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.newItemNumeric);
            this.Controls.Add(this.enterArrayDataGridView);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "manualInputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SortProgram";
            ((System.ComponentModel.ISupportInitialize)(this.enterArrayDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newItemNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sortArrayDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deleteItemNumeric)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.premutationComparisonDataGridView)).EndInit();
            this.sortingForGroupBox.ResumeLayout(false);
            this.sortingForGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView enterArrayDataGridView;
        private System.Windows.Forms.NumericUpDown newItemNumeric;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.DataGridView sortArrayDataGridView;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.NumericUpDown deleteItemNumeric;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Label newItemLabel;
        private System.Windows.Forms.Label deleteLabel;
        private System.Windows.Forms.Label enterTableLabel;
        private System.Windows.Forms.Label sortedArrayLabel;
        private System.Windows.Forms.DataGridView premutationComparisonDataGridView;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.GroupBox sortingForGroupBox;
        private System.Windows.Forms.RadioButton downRadioButton;
        private System.Windows.Forms.RadioButton upRadioButton;
        private System.Windows.Forms.DataGridViewLinkColumn Column1;
        private System.Windows.Forms.DataGridViewLinkColumn Column2;
        private System.Windows.Forms.DataGridViewLinkColumn Column3;
    }
}

