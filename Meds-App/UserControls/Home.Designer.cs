﻿namespace Meds_App
{
    partial class Home
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
            this.listView_Meds = new System.Windows.Forms.ListView();
            this.label_Search = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel_Home_Right = new System.Windows.Forms.Panel();
            this.button_Back = new System.Windows.Forms.Button();
            this.button_Add_Home = new System.Windows.Forms.Button();
            this.panel_Home_Left = new System.Windows.Forms.Panel();
            this.PanelAddMeds_In_Home = new Meds_App.AddMeds();
            this.button_Details = new System.Windows.Forms.Button();
            this.PanelDetails_In_Home = new Meds_App.UserControls.Home.DetailsMeds();
            this.panel_Home_Right.SuspendLayout();
            this.panel_Home_Left.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_Meds
            // 
            this.listView_Meds.BackColor = System.Drawing.Color.PapayaWhip;
            this.listView_Meds.HideSelection = false;
            this.listView_Meds.Location = new System.Drawing.Point(18, 12);
            this.listView_Meds.Name = "listView_Meds";
            this.listView_Meds.Size = new System.Drawing.Size(323, 510);
            this.listView_Meds.TabIndex = 0;
            this.listView_Meds.UseCompatibleStateImageBehavior = false;
            // 
            // label_Search
            // 
            this.label_Search.AutoSize = true;
            this.label_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Search.Location = new System.Drawing.Point(15, 541);
            this.label_Search.Name = "label_Search";
            this.label_Search.Size = new System.Drawing.Size(128, 32);
            this.label_Search.TabIndex = 1;
            this.label_Search.Text = "Search :";
            // 
            // textBox1
            // 
            this.textBox1.AcceptsTab = true;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(149, 541);
            this.textBox1.MaxLength = 100;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 32);
            this.textBox1.TabIndex = 2;
            // 
            // panel_Home_Right
            // 
            this.panel_Home_Right.Controls.Add(this.PanelDetails_In_Home);
            this.panel_Home_Right.Controls.Add(this.PanelAddMeds_In_Home);
            this.panel_Home_Right.Controls.Add(this.button_Back);
            this.panel_Home_Right.Controls.Add(this.button_Add_Home);
            this.panel_Home_Right.Controls.Add(this.button_Details);
            this.panel_Home_Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Home_Right.Location = new System.Drawing.Point(343, 0);
            this.panel_Home_Right.Name = "panel_Home_Right";
            this.panel_Home_Right.Size = new System.Drawing.Size(415, 590);
            this.panel_Home_Right.TabIndex = 3;
            // 
            // button_Back
            // 
            this.button_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Back.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.button_Back.FlatAppearance.BorderSize = 0;
            this.button_Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button_Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.button_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Back.ForeColor = System.Drawing.Color.Salmon;
            this.button_Back.Image = global::Meds_App.Properties.Resources.LOGO_Arrow;
            this.button_Back.Location = new System.Drawing.Point(3, 12);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(51, 39);
            this.button_Back.TabIndex = 23;
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // button_Add_Home
            // 
            this.button_Add_Home.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button_Add_Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Add_Home.FlatAppearance.BorderSize = 0;
            this.button_Add_Home.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button_Add_Home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_Add_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Add_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Add_Home.Location = new System.Drawing.Point(98, 108);
            this.button_Add_Home.Name = "button_Add_Home";
            this.button_Add_Home.Size = new System.Drawing.Size(198, 102);
            this.button_Add_Home.TabIndex = 0;
            this.button_Add_Home.Text = "Add Med";
            this.button_Add_Home.UseVisualStyleBackColor = false;
            this.button_Add_Home.Click += new System.EventHandler(this.button_Add_Home_Click);
            // 
            // panel_Home_Left
            // 
            this.panel_Home_Left.Controls.Add(this.textBox1);
            this.panel_Home_Left.Controls.Add(this.label_Search);
            this.panel_Home_Left.Controls.Add(this.listView_Meds);
            this.panel_Home_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Home_Left.Location = new System.Drawing.Point(0, 0);
            this.panel_Home_Left.Name = "panel_Home_Left";
            this.panel_Home_Left.Size = new System.Drawing.Size(344, 590);
            this.panel_Home_Left.TabIndex = 4;
            // 
            // PanelAddMeds_In_Home
            // 
            this.PanelAddMeds_In_Home.Location = new System.Drawing.Point(0, 0);
            this.PanelAddMeds_In_Home.Name = "PanelAddMeds_In_Home";
            this.PanelAddMeds_In_Home.Size = new System.Drawing.Size(415, 590);
            this.PanelAddMeds_In_Home.TabIndex = 24;
            // 
            // button_Details
            // 
            this.button_Details.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button_Details.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Details.FlatAppearance.BorderSize = 0;
            this.button_Details.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button_Details.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_Details.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Details.Location = new System.Drawing.Point(98, 273);
            this.button_Details.Name = "button_Details";
            this.button_Details.Size = new System.Drawing.Size(198, 102);
            this.button_Details.TabIndex = 25;
            this.button_Details.Text = "Details";
            this.button_Details.UseVisualStyleBackColor = false;
            this.button_Details.Click += new System.EventHandler(this.button_Details_Click);
            // 
            // PanelDetails_In_Home
            // 
            this.PanelDetails_In_Home.BackColor = System.Drawing.Color.OldLace;
            this.PanelDetails_In_Home.Location = new System.Drawing.Point(0, 0);
            this.PanelDetails_In_Home.Name = "PanelDetails_In_Home";
            this.PanelDetails_In_Home.Size = new System.Drawing.Size(415, 590);
            this.PanelDetails_In_Home.TabIndex = 26;
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.OldLace;
            this.Controls.Add(this.panel_Home_Left);
            this.Controls.Add(this.panel_Home_Right);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(758, 590);
            this.panel_Home_Right.ResumeLayout(false);
            this.panel_Home_Left.ResumeLayout(false);
            this.panel_Home_Left.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_Meds;
        private System.Windows.Forms.Label label_Search;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel_Home_Right;
        private System.Windows.Forms.Panel panel_Home_Left;
        private System.Windows.Forms.Button button_Add_Home;
        private System.Windows.Forms.Button button_Back;
        private AddMeds PanelAddMeds_In_Home;
        private System.Windows.Forms.Button button_Details;
        private UserControls.Home.DetailsMeds PanelDetails_In_Home;
    }
}