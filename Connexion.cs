using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fleurs
{
	public partial class Connexion : Form
	{
		public Connexion()
		{
			InitializeComponent();
		}

		private void connexion_button_Click(object sender, EventArgs e)
		{
			string username, password;

			username = email_textbox.Text; 
			password = password_textbox.Text;

			MessageBox.Show(username + password);
		}
	}
}
