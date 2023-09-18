using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace armApp
{
    public partial class org_agree : Form
    {
        int id { get; set; }
        public org_agree(int id_con)
        {
            InitializeComponent();

            id = id_con;
            SQLiteConnection con = new SQLiteConnection("data source = arm.db");
            con.Open();

            string sql = "SELECT * FROM Agreement WHERE id_study =" + id;
            SQLiteCommand cmd = new SQLiteCommand(sql, con);

            using (SQLiteDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    textBox3.Text = reader.GetValue("id_comp").ToString();
                    textBox1.Text = reader.GetValue("study").ToString();
                    textBox2.Text = reader.GetValue("agree").ToString();
                    textBox4.Text = reader.GetValue("validity").ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection("data source = arm.db");
            con.Open();

            string sql = "UPDATE Agreement " + "SET id_comp = '" + int.Parse(textBox3.Text) + "', study = '" + textBox1.Text + "', agree = '" + textBox2.Text + "', validity = '" + textBox4.Text + "' WHERE id_study=" + id;
            SQLiteCommand cmd = new SQLiteCommand(sql, con);

            cmd.ExecuteNonQuery();

            this.DialogResult = DialogResult.OK;

            con.Close();
            this.Close();
        }
    }
}
