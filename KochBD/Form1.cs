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


        
        
        public Form1()
        {
            InitializeComponent();            
        }
        
       
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateAbonentDB();
            updateContactDB();
            updateProviderDB();
            updateHasContactDB();
            //
            //abonDVG.Columns["name"].HeaderText = "Имя";
            //contDVG.Columns["id"].Visible = false;
            //provDVG.Columns["id"].Visible = false;
        }

       

        private void findAbonentButton_Click(object sender, EventArgs e)
        {
            List<Control> controls = new List<Control>();
            
            var id = AddIdTextBox();
            controls.Add(id);
           
            Request = "SELECT * FROM dbo.Kochenyuk_abonent WHERE id={0}";

            var run = AddRunButton(controls);
            
            controls.Add(run);

            AddHideButton(controls);          
        }


        
        
        private void addAbonentButton_Click(object sender, EventArgs e)
        {

            List<Control> controls = new List<Control>();
           
            var surName = AddSurNameTextBox();
            controls.Add(surName);

            var name = AddNameTextBox();
            controls.Add(name);

            var patronymic = AddPatronymicTextBox();
            controls.Add(patronymic);

            var birthDate = AddBirthTextBox();
            controls.Add(birthDate);

            var comment = AddCommentTextBox();
            controls.Add(comment);

            var adress = AddAdressTextBox();
            controls.Add(adress);

            string request = "";

            var run = AddRunButton(controls);
            controls.Add(run);

            AddHideButton(controls);

            
        }

        private void changeAbonentButton_Click(object sender, EventArgs e)
        {
            List<Control> controls = new List<Control>();

            var id = AddIdTextBox();
            controls.Add(id);

            var surName = AddSurNameTextBox();
            controls.Add(surName);

            var name = AddNameTextBox();
            controls.Add(name);

            var patronymic = AddPatronymicTextBox();
            controls.Add(patronymic);

            var birthDate = AddBirthTextBox();
            controls.Add(birthDate);

            var comment = AddCommentTextBox();
            controls.Add(comment);

            var adress = AddAdressTextBox();
            controls.Add(adress);

            string request = "";

            var run = AddRunButton(controls);
            controls.Add(run);

            AddHideButton(controls);
        }

        private void deleteAbonentButton_Click(object sender, EventArgs e)
        {
            List<Control> controls = new List<Control>();

            var id = AddIdTextBox();
            controls.Add(id);

            var surName = AddSurNameTextBox();
            controls.Add(surName);

            var name = AddNameTextBox();
            controls.Add(name);

            var patronymic = AddPatronymicTextBox();
            controls.Add(patronymic);

            var birthDate = AddBirthTextBox();
            controls.Add(birthDate);

            var comment = AddCommentTextBox();
            controls.Add(comment);

            var adress = AddAdressTextBox();
            controls.Add(adress);

            string request = "";

            var run = AddRunButton(controls);
            controls.Add(run);

            AddHideButton(controls);
        }
    }
}
