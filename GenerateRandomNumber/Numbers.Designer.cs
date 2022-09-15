namespace GenerateRandomNumber
{
    partial class Numbers
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.LowerBorder = new System.Windows.Forms.NumericUpDown();
            this.UpperBorder = new System.Windows.Forms.NumericUpDown();
            this.countNumbers = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GenerateNumber = new System.Windows.Forms.Button();
            this.valueNambers = new System.Windows.Forms.Label();
            this.ExcludeNumbers = new System.Windows.Forms.CheckBox();
            this.InvalidNumbers = new System.Windows.Forms.Label();
            this.LabelNumbers = new System.Windows.Forms.Label();
            this.OrderNumbers = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.LowerBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpperBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countNumbers)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LowerBorder
            // 
            this.LowerBorder.Location = new System.Drawing.Point(12, 28);
            this.LowerBorder.Name = "LowerBorder";
            this.LowerBorder.Size = new System.Drawing.Size(120, 20);
            this.LowerBorder.TabIndex = 0;
            this.LowerBorder.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // UpperBorder
            // 
            this.UpperBorder.Location = new System.Drawing.Point(160, 28);
            this.UpperBorder.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.UpperBorder.Name = "UpperBorder";
            this.UpperBorder.Size = new System.Drawing.Size(120, 20);
            this.UpperBorder.TabIndex = 1;
            this.UpperBorder.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // countNumbers
            // 
            this.countNumbers.Location = new System.Drawing.Point(15, 67);
            this.countNumbers.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.countNumbers.Name = "countNumbers";
            this.countNumbers.Size = new System.Drawing.Size(120, 20);
            this.countNumbers.TabIndex = 2;
            this.countNumbers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "от";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "до";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Количество чисел";
            // 
            // GenerateNumber
            // 
            this.GenerateNumber.BackColor = System.Drawing.Color.White;
            this.GenerateNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateNumber.Location = new System.Drawing.Point(160, 54);
            this.GenerateNumber.Name = "GenerateNumber";
            this.GenerateNumber.Size = new System.Drawing.Size(118, 23);
            this.GenerateNumber.TabIndex = 6;
            this.GenerateNumber.Text = "Сгенерировать";
            this.GenerateNumber.UseVisualStyleBackColor = false;
            this.GenerateNumber.Click += new System.EventHandler(this.GenerateNumber_Click);
            // 
            // valueNambers
            // 
            this.valueNambers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueNambers.Location = new System.Drawing.Point(155, 127);
            this.valueNambers.Name = "valueNambers";
            this.valueNambers.Size = new System.Drawing.Size(179, 25);
            this.valueNambers.TabIndex = 7;
            this.valueNambers.Text = "Ваше значение: ";
            // 
            // ExcludeNumbers
            // 
            this.ExcludeNumbers.AutoSize = true;
            this.ExcludeNumbers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExcludeNumbers.Location = new System.Drawing.Point(160, 83);
            this.ExcludeNumbers.Name = "ExcludeNumbers";
            this.ExcludeNumbers.Size = new System.Drawing.Size(141, 17);
            this.ExcludeNumbers.TabIndex = 8;
            this.ExcludeNumbers.Text = "Исключить повторения";
            this.ExcludeNumbers.UseVisualStyleBackColor = true;
            // 
            // InvalidNumbers
            // 
            this.InvalidNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InvalidNumbers.ForeColor = System.Drawing.Color.Red;
            this.InvalidNumbers.Location = new System.Drawing.Point(12, 90);
            this.InvalidNumbers.Name = "InvalidNumbers";
            this.InvalidNumbers.Size = new System.Drawing.Size(126, 49);
            this.InvalidNumbers.TabIndex = 9;
            // 
            // LabelNumbers
            // 
            this.LabelNumbers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelNumbers.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNumbers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelNumbers.Location = new System.Drawing.Point(332, 0);
            this.LabelNumbers.Name = "LabelNumbers";
            this.LabelNumbers.Size = new System.Drawing.Size(528, 351);
            this.LabelNumbers.TabIndex = 10;
            // 
            // OrderNumbers
            // 
            this.OrderNumbers.AutoSize = true;
            this.OrderNumbers.Location = new System.Drawing.Point(160, 107);
            this.OrderNumbers.Name = "OrderNumbers";
            this.OrderNumbers.Size = new System.Drawing.Size(150, 17);
            this.OrderNumbers.TabIndex = 11;
            this.OrderNumbers.Text = "Сортировать по порядку";
            this.OrderNumbers.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.OrderNumbers);
            this.panel1.Controls.Add(this.InvalidNumbers);
            this.panel1.Controls.Add(this.LowerBorder);
            this.panel1.Controls.Add(this.UpperBorder);
            this.panel1.Controls.Add(this.countNumbers);
            this.panel1.Controls.Add(this.ExcludeNumbers);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.valueNambers);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.GenerateNumber);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 351);
            this.panel1.TabIndex = 12;
            // 
            // Numbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 351);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LabelNumbers);
            this.Name = "Numbers";
            this.Text = "Random Number";
            ((System.ComponentModel.ISupportInitialize)(this.LowerBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpperBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countNumbers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown LowerBorder;
        private System.Windows.Forms.NumericUpDown UpperBorder;
        private System.Windows.Forms.NumericUpDown countNumbers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button GenerateNumber;
        private System.Windows.Forms.Label valueNambers;
        private System.Windows.Forms.CheckBox ExcludeNumbers;
        private System.Windows.Forms.Label InvalidNumbers;
        private System.Windows.Forms.Label LabelNumbers;
        private System.Windows.Forms.CheckBox OrderNumbers;
        private System.Windows.Forms.Panel panel1;
    }
}

