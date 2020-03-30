namespace Meds_App
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel_Left = new System.Windows.Forms.Panel();
            this.button_Details = new System.Windows.Forms.Button();
            this.button_Expired = new System.Windows.Forms.Button();
            this.button_Home = new System.Windows.Forms.Button();
            this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.label_Title = new System.Windows.Forms.Label();
            this.button_Help = new System.Windows.Forms.Button();
            this.button_Settings = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.panel_Main = new System.Windows.Forms.Panel();
            this.panelHome_In_Main = new Meds_App.Home();
            this.panelOutOfDate_In_Main = new Meds_App.UserControls.OutOfDate();
            this.panel_Left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
            this.panel_Top.SuspendLayout();
            this.panel_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Left
            // 
            this.panel_Left.BackColor = System.Drawing.Color.Moccasin;
            this.panel_Left.Controls.Add(this.button_Details);
            this.panel_Left.Controls.Add(this.button_Expired);
            this.panel_Left.Controls.Add(this.button_Home);
            this.panel_Left.Controls.Add(this.pictureBox_Logo);
            this.panel_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Left.Location = new System.Drawing.Point(0, 0);
            this.panel_Left.Name = "panel_Left";
            this.panel_Left.Size = new System.Drawing.Size(198, 629);
            this.panel_Left.TabIndex = 0;
            // 
            // button_Details
            // 
            this.button_Details.BackColor = System.Drawing.Color.Moccasin;
            this.button_Details.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Details.FlatAppearance.BorderSize = 0;
            this.button_Details.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Moccasin;
            this.button_Details.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.button_Details.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Details.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Details.Image = global::Meds_App.Properties.Resources.LOGO_List;
            this.button_Details.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Details.Location = new System.Drawing.Point(22, 481);
            this.button_Details.Name = "button_Details";
            this.button_Details.Size = new System.Drawing.Size(176, 93);
            this.button_Details.TabIndex = 4;
            this.button_Details.Text = "Details";
            this.button_Details.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Details.UseVisualStyleBackColor = false;
            this.button_Details.Click += new System.EventHandler(this.Button_Details_Click);
            // 
            // button_Expired
            // 
            this.button_Expired.BackColor = System.Drawing.Color.Moccasin;
            this.button_Expired.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Expired.FlatAppearance.BorderSize = 0;
            this.button_Expired.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Moccasin;
            this.button_Expired.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.button_Expired.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Expired.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Expired.Image = global::Meds_App.Properties.Resources.LOGO_OutOfDate;
            this.button_Expired.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Expired.Location = new System.Drawing.Point(22, 326);
            this.button_Expired.Name = "button_Expired";
            this.button_Expired.Size = new System.Drawing.Size(176, 105);
            this.button_Expired.TabIndex = 3;
            this.button_Expired.Text = "Out of date";
            this.button_Expired.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Expired.UseVisualStyleBackColor = false;
            this.button_Expired.Click += new System.EventHandler(this.Button_Expired_Click);
            // 
            // button_Home
            // 
            this.button_Home.BackColor = System.Drawing.Color.OldLace;
            this.button_Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Home.FlatAppearance.BorderSize = 0;
            this.button_Home.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Moccasin;
            this.button_Home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.AntiqueWhite;
            this.button_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Home.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Home.Image = global::Meds_App.Properties.Resources.LOGO_Home;
            this.button_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Home.Location = new System.Drawing.Point(22, 174);
            this.button_Home.Name = "button_Home";
            this.button_Home.Size = new System.Drawing.Size(176, 86);
            this.button_Home.TabIndex = 2;
            this.button_Home.Text = "Home";
            this.button_Home.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Home.UseVisualStyleBackColor = false;
            this.button_Home.Click += new System.EventHandler(this.Button_Home_Click);
            // 
            // pictureBox_Logo
            // 
            this.pictureBox_Logo.Image = global::Meds_App.Properties.Resources.LOGO_Med;
            this.pictureBox_Logo.ImageLocation = "";
            this.pictureBox_Logo.Location = new System.Drawing.Point(7, 25);
            this.pictureBox_Logo.Name = "pictureBox_Logo";
            this.pictureBox_Logo.Size = new System.Drawing.Size(185, 93);
            this.pictureBox_Logo.TabIndex = 0;
            this.pictureBox_Logo.TabStop = false;
            // 
            // panel_Top
            // 
            this.panel_Top.BackColor = System.Drawing.Color.Salmon;
            this.panel_Top.Controls.Add(this.label_Title);
            this.panel_Top.Controls.Add(this.button_Help);
            this.panel_Top.Controls.Add(this.button_Settings);
            this.panel_Top.Controls.Add(this.button_Exit);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(198, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(758, 39);
            this.panel_Top.TabIndex = 1;
            // 
            // label_Title
            // 
            this.label_Title.Font = new System.Drawing.Font("Script MT Bold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.Location = new System.Drawing.Point(0, 0);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(578, 41);
            this.label_Title.TabIndex = 4;
            this.label_Title.Text = "Application for managing home medicines";
            // 
            // button_Help
            // 
            this.button_Help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_Help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Help.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.button_Help.FlatAppearance.BorderSize = 0;
            this.button_Help.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.button_Help.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.button_Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Help.ForeColor = System.Drawing.Color.Salmon;
            this.button_Help.Image = global::Meds_App.Properties.Resources.LOGO_Help;
            this.button_Help.Location = new System.Drawing.Point(607, 0);
            this.button_Help.Name = "button_Help";
            this.button_Help.Size = new System.Drawing.Size(42, 39);
            this.button_Help.TabIndex = 3;
            this.button_Help.UseVisualStyleBackColor = true;
            // 
            // button_Settings
            // 
            this.button_Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_Settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Settings.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.button_Settings.FlatAppearance.BorderSize = 0;
            this.button_Settings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.button_Settings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.button_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Settings.ForeColor = System.Drawing.Color.Salmon;
            this.button_Settings.Image = global::Meds_App.Properties.Resources.LOGO_Settings;
            this.button_Settings.Location = new System.Drawing.Point(655, 0);
            this.button_Settings.Name = "button_Settings";
            this.button_Settings.Size = new System.Drawing.Size(46, 39);
            this.button_Settings.TabIndex = 2;
            this.button_Settings.UseVisualStyleBackColor = true;
            this.button_Settings.Click += new System.EventHandler(this.button_Settings_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Exit.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.button_Exit.FlatAppearance.BorderSize = 0;
            this.button_Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Exit.ForeColor = System.Drawing.Color.Salmon;
            this.button_Exit.Image = global::Meds_App.Properties.Resources.LOGO_Exit;
            this.button_Exit.Location = new System.Drawing.Point(707, 0);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(51, 39);
            this.button_Exit.TabIndex = 0;
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // panel_Main
            // 
            this.panel_Main.Controls.Add(this.panelOutOfDate_In_Main);
            this.panel_Main.Controls.Add(this.panelHome_In_Main);
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Main.Location = new System.Drawing.Point(198, 39);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(758, 590);
            this.panel_Main.TabIndex = 2;
            // 
            // panelHome_In_Main
            // 
            this.panelHome_In_Main.BackColor = System.Drawing.Color.OldLace;
            this.panelHome_In_Main.Location = new System.Drawing.Point(0, 0);
            this.panelHome_In_Main.Name = "panelHome_In_Main";
            this.panelHome_In_Main.Size = new System.Drawing.Size(758, 590);
            this.panelHome_In_Main.TabIndex = 0;
            // 
            // panelOutOfDate_In_Main
            // 
            this.panelOutOfDate_In_Main.Location = new System.Drawing.Point(0, 0);
            this.panelOutOfDate_In_Main.Name = "panelOutOfDate_In_Main";
            this.panelOutOfDate_In_Main.Size = new System.Drawing.Size(758, 590);
            this.panelOutOfDate_In_Main.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(956, 629);
            this.Controls.Add(this.panel_Main);
            this.Controls.Add(this.panel_Top);
            this.Controls.Add(this.panel_Left);
            this.Font = new System.Drawing.Font("Bauhaus 93", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meds App";
            this.panel_Left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
            this.panel_Top.ResumeLayout(false);
            this.panel_Main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_Left;
        private System.Windows.Forms.PictureBox pictureBox_Logo;
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_Settings;
        private System.Windows.Forms.Button button_Help;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Button button_Details;
        private System.Windows.Forms.Button button_Expired;
        private System.Windows.Forms.Button button_Home;
        private System.Windows.Forms.Panel panel_Main;
        private Home panelHome_In_Main;
        private UserControls.OutOfDate panelOutOfDate_In_Main;
    }
}

