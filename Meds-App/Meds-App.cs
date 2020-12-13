using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Transitions;
using static Meds_App.Utils.Utils;

namespace Meds_App
{
    public partial class MainForm : Form
    {
        bool languageEng, theme;    //booleans for language and theme.

        public MainForm()
        {
            InitializeComponent();
        }


        //-------------------------------------------MAIN COMPONENTS--------------------------------------------

        //Generated method
        //
        //This method creates a transition when the app is runned
        //It reads both language and theme from file and sets the application language and theme according to the values saved before
        private void MainForm_Load(object sender, EventArgs e)
        {
            Transition transitionSlide = new Transition(new TransitionType_Linear(700));
            transitionSlide.add(this.pictureBox_Logo, "Left", 7);
            transitionSlide.add(this.label_Title, "Top", 0);
            transitionSlide.run();
            Transition.run(this.panelHome_In_Main, "Left", 0, new TransitionType_EaseInEaseOut(1000));


            languageEng = Read_From_File_Language();
            theme = Read_From_File_Theme();

            Set_Language(languageEng);
            Set_Theme(theme);
        }

        //This method adds a shadow on bottom-right
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }

        }

        //Generated method
        //
        //This method is called after the Load method from the panelHome_In_Main
        //If the app does not connect to server then this method will show an error
        //Otherwise it will call the Show_OutOfDate_Medicines_Count method
        private void MainForm_Shown(object sender, EventArgs e)
        {
            if (panelHome_In_Main.medsList.Count == 0)
            {
                var result = MessageBox.Show(panelHome_In_Main.error_retrieve, panelHome_In_Main.error, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    panelHome_In_Main.Fill_ListBox();
                }
            }
            else
            {
                panelHome_In_Main.Show_OutOfDate_Medicines_Count();
            }
        }


        //-------------------------------------------UTILS--------------------------------------------


        //Input: a button
        //Output: true/false
        //
        //This method returns true if the button has either the color OldLace either the color Black. 
        //These two colors are used to know when a button is selected from the left part of the app.
        //Otherwise it returns false.
        private static bool Check_Active_Button(Button button)
        {
            if (button.BackColor.Equals(Color.OldLace))
            {
                return true;
            } 
            else if (button.BackColor.Equals(Color.Black))
            {
                return true;
            }
            return false;
        }

        //Input: a button (and theme)
        //Output: -
        //
        //This method sets all the BackColors of the left buttons according to the theme value (true/false).
        //The input button is set as the current value and it's BackColor is changed.
        public void Change_Selected_Button(Button button)
        {
            if (theme)
            {
                button_Home.BackColor = Color.Moccasin;
                button_OutOfDate.BackColor = Color.Moccasin;
                button_Details.BackColor = Color.Moccasin;

                if (button.Equals(button_Home))
                    button_Home.BackColor = Color.OldLace;
                else if (button.Equals(button_OutOfDate))
                    button_OutOfDate.BackColor = Color.OldLace;
                else if (button.Equals(button_Details))
                    button_Details.BackColor = Color.OldLace;
            }
            else
            {
                button_Home.BackColor = ColorLeftBlack;
                button_OutOfDate.BackColor = ColorLeftBlack;
                button_Details.BackColor = ColorLeftBlack;

                if (button.Equals(button_Home))
                    button_Home.BackColor = Color.Black;
                else if (button.Equals(button_OutOfDate))
                    button_OutOfDate.BackColor = Color.Black;
                else if (button.Equals(button_Details))
                    button_Details.BackColor = Color.Black;
            }
        }


        //-------------------------------------------BUTTONS LEFT--------------------------------------------


        //-------------------------------------------BUTTONS LEFT - HOME BUTTON------------------------------


        //Generated method
        //
        //When the Button_Home button is clicked, it will show a slide animation from the active panel to the Home panel.
        //If the active panel is the same as Home panel then it will do an emphasis animation.
        //It calls the Check_Selected_Button method to check which is the active panel.
        //After the animation, it calls the Change_Selected_Button method to change the button for the active panel.
        //Last, it calls the fillListBox method from the home panel to refresh the listbox elements.
        private void Button_Home_Click(object sender, EventArgs e)
        {
            if (Check_Active_Button(button_OutOfDate))
            {
                this.panelHome_In_Main.Location = new Point(0, -700);
                Transition slidePanels = new Transition(new TransitionType_EaseInEaseOut(1000));
                slidePanels.add(this.panelHome_In_Main, "Top", 0);
                slidePanels.add(this.panelOutOfDate_In_Main, "Top", 700);
                slidePanels.run();
            }
            else if (Check_Active_Button(button_Details))
            {
                this.panelHome_In_Main.Location = new Point(0, -1400);
                this.panelOutOfDate_In_Main.Location = new Point(0, -700);
                Transition slidePanels = new Transition(new TransitionType_EaseInEaseOut(1000));
                slidePanels.add(this.panelHome_In_Main, "Top", 0);
                slidePanels.add(this.panelOutOfDate_In_Main, "Top", 700);
                slidePanels.add(this.panelDetails_In_Main, "Top", 1400);
                slidePanels.run();
            }
            else
            {
                Transition emphasis = new Transition(new TransitionType_Flash(2, 300));
                emphasis.add(this.panelHome_In_Main, "BackColor", Color.Pink);
                emphasis.run();
            }

            Change_Selected_Button(button_Home);
            panelHome_In_Main.Fill_ListBox();
        }


        //-------------------------------------------BUTTONS LEFT - OUTOFDATE BUTTON-------------------------


        //Generated method
        //
        //When the Button_OutOfDate button is clicked, it will show a slide animation from the active panel to the OutOfDate panel.
        //If the active panel is the same as OutOfDate panel then it will do an emphasis animation.
        //It calls the Check_Selected_Button method to check which is the active panel.
        //After the animation, it calls the Change_Selected_Button method to change the button for the active panel.
        //Last, it calls the fillListBox method from the home panel to refresh the listbox elements.
        private void Button_OutOfDate_Click(object sender, EventArgs e)
        {
            if (Check_Active_Button(button_Home))
            {
                panelOutOfDate_In_Main.Location = new Point(0, 700);
                Transition slidePanels = new Transition(new TransitionType_EaseInEaseOut(1000));
                slidePanels.add(this.panelHome_In_Main, "Top", -700);
                slidePanels.add(this.panelOutOfDate_In_Main, "Top", 0);
                slidePanels.run();
            }
            else if (Check_Active_Button(button_Details))
            {
                panelOutOfDate_In_Main.Location = new Point(0, -700);
                Transition slidePanels = new Transition(new TransitionType_EaseInEaseOut(1000));
                slidePanels.add(this.panelDetails_In_Main, "Top", 700); 
                slidePanels.add(this.panelOutOfDate_In_Main, "Top", 0);
                slidePanels.run();
            }
            else
            {
                Transition emphasis = new Transition(new TransitionType_Flash(2, 300));
                emphasis.add(this.panelOutOfDate_In_Main, "BackColor", Color.Pink);
                emphasis.run();
            }

            Change_Selected_Button(button_OutOfDate);
            panelOutOfDate_In_Main.Fill_Listbox(DateTime.Now);
        }


        //-------------------------------------------BUTTONS LEFT - DETAILS BUTTON---------------------------


        //Generated method
        //
        //When the Button_Details button is clicked, it will show a slide animation from the active panel to the Details panel.
        //If the active panel is the same as Details panel then it will do an emphasis animation.
        //It calls the Check_Selected_Button method to check which is the active panel.
        //After the animation, it calls the Change_Selected_Button method to change the button for the active panel.
        private void Button_Details_Click(object sender, EventArgs e)
        {
            if (Check_Active_Button(button_OutOfDate))
            {
                this.panelDetails_In_Main.Location = new Point(0, 700);
                Transition slidePanels = new Transition(new TransitionType_EaseInEaseOut(1000));
                slidePanels.add(this.panelDetails_In_Main, "Top", 0);
                slidePanels.add(this.panelOutOfDate_In_Main, "Top", -700);
                slidePanels.run();
            }
            else if (Check_Active_Button(button_Home))
            {
                this.panelDetails_In_Main.Location = new Point(0, 1400);
                this.panelOutOfDate_In_Main.Location = new Point(0, 700);
                Transition slidePanels = new Transition(new TransitionType_EaseInEaseOut(1000));
                slidePanels.add(this.panelHome_In_Main, "Top", -1400);
                slidePanels.add(this.panelOutOfDate_In_Main, "Top", -700);
                slidePanels.add(this.panelDetails_In_Main, "Top", 0);
                slidePanels.run();
            }
            else
            {
                Transition emphasis = new Transition(new TransitionType_Flash(2, 300));
                emphasis.add(this.panelDetails_In_Main, "BackColor", Color.Pink);
                emphasis.run();
            }

            Change_Selected_Button(button_Details);
        }


        //-------------------------------------------BUTTONS TOP--------------------------------------------


        //-------------------------------------------BUTTONS TOP - REFRESH---------------------------------


        //Generated method
        //
        //When the Button_Refresh button is clicked, it calls the Check_Selected_Button method to check which is the active panel.
        //If it is one of the first two panels, then it will call the fillListBox method on the active panel to refresh the listbox elements.
        private void Button_Refresh_Click(object sender, EventArgs e)
        {
            if (Check_Active_Button(button_Home))
                panelHome_In_Main.Fill_ListBox();
            else if (Check_Active_Button(button_OutOfDate))
                panelOutOfDate_In_Main.Fill_Listbox(DateTime.Now);
        }


        //-------------------------------------------BUTTONS TOP - THEME---------------------------------


        //Generated method
        //
        //When the Button_Theme button is clicked, it calls the Set_Theme(Dark/Light) method according to theme value(true/false).
        //It sets the theme value and it calls the Write_To_File_Theme method which writes to file the value for future app runs.
        private void Button_Theme_Click(object sender, EventArgs e)
        {
            if (theme)
            {
                Set_Theme_Dark();                   //Change theme to dark to current form
                theme = false;                      //Change value to false (dark)
            }
            else
            {
                Set_Theme_Light();                  //Change theme to light to current form
                theme = true;                       //Change value to true (light)
            }
            Write_To_File_Theme(theme);
        }


        //-------------------------------------------BUTTONS TOP - LANGUAGE---------------------------------


        //Generated method
        //
        //When the Button_Language button is clicked, it calls the Change_Language method with the languageEng parameter (true/false)
        private void Button_Language_Click(object sender, EventArgs e)
        {
            Set_Language(!languageEng);
        }


        //-------------------------------------------BUTTONS TOP - EXIT---------------------------------

        //Generated method
        //
        //When the Button_Exit button is clicked, it tries to kill the Server process and then the app. 
        //If the server is not found , then it only closes the app.
        private void Button_Exit_Click(object sender, EventArgs e)
        {
            try
            {
                Process process = Process.GetProcessesByName("Meds-Server")[0];
                if (process != null)
                {
                    //process.Kill(); //Uncomment when needed.
                }
            }
            catch
            {
                
            }
            finally
            {
                this.Close();
            }
        }


        //-------------------------------------------LANGUAGE---------------------------------


        //Input: a bool 
        //Output: -
        //
        //This method calls the Set_Language(Ro/Eng) method acording to value.
        //It changes the languageEng value and calls the methods from the panels to change their languages.
        //It changes the button_Language button to the flag acording to value.
        //Finnaly, it writes the new value to an output file.
        private void Set_Language(bool value)
        {
            if (value)
            {
                Set_Language_Eng(this);
                languageEng = true;
                panelHome_In_Main.Set_Language_Home_Eng();
                panelOutOfDate_In_Main.Set_Language_OutOfDate_Eng();
                panelDetails_In_Main.Set_Language_Eng();
                button_Language.Image = Properties.Resources.LOGO_Flag_Ro;

            }
            else
            {
                Set_Language_Ro(this);
                languageEng = false;
                panelHome_In_Main.Set_Language_Home_Ro();
                panelOutOfDate_In_Main.Set_Language_OutOfDate_Ro();
                panelDetails_In_Main.Set_Language_Ro();
                button_Language.Image = Properties.Resources.Logo_Flag_Uk_Small;
            }

            Write_To_File_Language(languageEng);
        }

        //Input: a MainForm 
        //Output: -
        //
        //This method modifies the text from the buttons and labels from the main form to english.
        //It uses the strings from Resources.
        public static void Set_Language_Eng(MainForm form)
        {
            form.label_Title.Font = new Font("Script MT Bold", 20, FontStyle.Bold);
            form.label_Title.Location = new Point(0, 0);
            form.label_Title.Text = Properties.Resources.Title_eng;
            form.button_Home.Text = Properties.Resources.Home_eng;
            form.button_OutOfDate.Text = Properties.Resources.OutOfDate_eng;
            form.button_OutOfDate.Font = new Font("Franklin Gothic Medium Cond", 16);
            form.button_Details.Text = Properties.Resources.Details_eng;
        }

        //Input: a MainForm 
        //Output: -
        //
        //This method modifies the text from the buttons and labels from the main form to romanian.
        //It uses the strings from Resources.
        public static void Set_Language_Ro(MainForm form)
        {
            form.label_Title.Font = new Font("Script MT Bold", 18, FontStyle.Bold);
            form.label_Title.Location = new Point(0, 2);
            form.label_Title.Text = Properties.Resources.Title_ro;
            form.button_Home.Text = Properties.Resources.Home_ro;
            form.button_OutOfDate.Text = Properties.Resources.OutOfDate_ro;
            form.button_OutOfDate.Font = new Font("Franklin Gothic Medium Cond", 20);
            form.button_Details.Text = Properties.Resources.Details_ro;
        }


        //-------------------------------------------THEME---------------------------------


        //Input: a bool
        //Output: -
        //
        //This method calls the Set_Theme(Dark/Light) method according to the input value(true/false).
        //Sets the active button as the button_Home and modifies the colors according the input value(true/false).
        private void Set_Theme(bool theme)
        {
            if (theme) //theme true = white
            {
                Set_Theme_Light();
                button_Home.BackColor = Color.OldLace;  //Button color
                button_Home.ForeColor = Color.Black;    //Text color
            }
            else //theme false = dark
            {
                Set_Theme_Dark();
                button_Home.BackColor = Color.Black;    //Button color
                button_Home.ForeColor = Color.DarkGray; //Text color
            }
            Write_To_File_Theme(theme);
        }

        //Input: -
        //Output: -
        //
        //This method changes the buttons and other objects from the main form to Dark mode.
        private void Set_Theme_Dark()
        {

            panelHome_In_Main.Set_Theme_Dark();     //Change theme to dark to Home panel
            panelOutOfDate_In_Main.Set_Theme_Dark();//Change theme to dark to OutOfDate panel

            // TOP + TOP-BUTTONS

            button_Theme.Image = Properties.Resources.Logo_Theme_White_small;   //
            button_Refresh.Image = Properties.Resources.LOGO_Refresh_White;     //Sets the logos from the top buttons to white
            button_Exit.Image = Properties.Resources.LOGO_Exit_White;           //

            panel_Top.BackColor =
                button_Refresh.ForeColor = button_Theme.ForeColor = button_Language.ForeColor = button_Exit.ForeColor = //Text Color for buttons
                button_Refresh.BackColor = button_Theme.BackColor = button_Language.BackColor = button_Exit.BackColor = //BackColor for buttons
                button_Refresh.FlatAppearance.BorderColor = button_Theme.FlatAppearance.BorderColor =
                button_Language.FlatAppearance.BorderColor = button_Exit.FlatAppearance.BorderColor =                   //BorderColor for buttons
                ColorTopBlack;

            button_Refresh.FlatAppearance.MouseDownBackColor = button_Theme.FlatAppearance.MouseDownBackColor =
                button_Language.FlatAppearance.MouseDownBackColor = button_Exit.FlatAppearance.MouseDownBackColor =
                Color.Gainsboro;                                                                                        //Color when buttons are pressed

            button_Refresh.FlatAppearance.MouseOverBackColor = button_Theme.FlatAppearance.MouseOverBackColor =
                button_Language.FlatAppearance.MouseOverBackColor = button_Exit.FlatAppearance.MouseOverBackColor =
                Color.Black;                                                                                            //Color when buttons are hovered

            label_Title.ForeColor = Color.White;    //Text Color for title

            // LEFT + LEFT-BUTTONS

            pictureBox_Logo.Image = Properties.Resources.LOGO_Med_White;    //Sets the app logo (top-left) to White

            panel_Left.BackColor = ColorLeftBlack;                          //Sets the left panel color to a RGB value ColorLeftBlack                      

            button_Home.Image = Properties.Resources.LOGO_Home_White;           //
            button_OutOfDate.Image = Properties.Resources.LOGO_OutOfDate_White; //Sets the logos from the left buttons to White
            button_Details.Image = Properties.Resources.LOGO_List_White;        //


            button_Home.ForeColor = button_OutOfDate.ForeColor = button_Details.ForeColor = Color.White;    //Sets the text color of left panel buttons to White

            button_Home.FlatAppearance.MouseDownBackColor = button_OutOfDate.FlatAppearance.MouseDownBackColor =
                button_Details.FlatAppearance.MouseDownBackColor = ColorLeftBlack;      //Sets the color of the left buttons when they are pressed to a RGB value ColorLeftBlack

            button_Home.FlatAppearance.MouseOverBackColor = button_OutOfDate.FlatAppearance.MouseOverBackColor =
                button_Details.FlatAppearance.MouseOverBackColor = Color.Black;         //Sets the color of the left buttons when they are hovered to Black

            if (button_Home.BackColor == Color.OldLace)
            {
                button_Home.BackColor = Color.Black;                                        //Sets the color of the old active button to Black
                button_OutOfDate.BackColor = button_Details.BackColor = ColorLeftBlack;     //Sets the color of the rest of the left side buttons to RGB value ColorLeftBlack
            }
            else if (button_OutOfDate.BackColor == Color.OldLace)
            {
                button_OutOfDate.BackColor = Color.Black;                                   //Sets the color of the old active button to Black
                button_Home.BackColor = button_Details.BackColor = ColorLeftBlack;          //Sets the color of the rest of the left side buttons to RGB value ColorLeftBlack
            }
            else if (button_Details.BackColor == Color.OldLace)
            {
                button_Details.BackColor = Color.Black;                                     //Sets the color of the old active button to Black
                button_Home.BackColor = button_OutOfDate.BackColor = ColorLeftBlack;        //Sets the color of the rest of the left side buttons to RGB value ColorLeftBlack
            }

            panel_Main.BackColor = Color.Black;     //Sets the color of the main panel to Black
        }

        //Input: -
        //Output: -
        //
        //This method changes the buttons and other objects from the main form to Light mode.
        private void Set_Theme_Light()
        {

            panelHome_In_Main.Set_Theme_Light();        //Change theme to light to Home panel
            panelOutOfDate_In_Main.Set_Theme_Light();   //Change theme to light to OutOfDate panel

            // TOP + TOP-BUTTONS

            button_Theme.Image = Properties.Resources.Logo_Theme_Dark_small;    //
            button_Refresh.Image = Properties.Resources.LOGO_Refresh;           //Sets the logos from the top buttons to Black
            button_Exit.Image = Properties.Resources.LOGO_Exit;                 //

            panel_Top.BackColor =
                button_Refresh.ForeColor = button_Theme.ForeColor = button_Language.ForeColor = button_Exit.ForeColor = //Text Color for buttons
                button_Refresh.BackColor = button_Theme.BackColor = button_Language.BackColor = button_Exit.BackColor = //BackColor for buttons
                button_Refresh.FlatAppearance.BorderColor = button_Theme.FlatAppearance.BorderColor = 
                button_Language.FlatAppearance.BorderColor = button_Exit.FlatAppearance.BorderColor =                   //BorderColor for buttons
                Color.Salmon;

            button_Refresh.FlatAppearance.MouseDownBackColor = button_Theme.FlatAppearance.MouseDownBackColor =
                button_Language.FlatAppearance.MouseDownBackColor = button_Exit.FlatAppearance.MouseDownBackColor =
                Color.Gainsboro;                                                                                        //Color when buttons are pressed

            button_Refresh.FlatAppearance.MouseOverBackColor = button_Theme.FlatAppearance.MouseOverBackColor =
                button_Language.FlatAppearance.MouseOverBackColor = button_Exit.FlatAppearance.MouseOverBackColor =
                Color.OldLace;                                                                                          //Color when buttons are hovered

            label_Title.ForeColor = Color.Black;    //Text Color for title

            // LEFT + LEFT-BUTTONS

            pictureBox_Logo.Image = Properties.Resources.LOGO_Med;      //Sets the app logo (top-left) to black

            panel_Left.BackColor = Color.Moccasin;                      //Sets the left panel color to Moccasin

            button_Home.Image = Properties.Resources.LOGO_Home;             //
            button_OutOfDate.Image = Properties.Resources.LOGO_OutOfDate;   //Sets the logos from the left buttons to Black
            button_Details.Image = Properties.Resources.LOGO_List;          //

            button_Home.ForeColor = button_OutOfDate.ForeColor = button_Details.ForeColor = Color.Black;    //Sets the text color of left panel buttons to Black

            button_Home.FlatAppearance.MouseDownBackColor = button_OutOfDate.FlatAppearance.MouseDownBackColor =
                button_Details.FlatAppearance.MouseDownBackColor = Color.Moccasin;      //Sets the color of the left buttons when they are pressed to Moccasin

            button_Home.FlatAppearance.MouseOverBackColor = button_OutOfDate.FlatAppearance.MouseOverBackColor =
                button_Details.FlatAppearance.MouseOverBackColor = Color.OldLace;       //Sets the color of the left buttons when they are hovered to OldLace

            if (button_Home.BackColor == Color.Black) 
            {
                button_Home.BackColor = Color.OldLace;                                      //Sets the color of the old active button to OldLace
                button_OutOfDate.BackColor = button_Details.BackColor = Color.Moccasin;     //Sets the color of the rest of the left side buttons to Moccasin
            }
            else if (button_OutOfDate.BackColor == Color.Black)
            {
                button_OutOfDate.BackColor = Color.OldLace;                                 //Sets the color of the old active button to OldLace
                button_Home.BackColor = button_Details.BackColor = Color.Moccasin;          //Sets the color of the rest of the left side buttons to Moccasin
            }
            else if (button_Details.BackColor == Color.Black)
            {
                button_Details.BackColor = Color.OldLace;                                   //Sets the color of the old active button to OldLace
                button_Home.BackColor = button_OutOfDate.BackColor = Color.Moccasin;        //Sets the color of the rest of the left side buttons to Moccasin
            }

            panel_Main.BackColor = Color.OldLace;   //Sets the color of the main panel to OldLace
        }

    }
}
