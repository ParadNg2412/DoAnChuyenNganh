namespace SaberMart.UI
{
    partial class frmPassword
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pHide = new System.Windows.Forms.PictureBox();
            this.pShow = new System.Windows.Forms.PictureBox();
            this.txtPasswordn = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pHide2 = new System.Windows.Forms.PictureBox();
            this.pShow2 = new System.Windows.Forms.PictureBox();
            this.txtPasswordre = new System.Windows.Forms.TextBox();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHide2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pShow2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pHide2);
            this.panel1.Controls.Add(this.pShow2);
            this.panel1.Controls.Add(this.txtPasswordre);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pHide);
            this.panel1.Controls.Add(this.pShow);
            this.panel1.Controls.Add(this.txtPasswordn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 409);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Swordoflogos", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Swordoflogos", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Re-Enter Password";
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(157, 192);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(242, 5);
            this.panel3.TabIndex = 20;
            // 
            // pHide
            // 
            this.pHide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pHide.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pHide.Image = global::SaberMart.Properties.Resources.hide_32x32;
            this.pHide.Location = new System.Drawing.Point(365, 156);
            this.pHide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pHide.Name = "pHide";
            this.pHide.Size = new System.Drawing.Size(33, 34);
            this.pHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pHide.TabIndex = 19;
            this.pHide.TabStop = false;
            this.pHide.Click += new System.EventHandler(this.pHide_Click);
            // 
            // pShow
            // 
            this.pShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pShow.Image = global::SaberMart.Properties.Resources.show_32x32;
            this.pShow.Location = new System.Drawing.Point(365, 156);
            this.pShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pShow.Name = "pShow";
            this.pShow.Size = new System.Drawing.Size(33, 34);
            this.pShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pShow.TabIndex = 18;
            this.pShow.TabStop = false;
            this.pShow.Click += new System.EventHandler(this.pShow_Click);
            // 
            // txtPasswordn
            // 
            this.txtPasswordn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPasswordn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPasswordn.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordn.Location = new System.Drawing.Point(157, 158);
            this.txtPasswordn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPasswordn.Name = "txtPasswordn";
            this.txtPasswordn.PasswordChar = '*';
            this.txtPasswordn.Size = new System.Drawing.Size(208, 33);
            this.txtPasswordn.TabIndex = 17;
            this.txtPasswordn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(157, 282);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(242, 5);
            this.panel2.TabIndex = 24;
            // 
            // pHide2
            // 
            this.pHide2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pHide2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pHide2.Image = global::SaberMart.Properties.Resources.hide_32x32;
            this.pHide2.Location = new System.Drawing.Point(365, 247);
            this.pHide2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pHide2.Name = "pHide2";
            this.pHide2.Size = new System.Drawing.Size(33, 34);
            this.pHide2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pHide2.TabIndex = 23;
            this.pHide2.TabStop = false;
            this.pHide2.Click += new System.EventHandler(this.pHide2_Click);
            // 
            // pShow2
            // 
            this.pShow2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pShow2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pShow2.Image = global::SaberMart.Properties.Resources.show_32x32;
            this.pShow2.Location = new System.Drawing.Point(365, 247);
            this.pShow2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pShow2.Name = "pShow2";
            this.pShow2.Size = new System.Drawing.Size(33, 34);
            this.pShow2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pShow2.TabIndex = 22;
            this.pShow2.TabStop = false;
            this.pShow2.Click += new System.EventHandler(this.pShow2_Click);
            // 
            // txtPasswordre
            // 
            this.txtPasswordre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtPasswordre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPasswordre.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasswordre.Location = new System.Drawing.Point(157, 248);
            this.txtPasswordre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPasswordre.Name = "txtPasswordre";
            this.txtPasswordre.PasswordChar = '*';
            this.txtPasswordre.Size = new System.Drawing.Size(208, 33);
            this.txtPasswordre.TabIndex = 21;
            this.txtPasswordre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Swordoflogos", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Appearance.Options.UseBackColor = true;
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.AppearanceHovered.BackColor = System.Drawing.Color.Silver;
            this.btnUpdate.AppearanceHovered.Font = new System.Drawing.Font("Swordoflogos", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.AppearanceHovered.Options.UseBackColor = true;
            this.btnUpdate.AppearanceHovered.Options.UseFont = true;
            this.btnUpdate.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdate.AppearancePressed.Font = new System.Drawing.Font("Swordoflogos", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.AppearancePressed.Options.UseBackColor = true;
            this.btnUpdate.AppearancePressed.Options.UseFont = true;
            this.btnUpdate.Location = new System.Drawing.Point(107, 345);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(129, 52);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Swordoflogos", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "Username";
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel4.ForeColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(158, 109);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(242, 5);
            this.panel4.TabIndex = 28;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Coral;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.Location = new System.Drawing.Point(158, 75);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(241, 33);
            this.txtUsername.TabIndex = 27;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Swordoflogos", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Appearance.Options.UseBackColor = true;
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.AppearanceHovered.BackColor = System.Drawing.Color.Silver;
            this.btnCancel.AppearanceHovered.Font = new System.Drawing.Font("Swordoflogos", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.AppearanceHovered.Options.UseBackColor = true;
            this.btnCancel.AppearanceHovered.Options.UseFont = true;
            this.btnCancel.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.AppearancePressed.Font = new System.Drawing.Font("Swordoflogos", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.AppearancePressed.Options.UseBackColor = true;
            this.btnCancel.AppearancePressed.Options.UseFont = true;
            this.btnCancel.Location = new System.Drawing.Point(305, 357);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(129, 52);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmPassword
            // 
            this.Appearance.BackColor = System.Drawing.Color.Gray;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseImage = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(434, 409);
            this.Controls.Add(this.panel1);
            this.IconOptions.Image = global::SaberMart.Properties.Resources.SaberMart;
            this.Name = "frmPassword";
            this.Text = "Forgot Password";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHide2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pShow2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pHide2;
        private System.Windows.Forms.PictureBox pShow2;
        private System.Windows.Forms.TextBox txtPasswordre;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pHide;
        private System.Windows.Forms.PictureBox pShow;
        private System.Windows.Forms.TextBox txtPasswordn;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtUsername;
    }
}