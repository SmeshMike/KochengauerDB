namespace KochBD
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.Abonent = new System.Windows.Forms.TabControl();
            this.Bases = new System.Windows.Forms.TabPage();
            this.abonDVG = new System.Windows.Forms.DataGridView();
            this.Contacts = new System.Windows.Forms.TabPage();
            this.contDVG = new System.Windows.Forms.DataGridView();
            this.Providers = new System.Windows.Forms.TabPage();
            this.provDVG = new System.Windows.Forms.DataGridView();
            this.Directory = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Abonent.SuspendLayout();
            this.Bases.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.abonDVG)).BeginInit();
            this.Contacts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contDVG)).BeginInit();
            this.Providers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.provDVG)).BeginInit();
            this.Directory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(373, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Abonent
            // 
            this.Abonent.Controls.Add(this.Bases);
            this.Abonent.Controls.Add(this.Contacts);
            this.Abonent.Controls.Add(this.Providers);
            this.Abonent.Controls.Add(this.Directory);
            this.Abonent.Location = new System.Drawing.Point(12, 41);
            this.Abonent.Name = "Abonent";
            this.Abonent.SelectedIndex = 0;
            this.Abonent.Size = new System.Drawing.Size(443, 336);
            this.Abonent.TabIndex = 2;
            // 
            // Bases
            // 
            this.Bases.Controls.Add(this.abonDVG);
            this.Bases.Location = new System.Drawing.Point(4, 22);
            this.Bases.Name = "Bases";
            this.Bases.Padding = new System.Windows.Forms.Padding(3);
            this.Bases.Size = new System.Drawing.Size(435, 310);
            this.Bases.TabIndex = 0;
            this.Bases.Text = "Abonents";
            this.Bases.UseVisualStyleBackColor = true;
            // 
            // abonDVG
            // 
            this.abonDVG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.abonDVG.Location = new System.Drawing.Point(3, 3);
            this.abonDVG.Name = "abonDVG";
            this.abonDVG.Size = new System.Drawing.Size(429, 308);
            this.abonDVG.TabIndex = 0;
            // 
            // Contacts
            // 
            this.Contacts.AllowDrop = true;
            this.Contacts.Controls.Add(this.contDVG);
            this.Contacts.Location = new System.Drawing.Point(4, 22);
            this.Contacts.Name = "Contacts";
            this.Contacts.Padding = new System.Windows.Forms.Padding(3);
            this.Contacts.Size = new System.Drawing.Size(435, 310);
            this.Contacts.TabIndex = 1;
            this.Contacts.Text = "Contacts";
            this.Contacts.UseVisualStyleBackColor = true;
            // 
            // contDVG
            // 
            this.contDVG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contDVG.Location = new System.Drawing.Point(1, 1);
            this.contDVG.Name = "contDVG";
            this.contDVG.Size = new System.Drawing.Size(428, 303);
            this.contDVG.TabIndex = 0;
            // 
            // Providers
            // 
            this.Providers.Controls.Add(this.provDVG);
            this.Providers.Location = new System.Drawing.Point(4, 22);
            this.Providers.Name = "Providers";
            this.Providers.Size = new System.Drawing.Size(435, 310);
            this.Providers.TabIndex = 2;
            this.Providers.Text = "Providers";
            this.Providers.UseVisualStyleBackColor = true;
            // 
            // provDVG
            // 
            this.provDVG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.provDVG.Location = new System.Drawing.Point(4, 3);
            this.provDVG.Name = "provDVG";
            this.provDVG.Size = new System.Drawing.Size(428, 304);
            this.provDVG.TabIndex = 0;
            // 
            // Directory
            // 
            this.Directory.Controls.Add(this.dataGridView1);
            this.Directory.Location = new System.Drawing.Point(4, 22);
            this.Directory.Name = "Directory";
            this.Directory.Size = new System.Drawing.Size(435, 310);
            this.Directory.TabIndex = 3;
            this.Directory.Text = "HasContact";
            this.Directory.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(428, 605);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 786);
            this.Controls.Add(this.Abonent);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Abonent.ResumeLayout(false);
            this.Bases.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.abonDVG)).EndInit();
            this.Contacts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contDVG)).EndInit();
            this.Providers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.provDVG)).EndInit();
            this.Directory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl Abonent;
        private System.Windows.Forms.TabPage Bases;
        private System.Windows.Forms.TabPage Contacts;
        private System.Windows.Forms.TabPage Providers;
        private System.Windows.Forms.TabPage Directory;
        private System.Windows.Forms.DataGridView abonDVG;
        private System.Windows.Forms.DataGridView contDVG;
        private System.Windows.Forms.DataGridView provDVG;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

