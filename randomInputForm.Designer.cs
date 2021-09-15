
namespace SortProject {
    partial class randomInputForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {

            if (disposing && (components != null)) {
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
            this.sortArrayDataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.domainUpDown2 = new System.Windows.Forms.DomainUpDown();
            this.domainUpDown4 = new System.Windows.Forms.DomainUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.enterArrayDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sortArrayDataGridView)).BeginInit();
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
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
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
            this.sortingForGroupBox.Location = new System.Drawing.Point(12, 138);
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(12, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 48);
            this.button1.TabIndex = 18;
            this.button1.Text = "Ввод не сортированного массива";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(12, 290);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(236, 57);
            this.button2.TabIndex = 19;
            this.button2.Text = "Ввод сортированного массива (возрастание)";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(12, 353);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(236, 57);
            this.button3.TabIndex = 20;
            this.button3.Text = "Ввод сортированного массива (убывание)";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Location = new System.Drawing.Point(46, 52);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(148, 23);
            this.domainUpDown1.TabIndex = 21;
            this.domainUpDown1.Text = "domainUpDown1";
            // 
            // domainUpDown2
            // 
            this.domainUpDown2.Location = new System.Drawing.Point(46, 109);
            this.domainUpDown2.Name = "domainUpDown2";
            this.domainUpDown2.Size = new System.Drawing.Size(58, 23);
            this.domainUpDown2.TabIndex = 22;
            this.domainUpDown2.Text = "domainUpDown2";
            // 
            // domainUpDown4
            // 
            this.domainUpDown4.Location = new System.Drawing.Point(136, 109);
            this.domainUpDown4.Name = "domainUpDown4";
            this.domainUpDown4.Size = new System.Drawing.Size(58, 23);
            this.domainUpDown4.TabIndex = 23;
            this.domainUpDown4.Text = "domainUpDown4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "Выберите кол-во элементов массива";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "Выберите границы значечний элементов";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "до";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 15);
            this.label4.TabIndex = 28;
            this.label4.Text = "от";
            // 
            // randomInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 432);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.domainUpDown4);
            this.Controls.Add(this.domainUpDown2);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sortingForGroupBox);
            this.Controls.Add(this.label);
            this.Controls.Add(this.premutationComparisonDataGridView);
            this.Controls.Add(this.sortedArrayLabel);
            this.Controls.Add(this.enterTableLabel);
            this.Controls.Add(this.sortArrayDataGridView);
            this.Controls.Add(this.enterArrayDataGridView);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "randomInputForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SortProgram";
            ((System.ComponentModel.ISupportInitialize)(this.enterArrayDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sortArrayDataGridView)).EndInit();
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
        private System.Windows.Forms.DataGridView sortArrayDataGridView;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.DomainUpDown domainUpDown2;
        private System.Windows.Forms.DomainUpDown domainUpDown4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}