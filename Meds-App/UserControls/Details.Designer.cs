namespace Meds_App.UserControls
{
    partial class Details
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_bottom = new System.Windows.Forms.Panel();
            this.button_copyright_flag = new System.Windows.Forms.Button();
            this.label_copyright_flag = new System.Windows.Forms.Label();
            this.label_copyright_github = new System.Windows.Forms.Label();
            this.button_copyright_home = new System.Windows.Forms.Button();
            this.button_copyright_github = new System.Windows.Forms.Button();
            this.label_copyright_home = new System.Windows.Forms.Label();
            this.label_copyright = new System.Windows.Forms.Label();
            this.panel_top = new System.Windows.Forms.Panel();
            this.label_github_app = new System.Windows.Forms.Label();
            this.label_github_server = new System.Windows.Forms.Label();
            this.button_github_app = new System.Windows.Forms.Button();
            this.label_details_title = new System.Windows.Forms.Label();
            this.button_github_server = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel_bottom.SuspendLayout();
            this.panel_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OldLace;
            this.panel1.Controls.Add(this.panel_bottom);
            this.panel1.Controls.Add(this.panel_top);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 590);
            this.panel1.TabIndex = 0;
            // 
            // panel_bottom
            // 
            this.panel_bottom.Controls.Add(this.button_copyright_flag);
            this.panel_bottom.Controls.Add(this.label_copyright_flag);
            this.panel_bottom.Controls.Add(this.label_copyright_github);
            this.panel_bottom.Controls.Add(this.button_copyright_home);
            this.panel_bottom.Controls.Add(this.button_copyright_github);
            this.panel_bottom.Controls.Add(this.label_copyright_home);
            this.panel_bottom.Controls.Add(this.label_copyright);
            this.panel_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom.Location = new System.Drawing.Point(0, 266);
            this.panel_bottom.Name = "panel_bottom";
            this.panel_bottom.Size = new System.Drawing.Size(758, 324);
            this.panel_bottom.TabIndex = 5;
            // 
            // button_copyright_flag
            // 
            this.button_copyright_flag.FlatAppearance.BorderSize = 0;
            this.button_copyright_flag.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_copyright_flag.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.button_copyright_flag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_copyright_flag.Image = global::Meds_App.Properties.Resources.Logo_Flag_Uk_Small;
            this.button_copyright_flag.Location = new System.Drawing.Point(43, 249);
            this.button_copyright_flag.Name = "button_copyright_flag";
            this.button_copyright_flag.Size = new System.Drawing.Size(74, 68);
            this.button_copyright_flag.TabIndex = 11;
            this.button_copyright_flag.UseVisualStyleBackColor = true;
            this.button_copyright_flag.Click += new System.EventHandler(this.button_copyright_flag_Click);
            // 
            // label_copyright_flag
            // 
            this.label_copyright_flag.AutoSize = true;
            this.label_copyright_flag.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_copyright_flag.Location = new System.Drawing.Point(140, 272);
            this.label_copyright_flag.Name = "label_copyright_flag";
            this.label_copyright_flag.Size = new System.Drawing.Size(98, 32);
            this.label_copyright_flag.TabIndex = 10;
            this.label_copyright_flag.Text = "Server";
            // 
            // label_copyright_github
            // 
            this.label_copyright_github.AutoSize = true;
            this.label_copyright_github.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_copyright_github.Location = new System.Drawing.Point(140, 98);
            this.label_copyright_github.Name = "label_copyright_github";
            this.label_copyright_github.Size = new System.Drawing.Size(98, 32);
            this.label_copyright_github.TabIndex = 9;
            this.label_copyright_github.Text = "Server";
            // 
            // button_copyright_home
            // 
            this.button_copyright_home.FlatAppearance.BorderSize = 0;
            this.button_copyright_home.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_copyright_home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.button_copyright_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_copyright_home.Image = global::Meds_App.Properties.Resources.LOGO_Home;
            this.button_copyright_home.Location = new System.Drawing.Point(25, 158);
            this.button_copyright_home.Name = "button_copyright_home";
            this.button_copyright_home.Size = new System.Drawing.Size(109, 85);
            this.button_copyright_home.TabIndex = 8;
            this.button_copyright_home.UseVisualStyleBackColor = true;
            this.button_copyright_home.Click += new System.EventHandler(this.button_copyright_home_Click);
            // 
            // button_copyright_github
            // 
            this.button_copyright_github.FlatAppearance.BorderSize = 0;
            this.button_copyright_github.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_copyright_github.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.button_copyright_github.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_copyright_github.Image = global::Meds_App.Properties.Resources.GitHub_Mark_64px;
            this.button_copyright_github.Location = new System.Drawing.Point(25, 62);
            this.button_copyright_github.Name = "button_copyright_github";
            this.button_copyright_github.Size = new System.Drawing.Size(109, 90);
            this.button_copyright_github.TabIndex = 7;
            this.button_copyright_github.UseVisualStyleBackColor = true;
            this.button_copyright_github.Click += new System.EventHandler(this.button_copyright_github_Click);
            // 
            // label_copyright_home
            // 
            this.label_copyright_home.AutoSize = true;
            this.label_copyright_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_copyright_home.Location = new System.Drawing.Point(140, 188);
            this.label_copyright_home.Name = "label_copyright_home";
            this.label_copyright_home.Size = new System.Drawing.Size(98, 32);
            this.label_copyright_home.TabIndex = 6;
            this.label_copyright_home.Text = "Server";
            // 
            // label_copyright
            // 
            this.label_copyright.AutoSize = true;
            this.label_copyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_copyright.Location = new System.Drawing.Point(3, 6);
            this.label_copyright.Name = "label_copyright";
            this.label_copyright.Size = new System.Drawing.Size(132, 44);
            this.label_copyright.TabIndex = 5;
            this.label_copyright.Text = "Server";
            // 
            // panel_top
            // 
            this.panel_top.Controls.Add(this.label_github_app);
            this.panel_top.Controls.Add(this.label_github_server);
            this.panel_top.Controls.Add(this.button_github_app);
            this.panel_top.Controls.Add(this.label_details_title);
            this.panel_top.Controls.Add(this.button_github_server);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(758, 269);
            this.panel_top.TabIndex = 6;
            // 
            // label_github_app
            // 
            this.label_github_app.AutoSize = true;
            this.label_github_app.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_github_app.Location = new System.Drawing.Point(144, 107);
            this.label_github_app.Name = "label_github_app";
            this.label_github_app.Size = new System.Drawing.Size(70, 36);
            this.label_github_app.TabIndex = 3;
            this.label_github_app.Text = "App";
            // 
            // label_github_server
            // 
            this.label_github_server.AutoSize = true;
            this.label_github_server.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_github_server.Location = new System.Drawing.Point(140, 208);
            this.label_github_server.Name = "label_github_server";
            this.label_github_server.Size = new System.Drawing.Size(102, 36);
            this.label_github_server.TabIndex = 4;
            this.label_github_server.Text = "Server";
            // 
            // button_github_app
            // 
            this.button_github_app.FlatAppearance.BorderSize = 0;
            this.button_github_app.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_github_app.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.button_github_app.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_github_app.Image = global::Meds_App.Properties.Resources.GitHub_Mark_64px;
            this.button_github_app.Location = new System.Drawing.Point(33, 76);
            this.button_github_app.Name = "button_github_app";
            this.button_github_app.Size = new System.Drawing.Size(105, 91);
            this.button_github_app.TabIndex = 1;
            this.button_github_app.UseVisualStyleBackColor = true;
            this.button_github_app.Click += new System.EventHandler(this.button_github_app_Click);
            // 
            // label_details_title
            // 
            this.label_details_title.AutoSize = true;
            this.label_details_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_details_title.Location = new System.Drawing.Point(17, 12);
            this.label_details_title.Name = "label_details_title";
            this.label_details_title.Size = new System.Drawing.Size(176, 44);
            this.label_details_title.TabIndex = 0;
            this.label_details_title.Text = "DETAILS";
            // 
            // button_github_server
            // 
            this.button_github_server.FlatAppearance.BorderSize = 0;
            this.button_github_server.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button_github_server.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.button_github_server.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_github_server.Image = global::Meds_App.Properties.Resources.GitHub_Mark_64px;
            this.button_github_server.Location = new System.Drawing.Point(33, 178);
            this.button_github_server.Name = "button_github_server";
            this.button_github_server.Size = new System.Drawing.Size(105, 91);
            this.button_github_server.TabIndex = 2;
            this.button_github_server.UseVisualStyleBackColor = true;
            this.button_github_server.Click += new System.EventHandler(this.button_github_server_Click);
            // 
            // Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "Details";
            this.Size = new System.Drawing.Size(758, 590);
            this.panel1.ResumeLayout(false);
            this.panel_bottom.ResumeLayout(false);
            this.panel_bottom.PerformLayout();
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_details_title;
        private System.Windows.Forms.Button button_github_app;
        private System.Windows.Forms.Button button_github_server;
        private System.Windows.Forms.Label label_github_app;
        private System.Windows.Forms.Panel panel_bottom;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label label_github_server;
        private System.Windows.Forms.Label label_copyright;
        private System.Windows.Forms.Label label_copyright_home;
        private System.Windows.Forms.Button button_copyright_flag;
        private System.Windows.Forms.Label label_copyright_flag;
        private System.Windows.Forms.Label label_copyright_github;
        private System.Windows.Forms.Button button_copyright_home;
        private System.Windows.Forms.Button button_copyright_github;
    }
}
