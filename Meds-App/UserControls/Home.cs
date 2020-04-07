using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;
using Meds_App.Model;
using Meds_App.UserControls.Home;

namespace Meds_App
{
    public partial class HomeGUI : UserControl
    {
        string helpSearch = "test";
        ToolTip toolTipForSearch = new ToolTip();
        List<Med> medsList = new List<Med>();
        Med medDetails = new Med();
        public HomeGUI()
        {
            InitializeComponent();
            this.button_Back.Location = new Point(1000, 0);
            this.PanelAddMeds_In_Home.Location = new Point(1000, 0);
            this.PanelDetails_In_Home.Location = new Point(1000, 0);
        }


        private void button_Add_Home_Click(object sender, EventArgs e)
        {
            this.button_Back.Location = new Point(1000, 0);
            this.PanelAddMeds_In_Home.Location = new Point(1000, 0);
            Transition changePannel = new Transition(new TransitionType_EaseInEaseOut(700));
            changePannel.add(this.PanelAddMeds_In_Home, "Left", 0);
            changePannel.add(this.button_Back, "Left", 3);
            changePannel.add(this.button_Add_Home, "BackColor", Color.OldLace);
            changePannel.add(this.button_Add_Home, "ForeColor", Color.OldLace);
            changePannel.add(this.button_Details, "BackColor", Color.OldLace);
            changePannel.add(this.button_Details, "ForeColor", Color.OldLace);
            changePannel.run();
            this.button_Add_Home.Enabled = false;
            this.button_Details.Enabled = false;
            this.button_Back.BringToFront();
        }


        private void button_Back_Click(object sender, EventArgs e)
        {
            if (PanelAddMeds_In_Home.Location.X == 0)
            {
                Transition changePannel = new Transition(new TransitionType_EaseInEaseOut(700));
                changePannel.add(this.PanelAddMeds_In_Home, "Left", 1000);
                changePannel.add(this.button_Back, "Left", 1000);
                changePannel.add(this.button_Add_Home, "BackColor", Color.AntiqueWhite);
                changePannel.add(this.button_Add_Home, "ForeColor", Color.Black);
                changePannel.add(this.button_Details, "BackColor", Color.AntiqueWhite);
                changePannel.add(this.button_Details, "ForeColor", Color.Black);
                changePannel.run();
            }
            else
            {
                Transition changePannel = new Transition(new TransitionType_EaseInEaseOut(700));
                changePannel.add(this.PanelDetails_In_Home, "Left", 1000);
                changePannel.add(this.button_Back, "Left", 1000);
                changePannel.add(this.button_Add_Home, "BackColor", Color.AntiqueWhite);
                changePannel.add(this.button_Add_Home, "ForeColor", Color.Black);
                changePannel.add(this.button_Details, "BackColor", Color.AntiqueWhite);
                changePannel.add(this.button_Details, "ForeColor", Color.Black);
                changePannel.run();
            }
            this.button_Add_Home.Enabled = true;
            fillListBox();
        }

        private void button_Details_Click(object sender, EventArgs e)
        {
            this.PanelDetails_In_Home.fillDetails(medDetails);
            this.button_Back.Location = new Point(1000, 0);
            this.PanelDetails_In_Home.Location = new Point(1000, 0);
            Transition changePannel = new Transition(new TransitionType_EaseInEaseOut(700));
            changePannel.add(this.PanelDetails_In_Home, "Left", 0);
            changePannel.add(this.button_Back, "Left", 3);
            changePannel.add(this.button_Add_Home, "BackColor", Color.OldLace);
            changePannel.add(this.button_Add_Home, "ForeColor", Color.OldLace);
            changePannel.add(this.button_Details, "BackColor", Color.OldLace);
            changePannel.add(this.button_Details, "ForeColor", Color.OldLace);
            changePannel.run();
            this.button_Add_Home.Enabled = false;
            this.button_Details.Enabled = false;
            this.button_Back.BringToFront();
        }

        public async void fillListBox()
        {
            medsList = await Http.GetMedsAsync(true);
            if (medsList.Count == 0)
            {
                var result = MessageBox.Show("Meds cound not be retrived from server!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                while (result == DialogResult.Retry)
                {
                    fillListBox();
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
        }

        private void Home_Load(object sender, EventArgs e)
        {
            listBox_Meds.Items.Add("Loading...");
            button_Details.Enabled = false;
            listBox_Meds.Enabled = false;
            fillListBox();
            toolTipForSearch.SetToolTip(textBox_search, helpSearch);
            toolTipForSearch.IsBalloon = true;
            toolTipForSearch.ShowAlways = true;
            toolTipForSearch.ToolTipIcon = ToolTipIcon.Info;
        }

        private void listBox_Meds_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = listBox_Meds.SelectedIndex;
            if (selectedItem != -1)
            {
                button_Details.Enabled = true;
                medDetails = medsList[selectedItem];
                refreshDetails(medDetails);
            }
            else
            {
                textBox_search.Text = "";
            }
        }

        private void refreshDetails(Med medDetails)
        {
            this.PanelDetails_In_Home.fillDetails(medDetails);
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            listBox_Meds.Items.Clear();
            foreach (var med in medsList)
            {
                if (med.Name.ToLower().Contains(textBox_search.Text.ToLower()) || 
                    med.Description.ToLower().Contains(textBox_search.Text.ToLower()) || 
                    med.BaseSubstance.ToLower().Contains(textBox_search.Text.ToLower()))
                {
                    listBox_Meds.Items.Add(med.Name);
                }
            }

        }

        public void setLanguageRo()
        {
            button_Add_Home.Text = Properties.Resources.Add_ro;
            button_Details.Text = Properties.Resources.Details_ro;
            label_Search.Text = Properties.Resources.Search_ro;
            helpSearch = Properties.Resources.HelpSearch_ro;
            toolTipForSearch.SetToolTip(textBox_search, helpSearch);
            PanelAddMeds_In_Home.setLanguageRo();
            PanelDetails_In_Home.setLanguageRo();
        }

        public void setLanguageEng()
        {
            button_Add_Home.Text = Properties.Resources.Add_eng;
            button_Details.Text = Properties.Resources.Details_eng;
            label_Search.Text = Properties.Resources.Search_eng;
            helpSearch = Properties.Resources.HelpSearch_eng;
            toolTipForSearch.SetToolTip(textBox_search, helpSearch);
            PanelAddMeds_In_Home.setLanguageEng();
            PanelDetails_In_Home.setLanguageEng();
        }
    }
}
