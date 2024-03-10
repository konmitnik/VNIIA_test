namespace VNIIA_test.Forms
{
    partial class PositionForm
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
            PosDelBtn = new Button();
            PosSaveBtn = new Button();
            PosSumField = new TextBox();
            PosNameField = new TextBox();
            PosNumField = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // PosDelBtn
            // 
            PosDelBtn.Location = new Point(395, 397);
            PosDelBtn.Name = "PosDelBtn";
            PosDelBtn.Size = new Size(75, 23);
            PosDelBtn.TabIndex = 16;
            PosDelBtn.Text = "Удалить";
            PosDelBtn.UseVisualStyleBackColor = true;
            PosDelBtn.Click += PosDelBtn_Click;
            // 
            // PosSaveBtn
            // 
            PosSaveBtn.Location = new Point(314, 397);
            PosSaveBtn.Name = "PosSaveBtn";
            PosSaveBtn.Size = new Size(75, 23);
            PosSaveBtn.TabIndex = 15;
            PosSaveBtn.Text = "Сохранить";
            PosSaveBtn.UseVisualStyleBackColor = true;
            PosSaveBtn.Click += PosSaveBtn_Click;
            // 
            // PosSumField
            // 
            PosSumField.Location = new Point(159, 114);
            PosSumField.Name = "PosSumField";
            PosSumField.Size = new Size(152, 23);
            PosSumField.TabIndex = 14;
            // 
            // PosNameField
            // 
            PosNameField.Location = new Point(159, 85);
            PosNameField.Name = "PosNameField";
            PosNameField.Size = new Size(152, 23);
            PosNameField.TabIndex = 13;
            // 
            // PosNumField
            // 
            PosNumField.Location = new Point(159, 56);
            PosNumField.Name = "PosNumField";
            PosNumField.Size = new Size(152, 23);
            PosNumField.TabIndex = 12;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(24, 117);
            label10.Name = "label10";
            label10.Size = new Size(45, 15);
            label10.TabIndex = 11;
            label10.Text = "Сумма";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(24, 88);
            label9.Name = "label9";
            label9.Size = new Size(90, 15);
            label9.TabIndex = 10;
            label9.Text = "Наименование";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 59);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 9;
            label8.Text = "Номер";
            // 
            // PositionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PosDelBtn);
            Controls.Add(PosSaveBtn);
            Controls.Add(PosSumField);
            Controls.Add(PosNameField);
            Controls.Add(PosNumField);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Name = "PositionForm";
            Text = "PositionForm";
            Load += PositionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button PosDelBtn;
        private Button PosSaveBtn;
        private TextBox PosSumField;
        private TextBox PosNameField;
        private TextBox PosNumField;
        private Label label10;
        private Label label9;
        private Label label8;
    }
}