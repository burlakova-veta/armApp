using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace armApp
{
    public partial class org_agree_add : Form
    {
        public org_agree_add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection("data source = arm.db");
            con.Open();
            string sql = "INSERT INTO Agreement (id_comp, study, agree, validity) values ('" + int.Parse(textBox4.Text) + "', '" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "')";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            cmd.ExecuteNonQuery();

            this.DialogResult = DialogResult.OK;

            con.Close();
            this.Close();
        }
    }
}
