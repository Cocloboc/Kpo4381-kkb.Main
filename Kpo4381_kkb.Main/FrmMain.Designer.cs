namespace Kpo4381.kkb.Main
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.nmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mmCompany = new System.Windows.Forms.ToolStripMenuItem();
            this.mnOpenCompany = new System.Windows.Forms.ToolStripMenuItem();
            this.mmSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvCompanies = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LoadFileStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.CatsTextBox = new System.Windows.Forms.RichTextBox();
            this.UpdateDataTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompanies)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmFile,
            this.mmCompany,
            this.mmSettings});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "MMenu";
            // 
            // mmFile
            // 
            this.mmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nmExit,
            this.mnOpen});
            this.mmFile.Name = "mmFile";
            this.mmFile.Size = new System.Drawing.Size(70, 24);
            this.mmFile.Text = "1&.Файл";
            // 
            // nmExit
            // 
            this.nmExit.Name = "nmExit";
            this.nmExit.Size = new System.Drawing.Size(150, 26);
            this.nmExit.Text = "Выход";
            this.nmExit.Click += new System.EventHandler(this.nmExit_Click);
            // 
            // mnOpen
            // 
            this.mnOpen.Name = "mnOpen";
            this.mnOpen.Size = new System.Drawing.Size(150, 26);
            this.mnOpen.Text = "Открыть";
            this.mnOpen.Click += new System.EventHandler(this.mnOpen_Click);
            // 
            // mmCompany
            // 
            this.mmCompany.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnOpenCompany});
            this.mmCompany.Name = "mmCompany";
            this.mmCompany.Size = new System.Drawing.Size(107, 24);
            this.mmCompany.Text = "2&.Компании";
            // 
            // mnOpenCompany
            // 
            this.mnOpenCompany.Name = "mnOpenCompany";
            this.mnOpenCompany.Size = new System.Drawing.Size(282, 26);
            this.mnOpenCompany.Text = "Открыть данные компании";
            this.mnOpenCompany.Click += new System.EventHandler(this.mnOpenCompany_Click);
            // 
            // mmSettings
            // 
            this.mmSettings.Name = "mmSettings";
            this.mmSettings.Size = new System.Drawing.Size(109, 24);
            this.mmSettings.Text = "3&.Настройки";
            this.mmSettings.Click += new System.EventHandler(this.mmSettings_Click);
            // 
            // dgvCompanies
            // 
            this.dgvCompanies.AllowUserToAddRows = false;
            this.dgvCompanies.AllowUserToDeleteRows = false;
            this.dgvCompanies.AllowUserToResizeColumns = false;
            this.dgvCompanies.AllowUserToResizeRows = false;
            this.dgvCompanies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCompanies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompanies.Location = new System.Drawing.Point(12, 31);
            this.dgvCompanies.Name = "dgvCompanies";
            this.dgvCompanies.ReadOnly = true;
            this.dgvCompanies.RowHeadersVisible = false;
            this.dgvCompanies.RowHeadersWidth = 51;
            this.dgvCompanies.RowTemplate.Height = 24;
            this.dgvCompanies.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompanies.Size = new System.Drawing.Size(776, 407);
            this.dgvCompanies.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadFileStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 507);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // LoadFileStatusLabel
            // 
            this.LoadFileStatusLabel.Name = "LoadFileStatusLabel";
            this.LoadFileStatusLabel.Size = new System.Drawing.Size(0, 16);
            // 
            // CatsTextBox
            // 
            this.CatsTextBox.Location = new System.Drawing.Point(12, 444);
            this.CatsTextBox.Name = "CatsTextBox";
            this.CatsTextBox.ReadOnly = true;
            this.CatsTextBox.Size = new System.Drawing.Size(776, 56);
            this.CatsTextBox.TabIndex = 3;
            this.CatsTextBox.Text = "";
            // 
            // UpdateDataTimer
            // 
            this.UpdateDataTimer.Enabled = true;
            this.UpdateDataTimer.Interval = 10000;
            this.UpdateDataTimer.Tick += new System.EventHandler(this.UpdateDataTimer_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 529);
            this.Controls.Add(this.CatsTextBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgvCompanies);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompanies)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mmFile;
        private System.Windows.Forms.ToolStripMenuItem nmExit;
        private System.Windows.Forms.ToolStripMenuItem mnOpen;
        private System.Windows.Forms.DataGridView dgvCompanies;
        private System.Windows.Forms.ToolStripMenuItem mmCompany;
        private System.Windows.Forms.ToolStripMenuItem mnOpenCompany;
        private System.Windows.Forms.ToolStripMenuItem mmSettings;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel LoadFileStatusLabel;
        private System.Windows.Forms.RichTextBox CatsTextBox;
        private System.Windows.Forms.Timer UpdateDataTimer;
    }
}

