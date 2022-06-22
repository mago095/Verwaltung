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

namespace Verwaltung
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Btn_register_Click(object sender, EventArgs e)
        {   
            
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)//MSSQLLocalDB;AttachDbFilename=C://Users//mago//source//repos//Verwaltung//Verwaltung//LoginDatabase.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("insert into Accounts values (@id, @user, @password", con);
            cmd.Parameters.AddWithValue("@user", Txt_registerUser.Text);
            cmd.Parameters.AddWithValue("@password", Txt_registerPassword);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Succesful");


        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {

        }

    }
}
