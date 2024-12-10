namespace SCMS
{
    partial class Formlogin
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
            this.components = new System.ComponentModel.Container();
            this.skinTextBoxName = new CCWin.SkinControl.SkinTextBox();
            this.skinTextBoxPassword = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinButtonLogin = new CCWin.SkinControl.SkinButton();
            this.skinButtonCancel = new CCWin.SkinControl.SkinButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // skinTextBoxName
            // 
            this.skinTextBoxName.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBoxName.DownBack = null;
            this.skinTextBoxName.Icon = null;
            this.skinTextBoxName.IconIsButton = false;
            this.skinTextBoxName.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxName.IsPasswordChat = '\0';
            this.skinTextBoxName.IsSystemPasswordChar = false;
            this.skinTextBoxName.Lines = new string[0];
            this.skinTextBoxName.Location = new System.Drawing.Point(272, 176);
            this.skinTextBoxName.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBoxName.MaxLength = 32767;
            this.skinTextBoxName.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBoxName.MouseBack = null;
            this.skinTextBoxName.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxName.Multiline = false;
            this.skinTextBoxName.Name = "skinTextBoxName";
            this.skinTextBoxName.NormlBack = null;
            this.skinTextBoxName.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBoxName.ReadOnly = false;
            this.skinTextBoxName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBoxName.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.skinTextBoxName.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBoxName.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBoxName.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBoxName.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBoxName.SkinTxt.Name = "BaseText";
            this.skinTextBoxName.SkinTxt.Size = new System.Drawing.Size(175, 26);
            this.skinTextBoxName.SkinTxt.TabIndex = 0;
            this.skinTextBoxName.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxName.SkinTxt.WaterText = "你的姓名";
            this.skinTextBoxName.TabIndex = 0;
            this.skinTextBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBoxName.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxName.WaterText = "你的姓名";
            this.skinTextBoxName.WordWrap = true;
            this.skinTextBoxName.Paint += new System.Windows.Forms.PaintEventHandler(this.skinTextBoxName_Paint);
            // 
            // skinTextBoxPassword
            // 
            this.skinTextBoxPassword.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBoxPassword.DownBack = null;
            this.skinTextBoxPassword.Icon = null;
            this.skinTextBoxPassword.IconIsButton = false;
            this.skinTextBoxPassword.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxPassword.IsPasswordChat = '●';
            this.skinTextBoxPassword.IsSystemPasswordChar = true;
            this.skinTextBoxPassword.Lines = new string[0];
            this.skinTextBoxPassword.Location = new System.Drawing.Point(272, 256);
            this.skinTextBoxPassword.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBoxPassword.MaxLength = 32767;
            this.skinTextBoxPassword.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBoxPassword.MouseBack = null;
            this.skinTextBoxPassword.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBoxPassword.Multiline = false;
            this.skinTextBoxPassword.Name = "skinTextBoxPassword";
            this.skinTextBoxPassword.NormlBack = null;
            this.skinTextBoxPassword.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBoxPassword.ReadOnly = false;
            this.skinTextBoxPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBoxPassword.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.skinTextBoxPassword.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBoxPassword.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBoxPassword.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBoxPassword.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBoxPassword.SkinTxt.Name = "BaseText";
            this.skinTextBoxPassword.SkinTxt.PasswordChar = '●';
            this.skinTextBoxPassword.SkinTxt.Size = new System.Drawing.Size(175, 26);
            this.skinTextBoxPassword.SkinTxt.TabIndex = 0;
            this.skinTextBoxPassword.SkinTxt.UseSystemPasswordChar = true;
            this.skinTextBoxPassword.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxPassword.SkinTxt.WaterText = "密码长度大于6";
            this.skinTextBoxPassword.TabIndex = 1;
            this.skinTextBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBoxPassword.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBoxPassword.WaterText = "密码长度大于6";
            this.skinTextBoxPassword.WordWrap = true;
            this.skinTextBoxPassword.Paint += new System.Windows.Forms.PaintEventHandler(this.skinTextBox2_Paint);
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.skinLabel1.Location = new System.Drawing.Point(266, 133);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(62, 31);
            this.skinLabel1.TabIndex = 2;
            this.skinLabel1.Text = "用户";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.skinLabel2.Location = new System.Drawing.Point(266, 225);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(62, 31);
            this.skinLabel2.TabIndex = 3;
            this.skinLabel2.Text = "密码";
            this.skinLabel2.Click += new System.EventHandler(this.skinLabel2_Click);
            // 
            // skinButtonLogin
            // 
            this.skinButtonLogin.BackColor = System.Drawing.Color.Transparent;
            this.skinButtonLogin.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButtonLogin.DownBack = null;
            this.skinButtonLogin.Location = new System.Drawing.Point(240, 342);
            this.skinButtonLogin.MouseBack = null;
            this.skinButtonLogin.Name = "skinButtonLogin";
            this.skinButtonLogin.NormlBack = null;
            this.skinButtonLogin.Size = new System.Drawing.Size(75, 23);
            this.skinButtonLogin.TabIndex = 4;
            this.skinButtonLogin.Text = "登录";
            this.skinButtonLogin.UseVisualStyleBackColor = false;
            this.skinButtonLogin.Click += new System.EventHandler(this.skinButtonLogin_Click);
            // 
            // skinButtonCancel
            // 
            this.skinButtonCancel.BackColor = System.Drawing.Color.Transparent;
            this.skinButtonCancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButtonCancel.DownBack = null;
            this.skinButtonCancel.Location = new System.Drawing.Point(416, 342);
            this.skinButtonCancel.MouseBack = null;
            this.skinButtonCancel.Name = "skinButtonCancel";
            this.skinButtonCancel.NormlBack = null;
            this.skinButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.skinButtonCancel.TabIndex = 5;
            this.skinButtonCancel.Text = "取消";
            this.skinButtonCancel.UseVisualStyleBackColor = false;
            this.skinButtonCancel.Click += new System.EventHandler(this.skinButtonCancel_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.DimGray;
            this.linkLabel1.Location = new System.Drawing.Point(460, 173);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(110, 31);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "用户注册";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel2.LinkColor = System.Drawing.Color.DimGray;
            this.linkLabel2.Location = new System.Drawing.Point(460, 253);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(110, 31);
            this.linkLabel2.TabIndex = 7;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "找回密码";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // Formlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.skinButtonCancel);
            this.Controls.Add(this.skinButtonLogin);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.skinTextBoxPassword);
            this.Controls.Add(this.skinTextBoxName);
            this.Name = "Formlogin";
            this.ShowInTaskbar = false;
            this.Text = "登录系统";
            this.Load += new System.EventHandler(this.Formlogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinTextBox skinTextBoxName;
        private CCWin.SkinControl.SkinTextBox skinTextBoxPassword;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinButton skinButtonLogin;
        private CCWin.SkinControl.SkinButton skinButtonCancel;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}