namespace WinFormsApp2
{
    partial class Form1
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
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.cmbOperation = new System.Windows.Forms.ComboBox();
            this.cmbFirstType = new System.Windows.Forms.ComboBox();
            this.cmbSecondType = new System.Windows.Forms.ComboBox();
            this.cmbResultType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.number1 = new System.Windows.Forms.TextBox();
            this.cmbBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbBox2 = new System.Windows.Forms.ComboBox();
            this.number2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFirst
            // 
            this.txtFirst.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtFirst.Location = new System.Drawing.Point(108, 116);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(125, 34);
            this.txtFirst.TabIndex = 0;
            this.txtFirst.TextChanged += new System.EventHandler(this.txtFirst_TextChanged);
            // 
            // txtSecond
            // 
            this.txtSecond.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSecond.Location = new System.Drawing.Point(108, 166);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(125, 34);
            this.txtSecond.TabIndex = 1;
            this.txtSecond.TextChanged += new System.EventHandler(this.txtSecond_TextChanged);
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.White;
            this.txtResult.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtResult.ForeColor = System.Drawing.Color.Black;
            this.txtResult.Location = new System.Drawing.Point(108, 220);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(125, 34);
            this.txtResult.TabIndex = 2;
            this.txtResult.TextChanged += new System.EventHandler(this.txtResult_TextChanged);
            // 
            // cmbOperation
            // 
            this.cmbOperation.FormattingEnabled = true;
            this.cmbOperation.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cmbOperation.Location = new System.Drawing.Point(12, 152);
            this.cmbOperation.Name = "cmbOperation";
            this.cmbOperation.Size = new System.Drawing.Size(77, 28);
            this.cmbOperation.TabIndex = 3;
            this.cmbOperation.Text = "+";
            this.cmbOperation.SelectedIndexChanged += new System.EventHandler(this.cmbOperation_SelectedIndexChanged);
            // 
            // cmbFirstType
            // 
            this.cmbFirstType.Font = new System.Drawing.Font("Segoe UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbFirstType.FormattingEnabled = true;
            this.cmbFirstType.Location = new System.Drawing.Point(255, 115);
            this.cmbFirstType.Name = "cmbFirstType";
            this.cmbFirstType.Size = new System.Drawing.Size(151, 33);
            this.cmbFirstType.TabIndex = 4;
            this.cmbFirstType.SelectedIndexChanged += new System.EventHandler(this.cmbFirstType_SelectedIndexChanged);
            // 
            // cmbSecondType
            // 
            this.cmbSecondType.Font = new System.Drawing.Font("Segoe UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbSecondType.FormattingEnabled = true;
            this.cmbSecondType.Location = new System.Drawing.Point(255, 166);
            this.cmbSecondType.Name = "cmbSecondType";
            this.cmbSecondType.Size = new System.Drawing.Size(151, 33);
            this.cmbSecondType.TabIndex = 5;
            this.cmbSecondType.SelectedIndexChanged += new System.EventHandler(this.cmbSecondType_SelectedIndexChanged);
            // 
            // cmbResultType
            // 
            this.cmbResultType.Font = new System.Drawing.Font("Segoe UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbResultType.FormattingEnabled = true;
            this.cmbResultType.Location = new System.Drawing.Point(255, 220);
            this.cmbResultType.Name = "cmbResultType";
            this.cmbResultType.Size = new System.Drawing.Size(151, 33);
            this.cmbResultType.TabIndex = 6;
            this.cmbResultType.SelectedIndexChanged += new System.EventHandler(this.cmbResultType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(129, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(108, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "_________________     ______________________";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(255, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cистема счисления";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(20, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(399, 56);
            this.label4.TabIndex = 10;
            this.label4.Text = "Калькулятор операций чисел в разных\r\n            системах счисления";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(25, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(391, 56);
            this.label5.TabIndex = 11;
            this.label5.Text = "Перевод числа в различные системы \r\n                        счисления\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(19, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 28);
            this.label6.TabIndex = 12;
            this.label6.Text = "Число:";
            // 
            // number1
            // 
            this.number1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.number1.Location = new System.Drawing.Point(108, 389);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(125, 34);
            this.number1.TabIndex = 13;
            this.number1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cmbBox1
            // 
            this.cmbBox1.Font = new System.Drawing.Font("Segoe UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbBox1.FormattingEnabled = true;
            this.cmbBox1.Location = new System.Drawing.Point(255, 389);
            this.cmbBox1.Name = "cmbBox1";
            this.cmbBox1.Size = new System.Drawing.Size(151, 33);
            this.cmbBox1.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(255, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "Cистема счисления";
            // 
            // cmbBox2
            // 
            this.cmbBox2.Font = new System.Drawing.Font("Segoe UI Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbBox2.FormattingEnabled = true;
            this.cmbBox2.Location = new System.Drawing.Point(255, 448);
            this.cmbBox2.Name = "cmbBox2";
            this.cmbBox2.Size = new System.Drawing.Size(151, 33);
            this.cmbBox2.TabIndex = 17;
            // 
            // number2
            // 
            this.number2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.number2.Location = new System.Drawing.Point(108, 448);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(125, 34);
            this.number2.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(12, 448);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 28);
            this.label8.TabIndex = 19;
            this.label8.Text = "Результат:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 492);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.cmbBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbBox1);
            this.Controls.Add(this.number1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbResultType);
            this.Controls.Add(this.cmbSecondType);
            this.Controls.Add(this.cmbFirstType);
            this.Controls.Add(this.cmbOperation);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtSecond);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtFirst;
        private TextBox txtSecond;
        private TextBox txtResult;
        private ComboBox cmbOperation;
        private ComboBox cmbFirstType;
        private ComboBox cmbSecondType;
        private ComboBox cmbResultType;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox number1;
        private ComboBox cmbBox1;
        private Label label7;
        private ComboBox cmbBox2;
        private TextBox number2;
        private Label label8;
    }
}