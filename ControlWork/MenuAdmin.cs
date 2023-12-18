using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KR.DataModel;

namespace KR
{
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Authorization form_Authorization = new Form_Authorization();
            form_Authorization.Show();
            this.Close();

        }


        private void buttonShowTenants_Click(object sender, EventArgs e)
        {
            TenantsForm tenantsForm = new TenantsForm();
            tenantsForm.Show();
            this.Hide();
        }
    }
}
