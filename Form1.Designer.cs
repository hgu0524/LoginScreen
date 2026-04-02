namespace LoginScreen
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
            txtID = new TextBox();
            lblAppName = new Label();
            txtPW = new TextBox();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // txtID
            // 
            txtID.Font = new Font("맑은 고딕", 24F);
            txtID.ForeColor = Color.Silver;
            txtID.Location = new Point(189, 227);
            txtID.Multiline = true;
            txtID.Name = "txtID";
            txtID.Size = new Size(685, 98);
            txtID.TabIndex = 2;
            txtID.Text = "아이디";
            txtID.Enter += txtID_Enter;
            txtID.Leave += txtID_Leave;
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("맑은 고딕", 40.125F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblAppName.Location = new Point(376, 34);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(327, 142);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "Login";
            // 
            // txtPW
            // 
            txtPW.Font = new Font("맑은 고딕", 24F);
            txtPW.ForeColor = Color.Silver;
            txtPW.Location = new Point(189, 396);
            txtPW.Name = "txtPW";
            txtPW.Size = new Size(685, 93);
            txtPW.TabIndex = 3;
            txtPW.Text = "패스워드";
            txtPW.Enter += txtPW_Enter;
            txtPW.Leave += txtPW_Leave;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.CornflowerBlue;
            btnLogin.Font = new Font("맑은 고딕", 20F);
            btnLogin.Location = new Point(376, 625);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(327, 111);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "로그인";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 830);
            Controls.Add(btnLogin);
            Controls.Add(txtPW);
            Controls.Add(lblAppName);
            Controls.Add(txtID);
            Name = "Form1";
            Text = "Login Sreen";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtID;
        private Label lblAppName;
        private TextBox txtPW;
        private Button btnLogin;
    }
}
