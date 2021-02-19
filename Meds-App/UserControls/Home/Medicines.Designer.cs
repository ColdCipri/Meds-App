namespace Meds_App
{
    partial class Medicines
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
            this.panel_AddMeds = new System.Windows.Forms.Panel();
            this.checkBox_BaseSubst = new System.Windows.Forms.CheckBox();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.button_AddPicture = new System.Windows.Forms.Button();
            this.textBox_Description = new System.Windows.Forms.TextBox();
            this.label_Description = new System.Windows.Forms.Label();
            this.comboBox_BaseSubstanceQuantity = new System.Windows.Forms.ComboBox();
            this.numericUpDown_BaseSubstanceQuantity = new System.Windows.Forms.NumericUpDown();
            this.label_BestBefore = new System.Windows.Forms.Label();
            this.label_BaseSubstanceQuantity = new System.Windows.Forms.Label();
            this.textBox_BaseSubstance = new System.Windows.Forms.TextBox();
            this.label_BaseSubstance = new System.Windows.Forms.Label();
            this.dateTimePicker_BestBefore = new System.Windows.Forms.DateTimePicker();
            this.comboBox_Type = new System.Windows.Forms.ComboBox();
            this.label_Type = new System.Windows.Forms.Label();
            this.numericUpDown_Pieces = new System.Windows.Forms.NumericUpDown();
            this.label_Pieces = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Title_Add = new System.Windows.Forms.Label();
            this.label_Title_Details = new System.Windows.Forms.Label();
            this.panel_AddMeds.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_BaseSubstanceQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Pieces)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_AddMeds
            // 
            this.panel_AddMeds.BackColor = System.Drawing.Color.OldLace;
            this.panel_AddMeds.Controls.Add(this.checkBox_BaseSubst);
            this.panel_AddMeds.Controls.Add(this.button_Delete);
            this.panel_AddMeds.Controls.Add(this.button_Update);
            this.panel_AddMeds.Controls.Add(this.button_Save);
            this.panel_AddMeds.Controls.Add(this.pictureBox);
            this.panel_AddMeds.Controls.Add(this.button_AddPicture);
            this.panel_AddMeds.Controls.Add(this.textBox_Description);
            this.panel_AddMeds.Controls.Add(this.label_Description);
            this.panel_AddMeds.Controls.Add(this.comboBox_BaseSubstanceQuantity);
            this.panel_AddMeds.Controls.Add(this.numericUpDown_BaseSubstanceQuantity);
            this.panel_AddMeds.Controls.Add(this.label_BestBefore);
            this.panel_AddMeds.Controls.Add(this.label_BaseSubstanceQuantity);
            this.panel_AddMeds.Controls.Add(this.textBox_BaseSubstance);
            this.panel_AddMeds.Controls.Add(this.label_BaseSubstance);
            this.panel_AddMeds.Controls.Add(this.dateTimePicker_BestBefore);
            this.panel_AddMeds.Controls.Add(this.comboBox_Type);
            this.panel_AddMeds.Controls.Add(this.label_Type);
            this.panel_AddMeds.Controls.Add(this.numericUpDown_Pieces);
            this.panel_AddMeds.Controls.Add(this.label_Pieces);
            this.panel_AddMeds.Controls.Add(this.textBox_Name);
            this.panel_AddMeds.Controls.Add(this.label_Name);
            this.panel_AddMeds.Controls.Add(this.label_Title_Add);
            this.panel_AddMeds.Controls.Add(this.label_Title_Details);
            this.panel_AddMeds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_AddMeds.Location = new System.Drawing.Point(0, 0);
            this.panel_AddMeds.Name = "panel_AddMeds";
            this.panel_AddMeds.Size = new System.Drawing.Size(408, 590);
            this.panel_AddMeds.TabIndex = 0;
            // 
            // checkBox_BaseSubst
            // 
            this.checkBox_BaseSubst.AutoSize = true;
            this.checkBox_BaseSubst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_BaseSubst.Location = new System.Drawing.Point(67, 249);
            this.checkBox_BaseSubst.Name = "checkBox_BaseSubst";
            this.checkBox_BaseSubst.Size = new System.Drawing.Size(244, 29);
            this.checkBox_BaseSubst.TabIndex = 46;
            this.checkBox_BaseSubst.Text = "Without base substance";
            this.checkBox_BaseSubst.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_BaseSubst.UseVisualStyleBackColor = true;
            this.checkBox_BaseSubst.CheckedChanged += new System.EventHandler(this.checkBox_BaseSubst_CheckedChanged);
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.Moccasin;
            this.button_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_Delete.FlatAppearance.BorderSize = 0;
            this.button_Delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button_Delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delete.Location = new System.Drawing.Point(207, 540);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(134, 46);
            this.button_Delete.TabIndex = 44;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Update
            // 
            this.button_Update.BackColor = System.Drawing.Color.Moccasin;
            this.button_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Update.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_Update.FlatAppearance.BorderSize = 0;
            this.button_Update.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button_Update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Update.Location = new System.Drawing.Point(28, 540);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(134, 46);
            this.button_Update.TabIndex = 43;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = false;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.Color.Moccasin;
            this.button_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_Save.FlatAppearance.BorderSize = 0;
            this.button_Save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button_Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Save.Location = new System.Drawing.Point(128, 540);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(134, 46);
            this.button_Save.TabIndex = 21;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(34, 440);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(123, 87);
            this.pictureBox.TabIndex = 20;
            this.pictureBox.TabStop = false;
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
            this.button_AddPicture.Location = new System.Drawing.Point(186, 464);
            this.button_AddPicture.Name = "button_AddPicture";
            this.button_AddPicture.Size = new System.Drawing.Size(134, 46);
            this.button_AddPicture.TabIndex = 19;
            this.button_AddPicture.Text = "Add Picture";
            this.button_AddPicture.UseVisualStyleBackColor = false;
            this.button_AddPicture.Click += new System.EventHandler(this.button_AddPicture_Click);
            // 
            // textBox_Description
            // 
            this.textBox_Description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Description.Location = new System.Drawing.Point(174, 390);
            this.textBox_Description.Multiline = true;
            this.textBox_Description.Name = "textBox_Description";
            this.textBox_Description.Size = new System.Drawing.Size(183, 53);
            this.textBox_Description.TabIndex = 17;
            // 
            // label_Description
            // 
            this.label_Description.AutoSize = true;
            this.label_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Description.Location = new System.Drawing.Point(42, 397);
            this.label_Description.Name = "label_Description";
            this.label_Description.Size = new System.Drawing.Size(115, 25);
            this.label_Description.TabIndex = 16;
            this.label_Description.Text = "Description:";
            // 
            // comboBox_BaseSubstanceQuantity
            // 
            this.comboBox_BaseSubstanceQuantity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_BaseSubstanceQuantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_BaseSubstanceQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_BaseSubstanceQuantity.FormattingEnabled = true;
            this.comboBox_BaseSubstanceQuantity.Items.AddRange(new object[] {
            "mg",
            "ml",
            "ug",
            "UI"});
            this.comboBox_BaseSubstanceQuantity.Location = new System.Drawing.Point(240, 346);
            this.comboBox_BaseSubstanceQuantity.Name = "comboBox_BaseSubstanceQuantity";
            this.comboBox_BaseSubstanceQuantity.Size = new System.Drawing.Size(80, 30);
            this.comboBox_BaseSubstanceQuantity.TabIndex = 15;
            // 
            // numericUpDown_BaseSubstanceQuantity
            // 
            this.numericUpDown_BaseSubstanceQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown_BaseSubstanceQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_BaseSubstanceQuantity.Location = new System.Drawing.Point(174, 346);
            this.numericUpDown_BaseSubstanceQuantity.Name = "numericUpDown_BaseSubstanceQuantity";
            this.numericUpDown_BaseSubstanceQuantity.Size = new System.Drawing.Size(60, 24);
            this.numericUpDown_BaseSubstanceQuantity.TabIndex = 14;
            this.numericUpDown_BaseSubstanceQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label_BestBefore
            // 
            this.label_BestBefore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BestBefore.Location = new System.Drawing.Point(61, 179);
            this.label_BestBefore.Name = "label_BestBefore";
            this.label_BestBefore.Size = new System.Drawing.Size(87, 55);
            this.label_BestBefore.TabIndex = 9;
            this.label_BestBefore.Text = "Best before:";
            this.label_BestBefore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_BaseSubstanceQuantity
            // 
            this.label_BaseSubstanceQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BaseSubstanceQuantity.Location = new System.Drawing.Point(21, 319);
            this.label_BaseSubstanceQuantity.Name = "label_BaseSubstanceQuantity";
            this.label_BaseSubstanceQuantity.Size = new System.Drawing.Size(162, 78);
            this.label_BaseSubstanceQuantity.TabIndex = 13;
            this.label_BaseSubstanceQuantity.Text = "Base substance quantity:";
            this.label_BaseSubstanceQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_BaseSubstance
            // 
            this.textBox_BaseSubstance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_BaseSubstance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_BaseSubstance.Location = new System.Drawing.Point(174, 284);
            this.textBox_BaseSubstance.Multiline = true;
            this.textBox_BaseSubstance.Name = "textBox_BaseSubstance";
            this.textBox_BaseSubstance.Size = new System.Drawing.Size(146, 25);
            this.textBox_BaseSubstance.TabIndex = 12;
            // 
            // label_BaseSubstance
            // 
            this.label_BaseSubstance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_BaseSubstance.Location = new System.Drawing.Point(29, 264);
            this.label_BaseSubstance.Name = "label_BaseSubstance";
            this.label_BaseSubstance.Size = new System.Drawing.Size(139, 71);
            this.label_BaseSubstance.TabIndex = 11;
            this.label_BaseSubstance.Text = "Base substance:";
            this.label_BaseSubstance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker_BestBefore
            // 
            this.dateTimePicker_BestBefore.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_BestBefore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_BestBefore.Location = new System.Drawing.Point(176, 196);
            this.dateTimePicker_BestBefore.Name = "dateTimePicker_BestBefore";
            this.dateTimePicker_BestBefore.Size = new System.Drawing.Size(146, 23);
            this.dateTimePicker_BestBefore.TabIndex = 10;
            // 
            // comboBox_Type
            // 
            this.comboBox_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Type.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Type.FormattingEnabled = true;
            this.comboBox_Type.Items.AddRange(new object[] {
            "Pill",
            "Cream",
            "Tea",
            "Spray",
            "Syrup",
            "Suppository",
            "Drops",
            "Gel",
            "Effervescent"});
            this.comboBox_Type.Location = new System.Drawing.Point(176, 135);
            this.comboBox_Type.Name = "comboBox_Type";
            this.comboBox_Type.Size = new System.Drawing.Size(146, 30);
            this.comboBox_Type.TabIndex = 8;
            // 
            // label_Type
            // 
            this.label_Type.AutoSize = true;
            this.label_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Type.Location = new System.Drawing.Point(71, 136);
            this.label_Type.Name = "label_Type";
            this.label_Type.Size = new System.Drawing.Size(63, 25);
            this.label_Type.TabIndex = 6;
            this.label_Type.Text = "Type:";
            // 
            // numericUpDown_Pieces
            // 
            this.numericUpDown_Pieces.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown_Pieces.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_Pieces.Location = new System.Drawing.Point(176, 92);
            this.numericUpDown_Pieces.Name = "numericUpDown_Pieces";
            this.numericUpDown_Pieces.Size = new System.Drawing.Size(60, 24);
            this.numericUpDown_Pieces.TabIndex = 5;
            this.numericUpDown_Pieces.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label_Pieces
            // 
            this.label_Pieces.AutoSize = true;
            this.label_Pieces.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Pieces.Location = new System.Drawing.Point(71, 89);
            this.label_Pieces.Name = "label_Pieces";
            this.label_Pieces.Size = new System.Drawing.Size(77, 25);
            this.label_Pieces.TabIndex = 3;
            this.label_Pieces.Text = "Pieces:";
            // 
            // textBox_Name
            // 
            this.textBox_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Name.Location = new System.Drawing.Point(176, 49);
            this.textBox_Name.Multiline = true;
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(146, 25);
            this.textBox_Name.TabIndex = 2;
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.Location = new System.Drawing.Point(71, 49);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(70, 25);
            this.label_Name.TabIndex = 1;
            this.label_Name.Text = "Name:";
            // 
            // label_Title_Add
            // 
            this.label_Title_Add.AutoSize = true;
            this.label_Title_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title_Add.Location = new System.Drawing.Point(59, 5);
            this.label_Title_Add.Name = "label_Title_Add";
            this.label_Title_Add.Size = new System.Drawing.Size(282, 44);
            this.label_Title_Add.TabIndex = 0;
            this.label_Title_Add.Text = "Add a new med";
            // 
            // label_Title_Details
            // 
            this.label_Title_Details.AutoSize = true;
            this.label_Title_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title_Details.Location = new System.Drawing.Point(59, 5);
            this.label_Title_Details.Name = "label_Title_Details";
            this.label_Title_Details.Size = new System.Drawing.Size(282, 44);
            this.label_Title_Details.TabIndex = 45;
            this.label_Title_Details.Text = "Add a new med";
            // 
            // Medicines
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel_AddMeds);
            this.Name = "Medicines";
            this.Size = new System.Drawing.Size(408, 590);
            this.panel_AddMeds.ResumeLayout(false);
            this.panel_AddMeds.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_BaseSubstanceQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Pieces)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel_AddMeds;
        private System.Windows.Forms.Label label_Title_Add;
        private System.Windows.Forms.NumericUpDown numericUpDown_Pieces;
        private System.Windows.Forms.Label label_Pieces;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Type;
        private System.Windows.Forms.TextBox textBox_Description;
        private System.Windows.Forms.Label label_Description;
        private System.Windows.Forms.ComboBox comboBox_BaseSubstanceQuantity;
        private System.Windows.Forms.NumericUpDown numericUpDown_BaseSubstanceQuantity;
        private System.Windows.Forms.Label label_BestBefore;
        private System.Windows.Forms.Label label_BaseSubstanceQuantity;
        private System.Windows.Forms.TextBox textBox_BaseSubstance;
        private System.Windows.Forms.Label label_BaseSubstance;
        private System.Windows.Forms.DateTimePicker dateTimePicker_BestBefore;
        private System.Windows.Forms.ComboBox comboBox_Type;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button button_AddPicture;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Label label_Title_Details;
        private System.Windows.Forms.CheckBox checkBox_BaseSubst;
    }
}
