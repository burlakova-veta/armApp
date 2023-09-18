using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SQLite;
using System.Security.Cryptography.X509Certificates;
using System.Data;

namespace armApp
{
    public partial class ARM : Form
    {
        public ARM()
        {
            InitializeComponent();
        }

        private void ARM_Load(object sender, EventArgs e)
        {
            btn_up_staff_Click(sender, e);
            btn_up_stud_Click(sender, e);
            btn_up_comp_Click(sender, e);
            btn_up_study_Click(sender, e);
        }

        private void btn_add_staff_Click(object sender, EventArgs e)
        {
            personal_add windows = new personal_add();
            DialogResult res = windows.ShowDialog();
            if (res == DialogResult.OK)
            {
                btn_up_staff_Click(sender, e);
            }
        }

        private void btn_edit_staff_Click(object sender, EventArgs e)
        {
            int id = int.Parse(show_staff.CurrentRow.Cells[0].Value.ToString());
            personal windows = new personal();
            DialogResult res = windows.ShowDialog();
            if (res == DialogResult.OK)
            {
                btn_up_staff_Click(sender, e);
            }
        }

        private void btn_up_staff_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(@"data source=arm.db");
            con.Open();

            string query = "SELECT id_staff as ID, surname as Фамилия, names as Имя, patronymic as Отчество, post as Должность, department as Отдел, branch as Филиал, stat as Статус, formats as [Формат работы], e_mail as Почта, phone as Телефон FROM Staff \r\n\r\n INNER JOIN Post ON Post.id_post = Staff.id_post;";

            SQLiteCommand cmd = new SQLiteCommand(query, con);
            DataTable dt = new DataTable();

            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            show_staff.DataSource = dt;
            con.Close();
        }

        private void btn_del_staff_Click(object sender, EventArgs e)
        {
            int id = int.Parse(show_staff.CurrentRow.Cells[0].Value.ToString());
            SQLiteConnection con = new SQLiteConnection("data source = arm.db");
            con.Open();

            var res = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel);
            if (res == DialogResult.OK)
            {
                string sql = "DELETE FROM Staff WHERE id_staff = " + id;
                SQLiteCommand cmd = new SQLiteCommand(sql, con);
                cmd.ExecuteNonQuery();
                btn_up_staff_Click(sender, e);
            }
            con.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_stud_Click(object sender, EventArgs e)
        {
            study_add windows = new study_add();
            DialogResult res = windows.ShowDialog();
            if (res == DialogResult.OK)
            {
                btn_up_stud_Click(sender, e);
            }
        }

        private void btn_edit_stud_Click(object sender, EventArgs e)
        {
            int id = int.Parse(show_stud.CurrentRow.Cells[0].Value.ToString());
            study windows = new study();
            DialogResult res = windows.ShowDialog();
            if (res == DialogResult.OK)
            {
                btn_up_stud_Click(sender, e);
            }
        }

        private void btn_del_stud_Click(object sender, EventArgs e)
        {
            int id = int.Parse(show_stud.CurrentRow.Cells[0].Value.ToString());
            SQLiteConnection con = new SQLiteConnection("data source = arm.db");
            con.Open();

            var res = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel);
            if (res == DialogResult.OK)
            {
                string sql = "DELETE FROM Study WHERE id = " + id;
                SQLiteCommand cmd = new SQLiteCommand(sql, con);
                cmd.ExecuteNonQuery();
                btn_up_stud_Click(sender, e);
            }
            con.Close();
        }

        private void btn_up_stud_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(@"data source=arm.db");
            con.Open();

            string query = "SELECT id, surname||' '||names||' '||patronymic as ФИО, Agreement.study as [Программа обучения], Study.stat as Статус, number_cert as [Номер сертификата], Study.dates as Дата FROM Study\r\n\r\nINNER JOIN Staff ON Staff.id_staff = Study.id_staff\r\n\r\nINNER JOIN Agreement ON Agreement.id_study = Study.id_study;";

            SQLiteCommand cmd = new SQLiteCommand(query, con);
            DataTable dt = new DataTable();

            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            show_stud.DataSource = dt;
            con.Close();
        }

        private void btn_add_comp_Click(object sender, EventArgs e)
        {
            organization_add windows = new organization_add();
            DialogResult res = windows.ShowDialog();
            if (res == DialogResult.OK)
            {
                btn_up_comp_Click(sender, e);
            }
        }

        private void btn_edit_comp_Click(object sender, EventArgs e)
        {
            int id = int.Parse(show_comp.CurrentRow.Cells[0].Value.ToString());
            organizations windows = new organizations();
            DialogResult res = windows.ShowDialog();
            if (res == DialogResult.OK)
            {
                btn_up_comp_Click(sender, e);
            }
        }

        private void btn_del_comp_Click(object sender, EventArgs e)
        {
            int id = int.Parse(show_comp.CurrentRow.Cells[0].Value.ToString());
            SQLiteConnection con = new SQLiteConnection("data source = arm.db");
            con.Open();

            var res = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel);
            if (res == DialogResult.OK)
            {
                string sql = "DELETE FROM Company WHERE id_comp = " + id;
                SQLiteCommand cmd = new SQLiteCommand(sql, con);
                cmd.ExecuteNonQuery();
                btn_up_comp_Click(sender, e);
            }
            con.Close();
        }

        private void btn_add_study_Click(object sender, EventArgs e)
        {
            org_agree_add windows = new org_agree_add();
            DialogResult res = windows.ShowDialog();
            if (res == DialogResult.OK)
            {
                btn_up_study_Click(sender, e);
            }
        }

        private void btn_edit_study_Click(object sender, EventArgs e)
        {
            int id = int.Parse(show_study.CurrentRow.Cells[0].Value.ToString());
            org_agree windows = new org_agree(id);
            DialogResult res = windows.ShowDialog();
            if (res == DialogResult.OK)
            {
                btn_up_study_Click(sender, e);
            }
        }

        private void btn_del_study_Click(object sender, EventArgs e)
        {
            int id = int.Parse(show_study.CurrentRow.Cells[0].Value.ToString());
            SQLiteConnection con = new SQLiteConnection("data source = arm.db");
            con.Open();

            var res = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel);
            if (res == DialogResult.OK)
            {
                string sql = "DELETE FROM Agreement WHERE id_study = " + id;
                SQLiteCommand cmd = new SQLiteCommand(sql, con);
                cmd.ExecuteNonQuery();
                btn_up_comp_Click(sender, e);
            }
            con.Close();
        }

        private void btn_up_study_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(@"data source=arm.db");
            con.Open();

            string query = "SELECT id_study as ID, ownship||' '||name_c as Организация, study as [Программа обучения], agree as [Номер договора], validity as [Действителен до] FROM Agreement A\r\n\r\nINNER JOIN Company C ON C.id_comp = A.id_comp;";

            SQLiteCommand cmd = new SQLiteCommand(query, con);
            DataTable dt = new DataTable();

            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            show_study.DataSource = dt;
            con.Close();
        }

        private void password_Click(object sender, EventArgs e)
        {
            var myForm = new edit_password();
            myForm.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {

        }

        private void btn_up_comp_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(@"data source=arm.db");
            con.Open();

            string query = "SELECT id_comp as ID, ownship as [Форма собственности], name_c as Наименование, itn_c as [ИНН], addr as Адрес, e_mail as Почта, phone as Телефон FROM Company;";

            SQLiteCommand cmd = new SQLiteCommand(query, con);
            DataTable dt = new DataTable();

            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(dt);

            show_comp.DataSource = dt;
            con.Close();
        }
    }
}