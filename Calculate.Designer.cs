namespace ProfitFurniture
{
    partial class Calculate
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.какСтарыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.какНовыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьПустуюКнигуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьОтчётToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчётВWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетПоКлиентамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.расчитатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.добавитьЗначениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SlateGray;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.создатьОтчётToolStripMenuItem,
            this.расчитатьToolStripMenuItem,
            this.добавитьЗначениеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.создатьПустуюКнигуToolStripMenuItem});
            this.файлToolStripMenuItem.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.файлToolStripMenuItem.ForeColor = System.Drawing.Color.AliceBlue;
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.BackColor = System.Drawing.Color.LightSlateGray;
            this.открытьToolStripMenuItem.ForeColor = System.Drawing.Color.AliceBlue;
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(306, 26);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.BackColor = System.Drawing.Color.LightSlateGray;
            this.сохранитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.какСтарыйToolStripMenuItem,
            this.какНовыйToolStripMenuItem});
            this.сохранитьToolStripMenuItem.ForeColor = System.Drawing.Color.AliceBlue;
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(306, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // какСтарыйToolStripMenuItem
            // 
            this.какСтарыйToolStripMenuItem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.какСтарыйToolStripMenuItem.ForeColor = System.Drawing.Color.SlateGray;
            this.какСтарыйToolStripMenuItem.Name = "какСтарыйToolStripMenuItem";
            this.какСтарыйToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.какСтарыйToolStripMenuItem.Text = "Сохранить";
            this.какСтарыйToolStripMenuItem.Click += new System.EventHandler(this.какСтарыйToolStripMenuItem_Click);
            // 
            // какНовыйToolStripMenuItem
            // 
            this.какНовыйToolStripMenuItem.BackColor = System.Drawing.Color.LightSteelBlue;
            this.какНовыйToolStripMenuItem.ForeColor = System.Drawing.Color.SlateGray;
            this.какНовыйToolStripMenuItem.Name = "какНовыйToolStripMenuItem";
            this.какНовыйToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.какНовыйToolStripMenuItem.Text = "Сохранить как";
            this.какНовыйToolStripMenuItem.Click += new System.EventHandler(this.какНовыйToolStripMenuItem_Click);
            // 
            // создатьПустуюКнигуToolStripMenuItem
            // 
            this.создатьПустуюКнигуToolStripMenuItem.BackColor = System.Drawing.Color.LightSlateGray;
            this.создатьПустуюКнигуToolStripMenuItem.ForeColor = System.Drawing.Color.AliceBlue;
            this.создатьПустуюКнигуToolStripMenuItem.Name = "создатьПустуюКнигуToolStripMenuItem";
            this.создатьПустуюКнигуToolStripMenuItem.Size = new System.Drawing.Size(306, 26);
            this.создатьПустуюКнигуToolStripMenuItem.Text = "Создать пустую книгу";
            this.создатьПустуюКнигуToolStripMenuItem.Click += new System.EventHandler(this.создатьПустуюКнигуToolStripMenuItem_Click);
            // 
            // создатьОтчётToolStripMenuItem
            // 
            this.создатьОтчётToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отчётВWordToolStripMenuItem,
            this.отчетПоКлиентамToolStripMenuItem});
            this.создатьОтчётToolStripMenuItem.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.создатьОтчётToolStripMenuItem.ForeColor = System.Drawing.Color.AliceBlue;
            this.создатьОтчётToolStripMenuItem.Name = "создатьОтчётToolStripMenuItem";
            this.создатьОтчётToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.создатьОтчётToolStripMenuItem.Text = "Создать отчёт ";
            this.создатьОтчётToolStripMenuItem.Click += new System.EventHandler(this.создатьОтчётToolStripMenuItem_Click);
            // 
            // отчётВWordToolStripMenuItem
            // 
            this.отчётВWordToolStripMenuItem.BackColor = System.Drawing.Color.SlateGray;
            this.отчётВWordToolStripMenuItem.ForeColor = System.Drawing.Color.AliceBlue;
            this.отчётВWordToolStripMenuItem.Name = "отчётВWordToolStripMenuItem";
            this.отчётВWordToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.отчётВWordToolStripMenuItem.Text = "Отчёт в Word";
            this.отчётВWordToolStripMenuItem.Click += new System.EventHandler(this.отчётВWordToolStripMenuItem_Click);
            // 
            // отчетПоКлиентамToolStripMenuItem
            // 
            this.отчетПоКлиентамToolStripMenuItem.BackColor = System.Drawing.Color.SlateGray;
            this.отчетПоКлиентамToolStripMenuItem.ForeColor = System.Drawing.Color.AliceBlue;
            this.отчетПоКлиентамToolStripMenuItem.Name = "отчетПоКлиентамToolStripMenuItem";
            this.отчетПоКлиентамToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.отчетПоКлиентамToolStripMenuItem.Text = "Отчет по клиентам";
            this.отчетПоКлиентамToolStripMenuItem.Click += new System.EventHandler(this.отчетПоКлиентамToolStripMenuItem_Click);
            // 
            // расчитатьToolStripMenuItem
            // 
            this.расчитатьToolStripMenuItem.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.расчитатьToolStripMenuItem.ForeColor = System.Drawing.Color.AliceBlue;
            this.расчитатьToolStripMenuItem.Name = "расчитатьToolStripMenuItem";
            this.расчитатьToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.расчитатьToolStripMenuItem.Text = "Расчитать";
            this.расчитатьToolStripMenuItem.Click += new System.EventHandler(this.расчитатьToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightSlateGray;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripComboBox1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 28);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Bookman Old Style", 10.2F);
            this.toolStripLabel1.ForeColor = System.Drawing.Color.AliceBlue;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(51, 25);
            this.toolStripLabel1.Text = "Лист";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 28);
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 394);
            this.dataGridView1.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Excel|*.xlsx";
            // 
            // добавитьЗначениеToolStripMenuItem
            // 
            this.добавитьЗначениеToolStripMenuItem.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold);
            this.добавитьЗначениеToolStripMenuItem.ForeColor = System.Drawing.Color.AliceBlue;
            this.добавитьЗначениеToolStripMenuItem.Name = "добавитьЗначениеToolStripMenuItem";
            this.добавитьЗначениеToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.добавитьЗначениеToolStripMenuItem.Text = "Добавить значение";
            this.добавитьЗначениеToolStripMenuItem.Click += new System.EventHandler(this.добавитьЗначениеToolStripMenuItem_Click);
            // 
            // Calculate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Calculate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculate";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Calculate_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem создатьОтчётToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem расчитатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem какСтарыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem какНовыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчётВWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетПоКлиентамToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьПустуюКнигуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьЗначениеToolStripMenuItem;
    }
}