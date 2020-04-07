using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Meds_App.Model;
using System.IO;

namespace Meds_App.UserControls.Home
{
    public partial class DetailsMeds : UserControl
    {
        string imgLocation = "";
        Med med = new Med();
        public DetailsMeds()
        {
            InitializeComponent();
        }

        public void fillDetails(Med medExt)
        {
            med = medExt;
            textBox_Details_Name.Text = med.Name;

            numericUpDown_Details_Pieces.Value = med.Pieces;

            if (!med.Type.Equals(null))
            {

                switch (med.Type)
                {
                    case "Pill":
                        comboBox_Details_Type.SelectedItem = "Pill";
                        break;
                    case "Cream":
                        comboBox_Details_Type.SelectedItem = "Cream";
                        break;
                    case "Tea":
                        comboBox_Details_Type.SelectedItem = "Tea";
                        break;
                    case "Spray":
                        comboBox_Details_Type.SelectedItem = "Spray";
                        break;
                    case "Syrup":
                        comboBox_Details_Type.SelectedItem = "Syrup";
                        break;
                    case "Suppository":
                        comboBox_Details_Type.SelectedItem = "Suppository";
                        break;
                    case "Drops":
                        comboBox_Details_Type.SelectedItem = "Drops";
                        break;
                    case "Gel":
                        comboBox_Details_Type.SelectedItem = "Gel";
                        break;
                    case "Effervescent":
                        comboBox_Details_Type.SelectedItem = "Effervescent";
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
            updatedMed.Name = textBox_Details_Name.Text;
            updatedMed.Pieces = int.Parse(numericUpDown_Details_Pieces.Value.ToString());
            updatedMed.Type = comboBox_Details_Type.SelectedItem.ToString();
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
            MessageBox.Show($"Succesfully updated {updatedMed.Name}!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Http.PutMedAsync(updatedMed, med.Id);
        }

        private void button_Details_Delete_Click(object sender, EventArgs e)
        {
            Http.DeleteMedAsync(med.Id);
            MessageBox.Show($"Succesfully deleted {med.Name}!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                Filter = "Image files(*.jpg;*.png)|*.jpg;*.png|All files(*.*)|*.*"
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
        }
    }
}
