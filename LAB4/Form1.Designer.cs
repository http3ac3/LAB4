namespace LAB4
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
            this.TextTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SymbolsAmount = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FirstBlockTB = new System.Windows.Forms.TextBox();
            this.SecondBlockTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ThirdBlockTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.FourthBlockTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.FifthBlockTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CipherButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TextTB
            // 
            this.TextTB.Location = new System.Drawing.Point(183, 10);
            this.TextTB.Name = "TextTB";
            this.TextTB.ReadOnly = true;
            this.TextTB.Size = new System.Drawing.Size(248, 23);
            this.TextTB.TabIndex = 0;
            this.TextTB.Text = "КОЛОБОК ПОЛОТЕНЦЕ УВОЛОК ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Текст для шифрования";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Количество символов";
            // 
            // SymbolsAmount
            // 
            this.SymbolsAmount.Location = new System.Drawing.Point(182, 42);
            this.SymbolsAmount.Name = "SymbolsAmount";
            this.SymbolsAmount.ReadOnly = true;
            this.SymbolsAmount.Size = new System.Drawing.Size(74, 23);
            this.SymbolsAmount.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LAB4.Properties.Resources.lab5;
            this.pictureBox1.Location = new System.Drawing.Point(437, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 137);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(462, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Перестановки";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Блок 1";
            // 
            // FirstBlockTB
            // 
            this.FirstBlockTB.Location = new System.Drawing.Point(74, 84);
            this.FirstBlockTB.Name = "FirstBlockTB";
            this.FirstBlockTB.ReadOnly = true;
            this.FirstBlockTB.Size = new System.Drawing.Size(74, 23);
            this.FirstBlockTB.TabIndex = 7;
            // 
            // SecondBlockTB
            // 
            this.SecondBlockTB.Location = new System.Drawing.Point(74, 113);
            this.SecondBlockTB.Name = "SecondBlockTB";
            this.SecondBlockTB.ReadOnly = true;
            this.SecondBlockTB.Size = new System.Drawing.Size(74, 23);
            this.SecondBlockTB.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Блок 2";
            // 
            // ThirdBlockTB
            // 
            this.ThirdBlockTB.Location = new System.Drawing.Point(74, 142);
            this.ThirdBlockTB.Name = "ThirdBlockTB";
            this.ThirdBlockTB.ReadOnly = true;
            this.ThirdBlockTB.Size = new System.Drawing.Size(74, 23);
            this.ThirdBlockTB.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Блок 3";
            // 
            // FourthBlockTB
            // 
            this.FourthBlockTB.Location = new System.Drawing.Point(238, 81);
            this.FourthBlockTB.Name = "FourthBlockTB";
            this.FourthBlockTB.ReadOnly = true;
            this.FourthBlockTB.Size = new System.Drawing.Size(74, 23);
            this.FourthBlockTB.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(180, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Блок 4";
            // 
            // FifthBlockTB
            // 
            this.FifthBlockTB.Location = new System.Drawing.Point(238, 113);
            this.FifthBlockTB.Name = "FifthBlockTB";
            this.FifthBlockTB.ReadOnly = true;
            this.FifthBlockTB.Size = new System.Drawing.Size(74, 23);
            this.FifthBlockTB.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(180, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Блок 5";
            // 
            // CipherButton
            // 
            this.CipherButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.CipherButton.Location = new System.Drawing.Point(182, 145);
            this.CipherButton.Name = "CipherButton";
            this.CipherButton.Size = new System.Drawing.Size(249, 24);
            this.CipherButton.TabIndex = 16;
            this.CipherButton.Text = "Зашифровать";
            this.CipherButton.UseVisualStyleBackColor = true;
            this.CipherButton.Click += new System.EventHandler(this.CipherButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 177);
            this.Controls.Add(this.CipherButton);
            this.Controls.Add(this.FifthBlockTB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.FourthBlockTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ThirdBlockTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SecondBlockTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FirstBlockTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SymbolsAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextTB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SymbolsAmount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FirstBlockTB;
        private System.Windows.Forms.TextBox SecondBlockTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ThirdBlockTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox FourthBlockTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox FifthBlockTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button CipherButton;
    }
}

