namespace vizsgaremek
{
    partial class Form1
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
            username_textbox = new TextBox();
            password_textbox = new TextBox();
            login_btn = new Button();
            SuspendLayout();
            // 
            // username_textbox
            // 
            username_textbox.Location = new Point(261, 148);
            username_textbox.Multiline = true;
            username_textbox.Name = "username_textbox";
            username_textbox.Size = new Size(214, 34);
            username_textbox.TabIndex = 0;
            // 
            // password_textbox
            // 
            password_textbox.Location = new Point(261, 203);
            password_textbox.Multiline = true;
            password_textbox.Name = "password_textbox";
            password_textbox.Size = new Size(214, 34);
            password_textbox.TabIndex = 1;
            // 
            // login_btn
            // 
            login_btn.Location = new Point(264, 257);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(75, 23);
            login_btn.TabIndex = 2;
            login_btn.Text = "login";
            login_btn.UseVisualStyleBackColor = true;
            login_btn.Click += login_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(login_btn);
            Controls.Add(password_textbox);
            Controls.Add(username_textbox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox username_textbox;
        private TextBox password_textbox;
        private Button login_btn;
    }
}