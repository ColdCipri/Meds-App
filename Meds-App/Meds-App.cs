using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meds_App
{
    public partial class MainForm : Form
    {
        bool languageEng = true;
        public MainForm()
        {
            InitializeComponent();
            this.panelOutOfDate_In_Main.Visible = false;
            this.panelHome_In_Main.Visible = true;
            this.panelHome_In_Main.BringToFront();
        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_Home_Click(object sender, EventArgs e)
        {
            this.panelOutOfDate_In_Main.Visible = false;
            this.panelHome_In_Main.Visible = true;
            this.panelHome_In_Main.BringToFront();
            button_Home.BackColor = Color.OldLace;
            button_Expired.BackColor = Color.Moccasin;
            button_Details.BackColor = Color.Moccasin;
        }

        private void Button_Expired_Click(object sender, EventArgs e)
        {
            this.panelHome_In_Main.Visible = false;
            this.panelOutOfDate_In_Main.Visible = true;
            this.panelOutOfDate_In_Main.BringToFront();
            button_Home.BackColor = Color.Moccasin;
            button_Expired.BackColor = Color.OldLace;
            button_Details.BackColor = Color.Moccasin;
        }

        private void Button_Details_Click(object sender, EventArgs e)
        {
            this.panelHome_In_Main.Visible = false;
            this.panelOutOfDate_In_Main.Visible = false;
            button_Home.BackColor = Color.Moccasin;
            button_Expired.BackColor = Color.Moccasin;
            button_Details.BackColor = Color.OldLace;
        }

        public static void setLanguageEng(MainForm form)
        {
            form.label_Title.Font = new Font("Script MT Bold", 20, FontStyle.Bold);
            form.label_Title.Location = new Point(0, 0);
            form.label_Title.Text = Properties.Resources.Label_Title_eng;
            form.button_Home.Text = Properties.Resources.Label_Home_eng;
            form.button_Expired.Text = Properties.Resources.Label_OutOfDate_eng;
            form.button_Expired.Font = new Font("Franklin Gothic Medium Cond", 16);
            form.button_Details.Text = Properties.Resources.Label_Details_eng;
        }

        public static void setLanguageRo(MainForm form)
        {
            form.label_Title.Font = new Font("Script MT Bold", 18, FontStyle.Bold);
            form.label_Title.Location = new Point(0, 2);
            form.label_Title.Text = Properties.Resources.Label_Title_ro;
            form.button_Home.Text = Properties.Resources.Label_Home_ro;
            form.button_Expired.Text = Properties.Resources.Label_OutOfDate_ro;
            form.button_Expired.Font = new Font("Franklin Gothic Medium Cond", 20);
            form.button_Details.Text = Properties.Resources.Label_Details_ro;
        }

        private void button_Settings_Click(object sender, EventArgs e)
        {
            if (languageEng)
            {
                setLanguageRo(this);
                languageEng = false;
            }
            else
            {
                setLanguageEng(this);
                languageEng = true;
            }
        }

        private void home1_Load(object sender, EventArgs e)
        {

        }
    }
}
