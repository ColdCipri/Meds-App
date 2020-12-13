using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using Transitions;
using Meds_App.Model;
using static Meds_App.Utils.Utils;

namespace Meds_App
{
    public partial class HomeGUI : UserControl
    {
        public string helpSearch, outofdatedetails,        //Strings for texts. These ones were saved here because they can be modified by the language
            warning, error_retrieve, error, outofdatemeds;

        private bool themeDark, firstTime = false, ok = true;   //Bool values

        private DialogResult result;
        private ToolTip toolTipForSearch = new ToolTip();           //It initialises a new ToolTip which would be set later
        public List<Med> medsList = new List<Med>();                //It initialises an empty list which would be later filled with medicines from the server
        private Med medDetails = new Med();                         //It initialises an empty medicine which would be later modified

        //Constructor - Generated method
        //
        //This method sets the positions of the back button and the *two* pannels to a new point
        //where they can not be seen
        public HomeGUI()
        {
            InitializeComponent();
            button_Back.Location = new Point(1000, 0);
            PanelMedicines_In_Home.Location = new Point(1000, 0);
        }


        //-------------------------------------------MAIN COMPONENTS--------------------------------------------
        

        //Generated method
        //
        //This method starts with disabling both buttons so that they can not be pressed
        //It adds to the listbox an item named "Loading..." as it is loading and waiting updates
        //It tries to get the server process. If it succedes then the application continues but if it fails, 
        //  it tries to open the server and puts the application to sleep for 5 seconds while the server starts
        //It calls the Fill_Listbox method to fill the list with medicines from the server
        //Finnaly, it sets the ToolTip atributes
        private void Home_Load(object sender, EventArgs e)
        {
            listBox_Meds.Items.Add("Loading...");
            button_Details.Enabled = false;
            listBox_Meds.Enabled = false;
            try
            {
                button_Add.Enabled = true;
                textBox_search.Enabled = true;
                Process process = Process.GetProcessesByName("Meds-Server")[0];
            }
            catch (Exception)
            {
                //Process.Start(Properties.Resources.openServer);
                //Process.Start(@"C:\Users\colde\source\repos\ColdCipri\Meds-Server\Meds-Server\openServer.bat");
                Thread.Sleep(5000);
                button_Add.Enabled = false;
                textBox_search.Enabled = false;
                listBox_Meds.Items.Clear(); 
            }

            Fill_ListBox();
            toolTipForSearch.SetToolTip(textBox_search, helpSearch);
            toolTipForSearch.IsBalloon = true;
            toolTipForSearch.ShowAlways = true;
            toolTipForSearch.ToolTipIcon = ToolTipIcon.Info;
        }


        //-------------------------------------------BUTTONS--------------------------------------------


        //-------------------------------------------BUTTONS - ADD BUTTON-------------------------------


        //Generated method
        //
        //When the Add_Home button is clicked, it sets the positions of back button and add panel to 1000, 0 in order to work the transition as expected
        //It creates the transition and adds the two objects: the add panel and the back button, then acording to theme, it adds the two buttons: add and details with the according colors
        //Now it runs the transition. While it runs, the add and details buttons are disabled and the back button is bringed to front.
        private void Button_Add_Home_Click(object sender, EventArgs e)
        {
            button_Back.Location = new Point(1000, 0);
            PanelMedicines_In_Home.Location = new Point(1000, 0);

            Transition changePannel = new Transition(new TransitionType_EaseInEaseOut(700));
            changePannel.add(PanelMedicines_In_Home, "Left", 0);    //It changes the Left atribute of PanelAddMeds_In_Home to 0
            changePannel.add(button_Back, "Left", 3);               //It changes the Left atribute of back button to 3 because it needs to be a little to the right than the panel

            if (themeDark) // if the theme is dark then it changes both buttons text and color to match the background
            {
                changePannel.add(button_Add, "BackColor", Color.Black);    //Color of button
                changePannel.add(button_Add, "ForeColor", Color.Black);    //Color of text
                changePannel.add(button_Details, "BackColor", Color.Black);     //Color of button
                changePannel.add(button_Details, "ForeColor", Color.Black);     //Color of text
            }
            else if (!themeDark) // if theme is white same happens, but with the white theme color
            {
                changePannel.add(button_Add, "BackColor", Color.OldLace);  //Color of button
                changePannel.add(button_Add, "ForeColor", Color.OldLace);  //Color of text
                changePannel.add(button_Details, "BackColor", Color.OldLace);   //Color of button
                changePannel.add(button_Details, "ForeColor", Color.OldLace);   //Color of text
            }
            changePannel.run();

            button_Add.Enabled = false;
            button_Details.Enabled = false;

            button_Back.BringToFront();

            PanelMedicines_In_Home.SetSaveButtonOn(); //When the panel is opened, there will be only the save button down.
        }


        //-------------------------------------------BUTTONS - DETAILS BUTTON-------------------------------


        //Generated method
        //
        //When the Details button is clicked, it sends the medicine selected from the list to the details panel
        //It calls the Button_Add_Home_Click method because it does the same things
        private void Button_Details_Click(object sender, EventArgs e)
        {
            PanelMedicines_In_Home.Fill_Med(medDetails);
            Button_Add_Home_Click(sender, e); 

            PanelMedicines_In_Home.SetSaveButtonOff(); //When the panel is opened, there will be the update and delete buttons down.
        }


        //-------------------------------------------BUTTONS - BACK BUTTON-------------------------------


        //Generated method
        //
        //When the back button is clicked, it creates a new instance of Transition. In this one we add the atributes and we set back the colors of the 
        //add and details buttons just like before
        public void Button_Back_Click(object sender, EventArgs e)
        {
            Transition changePannel = new Transition(new TransitionType_EaseInEaseOut(700));
            changePannel.add(PanelMedicines_In_Home, "Left", 1000);
            changePannel.add(button_Back, "Left", 1000);

            if (themeDark)
            {
                changePannel.add(button_Add, "BackColor", ColorButton);    //Color of the button
                changePannel.add(button_Add, "ForeColor", Color.White);    //Color of the text
                changePannel.add(button_Details, "BackColor", ColorButton);     //Color of the button
                changePannel.add(button_Details, "ForeColor", Color.White);     //Color of the text
            }
            else if (!themeDark)
            {
                changePannel.add(button_Add, "BackColor", Color.AntiqueWhite); //Color of the button
                changePannel.add(button_Add, "ForeColor", Color.Black);        //Color of the text
                changePannel.add(button_Details, "BackColor", Color.AntiqueWhite);  //Color of the button
                changePannel.add(button_Details, "ForeColor", Color.Black);         //Color of the text
            }
            changePannel.run();

            button_Add.Enabled = true;
            textBox_search.Text = "";
            PanelMedicines_In_Home.clearUserInput(); //Here we clear the user input because if we press the back button when we are in details page, the user input remains

            Fill_ListBox();
        }


        //-------------------------------------------LISTBOX----------------------------------------------


        //Generated method
        //
        //When the selected item in list changes to a positive number then we enable Details button
        //This button opens the details page but with the fields filled by the medicine that have been clicked in the list
        //If the medicine that is clicked is out of date than an warning message will be showed
        private void Listbox_Meds_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = listBox_Meds.SelectedIndex;
            if (selectedItem != -1)
            {
                button_Details.Enabled = true;
                medDetails = medsList[selectedItem];
                if (DateTime.Compare(medDetails.BestBefore, DateTime.Now) <= 0)
                {
                    MessageBox.Show($"{outofdatedetails} {medDetails.BestBefore}!", warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                Refresh_Details(medDetails);
            }
            else
            {
                textBox_search.Text = "";
            }
        }

        
        //-------------------------------------------TEXTBOX - SEARCH-----------------------------------------


        //Generated method
        //
        //Firstly it clears the listbox items then it creates a new empty list of medicines
        //It searches through the list of all medicines to match the textbox text with the medicines name, description or base substance
        // if it finds some then it would be added in the empty list created before and it adds it to the listbox
        //If the text is emptied then all medicines are showed in the listbox

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            listBox_Meds.Items.Clear();
            List<Med> medsListSearch = new List<Med>();
            foreach (var med in medsList)
            {
                if (med.Name.ToLower().Contains(textBox_search.Text.ToLower()) ||
                    med.Description.ToLower().Contains(textBox_search.Text.ToLower()) ||
                    med.BaseSubstance.ToLower().Contains(textBox_search.Text.ToLower()))
                {
                    medsListSearch.Add(med);
                    listBox_Meds.Items.Add(med.Name);
                }
            }
            medsList = medsListSearch;
            if (textBox_search.Text.Length == 0)
            {
                Fill_ListBox();
            }
        }


        //-------------------------------------------UTILS--------------------------------------------


        //Input: -
        //Output: -
        //
        //This method tries to fill the list. If the list still has no elements after the Get_Meds_Async method then it greets the user with an error message
        //Otherwise it fills the list
        public async void Fill_ListBox()
        {
            medsList = await Http.Get_Meds_Async(true);

            if (medsList.Count == 0 && firstTime)
            {
                result = MessageBox.Show(error_retrieve, error, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                Disable_Add_Search();
                while (result == DialogResult.Retry && ok)
                {
                    medsList = await Http.Get_Meds_Async(true); 
                    if (medsList.Count != 0)
                    {
                        ok = false; 
                        
                        listBox_Meds.Items.Clear();
                        listBox_Meds.Enabled = true;
                        foreach (var med in medsList)
                        {
                            listBox_Meds.Items.Add($"{med.Name}");
                        }
                        Enable_Add_Search();
                    }
                    else
                    {
                        result = MessageBox.Show(error_retrieve, error, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        Disable_Add_Search();
                        //Here is a bug. When pressing for the 2nd-3rd time the refresh icon, and then press retry from the message box, it does nothing
                    }
                }
            }
            else
            {
                listBox_Meds.Items.Clear();
                listBox_Meds.Enabled = true;
                foreach (var med in medsList)
                {
                    listBox_Meds.Items.Add($"{med.Name}");
                }
            }
            firstTime = true;
        }

        //Input: -
        //Output: -
        //
        //This method enables the add button and the search textbox
        public void Enable_Add_Search()
        {
            if (!button_Add.Enabled)
            {
                button_Add.Enabled = true;
            }

            if (!textBox_search.Enabled)
            {
                textBox_search.Enabled = true;
            }
        }

        //Input: -
        //Output: -
        //
        //This method disables the add button, details button and search textbox and clears the list
        public void Disable_Add_Search()
        {
            if (button_Add.Enabled)
            {
                button_Add.Enabled = false;
            }

            if (button_Details.Enabled)
            {
                button_Details.Enabled = false;
            }

            if (textBox_search.Enabled)
            {
                textBox_search.Enabled = false;
            }

            listBox_Meds.Items.Clear();
        }

        //Input: -
        //Output: -
        //
        //This method tries to show the user an message with the number of out of dates medicines
        //If there are no medicines out of date or no medicines at all nothing will happen
        public async void Show_OutOfDate_Medicines_Count()
        {
            List<Med> outOfDateMeds = await Http.Get_OutOfDate_Meds_Async(true);
            if (medsList.Count != 0)
            {
                if (outOfDateMeds.Count != 0)
                {
                    MessageBox.Show(outOfDateMeds.Count + outofdatemeds, warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        //Input: Med
        //Output: -
        //
        //This method sends the input medicine to the details pannel to fill the textboxes and atributes
        private void Refresh_Details(Med medDetails)
        {
            PanelMedicines_In_Home.Fill_Med(medDetails);
        }


        //-------------------------------------LANGUAGE-------------------------------------


        //-------------------------------------LANGUAGE - RO--------------------------------


        internal void Set_Language_Home_Ro()
        {
            button_Add.Text = Properties.Resources.Add_ro;
            button_Details.Text = Properties.Resources.Details_ro;
            label_Search.Text = Properties.Resources.Search_ro;
            helpSearch = Properties.Resources.HelpSearch_ro;
            toolTipForSearch.SetToolTip(textBox_search, helpSearch);
            toolTipForSearch.ToolTipTitle = Properties.Resources.HelpSearchTitle_ro;
            outofdatedetails = Properties.Resources.OutOfDateDetails_ro;
            outofdatemeds = Properties.Resources.OutOfDateCount_ro;
            warning = "Atentie!";
            error = Properties.Resources.Error_ro;
            error_retrieve = Properties.Resources.ErrorRetrieve_ro;
            PanelMedicines_In_Home.Set_Language_Medicines_Ro();
        }


        //-------------------------------------LANGUAGE - ENG-------------------------------


        internal void Set_Language_Home_Eng()
        {
            button_Add.Text = Properties.Resources.Add_eng;
            button_Details.Text = Properties.Resources.Details_eng;
            label_Search.Text = Properties.Resources.Search_eng;
            helpSearch = Properties.Resources.HelpSearch_eng;
            toolTipForSearch.SetToolTip(textBox_search, helpSearch);
            toolTipForSearch.ToolTipTitle = Properties.Resources.HelpSearchTitle_eng;
            outofdatedetails = Properties.Resources.OutOfDateDetails_eng;
            outofdatemeds = Properties.Resources.OutOfDateCount_eng;
            warning = "Warning!";
            error = Properties.Resources.Error_eng;
            error_retrieve = Properties.Resources.ErrorRetrieve_eng;
            PanelMedicines_In_Home.Set_Language_Medicines_Eng();
        }


        //-------------------------------------THEME-------------------------------------


        //-------------------------------------THEME - DARK------------------------------


        internal void Set_Theme_Dark()
        {
            themeDark = true;

            PanelMedicines_In_Home.Set_Theme_Dark();

            panel_Home_Left.BackColor = panel_Home_Right.BackColor =    //Set color of main panels to Black
                label_Search.BackColor =                                //Set back color of Search label to Black
                Color.Black;

            button_Back.Image = Properties.Resources.LOGO_Arrow_White;  //Sets the arrow color to white

            label_Search.ForeColor =        //Sets color of search label text to White
                textBox_search.ForeColor =  //Sets color of search box text to White
                listBox_Meds.ForeColor =    //Sets color of listbox elements text to White
                button_Add.ForeColor =      //Sets color of add button text to White
                button_Details.ForeColor =  //Sets color of details button text to White
                Color.White;

            listBox_Meds.BackColor =        //Sets the color of the listbox to a RGB value ColorBackground
                textBox_search.BackColor =  //Sets the color of the search box to a RGB value ColorBackground
                ColorBackground;

            button_Add.BackColor =          //Sets the color of the add button to a RGB value ColorButton
                button_Details.BackColor =  //Sets the color of the details button to a RGB value ColorButton
                ColorButton;

            button_Add.FlatAppearance.MouseDownBackColor =     //Sets the color of the add button when it is clicked to a RGB value ColorMouseDownButtonDark
                button_Details.FlatAppearance.MouseDownBackColor =  //Sets the color of the details button when it is clicked to a RGB value ColorMouseDownButtonDark
                button_Back.FlatAppearance.MouseDownBackColor =     //Sets the color of the back button when it is clicked to a RGB value ColorMouseDownButtonDark
                ColorMouseDownButtonDark;

            button_Add.FlatAppearance.MouseOverBackColor =     //Sets the color of the add button when it is hovered to a RGB value ColorMouseOverButtonDark
                button_Details.FlatAppearance.MouseOverBackColor =  //Sets the color of the details button when it is hovered to a RGB value ColorMouseOverButtonDark
                button_Back.FlatAppearance.MouseOverBackColor =     //Sets the color of the back button when it is hovered to a RGB value ColorMouseOverButtonDark
                ColorMouseOverButtonDark;

        }


        //-------------------------------------THEME - LIGHT-------------------------------------


        internal void Set_Theme_Light()
        {
            themeDark = false;

            PanelMedicines_In_Home.Set_Theme_Light();

            button_Back.Image = Properties.Resources.LOGO_Arrow;  //Sets the arrow color to white

            panel_Home_Left.BackColor = panel_Home_Right.BackColor =    //Set color of main panels to OldLace
                label_Search.BackColor =                                //Set back color of search label to OldLace
                Color.OldLace;

            label_Search.ForeColor =        //Set color of search label text to Black
                textBox_search.ForeColor =  //Set color of search box text to Black
                listBox_Meds.ForeColor =    //Set color of listbox elements text to Black
                button_Add.ForeColor = //Set color of add button text to Black
                button_Details.ForeColor =  //Set color of details button text to Black
                Color.Black;                       
            
            listBox_Meds.BackColor =        //Sets the color of the listbox to PapayaWhip
                textBox_search.BackColor =  //Sets the color of the search box to PapayaWhip
                Color.PapayaWhip;

            button_Add.BackColor =     //Sets the color of the add button to AntiqueWhite
                button_Details.BackColor =  //Sets the color of the details button to AntiqueWhite
                Color.AntiqueWhite;

            button_Add.FlatAppearance.MouseDownBackColor =     //Sets the color of the add button when it is clicked to a RGB value ColorMouseDownButtonLight
                button_Details.FlatAppearance.MouseDownBackColor =  //Sets the color of the details button when it is clicked to a RGB value ColorMouseDownButtonLight
                button_Back.FlatAppearance.MouseDownBackColor =     //Sets the color of the back button when it is clicked to a RGB value ColorMouseDownButtonLight
                ColorMouseDownButtonLight;

            button_Add.FlatAppearance.MouseOverBackColor =     //Sets the color of the add button when it is hovered to a RGB value ColorMouseOverButtonLight
                button_Details.FlatAppearance.MouseOverBackColor =  //Sets the color of the details button when it is hovered to a RGB value ColorMouseOverButtonLight
                button_Back.FlatAppearance.MouseOverBackColor =     //Sets the color of the back button when it is hovered to a RGB value ColorMouseOverButtonLight
                ColorMouseOverButtonLight;
                
        }
    }
}
