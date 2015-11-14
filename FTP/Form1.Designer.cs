namespace FTP
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
            this.B1 = new System.Windows.Forms.Button();
            this.TB1 = new System.Windows.Forms.TextBox();
            this.TB2 = new System.Windows.Forms.TextBox();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.B4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // B1
            // 
            this.B1.Location = new System.Drawing.Point(0, 0);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(75, 23);
            this.B1.TabIndex = 0;
            this.B1.Text = "button1";
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.B_Click);
            // 
            // TB1
            // 
            this.TB1.Location = new System.Drawing.Point(0, 100);
            this.TB1.Multiline = true;
            this.TB1.Name = "TB1";
            this.TB1.Size = new System.Drawing.Size(1032, 440);
            this.TB1.TabIndex = 1;
            // 
            // TB2
            // 
            this.TB2.Location = new System.Drawing.Point(12, 29);
            this.TB2.Multiline = true;
            this.TB2.Name = "TB2";
            this.TB2.Size = new System.Drawing.Size(1020, 65);
            this.TB2.TabIndex = 2;
            // 
            // B2
            // 
            this.B2.Location = new System.Drawing.Point(81, 0);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(75, 23);
            this.B2.TabIndex = 3;
            this.B2.Text = "button1";
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.B2_Click);
            // 
            // B3
            // 
            this.B3.Location = new System.Drawing.Point(162, 0);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(75, 23);
            this.B3.TabIndex = 4;
            this.B3.Text = "button2";
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.B3_Click);
            // 
            // B4
            // 
            this.B4.Location = new System.Drawing.Point(243, 0);
            this.B4.Name = "B4";
            this.B4.Size = new System.Drawing.Size(75, 23);
            this.B4.TabIndex = 5;
            this.B4.Text = "button3";
            this.B4.UseVisualStyleBackColor = true;
            //this.B4.Click += new System.EventHandler(this.B4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 552);
            this.Controls.Add(this.B4);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.TB2);
            this.Controls.Add(this.TB1);
            this.Controls.Add(this.B1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.TextBox TB1;
        private System.Windows.Forms.TextBox TB2;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button B4;
    }
}

