using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PAS_CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Yakin ingin keluar?", "Pesan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=YASKRAZ\\SQLEXPRESS;Initial Catalog=crudyasapas;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            string query = "SELECT COUNT(*) FROM login WHERE username=@username AND password=@password";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", tb_username.Text);
            cmd.Parameters.AddWithValue("@password", tb_password.Text);
            int count = (int)cmd.ExecuteScalar();
            con.Close();
            if (count > 0)
            {
                MessageBox.Show("Login Success", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_username.Text = "";
                tb_password.Text = "";
                Dashboard home = new Dashboard();
                home.Show();
                this.Hide();
            }
            else if (string.IsNullOrEmpty(tb_username.Text) || string.IsNullOrEmpty(tb_password.Text))
            {
                DialogResult dialogResult = MessageBox.Show("Tolong Isi Semua Text Box yang Ada", "Pesan", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tb_username.Text = "";
                tb_password.Text = "";
            }
            else 
            {
                MessageBox.Show("Error Login");

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            tb_password.PasswordChar = cb_showpass.Checked ? '\0' : '*';
        }
    }
}