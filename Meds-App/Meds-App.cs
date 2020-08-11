using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Transitions;

namespace Meds_App
{
    public partial class MainForm : Form
    {
        //bools for language and theme.
        bool languageEng, theme;

        //colors for black theme
        private static Color ForeColorTitleDarkTheme = Color.FromArgb(169, 169, 169);
        private static Color ColorLeftBlack = Color.FromArgb(24, 24, 24);

        public MainForm()
        {
            InitializeComponent();
        }


        //-------------------------------------------MAIN COMPONENTS--------------------------------------------

        private void MainForm_Load(object sender, EventArgs e)
        {
            Transition transitionSlide = new Transition(new TransitionType_Linear(700));
            transitionSlide.add(this.pictureBox_Logo, "Left", 7);
            transitionSlide.add(this.label_Title, "Top", 0);
            transitionSlide.run();
            Transition.run(this.panelHome_In_Main, "Left", 0, new TransitionType_EaseInEaseOut(1000));
            languageEng = Utils.Utils.readFromFileLanguage();
            theme = Utils.Utils.readFromFileTheme();

            setLanguage(languageEng);
            if (languageEng)
            {
                button_Language.Image = Properties.Resources.LOGO_Flag_Ro;
            }
            else
            {
                button_Language.Image = Properties.Resources.Logo_Flag_Uk_Small;
            }

            setTheme(theme);
        }

        //Add shadow on right-bottom
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

        //-------------------------------------------BUTTONS LEFT--------------------------------------------

        private static bool Check_Selected_Button(Button button)
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

        private void Button_Home_Click(object sender, EventArgs e)
        {


            if (Check_Selected_Button(button_OutOfDate))
            {
                this.panelHome_In_Main.Location = new Point(0, -700);
                Transition slidePanels = new Transition(new TransitionType_EaseInEaseOut(1000));
                slidePanels.add(this.panelHome_In_Main, "Top", 0);
                slidePanels.add(this.panelOutOfDate_In_Main, "Top", 700);
                slidePanels.run();
            }
            else if (Check_Selected_Button(button_Details))
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

            if (theme)
            {
                button_Home.BackColor = Color.OldLace;
                button_OutOfDate.BackColor = Color.Moccasin;
                button_Details.BackColor = Color.Moccasin;
            }
            else
            {
                button_Home.BackColor = Color.Black;
                button_OutOfDate.BackColor = ColorLeftBlack;
                button_Details.BackColor = ColorLeftBlack;
            }


            panelHome_In_Main.fillListBox();
        }
        
        private void Button_OutOfDate_Click(object sender, EventArgs e)
        {
            if (Check_Selected_Button(button_Home))
            {
                panelOutOfDate_In_Main.Location = new Point(0, 700);
                Transition slidePanels = new Transition(new TransitionType_EaseInEaseOut(1000));
                slidePanels.add(this.panelHome_In_Main, "Top", -700);
                slidePanels.add(this.panelOutOfDate_In_Main, "Top", 0);
                slidePanels.run();
            }
            else if (Check_Selected_Button(button_Details))
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

            if (theme)
            {
                button_Home.BackColor = Color.Moccasin;
                button_OutOfDate.BackColor = Color.OldLace;
                button_Details.BackColor = Color.Moccasin;
            }
            else
            {
                button_Home.BackColor = ColorLeftBlack;
                button_OutOfDate.BackColor = Color.Black;
                button_Details.BackColor = ColorLeftBlack;
            }

            panelOutOfDate_In_Main.fillListBox(DateTime.Now);
        }

        private void Button_Details_Click(object sender, EventArgs e)
        {
            if (Check_Selected_Button(button_OutOfDate))
            {
                this.panelDetails_In_Main.Location = new Point(0, 700);
                Transition slidePanels = new Transition(new TransitionType_EaseInEaseOut(1000));
                slidePanels.add(this.panelDetails_In_Main, "Top", 0);
                slidePanels.add(this.panelOutOfDate_In_Main, "Top", -700);
                slidePanels.run();
            }
            else if (Check_Selected_Button(button_Home))
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

            if (theme)
            {
                button_Home.BackColor = Color.Moccasin;
                button_OutOfDate.BackColor = Color.Moccasin;
                button_Details.BackColor = Color.OldLace;
            }
            else
            {
                button_Home.BackColor = ColorLeftBlack;
                button_OutOfDate.BackColor = ColorLeftBlack;
                button_Details.BackColor = Color.Black;
            }
        }

        //-------------------------------------------BUTTONS TOP--------------------------------------------

        //-------------------------------------------BUTTONS TOP - REFRESH---------------------------------

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            if (button_Home.BackColor.Equals(Color.OldLace))
                panelHome_In_Main.fillListBox();
            else if (button_OutOfDate.BackColor.Equals(Color.OldLace))
                panelOutOfDate_In_Main.fillListBox(DateTime.Now);
        }


        //-------------------------------------------BUTTONS TOP - THEME---------------------------------

        private void button_Theme_Click(object sender, EventArgs e)
        {
            if (theme)
            {
                setThemeDark(); //change theme to dark
                theme = false;
                button_Theme.Image = Properties.Resources.Logo_Theme_White_small;
                Utils.Utils.writeToFileTheme(theme);
            }
            else
            {
                setThemeWhite(); //change theme to white
                theme = true;
                button_Theme.Image = Properties.Resources.Logo_Theme_Dark_small;
                Utils.Utils.writeToFileTheme(theme);
            }
        }

        private void setTheme(bool theme)
        {
            if (theme) //theme true = white
            {
                setThemeWhite();
                button_Home.BackColor = Color.OldLace;  //Button color
                button_Home.ForeColor = Color.Black;    //Text color
            }
            else //theme false = dark
            {
                setThemeDark();
                button_Home.BackColor = Color.Black;    //Button color
                button_Home.ForeColor = Color.DarkGray; //Text color
            }
            Utils.Utils.writeToFileTheme(theme);
        }

        private void setThemeDark()
        {
            // TOP + TOP-BUTTONS

            button_Theme.Image = Properties.Resources.Logo_Theme_White_small;
            button_Refresh.Image = Properties.Resources.LOGO_Refresh_White;
            button_Exit.Image = Properties.Resources.LOGO_Exit_White;

            panel_Top.BackColor =
                button_Refresh.ForeColor = button_Theme.ForeColor = button_Language.ForeColor = button_Exit.ForeColor = //ForeColor for buttons
                button_Refresh.BackColor = button_Theme.BackColor = button_Language.BackColor = button_Exit.BackColor = //BackColor for buttons
                button_Refresh.FlatAppearance.BorderColor = button_Theme.FlatAppearance.BorderColor = 
                button_Language.FlatAppearance.BorderColor = button_Exit.FlatAppearance.BorderColor = //BorderColor for buttons
                Color.FromArgb(4,16,86);

            button_Refresh.FlatAppearance.MouseDownBackColor = button_Theme.FlatAppearance.MouseDownBackColor =
                button_Language.FlatAppearance.MouseDownBackColor = button_Exit.FlatAppearance.MouseDownBackColor =
                Color.Gainsboro; //Color when button is pressed

            button_Refresh.FlatAppearance.MouseOverBackColor = button_Theme.FlatAppearance.MouseOverBackColor =
                button_Language.FlatAppearance.MouseOverBackColor = button_Exit.FlatAppearance.MouseOverBackColor =
                Color.Black; //Color when button is hovered

            label_Title.ForeColor = Color.White;

            // LEFT + LEFT-BUTTONS

            pictureBox_Logo.Image = Properties.Resources.LOGO_Med_White;

            panel_Left.BackColor = ColorLeftBlack;

            button_Home.Image = Properties.Resources.LOGO_Home_White;
            button_OutOfDate.Image = Properties.Resources.LOGO_OutOfDate_White;
            button_Details.Image = Properties.Resources.LOGO_List_White;


            button_Home.ForeColor = button_OutOfDate.ForeColor = button_Details.ForeColor = Color.White;
            button_Home.FlatAppearance.MouseOverBackColor = button_OutOfDate.FlatAppearance.MouseOverBackColor =
                button_Details.FlatAppearance.MouseOverBackColor = Color.Black;         //Color when button is hovered

            if (button_Home.BackColor == Color.OldLace)
            {
                button_Home.BackColor = Color.Black;    //Background
                button_OutOfDate.BackColor = button_Details.BackColor = ColorLeftBlack;    //OTHER BUTTONS BACKGROUND
            }
            else if (button_OutOfDate.BackColor == Color.OldLace)
            {
                button_OutOfDate.BackColor = Color.Black;   //Background
                button_Home.BackColor = button_Details.BackColor = ColorLeftBlack;         //OTHER BUTTONS BACKGROUND
            }
            else if (button_Details.BackColor == Color.OldLace)
            {
                button_Details.BackColor = Color.Black;     //Background
                button_Home.BackColor = button_OutOfDate.BackColor = ColorLeftBlack;       //OTHER BUTTONS BACKGROUND
            }

        }

        private void setThemeWhite()
        {
            // TOP + TOP-BUTTONS

            button_Theme.Image = Properties.Resources.Logo_Theme_Dark_small;
            button_Refresh.Image = Properties.Resources.LOGO_Refresh;
            button_Exit.Image = Properties.Resources.LOGO_Exit;

            panel_Top.BackColor = 
                button_Refresh.ForeColor = button_Theme.ForeColor = button_Language.ForeColor = button_Exit.ForeColor = //ForeColor for buttons
                button_Refresh.BackColor = button_Theme.BackColor = button_Language.BackColor = button_Exit.BackColor = //BackColor for buttons
                button_Refresh.FlatAppearance.BorderColor = button_Theme.FlatAppearance.BorderColor = button_Language.FlatAppearance.BorderColor = button_Exit.FlatAppearance.BorderColor = //BorderColor for buttons
                Color.Salmon;

            button_Refresh.FlatAppearance.MouseDownBackColor = button_Theme.FlatAppearance.MouseDownBackColor = 
                button_Language.FlatAppearance.MouseDownBackColor = button_Exit.FlatAppearance.MouseDownBackColor =
                Color.Gainsboro; //Color when button is pressed

            button_Refresh.FlatAppearance.MouseOverBackColor = button_Theme.FlatAppearance.MouseOverBackColor =
                button_Language.FlatAppearance.MouseOverBackColor = button_Exit.FlatAppearance.MouseOverBackColor =
                Color.OldLace; //Color when button is hovered

            label_Title.ForeColor = Color.Black;

            // LEFT + LEFT-BUTTONS

            pictureBox_Logo.Image = Properties.Resources.LOGO_Med;

            panel_Left.BackColor = Color.Moccasin;

            button_Home.Image = Properties.Resources.LOGO_Home;
            button_OutOfDate.Image = Properties.Resources.LOGO_OutOfDate;
            button_Details.Image = Properties.Resources.LOGO_List;

            button_Home.ForeColor = button_OutOfDate.ForeColor = button_Details.ForeColor = Color.Black;
            button_Home.FlatAppearance.MouseOverBackColor = button_OutOfDate.FlatAppearance.MouseOverBackColor =
                button_Details.FlatAppearance.MouseOverBackColor = Color.OldLace;         //Color when button is hovered

            if (button_Home.BackColor == Color.Black) //equivalent in dark mode.
            {
                button_Home.BackColor = Color.OldLace;
                button_OutOfDate.BackColor = button_Details.BackColor = Color.Moccasin;
            }
            else if (button_OutOfDate.BackColor == Color.Black)
            {
                button_OutOfDate.BackColor = Color.OldLace;
                button_Home.BackColor = button_Details.BackColor = Color.Moccasin;
            }
            else if (button_Details.BackColor == Color.Black)
            {
                button_Details.BackColor = Color.OldLace;
                button_Home.BackColor = button_OutOfDate.BackColor = Color.Moccasin;
            }

        }

        //-------------------------------------------BUTTONS TOP - LANGUAGE---------------------------------

        private void button_Language_Click(object sender, EventArgs e)
        {
            changeLanguage(languageEng);
        }

        private void changeLanguage(bool value)
        {
            if (value)
            {
                setLanguageRo(this);
                languageEng = false;
                panelHome_In_Main.setLanguageRo();
                panelOutOfDate_In_Main.setLanguageRo();
                panelDetails_In_Main.setLanguageRo();
                button_Language.Image = Properties.Resources.Logo_Flag_Uk_Small;
                Utils.Utils.writeToFileLanguage(languageEng);
            }
            else
            {
                setLanguageEng(this);
                languageEng = true;
                panelHome_In_Main.setLanguageEng();
                panelOutOfDate_In_Main.setLanguageEng();
                panelDetails_In_Main.setLanguageEng();
                button_Language.Image = Properties.Resources.LOGO_Flag_Ro;
                Utils.Utils.writeToFileLanguage(languageEng);
            }
        }

        private void setLanguage(bool value)
        {
            if (value)
            {
                setLanguageEng(this);
                panelHome_In_Main.setLanguageEng();
                panelOutOfDate_In_Main.setLanguageEng();
                panelDetails_In_Main.setLanguageEng();
                button_Language.Image = Properties.Resources.LOGO_Flag_Ro;
                Utils.Utils.writeToFileLanguage(languageEng);

            }
            else
            {
                setLanguageRo(this);
                panelHome_In_Main.setLanguageRo();
                panelOutOfDate_In_Main.setLanguageRo();
                panelDetails_In_Main.setLanguageRo();
                button_Language.Image = Properties.Resources.Logo_Flag_Uk_Small;
                Utils.Utils.writeToFileLanguage(languageEng);
            }
        }

        public static void setLanguageEng(MainForm form)
        {
            form.label_Title.Font = new Font("Script MT Bold", 20, FontStyle.Bold);
            form.label_Title.Location = new Point(0, 0);
            form.label_Title.Text = Properties.Resources.Title_eng;
            form.button_Home.Text = Properties.Resources.Home_eng;
            form.button_OutOfDate.Text = Properties.Resources.OutOfDate_eng;
            form.button_OutOfDate.Font = new Font("Franklin Gothic Medium Cond", 16);
            form.button_Details.Text = Properties.Resources.Details_eng;
        }

        public static void setLanguageRo(MainForm form)
        {
            form.label_Title.Font = new Font("Script MT Bold", 18, FontStyle.Bold);
            form.label_Title.Location = new Point(0, 2);
            form.label_Title.Text = Properties.Resources.Title_ro;
            form.button_Home.Text = Properties.Resources.Home_ro;
            form.button_OutOfDate.Text = Properties.Resources.OutOfDate_ro;
            form.button_OutOfDate.Font = new Font("Franklin Gothic Medium Cond", 20);
            form.button_Details.Text = Properties.Resources.Details_ro;
        }

        //-------------------------------------------BUTTONS TOP - EXIT---------------------------------

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            try
            {
                Process process = Process.GetProcessesByName("Meds-Server")[0];
                if (process != null)
                {
                    //process.Kill();
                }
                this.Close();
            }
            catch
            {
                this.Close();
            }
        }

    }
}
