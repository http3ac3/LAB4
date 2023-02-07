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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.SixCipherButton = new System.Windows.Forms.Button();
            this.SixLettersTable = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.SixOpenTextTB = new System.Windows.Forms.TextBox();
            this.DecipherButton = new System.Windows.Forms.Button();
            this.FifthCipherTB = new System.Windows.Forms.RichTextBox();
            this.SixDecipherButton = new System.Windows.Forms.Button();
            this.FifthKolLettersButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SixClosedTextTB = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.SixDecipherTable = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TextTB
            // 
            this.TextTB.Location = new System.Drawing.Point(217, 6);
            this.TextTB.Name = "TextTB";
            this.TextTB.ReadOnly = true;
            this.TextTB.Size = new System.Drawing.Size(293, 23);
            this.TextTB.TabIndex = 0;
            this.TextTB.Text = "КОЛОБОК ПОЛОТЕНЦЕ УВОЛОК ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Текст для шифрования";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Количество символов";
            // 
            // SymbolsAmount
            // 
            this.SymbolsAmount.Location = new System.Drawing.Point(217, 39);
            this.SymbolsAmount.Name = "SymbolsAmount";
            this.SymbolsAmount.ReadOnly = true;
            this.SymbolsAmount.Size = new System.Drawing.Size(124, 23);
            this.SymbolsAmount.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Блок 1";
            // 
            // FirstBlockTB
            // 
            this.FirstBlockTB.Location = new System.Drawing.Point(79, 81);
            this.FirstBlockTB.Name = "FirstBlockTB";
            this.FirstBlockTB.ReadOnly = true;
            this.FirstBlockTB.Size = new System.Drawing.Size(86, 23);
            this.FirstBlockTB.TabIndex = 7;
            // 
            // SecondBlockTB
            // 
            this.SecondBlockTB.Location = new System.Drawing.Point(79, 110);
            this.SecondBlockTB.Name = "SecondBlockTB";
            this.SecondBlockTB.ReadOnly = true;
            this.SecondBlockTB.Size = new System.Drawing.Size(86, 23);
            this.SecondBlockTB.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Блок 2";
            // 
            // ThirdBlockTB
            // 
            this.ThirdBlockTB.Location = new System.Drawing.Point(79, 139);
            this.ThirdBlockTB.Name = "ThirdBlockTB";
            this.ThirdBlockTB.ReadOnly = true;
            this.ThirdBlockTB.Size = new System.Drawing.Size(86, 23);
            this.ThirdBlockTB.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Блок 3";
            // 
            // FourthBlockTB
            // 
            this.FourthBlockTB.Location = new System.Drawing.Point(243, 77);
            this.FourthBlockTB.Name = "FourthBlockTB";
            this.FourthBlockTB.ReadOnly = true;
            this.FourthBlockTB.Size = new System.Drawing.Size(98, 23);
            this.FourthBlockTB.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(171, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Блок 4";
            // 
            // FifthBlockTB
            // 
            this.FifthBlockTB.Location = new System.Drawing.Point(243, 109);
            this.FifthBlockTB.Name = "FifthBlockTB";
            this.FifthBlockTB.ReadOnly = true;
            this.FifthBlockTB.Size = new System.Drawing.Size(98, 23);
            this.FifthBlockTB.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(171, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Блок 5";
            // 
            // CipherButton
            // 
            this.CipherButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CipherButton.Location = new System.Drawing.Point(173, 142);
            this.CipherButton.Name = "CipherButton";
            this.CipherButton.Size = new System.Drawing.Size(337, 24);
            this.CipherButton.TabIndex = 16;
            this.CipherButton.Text = "Зашифровать";
            this.CipherButton.UseVisualStyleBackColor = true;
            this.CipherButton.Click += new System.EventHandler(this.CipherButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(697, 365);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.FifthKolLettersButton);
            this.tabPage1.Controls.Add(this.FifthCipherTB);
            this.tabPage1.Controls.Add(this.DecipherButton);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.CipherButton);
            this.tabPage1.Controls.Add(this.TextTB);
            this.tabPage1.Controls.Add(this.FifthBlockTB);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.SymbolsAmount);
            this.tabPage1.Controls.Add(this.FourthBlockTB);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.ThirdBlockTB);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.FirstBlockTB);
            this.tabPage1.Controls.Add(this.SecondBlockTB);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(689, 293);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lab 5";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.SixDecipherButton);
            this.tabPage2.Controls.Add(this.SixCipherButton);
            this.tabPage2.Controls.Add(this.SixDecipherTable);
            this.tabPage2.Controls.Add(this.SixLettersTable);
            this.tabPage2.Controls.Add(this.pictureBox3);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.SixClosedTextTB);
            this.tabPage2.Controls.Add(this.SixOpenTextTB);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(689, 335);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lab 6";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // SixCipherButton
            // 
            this.SixCipherButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.SixCipherButton.Location = new System.Drawing.Point(219, 44);
            this.SixCipherButton.Name = "SixCipherButton";
            this.SixCipherButton.Size = new System.Drawing.Size(229, 38);
            this.SixCipherButton.TabIndex = 17;
            this.SixCipherButton.Text = "Зашифровать";
            this.SixCipherButton.UseVisualStyleBackColor = true;
            this.SixCipherButton.Click += new System.EventHandler(this.SixCipherButton_Click);
            // 
            // SixLettersTable
            // 
            this.SixLettersTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.SixLettersTable.ColumnCount = 4;
            this.SixLettersTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SixLettersTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SixLettersTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SixLettersTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SixLettersTable.Location = new System.Drawing.Point(13, 44);
            this.SixLettersTable.Name = "SixLettersTable";
            this.SixLettersTable.RowCount = 4;
            this.SixLettersTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SixLettersTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SixLettersTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.96694F));
            this.SixLettersTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.44628F));
            this.SixLettersTable.Size = new System.Drawing.Size(200, 122);
            this.SixLettersTable.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Текст для шифрования";
            // 
            // SixOpenTextTB
            // 
            this.SixOpenTextTB.Location = new System.Drawing.Point(219, 6);
            this.SixOpenTextTB.Name = "SixOpenTextTB";
            this.SixOpenTextTB.ReadOnly = true;
            this.SixOpenTextTB.Size = new System.Drawing.Size(229, 23);
            this.SixOpenTextTB.TabIndex = 2;
            this.SixOpenTextTB.Text = "ВРЕМЕНА_МЕНЯЮТСЯ";
            // 
            // DecipherButton
            // 
            this.DecipherButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.DecipherButton.Location = new System.Drawing.Point(347, 109);
            this.DecipherButton.Name = "DecipherButton";
            this.DecipherButton.Size = new System.Drawing.Size(164, 24);
            this.DecipherButton.TabIndex = 17;
            this.DecipherButton.Text = " Расшифровать";
            this.DecipherButton.UseVisualStyleBackColor = true;
            this.DecipherButton.Click += new System.EventHandler(this.DecipherButton_Click);
            // 
            // FifthCipherTB
            // 
            this.FifthCipherTB.Location = new System.Drawing.Point(348, 39);
            this.FifthCipherTB.Name = "FifthCipherTB";
            this.FifthCipherTB.Size = new System.Drawing.Size(162, 65);
            this.FifthCipherTB.TabIndex = 18;
            this.FifthCipherTB.Text = "";
            // 
            // SixDecipherButton
            // 
            this.SixDecipherButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.SixDecipherButton.Location = new System.Drawing.Point(219, 209);
            this.SixDecipherButton.Name = "SixDecipherButton";
            this.SixDecipherButton.Size = new System.Drawing.Size(229, 38);
            this.SixDecipherButton.TabIndex = 18;
            this.SixDecipherButton.Text = "Расшифровать";
            this.SixDecipherButton.UseVisualStyleBackColor = true;
            this.SixDecipherButton.Click += new System.EventHandler(this.SixDecipherButton_Click);
            // 
            // FifthKolLettersButton
            // 
            this.FifthKolLettersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FifthKolLettersButton.Location = new System.Drawing.Point(519, 6);
            this.FifthKolLettersButton.Name = "FifthKolLettersButton";
            this.FifthKolLettersButton.Size = new System.Drawing.Size(164, 24);
            this.FifthKolLettersButton.TabIndex = 19;
            this.FifthKolLettersButton.Text = "Кол-во букв";
            this.FifthKolLettersButton.UseVisualStyleBackColor = true;
            this.FifthKolLettersButton.Click += new System.EventHandler(this.FifthKolLettersButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Текст для дешифрования";
            // 
            // SixClosedTextTB
            // 
            this.SixClosedTextTB.Location = new System.Drawing.Point(219, 180);
            this.SixClosedTextTB.Name = "SixClosedTextTB";
            this.SixClosedTextTB.ReadOnly = true;
            this.SixClosedTextTB.Size = new System.Drawing.Size(229, 23);
            this.SixClosedTextTB.TabIndex = 2;
            this.SixClosedTextTB.Text = "ЗС_ТДРЕАИ_ЧОАП_В";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LAB4.Properties.Resources.lab5;
            this.pictureBox1.Location = new System.Drawing.Point(525, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 137);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::LAB4.Properties.Resources.Снимок_экрана_2023_02_07_125342;
            this.pictureBox3.Location = new System.Drawing.Point(454, 180);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(184, 97);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LAB4.Properties.Resources.Снимок_экрана_2023_02_02_174432;
            this.pictureBox2.Location = new System.Drawing.Point(454, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(227, 122);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // SixDecipherTable
            // 
            this.SixDecipherTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.SixDecipherTable.ColumnCount = 4;
            this.SixDecipherTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SixDecipherTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SixDecipherTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SixDecipherTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SixDecipherTable.Location = new System.Drawing.Point(13, 205);
            this.SixDecipherTable.Name = "SixDecipherTable";
            this.SixDecipherTable.RowCount = 4;
            this.SixDecipherTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SixDecipherTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SixDecipherTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.96694F));
            this.SixDecipherTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.44628F));
            this.SixDecipherTable.Size = new System.Drawing.Size(200, 122);
            this.SixDecipherTable.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 365);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Лабораторные работы 5, 6";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TextTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SymbolsAmount;
        private System.Windows.Forms.PictureBox pictureBox1;
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox SixOpenTextTB;
        private System.Windows.Forms.Button SixCipherButton;
        private System.Windows.Forms.TableLayoutPanel SixLettersTable;
        private System.Windows.Forms.Button DecipherButton;
        private System.Windows.Forms.RichTextBox FifthCipherTB;
        private System.Windows.Forms.Button SixDecipherButton;
        private System.Windows.Forms.Button FifthKolLettersButton;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SixClosedTextTB;
        private System.Windows.Forms.TableLayoutPanel SixDecipherTable;
    }
}

