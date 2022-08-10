namespace AppDownholes
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonClearSearch = new System.Windows.Forms.Button();
            this.textBoxResultSearch = new System.Windows.Forms.TextBox();
            this.textBoxMine = new System.Windows.Forms.TextBox();
            this.textBoxNumberDownhole = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelMine = new System.Windows.Forms.Label();
            this.labelNumberDownhole = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonClearStatistics = new System.Windows.Forms.Button();
            this.buttonStatistics = new System.Windows.Forms.Button();
            this.textBoxFindStatistics = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxStatistics = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxStatistics = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1808, 634);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightCyan;
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1800, 605);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Скважины";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1794, 599);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            this.dataGridView1.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserAddedRow);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tabPage2.Controls.Add(this.buttonClearSearch);
            this.tabPage2.Controls.Add(this.textBoxResultSearch);
            this.tabPage2.Controls.Add(this.textBoxMine);
            this.tabPage2.Controls.Add(this.textBoxNumberDownhole);
            this.tabPage2.Controls.Add(this.buttonSearch);
            this.tabPage2.Controls.Add(this.labelMine);
            this.tabPage2.Controls.Add(this.labelNumberDownhole);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1800, 605);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Поиск";
            // 
            // buttonClearSearch
            // 
            this.buttonClearSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonClearSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClearSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonClearSearch.Location = new System.Drawing.Point(141, 106);
            this.buttonClearSearch.Name = "buttonClearSearch";
            this.buttonClearSearch.Size = new System.Drawing.Size(122, 36);
            this.buttonClearSearch.TabIndex = 6;
            this.buttonClearSearch.Text = "Очистить";
            this.buttonClearSearch.UseVisualStyleBackColor = false;
            this.buttonClearSearch.Click += new System.EventHandler(this.buttonClearSearch_Click);
            // 
            // textBoxResultSearch
            // 
            this.textBoxResultSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResultSearch.Location = new System.Drawing.Point(19, 170);
            this.textBoxResultSearch.Multiline = true;
            this.textBoxResultSearch.Name = "textBoxResultSearch";
            this.textBoxResultSearch.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxResultSearch.Size = new System.Drawing.Size(1115, 407);
            this.textBoxResultSearch.TabIndex = 5;
            // 
            // textBoxMine
            // 
            this.textBoxMine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxMine.Location = new System.Drawing.Point(229, 61);
            this.textBoxMine.Name = "textBoxMine";
            this.textBoxMine.Size = new System.Drawing.Size(157, 27);
            this.textBoxMine.TabIndex = 4;
            // 
            // textBoxNumberDownhole
            // 
            this.textBoxNumberDownhole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNumberDownhole.Location = new System.Drawing.Point(20, 61);
            this.textBoxNumberDownhole.Name = "textBoxNumberDownhole";
            this.textBoxNumberDownhole.Size = new System.Drawing.Size(148, 27);
            this.textBoxNumberDownhole.TabIndex = 3;
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSearch.Location = new System.Drawing.Point(18, 106);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(100, 36);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Найти";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelMine
            // 
            this.labelMine.AutoSize = true;
            this.labelMine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMine.Location = new System.Drawing.Point(225, 30);
            this.labelMine.Name = "labelMine";
            this.labelMine.Size = new System.Drawing.Size(159, 20);
            this.labelMine.TabIndex = 1;
            this.labelMine.Text = "Месторождение";
            // 
            // labelNumberDownhole
            // 
            this.labelNumberDownhole.AutoSize = true;
            this.labelNumberDownhole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumberDownhole.Location = new System.Drawing.Point(17, 30);
            this.labelNumberDownhole.Name = "labelNumberDownhole";
            this.labelNumberDownhole.Size = new System.Drawing.Size(165, 20);
            this.labelNumberDownhole.TabIndex = 0;
            this.labelNumberDownhole.Text = "Номер скважины";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tabPage3.Controls.Add(this.buttonClearStatistics);
            this.tabPage3.Controls.Add(this.buttonStatistics);
            this.tabPage3.Controls.Add(this.textBoxFindStatistics);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.textBoxStatistics);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.comboBoxStatistics);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1800, 605);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Статистика";
            // 
            // buttonClearStatistics
            // 
            this.buttonClearStatistics.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonClearStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClearStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClearStatistics.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonClearStatistics.Location = new System.Drawing.Point(234, 161);
            this.buttonClearStatistics.Name = "buttonClearStatistics";
            this.buttonClearStatistics.Size = new System.Drawing.Size(122, 36);
            this.buttonClearStatistics.TabIndex = 9;
            this.buttonClearStatistics.Text = "Очистить";
            this.buttonClearStatistics.UseVisualStyleBackColor = false;
            this.buttonClearStatistics.Click += new System.EventHandler(this.buttonClearStatistics_Click);
            // 
            // buttonStatistics
            // 
            this.buttonStatistics.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStatistics.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonStatistics.Location = new System.Drawing.Point(29, 161);
            this.buttonStatistics.Name = "buttonStatistics";
            this.buttonStatistics.Size = new System.Drawing.Size(164, 36);
            this.buttonStatistics.TabIndex = 8;
            this.buttonStatistics.Text = "Статистика";
            this.buttonStatistics.UseVisualStyleBackColor = false;
            this.buttonStatistics.Click += new System.EventHandler(this.buttonStatistics_Click);
            // 
            // textBoxFindStatistics
            // 
            this.textBoxFindStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFindStatistics.Location = new System.Drawing.Point(29, 232);
            this.textBoxFindStatistics.Multiline = true;
            this.textBoxFindStatistics.Name = "textBoxFindStatistics";
            this.textBoxFindStatistics.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxFindStatistics.Size = new System.Drawing.Size(507, 275);
            this.textBoxFindStatistics.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(25, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Задайте значение";
            // 
            // textBoxStatistics
            // 
            this.textBoxStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxStatistics.Location = new System.Drawing.Point(234, 94);
            this.textBoxStatistics.Name = "textBoxStatistics";
            this.textBoxStatistics.Size = new System.Drawing.Size(302, 27);
            this.textBoxStatistics.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(600, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(49, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выберите пункт";
            // 
            // comboBoxStatistics
            // 
            this.comboBoxStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxStatistics.FormattingEnabled = true;
            this.comboBoxStatistics.Items.AddRange(new object[] {
            "Метод исследования",
            "Заказчик",
            "Подрядчик"});
            this.comboBoxStatistics.Location = new System.Drawing.Point(234, 46);
            this.comboBoxStatistics.Name = "comboBoxStatistics";
            this.comboBoxStatistics.Size = new System.Drawing.Size(302, 28);
            this.comboBoxStatistics.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1808, 634);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "AddDownholes";
            this.TransparencyKey = System.Drawing.SystemColors.AppWorkspace;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelMine;
        private System.Windows.Forms.Label labelNumberDownhole;
        private System.Windows.Forms.TextBox textBoxResultSearch;
        private System.Windows.Forms.TextBox textBoxMine;
        private System.Windows.Forms.TextBox textBoxNumberDownhole;
        private System.Windows.Forms.Button buttonClearSearch;
        private System.Windows.Forms.ComboBox comboBoxStatistics;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxStatistics;
        private System.Windows.Forms.TextBox textBoxFindStatistics;
        private System.Windows.Forms.Button buttonClearStatistics;
        private System.Windows.Forms.Button buttonStatistics;
    }
}

