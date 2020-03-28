namespace Meds_App
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
            this.Panel_Left = new System.Windows.Forms.Panel();
            this.Panel_Top = new System.Windows.Forms.Panel();
            this.Label_Title = new System.Windows.Forms.Label();
            this.Button_Help = new System.Windows.Forms.Button();
            this.Button_Settings = new System.Windows.Forms.Button();
            this.Button_Exit = new System.Windows.Forms.Button();
            this.Button_Details = new System.Windows.Forms.Button();
            this.Button_Expired = new System.Windows.Forms.Button();
            this.Button_Home = new System.Windows.Forms.Button();
            this.PictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.Panel_Left.SuspendLayout();
            this.Panel_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Left
            // 
            this.Panel_Left.BackColor = System.Drawing.Color.Moccasin;
            this.Panel_Left.Controls.Add(this.Button_Details);
            this.Panel_Left.Controls.Add(this.Button_Expired);
            this.Panel_Left.Controls.Add(this.Button_Home);
            this.Panel_Left.Controls.Add(this.PictureBox_Logo);
            this.Panel_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_Left.Location = new System.Drawing.Point(0, 0);
            this.Panel_Left.Name = "Panel_Left";
            this.Panel_Left.Size = new System.Drawing.Size(198, 557);
            this.Panel_Left.TabIndex = 0;
            // 
            // Panel_Top
            // 
            this.Panel_Top.BackColor = System.Drawing.Color.Salmon;
            this.Panel_Top.Controls.Add(this.Label_Title);
            this.Panel_Top.Controls.Add(this.Button_Help);
            this.Panel_Top.Controls.Add(this.Button_Settings);
            this.Panel_Top.Controls.Add(this.Button_Exit);
            this.Panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Top.Location = new System.Drawing.Point(198, 0);
            this.Panel_Top.Name = "Panel_Top";
            this.Panel_Top.Size = new System.Drawing.Size(758, 39);
            this.Panel_Top.TabIndex = 1;
            // 
            // Label_Title
            // 
            this.Label_Title.AutoSize = true;
            this.Label_Title.Font = new System.Drawing.Font("Script MT Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Title.Location = new System.Drawing.Point(-7, -2);
            this.Label_Title.Name = "Label_Title";
            this.Label_Title.Size = new System.Drawing.Size(559, 41);
            this.Label_Title.TabIndex = 4;
            this.Label_Title.Text = "Management for home meds application";
            // 
            // Button_Help
            // 
            this.Button_Help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button_Help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Help.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.Button_Help.FlatAppearance.BorderSize = 0;
            this.Button_Help.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.Button_Help.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.Button_Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Help.ForeColor = System.Drawing.Color.Salmon;
            this.Button_Help.Image = global::Meds_App.Properties.Resources.LOGO_Help;
            this.Button_Help.Location = new System.Drawing.Point(557, 0);
            this.Button_Help.Name = "Button_Help";
            this.Button_Help.Size = new System.Drawing.Size(63, 39);
            this.Button_Help.TabIndex = 3;
            this.Button_Help.UseVisualStyleBackColor = true;
            // 
            // Button_Settings
            // 
            this.Button_Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button_Settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Settings.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.Button_Settings.FlatAppearance.BorderSize = 0;
            this.Button_Settings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.Button_Settings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.Button_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Settings.ForeColor = System.Drawing.Color.Salmon;
            this.Button_Settings.Image = global::Meds_App.Properties.Resources.LOGO_Settings;
            this.Button_Settings.Location = new System.Drawing.Point(626, 0);
            this.Button_Settings.Name = "Button_Settings";
            this.Button_Settings.Size = new System.Drawing.Size(63, 39);
            this.Button_Settings.TabIndex = 2;
            this.Button_Settings.UseVisualStyleBackColor = true;
            // 
            // Button_Exit
            // 
            this.Button_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Button_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Exit.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.Button_Exit.FlatAppearance.BorderSize = 0;
            this.Button_Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Button_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.Button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Exit.ForeColor = System.Drawing.Color.Salmon;
            this.Button_Exit.Image = global::Meds_App.Properties.Resources.LOGO_Exit;
            this.Button_Exit.Location = new System.Drawing.Point(695, 0);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(63, 39);
            this.Button_Exit.TabIndex = 0;
            this.Button_Exit.UseVisualStyleBackColor = true;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // Button_Details
            // 
            this.Button_Details.BackColor = System.Drawing.Color.Moccasin;
            this.Button_Details.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Details.FlatAppearance.BorderSize = 0;
            this.Button_Details.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Moccasin;
            this.Button_Details.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.Button_Details.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Details.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Details.Image = global::Meds_App.Properties.Resources.LOGO_List;
            this.Button_Details.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Details.Location = new System.Drawing.Point(22, 413);
            this.Button_Details.Name = "Button_Details";
            this.Button_Details.Size = new System.Drawing.Size(176, 93);
            this.Button_Details.TabIndex = 4;
            this.Button_Details.Text = "Details";
            this.Button_Details.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_Details.UseVisualStyleBackColor = false;
            this.Button_Details.Click += new System.EventHandler(this.Button_Details_Click);
            // 
            // Button_Expired
            // 
            this.Button_Expired.BackColor = System.Drawing.Color.Moccasin;
            this.Button_Expired.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Expired.FlatAppearance.BorderSize = 0;
            this.Button_Expired.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Moccasin;
            this.Button_Expired.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.Button_Expired.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Expired.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Expired.Image = global::Meds_App.Properties.Resources.LOGO_OutOfDate;
            this.Button_Expired.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Expired.Location = new System.Drawing.Point(22, 280);
            this.Button_Expired.Name = "Button_Expired";
            this.Button_Expired.Size = new System.Drawing.Size(176, 105);
            this.Button_Expired.TabIndex = 3;
            this.Button_Expired.Text = "Out of date";
            this.Button_Expired.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_Expired.UseVisualStyleBackColor = false;
            this.Button_Expired.Click += new System.EventHandler(this.Button_Expired_Click);
            // 
            // Button_Home
            // 
            this.Button_Home.BackColor = System.Drawing.Color.OldLace;
            this.Button_Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Home.FlatAppearance.BorderSize = 0;
            this.Button_Home.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Moccasin;
            this.Button_Home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.Button_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Home.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Home.Image = global::Meds_App.Properties.Resources.LOGO_Home;
            this.Button_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Home.Location = new System.Drawing.Point(22, 174);
            this.Button_Home.Name = "Button_Home";
            this.Button_Home.Size = new System.Drawing.Size(176, 72);
            this.Button_Home.TabIndex = 2;
            this.Button_Home.Text = "Home";
            this.Button_Home.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Button_Home.UseVisualStyleBackColor = false;
            this.Button_Home.Click += new System.EventHandler(this.Button_Home_Click);
            // 
            // PictureBox_Logo
            // 
            this.PictureBox_Logo.Image = global::Meds_App.Properties.Resources.LOGO_Med;
            this.PictureBox_Logo.ImageLocation = "";
            this.PictureBox_Logo.Location = new System.Drawing.Point(7, 25);
            this.PictureBox_Logo.Name = "PictureBox_Logo";
            this.PictureBox_Logo.Size = new System.Drawing.Size(185, 93);
            this.PictureBox_Logo.TabIndex = 0;
            this.PictureBox_Logo.TabStop = false;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(956, 557);
            this.Controls.Add(this.Panel_Top);
            this.Controls.Add(this.Panel_Left);
            this.Font = new System.Drawing.Font("Bauhaus 93", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meds App";
            this.Panel_Left.ResumeLayout(false);
            this.Panel_Top.ResumeLayout(false);
            this.Panel_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Panel_Left;
        private System.Windows.Forms.PictureBox PictureBox_Logo;
        private System.Windows.Forms.Panel Panel_Top;
        private System.Windows.Forms.Button Button_Exit;
        private System.Windows.Forms.Button Button_Settings;
        private System.Windows.Forms.Button Button_Help;
        private System.Windows.Forms.Label Label_Title;
        private System.Windows.Forms.Button Button_Details;
        private System.Windows.Forms.Button Button_Expired;
        private System.Windows.Forms.Button Button_Home;
    }
}

