namespace VNIIA_test.Forms
{
    partial class DocumnetForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label7 = new Label();
            DocPosView = new DataGridView();
            DocDatePicker = new DateTimePicker();
            DocComField = new TextBox();
            DocSumField = new TextBox();
            DocNumField = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            DocDelBtn = new Button();
            DocSaveBtn = new Button();
            NewPosDocBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)DocPosView).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 179);
            label7.Name = "label7";
            label7.Size = new Size(117, 15);
            label7.TabIndex = 22;
            label7.Text = "Позиции документа";
            // 
            // DocPosView
            // 
            DocPosView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DocPosView.Location = new Point(24, 204);
            DocPosView.Name = "DocPosView";
            DocPosView.Size = new Size(759, 200);
            DocPosView.TabIndex = 21;
            DocPosView.CellDoubleClick += DocPosView_CellDoubleClick;
            // 
            // DocDatePicker
            // 
            DocDatePicker.Location = new Point(143, 82);
            DocDatePicker.Name = "DocDatePicker";
            DocDatePicker.Size = new Size(170, 23);
            DocDatePicker.TabIndex = 20;
            // 
            // DocComField
            // 
            DocComField.Location = new Point(143, 140);
            DocComField.Name = "DocComField";
            DocComField.Size = new Size(170, 23);
            DocComField.TabIndex = 19;
            // 
            // DocSumField
            // 
            DocSumField.Enabled = false;
            DocSumField.Location = new Point(143, 111);
            DocSumField.Name = "DocSumField";
            DocSumField.Size = new Size(170, 23);
            DocSumField.TabIndex = 18;
            // 
            // DocNumField
            // 
            DocNumField.Location = new Point(143, 53);
            DocNumField.Name = "DocNumField";
            DocNumField.Size = new Size(170, 23);
            DocNumField.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 143);
            label6.Name = "label6";
            label6.Size = new Size(78, 15);
            label6.TabIndex = 16;
            label6.Text = "Примечание";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 114);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 15;
            label5.Text = "Сумма";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 88);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 14;
            label4.Text = "Дата";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 56);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 13;
            label3.Text = "Номер";
            // 
            // DocDelBtn
            // 
            DocDelBtn.Location = new Point(398, 415);
            DocDelBtn.Name = "DocDelBtn";
            DocDelBtn.Size = new Size(75, 23);
            DocDelBtn.TabIndex = 25;
            DocDelBtn.Text = "Удалить";
            DocDelBtn.UseVisualStyleBackColor = true;
            DocDelBtn.Click += DocDelBtn_Click;
            // 
            // DocSaveBtn
            // 
            DocSaveBtn.Location = new Point(317, 415);
            DocSaveBtn.Name = "DocSaveBtn";
            DocSaveBtn.Size = new Size(75, 23);
            DocSaveBtn.TabIndex = 24;
            DocSaveBtn.Text = "Сохранить";
            DocSaveBtn.UseVisualStyleBackColor = true;
            DocSaveBtn.Click += DocSaveBtn_Click;
            // 
            // NewPosDocBtn
            // 
            NewPosDocBtn.Location = new Point(147, 175);
            NewPosDocBtn.Name = "NewPosDocBtn";
            NewPosDocBtn.Size = new Size(75, 23);
            NewPosDocBtn.TabIndex = 26;
            NewPosDocBtn.Text = "Добавить позицию";
            NewPosDocBtn.UseVisualStyleBackColor = true;
            NewPosDocBtn.Click += NewDocPosBtn_Click;
            // 
            // DocumnetForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(NewPosDocBtn);
            Controls.Add(DocDelBtn);
            Controls.Add(DocSaveBtn);
            Controls.Add(label7);
            Controls.Add(DocPosView);
            Controls.Add(DocDatePicker);
            Controls.Add(DocComField);
            Controls.Add(DocSumField);
            Controls.Add(DocNumField);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Name = "DocumnetForm";
            Text = "DocumnetForm";
            Load += DocumnetForm_Load;
            ((System.ComponentModel.ISupportInitialize)DocPosView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private DataGridView DocPosView;
        private DateTimePicker DocDatePicker;
        private TextBox DocComField;
        private TextBox DocSumField;
        private TextBox DocNumField;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button DocDelBtn;
        private Button DocSaveBtn;
        private Button NewPosDocBtn;
    }
}