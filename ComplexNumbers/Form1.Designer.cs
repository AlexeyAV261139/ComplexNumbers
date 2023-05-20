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
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.labelD = new System.Windows.Forms.Label();
            this.labelFinalDif = new System.Windows.Forms.Label();
            this.labelMulti = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxRealNumA
            // 
            this.textBoxRealNumA.Location = new System.Drawing.Point(83, 51);
            this.textBoxRealNumA.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxRealNumA.Name = "textBoxRealNumA";
            this.textBoxRealNumA.Size = new System.Drawing.Size(72, 29);
            this.textBoxRealNumA.TabIndex = 0;
            // 
            // textBoxRealNumB
            // 
            this.textBoxRealNumB.Location = new System.Drawing.Point(197, 51);
            this.textBoxRealNumB.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxRealNumB.Name = "textBoxRealNumB";
            this.textBoxRealNumB.Size = new System.Drawing.Size(73, 29);
            this.textBoxRealNumB.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(506, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Расчёт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxSummA
            // 
            this.textBoxSummA.Location = new System.Drawing.Point(83, 121);
            this.textBoxSummA.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxSummA.Name = "textBoxSummA";
            this.textBoxSummA.Size = new System.Drawing.Size(72, 29);
            this.textBoxSummA.TabIndex = 3;
            // 
            // textBoxSummB
            // 
            this.textBoxSummB.Location = new System.Drawing.Point(197, 121);
            this.textBoxSummB.Margin = new System.Windows.Forms.Padding(5);
            this.textBoxSummB.Name = "textBoxSummB";
            this.textBoxSummB.Size = new System.Drawing.Size(73, 29);
            this.textBoxSummB.TabIndex = 4;
            // 
            // labelFinal
            // 
            this.labelFinal.AutoSize = true;
            this.labelFinal.Location = new System.Drawing.Point(292, 124);
            this.labelFinal.Name = "labelFinal";
            this.labelFinal.Size = new System.Drawing.Size(142, 21);
            this.labelFinal.TabIndex = 5;
            this.labelFinal.Text = "(a + bi) + (c + di)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "a + bi";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(57, 54);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(18, 21);
            this.labelA.TabIndex = 7;
            this.labelA.Text = "a";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(169, 54);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(20, 21);
            this.labelB.TabIndex = 8;
            this.labelB.Text = "b";
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(56, 124);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(19, 21);
            this.labelC.TabIndex = 9;
            this.labelC.Text = "c";
            // 
            // labelD
            // 
            this.labelD.AutoSize = true;
            this.labelD.Location = new System.Drawing.Point(169, 124);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(20, 21);
            this.labelD.TabIndex = 10;
            this.labelD.Text = "d";
            // 
            // labelFinalDif
            // 
            this.labelFinalDif.AutoSize = true;
            this.labelFinalDif.Location = new System.Drawing.Point(297, 198);
            this.labelFinalDif.Name = "labelFinalDif";
            this.labelFinalDif.Size = new System.Drawing.Size(137, 21);
            this.labelFinalDif.TabIndex = 11;
            this.labelFinalDif.Text = "(a + bi) - (c + di)";
            // 
            // labelMulti
            // 
            this.labelMulti.AutoSize = true;
            this.labelMulti.Location = new System.Drawing.Point(15, 198);
            this.labelMulti.Name = "labelMulti";
            this.labelMulti.Size = new System.Drawing.Size(140, 21);
            this.labelMulti.TabIndex = 12;
            this.labelMulti.Text = "(a + bi) * (c + di)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 310);
            this.Controls.Add(this.labelMulti);
            this.Controls.Add(this.labelFinalDif);
            this.Controls.Add(this.labelD);
            this.Controls.Add(this.labelC);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelFinal);
            this.Controls.Add(this.textBoxSummB);
            this.Controls.Add(this.textBoxSummA);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxRealNumB);
            this.Controls.Add(this.textBoxRealNumA);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
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
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.Label labelFinalDif;
        private System.Windows.Forms.Label labelMulti;
    }
}

