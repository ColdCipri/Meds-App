namespace Meds_App.UserControls
{
    partial class OutOfDate
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
            this.panel_OutOfDate = new System.Windows.Forms.Panel();
            this.dateTimePicker_OutOfDate = new System.Windows.Forms.DateTimePicker();
            this.panel_Right = new System.Windows.Forms.Panel();
            this.button_OutOfDate_details = new System.Windows.Forms.Button();
            this.listBox_OutOfDate = new System.Windows.Forms.ListBox();
            this.button_OutOfDate_Back = new System.Windows.Forms.Button();
            this.PanelDetailsMeds_In_OutOfDate = new Meds_App.UserControls.Home.DetailsMeds();
            this.panel_OutOfDate.SuspendLayout();
            this.panel_Right.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_OutOfDate
            // 
            this.panel_OutOfDate.BackColor = System.Drawing.Color.OldLace;
            this.panel_OutOfDate.Controls.Add(this.listBox_OutOfDate);
            this.panel_OutOfDate.Controls.Add(this.dateTimePicker_OutOfDate);
            this.panel_OutOfDate.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_OutOfDate.Location = new System.Drawing.Point(0, 0);
            this.panel_OutOfDate.Name = "panel_OutOfDate";
            this.panel_OutOfDate.Size = new System.Drawing.Size(344, 590);
            this.panel_OutOfDate.TabIndex = 0;
            // 
            // dateTimePicker_OutOfDate
            // 
            this.dateTimePicker_OutOfDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_OutOfDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_OutOfDate.Location = new System.Drawing.Point(17, 21);
            this.dateTimePicker_OutOfDate.Name = "dateTimePicker_OutOfDate";
            this.dateTimePicker_OutOfDate.Size = new System.Drawing.Size(238, 38);
            this.dateTimePicker_OutOfDate.TabIndex = 0;
            this.dateTimePicker_OutOfDate.ValueChanged += new System.EventHandler(this.dateTimePicker_OutOfDate_ValueChanged);
            // 
            // panel_Right
            // 
            this.panel_Right.Controls.Add(this.PanelDetailsMeds_In_OutOfDate);
            this.panel_Right.Controls.Add(this.button_OutOfDate_Back);
            this.panel_Right.Controls.Add(this.button_OutOfDate_details);
            this.panel_Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Right.Location = new System.Drawing.Point(350, 0);
            this.panel_Right.Name = "panel_Right";
            this.panel_Right.Size = new System.Drawing.Size(408, 590);
            this.panel_Right.TabIndex = 1;
            // 
            // button_OutOfDate_details
            // 
            this.button_OutOfDate_details.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button_OutOfDate_details.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_OutOfDate_details.FlatAppearance.BorderSize = 0;
            this.button_OutOfDate_details.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button_OutOfDate_details.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_OutOfDate_details.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_OutOfDate_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_OutOfDate_details.Location = new System.Drawing.Point(87, 246);
            this.button_OutOfDate_details.Name = "button_OutOfDate_details";
            this.button_OutOfDate_details.Size = new System.Drawing.Size(198, 102);
            this.button_OutOfDate_details.TabIndex = 26;
            this.button_OutOfDate_details.Text = "Details";
            this.button_OutOfDate_details.UseVisualStyleBackColor = false;
            this.button_OutOfDate_details.Click += new System.EventHandler(this.button_OutOfDate_details_Click);
            // 
            // listBox_OutOfDate
            // 
            this.listBox_OutOfDate.BackColor = System.Drawing.Color.PapayaWhip;
            this.listBox_OutOfDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_OutOfDate.FormattingEnabled = true;
            this.listBox_OutOfDate.ItemHeight = 38;
            this.listBox_OutOfDate.Location = new System.Drawing.Point(17, 92);
            this.listBox_OutOfDate.Name = "listBox_OutOfDate";
            this.listBox_OutOfDate.Size = new System.Drawing.Size(318, 460);
            this.listBox_OutOfDate.TabIndex = 1;
            this.listBox_OutOfDate.SelectedIndexChanged += new System.EventHandler(this.listBox_OutOfDate_SelectedIndexChanged);
            // 
            // button_OutOfDate_Back
            // 
            this.button_OutOfDate_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_OutOfDate_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_OutOfDate_Back.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.button_OutOfDate_Back.FlatAppearance.BorderSize = 0;
            this.button_OutOfDate_Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button_OutOfDate_Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.button_OutOfDate_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_OutOfDate_Back.ForeColor = System.Drawing.Color.Salmon;
            this.button_OutOfDate_Back.Image = global::Meds_App.Properties.Resources.LOGO_Arrow;
            this.button_OutOfDate_Back.Location = new System.Drawing.Point(3, 20);
            this.button_OutOfDate_Back.Name = "button_OutOfDate_Back";
            this.button_OutOfDate_Back.Size = new System.Drawing.Size(51, 39);
            this.button_OutOfDate_Back.TabIndex = 27;
            this.button_OutOfDate_Back.UseVisualStyleBackColor = true;
            this.button_OutOfDate_Back.Click += new System.EventHandler(this.button_OutOfDate_Back_Click);
            // 
            // PanelDetailsMeds_In_OutOfDate
            // 
            this.PanelDetailsMeds_In_OutOfDate.BackColor = System.Drawing.Color.OldLace;
            this.PanelDetailsMeds_In_OutOfDate.Location = new System.Drawing.Point(0, 0);
            this.PanelDetailsMeds_In_OutOfDate.Name = "PanelDetailsMeds_In_OutOfDate";
            this.PanelDetailsMeds_In_OutOfDate.Size = new System.Drawing.Size(408, 590);
            this.PanelDetailsMeds_In_OutOfDate.TabIndex = 28;
            // 
            // OutOfDate
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.OldLace;
            this.Controls.Add(this.panel_Right);
            this.Controls.Add(this.panel_OutOfDate);
            this.Name = "OutOfDate";
            this.Size = new System.Drawing.Size(758, 590);
            this.Load += new System.EventHandler(this.OutOfDate_Load);
            this.panel_OutOfDate.ResumeLayout(false);
            this.panel_Right.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_OutOfDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_OutOfDate;
        private System.Windows.Forms.Panel panel_Right;
        private System.Windows.Forms.Button button_OutOfDate_details;
        private System.Windows.Forms.ListBox listBox_OutOfDate;
        private System.Windows.Forms.Button button_OutOfDate_Back;
        private Home.DetailsMeds PanelDetailsMeds_In_OutOfDate;
    }
}
