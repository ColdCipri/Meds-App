namespace Meds_App.UserControls
{
    partial class ReportBug
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
            this.panel_full = new System.Windows.Forms.Panel();
            this.pictureBox_help = new System.Windows.Forms.PictureBox();
            this.button_Send = new System.Windows.Forms.Button();
            this.button_AddPicture = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.textBox_Message = new System.Windows.Forms.TextBox();
            this.label_Message = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label_Name = new System.Windows.Forms.Label();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.label_Email = new System.Windows.Forms.Label();
            this.label_Title = new System.Windows.Forms.Label();
            this.panel_full.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_help)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_full
            // 
            this.panel_full.Controls.Add(this.pictureBox_help);
            this.panel_full.Controls.Add(this.button_Send);
            this.panel_full.Controls.Add(this.button_AddPicture);
            this.panel_full.Controls.Add(this.pictureBox);
            this.panel_full.Controls.Add(this.textBox_Message);
            this.panel_full.Controls.Add(this.label_Message);
            this.panel_full.Controls.Add(this.textBox_Name);
            this.panel_full.Controls.Add(this.label_Name);
            this.panel_full.Controls.Add(this.textBox_Email);
            this.panel_full.Controls.Add(this.label_Email);
            this.panel_full.Controls.Add(this.label_Title);
            this.panel_full.Location = new System.Drawing.Point(0, 0);
            this.panel_full.Name = "panel_full";
            this.panel_full.Size = new System.Drawing.Size(758, 590);
            this.panel_full.TabIndex = 0;
            // 
            // pictureBox_help
            // 
            this.pictureBox_help.Cursor = System.Windows.Forms.Cursors.Help;
            this.pictureBox_help.Image = global::Meds_App.Properties.Resources.LOGO_Help;
            this.pictureBox_help.InitialImage = null;
            this.pictureBox_help.Location = new System.Drawing.Point(662, 29);
            this.pictureBox_help.Name = "pictureBox_help";
            this.pictureBox_help.Size = new System.Drawing.Size(63, 56);
            this.pictureBox_help.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_help.TabIndex = 43;
            this.pictureBox_help.TabStop = false;
            // 
            // button_Send
            // 
            this.button_Send.BackColor = System.Drawing.Color.Moccasin;
            this.button_Send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Send.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_Send.FlatAppearance.BorderSize = 0;
            this.button_Send.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button_Send.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_Send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Send.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Send.Location = new System.Drawing.Point(293, 455);
            this.button_Send.Name = "button_Send";
            this.button_Send.Size = new System.Drawing.Size(151, 81);
            this.button_Send.TabIndex = 42;
            this.button_Send.Text = "Send";
            this.button_Send.UseVisualStyleBackColor = false;
            this.button_Send.Click += new System.EventHandler(this.button_Report_Send_Click);
            // 
            // button_AddPicture
            // 
            this.button_AddPicture.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button_AddPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_AddPicture.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_AddPicture.FlatAppearance.BorderSize = 0;
            this.button_AddPicture.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button_AddPicture.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_AddPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AddPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AddPicture.Location = new System.Drawing.Point(498, 304);
            this.button_AddPicture.Name = "button_AddPicture";
            this.button_AddPicture.Size = new System.Drawing.Size(134, 46);
            this.button_AddPicture.TabIndex = 40;
            this.button_AddPicture.Text = "Add picture";
            this.button_AddPicture.UseVisualStyleBackColor = false;
            this.button_AddPicture.Click += new System.EventHandler(this.button_AddPicture_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(465, 110);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(221, 140);
            this.pictureBox.TabIndex = 20;
            this.pictureBox.TabStop = false;
            // 
            // textBox_Message
            // 
            this.textBox_Message.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Message.Location = new System.Drawing.Point(152, 261);
            this.textBox_Message.Multiline = true;
            this.textBox_Message.Name = "textBox_Message";
            this.textBox_Message.Size = new System.Drawing.Size(225, 106);
            this.textBox_Message.TabIndex = 18;
            // 
            // label_Message
            // 
            this.label_Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Message.Location = new System.Drawing.Point(23, 261);
            this.label_Message.Margin = new System.Windows.Forms.Padding(0);
            this.label_Message.Name = "label_Message";
            this.label_Message.Size = new System.Drawing.Size(126, 58);
            this.label_Message.TabIndex = 17;
            this.label_Message.Text = "Problem description*:";
            this.label_Message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_Name
            // 
            this.textBox_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Name.Location = new System.Drawing.Point(152, 185);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(146, 23);
            this.textBox_Name.TabIndex = 16;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.Location = new System.Drawing.Point(56, 182);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(70, 25);
            this.label_Name.TabIndex = 15;
            this.label_Name.Text = "Name:";
            this.label_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_Email
            // 
            this.textBox_Email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Email.Location = new System.Drawing.Point(152, 112);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(146, 23);
            this.textBox_Email.TabIndex = 14;
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Email.Location = new System.Drawing.Point(56, 110);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(74, 25);
            this.label_Email.TabIndex = 13;
            this.label_Email.Text = "Email*:";
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.Location = new System.Drawing.Point(253, 17);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(244, 42);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "Report a bug!";
            // 
            // ReportBug
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.OldLace;
            this.Controls.Add(this.panel_full);
            this.Name = "ReportBug";
            this.Size = new System.Drawing.Size(758, 590);
            this.panel_full.ResumeLayout(false);
            this.panel_full.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_help)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel_full;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.TextBox textBox_Message;
        private System.Windows.Forms.Label label_Message;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button button_AddPicture;
        private System.Windows.Forms.Button button_Send;
        private System.Windows.Forms.PictureBox pictureBox_help;
    }
}
