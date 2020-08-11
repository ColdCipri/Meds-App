using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Transitions;
using Meds_App.Model;
using System.Threading;
using System.Diagnostics;

namespace Meds_App
{
    public partial class HomeGUI : UserControl
    {
        private string helpSearch, outofdatedetails, warning, error_retrieve, error, outofdatemeds;
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


        public void button_Back_Click(object sender, EventArgs e)
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
            this.textBox_search.Text = "";
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
                var result = MessageBox.Show(error_retrieve, error, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
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
            try
            {
                Process process = Process.GetProcessesByName("Meds-Server")[0];

            }
            catch (Exception)
            {
                Process.Start(@"C:\Users\colde\source\repos\ColdCipri\Meds-Server\Meds-Server\openServer.bat");
                Thread.Sleep(5000);
            }

            fillListBox();
            showOutOfDateMedicinesCount();
            toolTipForSearch.SetToolTip(textBox_search, helpSearch);
            toolTipForSearch.IsBalloon = true;
            toolTipForSearch.ShowAlways = true;
            toolTipForSearch.ToolTipIcon = ToolTipIcon.Info;
        }

        public async void showOutOfDateMedicinesCount()
        {
            List<Med> outOfDateMeds = await Http.GetOutOfDateMedsAsync(true);
            if (medsList.Count != 0)
            {
                if (outOfDateMeds.Count != 0)
                {
                    MessageBox.Show(outOfDateMeds.Count + outofdatemeds, warning, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show(error_retrieve, error, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void listBox_Meds_SelectedIndexChanged(object sender, EventArgs e)
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
                fillListBox();
            }
        }

        public void Set_Language_Ro()
        {
            button_Add_Home.Text = Properties.Resources.Add_ro;
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
            PanelAddMeds_In_Home.setLanguageRo();
            PanelDetails_In_Home.setLanguageRo();
        }

        public void Set_Language_Eng()
        {
            button_Add_Home.Text = Properties.Resources.Add_eng;
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
            PanelAddMeds_In_Home.setLanguageEng();
            PanelDetails_In_Home.setLanguageEng();
        }
    }
}
