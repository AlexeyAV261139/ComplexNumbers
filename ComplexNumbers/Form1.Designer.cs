namespace ComplexNumbers
{
    partial class Form1
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
            this.textBoxRealNumA = new System.Windows.Forms.TextBox();
            this.textBoxRealNumB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxSummA = new System.Windows.Forms.TextBox();
            this.textBoxSummB = new System.Windows.Forms.TextBox();
            this.labelFinal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxRealNumA
            // 
            this.textBoxRealNumA.Location = new System.Drawing.Point(116, 70);
            this.textBoxRealNumA.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBoxRealNumA.Name = "textBoxRealNumA";
            this.textBoxRealNumA.Size = new System.Drawing.Size(164, 29);
            this.textBoxRealNumA.TabIndex = 0;
            // 
            // textBoxRealNumB
            // 
            this.textBoxRealNumB.Location = new System.Drawing.Point(317, 70);
            this.textBoxRealNumB.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxRealNumB.Name = "textBoxRealNumB";
            this.textBoxRealNumB.Size = new System.Drawing.Size(164, 29);
            this.textBoxRealNumB.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxSummA
            // 
            this.textBoxSummA.Location = new System.Drawing.Point(116, 160);
            this.textBoxSummA.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxSummA.Name = "textBoxSummA";
            this.textBoxSummA.Size = new System.Drawing.Size(164, 29);
            this.textBoxSummA.TabIndex = 3;
            // 
            // textBoxSummB
            // 
            this.textBoxSummB.Location = new System.Drawing.Point(329, 160);
            this.textBoxSummB.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxSummB.Name = "textBoxSummB";
            this.textBoxSummB.Size = new System.Drawing.Size(164, 29);
            this.textBoxSummB.TabIndex = 4;
            // 
            // labelFinal
            // 
            this.labelFinal.AutoSize = true;
            this.labelFinal.Location = new System.Drawing.Point(241, 217);
            this.labelFinal.Name = "labelFinal";
            this.labelFinal.Size = new System.Drawing.Size(53, 21);
            this.labelFinal.TabIndex = 5;
            this.labelFinal.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 400);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelFinal);
            this.Controls.Add(this.textBoxSummB);
            this.Controls.Add(this.textBoxSummA);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxRealNumB);
            this.Controls.Add(this.textBoxRealNumA);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxRealNumA;
        private System.Windows.Forms.TextBox textBoxRealNumB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxSummA;
        private System.Windows.Forms.TextBox textBoxSummB;
        private System.Windows.Forms.Label labelFinal;
        private System.Windows.Forms.Label label1;
    }
}

