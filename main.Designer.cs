namespace armApp
{
    partial class ARM
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            all_staff = new TabControl();
            page_work = new TabPage();
            flowLayoutPanel10 = new FlowLayoutPanel();
            label_search_staff = new Label();
            search_staff = new TextBox();
            btn_ok = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btn_add_staff = new Button();
            btn_edit_staff = new Button();
            btn_up_staff = new Button();
            btn_del_staff = new Button();
            show_staff = new DataGridView();
            page_study = new TabPage();
            flowLayoutPanel9 = new FlowLayoutPanel();
            ch_stud_staff = new CheckBox();
            tb_stud_staff = new TextBox();
            ch_stud_prog = new CheckBox();
            textBox6 = new TextBox();
            flowLayoutPanel7 = new FlowLayoutPanel();
            btn_add_stud = new Button();
            btn_edit_stud = new Button();
            btn_up_stud = new Button();
            btn_del_stud = new Button();
            flowLayoutPanel8 = new FlowLayoutPanel();
            rb_app = new RadioButton();
            rb_during = new RadioButton();
            rb_master = new RadioButton();
            rb_all_stud = new RadioButton();
            show_stud = new DataGridView();
            page_org = new TabPage();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btn_add_comp = new Button();
            btn_edit_comp = new Button();
            btn_up_comp = new Button();
            btn_del_comp = new Button();
            show_comp = new DataGridView();
            page_company = new TabPage();
            flowLayoutPanel4 = new FlowLayoutPanel();
            btn_add_study = new Button();
            btn_edit_study = new Button();
            btn_up_study = new Button();
            btn_del_study = new Button();
            show_study = new DataGridView();
            page_plenum = new TabPage();
            panel1 = new Panel();
            listView2 = new ListView();
            listView1 = new ListView();
            lv_vacant = new ListView();
            lv_occup = new ListView();
            lv_workplace = new ListView();
            workplace = new Label();
            occup = new Label();
            vacant = new Label();
            label5 = new Label();
            flowLayoutPanel3 = new FlowLayoutPanel();
            all_work = new RadioButton();
            manager = new RadioButton();
            social = new RadioButton();
            programmer = new RadioButton();
            radioButton1 = new RadioButton();
            label4 = new Label();
            page_settings = new TabPage();
            groupBox1 = new GroupBox();
            password = new Button();
            exit = new Button();
            all_staff.SuspendLayout();
            page_work.SuspendLayout();
            flowLayoutPanel10.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)show_staff).BeginInit();
            page_study.SuspendLayout();
            flowLayoutPanel9.SuspendLayout();
            flowLayoutPanel7.SuspendLayout();
            flowLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)show_stud).BeginInit();
            page_org.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)show_comp).BeginInit();
            page_company.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)show_study).BeginInit();
            page_plenum.SuspendLayout();
            panel1.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            page_settings.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // all_staff
            // 
            all_staff.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            all_staff.Controls.Add(page_work);
            all_staff.Controls.Add(page_study);
            all_staff.Controls.Add(page_org);
            all_staff.Controls.Add(page_company);
            all_staff.Controls.Add(page_plenum);
            all_staff.Controls.Add(page_settings);
            all_staff.Location = new Point(12, 12);
            all_staff.Multiline = true;
            all_staff.Name = "all_staff";
            all_staff.SelectedIndex = 0;
            all_staff.Size = new Size(611, 379);
            all_staff.TabIndex = 0;
            // 
            // page_work
            // 
            page_work.Controls.Add(flowLayoutPanel10);
            page_work.Controls.Add(flowLayoutPanel1);
            page_work.Controls.Add(show_staff);
            page_work.Location = new Point(4, 54);
            page_work.Name = "page_work";
            page_work.Padding = new Padding(3);
            page_work.Size = new Size(603, 321);
            page_work.TabIndex = 0;
            page_work.Text = "Сотрудники";
            page_work.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel10
            // 
            flowLayoutPanel10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel10.Controls.Add(label_search_staff);
            flowLayoutPanel10.Controls.Add(search_staff);
            flowLayoutPanel10.Controls.Add(btn_ok);
            flowLayoutPanel10.Location = new Point(24, 61);
            flowLayoutPanel10.Name = "flowLayoutPanel10";
            flowLayoutPanel10.Size = new Size(558, 37);
            flowLayoutPanel10.TabIndex = 15;
            // 
            // label_search_staff
            // 
            label_search_staff.AutoSize = true;
            label_search_staff.Location = new Point(23, 8);
            label_search_staff.Margin = new Padding(23, 8, 3, 0);
            label_search_staff.Name = "label_search_staff";
            label_search_staff.Size = new Size(111, 20);
            label_search_staff.TabIndex = 12;
            label_search_staff.Text = "Поиск по ФИО";
            // 
            // search_staff
            // 
            search_staff.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            search_staff.Location = new Point(140, 5);
            search_staff.Margin = new Padding(3, 5, 3, 3);
            search_staff.Name = "search_staff";
            search_staff.Size = new Size(279, 27);
            search_staff.TabIndex = 13;
            // 
            // btn_ok
            // 
            btn_ok.Location = new Point(425, 3);
            btn_ok.Name = "btn_ok";
            btn_ok.Size = new Size(43, 29);
            btn_ok.TabIndex = 14;
            btn_ok.Text = "OK";
            btn_ok.UseVisualStyleBackColor = true;
            btn_ok.Click += btn_ok_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.Controls.Add(btn_add_staff);
            flowLayoutPanel1.Controls.Add(btn_edit_staff);
            flowLayoutPanel1.Controls.Add(btn_up_staff);
            flowLayoutPanel1.Controls.Add(btn_del_staff);
            flowLayoutPanel1.Location = new Point(24, 18);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(558, 37);
            flowLayoutPanel1.TabIndex = 8;
            flowLayoutPanel1.UseWaitCursor = true;
            // 
            // btn_add_staff
            // 
            btn_add_staff.Location = new Point(20, 3);
            btn_add_staff.Margin = new Padding(20, 3, 3, 3);
            btn_add_staff.Name = "btn_add_staff";
            btn_add_staff.Size = new Size(94, 29);
            btn_add_staff.TabIndex = 0;
            btn_add_staff.Text = "Добавить";
            btn_add_staff.UseVisualStyleBackColor = true;
            btn_add_staff.UseWaitCursor = true;
            btn_add_staff.Click += btn_add_staff_Click;
            // 
            // btn_edit_staff
            // 
            btn_edit_staff.Location = new Point(137, 3);
            btn_edit_staff.Margin = new Padding(20, 3, 3, 3);
            btn_edit_staff.Name = "btn_edit_staff";
            btn_edit_staff.Size = new Size(167, 29);
            btn_edit_staff.TabIndex = 1;
            btn_edit_staff.Text = "Открыть / изменить";
            btn_edit_staff.UseVisualStyleBackColor = true;
            btn_edit_staff.UseWaitCursor = true;
            btn_edit_staff.Click += btn_edit_staff_Click;
            // 
            // btn_up_staff
            // 
            btn_up_staff.Location = new Point(327, 3);
            btn_up_staff.Margin = new Padding(20, 3, 3, 3);
            btn_up_staff.Name = "btn_up_staff";
            btn_up_staff.Size = new Size(94, 29);
            btn_up_staff.TabIndex = 3;
            btn_up_staff.Text = "Обновить";
            btn_up_staff.UseVisualStyleBackColor = true;
            btn_up_staff.UseWaitCursor = true;
            btn_up_staff.Click += btn_up_staff_Click;
            // 
            // btn_del_staff
            // 
            btn_del_staff.Location = new Point(444, 3);
            btn_del_staff.Margin = new Padding(20, 3, 3, 3);
            btn_del_staff.Name = "btn_del_staff";
            btn_del_staff.Size = new Size(94, 29);
            btn_del_staff.TabIndex = 4;
            btn_del_staff.Text = "Удалить";
            btn_del_staff.UseVisualStyleBackColor = true;
            btn_del_staff.UseWaitCursor = true;
            btn_del_staff.Click += btn_del_staff_Click;
            // 
            // show_staff
            // 
            show_staff.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            show_staff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            show_staff.BackgroundColor = SystemColors.Control;
            show_staff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            show_staff.Location = new Point(14, 115);
            show_staff.Name = "show_staff";
            show_staff.RowHeadersWidth = 51;
            show_staff.RowTemplate.Height = 29;
            show_staff.Size = new Size(583, 190);
            show_staff.TabIndex = 9;
            // 
            // page_study
            // 
            page_study.Controls.Add(flowLayoutPanel9);
            page_study.Controls.Add(flowLayoutPanel7);
            page_study.Controls.Add(flowLayoutPanel8);
            page_study.Controls.Add(show_stud);
            page_study.Location = new Point(4, 54);
            page_study.Name = "page_study";
            page_study.Size = new Size(603, 321);
            page_study.TabIndex = 3;
            page_study.Text = "Обучение";
            page_study.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel9
            // 
            flowLayoutPanel9.Controls.Add(ch_stud_staff);
            flowLayoutPanel9.Controls.Add(tb_stud_staff);
            flowLayoutPanel9.Controls.Add(ch_stud_prog);
            flowLayoutPanel9.Controls.Add(textBox6);
            flowLayoutPanel9.Location = new Point(12, 12);
            flowLayoutPanel9.Name = "flowLayoutPanel9";
            flowLayoutPanel9.Padding = new Padding(10, 0, 10, 0);
            flowLayoutPanel9.Size = new Size(364, 96);
            flowLayoutPanel9.TabIndex = 16;
            // 
            // ch_stud_staff
            // 
            ch_stud_staff.AutoSize = true;
            ch_stud_staff.Location = new Point(13, 18);
            ch_stud_staff.Margin = new Padding(3, 18, 3, 3);
            ch_stud_staff.Name = "ch_stud_staff";
            ch_stud_staff.Size = new Size(133, 24);
            ch_stud_staff.TabIndex = 15;
            ch_stud_staff.Text = "Поиск по ФИО";
            ch_stud_staff.UseVisualStyleBackColor = true;
            // 
            // tb_stud_staff
            // 
            tb_stud_staff.Location = new Point(152, 18);
            tb_stud_staff.Margin = new Padding(3, 18, 3, 3);
            tb_stud_staff.Name = "tb_stud_staff";
            tb_stud_staff.Size = new Size(191, 27);
            tb_stud_staff.TabIndex = 16;
            // 
            // ch_stud_prog
            // 
            ch_stud_prog.AutoSize = true;
            ch_stud_prog.Location = new Point(13, 51);
            ch_stud_prog.Name = "ch_stud_prog";
            ch_stud_prog.Size = new Size(180, 24);
            ch_stud_prog.TabIndex = 19;
            ch_stud_prog.Text = "Поиск по программе";
            ch_stud_prog.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(199, 51);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(144, 27);
            textBox6.TabIndex = 18;
            // 
            // flowLayoutPanel7
            // 
            flowLayoutPanel7.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel7.Controls.Add(btn_add_stud);
            flowLayoutPanel7.Controls.Add(btn_edit_stud);
            flowLayoutPanel7.Controls.Add(btn_up_stud);
            flowLayoutPanel7.Controls.Add(btn_del_stud);
            flowLayoutPanel7.Location = new Point(65, 272);
            flowLayoutPanel7.Name = "flowLayoutPanel7";
            flowLayoutPanel7.Size = new Size(488, 37);
            flowLayoutPanel7.TabIndex = 13;
            flowLayoutPanel7.UseWaitCursor = true;
            // 
            // btn_add_stud
            // 
            btn_add_stud.Location = new Point(20, 3);
            btn_add_stud.Margin = new Padding(20, 3, 3, 3);
            btn_add_stud.Name = "btn_add_stud";
            btn_add_stud.Size = new Size(94, 29);
            btn_add_stud.TabIndex = 0;
            btn_add_stud.Text = "Добавить";
            btn_add_stud.UseVisualStyleBackColor = true;
            btn_add_stud.UseWaitCursor = true;
            btn_add_stud.Click += btn_add_stud_Click;
            // 
            // btn_edit_stud
            // 
            btn_edit_stud.Location = new Point(137, 3);
            btn_edit_stud.Margin = new Padding(20, 3, 3, 3);
            btn_edit_stud.Name = "btn_edit_stud";
            btn_edit_stud.Size = new Size(94, 29);
            btn_edit_stud.TabIndex = 1;
            btn_edit_stud.Text = "Изменить";
            btn_edit_stud.UseVisualStyleBackColor = true;
            btn_edit_stud.UseWaitCursor = true;
            btn_edit_stud.Click += btn_edit_stud_Click;
            // 
            // btn_up_stud
            // 
            btn_up_stud.Location = new Point(254, 3);
            btn_up_stud.Margin = new Padding(20, 3, 3, 3);
            btn_up_stud.Name = "btn_up_stud";
            btn_up_stud.Size = new Size(94, 29);
            btn_up_stud.TabIndex = 3;
            btn_up_stud.Text = "Обновить";
            btn_up_stud.UseVisualStyleBackColor = true;
            btn_up_stud.UseWaitCursor = true;
            btn_up_stud.Click += btn_up_stud_Click;
            // 
            // btn_del_stud
            // 
            btn_del_stud.Location = new Point(371, 3);
            btn_del_stud.Margin = new Padding(20, 3, 3, 3);
            btn_del_stud.Name = "btn_del_stud";
            btn_del_stud.Size = new Size(94, 29);
            btn_del_stud.TabIndex = 2;
            btn_del_stud.Text = "Удалить";
            btn_del_stud.UseVisualStyleBackColor = true;
            btn_del_stud.UseWaitCursor = true;
            btn_del_stud.Click += btn_del_stud_Click;
            // 
            // flowLayoutPanel8
            // 
            flowLayoutPanel8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            flowLayoutPanel8.Controls.Add(rb_app);
            flowLayoutPanel8.Controls.Add(rb_during);
            flowLayoutPanel8.Controls.Add(rb_master);
            flowLayoutPanel8.Controls.Add(rb_all_stud);
            flowLayoutPanel8.Location = new Point(382, 12);
            flowLayoutPanel8.Name = "flowLayoutPanel8";
            flowLayoutPanel8.Size = new Size(206, 96);
            flowLayoutPanel8.TabIndex = 12;
            // 
            // rb_app
            // 
            rb_app.AutoSize = true;
            rb_app.Location = new Point(10, 3);
            rb_app.Margin = new Padding(10, 3, 3, 3);
            rb_app.Name = "rb_app";
            rb_app.Size = new Size(188, 24);
            rb_app.TabIndex = 1;
            rb_app.Text = "Нуждается в обучении";
            rb_app.UseVisualStyleBackColor = true;
            // 
            // rb_during
            // 
            rb_during.AutoSize = true;
            rb_during.Location = new Point(10, 33);
            rb_during.Margin = new Padding(10, 3, 3, 3);
            rb_during.Name = "rb_during";
            rb_during.Size = new Size(121, 24);
            rb_during.TabIndex = 3;
            rb_during.Text = "На обучении";
            rb_during.UseVisualStyleBackColor = true;
            // 
            // rb_master
            // 
            rb_master.AutoSize = true;
            rb_master.Location = new Point(10, 63);
            rb_master.Margin = new Padding(10, 3, 3, 3);
            rb_master.Name = "rb_master";
            rb_master.Size = new Size(91, 24);
            rb_master.TabIndex = 0;
            rb_master.Text = "Освоено";
            rb_master.UseVisualStyleBackColor = true;
            // 
            // rb_all_stud
            // 
            rb_all_stud.AutoSize = true;
            rb_all_stud.Checked = true;
            rb_all_stud.Location = new Point(114, 63);
            rb_all_stud.Margin = new Padding(10, 3, 3, 3);
            rb_all_stud.Name = "rb_all_stud";
            rb_all_stud.Size = new Size(54, 24);
            rb_all_stud.TabIndex = 2;
            rb_all_stud.TabStop = true;
            rb_all_stud.Text = "Все";
            rb_all_stud.UseVisualStyleBackColor = true;
            // 
            // show_stud
            // 
            show_stud.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            show_stud.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            show_stud.BackgroundColor = SystemColors.Control;
            show_stud.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            show_stud.Location = new Point(12, 114);
            show_stud.Name = "show_stud";
            show_stud.RowHeadersWidth = 51;
            show_stud.RowTemplate.Height = 29;
            show_stud.Size = new Size(576, 144);
            show_stud.TabIndex = 11;
            // 
            // page_org
            // 
            page_org.Controls.Add(flowLayoutPanel2);
            page_org.Controls.Add(show_comp);
            page_org.Location = new Point(4, 54);
            page_org.Name = "page_org";
            page_org.Size = new Size(603, 321);
            page_org.TabIndex = 6;
            page_org.Text = "Организации";
            page_org.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel2.Controls.Add(btn_add_comp);
            flowLayoutPanel2.Controls.Add(btn_edit_comp);
            flowLayoutPanel2.Controls.Add(btn_up_comp);
            flowLayoutPanel2.Controls.Add(btn_del_comp);
            flowLayoutPanel2.Location = new Point(60, 21);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(484, 37);
            flowLayoutPanel2.TabIndex = 5;
            flowLayoutPanel2.UseWaitCursor = true;
            // 
            // btn_add_comp
            // 
            btn_add_comp.Location = new Point(20, 3);
            btn_add_comp.Margin = new Padding(20, 3, 3, 3);
            btn_add_comp.Name = "btn_add_comp";
            btn_add_comp.Size = new Size(94, 29);
            btn_add_comp.TabIndex = 0;
            btn_add_comp.Text = "Добавить";
            btn_add_comp.UseVisualStyleBackColor = true;
            btn_add_comp.UseWaitCursor = true;
            btn_add_comp.Click += btn_add_comp_Click;
            // 
            // btn_edit_comp
            // 
            btn_edit_comp.Location = new Point(137, 3);
            btn_edit_comp.Margin = new Padding(20, 3, 3, 3);
            btn_edit_comp.Name = "btn_edit_comp";
            btn_edit_comp.Size = new Size(94, 29);
            btn_edit_comp.TabIndex = 1;
            btn_edit_comp.Text = "Изменить";
            btn_edit_comp.UseVisualStyleBackColor = true;
            btn_edit_comp.UseWaitCursor = true;
            btn_edit_comp.Click += btn_edit_comp_Click;
            // 
            // btn_up_comp
            // 
            btn_up_comp.Location = new Point(254, 3);
            btn_up_comp.Margin = new Padding(20, 3, 3, 3);
            btn_up_comp.Name = "btn_up_comp";
            btn_up_comp.Size = new Size(94, 29);
            btn_up_comp.TabIndex = 4;
            btn_up_comp.Text = "Обновить";
            btn_up_comp.UseVisualStyleBackColor = true;
            btn_up_comp.UseWaitCursor = true;
            btn_up_comp.Click += btn_up_comp_Click;
            // 
            // btn_del_comp
            // 
            btn_del_comp.Location = new Point(371, 3);
            btn_del_comp.Margin = new Padding(20, 3, 3, 3);
            btn_del_comp.Name = "btn_del_comp";
            btn_del_comp.Size = new Size(94, 29);
            btn_del_comp.TabIndex = 3;
            btn_del_comp.Text = "Удалить";
            btn_del_comp.UseVisualStyleBackColor = true;
            btn_del_comp.UseWaitCursor = true;
            btn_del_comp.Click += btn_del_comp_Click;
            // 
            // show_comp
            // 
            show_comp.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            show_comp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            show_comp.BackgroundColor = SystemColors.Control;
            show_comp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            show_comp.Location = new Point(7, 64);
            show_comp.Name = "show_comp";
            show_comp.RowHeadersWidth = 51;
            show_comp.RowTemplate.Height = 29;
            show_comp.Size = new Size(591, 251);
            show_comp.TabIndex = 6;
            // 
            // page_company
            // 
            page_company.Controls.Add(flowLayoutPanel4);
            page_company.Controls.Add(show_study);
            page_company.Location = new Point(4, 54);
            page_company.Name = "page_company";
            page_company.Padding = new Padding(3);
            page_company.Size = new Size(603, 321);
            page_company.TabIndex = 1;
            page_company.Text = "Программы обучения";
            page_company.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel4.Controls.Add(btn_add_study);
            flowLayoutPanel4.Controls.Add(btn_edit_study);
            flowLayoutPanel4.Controls.Add(btn_up_study);
            flowLayoutPanel4.Controls.Add(btn_del_study);
            flowLayoutPanel4.Location = new Point(60, 21);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(484, 37);
            flowLayoutPanel4.TabIndex = 3;
            flowLayoutPanel4.UseWaitCursor = true;
            // 
            // btn_add_study
            // 
            btn_add_study.Location = new Point(20, 3);
            btn_add_study.Margin = new Padding(20, 3, 3, 3);
            btn_add_study.Name = "btn_add_study";
            btn_add_study.Size = new Size(94, 29);
            btn_add_study.TabIndex = 0;
            btn_add_study.Text = "Добавить";
            btn_add_study.UseVisualStyleBackColor = true;
            btn_add_study.UseWaitCursor = true;
            btn_add_study.Click += btn_add_study_Click;
            // 
            // btn_edit_study
            // 
            btn_edit_study.Location = new Point(137, 3);
            btn_edit_study.Margin = new Padding(20, 3, 3, 3);
            btn_edit_study.Name = "btn_edit_study";
            btn_edit_study.Size = new Size(94, 29);
            btn_edit_study.TabIndex = 1;
            btn_edit_study.Text = "Изменить";
            btn_edit_study.UseVisualStyleBackColor = true;
            btn_edit_study.UseWaitCursor = true;
            btn_edit_study.Click += btn_edit_study_Click;
            // 
            // btn_up_study
            // 
            btn_up_study.Location = new Point(254, 3);
            btn_up_study.Margin = new Padding(20, 3, 3, 3);
            btn_up_study.Name = "btn_up_study";
            btn_up_study.Size = new Size(94, 29);
            btn_up_study.TabIndex = 4;
            btn_up_study.Text = "Обновить";
            btn_up_study.UseVisualStyleBackColor = true;
            btn_up_study.UseWaitCursor = true;
            btn_up_study.Click += btn_up_study_Click;
            // 
            // btn_del_study
            // 
            btn_del_study.Location = new Point(371, 3);
            btn_del_study.Margin = new Padding(20, 3, 3, 3);
            btn_del_study.Name = "btn_del_study";
            btn_del_study.Size = new Size(94, 29);
            btn_del_study.TabIndex = 3;
            btn_del_study.Text = "Удалить";
            btn_del_study.UseVisualStyleBackColor = true;
            btn_del_study.UseWaitCursor = true;
            btn_del_study.Click += btn_del_study_Click;
            // 
            // show_study
            // 
            show_study.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            show_study.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            show_study.BackgroundColor = SystemColors.Control;
            show_study.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            show_study.Location = new Point(7, 64);
            show_study.Name = "show_study";
            show_study.RowHeadersWidth = 51;
            show_study.RowTemplate.Height = 29;
            show_study.Size = new Size(591, 251);
            show_study.TabIndex = 4;
            // 
            // page_plenum
            // 
            page_plenum.Controls.Add(panel1);
            page_plenum.Controls.Add(label5);
            page_plenum.Controls.Add(flowLayoutPanel3);
            page_plenum.Controls.Add(label4);
            page_plenum.Location = new Point(4, 54);
            page_plenum.Name = "page_plenum";
            page_plenum.Size = new Size(603, 321);
            page_plenum.TabIndex = 4;
            page_plenum.Text = "Укомплектованность отдела";
            page_plenum.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(listView2);
            panel1.Controls.Add(listView1);
            panel1.Controls.Add(lv_vacant);
            panel1.Controls.Add(lv_occup);
            panel1.Controls.Add(lv_workplace);
            panel1.Controls.Add(workplace);
            panel1.Controls.Add(occup);
            panel1.Controls.Add(vacant);
            panel1.Location = new Point(48, 180);
            panel1.Name = "panel1";
            panel1.Size = new Size(501, 125);
            panel1.TabIndex = 11;
            // 
            // listView2
            // 
            listView2.BackColor = SystemColors.MenuBar;
            listView2.BorderStyle = BorderStyle.None;
            listView2.Location = new Point(423, 83);
            listView2.Name = "listView2";
            listView2.Size = new Size(63, 30);
            listView2.TabIndex = 16;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // listView1
            // 
            listView1.BackColor = SystemColors.MenuBar;
            listView1.BorderStyle = BorderStyle.None;
            listView1.Location = new Point(423, 44);
            listView1.Name = "listView1";
            listView1.Size = new Size(63, 30);
            listView1.TabIndex = 15;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lv_vacant
            // 
            lv_vacant.Location = new Point(356, 83);
            lv_vacant.Name = "lv_vacant";
            lv_vacant.Size = new Size(63, 30);
            lv_vacant.TabIndex = 14;
            lv_vacant.UseCompatibleStateImageBehavior = false;
            // 
            // lv_occup
            // 
            lv_occup.Location = new Point(356, 44);
            lv_occup.Name = "lv_occup";
            lv_occup.Size = new Size(63, 30);
            lv_occup.TabIndex = 13;
            lv_occup.UseCompatibleStateImageBehavior = false;
            // 
            // lv_workplace
            // 
            lv_workplace.Location = new Point(356, 6);
            lv_workplace.Name = "lv_workplace";
            lv_workplace.Size = new Size(130, 30);
            lv_workplace.TabIndex = 12;
            lv_workplace.UseCompatibleStateImageBehavior = false;
            // 
            // workplace
            // 
            workplace.AutoSize = true;
            workplace.Location = new Point(157, 11);
            workplace.Name = "workplace";
            workplace.Size = new Size(189, 20);
            workplace.TabIndex = 0;
            workplace.Text = "Количество рабочих мест";
            // 
            // occup
            // 
            occup.AutoSize = true;
            occup.Location = new Point(7, 49);
            occup.Name = "occup";
            occup.Size = new Size(339, 20);
            occup.TabIndex = 1;
            occup.Text = "Количество сотрудников на данной должности";
            // 
            // vacant
            // 
            vacant.AutoSize = true;
            vacant.Location = new Point(80, 87);
            vacant.Name = "vacant";
            vacant.Size = new Size(266, 20);
            vacant.TabIndex = 2;
            vacant.Text = "Количество вакантных рабочих мест";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(76, 157);
            label5.Name = "label5";
            label5.Size = new Size(257, 20);
            label5.TabIndex = 10;
            label5.Text = "Информация по рабочим местам";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel3.Controls.Add(all_work);
            flowLayoutPanel3.Controls.Add(manager);
            flowLayoutPanel3.Controls.Add(social);
            flowLayoutPanel3.Controls.Add(programmer);
            flowLayoutPanel3.Controls.Add(radioButton1);
            flowLayoutPanel3.Location = new Point(48, 56);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(501, 65);
            flowLayoutPanel3.TabIndex = 9;
            // 
            // all_work
            // 
            all_work.AutoSize = true;
            all_work.Checked = true;
            all_work.Location = new Point(10, 3);
            all_work.Margin = new Padding(10, 3, 3, 3);
            all_work.Name = "all_work";
            all_work.Size = new Size(54, 24);
            all_work.TabIndex = 0;
            all_work.TabStop = true;
            all_work.Text = "Все";
            all_work.UseVisualStyleBackColor = true;
            // 
            // manager
            // 
            manager.AutoSize = true;
            manager.Location = new Point(77, 3);
            manager.Margin = new Padding(10, 3, 3, 3);
            manager.Name = "manager";
            manager.Size = new Size(104, 24);
            manager.TabIndex = 1;
            manager.Text = "Менеджер";
            manager.UseVisualStyleBackColor = true;
            // 
            // social
            // 
            social.AutoSize = true;
            social.Location = new Point(194, 3);
            social.Margin = new Padding(10, 3, 3, 3);
            social.Name = "social";
            social.Size = new Size(292, 24);
            social.TabIndex = 2;
            social.Text = "Специалист по социальной политике";
            social.UseVisualStyleBackColor = true;
            // 
            // programmer
            // 
            programmer.AutoSize = true;
            programmer.Location = new Point(10, 33);
            programmer.Margin = new Padding(10, 3, 3, 3);
            programmer.Name = "programmer";
            programmer.Size = new Size(126, 24);
            programmer.TabIndex = 3;
            programmer.Text = "Программист";
            programmer.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(142, 33);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(98, 24);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "Бухгалтер";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(76, 23);
            label4.Name = "label4";
            label4.Size = new Size(93, 20);
            label4.TabIndex = 8;
            label4.Text = "Должности";
            // 
            // page_settings
            // 
            page_settings.Controls.Add(groupBox1);
            page_settings.Location = new Point(4, 54);
            page_settings.Name = "page_settings";
            page_settings.Size = new Size(603, 321);
            page_settings.TabIndex = 5;
            page_settings.Text = "Настройки";
            page_settings.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(password);
            groupBox1.Controls.Add(exit);
            groupBox1.Location = new Point(120, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(346, 128);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // password
            // 
            password.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            password.Location = new Point(32, 39);
            password.Name = "password";
            password.Size = new Size(293, 29);
            password.TabIndex = 1;
            password.Text = "Сменить пароль";
            password.UseVisualStyleBackColor = true;
            password.Click += password_Click;
            // 
            // exit
            // 
            exit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            exit.BackColor = Color.LightCoral;
            exit.BackgroundImageLayout = ImageLayout.None;
            exit.FlatStyle = FlatStyle.Popup;
            exit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            exit.Location = new Point(32, 89);
            exit.Name = "exit";
            exit.Size = new Size(293, 29);
            exit.TabIndex = 2;
            exit.Text = "Выход из учетной записи";
            exit.UseVisualStyleBackColor = false;
            exit.Click += exit_Click;
            // 
            // ARM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 403);
            Controls.Add(all_staff);
            MinimumSize = new Size(650, 450);
            Name = "ARM";
            Text = "АРМ специалиста по управлению персоналом";
            Load += ARM_Load;
            all_staff.ResumeLayout(false);
            page_work.ResumeLayout(false);
            flowLayoutPanel10.ResumeLayout(false);
            flowLayoutPanel10.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)show_staff).EndInit();
            page_study.ResumeLayout(false);
            flowLayoutPanel9.ResumeLayout(false);
            flowLayoutPanel9.PerformLayout();
            flowLayoutPanel7.ResumeLayout(false);
            flowLayoutPanel8.ResumeLayout(false);
            flowLayoutPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)show_stud).EndInit();
            page_org.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)show_comp).EndInit();
            page_company.ResumeLayout(false);
            flowLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)show_study).EndInit();
            page_plenum.ResumeLayout(false);
            page_plenum.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            page_settings.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl all_staff;
        private TabPage page_work;
        private TabPage page_company;
        private TabPage page_study;
        private TabPage page_plenum;
        private FlowLayoutPanel flowLayoutPanel3;
        private RadioButton all_work;
        private RadioButton manager;
        private RadioButton social;
        private RadioButton programmer;
        private Label label4;
        private Label vacant;
        private Label occup;
        private Label workplace;
        private Label label5;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel4;
        private Button btn_add_study;
        private Button btn_edit_study;
        private Button btn_del_study;
        private DataGridView show_study;
        private FlowLayoutPanel flowLayoutPanel7;
        private Button btn_add_stud;
        private Button btn_edit_stud;
        private Button btn_del_stud;
        private Button btn_up_stud;
        private FlowLayoutPanel flowLayoutPanel8;
        private RadioButton rb_master;
        private RadioButton rb_app;
        private RadioButton rb_all_stud;
        private DataGridView show_stud;
        private FlowLayoutPanel flowLayoutPanel9;
        private CheckBox ch_stud_staff;
        private TextBox tb_stud_staff;
        private CheckBox ch_stud_prog;
        private TextBox textBox6;
        private RadioButton rb_during;
        private ListView lv_occup;
        private ListView lv_workplace;
        private TabPage page_settings;
        private GroupBox groupBox1;
        private Button password;
        private Button exit;
        private Button btn_up_study;
        private ListView listView2;
        private ListView listView1;
        private ListView lv_vacant;
        private FlowLayoutPanel flowLayoutPanel10;
        private Label label_search_staff;
        private TextBox search_staff;
        private Button btn_ok;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btn_add_staff;
        private Button btn_edit_staff;
        private Button btn_up_staff;
        private Button btn_del_staff;
        private DataGridView show_staff;
        private TabPage page_org;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btn_add_comp;
        private Button btn_edit_comp;
        private Button btn_del_comp;
        private Button btn_up_comp;
        private DataGridView show_comp;
        private RadioButton radioButton1;
    }
}