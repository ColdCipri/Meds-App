using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Meds_App.Model;

namespace Meds_App
{
    public partial class AddMeds : UserControl
    {
        private string imgLocation = "", imgFile, error, error_name,
            error_pieces, error_type, error_basesubst, error_basesubstq1,
            error_basesubstq2, error_description, successfully_added,
            med_added, failed_to_add;
        private List<string> typeList = 
            new List<string> { "Pill", "Cream", "Tea", "Spray", "Syrup", 
                "Suppository", "Drops", "Gel", "Effervescent" };

        public AddMeds()
        {
            InitializeComponent();
            comboBox_Add_Type.SelectedIndex = 0;
            comboBox_Add_BaseSubstanceQuantity.SelectedIndex = 0;
        }

        private void button_Add_Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_Add_Name.Text))
            {
                MessageBox.Show(error_name, error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(textBox_Add_BaseSubstance.Text))
            {
                MessageBox.Show(error_basesubst, error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(textBox_Add_Description.Text))
            {
                MessageBox.Show(error_description, error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBox_Add_Type.SelectedIndex.Equals(-1))
            {
                MessageBox.Show(error_type, error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBox_Add_BaseSubstanceQuantity.SelectedIndex.Equals(-1))
            {
                MessageBox.Show(error_basesubstq2, error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (numericUpDown_Add_Pieces.Value < 1)
            {
                MessageBox.Show(error_pieces, error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (numericUpDown_Add_BaseSubstanceQuantity.Value < 1)
            {
                MessageBox.Show(error_basesubstq1, error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var name = textBox_Add_Name.Text.ToString();
                int pieces = int.Parse(numericUpDown_Add_Pieces.Value.ToString());
                var type = typeList[comboBox_Add_Type.SelectedIndex];
                var best_before = dateTimePicker_Add_BestBefore.Value;
                var base_substance = textBox_Add_BaseSubstance.Text.ToString();
                var base_substance_quantity = $"{numericUpDown_Add_BaseSubstanceQuantity.Value} {comboBox_Add_BaseSubstanceQuantity.SelectedItem.ToString()}";
                var description = textBox_Add_Description.Text.ToString();
                if (!imgLocation.Equals(""))
                {
                    byte[] image = null;
                    FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader binaryReader = new BinaryReader(stream);
                    image = binaryReader.ReadBytes((int)(stream.Length));

                    Med med = new Med(name, pieces, type, best_before, base_substance, base_substance_quantity, description, image);

                    bool response = true;//needs to be modified 
                    addMed(med);
                    if (response)
                    {
                        MessageBox.Show($"{med.Name} {successfully_added}", med_added, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearUserInput();
                    }
                    else
                    {
                        MessageBox.Show($"{med.Name} {failed_to_add}", error, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    Med med = new Med(name, pieces, type, best_before, base_substance, base_substance_quantity, description);

                    bool response = true;//needs to be modified 
                    addMed(med);
                    if (response)
                    {
                        MessageBox.Show($"{med.Name} {successfully_added}", med_added, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearUserInput();
                    }
                    else
                    {
                        MessageBox.Show($"{med.Name} {failed_to_add}", error, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

            }
        }

        private void button_Add_AddPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = imgFile
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pictureBox_Add.ImageLocation = imgLocation;
                pictureBox_Add.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private async void addMed(Med med)
        {
            await Http.PostMedAsync(med);
        }

        public void clearUserInput()
        {
            textBox_Add_Name.Text = textBox_Add_Description.Text = textBox_Add_BaseSubstance.Text = imgLocation = "";
            numericUpDown_Add_Pieces.Value = numericUpDown_Add_BaseSubstanceQuantity.Value = 1;
            comboBox_Add_Type.SelectedIndex = comboBox_Add_BaseSubstanceQuantity.SelectedIndex = -1;
            dateTimePicker_Add_BestBefore.Value = DateTime.Now;
            pictureBox_Add.Image = null;
        }

        public void setLanguageRo()
        {
            label_Add_Title.Font = new Font("Microsoft Sans Serif", 18);
            label_Add_Title.Text = Properties.Resources.AddANewMed_ro;
            label_Add_Name.Text = Properties.Resources.Name_ro;
            label_Add_Pieces.Text = Properties.Resources.Pieces_ro;
            label_Add_Type.Text = Properties.Resources.Type_ro;
            label_Add_BestBefore.Text = Properties.Resources.BestBefore_ro;
            label_Add_BaseSubstance.Text = Properties.Resources.BaseSubstance_ro;
            label_Add_BaseSubstanceQuantity.Text = Properties.Resources.BaseSubstanceQuantity_ro;
            label_Add_Description.Text = Properties.Resources.Description_ro;
            button_Add_AddPicture.Text = Properties.Resources.AddPicture_ro;
            button_Add_Save.Text = Properties.Resources.Save_ro;
            setErrorsRo();
            setTypeRo();
        }

        public void setLanguageEng()
        {
            label_Add_Title.Font = new Font("Microsoft Sans Serif", 22);
            label_Add_Title.Text = Properties.Resources.AddANewMed_eng;
            label_Add_Name.Text = Properties.Resources.Name_eng;
            label_Add_Pieces.Text = Properties.Resources.Pieces_eng;
            label_Add_Type.Text = Properties.Resources.Type_eng;
            label_Add_BestBefore.Text = Properties.Resources.BestBefore_eng;
            label_Add_BaseSubstance.Text = Properties.Resources.BaseSubstance_eng;
            label_Add_BaseSubstanceQuantity.Text = Properties.Resources.BaseSubstanceQuantity_eng;
            label_Add_Description.Text = Properties.Resources.Description_eng;
            button_Add_AddPicture.Text = Properties.Resources.AddPicture_eng;
            button_Add_Save.Text = Properties.Resources.Save_eng;
            setErrorsEng();
            setTypeEng();
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
            med_added = Properties.Resources.MedAdded_ro;
            successfully_added = Properties.Resources.SuccessfullyAdded_ro;
            failed_to_add = Properties.Resources.FailedToAdd_ro;
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
            med_added = Properties.Resources.MedAdded_eng;
            successfully_added = Properties.Resources.SuccessfullyAdded_eng;
            failed_to_add = Properties.Resources.FailedToAdd_eng;
        }

        private void setTypeRo()
        {
            var selectedIndex = comboBox_Add_Type.SelectedIndex;
            comboBox_Add_Type.Items.Clear();
            comboBox_Add_Type.Items.Add(Properties.Resources.TypePill_ro);
            comboBox_Add_Type.Items.Add(Properties.Resources.TypeCream_ro);
            comboBox_Add_Type.Items.Add(Properties.Resources.TypeTea_ro);
            comboBox_Add_Type.Items.Add(Properties.Resources.TypeSpray);
            comboBox_Add_Type.Items.Add(Properties.Resources.TypeSyrup_ro);
            comboBox_Add_Type.Items.Add(Properties.Resources.TypeSuppository_ro);
            comboBox_Add_Type.Items.Add(Properties.Resources.TypeDrops_ro);
            comboBox_Add_Type.Items.Add(Properties.Resources.TypeGel);
            comboBox_Add_Type.Items.Add(Properties.Resources.TypeEffervescent_ro);
            comboBox_Add_Type.SelectedIndex = selectedIndex;
        }

        private void setTypeEng()
        {
            var selectedIndex = comboBox_Add_Type.SelectedIndex;
            comboBox_Add_Type.Items.Clear();
            comboBox_Add_Type.Items.Add(Properties.Resources.TypePill_eng);
            comboBox_Add_Type.Items.Add(Properties.Resources.TypeCream_eng);
            comboBox_Add_Type.Items.Add(Properties.Resources.TypeTea_eng);
            comboBox_Add_Type.Items.Add(Properties.Resources.TypeSpray);
            comboBox_Add_Type.Items.Add(Properties.Resources.TypeSyrup_eng);
            comboBox_Add_Type.Items.Add(Properties.Resources.TypeSuppository_eng);
            comboBox_Add_Type.Items.Add(Properties.Resources.TypeDrops_eng);
            comboBox_Add_Type.Items.Add(Properties.Resources.TypeGel);
            comboBox_Add_Type.Items.Add(Properties.Resources.TypeEffervescent_eng);
            comboBox_Add_Type.SelectedIndex = selectedIndex;
        }
    }
}
