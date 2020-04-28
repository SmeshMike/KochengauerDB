namespace KochBD
{
    partial class RedactorForm
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
            this.providerComboBox = new System.Windows.Forms.ComboBox();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.adressTextBox = new System.Windows.Forms.TextBox();
            this.patronymicTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.birthDateTextBox = new System.Windows.Forms.TextBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // providerComboBox
            // 
            this.providerComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.providerComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.providerComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.providerComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.471698F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.providerComboBox.ForeColor = System.Drawing.Color.Black;
            this.providerComboBox.FormattingEnabled = true;
            this.providerComboBox.Location = new System.Drawing.Point(280, 245);
            this.providerComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.providerComboBox.Name = "providerComboBox";
            this.providerComboBox.Size = new System.Drawing.Size(145, 21);
            this.providerComboBox.TabIndex = 26;
            this.providerComboBox.Text = "Выберите провайдера";
            this.providerComboBox.Enter += new System.EventHandler(this.providerComboBox_Enter);
            this.providerComboBox.Leave += new System.EventHandler(this.providerComboBox_Leave);
            // 
            // commentTextBox
            // 
            this.commentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.471698F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.commentTextBox.ForeColor = System.Drawing.Color.Gray;
            this.commentTextBox.Location = new System.Drawing.Point(13, 148);
            this.commentTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(412, 59);
            this.commentTextBox.TabIndex = 23;
            this.commentTextBox.Text = "Введите комментарий";
            this.commentTextBox.Enter += new System.EventHandler(this.commentTextBox_Enter);
            this.commentTextBox.Leave += new System.EventHandler(this.commentTextBox_Leave);
            // 
            // adressTextBox
            // 
            this.adressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.471698F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adressTextBox.ForeColor = System.Drawing.Color.Gray;
            this.adressTextBox.Location = new System.Drawing.Point(13, 106);
            this.adressTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.adressTextBox.Name = "adressTextBox";
            this.adressTextBox.Size = new System.Drawing.Size(412, 20);
            this.adressTextBox.TabIndex = 22;
            this.adressTextBox.Text = "Введите адрес";
            this.adressTextBox.Enter += new System.EventHandler(this.adressTextBox_Enter);
            this.adressTextBox.Leave += new System.EventHandler(this.adressTextBox_Leave);
            // 
            // patronymicTextBox
            // 
            this.patronymicTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.471698F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patronymicTextBox.ForeColor = System.Drawing.Color.Gray;
            this.patronymicTextBox.Location = new System.Drawing.Point(313, 22);
            this.patronymicTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.patronymicTextBox.Name = "patronymicTextBox";
            this.patronymicTextBox.Size = new System.Drawing.Size(110, 20);
            this.patronymicTextBox.TabIndex = 20;
            this.patronymicTextBox.Text = "Введите отчество";
            this.patronymicTextBox.Enter += new System.EventHandler(this.patronymicTextBox_Enter);
            this.patronymicTextBox.Leave += new System.EventHandler(this.patronymicTextBox_Leave);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.471698F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.ForeColor = System.Drawing.Color.Gray;
            this.nameTextBox.Location = new System.Drawing.Point(162, 22);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(110, 20);
            this.nameTextBox.TabIndex = 17;
            this.nameTextBox.Text = "Введите имя";
            this.nameTextBox.Enter += new System.EventHandler(this.nameTextBox_Enter);
            this.nameTextBox.Leave += new System.EventHandler(this.nameTextBox_Leave);
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.471698F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameTextBox.ForeColor = System.Drawing.Color.Gray;
            this.surnameTextBox.Location = new System.Drawing.Point(13, 22);
            this.surnameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(110, 20);
            this.surnameTextBox.TabIndex = 16;
            this.surnameTextBox.Text = "Введите фамилию";
            this.surnameTextBox.Enter += new System.EventHandler(this.surnameTextBox_Enter);
            this.surnameTextBox.Leave += new System.EventHandler(this.surnameTextBox_Leave);
            // 
            // button_OK
            // 
            this.button_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_OK.Location = new System.Drawing.Point(350, 290);
            this.button_OK.Margin = new System.Windows.Forms.Padding(2);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 24);
            this.button_OK.TabIndex = 15;
            this.button_OK.Text = "Добавить";
            this.button_OK.UseVisualStyleBackColor = true;
            // 
            // button_cancel
            // 
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Location = new System.Drawing.Point(11, 290);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(2);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(64, 24);
            this.button_cancel.TabIndex = 14;
            this.button_cancel.Text = "Отмена";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // birthDateTextBox
            // 
            this.birthDateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.471698F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthDateTextBox.ForeColor = System.Drawing.Color.Gray;
            this.birthDateTextBox.Location = new System.Drawing.Point(13, 61);
            this.birthDateTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.birthDateTextBox.Name = "birthDateTextBox";
            this.birthDateTextBox.Size = new System.Drawing.Size(110, 20);
            this.birthDateTextBox.TabIndex = 27;
            this.birthDateTextBox.Text = "Введите дату рождения";
            this.birthDateTextBox.Enter += new System.EventHandler(this.birthDateTextBox_Enter);
            this.birthDateTextBox.Leave += new System.EventHandler(this.birthDateTextBox_Leave);
            // 
            // typeComboBox
            // 
            this.typeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.471698F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeComboBox.ForeColor = System.Drawing.Color.Black;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(162, 61);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(110, 21);
            this.typeComboBox.TabIndex = 28;
            this.typeComboBox.Text = "Выберите тип";
            // 
            // numberTextBox
            // 
            this.numberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.471698F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberTextBox.ForeColor = System.Drawing.Color.Gray;
            this.numberTextBox.Location = new System.Drawing.Point(313, 61);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(112, 20);
            this.numberTextBox.TabIndex = 29;
            this.numberTextBox.Text = "Введите номер";
            this.numberTextBox.Enter += new System.EventHandler(this.numberTextBox_Enter);
            this.numberTextBox.Leave += new System.EventHandler(this.numberTextBox_Leave);
            // 
            // RedactorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 324);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.birthDateTextBox);
            this.Controls.Add(this.providerComboBox);
            this.Controls.Add(this.commentTextBox);
            this.Controls.Add(this.adressTextBox);
            this.Controls.Add(this.patronymicTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.button_cancel);
            this.Name = "RedactorForm";
            this.Text = "RedactorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ComboBox providerComboBox;
        public System.Windows.Forms.TextBox commentTextBox;
        public System.Windows.Forms.TextBox adressTextBox;
        public System.Windows.Forms.TextBox patronymicTextBox;
        public System.Windows.Forms.TextBox nameTextBox;
        public System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_cancel;
        public System.Windows.Forms.TextBox birthDateTextBox;
        public System.Windows.Forms.ComboBox typeComboBox;
        public System.Windows.Forms.TextBox numberTextBox;
    }
}