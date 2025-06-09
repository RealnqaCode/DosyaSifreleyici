namespace DosyaSifreleyici
{
    partial class Form1
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnEncrypt = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnDecrypt = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnBrowse = new Guna.UI2.WinForms.Guna2TileButton();
            this.txtFilePath = new Guna.UI2.WinForms.Guna2TextBox();
            this.circleProgress = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Animated = true;
            this.txtPassword.BorderRadius = 5;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(218, 167);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PlaceholderText = "Şifre Giriniz";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(363, 38);
            this.txtPassword.TabIndex = 0;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Animated = true;
            this.btnEncrypt.BackColor = System.Drawing.Color.Transparent;
            this.btnEncrypt.BorderRadius = 5;
            this.btnEncrypt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEncrypt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEncrypt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEncrypt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEncrypt.FillColor = System.Drawing.Color.White;
            this.btnEncrypt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnEncrypt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnEncrypt.Location = new System.Drawing.Point(218, 271);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(137, 52);
            this.btnEncrypt.TabIndex = 1;
            this.btnEncrypt.Text = "Dosyayı Şifrele";
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Animated = true;
            this.btnDecrypt.BackColor = System.Drawing.Color.Transparent;
            this.btnDecrypt.BorderRadius = 5;
            this.btnDecrypt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDecrypt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDecrypt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDecrypt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDecrypt.FillColor = System.Drawing.Color.White;
            this.btnDecrypt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnDecrypt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnDecrypt.Location = new System.Drawing.Point(444, 271);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(137, 52);
            this.btnDecrypt.TabIndex = 2;
            this.btnDecrypt.Text = "Şifreyi Çöz";
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Animated = true;
            this.btnBrowse.BackColor = System.Drawing.Color.Transparent;
            this.btnBrowse.BorderRadius = 5;
            this.btnBrowse.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBrowse.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBrowse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBrowse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBrowse.FillColor = System.Drawing.Color.White;
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnBrowse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnBrowse.Location = new System.Drawing.Point(46, 39);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(149, 39);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Dosya Seç";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.Animated = true;
            this.txtFilePath.BorderRadius = 5;
            this.txtFilePath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilePath.DefaultText = "";
            this.txtFilePath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFilePath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFilePath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilePath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilePath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilePath.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtFilePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtFilePath.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilePath.Location = new System.Drawing.Point(218, 40);
            this.txtFilePath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.PlaceholderText = "";
            this.txtFilePath.SelectedText = "";
            this.txtFilePath.Size = new System.Drawing.Size(363, 38);
            this.txtFilePath.TabIndex = 4;
            // 
            // circleProgress
            // 
            this.circleProgress.FillColor = System.Drawing.Color.White;
            this.circleProgress.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.circleProgress.ForeColor = System.Drawing.Color.White;
            this.circleProgress.Location = new System.Drawing.Point(29, 146);
            this.circleProgress.Minimum = 0;
            this.circleProgress.Name = "circleProgress";
            this.circleProgress.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.circleProgress.Size = new System.Drawing.Size(150, 150);
            this.circleProgress.TabIndex = 5;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(70)))), ((int)(((byte)(143)))));
            this.ClientSize = new System.Drawing.Size(642, 374);
            this.Controls.Add(this.circleProgress);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.txtPassword);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dosya Şifreleme";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TileButton btnEncrypt;
        private Guna.UI2.WinForms.Guna2TileButton btnDecrypt;
        private Guna.UI2.WinForms.Guna2TextBox txtFilePath;
        private Guna.UI2.WinForms.Guna2TileButton btnBrowse;
        private Guna.UI2.WinForms.Guna2CircleProgressBar circleProgress;
    }
}

