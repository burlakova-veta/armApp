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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace armApp
{
    public partial class personal_add : Form
    {
        public personal_add()
        {
            InitializeComponent();
        }

        private void personal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (open_dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var image = new Bitmap(open_dialog.FileName);
                    this.pictureBox1.Size = image.Size;
                    pictureBox1.Image = image;
                    pictureBox1.Invalidate();
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection("data source = arm.db");
            con.Open();

           int  mil = checkBox1.Checked ? 1 : 0;
            string sql = "INSERT INTO Staff (surname, names, patronymic, passport, nation, sex, addr, birthdate, phone, e_mail, id_post, department, branch, stat, dates, experience, formats, doc_stud, number_doc, qualif, univer, special, years, work_doc, snils, number_contract, itn, miitary, lang, lvl) " +
                "VALUES ('" + textBox12.Text + "', '" + textBox7.Text + "', '" + textBox11.Text + "', '" + textBox8.Text + "', '" + comboBox8.SelectedValue.ToString() + "', '" + comboBox6.SelectedValue.ToString() + "', '" + textBox9.Text + "', '" + dateTimePicker1.Value.ToString("dd.MM.yyyy") + "', '" + textBox10.Text + "', '" + textBox6.Text + "'," +
                "'" + textBox14.Text + "', '" + textBox16.Text + "', '" + textBox15.Text + "', '" + comboBox3.SelectedValue.ToString() + "', '" + dateTimePicker2.Value.ToString("dd.MM.yyyy") + "', '" + Convert.ToInt32(numericUpDown1.Text) + "', '" + comboBox4.SelectedValue.ToString() + "'," +
                "'" + comboBox2.SelectedValue.ToString() + "', '" + textBox3.Text + "', '" + comboBox1.SelectedValue.ToString() + "', '" + textBox4.Text + "', '" + textBox1.Text + "', '" + textBox2.Text + "'," +
                "'" + textBox19.Text + "', '" + textBox20.Text + "', '" + textBox22.Text + "', '" + textBox21.Text + "', '" + mil + "', '" + comboBox5.SelectedValue.ToString() + "', '" + comboBox7.SelectedValue.ToString() + "')";
            SQLiteCommand cmd = new SQLiteCommand(sql, con);
            cmd.ExecuteNonQuery();

            this.DialogResult = DialogResult.OK;

            con.Close();
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
    }
}
