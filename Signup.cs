using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace test2
{
    public partial class Signup : Form
    {

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Arham Shakeel\Documents\loginData.mdf;Integrated Security=True;Connect Timeout=30");        

        public Signup()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form1 lForm = new Form1();
            lForm.Show();
            this.Hide();
        }

        private void signup_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {

            if(signup_email.Text == "" || signup_username.Text == "" || signup_password.Text  == "")
            {
                MessageBox.Show("Please fill all Blank fields","Error Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
            if(connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    String checkUsername = "SELECT * FROM admin WHERE username = '"+signup_username.Text.Trim()+"'"; //Here, admin is the name of the table in our database
                    
                    using(SqlCommand checkUser = new SqlCommand(checkUsername,connect))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if(table.Rows.Count >= 1)
                        {
                            MessageBox.Show(signup_username.Text + " already exists", "Error Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                        else
                        {
                            string insertData = "INSERT INTO admin (email,username,passowrd,date_created) VALUES(@email,@username,@pass,@date)";

                            DateTime date = DateTime.Today;

                            using(SqlCommand cmd = new SqlCommand(insertData,connect))
                            {
                                cmd.Parameters.AddWithValue("@email",signup_email.Text.Trim());
                                cmd.Parameters.AddWithValue("@username",signup_username.Text.Trim());
                                cmd.Parameters.AddWithValue("@pass",signup_password.Text.Trim());
                                cmd.Parameters.AddWithValue("@date",date);

                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Registered Successfully","Information Message",MessageBoxButtons.OK,MessageBoxIcon.Information);

                                //To Switch Forms:
                                Form1 lForm = new Form1();
                                lForm.Show();
                                this.Hide();
                            }
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error Connecting Database: " + ex,"Error Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }

            }
        }

        private void signup_showPass_CheckedChanged(object sender, EventArgs e)
        {
            if(signup_showPass.Checked)
            {
                signup_password.PasswordChar =  '\0';
            }
            else
            {
                signup_password.PasswordChar = '*';
            }
        }
    }
}
