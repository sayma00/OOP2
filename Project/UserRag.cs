using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Bank_Loan_System
{
    public partial class UserRag : Form
    {
        public UserRag()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("server=localhost; uid=root; password=Jahid@12172003;database=bankingsyatem;");

        private void button1_Click(object sender, EventArgs e)
        {
            if (textfrist.Text == "" || textlast.Text == "" || textemail.Text == "" || textuserId.Text == "" || textpassword.Text == "" || textCpassword.Text == "")
            {
                MessageBox.Show("\t \t Missing Information \t \t");
            }
            else
            {
                string fristname, lastname, email, userid, password, Cpassword;

                fristname = textfrist.Text;
                lastname = textlast.Text;
                email = textemail.Text;
                userid = textuserId.Text;
                password = textpassword.Text;
                Cpassword = textCpassword.Text;


                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                MySqlTransaction transaction;
                transaction = con.BeginTransaction();
                cmd.Connection = con;
                cmd.Transaction = transaction;
                try
                {
                    cmd.CommandText = "insert into userlogin(Frist_Name,Last_Name,Email,User_Id, Password ,C_Password) values( '" + fristname + "', '" + lastname + "', '" + email + "', '" + userid + "', '" + password + "', '" + Cpassword + "' )";
                    cmd.ExecuteNonQuery();

                    transaction.Commit();
                    MessageBox.Show("            Rccord Added            ");

                    UserLogin userLogin = new UserLogin();
                    this.Hide();
                    userLogin.Show();
                    
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserLogin userLogin = new UserLogin();
            this.Hide();
            userLogin.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textpassword.UseSystemPasswordChar = false;
            }
            else
            {
                textpassword.UseSystemPasswordChar = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                textCpassword.UseSystemPasswordChar = false;
            }
            else
            {
                textCpassword.UseSystemPasswordChar = true;
            }
        }

        private void UserRag_Load(object sender, EventArgs e)
        {

        }
    }
}
