using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Meds_App.Model;
using static Meds_App.Utils.Utils;

namespace Meds_App
{
    public partial class Medicines : UserControl
    {
        private string imgLocation = "", imgFile,   //Strings for texts. These ones were saved here because they can be modified by the language
            error, error_name, error_pieces, error_type, error_basesubst, error_basesubstq1,
            error_basesubstq2, error_description, 
            successfully_added, med_added, failed_to_add, 
            successfully_updated, successfully_deleted, success;

        private List<string> typeList =         //It initialises a new list with the types of medicines
            new List<string> { "Pill", "Cream", "Tea", "Spray", "Syrup", 
                "Suppository", "Drops", "Gel", "Effervescent" };


        Med med = new Med();                    //It initialises a new med that will be updated if this page open as details page

        //Constructor - Generated method
        //
        //This method sets the selected index from the two comboboxes to 0
        public Medicines()
        {
            InitializeComponent();
            comboBox_Type.SelectedIndex = 0;
            comboBox_BaseSubstanceQuantity.SelectedIndex = 0;
        }


        //-------------------------------------------BUTTONS--------------------------------------------


        //-------------------------------------------BUTTONS - SAVE BUTTON-------------------------------


        //Generated method
        //
        //This method runs when the save button is clicked
        //It checks every every textbox , listbox and so on if there is user input, if not it will show an error with the missing input
        //If everything is ok, it checks for the image
        //Last but not least, it send the request to server calling the addMed method
        //If the request was received and the med was added there will be an success message and fail message otherwise
        private void button_Save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_Name.Text))
            {
                MessageBox.Show(error_name, error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(textBox_BaseSubstance.Text))
            {
                MessageBox.Show(error_basesubst, error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(textBox_Description.Text))
            {
                MessageBox.Show(error_description, error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBox_Type.SelectedIndex.Equals(-1))
            {
                MessageBox.Show(error_type, error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBox_BaseSubstanceQuantity.SelectedIndex.Equals(-1))
            {
                MessageBox.Show(error_basesubstq2, error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (numericUpDown_Pieces.Value < 1)
            {
                MessageBox.Show(error_pieces, error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (numericUpDown_BaseSubstanceQuantity.Value < 1)
            {
                MessageBox.Show(error_basesubstq1, error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var name = textBox_Name.Text.ToString();
                int pieces = int.Parse(numericUpDown_Pieces.Value.ToString());
                var type = typeList[comboBox_Type.SelectedIndex];
                var best_before = dateTimePicker_BestBefore.Value;
                var base_substance = textBox_BaseSubstance.Text.ToString();
                var base_substance_quantity = $"{numericUpDown_BaseSubstanceQuantity.Value} {comboBox_BaseSubstanceQuantity.SelectedItem.ToString()}";
                var description = textBox_Description.Text.ToString();
                if (!imgLocation.Equals(""))
                {

                    FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader binaryReader = new BinaryReader(stream);
                    byte[] image = binaryReader.ReadBytes((int)(stream.Length));

                    Med med = new Med(name, pieces, type, best_before, base_substance, base_substance_quantity, description, image);

                    bool response = true; //needs to be modified 
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

                    bool response = true; //needs to be modified 
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


        //-------------------------------------------BUTTONS - UPDATE BUTTON-------------------------------


        //Generated method
        //
        //This method runs when the update button is clicked
        //It checks every every textbox , listbox and so on if there is user input, if not it will show an error with the missing input
        //If everything is ok, it checks for the image
        //Last but not least, it send the request to server calling the PutMedAsync method from the Http class
        //If the request was received and the med was updated there will be an success message ---------and fail message otherwise
        private void button_Update_Click(object sender, EventArgs e)
        {
            Med updatedMed = new Med();
            if (string.IsNullOrWhiteSpace(textBox_Name.Text))
            {
                MessageBox.Show(error_name, error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(textBox_BaseSubstance.Text))
            {
                MessageBox.Show(error_basesubst, error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(textBox_Description.Text))
            {
                MessageBox.Show(error_description, error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBox_Type.SelectedIndex.Equals(-1))
            {
                MessageBox.Show(error_type, error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (comboBox_BaseSubstanceQuantity.SelectedIndex.Equals(-1))
            {
                MessageBox.Show(error_basesubstq2, error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (numericUpDown_Pieces.Value < 1)
            {
                MessageBox.Show(error_pieces, error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (numericUpDown_BaseSubstanceQuantity.Value < 1)
            {
                MessageBox.Show(error_basesubstq1, error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                updatedMed.Name = textBox_Name.Text;
                updatedMed.Pieces = int.Parse(numericUpDown_Pieces.Value.ToString());
                updatedMed.Type = typeList[comboBox_Type.SelectedIndex];
                updatedMed.BestBefore = dateTimePicker_BestBefore.Value;
                updatedMed.BaseSubstance = textBox_BaseSubstance.Text;
                updatedMed.BaseSubstanceQuantity = $"{numericUpDown_BaseSubstanceQuantity.Value} {comboBox_BaseSubstanceQuantity.SelectedItem}";
                updatedMed.Description = textBox_Description.Text;


                if (imgLocation.Equals(""))
                {
                    updatedMed.Picture = med.Picture;
                }
                else
                {
                    FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                    BinaryReader binaryReader = new BinaryReader(stream);
                    byte[] image = binaryReader.ReadBytes((int)(stream.Length));

                    updatedMed.Picture = image;

                }
                Http.PutMedAsync(updatedMed, med.Id); // here needs to be added if-else with fail
                MessageBox.Show($"{successfully_updated} {updatedMed.Name}!", success, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        //-------------------------------------------BUTTONS - DELETE BUTTON-------------------------------


        //Generated method
        //
        //This method runs when the delete button is clicked
        //It send the request to server calling the DeleteMedAsync method from the Http class with the medicine id
        //If the request was received and the med was delete there will be an success message ---------and fail message otherwise
        private void button_Delete_Click(object sender, EventArgs e)
        {
            Http.DeleteMedAsync(med.Id);
            MessageBox.Show($"{successfully_deleted} {med.Name}!", success, MessageBoxButtons.OK, MessageBoxIcon.Information);
            clearUserInput();
        }


        //-------------------------------------------BUTTONS - ADDPICTURE BUTTON-------------------------------


        //Generated method
        //
        //This method runs when the Add Picture button is clicked
        //It opens a dialog where you can search for photos
        //If you selected a photo, this one will be showed next to the button and the location of the photo will be saved in a variable for later use
        private void button_AddPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = imgFile
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pictureBox.ImageLocation = imgLocation;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }


        //-------------------------------------------UTILS--------------------------------------------


        //Input: Med
        //Output: -
        //
        //This method sends the Med instance to the server to be added
        private async void addMed(Med med)
        {
            await Http.PostMedAsync(med);
        }

        //Input: -
        //Output: -
        //
        //This method clears the user input
        public void clearUserInput()
        {
            textBox_Name.Text = textBox_Description.Text = textBox_BaseSubstance.Text = imgLocation = "";
            numericUpDown_Pieces.Value = numericUpDown_BaseSubstanceQuantity.Value = 1;
            comboBox_Type.SelectedIndex = comboBox_BaseSubstanceQuantity.SelectedIndex = 0;
            dateTimePicker_BestBefore.Value = DateTime.Now;
            pictureBox.Image = null;
        }

        //Input: Med
        //Output: -
        //
        //This method is called when the Details part of this class is opened and it fills the textboxes, lists and so on with the input medicine parameter
        public void Fill_Med(Med medExt)
        {
            med = medExt;
            textBox_Name.Text = med.Name;

            numericUpDown_Pieces.Value = med.Pieces;

            if (!med.Type.Equals(null))
            {

                switch (med.Type)
                {
                    case "Pill":
                        comboBox_Type.SelectedIndex = 0;
                        break;
                    case "Cream":
                        comboBox_Type.SelectedIndex = 1;
                        break;
                    case "Tea":
                        comboBox_Type.SelectedIndex = 2;
                        break;
                    case "Spray":
                        comboBox_Type.SelectedIndex = 3;
                        break;
                    case "Syrup":
                        comboBox_Type.SelectedIndex = 4;
                        break;
                    case "Suppository":
                        comboBox_Type.SelectedIndex = 5;
                        break;
                    case "Drops":
                        comboBox_Type.SelectedIndex = 6;
                        break;
                    case "Gel":
                        comboBox_Type.SelectedIndex = 7;
                        break;
                    case "Effervescent":
                        comboBox_Type.SelectedIndex = 8;
                        break;
                }

            }

            dateTimePicker_BestBefore.Value = med.BestBefore;

            textBox_BaseSubstance.Text = med.BaseSubstance;

            if (!med.BaseSubstanceQuantity.Equals("null"))
            {
                numericUpDown_BaseSubstanceQuantity.Value = int.Parse(med.BaseSubstanceQuantity.Substring(0, med.BaseSubstanceQuantity.IndexOf(' ')));
                var value = med.BaseSubstanceQuantity.Substring(med.BaseSubstanceQuantity.IndexOf(" ") + 1);
                switch (value)
                {
                    case "mg":
                        comboBox_BaseSubstanceQuantity.SelectedItem = "mg";
                        break;
                    case "ml":
                        comboBox_BaseSubstanceQuantity.SelectedItem = "ml";
                        break;
                    case "UI":
                        comboBox_BaseSubstanceQuantity.SelectedItem = "UI";
                        break;
                    case "ug":
                        comboBox_BaseSubstanceQuantity.SelectedItem = "ug";
                        break;
                }
            }

            textBox_Description.Text = med.Description;

            try
            {
                pictureBox.Image = Image.FromStream(new MemoryStream((byte[])med.Picture));
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch
            {
                pictureBox.Image = null;
            }
        }

        //Input: -
        //Output: -
        //
        //This method sets the Save button to be visible and the other two (Update/Delete) to not be visible and it enables the name textbox to be modified
        public void SetSaveButtonOn()
        {
            button_Save.Visible = true;
            button_Update.Visible = false;
            button_Delete.Visible = false;

            label_Title_Add.Visible = true;
            label_Title_Details.Visible = false;

            textBox_Name.Enabled = true;
        }

        //Input: -
        //Output: -
        //
        //This method does the opposite of the one above
        public void SetSaveButtonOff()
        {
            button_Update.Visible = true;
            button_Delete.Visible = true;
            button_Save.Visible = false;

            label_Title_Add.Visible = false;
            label_Title_Details.Visible = true;

            textBox_Name.Enabled = false;
        }


        //-------------------------------------LANGUAGE-------------------------------------


        //-------------------------------------LANGUAGE - RO--------------------------------


        public void Set_Language_Medicines_Ro()
        {
            label_Title_Add.Font = label_Title_Details.Font = 
                new Font("Microsoft Sans Serif", 18);
            label_Title_Add.Text = Properties.Resources.AddANewMed_ro;
            label_Title_Details.Text = Properties.Resources.DetailsAbout_ro;
            label_Name.Text = Properties.Resources.Name_ro;
            label_Pieces.Text = Properties.Resources.Pieces_ro;
            label_Type.Text = Properties.Resources.Type_ro;
            label_BestBefore.Text = Properties.Resources.BestBefore_ro;
            label_BaseSubstance.Text = Properties.Resources.BaseSubstance_ro;
            label_BaseSubstanceQuantity.Text = Properties.Resources.BaseSubstanceQuantity_ro;
            label_Description.Text = Properties.Resources.Description_ro;


            button_AddPicture.Text = Properties.Resources.AddPicture_ro;
            button_Save.Text = Properties.Resources.Save_ro;
            button_Delete.Text = Properties.Resources.Delete_ro;
            button_Update.Text = Properties.Resources.Update_ro;


            imgFile = Properties.Resources.ImageFiles_ro;
            success = Properties.Resources.Success_ro;

            successfully_updated = Properties.Resources.SuccessfullyUpdated_ro;
            successfully_deleted = Properties.Resources.SuccessfullyDeleted_ro;

            setErrorsRo();
            setTypeRo();
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

        private void setTypeRo()
        {
            var selectedIndex = comboBox_Type.SelectedIndex;
            comboBox_Type.Items.Clear();
            comboBox_Type.Items.Add(Properties.Resources.TypePill_ro);
            comboBox_Type.Items.Add(Properties.Resources.TypeCream_ro);
            comboBox_Type.Items.Add(Properties.Resources.TypeTea_ro);
            comboBox_Type.Items.Add(Properties.Resources.TypeSpray);
            comboBox_Type.Items.Add(Properties.Resources.TypeSyrup_ro);
            comboBox_Type.Items.Add(Properties.Resources.TypeSuppository_ro);
            comboBox_Type.Items.Add(Properties.Resources.TypeDrops_ro);
            comboBox_Type.Items.Add(Properties.Resources.TypeGel);
            comboBox_Type.Items.Add(Properties.Resources.TypeEffervescent_ro);
            comboBox_Type.SelectedIndex = selectedIndex;
        }


        //-------------------------------------LANGUAGE - ENG--------------------------------


        public void Set_Language_Medicines_Eng()
        {
            label_Title_Add.Font = label_Title_Details.Font =
                new Font("Microsoft Sans Serif", 22);
            label_Title_Add.Text = Properties.Resources.AddANewMed_eng;
            label_Title_Details.Text = Properties.Resources.DetailsAbout_eng;
            label_Name.Text = Properties.Resources.Name_eng;
            label_Pieces.Text = Properties.Resources.Pieces_eng;
            label_Type.Text = Properties.Resources.Type_eng;
            label_BestBefore.Text = Properties.Resources.BestBefore_eng;
            label_BaseSubstance.Text = Properties.Resources.BaseSubstance_eng;
            label_BaseSubstanceQuantity.Text = Properties.Resources.BaseSubstanceQuantity_eng;
            label_Description.Text = Properties.Resources.Description_eng;


            button_AddPicture.Text = Properties.Resources.AddPicture_eng;
            button_Save.Text = Properties.Resources.Save_eng;
            button_Delete.Text = Properties.Resources.Delete_eng;
            button_Update.Text = Properties.Resources.Update_eng;


            imgFile = Properties.Resources.ImageFiles_eng;
            success = Properties.Resources.Success_eng;

            successfully_updated = Properties.Resources.SuccessfullyUpdated_eng;
            successfully_deleted = Properties.Resources.SuccessfullyDeleted_eng;

            setErrorsEng();
            setTypeEng();
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

        private void setTypeEng()
        {
            var selectedIndex = comboBox_Type.SelectedIndex;
            comboBox_Type.Items.Clear();
            comboBox_Type.Items.Add(Properties.Resources.TypePill_eng);
            comboBox_Type.Items.Add(Properties.Resources.TypeCream_eng);
            comboBox_Type.Items.Add(Properties.Resources.TypeTea_eng);
            comboBox_Type.Items.Add(Properties.Resources.TypeSpray);
            comboBox_Type.Items.Add(Properties.Resources.TypeSyrup_eng);
            comboBox_Type.Items.Add(Properties.Resources.TypeSuppository_eng);
            comboBox_Type.Items.Add(Properties.Resources.TypeDrops_eng);
            comboBox_Type.Items.Add(Properties.Resources.TypeGel);
            comboBox_Type.Items.Add(Properties.Resources.TypeEffervescent_eng);
            comboBox_Type.SelectedIndex = selectedIndex;
        }


        //-------------------------------------THEME-------------------------------------


        //-------------------------------------THEME - DARK------------------------------


        internal void Set_Theme_Dark()
        {
            panel_AddMeds.BackColor = Color.Black;  //Set the background color of panel to black

            label_Title_Add.ForeColor =         //Set the text color of add Title to white
                label_Title_Details.ForeColor = //Set the text color of details Title to white
                label_Name.ForeColor =          //Set the text color of Name label to white
                textBox_Name.ForeColor =        //Set the text color of Name textbox to white
                label_Pieces.ForeColor =        //Set the text color of Pieces label to white
                numericUpDown_Pieces.ForeColor =//Set the text color of Pieces numericupdown to white
                label_Type.ForeColor =          //Set the text color of Type label to white
                comboBox_Type.ForeColor =       //Set the text color of Type combobox to white
                label_BestBefore.ForeColor =    //Set the text color of Best Before label to white
                dateTimePicker_BestBefore.CalendarForeColor =           //Set the ? color of Best Before datetimepicker to white
                dateTimePicker_BestBefore.CalendarTitleForeColor =      //Set the ? color of Best Before datetimepicker to white
                dateTimePicker_BestBefore.CalendarTrailingForeColor =   //Set the ? color of Best Before datetimepicker to white
                label_BaseSubstance.ForeColor =                 //Set the text color of Base Substance label to white
                textBox_BaseSubstance.ForeColor =               //Set the text color of Base Substance textbox to white
                label_BaseSubstanceQuantity.ForeColor =         //Set the text color of Base Substance Quantity label to white
                numericUpDown_BaseSubstanceQuantity.ForeColor = //Set the text color of Base Substance Quantity numericupdown to white
                comboBox_BaseSubstanceQuantity.ForeColor =      //Set the text color of Base Substance Quantity combobox to white
                label_Description.ForeColor =   //Set the text color of Description label to white
                textBox_Description.ForeColor = //Set the text color of Description textbox to white
                button_AddPicture.ForeColor =   //Set the text color of Add Picture button to white
                button_Save.ForeColor =         //Set the text color of Save button to white
                button_Update.ForeColor =       //Set the text color of Update button to white
                button_Delete.ForeColor =       //Set the text color of Delete button to white
                Color.White;

            textBox_Name.BorderStyle = numericUpDown_Pieces.BorderStyle = textBox_BaseSubstance.BorderStyle =
                numericUpDown_BaseSubstanceQuantity.BorderStyle = textBox_Description.BorderStyle = BorderStyle.FixedSingle;
            //This command add the borders to the textboxes because they cannot be seen if there is not any border

            textBox_Name.BackColor =            //Sets the background color of the Name textbox to a RGB value ColorBackground
                numericUpDown_Pieces.BackColor =//Sets the background color of the Pieces numericupdown to a RGB value ColorBackground
                comboBox_Type.BackColor =       //Sets the background color of the Type combobox to a RGB value ColorBackground
                dateTimePicker_BestBefore.BackColor =   //Sets the background color of the Best Before datetimepicker to a RGB value ColorBackground
                textBox_BaseSubstance.BackColor =       //Sets the background color of the Base Substance textbox to a RGB value ColorBackground
                numericUpDown_BaseSubstanceQuantity.BackColor = //Sets the background color of the Base Substance Quantity numericupdown to a RGB value ColorBackground
                comboBox_BaseSubstanceQuantity.BackColor =  //Sets the background color of the Base Substance Quantity combobox to a RGB value ColorBackground
                textBox_Description.BackColor =             //Sets the background color of the Description textbox to a RGB value ColorBackground
                ColorBackground;

            button_AddPicture.FlatAppearance.MouseDownBackColor =   //Sets the color of the add button when it is clicked to a RGB value ColorMouseDownButtonDark
                button_Save.FlatAppearance.MouseDownBackColor =     //Sets the color of the save button when it is hovered to a RGB value ColorMouseDownButtonDark
                button_Update.FlatAppearance.MouseDownBackColor =   //Sets the color of the update button when it is hovered to a RGB value ColorMouseDownButtonDark
                button_Delete.FlatAppearance.MouseDownBackColor =   //Sets the color of the delete button when it is hovered to a RGB value ColorMouseDownButtonDark  
                ColorMouseDownButtonDark;

            button_AddPicture.FlatAppearance.MouseOverBackColor =   //Sets the color of the add button when it is hovered to a RGB value ColorMouseOverButtonDark
                button_Save.FlatAppearance.MouseOverBackColor =     //Sets the color of the save button when it is hovered to a RGB value ColorMouseOverButtonDark
                button_Update.FlatAppearance.MouseOverBackColor =   //Sets the color of the update button when it is hovered to a RGB value ColorMouseOverButtonDark
                button_Delete.FlatAppearance.MouseOverBackColor =   //Sets the color of the delete button when it is hovered to a RGB value ColorMouseOverButtonDark     
                ColorMouseOverButtonDark;


            button_AddPicture.BackColor = ColorButton;  //Sets the background color of Add Picture button to a RGB code ColorButton
            button_Save.BackColor =   //Sets the background color of Save button to a RGB code ColorButtonCRUD
            button_Update.BackColor = //Sets the background color of Update button to a RGB code ColorButtonCRUD
            button_Delete.BackColor = //Sets the background color of Delete button to a RGB code ColorButtonCRUD
                ColorButtonCRUD;
        }


        //-------------------------------------THEME - LIGHT------------------------------


        internal void Set_Theme_Light()
        {
            panel_AddMeds.BackColor = Color.OldLace;//Set the background color of panel to OldLace

            label_Title_Add.ForeColor =         //Set the text color of add Title to black
                label_Title_Details.ForeColor = //Set the text color of details Title to black
                label_Name.ForeColor =          //Set the text color of Name label to black
                textBox_Name.ForeColor =        //Set the text color of Name textbox to black
                label_Pieces.ForeColor =        //Set the text color of Pieces label to black
                numericUpDown_Pieces.ForeColor =//Set the text color of Pieces numericupdown to black
                label_Type.ForeColor =          //Set the text color of Type label to black
                comboBox_Type.ForeColor =       //Set the text color of Type combobox to black
                label_BestBefore.ForeColor =    //Set the text color of Best Before label to black
                dateTimePicker_BestBefore.CalendarForeColor =           //Set the ? color of Best Before datetimepicker to black
                dateTimePicker_BestBefore.CalendarTitleForeColor =      //Set the ? color of Best Before datetimepicker to black
                dateTimePicker_BestBefore.CalendarTrailingForeColor =   //Set the ? color of Best Before datetimepicker to black
                label_BaseSubstance.ForeColor =                 //Set the text color of Base Substance label to black
                textBox_BaseSubstance.ForeColor =               //Set the text color of Base Substance textbox to black
                label_BaseSubstanceQuantity.ForeColor =         //Set the text color of Base Substance Quantity label to black
                numericUpDown_BaseSubstanceQuantity.ForeColor = //Set the text color of Base Substance Quantity numericupdown to black
                comboBox_BaseSubstanceQuantity.ForeColor =      //Set the text color of Base Substance Quantity combobox to black
                label_Description.ForeColor =   //Set the text color of Description label to black
                textBox_Description.ForeColor = //Set the text color of Description textbox to black
                button_AddPicture.ForeColor =   //Set the text color of Add Picture button to black
                button_Save.ForeColor =         //Set the text color of Save button to black
                button_Update.ForeColor =       //Set the text color of Update button to black
                button_Delete.ForeColor =       //Set the text color of Delete button to black
                Color.Black;

            textBox_Name.BorderStyle = numericUpDown_Pieces.BorderStyle = textBox_BaseSubstance.BorderStyle =
                numericUpDown_BaseSubstanceQuantity.BorderStyle = textBox_Description.BorderStyle = BorderStyle.None;
            //This command removes the borders from the textboxes

            textBox_Name.BackColor =            //Sets the background color of the Name textbox to white
                numericUpDown_Pieces.BackColor =//Sets the background color of the Pieces numericupdown to white
                comboBox_Type.BackColor =       //Sets the background color of the Type combobox to white
                dateTimePicker_BestBefore.BackColor =   //Sets the background color of the Best Before datetimepicker to white
                textBox_BaseSubstance.BackColor =       //Sets the background color of the Base Substance textbox to white
                numericUpDown_BaseSubstanceQuantity.BackColor = //Sets the background color of the Base Substance Quantity numericupdown to white
                comboBox_BaseSubstanceQuantity.BackColor =  //Sets the background color of the Base Substance Quantity combobox to white
                textBox_Description.BackColor =             //Sets the background color of the Description textbox to white
                Color.White;

            button_AddPicture.FlatAppearance.MouseDownBackColor =   //Sets the color of the add button when it is clicked to a RGB value ColorMouseDownButtonLight
                button_Save.FlatAppearance.MouseDownBackColor =     //Sets the color of the save button when it is hovered to a RGB value ColorMouseDownButtonLight
                button_Update.FlatAppearance.MouseDownBackColor =   //Sets the color of the update button when it is hovered to a RGB value ColorMouseDownButtonLight
                button_Delete.FlatAppearance.MouseDownBackColor =   //Sets the color of the delete button when it is hovered to a RGB value ColorMouseDownButtonLight  
                ColorMouseDownButtonLight;

            button_AddPicture.FlatAppearance.MouseOverBackColor =   //Sets the color of the add button when it is hovered to a RGB value ColorMouseOverButtonLight
                button_Save.FlatAppearance.MouseOverBackColor =     //Sets the color of the save button when it is hovered to a RGB value ColorMouseOverButtonLight
                button_Update.FlatAppearance.MouseOverBackColor =   //Sets the color of the update button when it is hovered to a RGB value ColorMouseOverButtonLight
                button_Delete.FlatAppearance.MouseOverBackColor =   //Sets the color of the delete button when it is hovered to a RGB value ColorMouseOverButtonLight     
                ColorMouseOverButtonLight;


            button_AddPicture.BackColor = Color.AntiqueWhite;  //Sets the background color of Add Picture button to AntiqueWhite
            button_Save.BackColor =   //Sets the background color of Save button to Moccasin
            button_Update.BackColor = //Set the background color of Update button to Moccasin
            button_Delete.BackColor = //Set the background color of Delete button to Moccasin
                Color.Moccasin;

        }
    }
}
