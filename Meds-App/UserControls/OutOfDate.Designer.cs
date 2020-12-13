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
            this.listBox_OutOfDate = new System.Windows.Forms.ListBox();
            this.dateTimePicker_OutOfDate = new System.Windows.Forms.DateTimePicker();
            this.panel_OutOfDate_Right = new System.Windows.Forms.Panel();
            this.button_OutOfDate_Back = new System.Windows.Forms.Button();
            this.PanelMedicines_In_OutOfDate = new Meds_App.Medicines();
            this.button_OutOfDate_Details = new System.Windows.Forms.Button();
            this.panel_OutOfDate.SuspendLayout();
            this.panel_OutOfDate_Right.SuspendLayout();
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
            this.panel_OutOfDate.Size = new System.Drawing.Size(355, 590);
            this.panel_OutOfDate.TabIndex = 0;
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
            this.listBox_OutOfDate.SelectedIndexChanged += new System.EventHandler(this.Listbox_OutOfDate_SelectedIndexChanged);
            // 
            // dateTimePicker_OutOfDate
            // 
            this.dateTimePicker_OutOfDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_OutOfDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_OutOfDate.Location = new System.Drawing.Point(17, 21);
            this.dateTimePicker_OutOfDate.Name = "dateTimePicker_OutOfDate";
            this.dateTimePicker_OutOfDate.Size = new System.Drawing.Size(238, 38);
            this.dateTimePicker_OutOfDate.TabIndex = 0;
            this.dateTimePicker_OutOfDate.ValueChanged += new System.EventHandler(this.DateTimePicker_OutOfDate_ValueChanged);
            // 
            // panel_OutOfDate_Right
            // 
            this.panel_OutOfDate_Right.Controls.Add(this.button_OutOfDate_Back);
            this.panel_OutOfDate_Right.Controls.Add(this.PanelMedicines_In_OutOfDate);
            this.panel_OutOfDate_Right.Controls.Add(this.button_OutOfDate_Details);
            this.panel_OutOfDate_Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_OutOfDate_Right.Location = new System.Drawing.Point(350, 0);
            this.panel_OutOfDate_Right.Name = "panel_OutOfDate_Right";
            this.panel_OutOfDate_Right.Size = new System.Drawing.Size(408, 590);
            this.panel_OutOfDate_Right.TabIndex = 1;
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
            this.button_OutOfDate_Back.Click += new System.EventHandler(this.Button_OutOfDate_Back_Click);
            // 
            // PanelMedicines_In_OutOfDate
            // 
            this.PanelMedicines_In_OutOfDate.Location = new System.Drawing.Point(0, 0);
            this.PanelMedicines_In_OutOfDate.Name = "PanelMedicines_In_OutOfDate";
            this.PanelMedicines_In_OutOfDate.Size = new System.Drawing.Size(407, 589);
            this.PanelMedicines_In_OutOfDate.TabIndex = 28;
            // 
            // button_OutOfDate_Details
            // 
            this.button_OutOfDate_Details.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button_OutOfDate_Details.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_OutOfDate_Details.FlatAppearance.BorderSize = 0;
            this.button_OutOfDate_Details.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button_OutOfDate_Details.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_OutOfDate_Details.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_OutOfDate_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_OutOfDate_Details.Location = new System.Drawing.Point(87, 246);
            this.button_OutOfDate_Details.Name = "button_OutOfDate_Details";
            this.button_OutOfDate_Details.Size = new System.Drawing.Size(198, 102);
            this.button_OutOfDate_Details.TabIndex = 26;
            this.button_OutOfDate_Details.Text = "Details";
            this.button_OutOfDate_Details.UseVisualStyleBackColor = false;
            this.button_OutOfDate_Details.Click += new System.EventHandler(this.Button_OutOfDate_Details_Click);
            // 
            // OutOfDate
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.OldLace;
            this.Controls.Add(this.panel_OutOfDate_Right);
            this.Controls.Add(this.panel_OutOfDate);
            this.Name = "OutOfDate";
            this.Size = new System.Drawing.Size(758, 590);
            this.Load += new System.EventHandler(this.OutOfDate_Load);
            this.panel_OutOfDate.ResumeLayout(false);
            this.panel_OutOfDate_Right.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_OutOfDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_OutOfDate;
        private System.Windows.Forms.Panel panel_OutOfDate_Right;
        private System.Windows.Forms.Button button_OutOfDate_Details;
        private System.Windows.Forms.ListBox listBox_OutOfDate;
        private System.Windows.Forms.Button button_OutOfDate_Back;
        private Medicines PanelMedicines_In_OutOfDate;
    }
}
