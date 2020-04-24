namespace KochBD
{
    partial class MainForm
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
            this.Catalog = new System.Windows.Forms.TabControl();
            this.Abonents = new System.Windows.Forms.TabPage();
            this.abonDVG = new System.Windows.Forms.DataGridView();
            this.Contacts = new System.Windows.Forms.TabPage();
            this.contDVG = new System.Windows.Forms.DataGridView();
            this.Providers = new System.Windows.Forms.TabPage();
            this.provDVG = new System.Windows.Forms.DataGridView();
            this.Directory = new System.Windows.Forms.TabPage();
            this.directDVG = new System.Windows.Forms.DataGridView();
            this.findButton = new System.Windows.Forms.Button();
            this.fioTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.Catalog.SuspendLayout();
            this.Abonents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.abonDVG)).BeginInit();
            this.Contacts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contDVG)).BeginInit();
            this.Providers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.provDVG)).BeginInit();
            this.Directory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.directDVG)).BeginInit();
            this.SuspendLayout();
            // 
            // Catalog
            // 
            this.Catalog.Controls.Add(this.Abonents);
            this.Catalog.Controls.Add(this.Contacts);
            this.Catalog.Controls.Add(this.Providers);
            this.Catalog.Controls.Add(this.Directory);
            this.Catalog.Location = new System.Drawing.Point(12, 12);
            this.Catalog.Name = "Catalog";
            this.Catalog.SelectedIndex = 0;
            this.Catalog.Size = new System.Drawing.Size(813, 733);
            this.Catalog.TabIndex = 2;
            // 
            // Abonents
            // 
            this.Abonents.Controls.Add(this.abonDVG);
            this.Abonents.Location = new System.Drawing.Point(4, 22);
            this.Abonents.Name = "Abonents";
            this.Abonents.Padding = new System.Windows.Forms.Padding(3);
            this.Abonents.Size = new System.Drawing.Size(805, 707);
            this.Abonents.TabIndex = 0;
            this.Abonents.Text = "Абоненты";
            this.Abonents.UseVisualStyleBackColor = true;
            // 
            // abonDVG
            // 
            this.abonDVG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.abonDVG.Location = new System.Drawing.Point(0, 0);
            this.abonDVG.Name = "abonDVG";
            this.abonDVG.RowHeadersWidth = 45;
            this.abonDVG.Size = new System.Drawing.Size(805, 707);
            this.abonDVG.TabIndex = 0;
            // 
            // Contacts
            // 
            this.Contacts.AllowDrop = true;
            this.Contacts.Controls.Add(this.contDVG);
            this.Contacts.Location = new System.Drawing.Point(4, 22);
            this.Contacts.Name = "Contacts";
            this.Contacts.Padding = new System.Windows.Forms.Padding(3);
            this.Contacts.Size = new System.Drawing.Size(805, 707);
            this.Contacts.TabIndex = 1;
            this.Contacts.Text = "Контакты";
            this.Contacts.UseVisualStyleBackColor = true;
            // 
            // contDVG
            // 
            this.contDVG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contDVG.Location = new System.Drawing.Point(0, 0);
            this.contDVG.Name = "contDVG";
            this.contDVG.RowHeadersWidth = 45;
            this.contDVG.Size = new System.Drawing.Size(805, 707);
            this.contDVG.TabIndex = 0;
            // 
            // Providers
            // 
            this.Providers.Controls.Add(this.provDVG);
            this.Providers.Location = new System.Drawing.Point(4, 22);
            this.Providers.Name = "Providers";
            this.Providers.Size = new System.Drawing.Size(805, 707);
            this.Providers.TabIndex = 2;
            this.Providers.Text = "Провайдеры";
            this.Providers.UseVisualStyleBackColor = true;
            // 
            // provDVG
            // 
            this.provDVG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.provDVG.Location = new System.Drawing.Point(0, 0);
            this.provDVG.Name = "provDVG";
            this.provDVG.RowHeadersWidth = 45;
            this.provDVG.Size = new System.Drawing.Size(805, 707);
            this.provDVG.TabIndex = 0;
            // 
            // Directory
            // 
            this.Directory.Controls.Add(this.directDVG);
            this.Directory.Location = new System.Drawing.Point(4, 22);
            this.Directory.Name = "Directory";
            this.Directory.Size = new System.Drawing.Size(805, 707);
            this.Directory.TabIndex = 3;
            this.Directory.Text = "Справочник";
            this.Directory.UseVisualStyleBackColor = true;
            // 
            // directDVG
            // 
            this.directDVG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.directDVG.Location = new System.Drawing.Point(0, 0);
            this.directDVG.Name = "directDVG";
            this.directDVG.RowHeadersWidth = 45;
            this.directDVG.Size = new System.Drawing.Size(805, 707);
            this.directDVG.TabIndex = 0;
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(1227, 31);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(110, 23);
            this.findButton.TabIndex = 3;
            this.findButton.Text = "Найти";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // fioTextBox
            // 
            this.fioTextBox.Location = new System.Drawing.Point(864, 34);
            this.fioTextBox.Name = "fioTextBox";
            this.fioTextBox.Size = new System.Drawing.Size(100, 20);
            this.fioTextBox.TabIndex = 4;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(1059, 34);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneNumberTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(864, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1056, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Номер телефона";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(1227, 722);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(110, 23);
            this.deleteButton.TabIndex = 8;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(1227, 677);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(110, 23);
            this.editButton.TabIndex = 9;
            this.editButton.Text = "Редактировать";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(1227, 627);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(110, 23);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 786);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.fioTextBox);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.Catalog);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Catalog.ResumeLayout(false);
            this.Abonents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.abonDVG)).EndInit();
            this.Contacts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contDVG)).EndInit();
            this.Providers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.provDVG)).EndInit();
            this.Directory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.directDVG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl Catalog;
        private System.Windows.Forms.TabPage Abonents;
        private System.Windows.Forms.TabPage Contacts;
        private System.Windows.Forms.TabPage Providers;
        private System.Windows.Forms.TabPage Directory;
        public System.Windows.Forms.DataGridView abonDVG;
        public System.Windows.Forms.DataGridView contDVG;
        public System.Windows.Forms.DataGridView provDVG;
        public System.Windows.Forms.DataGridView directDVG;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.TextBox fioTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
    }
}

