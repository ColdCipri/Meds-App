using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Meds_App.Model;
using System.IO;

namespace Meds_App.UserControls.Home
{
    public partial class DetailsMeds : UserControl
    {
        private string error, error_name, error_pieces, error_type,
            error_basesubst, error_basesubstq1, error_basesubstq2,
            error_description, successfully_updated, successfully_deleted,
            imgFile, success, imgLocation = "";
        private List<string> typeList =
            new List<string> { "Pill", "Cream", "Tea", "Spray", "Syrup",
                "Suppository", "Drops", "Gel", "Effervescent" };
        Med med = new Med();

        public DetailsMeds()
        {
            InitializeComponent();
        }

        public void Fill_Med(Med medExt)
        {
            med = medExt;
            textBox_Details_Name.Text = med.Name;

            numericUpDown_Details_Pieces.Value = med.Pieces;

            if (!med.Type.Equals(null))
            {

                switch (med.Type)
                {
                    case "Pill":
                        comboBox_Details_Type.SelectedIndex = 0;
                        break;
                    case "Cream":
                        comboBox_Details_Type.SelectedIndex = 1;
                        break;
                    case "Tea":
                        comboBox_Details_Type.SelectedIndex = 2;
                        break;
                    case "Spray":
                        comboBox_Details_Type.SelectedIndex = 3;
                        break;
                    case "Syrup":
                        comboBox_Details_Type.SelectedIndex = 4;
                        break;
                    case "Suppository":
                        comboBox_Details_Type.SelectedIndex = 5;
                        break;
                    case "Drops":
                        comboBox_Details_Type.SelectedIndex = 6;
                        break;
                    case "Gel":
                        comboBox_Details_Type.SelectedIndex = 7;
                        break;
                    case "Effervescent":
                        comboBox_Details_Type.SelectedIndex = 8;
                        break;
                }

            }

            dateTimePicker_Details_BestBefore.Value = med.BestBefore;

            textBox_Details_BaseSubstance.Text = med.BaseSubstance;

            if (!med.BaseSubstanceQuantity.Equals("null"))
            {
                numericUpDown_Details_BaseSubstanceQuantity.Value = int.Parse(med.BaseSubstanceQuantity.Substring(0, med.BaseSubstanceQuantity.IndexOf(' ')));
                var value = med.BaseSubstanceQuantity.Substring(med.BaseSubstanceQuantity.IndexOf(" ") + 1);
                switch (value)
                {
                    case "mg":
                        comboBox_Details_BaseSubstanceQuantity.SelectedItem = "mg";
                        break;
                    case "ml":
                        comboBox_Details_BaseSubstanceQuantity.SelectedItem = "ml";
                        break;
                    case "UI":
                        comboBox_Details_BaseSubstanceQuantity.SelectedItem = "UI";
                        break;
                    case "ug":
                        comboBox_Details_BaseSubstanceQuantity.SelectedItem = "ug";
                        break;
                }
            }

            textBox_Details_Description.Text = med.Description;

            try
            {
                pictureBox_Details.Image = Image.FromStream(new MemoryStream((byte[])med.Picture));
                pictureBox_Details.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch
            {
                pictureBox_Details.Image = null;
            }
        }

        private void button_Details_Update_Click(object sender, EventArgs e)
        {
            Med updatedMed = new Med();
            if (string.IsNullOrWhiteSpace(textBox_Details_Name.Text))
            {
                MessageBox.Show(error_name, error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(textBox_Details_BaseSubstance.Text))
            {
                MessageBox.Show(error_basesubst, error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(textBox_Details_Description.Text))
            {
                MessageBox.Show(error_description, error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBox_Details_Type.SelectedIndex.Equals(-1))
            {
                MessageBox.Show(error_type, error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBox_Details_BaseSubstanceQuantity.SelectedIndex.Equals(-1))
            {
                MessageBox.Show(error_basesubstq2, error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (numericUpDown_Details_Pieces.Value < 1)
            {
                MessageBox.Show(error_pieces, error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (numericUpDown_Details_BaseSubstanceQuantity.Value < 1)
            {
                MessageBox.Show(error_basesubstq1, error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                updatedMed.Name = textBox_Details_Name.Text;
                updatedMed.Pieces = int.Parse(numericUpDown_Details_Pieces.Value.ToString());
                updatedMed.Type = typeList[comboBox_Details_Type.SelectedIndex];
                updatedMed.BestBefore = dateTimePicker_Details_BestBefore.Value;
                updatedMed.BaseSubstance = textBox_Details_BaseSubstance.Text;
                updatedMed.BaseSubstanceQuantity = $"{numericUpDown_Details_BaseSubstanceQuantity.Value} {comboBox_Details_BaseSubstanceQuantity.SelectedItem}";
                updatedMed.Description = textBox_Details_Description.Text;


                if (imgLocation.Equals(""))
                {
                    updatedMed.Picture = med.Picture;
                }
                else
                {
                    byte[] image = null;
                    FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader binaryReader = new BinaryReader(stream);
                    image = binaryReader.ReadBytes((int)(stream.Length));

                    updatedMed.Picture = image;

                }
                MessageBox.Show($"{successfully_updated} {updatedMed.Name}!", success, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Http.PutMedAsync(updatedMed, med.Id);
            }
        }

        private void button_Details_Delete_Click(object sender, EventArgs e)
        {
            Http.DeleteMedAsync(med.Id);
            MessageBox.Show($"{successfully_deleted} {med.Name}!", success, MessageBoxButtons.OK, MessageBoxIcon.Information);
            clearUserInput();
        }

        private void clearUserInput()
        {
            textBox_Details_Name.Text = textBox_Details_BaseSubstance.Text = textBox_Details_Description.Text = "";
            comboBox_Details_BaseSubstanceQuantity.SelectedIndex = comboBox_Details_Type.SelectedIndex = -1;
            numericUpDown_Details_Pieces.Value = numericUpDown_Details_BaseSubstanceQuantity.Value = 1;
            dateTimePicker_Details_BestBefore.Value = DateTime.Now;
            pictureBox_Details.Image = null;
        }

        private void button_Details_AddPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = imgFile
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pictureBox_Details.ImageLocation = imgLocation;
                pictureBox_Details.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        public void setLanguageRo()
        {
            label_Details_Title.Font = new Font("Microsoft Sans Serif", 22);
            label_Details_Title.Text = Properties.Resources.Details_ro;
            label_Details_Name.Text = Properties.Resources.Name_ro;
            label_Details_Pieces.Text = Properties.Resources.Pieces_ro;
            label_Details_Type.Text = Properties.Resources.Type_ro;
            label_Details_BestBefore.Text = Properties.Resources.BestBefore_ro;
            label_Details_BaseSubstance.Text = Properties.Resources.BaseSubstance_ro;
            label_Details_BaseSubstanceQuantity.Text = Properties.Resources.BaseSubstanceQuantity_ro;
            label_Details_Description.Text = Properties.Resources.Description_ro;
            button_Details_AddPicture.Text = Properties.Resources.AddPicture_ro;
            button_Details_Delete.Text = Properties.Resources.Delete_ro;
            button_Details_Update.Text = Properties.Resources.Update_ro;
            imgFile = Properties.Resources.ImageFiles_ro;
            success = Properties.Resources.Success_ro;
            successfully_updated = Properties.Resources.SuccessfullyUpdated_ro;
            successfully_deleted = Properties.Resources.SuccessfullyDeleted_ro;
            setTypeRo();
            setErrorsRo();
        }

        public void setLanguageEng()
        {
            label_Details_Title.Font = new Font("Microsoft Sans Serif", 22);
            label_Details_Title.Text = Properties.Resources.Details_eng;
            label_Details_Name.Text = Properties.Resources.Name_eng;
            label_Details_Pieces.Text = Properties.Resources.Pieces_eng;
            label_Details_Type.Text = Properties.Resources.Type_eng;
            label_Details_BestBefore.Text = Properties.Resources.BestBefore_eng;
            label_Details_BaseSubstance.Text = Properties.Resources.BaseSubstance_eng;
            label_Details_BaseSubstanceQuantity.Text = Properties.Resources.BaseSubstanceQuantity_eng;
            label_Details_Description.Text = Properties.Resources.Description_eng;
            button_Details_AddPicture.Text = Properties.Resources.AddPicture_eng;
            button_Details_Delete.Text = Properties.Resources.Delete_eng;
            button_Details_Update.Text = Properties.Resources.Update_eng;
            imgFile = Properties.Resources.ImageFiles_eng;
            success = Properties.Resources.Success_eng;
            successfully_updated = Properties.Resources.SuccessfullyUpdated_eng;
            successfully_deleted = Properties.Resources.SuccessfullyDeleted_eng;
            setTypeEng();
            setErrorsEng();
        }

        private void setErrorsRo()
        {
            error = Properties.Resources.Error_ro;
            error_name = Properties.Resources.ErrorName_ro;
            error_pieces = Properties.Resources.ErrorPieces_ro;
            error_type = Properties.Resources.ErrorType_ro;
            error_basesubst = Properties.Resources.ErrorBaseSubst_ro;
            error_basesubstq1 = Properties.Resources.ErrorBaseSubstQ1_ro;
            error_basesubstq2 = Properties.Resources.ErrorBaseSubstQ2_ro;
            error_description = Properties.Resources.ErrorDescription_ro;
            imgFile = Properties.Resources.ImageFiles_ro;
        }

        private void setErrorsEng()
        {
            error = Properties.Resources.Error_eng;
            error_name = Properties.Resources.ErrorName_eng;
            error_pieces = Properties.Resources.ErrorPieces_eng;
            error_type = Properties.Resources.ErrorType_eng;
            error_basesubst = Properties.Resources.ErrorBaseSubst_eng;
            error_basesubstq1 = Properties.Resources.ErrorBaseSubstQ1_eng;
            error_basesubstq2 = Properties.Resources.ErrorBaseSubstQ2_eng;
            error_description = Properties.Resources.ErrorDescription_eng;
            imgFile = Properties.Resources.ImageFiles_eng;
        }

        private void setTypeRo()
        {
            var selectedIndex = comboBox_Details_Type.SelectedIndex;
            comboBox_Details_Type.Items.Clear();
            comboBox_Details_Type.Items.Add(Properties.Resources.TypePill_ro);
            comboBox_Details_Type.Items.Add(Properties.Resources.TypeCream_ro);
            comboBox_Details_Type.Items.Add(Properties.Resources.TypeTea_ro);
            comboBox_Details_Type.Items.Add(Properties.Resources.TypeSpray);
            comboBox_Details_Type.Items.Add(Properties.Resources.TypeSyrup_ro);
            comboBox_Details_Type.Items.Add(Properties.Resources.TypeSuppository_ro);
            comboBox_Details_Type.Items.Add(Properties.Resources.TypeDrops_ro);
            comboBox_Details_Type.Items.Add(Properties.Resources.TypeGel);
            comboBox_Details_Type.Items.Add(Properties.Resources.TypeEffervescent_ro);
            comboBox_Details_Type.SelectedIndex = selectedIndex;
        }

        private void setTypeEng()
        {
            var selectedIndex = comboBox_Details_Type.SelectedIndex;
            comboBox_Details_Type.Items.Clear();
            comboBox_Details_Type.Items.Add(Properties.Resources.TypePill_eng);
            comboBox_Details_Type.Items.Add(Properties.Resources.TypeCream_eng);
            comboBox_Details_Type.Items.Add(Properties.Resources.TypeTea_eng);
            comboBox_Details_Type.Items.Add(Properties.Resources.TypeSpray);
            comboBox_Details_Type.Items.Add(Properties.Resources.TypeSyrup_eng);
            comboBox_Details_Type.Items.Add(Properties.Resources.TypeSuppository_eng);
            comboBox_Details_Type.Items.Add(Properties.Resources.TypeDrops_eng);
            comboBox_Details_Type.Items.Add(Properties.Resources.TypeGel);
            comboBox_Details_Type.Items.Add(Properties.Resources.TypeEffervescent_eng);
            comboBox_Details_Type.SelectedIndex = selectedIndex;
        }
    }
}
