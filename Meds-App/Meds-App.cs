using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;
using Meds_App.Model;

namespace Meds_App
{
    public partial class MainForm : Form
    {
        bool languageEng;
        public MainForm()
        {
            InitializeComponent();
        }
        
        private void Button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_Home_Click(object sender, EventArgs e)
        {
            if (button_OutOfDate.BackColor.Equals(Color.OldLace))
            {
                this.panelHome_In_Main.Location = new Point(0, -700);
                Transition slidePanels = new Transition(new TransitionType_EaseInEaseOut(1000));
                slidePanels.add(this.panelHome_In_Main, "Top", 0);
                slidePanels.add(this.panelOutOfDate_In_Main, "Top", 700);
                slidePanels.run();
            }
            else if (button_Details.BackColor.Equals(Color.OldLace))
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
            button_Home.BackColor = Color.OldLace;
            button_OutOfDate.BackColor = Color.Moccasin;
            button_Details.BackColor = Color.Moccasin;
        }
        
        private void Button_OutOfDate_Click(object sender, EventArgs e)
        {
            if (button_Home.BackColor.Equals(Color.OldLace))
            {
                panelOutOfDate_In_Main.Location = new Point(0, 700);
                Transition slidePanels = new Transition(new TransitionType_EaseInEaseOut(1000));
                slidePanels.add(this.panelHome_In_Main, "Top", -700);
                slidePanels.add(this.panelOutOfDate_In_Main, "Top", 0);
                slidePanels.run();
            }
            else if (button_Details.BackColor.Equals(Color.OldLace))
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
            button_Home.BackColor = Color.Moccasin;
            button_OutOfDate.BackColor = Color.OldLace;
            button_Details.BackColor = Color.Moccasin;

            panelOutOfDate_In_Main.fillListBox(DateTime.Now);
        }

        private void Button_Details_Click(object sender, EventArgs e)
        {
            if (button_OutOfDate.BackColor.Equals(Color.OldLace))
            {
                this.panelDetails_In_Main.Location = new Point(0, 700);
                Transition slidePanels = new Transition(new TransitionType_EaseInEaseOut(1000));
                slidePanels.add(this.panelDetails_In_Main, "Top", 0);
                slidePanels.add(this.panelOutOfDate_In_Main, "Top", -700);
                slidePanels.run();
            }
            else if (button_Home.BackColor.Equals(Color.OldLace))
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
            button_Home.BackColor = Color.Moccasin;
            button_OutOfDate.BackColor = Color.Moccasin;
            button_Details.BackColor = Color.OldLace;
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

        private void button_Language_Click(object sender, EventArgs e)
        {
            changeLanguage(languageEng);
            Utils.Utils.writeToFile(languageEng);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Transition.run(this.panel_Top, "BackColor", Color.Salmon, new TransitionType_Deceleration(1000));
            Transition transitionSlide = new Transition(new TransitionType_Linear(700));
            transitionSlide.add(this.pictureBox_Logo, "Left", 7);
            transitionSlide.add(this.label_Title, "Top", 0);
            transitionSlide.run();
            Transition.run(this.panelHome_In_Main, "Left", 0, new TransitionType_EaseInEaseOut(1000));
            languageEng = Utils.Utils.readFromFile();
            setLanguage(languageEng);
            if (languageEng)
            {
                button_Language.Image = Properties.Resources.LOGO_Flag_Ro;
            }
            else
            {
                button_Language.Image = Properties.Resources.Logo_Flag_Uk_Small;
            }
        }

        private void changeLanguage(bool value)
        {
            if (value)
            {
                setLanguageRo(this);
                languageEng = false;
                panelHome_In_Main.setLanguageRo();
                panelOutOfDate_In_Main.setLanguageRo();
                button_Language.Image = Properties.Resources.Logo_Flag_Uk_Small;
                Utils.Utils.writeToFile(languageEng);
            }
            else
            {
                setLanguageEng(this);
                languageEng = true;
                panelHome_In_Main.setLanguageEng();
                panelOutOfDate_In_Main.setLanguageEng();
                button_Language.Image = Properties.Resources.LOGO_Flag_Ro;
                Utils.Utils.writeToFile(languageEng);
            }
        }

        private void setLanguage(bool value)
        {
            if (value)
            {
                setLanguageEng(this);
                panelHome_In_Main.setLanguageEng();
                panelOutOfDate_In_Main.setLanguageEng();
                button_Language.Image = Properties.Resources.LOGO_Flag_Ro;
                Utils.Utils.writeToFile(languageEng);
                
            }
            else
            {
                setLanguageRo(this);
                panelHome_In_Main.setLanguageRo();
                panelOutOfDate_In_Main.setLanguageRo();
                button_Language.Image = Properties.Resources.Logo_Flag_Uk_Small;
                Utils.Utils.writeToFile(languageEng);
            }
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
    }
}
