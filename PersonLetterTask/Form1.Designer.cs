namespace PersonLetterTask
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNameLetter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSender = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTags = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.dtDataReg = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdLetter = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название письма";
            // 
            // txtNameLetter
            // 
            this.txtNameLetter.Location = new System.Drawing.Point(187, 79);
            this.txtNameLetter.Name = "txtNameLetter";
            this.txtNameLetter.Size = new System.Drawing.Size(221, 22);
            this.txtNameLetter.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Дата регистрации";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Адресат";
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(187, 161);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(221, 22);
            this.txtDestination.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Отправитель";
            // 
            // txtSender
            // 
            this.txtSender.Location = new System.Drawing.Point(187, 210);
            this.txtSender.Name = "txtSender";
            this.txtSender.Size = new System.Drawing.Size(221, 22);
            this.txtSender.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Тэги";
            // 
            // txtTags
            // 
            this.txtTags.Location = new System.Drawing.Point(187, 250);
            this.txtTags.Name = "txtTags";
            this.txtTags.Size = new System.Drawing.Size(221, 22);
            this.txtTags.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Содержание";
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(187, 288);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(653, 180);
            this.txtContent.TabIndex = 1;
            // 
            // dtDataReg
            // 
            this.dtDataReg.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataReg.Location = new System.Drawing.Point(187, 121);
            this.dtDataReg.Name = "dtDataReg";
            this.dtDataReg.Size = new System.Drawing.Size(109, 22);
            this.dtDataReg.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(495, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 64);
            this.button1.TabIndex = 3;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Индификатор письма";
            // 
            // txtIdLetter
            // 
            this.txtIdLetter.Enabled = false;
            this.txtIdLetter.Location = new System.Drawing.Point(187, 40);
            this.txtIdLetter.Name = "txtIdLetter";
            this.txtIdLetter.Size = new System.Drawing.Size(92, 22);
            this.txtIdLetter.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(653, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 66);
            this.button2.TabIndex = 4;
            this.button2.Text = "Найти";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(495, 163);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 65);
            this.button3.TabIndex = 5;
            this.button3.Text = "Обновить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(653, 163);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(126, 65);
            this.button4.TabIndex = 6;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 532);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtDataReg);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTags);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSender);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdLetter);
            this.Controls.Add(this.txtNameLetter);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNameLetter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTags;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.DateTimePicker dtDataReg;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIdLetter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

