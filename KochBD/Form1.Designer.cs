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
            this.Catalog = new System.Windows.Forms.TabControl();
            this.Bases = new System.Windows.Forms.TabPage();
            this.abonDVG = new System.Windows.Forms.DataGridView();
            this.Contacts = new System.Windows.Forms.TabPage();
            this.contDVG = new System.Windows.Forms.DataGridView();
            this.Providers = new System.Windows.Forms.TabPage();
            this.provDVG = new System.Windows.Forms.DataGridView();
            this.Directory = new System.Windows.Forms.TabPage();
            this.hasConDVG = new System.Windows.Forms.DataGridView();
            this.findAbonentButton = new System.Windows.Forms.Button();
            this.abonentGroubBox = new System.Windows.Forms.GroupBox();
            this.deleteAbonentButton = new System.Windows.Forms.Button();
            this.changeAbonentButton = new System.Windows.Forms.Button();
            this.addAbonentButton = new System.Windows.Forms.Button();
            this.contactGroubBox = new System.Windows.Forms.GroupBox();
            this.deleteContactButton = new System.Windows.Forms.Button();
            this.changeContactButton = new System.Windows.Forms.Button();
            this.addContactButton = new System.Windows.Forms.Button();
            this.findContactButton = new System.Windows.Forms.Button();
            this.providerGroubBox = new System.Windows.Forms.GroupBox();
            this.deleteProviderButton = new System.Windows.Forms.Button();
            this.changeProviderButton = new System.Windows.Forms.Button();
            this.addProviderButton = new System.Windows.Forms.Button();
            this.findProviderButton = new System.Windows.Forms.Button();
            this.Catalog.SuspendLayout();
            this.Bases.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.abonDVG)).BeginInit();
            this.Contacts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contDVG)).BeginInit();
            this.Providers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.provDVG)).BeginInit();
            this.Directory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hasConDVG)).BeginInit();
            this.abonentGroubBox.SuspendLayout();
            this.contactGroubBox.SuspendLayout();
            this.providerGroubBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Catalog
            // 
            this.Catalog.Controls.Add(this.Bases);
            this.Catalog.Controls.Add(this.Contacts);
            this.Catalog.Controls.Add(this.Providers);
            this.Catalog.Controls.Add(this.Directory);
            this.Catalog.Location = new System.Drawing.Point(12, 12);
            this.Catalog.Name = "Catalog";
            this.Catalog.SelectedIndex = 0;
            this.Catalog.Size = new System.Drawing.Size(813, 733);
            this.Catalog.TabIndex = 2;
            // 
            // Bases
            // 
            this.Bases.Controls.Add(this.abonDVG);
            this.Bases.Location = new System.Drawing.Point(4, 22);
            this.Bases.Name = "Bases";
            this.Bases.Padding = new System.Windows.Forms.Padding(3);
            this.Bases.Size = new System.Drawing.Size(805, 707);
            this.Bases.TabIndex = 0;
            this.Bases.Text = "Abonents";
            this.Bases.UseVisualStyleBackColor = true;
            // 
            // abonDVG
            // 
            this.abonDVG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.abonDVG.Location = new System.Drawing.Point(3, -3);
            this.abonDVG.Name = "abonDVG";
            this.abonDVG.RowHeadersWidth = 45;
            this.abonDVG.Size = new System.Drawing.Size(796, 714);
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
            this.Contacts.Text = "Contacts";
            this.Contacts.UseVisualStyleBackColor = true;
            // 
            // contDVG
            // 
            this.contDVG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contDVG.Location = new System.Drawing.Point(0, 3);
            this.contDVG.Name = "contDVG";
            this.contDVG.RowHeadersWidth = 45;
            this.contDVG.Size = new System.Drawing.Size(799, 704);
            this.contDVG.TabIndex = 0;
            // 
            // Providers
            // 
            this.Providers.Controls.Add(this.provDVG);
            this.Providers.Location = new System.Drawing.Point(4, 22);
            this.Providers.Name = "Providers";
            this.Providers.Size = new System.Drawing.Size(805, 707);
            this.Providers.TabIndex = 2;
            this.Providers.Text = "Providers";
            this.Providers.UseVisualStyleBackColor = true;
            // 
            // provDVG
            // 
            this.provDVG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.provDVG.Location = new System.Drawing.Point(3, 4);
            this.provDVG.Name = "provDVG";
            this.provDVG.RowHeadersWidth = 45;
            this.provDVG.Size = new System.Drawing.Size(799, 700);
            this.provDVG.TabIndex = 0;
            // 
            // Directory
            // 
            this.Directory.Controls.Add(this.hasConDVG);
            this.Directory.Location = new System.Drawing.Point(4, 22);
            this.Directory.Name = "Directory";
            this.Directory.Size = new System.Drawing.Size(805, 707);
            this.Directory.TabIndex = 3;
            this.Directory.Text = "HasContact";
            this.Directory.UseVisualStyleBackColor = true;
            // 
            // hasConDVG
            // 
            this.hasConDVG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hasConDVG.Location = new System.Drawing.Point(3, 3);
            this.hasConDVG.Name = "hasConDVG";
            this.hasConDVG.RowHeadersWidth = 45;
            this.hasConDVG.Size = new System.Drawing.Size(799, 701);
            this.hasConDVG.TabIndex = 0;
            // 
            // findAbonentButton
            // 
            this.findAbonentButton.Location = new System.Drawing.Point(6, 19);
            this.findAbonentButton.Name = "findAbonentButton";
            this.findAbonentButton.Size = new System.Drawing.Size(113, 23);
            this.findAbonentButton.TabIndex = 3;
            this.findAbonentButton.Text = "Найти";
            this.findAbonentButton.UseVisualStyleBackColor = true;
            this.findAbonentButton.Click += new System.EventHandler(this.findAbonentButton_Click);
            // 
            // abonentGroubBox
            // 
            this.abonentGroubBox.Controls.Add(this.deleteAbonentButton);
            this.abonentGroubBox.Controls.Add(this.changeAbonentButton);
            this.abonentGroubBox.Controls.Add(this.addAbonentButton);
            this.abonentGroubBox.Controls.Add(this.findAbonentButton);
            this.abonentGroubBox.Location = new System.Drawing.Point(857, 12);
            this.abonentGroubBox.Name = "abonentGroubBox";
            this.abonentGroubBox.Size = new System.Drawing.Size(125, 135);
            this.abonentGroubBox.TabIndex = 6;
            this.abonentGroubBox.TabStop = false;
            this.abonentGroubBox.Text = "Абонент";
            // 
            // deleteAbonentButton
            // 
            this.deleteAbonentButton.Location = new System.Drawing.Point(6, 106);
            this.deleteAbonentButton.Name = "deleteAbonentButton";
            this.deleteAbonentButton.Size = new System.Drawing.Size(113, 23);
            this.deleteAbonentButton.TabIndex = 6;
            this.deleteAbonentButton.Text = "Удалить";
            this.deleteAbonentButton.UseVisualStyleBackColor = true;
            this.deleteAbonentButton.Click += new System.EventHandler(this.deleteAbonentButton_Click);
            // 
            // changeAbonentButton
            // 
            this.changeAbonentButton.Location = new System.Drawing.Point(6, 77);
            this.changeAbonentButton.Name = "changeAbonentButton";
            this.changeAbonentButton.Size = new System.Drawing.Size(113, 23);
            this.changeAbonentButton.TabIndex = 5;
            this.changeAbonentButton.Text = "Изменить";
            this.changeAbonentButton.UseVisualStyleBackColor = true;
            this.changeAbonentButton.Click += new System.EventHandler(this.changeAbonentButton_Click);
            // 
            // addAbonentButton
            // 
            this.addAbonentButton.Location = new System.Drawing.Point(6, 48);
            this.addAbonentButton.Name = "addAbonentButton";
            this.addAbonentButton.Size = new System.Drawing.Size(113, 23);
            this.addAbonentButton.TabIndex = 4;
            this.addAbonentButton.Text = "Добавить";
            this.addAbonentButton.UseVisualStyleBackColor = true;
            this.addAbonentButton.Click += new System.EventHandler(this.addAbonentButton_Click);
            // 
            // contactGroubBox
            // 
            this.contactGroubBox.Controls.Add(this.deleteContactButton);
            this.contactGroubBox.Controls.Add(this.changeContactButton);
            this.contactGroubBox.Controls.Add(this.addContactButton);
            this.contactGroubBox.Controls.Add(this.findContactButton);
            this.contactGroubBox.Location = new System.Drawing.Point(1032, 12);
            this.contactGroubBox.Name = "contactGroubBox";
            this.contactGroubBox.Size = new System.Drawing.Size(125, 135);
            this.contactGroubBox.TabIndex = 9;
            this.contactGroubBox.TabStop = false;
            this.contactGroubBox.Text = "Контакт";
            // 
            // deleteContactButton
            // 
            this.deleteContactButton.Location = new System.Drawing.Point(6, 106);
            this.deleteContactButton.Name = "deleteContactButton";
            this.deleteContactButton.Size = new System.Drawing.Size(113, 23);
            this.deleteContactButton.TabIndex = 6;
            this.deleteContactButton.Text = "Удалить";
            this.deleteContactButton.UseVisualStyleBackColor = true;
            // 
            // changeContactButton
            // 
            this.changeContactButton.Location = new System.Drawing.Point(6, 77);
            this.changeContactButton.Name = "changeContactButton";
            this.changeContactButton.Size = new System.Drawing.Size(113, 23);
            this.changeContactButton.TabIndex = 5;
            this.changeContactButton.Text = "Изменить";
            this.changeContactButton.UseVisualStyleBackColor = true;
            // 
            // addContactButton
            // 
            this.addContactButton.Location = new System.Drawing.Point(6, 48);
            this.addContactButton.Name = "addContactButton";
            this.addContactButton.Size = new System.Drawing.Size(113, 23);
            this.addContactButton.TabIndex = 4;
            this.addContactButton.Text = "Добавить";
            this.addContactButton.UseVisualStyleBackColor = true;
            // 
            // findContactButton
            // 
            this.findContactButton.Location = new System.Drawing.Point(6, 19);
            this.findContactButton.Name = "findContactButton";
            this.findContactButton.Size = new System.Drawing.Size(113, 23);
            this.findContactButton.TabIndex = 3;
            this.findContactButton.Text = "Найти";
            this.findContactButton.UseVisualStyleBackColor = true;
            // 
            // providerGroubBox
            // 
            this.providerGroubBox.Controls.Add(this.deleteProviderButton);
            this.providerGroubBox.Controls.Add(this.changeProviderButton);
            this.providerGroubBox.Controls.Add(this.addProviderButton);
            this.providerGroubBox.Controls.Add(this.findProviderButton);
            this.providerGroubBox.Location = new System.Drawing.Point(1207, 12);
            this.providerGroubBox.Name = "providerGroubBox";
            this.providerGroubBox.Size = new System.Drawing.Size(125, 135);
            this.providerGroubBox.TabIndex = 10;
            this.providerGroubBox.TabStop = false;
            this.providerGroubBox.Text = "Провайдер";
            // 
            // deleteProviderButton
            // 
            this.deleteProviderButton.Location = new System.Drawing.Point(6, 106);
            this.deleteProviderButton.Name = "deleteProviderButton";
            this.deleteProviderButton.Size = new System.Drawing.Size(113, 23);
            this.deleteProviderButton.TabIndex = 6;
            this.deleteProviderButton.Text = "Удалить";
            this.deleteProviderButton.UseVisualStyleBackColor = true;
            // 
            // changeProviderButton
            // 
            this.changeProviderButton.Location = new System.Drawing.Point(6, 77);
            this.changeProviderButton.Name = "changeProviderButton";
            this.changeProviderButton.Size = new System.Drawing.Size(113, 23);
            this.changeProviderButton.TabIndex = 5;
            this.changeProviderButton.Text = "Изменить";
            this.changeProviderButton.UseVisualStyleBackColor = true;
            // 
            // addProviderButton
            // 
            this.addProviderButton.Location = new System.Drawing.Point(6, 48);
            this.addProviderButton.Name = "addProviderButton";
            this.addProviderButton.Size = new System.Drawing.Size(113, 23);
            this.addProviderButton.TabIndex = 4;
            this.addProviderButton.Text = "Добавить";
            this.addProviderButton.UseVisualStyleBackColor = true;
            // 
            // findProviderButton
            // 
            this.findProviderButton.Location = new System.Drawing.Point(6, 19);
            this.findProviderButton.Name = "findProviderButton";
            this.findProviderButton.Size = new System.Drawing.Size(113, 23);
            this.findProviderButton.TabIndex = 3;
            this.findProviderButton.Text = "Найти";
            this.findProviderButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 786);
            this.Controls.Add(this.providerGroubBox);
            this.Controls.Add(this.contactGroubBox);
            this.Controls.Add(this.abonentGroubBox);
            this.Controls.Add(this.Catalog);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Catalog.ResumeLayout(false);
            this.Bases.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.abonDVG)).EndInit();
            this.Contacts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contDVG)).EndInit();
            this.Providers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.provDVG)).EndInit();
            this.Directory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hasConDVG)).EndInit();
            this.abonentGroubBox.ResumeLayout(false);
            this.contactGroubBox.ResumeLayout(false);
            this.providerGroubBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl Catalog;
        private System.Windows.Forms.TabPage Bases;
        private System.Windows.Forms.TabPage Contacts;
        private System.Windows.Forms.TabPage Providers;
        private System.Windows.Forms.TabPage Directory;
        public System.Windows.Forms.DataGridView abonDVG;
        public System.Windows.Forms.DataGridView contDVG;
        public System.Windows.Forms.DataGridView provDVG;
        public System.Windows.Forms.DataGridView hasConDVG;
        private System.Windows.Forms.Button findAbonentButton;
        private System.Windows.Forms.GroupBox abonentGroubBox;
        private System.Windows.Forms.Button deleteAbonentButton;
        private System.Windows.Forms.Button changeAbonentButton;
        private System.Windows.Forms.Button addAbonentButton;
        private System.Windows.Forms.GroupBox contactGroubBox;
        private System.Windows.Forms.Button deleteContactButton;
        private System.Windows.Forms.Button changeContactButton;
        private System.Windows.Forms.Button addContactButton;
        private System.Windows.Forms.Button findContactButton;
        private System.Windows.Forms.GroupBox providerGroubBox;
        private System.Windows.Forms.Button deleteProviderButton;
        private System.Windows.Forms.Button changeProviderButton;
        private System.Windows.Forms.Button addProviderButton;
        private System.Windows.Forms.Button findProviderButton;
    }
}

