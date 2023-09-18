namespace armApp
{
    partial class edit_password
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
            btn_login = new Button();
            password = new TextBox();
            label_password = new Label();
            password_1 = new TextBox();
            label_password_1 = new Label();
            password_2 = new TextBox();
            label_password_2 = new Label();
            cb1 = new CheckBox();
            cb2 = new CheckBox();
            cb3 = new CheckBox();
            SuspendLayout();
            // 
            // btn_login
            // 
            btn_login.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_login.Location = new Point(139, 228);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(117, 31);
            btn_login.TabIndex = 9;
            btn_login.Text = "Сохранить";
            btn_login.UseVisualStyleBackColor = true;
            // 
            // password
            // 
            password.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            password.Location = new Point(85, 58);
            password.Name = "password";
            password.Size = new Size(224, 27);
            password.TabIndex = 8;
            // 
            // label_password
            // 
            label_password.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_password.AutoSize = true;
            label_password.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label_password.Location = new Point(85, 36);
            label_password.Name = "label_password";
            label_password.Size = new Size(106, 19);
            label_password.TabIndex = 7;
            label_password.Text = "Старый пароль";
            // 
            // password_1
            // 
            password_1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            password_1.Location = new Point(85, 117);
            password_1.Name = "password_1";
            password_1.Size = new Size(224, 27);
            password_1.TabIndex = 11;
            // 
            // label_password_1
            // 
            label_password_1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_password_1.AutoSize = true;
            label_password_1.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label_password_1.Location = new Point(85, 95);
            label_password_1.Name = "label_password_1";
            label_password_1.Size = new Size(101, 19);
            label_password_1.TabIndex = 10;
            label_password_1.Text = "Новый пароль";
            // 
            // password_2
            // 
            password_2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            password_2.Location = new Point(85, 176);
            password_2.Name = "password_2";
            password_2.Size = new Size(224, 27);
            password_2.TabIndex = 13;
            // 
            // label_password_2
            // 
            label_password_2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label_password_2.AutoSize = true;
            label_password_2.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label_password_2.Location = new Point(85, 154);
            label_password_2.Name = "label_password_2";
            label_password_2.Size = new Size(126, 19);
            label_password_2.TabIndex = 12;
            label_password_2.Text = "Повторите пароль";
            // 
            // cb1
            // 
            cb1.AutoSize = true;
            cb1.Location = new Point(315, 64);
            cb1.Name = "cb1";
            cb1.Size = new Size(18, 17);
            cb1.TabIndex = 14;
            cb1.UseVisualStyleBackColor = true;
            // 
            // cb2
            // 
            cb2.AutoSize = true;
            cb2.Location = new Point(315, 123);
            cb2.Name = "cb2";
            cb2.Size = new Size(18, 17);
            cb2.TabIndex = 15;
            cb2.UseVisualStyleBackColor = true;
            // 
            // cb3
            // 
            cb3.AutoSize = true;
            cb3.Location = new Point(315, 182);
            cb3.Name = "cb3";
            cb3.Size = new Size(18, 17);
            cb3.TabIndex = 16;
            cb3.UseVisualStyleBackColor = true;
            // 
            // edit_password
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 283);
            Controls.Add(cb3);
            Controls.Add(cb2);
            Controls.Add(cb1);
            Controls.Add(password_2);
            Controls.Add(label_password_2);
            Controls.Add(password_1);
            Controls.Add(label_password_1);
            Controls.Add(btn_login);
            Controls.Add(password);
            Controls.Add(label_password);
            MaximumSize = new Size(450, 330);
            MinimumSize = new Size(350, 330);
            Name = "edit_password";
            Text = "Изменение пароля";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_login;
        private TextBox password;
        private Label label_password;
        private TextBox password_1;
        private Label label_password_1;
        private TextBox password_2;
        private Label label_password_2;
        private CheckBox cb1;
        private CheckBox cb2;
        private CheckBox cb3;
    }
}