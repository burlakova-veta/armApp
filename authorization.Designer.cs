namespace armApp
{
    partial class Auth
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_login = new Label();
            login = new TextBox();
            password = new TextBox();
            label_password = new Label();
            btn_login = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // label_login
            // 
            label_login.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_login.AutoSize = true;
            label_login.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label_login.Location = new Point(69, 22);
            label_login.Name = "label_login";
            label_login.Size = new Size(47, 19);
            label_login.TabIndex = 0;
            label_login.Text = "Логин";
            // 
            // login
            // 
            login.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            login.Location = new Point(69, 44);
            login.Name = "login";
            login.Size = new Size(278, 27);
            login.TabIndex = 1;
            // 
            // password
            // 
            password.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            password.Location = new Point(69, 107);
            password.Name = "password";
            password.Size = new Size(278, 27);
            password.TabIndex = 3;
            // 
            // label_password
            // 
            label_password.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_password.AutoSize = true;
            label_password.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label_password.Location = new Point(69, 85);
            label_password.Name = "label_password";
            label_password.Size = new Size(56, 19);
            label_password.TabIndex = 2;
            label_password.Text = "Пароль";
            // 
            // btn_login
            // 
            btn_login.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_login.Location = new Point(155, 175);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(89, 31);
            btn_login.TabIndex = 4;
            btn_login.Text = "ОК";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(197, 140);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(150, 24);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Показать пароль";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Auth
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 218);
            Controls.Add(checkBox1);
            Controls.Add(btn_login);
            Controls.Add(password);
            Controls.Add(label_password);
            Controls.Add(login);
            Controls.Add(label_login);
            MaximumSize = new Size(500, 265);
            MinimumSize = new Size(400, 265);
            Name = "Auth";
            Text = "Авторизация";
            Load += Auth_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_login;
        private TextBox login;
        private TextBox password;
        private Label label_password;
        private Button btn_login;
        private CheckBox checkBox1;
    }
}