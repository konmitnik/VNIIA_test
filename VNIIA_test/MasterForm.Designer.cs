namespace VNIIA_test
{
    partial class MasterForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            label2 = new Label();
            label1 = new Label();
            PosMasterView = new DataGridView();
            DocMasterView = new DataGridView();
            tabPage2 = new TabPage();
            DocIdLabel = new Label();
            label7 = new Label();
            DocPosView = new DataGridView();
            DocPosNumColumn = new DataGridViewTextBoxColumn();
            DocPosNameColumn = new DataGridViewTextBoxColumn();
            DocPosSumColumn = new DataGridViewTextBoxColumn();
            DocDelBtn = new Button();
            DocSaveBtn = new Button();
            DocDatePicker = new DateTimePicker();
            DocComField = new TextBox();
            DocSumField = new TextBox();
            DocNumField = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            tabPage3 = new TabPage();
            PosIdLabel = new Label();
            PosDelBtn = new Button();
            PosSaveBtn = new Button();
            PosSumField = new TextBox();
            PosNameField = new TextBox();
            PosNumField = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PosMasterView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DocMasterView).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DocPosView).BeginInit();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Controls.Add(tabPage3);
            tabControl.Location = new Point(12, 12);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(776, 426);
            tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(PosMasterView);
            tabPage1.Controls.Add(DocMasterView);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 398);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Master tables";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 210);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 3;
            label2.Text = "Позиции";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 3);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 2;
            label1.Text = "Документы";
            // 
            // PosMasterView
            // 
            PosMasterView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PosMasterView.Location = new Point(6, 228);
            PosMasterView.Name = "PosMasterView";
            PosMasterView.Size = new Size(756, 164);
            PosMasterView.TabIndex = 1;
            // 
            // DocMasterView
            // 
            DocMasterView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DocMasterView.Location = new Point(6, 21);
            DocMasterView.Name = "DocMasterView";
            DocMasterView.Size = new Size(756, 179);
            DocMasterView.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(DocIdLabel);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(DocPosView);
            tabPage2.Controls.Add(DocDelBtn);
            tabPage2.Controls.Add(DocSaveBtn);
            tabPage2.Controls.Add(DocDatePicker);
            tabPage2.Controls.Add(DocComField);
            tabPage2.Controls.Add(DocSumField);
            tabPage2.Controls.Add(DocNumField);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 398);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Document detail";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // DocIdLabel
            // 
            DocIdLabel.AutoSize = true;
            DocIdLabel.Location = new Point(749, 3);
            DocIdLabel.Name = "DocIdLabel";
            DocIdLabel.Size = new Size(13, 15);
            DocIdLabel.TabIndex = 13;
            DocIdLabel.Text = "0";
            DocIdLabel.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 145);
            label7.Name = "label7";
            label7.Size = new Size(117, 15);
            label7.TabIndex = 12;
            label7.Text = "Позиции документа";
            // 
            // DocPosView
            // 
            DocPosView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DocPosView.Columns.AddRange(new DataGridViewColumn[] { DocPosNumColumn, DocPosNameColumn, DocPosSumColumn });
            DocPosView.Location = new Point(3, 163);
            DocPosView.Name = "DocPosView";
            DocPosView.Size = new Size(759, 200);
            DocPosView.TabIndex = 11;
            // 
            // DocPosNumColumn
            // 
            DocPosNumColumn.HeaderText = "Номер";
            DocPosNumColumn.Name = "DocPosNumColumn";
            // 
            // DocPosNameColumn
            // 
            DocPosNameColumn.HeaderText = "Нименование";
            DocPosNameColumn.Name = "DocPosNameColumn";
            // 
            // DocPosSumColumn
            // 
            DocPosSumColumn.HeaderText = "Сумма";
            DocPosSumColumn.Name = "DocPosSumColumn";
            // 
            // DocDelBtn
            // 
            DocDelBtn.Location = new Point(368, 369);
            DocDelBtn.Name = "DocDelBtn";
            DocDelBtn.Size = new Size(75, 23);
            DocDelBtn.TabIndex = 10;
            DocDelBtn.Text = "Удалить";
            DocDelBtn.UseVisualStyleBackColor = true;
            DocDelBtn.Click += DocDelBtn_Click;
            // 
            // DocSaveBtn
            // 
            DocSaveBtn.Location = new Point(287, 369);
            DocSaveBtn.Name = "DocSaveBtn";
            DocSaveBtn.Size = new Size(75, 23);
            DocSaveBtn.TabIndex = 9;
            DocSaveBtn.Text = "Сохранить";
            DocSaveBtn.UseVisualStyleBackColor = true;
            DocSaveBtn.Click += DocSaveBtn_Click;
            // 
            // DocDatePicker
            // 
            DocDatePicker.Location = new Point(125, 48);
            DocDatePicker.Name = "DocDatePicker";
            DocDatePicker.Size = new Size(170, 23);
            DocDatePicker.TabIndex = 8;
            // 
            // DocComField
            // 
            DocComField.Location = new Point(125, 106);
            DocComField.Name = "DocComField";
            DocComField.Size = new Size(170, 23);
            DocComField.TabIndex = 7;
            // 
            // DocSumField
            // 
            DocSumField.Enabled = false;
            DocSumField.Location = new Point(125, 77);
            DocSumField.Name = "DocSumField";
            DocSumField.Size = new Size(170, 23);
            DocSumField.TabIndex = 6;
            // 
            // DocNumField
            // 
            DocNumField.Location = new Point(125, 19);
            DocNumField.Name = "DocNumField";
            DocNumField.Size = new Size(170, 23);
            DocNumField.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 109);
            label6.Name = "label6";
            label6.Size = new Size(78, 15);
            label6.TabIndex = 3;
            label6.Text = "Примечание";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 80);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 2;
            label5.Text = "Сумма";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 54);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 1;
            label4.Text = "Дата";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 22);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 0;
            label3.Text = "Номер";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(PosIdLabel);
            tabPage3.Controls.Add(PosDelBtn);
            tabPage3.Controls.Add(PosSaveBtn);
            tabPage3.Controls.Add(PosSumField);
            tabPage3.Controls.Add(PosNameField);
            tabPage3.Controls.Add(PosNumField);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(label8);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(768, 398);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Position detail";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // PosIdLabel
            // 
            PosIdLabel.AutoSize = true;
            PosIdLabel.Location = new Point(752, 0);
            PosIdLabel.Name = "PosIdLabel";
            PosIdLabel.Size = new Size(13, 15);
            PosIdLabel.TabIndex = 8;
            PosIdLabel.Text = "0";
            PosIdLabel.Visible = false;
            // 
            // PosDelBtn
            // 
            PosDelBtn.Location = new Point(383, 366);
            PosDelBtn.Name = "PosDelBtn";
            PosDelBtn.Size = new Size(75, 23);
            PosDelBtn.TabIndex = 7;
            PosDelBtn.Text = "Удалить";
            PosDelBtn.UseVisualStyleBackColor = true;
            PosDelBtn.Click += PosDelBtn_Click;
            // 
            // PosSaveBtn
            // 
            PosSaveBtn.Location = new Point(302, 366);
            PosSaveBtn.Name = "PosSaveBtn";
            PosSaveBtn.Size = new Size(75, 23);
            PosSaveBtn.TabIndex = 6;
            PosSaveBtn.Text = "Сохранить";
            PosSaveBtn.UseVisualStyleBackColor = true;
            PosSaveBtn.Click += PosSaveBtn_Click;
            // 
            // PosSumField
            // 
            PosSumField.Location = new Point(147, 83);
            PosSumField.Name = "PosSumField";
            PosSumField.Size = new Size(152, 23);
            PosSumField.TabIndex = 5;
            // 
            // PosNameField
            // 
            PosNameField.Location = new Point(147, 54);
            PosNameField.Name = "PosNameField";
            PosNameField.Size = new Size(152, 23);
            PosNameField.TabIndex = 4;
            // 
            // PosNumField
            // 
            PosNumField.Location = new Point(147, 25);
            PosNumField.Name = "PosNumField";
            PosNumField.Size = new Size(152, 23);
            PosNumField.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 86);
            label10.Name = "label10";
            label10.Size = new Size(45, 15);
            label10.TabIndex = 2;
            label10.Text = "Сумма";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 57);
            label9.Name = "label9";
            label9.Size = new Size(90, 15);
            label9.TabIndex = 1;
            label9.Text = "Наименование";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 28);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 0;
            label8.Text = "Номер";
            // 
            // MasterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl);
            Name = "MasterForm";
            Text = "VNIIA test task";
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PosMasterView).EndInit();
            ((System.ComponentModel.ISupportInitialize)DocMasterView).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DocPosView).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private DataGridView DocMasterView;
        private Label label1;
        private DataGridView PosMasterView;
        private Label label2;
        private TextBox textBox2;
        private TextBox DocNumField;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private DateTimePicker DocDatePicker;
        private TextBox DocComField;
        private TextBox DocSumField;
        private Label label7;
        private DataGridView DocPosView;
        private Button DocDelBtn;
        private Button DocSaveBtn;
        private Label label10;
        private Label label9;
        private Label label8;
        private Button PosDelBtn;
        private Button PosSaveBtn;
        private TextBox PosSumField;
        private TextBox PosNameField;
        private TextBox PosNumField;
        private DataGridViewTextBoxColumn DocPosNumColumn;
        private DataGridViewTextBoxColumn DocPosNameColumn;
        private DataGridViewTextBoxColumn DocPosSumColumn;
        private Label DocIdLabel;
        private Label PosIdLabel;
    }
}
