using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Loan_System
{
    public partial class ServicProvider : Form
    {
        public ServicProvider()
        {
            InitializeComponent();
        }
        int count = 0;

        MySqlConnection con = new MySqlConnection("server=localhost; uid=root; password=Jahid@12172003;database=bankingsyatem;");

        private void button2_Click(object sender, EventArgs e)
        {
            string username, userpassword;
            username = UserName.Text;
            userpassword = UserPassword.Text;

            count += count;
            if (count >= 3)
            {
                MessageBox.Show("\t \t System Is Block \t \t");
                Application.Exit();
            }
            if (username == "")
            {
                MessageBox.Show("\t\t Blank User Name \t\t");
            }
            else if (userpassword == "")
            {
                MessageBox.Show("\t\t Blank Password \t\t");
            }
            else
            {
                try
                {
                    string qurry = "Select * From servicprovider Where User_Id = '" + UserName.Text + "' And Password = '" + UserPassword.Text + "'";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(qurry, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        username = UserName.Text;
                        userpassword = UserPassword.Text;

                        Form2 form11 = new Form2();
                        this.Hide();
                        form11.Show();

                    }
                    else
                    {
                        UserName.Clear();
                        UserPassword.Clear();
                        UserName.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                UserPassword.UseSystemPasswordChar = false;
            }
            else
            {
                UserPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
