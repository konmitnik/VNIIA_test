namespace VNIIA_test.Forms
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
            label2 = new Label();
            label1 = new Label();
            PosMasterView = new DataGridView();
            DocMasterView = new DataGridView();
            NewDocBtn = new Button();
            NewPosBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)PosMasterView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DocMasterView).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 238);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 7;
            label2.Text = "Позиции";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 9);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 6;
            label1.Text = "Документы";
            // 
            // PosMasterView
            // 
            PosMasterView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PosMasterView.Location = new Point(22, 264);
            PosMasterView.Name = "PosMasterView";
            PosMasterView.Size = new Size(756, 174);
            PosMasterView.TabIndex = 5;
            PosMasterView.CellDoubleClick += PosMasterView_CellDoubleClick;
            // 
            // DocMasterView
            // 
            DocMasterView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DocMasterView.Location = new Point(22, 35);
            DocMasterView.Name = "DocMasterView";
            DocMasterView.Size = new Size(756, 179);
            DocMasterView.TabIndex = 4;
            DocMasterView.CellDoubleClick += DocMasterView_CellDoubleClick;
            // 
            // NewDocBtn
            // 
            NewDocBtn.Location = new Point(98, 4);
            NewDocBtn.Name = "NewDocBtn";
            NewDocBtn.Size = new Size(117, 25);
            NewDocBtn.TabIndex = 8;
            NewDocBtn.Text = "Новый документ";
            NewDocBtn.UseVisualStyleBackColor = true;
            NewDocBtn.Click += NewDocBtn_Click;
            // 
            // NewPosBtn
            // 
            NewPosBtn.Location = new Point(98, 233);
            NewPosBtn.Name = "NewPosBtn";
            NewPosBtn.Size = new Size(117, 25);
            NewPosBtn.TabIndex = 9;
            NewPosBtn.Text = "Новая позиция";
            NewPosBtn.UseVisualStyleBackColor = true;
            NewPosBtn.Click += NewPosBtn_Click;
            // 
            // MasterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(NewPosBtn);
            Controls.Add(NewDocBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PosMasterView);
            Controls.Add(DocMasterView);
            Name = "MasterForm";
            Text = "VNIIA test task";
            Load += MasterForm_Load;
            ((System.ComponentModel.ISupportInitialize)PosMasterView).EndInit();
            ((System.ComponentModel.ISupportInitialize)DocMasterView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox2;
        private Label label2;
        private Label label1;
        private DataGridView PosMasterView;
        private DataGridView DocMasterView;
        private Button NewDocBtn;
        private Button NewPosBtn;
    }
}
