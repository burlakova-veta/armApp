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

namespace armApp
{
    public partial class study_add : Form
    {
        public study_add()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection("data source=arm.db");
            con.Open();

            string sql = "INSERT INTO Study (id_staff, id_study, stat, number_cert, dates) VALUES ('" + textBox1.Text + "', '" + comboBox1.SelectedValue.ToString() + "', '" + comboBox2.SelectedValue.ToString() + "', '" + textBox2.Text + "', '" + dateTimePicker1.Value.ToString("dd.MM.yyyy") +  "' )";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            cmd.ExecuteNonQuery();

            this.DialogResult = DialogResult.OK;
            con.Close();
            this.Close();
        }
    }
}
