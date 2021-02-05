using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Meds_App.Model;
using static Meds_App.Utils.Utils;
using Transitions;
using System.Threading.Tasks;

namespace Meds_App.UserControls
{
    public partial class OutOfDate : UserControl
    {
        List<Med> medsList = new List<Med>();   //It initialises an empty list which would be later filled with medicines from the server
        Med medDetails = new Med();             //It initialises an empty medicine which would be later modified
        private bool themeDark;                 //Bool used for the theme (True if theme is dark, False otherwise
        public string outofdatedetails,        //Strings for texts. These ones were saved here because they can be modified by the language
            warning, error, outofdatemeds;

        //Constructor - Generated method
        //
        //This method sets the positions of the back button and the pannel to a new point
        //where they can not be seen
        public OutOfDate()
        {
            InitializeComponent();
            PanelMedicines_In_OutOfDate.Location = new Point(1000, 0);
            button_OutOfDate_Back.Location = new Point(1000, 0);
        }


        //-------------------------------------------MAIN COMPONENTS--------------------------------------------


        //Generated method
        //
        //This method adds to the listbox an item named "Loading..." as it is loading and waiting updates
        //It disables the button 
        //It calls the Fill_Listbox method with the current date as the parameter to fill the list with medicines from the server that have the best before earlier than current date
        private void OutOfDate_Load(object sender, EventArgs e)
        {
            listBox_OutOfDate.Items.Add("Loading...");
            button_OutOfDate_Details.Enabled = false;
            Fill_Listbox();
        }


        //-------------------------------------------BUTTONS--------------------------------------------


        //-------------------------------------------BUTTONS - DETAILS BUTTON-------------------------------


        //Generated method
        //
        //When the details button is clicked, it sets the positions of back button and details panel to 1000, 0 in order to work the transition as expected
        //It creates the transition and adds the two objects: the details panel and the back button, then acording to theme, it adds the details buttons with the according colors
        //Now it runs the transition. While it runs, the details button is disabled and the back button is bringed to front.
        private void Button_OutOfDate_Details_Click(object sender, EventArgs e)
        {
            PanelMedicines_In_OutOfDate.Fill_Med(medDetails);

            button_OutOfDate_Back.Location = new Point(1000, 0);
            PanelMedicines_In_OutOfDate.Location = new Point(1000, 0);


            Transition changePannel = new Transition(new TransitionType_EaseInEaseOut(700));
            changePannel.add(PanelMedicines_In_OutOfDate, "Left", 0);  //It changes the Left atribute of PanelMedicines_In_OutOfDate to 0
            changePannel.add(button_OutOfDate_Back, "Left", 3);        //It changes the Left atribute of back button to 3 because it needs to be a little to the right than the panel

            if (themeDark) // if the theme is dark then it changes both buttons text and color to match the background
            {
                changePannel.add(button_OutOfDate_Details, "BackColor", Color.Black);     //Color of button
                changePannel.add(button_OutOfDate_Details, "ForeColor", Color.Black);     //Color of text
            }
            else if (!themeDark) // if theme is white same happens, but with the white theme color
            {
                changePannel.add(button_OutOfDate_Details, "BackColor", Color.OldLace);   //Color of button
                changePannel.add(button_OutOfDate_Details, "ForeColor", Color.OldLace);   //Color of text
            }
            changePannel.run();

            button_OutOfDate_Details.Enabled = false;

            button_OutOfDate_Back.BringToFront();

            PanelMedicines_In_OutOfDate.SetSaveButtonOff();
        }


        //-------------------------------------------BUTTONS - BACK BUTTON-------------------------------


        //Generated method
        //
        //When the back button is clicked, it creates a new instance of Transition. In this one we add the atributes and we set back the colors of the 
        //details button just like before
        private void Button_OutOfDate_Back_Click(object sender, EventArgs e)
        {
            Transition changePannel = new Transition(new TransitionType_EaseInEaseOut(700));
            changePannel.add(PanelMedicines_In_OutOfDate, "Left", 1000);
            changePannel.add(button_OutOfDate_Back, "Left", 1000);

            if (themeDark)
            {
                changePannel.add(button_OutOfDate_Details, "BackColor", ColorButton);     //Color of the button
                changePannel.add(button_OutOfDate_Details, "ForeColor", Color.White);     //Color of the text
            }
            else if (!themeDark)
            {
                changePannel.add(button_OutOfDate_Details, "BackColor", Color.AntiqueWhite);  //Color of the button
                changePannel.add(button_OutOfDate_Details, "ForeColor", Color.Black);         //Color of the text
            }

            changePannel.run();

            PanelMedicines_In_OutOfDate.clearUserInput();

            Fill_Listbox();
        }


        //-------------------------------------------LISTBOX----------------------------------------------


        //Generated method
        //
        //When the selected item in list changes to a positive number then we enable Details button
        //This button opens the details page but with the fields filled by the medicine that have been clicked in the list
        //If the medicine that is clicked is out of date than an warning message will be showed
        private void Listbox_OutOfDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = listBox_OutOfDate.SelectedIndex;
            if (selectedItem != -1)
            {
                button_OutOfDate_Details.Enabled = true;
                medDetails = medsList[selectedItem]; 
                if (DateTime.Compare(medDetails.BestBefore, DateTime.Now) <= 0)
                {
                    MessageBox.Show($"{outofdatedetails} {medDetails.BestBefore}!", warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                RefreshDetails(medDetails);
            }
        }


        //-------------------------------------------DATETIMEPICKER----------------------------------------------


        //Generated method
        //
        //If the date in the datetimepicked changes then the items from the list are removed and we fill the list with 
        //the new items that have the best before earlier then the date selected
        //Lastly, we disable the details button
        private void DateTimePicker_OutOfDate_ValueChanged(object sender, EventArgs e)
        {
            listBox_OutOfDate.Items.Clear();
            Fill_Listbox();
            button_OutOfDate_Details.Enabled = false;
        }


        //-------------------------------------------UTILS--------------------------------------------


        //Input: Med
        //Output: -
        //
        //This method calls refreshes the textboxes from the medicine page with the new input medicine
        private void RefreshDetails(Med medDetails)
        {
            PanelMedicines_In_OutOfDate.Fill_Med(medDetails);
        }

        //Input: DateTime
        //Output: -
        //
        //This method tries to fill the list. If the list still has no elements after the Get_Meds_Async method then it means 
        //that there are no medicines from the server that have the best before earlier than the date of the parameter
        //Otherwise it fills the list
        public void Fill_Listbox()
        {
            //medsList = await Http.Get_Meds_Async(true);
            Task.Run(async () => medsList = await Http.Get_Meds_Async(true));
            listBox_OutOfDate.Items.Clear();

            List<Med> outofdateList = new List<Med>();
            if (medsList.Count != 0)
            {
                foreach (var med in medsList)
                {
                    if (DateTime.Compare(med.BestBefore, dateTimePicker_OutOfDate.Value) < 0)
                    {
                        outofdateList.Add(med);
                        listBox_OutOfDate.Items.Add($"{med.Name}");
                    }
                }
            }
            medsList = outofdateList;
        }


        //-------------------------------------LANGUAGE-------------------------------------


        //-------------------------------------LANGUAGE - RO--------------------------------


        public void Set_Language_OutOfDate_Ro()
        {
            button_OutOfDate_Details.Text = Properties.Resources.Details_ro;
            PanelMedicines_In_OutOfDate.Set_Language_Medicines_Ro();
        }


        //-------------------------------------LANGUAGE - ENG-------------------------------


        public void Set_Language_OutOfDate_Eng()
        {
            button_OutOfDate_Details.Text = Properties.Resources.Details_eng;
            PanelMedicines_In_OutOfDate.Set_Language_Medicines_Eng();
        }


        //-------------------------------------THEME-------------------------------------


        //-------------------------------------THEME - DARK------------------------------


        internal void Set_Theme_Dark()
        {
            themeDark = true;

            PanelMedicines_In_OutOfDate.Set_Theme_Dark();

            panel_OutOfDate.BackColor = //Set color of main panels to Black
                panel_OutOfDate_Right.BackColor =
                Color.Black;

            button_OutOfDate_Back.Image = Properties.Resources.LOGO_Arrow_White;

            listBox_OutOfDate.ForeColor =            //Set color of search box text to White
                button_OutOfDate_Details.ForeColor = //Sets color of details button text to White
                Color.White;

            listBox_OutOfDate.BackColor =   //Sets the color of the listbox to a RGB value ColorBackground
                ColorBackground;

            button_OutOfDate_Details.BackColor =    //Sets the color of the details button to a RGB value ColorButton
                ColorButton;

            button_OutOfDate_Details.FlatAppearance.MouseDownBackColor =    //Sets the color of the details button when it is clicked to a RGB value ColorMouseDownButtonDark
                button_OutOfDate_Back.FlatAppearance.MouseDownBackColor =   //Sets the color of the back button when it is clicked to a RGB value ColorMouseDownButtonDark
                ColorMouseDownButtonDark;

            button_OutOfDate_Details.FlatAppearance.MouseOverBackColor =    //Sets the color of the details button when it is hovered to a RGB value ColorMouseOverButtonDark
               button_OutOfDate_Back.FlatAppearance.MouseOverBackColor =    //Sets the color of the back button when it is hovered to a RGB value ColorMouseOverButtonDark
               ColorMouseOverButtonDark;
        }


        //-------------------------------------THEME - LIGHT-------------------------------------


        internal void Set_Theme_Light()
        {
            themeDark = false;

            PanelMedicines_In_OutOfDate.Set_Theme_Light();

            button_OutOfDate_Back.Image = Properties.Resources.LOGO_Arrow;  //Sets the arrow color to white

            panel_OutOfDate.BackColor = panel_OutOfDate_Right.BackColor =   //Set color of main panels to OldLace
                Color.OldLace;

            listBox_OutOfDate.ForeColor =           //Set color of listbox elements text to Black
                button_OutOfDate_Details.ForeColor =//Set color of details button text to Black
                Color.Black;

            listBox_OutOfDate.BackColor =   //Sets the color of the listbox to PapayaWhip
                Color.PapayaWhip;

            button_OutOfDate_Details.BackColor =  //Sets the color of the details button to AntiqueWhite
                Color.AntiqueWhite;

            button_OutOfDate_Details.FlatAppearance.MouseDownBackColor =    //Sets the color of the details button when it is clicked to a RGB value ColorMouseDownButtonLight
                button_OutOfDate_Back.FlatAppearance.MouseDownBackColor =   //Sets the color of the back button when it is clicked to a RGB value ColorMouseDownButtonLight
                ColorMouseDownButtonLight;

            button_OutOfDate_Details.FlatAppearance.MouseOverBackColor =    //Sets the color of the details button when it is hovered to a RGB value ColorMouseOverButtonLight
                button_OutOfDate_Back.FlatAppearance.MouseOverBackColor =   //Sets the color of the back button when it is hovered to a RGB value ColorMouseOverButtonLight
                ColorMouseOverButtonLight;
        }
    }
}
