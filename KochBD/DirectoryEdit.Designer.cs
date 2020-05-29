namespace KochBD
{
    partial class DirectoryEdit
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
            this.typeTextBox = new System.Windows.Forms.TextBox();
            this.numberComboBox = new System.Windows.Forms.ComboBox();
            this.birthDateTextBox = new System.Windows.Forms.TextBox();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.adressTextBox = new System.Windows.Forms.TextBox();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.fullNameСomboBox = new System.Windows.Forms.ComboBox();
            this.providerTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // typeTextBox
            // 
            this.typeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.471698F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeTextBox.ForeColor = System.Drawing.Color.Black;
            this.typeTextBox.Location = new System.Drawing.Point(160, 52);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(112, 19);
            this.typeTextBox.TabIndex = 40;
            this.typeTextBox.Text = "Тип";
            // 
            // numberComboBox
            // 
            this.numberComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.471698F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberComboBox.ForeColor = System.Drawing.Color.Black;
            this.numberComboBox.FormattingEnabled = true;
            this.numberComboBox.Location = new System.Drawing.Point(312, 52);
            this.numberComboBox.Name = "numberComboBox";
            this.numberComboBox.Size = new System.Drawing.Size(110, 21);
            this.numberComboBox.TabIndex = 39;
            this.numberComboBox.Text = "Выберите номер";
            // 
            // birthDateTextBox
            // 
            this.birthDateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.471698F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthDateTextBox.ForeColor = System.Drawing.Color.Black;
            this.birthDateTextBox.Location = new System.Drawing.Point(10, 52);
            this.birthDateTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.birthDateTextBox.Name = "birthDateTextBox";
            this.birthDateTextBox.Size = new System.Drawing.Size(110, 19);
            this.birthDateTextBox.TabIndex = 38;
            this.birthDateTextBox.Text = "Дату рождения";
            // 
            // commentTextBox
            // 
            this.commentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.471698F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.commentTextBox.ForeColor = System.Drawing.Color.Black;
            this.commentTextBox.Location = new System.Drawing.Point(10, 139);
            this.commentTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.commentTextBox.Multiline = true;
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(412, 59);
            this.commentTextBox.TabIndex = 36;
            this.commentTextBox.Text = "Введите комментарий";
            // 
            // adressTextBox
            // 
            this.adressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.471698F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adressTextBox.ForeColor = System.Drawing.Color.Black;
            this.adressTextBox.Location = new System.Drawing.Point(10, 97);
            this.adressTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.adressTextBox.Name = "adressTextBox";
            this.adressTextBox.Size = new System.Drawing.Size(412, 19);
            this.adressTextBox.TabIndex = 35;
            this.adressTextBox.Text = "Введите адрес";
            // 
            // button_OK
            // 
            this.button_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_OK.Location = new System.Drawing.Point(347, 281);
            this.button_OK.Margin = new System.Windows.Forms.Padding(2);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 24);
            this.button_OK.TabIndex = 31;
            this.button_OK.Text = "Изменить";
            this.button_OK.UseVisualStyleBackColor = true;
            // 
            // button_cancel
            // 
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Location = new System.Drawing.Point(8, 281);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(2);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(64, 24);
            this.button_cancel.TabIndex = 30;
            this.button_cancel.Text = "Отмена";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // fullNameСomboBox
            // 
            this.fullNameСomboBox.FormattingEnabled = true;
            this.fullNameСomboBox.Location = new System.Drawing.Point(10, 13);
            this.fullNameСomboBox.Name = "fullNameСomboBox";
            this.fullNameСomboBox.Size = new System.Drawing.Size(412, 21);
            this.fullNameСomboBox.TabIndex = 41;
            this.fullNameСomboBox.Text = "ФИО";
            // 
            // providerTextBox
            // 
            this.providerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.471698F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.providerTextBox.ForeColor = System.Drawing.Color.Black;
            this.providerTextBox.Location = new System.Drawing.Point(310, 217);
            this.providerTextBox.Name = "providerTextBox";
            this.providerTextBox.Size = new System.Drawing.Size(112, 19);
            this.providerTextBox.TabIndex = 42;
            this.providerTextBox.Text = "Провайдер";
            // 
            // DirectoryEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 314);
            this.Controls.Add(this.providerTextBox);
            this.Controls.Add(this.fullNameСomboBox);
            this.Controls.Add(this.typeTextBox);
            this.Controls.Add(this.numberComboBox);
            this.Controls.Add(this.birthDateTextBox);
            this.Controls.Add(this.commentTextBox);
            this.Controls.Add(this.adressTextBox);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.button_cancel);
            this.Name = "DirectoryEdit";
            this.Text = "DirectoryEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox typeTextBox;
        public System.Windows.Forms.ComboBox numberComboBox;
        public System.Windows.Forms.TextBox birthDateTextBox;
        public System.Windows.Forms.TextBox commentTextBox;
        public System.Windows.Forms.TextBox adressTextBox;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_cancel;
        public System.Windows.Forms.ComboBox fullNameСomboBox;
        public System.Windows.Forms.TextBox providerTextBox;
    }
}