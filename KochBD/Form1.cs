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

namespace KochBD
{
    public partial class Form1 : Form
    {
        private string connection = global::KochBD.Properties.Settings.Default.Database1ConnectionString;

        DataGridView dirDVG;

        public Form1()
        {
            InitializeComponent();
                                                  
            
        }
        
        void updateAbonentDB()
        { 
           var request = "SELECT * FROM dbo.Kochenyuk_abonent";
           var adapter = new SqlDataAdapter(request, connection);
           var abonentTable = new DataTable();
           adapter.Fill(abonentTable);
           abonDVG.DataSource = abonentTable;
           abonDVG.Columns["id"].Visible = false;
        }

        void updateContactDB()
        {
            var request = "SELECT * FROM dbo.Kochenyuk_contact";
            var adapter = new SqlDataAdapter(request, connection);
            var contactTable = new DataTable();
            adapter.Fill(contactTable);
            contDVG.DataSource = contactTable;
        }
        void updateProviderDB()
        {
            var request = "SELECT * FROM dbo.Kochenyuk_provider";
            var adapter = new SqlDataAdapter(request, connection);
            var providerTable = new DataTable();
            adapter.Fill(providerTable);
            provDVG.DataSource = providerTable;
        }

                    
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateAbonentDB();
            updateContactDB();
            updateProviderDB();
            //
            //abonDVG.Columns["name"].HeaderText = "Имя";
            //contDVG.Columns["id"].Visible = false;
            //provDVG.Columns["id"].Visible = false;
        }

    }
}
