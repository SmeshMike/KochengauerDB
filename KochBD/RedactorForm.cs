using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KochBD
{
    public partial class RedactorForm : Form
    {
        public RedactorForm()
        {
            InitializeComponent();
        }

        private void surnameTextBox_Enter(object sender, EventArgs e)
        {
            if (surnameTextBox.ForeColor == Color.Gray)
            {
                surnameTextBox.Text = "";
                surnameTextBox.Font = new Font(surnameTextBox.Font, FontStyle.Regular);
                surnameTextBox.ForeColor = Color.Black;
            }
        }

        private void surnameTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(surnameTextBox.Text))
            {
                surnameTextBox.Text = "Введите фамилию";
                surnameTextBox.Font = new Font(surnameTextBox.Font, FontStyle.Italic);
                surnameTextBox.ForeColor = Color.Gray;
            }
        }

        private void nameTextBox_Enter(object sender, EventArgs e)
        {
            if (nameTextBox.ForeColor == Color.Gray)
            {
                nameTextBox.Text = "";
                nameTextBox.Font = new Font(nameTextBox.Font, FontStyle.Regular);
                nameTextBox.ForeColor = Color.Black;
            }
        }

        private void nameTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                nameTextBox.Text = "Введите имя";
                nameTextBox.Font = new Font(nameTextBox.Font, FontStyle.Italic);
                nameTextBox.ForeColor = Color.Gray;
            }
        }

        private void patronymicTextBox_Enter(object sender, EventArgs e)
        {
            if (patronymicTextBox.ForeColor == Color.Gray)
            {
                patronymicTextBox.Text = "";
                patronymicTextBox.Font = new Font(patronymicTextBox.Font, FontStyle.Regular);
                patronymicTextBox.ForeColor = Color.Black;
            }
        }

        private void patronymicTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(patronymicTextBox.Text))
            {
                patronymicTextBox.Text = "Введите отчество";
                patronymicTextBox.Font = new Font(patronymicTextBox.Font, FontStyle.Italic);
                patronymicTextBox.ForeColor = Color.Gray;
            }
        }

        private void adressTextBox_Enter(object sender, EventArgs e)
        {
            if (adressTextBox.ForeColor == Color.Gray)
            {
                adressTextBox.Text = "";
                adressTextBox.Font = new Font(adressTextBox.Font, FontStyle.Regular);
                adressTextBox.ForeColor = Color.Black;
            }
        }

        private void adressTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(adressTextBox.Text))
            {
                adressTextBox.Text = "Введите адресс";
                adressTextBox.Font = new Font(adressTextBox.Font, FontStyle.Italic);
                adressTextBox.ForeColor = Color.Gray;
            }
        }

        private void commentTextBox_Enter(object sender, EventArgs e)
        {
            if (commentTextBox.ForeColor == Color.Gray)
            {
                commentTextBox.Text = "";
                commentTextBox.Font = new Font(commentTextBox.Font, FontStyle.Regular);
                commentTextBox.ForeColor = Color.Black;
            }
        }

        private void commentTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(commentTextBox.Text))
            {
                commentTextBox.Text = "Введите комментарий";
                commentTextBox.Font = new Font(commentTextBox.Font, FontStyle.Italic);
                commentTextBox.ForeColor = Color.Gray;
            }
        }

        private void providerComboBox_Enter(object sender, EventArgs e)
        {
            if (providerComboBox.ForeColor == Color.Gray)
            {
                providerComboBox.Text = "";
                providerComboBox.Font = new Font(providerComboBox.Font, FontStyle.Regular);
                providerComboBox.ForeColor = Color.Black;
            }
        }

        private void providerComboBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(providerComboBox.Text))
            {
                providerComboBox.Text = "Выберите провайдер";
                providerComboBox.Font = new Font(providerComboBox.Font, FontStyle.Italic);
                providerComboBox.ForeColor = Color.Gray;
            }
        }

        private void birthDateTextBox_Enter(object sender, EventArgs e)
        {
            if (birthDateTextBox.ForeColor == Color.Gray)
            {
                birthDateTextBox.Text = "";
                birthDateTextBox.Font = new Font(birthDateTextBox.Font, FontStyle.Regular);
                birthDateTextBox.ForeColor = Color.Black;
            }
        }

        private void birthDateTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(birthDateTextBox.Text))
            {
                birthDateTextBox.Text = "Введите дату рождения";
                birthDateTextBox.Font = new Font(birthDateTextBox.Font, FontStyle.Italic);
                birthDateTextBox.ForeColor = Color.Gray;
            }
        }


        private void numberTextBox_Enter(object sender, EventArgs e)
        {
            if (numberTextBox.ForeColor == Color.Gray)
            {
                numberTextBox.Text = "";
                numberTextBox.Font = new Font(numberTextBox.Font, FontStyle.Regular);
                numberTextBox.ForeColor = Color.Black;
            }
        }

        private void numberTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(numberTextBox.Text))
            {
                numberTextBox.Text = "Введите дату рождения";
                numberTextBox.Font = new Font(numberTextBox.Font, FontStyle.Italic);
                numberTextBox.ForeColor = Color.Gray;
            }
        }


        public Dictionary<int, string> ProviderData
        {
            set
            { 
                providerComboBox.DataSource = value.ToArray();
                providerComboBox.DisplayMember = "value";
            }
        }

        public List<string> TypeData
        {
            set
            {
                typeComboBox.DataSource = value.ToArray();
                typeComboBox.DisplayMember = "value";
            }
        }



        public int ProviderId
        {
            get
            {
                return ((KeyValuePair<int, string>)providerComboBox.SelectedItem).Key;
            }
        }

        public int TypeId
        {
            get
            {
                return ((KeyValuePair<int, string>)providerComboBox.SelectedItem).Key;
            }
        }


    }
}
