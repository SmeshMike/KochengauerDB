using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace KochBD
{
    public partial class MainForm : Form
    {

        //string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf";
        string connectionString = string.Format("Data Source = (LocalDB)\\MSSQLLocalDB;AttachDbFilename={0};Integrated Security = True", GetConnectionSting());

        public static string GetConnectionSting()
        {
            var exeDirectory = Environment.CurrentDirectory;
            exeDirectory = exeDirectory.Substring(0, exeDirectory.Length - 10);
            var dbDirectory = "Database1.mdf";
            return Path.Combine(exeDirectory, dbDirectory);
        }
        void updateAbonentDB()
        {
            var request = "SELECT * FROM Kochenyuk_abonent";
            var adapter = new SqlDataAdapter(request, connectionString);
            var contactTable = new DataTable();
            adapter.Fill(contactTable);
            abonDVG.DataSource = contactTable;
            abonDVG.Columns["id"].Visible = false;
            var exeDirectory = Environment.CurrentDirectory;
        }

        void updateContactDB()
        {
            var request = "SELECT * FROM Kochenyuk_contact";
            var adapter = new SqlDataAdapter(request, connectionString);
            var contactTable = new DataTable();
            adapter.Fill(contactTable);
            contDVG.DataSource = contactTable;
            contDVG.Columns["id"].Visible = false;
            contDVG.Columns["phone"].HeaderText = "Телефон";
            contDVG.Columns["type"].HeaderText = "Тип";
        }

        void updateProviderDB()
        {
            var request = "SELECT * FROM Kochenyuk_provider";
            var adapter = new SqlDataAdapter(request, connectionString);
            var contactTable = new DataTable();
            adapter.Fill(contactTable);
            provDVG.DataSource = contactTable;
            provDVG.Columns["id"].Visible = false;
            provDVG.Columns["company"].HeaderText = "Название";
            provDVG.Columns["score"].Visible = false;

            
        }

        void updateDirectoryDB()
        {
            var request =
            @"SELECT *FROM Kochenyuk_abonent JOIN 
            Kochenyuk_abonent_has_contact 
            ON Kochenyuk_abonent.id=Kochenyuk_abonent_has_contact.abonent_id 
            JOIN Kochenyuk_contact
            ON Kochenyuk_contact.id=Kochenyuk_abonent_has_contact.contact_id
            LEFT JOIN Kochenyuk_provider 
            ON Kochenyuk_provider.id=Kochenyuk_contact.provider_id ";

            var adapter = new SqlDataAdapter(request, connectionString);
            var Phone_Table = new DataTable();
            adapter.Fill(Phone_Table);

            directDVG.DataSource = Phone_Table;
            //directDVG.Columns["id"].Visible = false;
            directDVG.Columns["id1"].Visible = false;
            directDVG.Columns["id2"].Visible = false;
            directDVG.Columns["provider_id"].Visible = false;
            directDVG.Columns["abonent_id"].Visible = false;
            directDVG.Columns["contact_id"].Visible = false;
            directDVG.Columns["birthdate"].Visible = false;
            directDVG.Columns["score"].Visible = false;
            directDVG.Columns["name"].HeaderText = "Имя";
            directDVG.Columns["company"].HeaderText = "Провайдер";
            directDVG.Columns["patronymic"].HeaderText = "Отчество";
            directDVG.Columns["surname"].HeaderText = "Фамилия";
            directDVG.Columns["adress"].HeaderText = "Адрес";
            directDVG.Columns["id"].Visible = false;
            //directDVG.Columns["phone"].HeaderText = "Телефон";
            directDVG.Columns["type"].HeaderText = "Тип";
        }

        public MainForm()
        {
            InitializeComponent();            
        }

        private void findButton_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(fioTextBox.Text) || !string.IsNullOrEmpty(phoneNumberTextBox.Text))
            {
                var request = @"SELECT *FROM Kochenyuk_abonent JOIN 
                              Kochenyuk_abonent_has_contact 
                              ON Kochenyuk_abonent.id=Kochenyuk_abonent_has_contact.abonent_id 
                              JOIN Kochenyuk_contact
                              ON Kochenyuk_contact.id=Kochenyuk_abonent_has_contact.contact_id
                              LEFT JOIN Kochenyuk_provider 
                              ON Kochenyuk_provider.id=Kochenyuk_contact.provider_id 
                              WHERE 1=1 ";

                if (!string.IsNullOrEmpty(fioTextBox.Text))
                    request += string.Format(@"AND Kochenyuk_abonent.surname + ' '   
                            +Kochenyuk_abonent.patronymic + ' '
                            +Kochenyuk_abonent.name LIKE N'%{0}%'", fioTextBox.Text);


                if (!string.IsNullOrEmpty(phoneNumberTextBox.Text))
                    request += string.Format("AND Kochenyuk_contact.phone LIKE '%{0}%'", phoneNumberTextBox.Text);

                var adapter = new SqlDataAdapter(request, connectionString);
                var Phone_Table = new DataTable();
                adapter.Fill(Phone_Table);
                directDVG.DataSource = Phone_Table;
                //directDVG.Update();
                directDVG.Columns["id1"].Visible = false;
                directDVG.Columns["id2"].Visible = false;
                //directDVG.Columns["provider_id"].Visible = false;
                //directDVG.Columns["abonent_id"].Visible = false;
                //directDVG.Columns["contact_id"].Visible = false;
                //directDVG.Columns["birthdate"].Visible = false;
                //directDVG.Columns["score"].Visible = false;
                //directDVG.Columns["name"].HeaderText = "Имя";
                //directDVG.Columns["name1"].HeaderText = "Провайдер";
                //directDVG.Columns["patronymic"].HeaderText = "Отчество";
                //directDVG.Columns["surname"].HeaderText = "Фамилия";
                //directDVG.Columns["adress"].HeaderText = "Адрес";
                //directDVG.Columns["phone"].HeaderText = "Телефон";
                //directDVG.Columns["type"].HeaderText = "Тип";
                //updateDirectoryDB();
            }
            else 
            {
                updateAbonentDB();
                updateContactDB();
                updateDirectoryDB();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var tabName = Catalog.SelectedTab.Text;
            if (tabName == "Абоненты")
            {
                var form = new RedactorForm();

                form.providerComboBox.Visible = false;
                form.numberTextBox.Visible = false;
                form.typeComboBox.Visible = false;

                var res = form.ShowDialog();
                if (res == DialogResult.OK)
                {
                    var surname = form.surnameTextBox.Text;
                    var name = form.nameTextBox.Text;
                    var patronymic = form.patronymicTextBox.Text;
                    var address = form.adressTextBox.Text;
                    var comment = form.commentTextBox.Text;

                    var birthdate = Convert.ToDateTime(form.birthDateTextBox.Text).ToString("yyyy-MM-dd HH:mm:ss.fff");

                    var connection = new SqlConnection(connectionString);
                    connection.Open();

                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            var command = new SqlCommand();
                            command.Connection = connection;
                            command.CommandType = CommandType.Text;
                            command.Transaction = transaction;

                            command.CommandText = string.Format(@"INSERT INTO Kochenyuk_abonent (surname, name, patronymic, adress, comments, birthdate) VALUES (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}')",
                                                                    surname, name, patronymic, address, comment, birthdate);
                            command.ExecuteNonQuery();

                            transaction.Commit();
                            connection.Close();

                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                        }
                    }

                }
            }
            if (tabName == "Контакты")
            {
                var form = new RedactorForm();
                {
                    var request = "SELECT * FROM Kochenyuk_provider";
                    var adapter = new SqlDataAdapter(request, connectionString);
                    var prTable = new DataTable();
                    adapter.Fill(prTable);
                    var dict = new Dictionary<int, string>();
                    foreach (DataRow row in prTable.Rows)
                    {
                        dict.Add((int)row["id"], row["company"].ToString());
                    }
                    form.ProviderData = dict;
                    dict.Clear();

                    List<string> qwe = new List<string>();

                    request = "SELECT DISTINCT  type From Kochenyuk_contact";
                    adapter = new SqlDataAdapter(request, connectionString);
                    prTable = new DataTable();
                    adapter.Fill(prTable);

                    foreach (DataRow row in prTable.Rows)
                    {
                        qwe.Add(row["type"].ToString());
                    }
                    form.TypeData = qwe;
                    form.surnameTextBox.Visible = false;
                    form.nameTextBox.Visible = false;
                    form.patronymicTextBox.Visible = false;
                    form.adressTextBox.Visible = false;
                    form.commentTextBox.Visible = false;
                    form.birthDateTextBox.Visible = false;
                }
                var res = form.ShowDialog();
                if (res == DialogResult.OK)
                {
                    
                    var providerId = form.ProviderId;

                    var number = form.numberTextBox.Text;
                    var type = form.typeComboBox.Text;


                    var connection = new SqlConnection(connectionString);
                    connection.Open();

                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            var command = new SqlCommand();
                            command.Connection = connection;
                            command.CommandType = CommandType.Text;
                            command.Transaction = transaction;
                                                                       
                            command.CommandText = string.Format("INSERT INTO Kochenyuk_contact VALUES (N'{0}',N'{1}',N'{2}')",
                                                                 number, type, providerId);
                            command.ExecuteNonQuery();

                            transaction.Commit();
                            connection.Close();

                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                        }
                    }

                }
            }
            if (tabName == "Провайдеры")
            {
                var form = new RedactorForm();

                form.surnameTextBox.Visible = false;
                form.patronymicTextBox.Visible = false;
                form.adressTextBox.Visible = false;
                form.commentTextBox.Visible = false;
                form.birthDateTextBox.Visible = false;
                form.numberTextBox.Visible = false;
                form.typeComboBox.Visible = false;
                form.providerComboBox.Visible = false;
                var res = form.ShowDialog();
                if (res == DialogResult.OK)
                {
                    var name = form.nameTextBox.Text;
                    
                    var connection = new SqlConnection(connectionString);
                    connection.Open();

                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            var command = new SqlCommand();
                            command.Connection = connection;
                            command.CommandType = CommandType.Text;
                            command.Transaction = transaction;

                            command.CommandText = string.Format(@"INSERT INTO Kochenyuk_provider (company, score) VALUES (N'{0}',100)", name);
                            command.ExecuteNonQuery();
                                                      
                            transaction.Commit();
                            connection.Close();

                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                        }
                    }

                }
            }
        

            if (tabName == "Справочник")
            {
                var form = new RedactorForm();
                {
                    var request = "SELECT * FROM Kochenyuk_provider";
                    var adapter = new SqlDataAdapter(request, connectionString);
                    var prTable = new DataTable();
                    adapter.Fill(prTable);
                    var dict = new Dictionary<int, string>();
                    foreach (DataRow row in prTable.Rows)
                    {
                        dict.Add((int)row["id"], row["company"].ToString());
                    }
                    form.ProviderData = dict;
                    dict.Clear();

                    List<string> qwe = new List<string>();

                    request = "SELECT DISTINCT  type From Kochenyuk_contact";
                    adapter = new SqlDataAdapter(request, connectionString);
                    prTable = new DataTable();
                    adapter.Fill(prTable);

                    foreach (DataRow row in prTable.Rows)
                    {
                        qwe.Add(row["type"].ToString());
                    }
                    form.TypeData = qwe;

                }
                var res = form.ShowDialog();
                if (res == DialogResult.OK)
                {
                    var surname = form.surnameTextBox.Text;
                    var name = form.nameTextBox.Text;
                    var patronymic = form.patronymicTextBox.Text;
                    var address = form.adressTextBox.Text;
                    var comment = form.commentTextBox.Text;

                    var providerId = form.ProviderId;

                    var number = form.numberTextBox.Text;
                    var type = form.typeComboBox.Text;
                    var birthdate = Convert.ToDateTime(form.birthDateTextBox.Text).ToString("yyyy-MM-dd HH:mm:ss.fff");

                    var connection = new SqlConnection(connectionString);
                    connection.Open();

                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            var command = new SqlCommand();
                            command.Connection = connection;
                            command.CommandType = CommandType.Text;
                            command.Transaction = transaction;

                            command.CommandText = string.Format(@"INSERT INTO Kochenyuk_abonent (surname, name, patronymic, adress, comments, birthdate) VALUES (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}')",
                                                                    surname, name, patronymic, address, comment, birthdate);
                            command.ExecuteNonQuery();
                            command.CommandText = string.Format("INSERT INTO Kochenyuk_contact VALUES (N'{0}',N'{1}',N'{2}')",
                                                                 number, type, providerId);
                            command.ExecuteNonQuery();

                            command.CommandText = string.Format("INSERT INTO dbo.Kochenyuk_abonent_has_contact values" +
                                                                "((select id from dbo.Kochenyuk_abonent where name=N'{0}'), (select id from dbo.Kochenyuk_contact where Phone = N'{1}'))",
                                                                 name, number);
                            command.ExecuteNonQuery();

                            transaction.Commit();
                            connection.Close();

                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                        }
                    }

                }
            }
            updateAbonentDB();
            updateContactDB();
            updateDirectoryDB();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            var tabName = Catalog.SelectedTab.Text;
            var form = new RedactorForm();

            DataGridViewRow row = null;

            if (tabName == "Абоненты")
            {
                row = abonDVG.SelectedRows.Count > 0 ? abonDVG.SelectedRows[0] : null;

                if (row == null)
                {
                    MessageBox.Show(" Сначала выберите строчку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                form.providerComboBox.Visible = false;
                form.numberTextBox.Visible = false;
                form.typeComboBox.Visible = false;


                form.surnameTextBox.Text = row.Cells["surname"].Value.ToString();
                form.surnameTextBox.ForeColor = Color.Black;
                form.surnameTextBox.Font = new Font(form.surnameTextBox.Font, FontStyle.Regular);

                form.nameTextBox.Text = row.Cells["name"].Value.ToString();
                form.nameTextBox.ForeColor = Color.Black;
                form.nameTextBox.Font = new Font(form.nameTextBox.Font, FontStyle.Regular);

                form.patronymicTextBox.Text = row.Cells["patronymic"].Value.ToString();
                form.patronymicTextBox.ForeColor = Color.Black;
                form.patronymicTextBox.Font = new Font(form.patronymicTextBox.Font, FontStyle.Regular);

                form.adressTextBox.Text = row.Cells["adress"].Value.ToString();
                form.adressTextBox.ForeColor = Color.Black;
                form.adressTextBox.Font = new Font(form.adressTextBox.Font, FontStyle.Regular);

                form.commentTextBox.Text = row.Cells["comments"].Value.ToString();
                form.commentTextBox.ForeColor = Color.Black;
                form.commentTextBox.Font = new Font(form.commentTextBox.Font, FontStyle.Regular);

                form.birthDateTextBox.Text = row.Cells["birthdate"].Value.ToString();
                form.birthDateTextBox.ForeColor = Color.Black;
                form.birthDateTextBox.Font = new Font(form.birthDateTextBox.Font, FontStyle.Regular);

                var prevSurName = form.surnameTextBox.Text;
                var prevName = form.nameTextBox.Text;

                var res = form.ShowDialog();
                if (res == DialogResult.OK)
                {
                    var surname = form.surnameTextBox.Text;
                    var name = form.nameTextBox.Text;
                    var patronymic = form.patronymicTextBox.Text;
                    var adress = form.adressTextBox.Text;
                    var comment = form.commentTextBox.Text;
                    var id = row.Cells["id"].Value.ToString();
                    var connection = new SqlConnection(connectionString);
                    var birthdate = Convert.ToDateTime(form.birthDateTextBox.Text).ToString("yyyy-MM-dd HH:mm:ss.fff");
                    connection.Open();
                    var request = string.Format(@"UPDATE  Kochenyuk_abonent SET surname=N'{0}',name=N'{1}', patronymic=N'{2}', adress=N'{3}', comments=N'{4}', birthdate='{5}' WHERE surname=N'{6}' AND name=N'{7}'"
                                            , surname, name, patronymic, adress, comment, birthdate, prevSurName, prevName);
                    var command = new SqlCommand(request, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    updateAbonentDB();

                }


            }
            if (tabName == "Контакты")
            {
                row = contDVG.SelectedRows.Count > 0 ? contDVG.SelectedRows[0] : null;

                if (row == null)
                {
                    MessageBox.Show(" Сначала выберите строчку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                form.surnameTextBox.Visible = false;
                form.nameTextBox.Visible = false;
                form.patronymicTextBox.Visible = false;
                form.adressTextBox.Visible = false;
                form.commentTextBox.Visible = false;
                form.birthDateTextBox.Visible = false;

                form.numberTextBox.Text = row.Cells["phone"].Value.ToString();
                form.numberTextBox.ForeColor = Color.Black;
                form.numberTextBox.Font = new Font(form.numberTextBox.Font, FontStyle.Regular);

                var prevNumber = form.numberTextBox.Text;

                var request = "SELECT * FROM Kochenyuk_provider";
                var adapter = new SqlDataAdapter(request, connectionString);
                var prTable = new DataTable();
                adapter.Fill(prTable);
                var dict = new Dictionary<int, string>();
                foreach (DataRow tempRow in prTable.Rows)
                {
                    dict.Add((int)tempRow["id"], tempRow["company"].ToString());
                }
                form.ProviderData = dict;
                dict.Clear();

                List<string> qwe = new List<string>();

                request = "SELECT DISTINCT  type From Kochenyuk_contact";
                adapter = new SqlDataAdapter(request, connectionString);
                prTable = new DataTable();
                adapter.Fill(prTable);

                foreach (DataRow tempRow in prTable.Rows)
                {
                    qwe.Add(tempRow["type"].ToString());
                }
                form.TypeData = qwe;

                form.typeComboBox.Text = row.Cells["type"].Value.ToString();
                form.typeComboBox.ForeColor = Color.Black;
                form.typeComboBox.Font = new Font(form.typeComboBox.Font, FontStyle.Regular);


                var res = form.ShowDialog();
                if (res == DialogResult.OK)
                {
                    var phone = form.numberTextBox.Text;
                    var type = form.typeComboBox.Text;
                    var connection = new SqlConnection(connectionString);
                    connection.Open();
                    request = string.Format(@"UPDATE  Kochenyuk_contact SET Phone=N'{0}', type=N'{1}' WHERE Phone=N'{2}'",
                                             phone, type, prevNumber);
                    var command = new SqlCommand(request, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    updateContactDB();

                }




            }

            if (tabName == "Провайдеры")
            {
                row = provDVG.SelectedRows.Count > 0 ? provDVG.SelectedRows[0] : null;

                if (row == null)
                {
                    MessageBox.Show(" Сначала выберите строчку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                form.surnameTextBox.Visible = false;
                form.patronymicTextBox.Visible = false;
                form.adressTextBox.Visible = false;
                form.commentTextBox.Visible = false;
                form.birthDateTextBox.Visible = false;
                form.numberTextBox.Visible = false;
                form.typeComboBox.Visible = false;
                form.providerComboBox.Visible = false;

                form.nameTextBox.Text = row.Cells["Company"].Value.ToString();
                form.nameTextBox.ForeColor = Color.Black;
                form.nameTextBox.Font = new Font(form.nameTextBox.Font, FontStyle.Regular);

                var prevCompany = form.nameTextBox.Text;

                var res = form.ShowDialog();
                if (res == DialogResult.OK)
                {
                    var company = form.nameTextBox.Text;
                    var connection = new SqlConnection(connectionString);
                    connection.Open();
                    var request = string.Format(@"UPDATE Kochenyuk_provider SET company=N'{0}' WHERE company=N'{1}'",
                                                  company, prevCompany);
                    var command = new SqlCommand(request, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    updateProviderDB();

                }



            }

            if (tabName == "Справочник")
            {
                row = directDVG.SelectedRows.Count > 0 ? directDVG.SelectedRows[0] : null;

                if (row == null)
                {
                    MessageBox.Show(" Сначала выберите строчку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                form.surnameTextBox.Text = row.Cells["surname"].Value.ToString();
                form.surnameTextBox.ForeColor = Color.Black;
                form.surnameTextBox.Font = new Font(form.surnameTextBox.Font, FontStyle.Regular);

                form.nameTextBox.Text = row.Cells["name"].Value.ToString();
                form.nameTextBox.ForeColor = Color.Black;
                form.nameTextBox.Font = new Font(form.nameTextBox.Font, FontStyle.Regular);

                form.patronymicTextBox.Text = row.Cells["patronymic"].Value.ToString();
                form.patronymicTextBox.ForeColor = Color.Black;
                form.patronymicTextBox.Font = new Font(form.patronymicTextBox.Font, FontStyle.Regular);

                form.adressTextBox.Text = row.Cells["adress"].Value.ToString();
                form.adressTextBox.ForeColor = Color.Black;
                form.adressTextBox.Font = new Font(form.adressTextBox.Font, FontStyle.Regular);

                form.commentTextBox.Text = row.Cells["comments"].Value.ToString();
                form.commentTextBox.ForeColor = Color.Black;
                form.commentTextBox.Font = new Font(form.commentTextBox.Font, FontStyle.Regular);

                form.birthDateTextBox.Text = row.Cells["birthdate"].Value.ToString();
                form.birthDateTextBox.ForeColor = Color.Black;
                form.birthDateTextBox.Font = new Font(form.birthDateTextBox.Font, FontStyle.Regular);

                form.numberTextBox.Text = row.Cells["phone"].Value.ToString();
                form.numberTextBox.ForeColor = Color.Black;
                form.numberTextBox.Font = new Font(form.numberTextBox.Font, FontStyle.Regular);



                var request = "SELECT * FROM Kochenyuk_provider";
                var adapter = new SqlDataAdapter(request, connectionString);
                var prTable = new DataTable();
                adapter.Fill(prTable);
                var dict = new Dictionary<int, string>();
                foreach (DataRow tempRow in prTable.Rows)
                {
                    dict.Add((int)tempRow["id"], tempRow["company"].ToString());
                }
                form.ProviderData = dict;
                dict.Clear();

                List<string> qwe = new List<string>();

                request = "SELECT DISTINCT  type From Kochenyuk_contact";
                adapter = new SqlDataAdapter(request, connectionString);
                prTable = new DataTable();
                adapter.Fill(prTable);

                foreach (DataRow tempRow in prTable.Rows)
                {
                    qwe.Add(tempRow["type"].ToString());
                }
                form.TypeData = qwe;


                form.providerComboBox.Text = row.Cells["company"].Value.ToString();
                form.providerComboBox.ForeColor = Color.Black;
                form.providerComboBox.Font = new Font(form.providerComboBox.Font, FontStyle.Regular);

                form.typeComboBox.Text = row.Cells["type"].Value.ToString();
                form.typeComboBox.ForeColor = Color.Black;
                form.typeComboBox.Font = new Font(form.typeComboBox.Font, FontStyle.Regular);


                var res = form.ShowDialog();
                if (res == DialogResult.OK)
                {
                    var surname = form.surnameTextBox.Text;
                    var name = form.nameTextBox.Text;
                    var patronymic = form.patronymicTextBox.Text;
                    var adress = form.adressTextBox.Text;
                    var comment = form.commentTextBox.Text;
                    var phone = form.numberTextBox.Text;
                    var type = form.typeComboBox.Text;
                    var id = row.Cells["id"].Value.ToString();
                    var connection = new SqlConnection(connectionString);
                    var birthdate = Convert.ToDateTime(form.birthDateTextBox.Text).ToString("yyyy-MM-dd HH:mm:ss.fff");
                    connection.Open();
                    request = string.Format(@"UPDATE  Kochenyuk_abonent SET surname=N'{0}',name=N'{1}', patronymic=N'{2}', adress=N'{3}', comments=N'{4}', birthdate='{5}' WHERE id={6}
                                              UPDATE  Kochenyuk_contact SET Phone=N'{7}', type=N'{8}'",
                                                  surname, name, patronymic, adress, comment, birthdate, id, phone, type);
                    var command = new SqlCommand(request, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    updateAbonentDB();
                    updateDirectoryDB();
                    updateContactDB();


                }
            }
        }


        private void deleteButton_Click(object sender, EventArgs e)
        {
            var tabName = Catalog.SelectedTab.Text;

            if (tabName == "Абоненты")
            {
                var row = abonDVG.SelectedRows.Count > 0 ? abonDVG.SelectedRows[0] : null;
                if (row == null)
                {
                    MessageBox.Show("Выберите строчку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var id = row.Cells["id"].Value.ToString();
                var connection = new SqlConnection(connectionString);
                connection.Open();
                var request = string.Format(@"DELETE dbo.Kochenyuk_abonent where id = N'{0}'", id);

                var command = new SqlCommand(request, connection);
                command.ExecuteNonQuery();
                connection.Close();

            }
            if (tabName == "Контакты")
            {
                var row = contDVG.SelectedRows.Count > 0 ? contDVG.SelectedRows[0] : null;
                if (row == null)
                {
                    MessageBox.Show("Выберите строчку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var phone = row.Cells["phone"].Value.ToString();
                var connection = new SqlConnection(connectionString);
                connection.Open();
                var request = string.Format(@"DELETE dbo.Kochenyuk_contact where Phone = N'{0}'", phone);

                var command = new SqlCommand(request, connection);
                command.ExecuteNonQuery();
                connection.Close();
                

            }

            if (tabName == "Провайдеры")
            {
                var row = provDVG.SelectedRows.Count > 0 ? provDVG.SelectedRows[0] : null;
                if (row == null)
                {
                    MessageBox.Show("Выберите строчку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var name = row.Cells["Название"].Value.ToString();
                var connection = new SqlConnection(connectionString);
                connection.Open();
                var request = string.Format(@"DELETE dbo.Kochenyuk_provider where company = N'{0}'", name);

                var command = new SqlCommand(request, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }


            if (tabName == "Справочник")
            {
                var row = directDVG.SelectedRows.Count > 0 ? directDVG.SelectedRows[0] : null;
                if (row == null)
                {
                    MessageBox.Show("Выберите строчку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var id = row.Cells["id"].Value.ToString();
                var phone = row.Cells["phone"].Value.ToString();
                var connection = new SqlConnection(connectionString);
                connection.Open();
                var request = string.Format(@"DELETE dbo.Kochenyuk_abonent_has_contact where contact_id = (select id from dbo.Kochenyuk_contact where Phone = N'{0}')
                                          DELETE dbo.Kochenyuk_contact where Phone = N'{0}'
                                          DELETE dbo.Kochenyuk_abonent where id ={1}", phone, id);

                var command = new SqlCommand(request, connection);
                command.ExecuteNonQuery();
                connection.Close();
                
            }
                    
         
            updateAbonentDB();
            updateContactDB();
            updateDirectoryDB();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            updateAbonentDB();
            updateContactDB();
            updateProviderDB();
            updateDirectoryDB();
        }
    }
}