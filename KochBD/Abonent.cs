using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Data.SqlClient;
using System.Data;
using System.Linq;

namespace KochBD
{
    partial class Form1
    {
        private string connection = global::KochBD.Properties.Settings.Default.Database1ConnectionString;

        string Request { get; set; }

        public void updateAbonentDB()
        {
            var request = "SELECT * FROM dbo.Kochenyuk_abonent";
            var adapter = new SqlDataAdapter(request, connection);
            var abonentTable = new DataTable();
            adapter.Fill(abonentTable);
            abonDVG.DataSource = abonentTable;
        }

        public void updateContactDB()
        {
            var request = "SELECT * FROM dbo.Kochenyuk_contact";
            var adapter = new SqlDataAdapter(request, connection);
            var contactTable = new DataTable();
            adapter.Fill(contactTable);
            contDVG.DataSource = contactTable;
        }
        public void updateProviderDB()
        {
            var request = "SELECT * FROM dbo.Kochenyuk_provider";
            var adapter = new SqlDataAdapter(request, connection);
            var providerTable = new DataTable();
            adapter.Fill(providerTable);
            provDVG.DataSource = providerTable;
        }

        public void updateHasContactDB()
        {
            var request = "SELECT * FROM dbo.Kochenyuk_abonent_has_contact";
            var adapter = new SqlDataAdapter(request, connection);
            var providerTable = new DataTable();
            adapter.Fill(providerTable);
            hasConDVG.DataSource = providerTable;
        }

        TextBox idTextBox;

        public TextBox AddIdTextBox()
        {
            idTextBox = new TextBox();
            idTextBox.Location = new Point(863, 200);
            idTextBox.Size = new Size(113, 23);
            idTextBox.Text = "Введите Ид";
            idTextBox.ForeColor = Color.Gray;
            idTextBox.Font = new Font(idTextBox.Font, FontStyle.Italic);
            idTextBox.Leave += (sen, evearg) => {
                idTextBox.Text = "Введите ИД";
                idTextBox.ForeColor = Color.Gray;
                idTextBox.Font = new Font(idTextBox.Font, FontStyle.Italic);
            };
            idTextBox.Enter += (sen, evearg) => {
                idTextBox.Text = "";
                idTextBox.ForeColor = Color.Black;
                idTextBox.Font = new Font(idTextBox.Font, FontStyle.Regular);
            };
            idTextBox.TextChanged += (sen, evearg) =>
            {
                Text = idTextBox.Text;
            };
            Controls.Add(idTextBox);
            return idTextBox;

        }

        public TextBox AddSurNameTextBox()
        {
            TextBox surNameTextBox = new TextBox();
            surNameTextBox.Location = new Point(863, 250);
            surNameTextBox.Size = new Size(113, 23);
            surNameTextBox.Text = "Введите фамилию";
            surNameTextBox.ForeColor = Color.Gray;
            surNameTextBox.Font = new Font(surNameTextBox.Font, FontStyle.Italic);
            surNameTextBox.Leave += (sen, evearg) => {
                surNameTextBox.Text = "Введите фамилию";
                surNameTextBox.ForeColor = Color.Gray;
                surNameTextBox.Font = new Font(surNameTextBox.Font, FontStyle.Italic);
            };
            surNameTextBox.Enter += (sen, evearg) => {
                surNameTextBox.Text = "";
                surNameTextBox.ForeColor = Color.Black;
                surNameTextBox.Font = new Font(surNameTextBox.Font, FontStyle.Italic);
            };
            this.Controls.Add(surNameTextBox);
            return surNameTextBox;
        }

        public TextBox AddNameTextBox()
        {
            TextBox nameTextBox = new TextBox();
            nameTextBox.Location = new Point(1038, 250);
            nameTextBox.Size = new Size(113, 23);
            nameTextBox.Text = "Введите имя";
            nameTextBox.ForeColor = Color.Gray;
            nameTextBox.Font = new Font(nameTextBox.Font, FontStyle.Italic);
            nameTextBox.Leave += (sen, evearg) => {
                nameTextBox.Text = "Введите имя";
                nameTextBox.ForeColor = Color.Gray;
                nameTextBox.Font = new Font(nameTextBox.Font, FontStyle.Italic);
            };
            nameTextBox.Enter += (sen, evearg) => {
                nameTextBox.Text = "";
                nameTextBox.ForeColor = Color.Black;
                nameTextBox.Font = new Font(nameTextBox.Font, FontStyle.Italic);
            };
            this.Controls.Add(nameTextBox);
            return nameTextBox;
        }

        public TextBox AddPatronymicTextBox()
        {
            TextBox patronymicTextBox = new TextBox();
            patronymicTextBox.Location = new Point(1213, 250);
            patronymicTextBox.Size = new Size(113, 23);
            patronymicTextBox.Text = "Введите отчество";
            patronymicTextBox.ForeColor = Color.Gray;
            patronymicTextBox.Font = new Font(patronymicTextBox.Font, FontStyle.Italic);
            patronymicTextBox.Leave += (sen, evearg) => {
                patronymicTextBox.Text = "Введите отчество";
                patronymicTextBox.ForeColor = Color.Gray;
                patronymicTextBox.Font = new Font(patronymicTextBox.Font, FontStyle.Italic);
            };
            patronymicTextBox.Enter += (sen, evearg) =>
            {
                patronymicTextBox.Text = "";
                patronymicTextBox.ForeColor = Color.Black;
                patronymicTextBox.Font = new Font(patronymicTextBox.Font, FontStyle.Italic);
            };
            this.Controls.Add(patronymicTextBox);
            return patronymicTextBox;
        }

        public TextBox AddBirthTextBox()
        {
            TextBox birthTextBox = new TextBox();
            birthTextBox.Location = new Point(863, 300);
            birthTextBox.Size = new Size(463, 23);
            birthTextBox.Text = "Введите дату рождения";
            birthTextBox.ForeColor = Color.Gray;
            birthTextBox.Font = new Font(birthTextBox.Font, FontStyle.Italic);
            birthTextBox.Leave += (sen, evearg) => {
                birthTextBox.Text = "Введите дату рождения";
                birthTextBox.ForeColor = Color.Gray;
                birthTextBox.Font = new Font(birthTextBox.Font, FontStyle.Italic);
            };
            birthTextBox.Enter += (sen, evearg) => {
                birthTextBox.Text = "";
                birthTextBox.ForeColor = Color.Black;
                birthTextBox.Font = new Font(birthTextBox.Font, FontStyle.Regular);
            };
            this.Controls.Add(birthTextBox);
            return birthTextBox;
        }

        public TextBox AddCommentTextBox()
        {
            TextBox commentTextBox = new TextBox();
            commentTextBox.Location = new Point(863, 350);
            commentTextBox.Size = new Size(463, 23);
            commentTextBox.Text = "Оставьте комментарий";
            commentTextBox.ForeColor = Color.Gray;
            commentTextBox.Font = new Font(commentTextBox.Font, FontStyle.Italic);
            commentTextBox.Leave += (sen, evearg) => {
                commentTextBox.Text = "Оставьте комментарий";
                commentTextBox.ForeColor = Color.Gray;
                commentTextBox.Font = new Font(commentTextBox.Font, FontStyle.Italic);
            };
            commentTextBox.Enter += (sen, evearg) => {
                commentTextBox.Text = "";
                commentTextBox.ForeColor = Color.Black;
                commentTextBox.Font = new Font(commentTextBox.Font, FontStyle.Regular);
            };
            this.Controls.Add(commentTextBox);
            return commentTextBox;
        }

        public TextBox AddAdressTextBox()
        {
            TextBox adressTextBox = new TextBox();
            adressTextBox.Location = new Point(863, 400);
            adressTextBox.Size = new Size(463, 23);
            adressTextBox.Text = "Введите адрес";
            adressTextBox.ForeColor = Color.Gray;
            adressTextBox.Font = new Font(adressTextBox.Font, FontStyle.Italic);
            adressTextBox.Leave += (sen, evearg) => {
                adressTextBox.Text = "Введите адрес";
                adressTextBox.ForeColor = Color.Gray;
                adressTextBox.Font = new Font(adressTextBox.Font, FontStyle.Italic);
            };
            adressTextBox.Enter += (sen, evearg) => {
                adressTextBox.Text = "";
                adressTextBox.ForeColor = Color.Black;
                adressTextBox.Font = new Font(adressTextBox.Font, FontStyle.Regular);
            };
            this.Controls.Add(adressTextBox);
            return adressTextBox;
        }

        public Button AddRunButton(List<Control> controls)
        {
            Button run = new Button();
            run.Location = new Point(1213, 200);
            run.Size = new Size(113, 23);
            run.Text = "Выполнить";
            run.Click += (sen, evearg) =>
            {
                
                var request = string.Format(Request, controls.Select(o => o.Text).ToArray());
                var adapter = new SqlDataAdapter(request, connection);
                var abonentTable = new DataTable();
                adapter.Fill(abonentTable);
                abonDVG.DataSource = abonentTable;
            };
            this.Controls.Add(run);
            return run;
        }

        public Button AddHideButton(List<Control> controls)
        {
            Button hide = new Button();
            controls.Add(hide);
            hide.Location = new Point(1213, 722);
            hide.Size = new Size(113, 23);
            hide.Text = "Скрыть";
            hide.Click += (sen, evearg) =>
            {
                foreach (var element in controls)
                {
                    this.Controls.Remove(element);

                }

            };
            this.Controls.Add(hide);
            return hide;
        }

    }
}
