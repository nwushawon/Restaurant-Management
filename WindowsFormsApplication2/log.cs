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

namespace WindowsFormsApplication2
{
    public partial class log : Form
    {
        public string user { get; set; }
        public string pass { get; set; }
        SqlConnection sql = new SqlConnection(@"Data Source=ANINDYA\SQLEXPRESS;Initial Catalog=kacci;Integrated Security=True");
        public log()
        {
            InitializeComponent();
            user = "";
            pass = "";
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void submit1_Click(object sender, EventArgs e)
        {
            user = textBox9.Text;
            pass = textBox11.Text;
            this.Hide();
        }

        private void label23_Click(object sender, EventArgs e)
        {
            
            ch_pass ps = new ch_pass();
            ps.Show();
        }
        }
    }

