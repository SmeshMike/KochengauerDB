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
    public partial class DirectoryEdit : Form
    {
        public DirectoryEdit()
        {
            InitializeComponent();
        }

        public Dictionary<int, string> FullNameData
        {
            set
            {
                fullNameСomboBox.DataSource = value.ToArray();
                fullNameСomboBox.DisplayMember = "value";
            }
        }


        public int FullNameId
        {
            get
            {
                return ((KeyValuePair<int, string>)fullNameСomboBox.SelectedItem).Key;
            }
        }

        public Dictionary<int, string> PhoneData
        {
            set
            {
                numberComboBox.DataSource = value.ToArray();
                numberComboBox.DisplayMember = "value";
            }
        }


        public int PhoneId
        {
            get
            {
                return ((KeyValuePair<int, string>)numberComboBox.SelectedItem).Key;
            }
        }

    }
}
