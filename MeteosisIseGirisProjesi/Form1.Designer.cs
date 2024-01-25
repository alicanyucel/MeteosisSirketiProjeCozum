namespace MeteosisIseGirisProjesi
{
    partial class Form1
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
            button1 = new Button();
            dtgSehir = new DataGridView();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgSehir).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(990, 386);
            button1.Name = "button1";
            button1.Size = new Size(239, 40);
            button1.TabIndex = 0;
            button1.Text = "Grafikte Göster";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dtgSehir
            // 
            dtgSehir.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgSehir.Location = new Point(12, 25);
            dtgSehir.Name = "dtgSehir";
            dtgSehir.RowHeadersWidth = 51;
            dtgSehir.Size = new Size(1217, 305);
            dtgSehir.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 358);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 2;
            label1.Text = "Şehir Seç";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(145, 350);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 420);
            label2.Name = "label2";
            label2.Size = new Size(136, 20);
            label2.TabIndex = 4;
            label2.Text = "Hesaplama Sonucu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(238, 420);
            label3.Name = "label3";
            label3.Size = new Size(12, 20);
            label3.TabIndex = 5;
            label3.Text = ",";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1356, 507);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(dtgSehir);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dtgSehir).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dtgSehir;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private Label label3;
    }
}