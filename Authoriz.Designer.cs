namespace ProfitFurniture
{
    partial class Authoriz
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
            this.toEnter = new System.Windows.Forms.Button();
            this.Registr = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Entry = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toEnter
            // 
            this.toEnter.BackColor = System.Drawing.Color.SlateGray;
            this.toEnter.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold);
            this.toEnter.ForeColor = System.Drawing.Color.AliceBlue;
            this.toEnter.Location = new System.Drawing.Point(95, 258);
            this.toEnter.Name = "toEnter";
            this.toEnter.Size = new System.Drawing.Size(458, 44);
            this.toEnter.TabIndex = 0;
            this.toEnter.Text = "Войти";
            this.toEnter.UseVisualStyleBackColor = false;
            this.toEnter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // Registr
            // 
            this.Registr.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold);
            this.Registr.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Registr.Location = new System.Drawing.Point(331, 215);
            this.Registr.Name = "Registr";
            this.Registr.Size = new System.Drawing.Size(222, 37);
            this.Registr.TabIndex = 1;
            this.Registr.Text = "Регистрация";
            this.Registr.UseVisualStyleBackColor = true;
            this.Registr.Click += new System.EventHandler(this.Registr_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox1.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.DimGray;
            this.textBox1.Location = new System.Drawing.Point(225, 126);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(328, 28);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Логин";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox2.Font = new System.Drawing.Font("Courier New", 10.2F);
            this.textBox2.ForeColor = System.Drawing.Color.DimGray;
            this.textBox2.Location = new System.Drawing.Point(225, 160);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(328, 28);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Пароль";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.Click += new System.EventHandler(this.textBox2_Click);
            this.textBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox2_MouseDown);
            this.textBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.textBox2_MouseUp);
            // 
            // Entry
            // 
            this.Entry.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Entry.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Entry.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Entry.Location = new System.Drawing.Point(95, 215);
            this.Entry.Name = "Entry";
            this.Entry.Size = new System.Drawing.Size(222, 37);
            this.Entry.TabIndex = 5;
            this.Entry.Text = "Вход";
            this.Entry.UseVisualStyleBackColor = false;
            this.Entry.Click += new System.EventHandler(this.Entry_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SlateGray;
            this.label1.Location = new System.Drawing.Point(20, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(592, 71);
            this.label1.TabIndex = 6;
            this.label1.Text = "Profit Furniture";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Entry);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.Registr);
            this.groupBox1.Controls.Add(this.toEnter);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(67, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(667, 341);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(255, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "изменить пароль";
            this.label2.Click += new System.EventHandler(this.ChangePassword_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProfitFurniture.Properties.Resources.iconicAuthoriz_;
            this.pictureBox1.Location = new System.Drawing.Point(95, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Authoriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(798, 405);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Authoriz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProfitFurniture";
            this.Load += new System.EventHandler(this.Authoriz_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button toEnter;
        private System.Windows.Forms.Button Registr;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Entry;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
    }
}

