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
        string imgLocation = "";
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
                MessageBox.Show("Name is invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(textBox_Add_BaseSubstance.Text))
            {
                MessageBox.Show("Base substance is invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(textBox_Add_Description.Text))
            {
                MessageBox.Show("Description is invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBox_Add_Type.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("No type selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBox_Add_BaseSubstanceQuantity.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("No base substance selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (numericUpDown_Add_Pieces.Value < 1)
            {
                MessageBox.Show("The must be a positive number of pieces!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (numericUpDown_Add_BaseSubstanceQuantity.Value < 1)
            {
                MessageBox.Show("The must be a positive number of base substance quantity!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var name = textBox_Add_Name.Text.ToString();
                int pieces = int.Parse(numericUpDown_Add_Pieces.Value.ToString());
                var type = comboBox_Add_Type.SelectedItem.ToString();
                var best_before = dateTimePicker_Add_BestBefore.Value;
                var base_substance = textBox_Add_BaseSubstance.Text.ToString();
                var base_substance_quantity = $"{numericUpDown_Add_BaseSubstanceQuantity.Value.ToString()} {comboBox_Add_BaseSubstanceQuantity.SelectedItem.ToString()}";
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
                        MessageBox.Show($"{med.Name} succesfully added!", "Med added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearUserInput();
                    }
                    else
                    {
                        MessageBox.Show($"{med.Name} failed to add! Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    Med med = new Med(name, pieces, type, best_before, base_substance, base_substance_quantity, description);

                    bool response = true;//needs to be modified 
                    addMed(med);
                    if (response)
                    {
                        MessageBox.Show($"{med.Name} succesfully added!", "Med added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearUserInput();
                    }
                    else
                    {
                        MessageBox.Show($"{med.Name} failed to add! Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

            }
        }

        private void button_Add_AddPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "Image files(*.jpg;*.png)|*.jpg;*.png|All files(*.*)|*.*"
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
    }
}
