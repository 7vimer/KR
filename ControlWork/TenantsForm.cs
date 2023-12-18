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
    public partial class TenantsForm : Form
    {
		public static ModelEF db = new ModelEF();
		public TenantsForm()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            MenuAdmin menuAdmin = new MenuAdmin();
            menuAdmin.labelUserInfo.Text = $"Добро пожаловать\n{Form_Authorization.User.First_Name} {Form_Authorization.User.Second_Name} {Form_Authorization.User.Middle_Name}";
            menuAdmin.Show();
            this.Close();
        }

		private void TenantsForm_Load(object sender, EventArgs e)
		{
			dataGridViewTenants.DataSource = db.Tenants.ToList();
			if (db.Tenants.ToList().Count == 0) return;
		}
	}
}
