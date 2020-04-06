using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Meds_App.Model;
using Transitions;

namespace Meds_App.UserControls
{
    public partial class OutOfDate : UserControl
    {
        List<Med> medsList = new List<Med>();
        Med medDetails = new Med();
        public OutOfDate()
        {
            InitializeComponent();
            this.PanelDetailsMeds_In_OutOfDate.Location = new Point(1000, 0);
            this.button_OutOfDate_Back.Location = new Point(1000, 0);

        }

        private void OutOfDate_Load(object sender, EventArgs e)
        {
            listBox_OutOfDate.Items.Add("Loading...");
            button_OutOfDate_details.Enabled = false;
            fillListBox(DateTime.Now);
        }

        public async void fillListBox(DateTime date)
        {
            medsList = await Http.GetMedsAsync(true);
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

        private void button_OutOfDate_details_Click(object sender, EventArgs e)
        {
            this.PanelDetailsMeds_In_OutOfDate.fillDetails(medDetails);
            this.button_OutOfDate_Back.Location = new Point(1000, 0);
            this.PanelDetailsMeds_In_OutOfDate.Location = new Point(1000, 0);
            Transition changePannel = new Transition(new TransitionType_EaseInEaseOut(700));
            changePannel.add(this.PanelDetailsMeds_In_OutOfDate, "Left", 0);
            changePannel.add(this.button_OutOfDate_Back, "Left", 3);
            changePannel.add(this.button_OutOfDate_details, "BackColor", Color.OldLace);
            changePannel.add(this.button_OutOfDate_details, "ForeColor", Color.OldLace);
            changePannel.run();
            this.button_OutOfDate_details.Enabled = false;
            this.button_OutOfDate_Back.BringToFront();
        }

        private void button_OutOfDate_Back_Click(object sender, EventArgs e)
        {
            Transition changePannel = new Transition(new TransitionType_EaseInEaseOut(700));
            changePannel.add(this.PanelDetailsMeds_In_OutOfDate, "Left", 1000);
            changePannel.add(this.button_OutOfDate_Back, "Left", 1000);
            changePannel.add(this.button_OutOfDate_details, "BackColor", Color.AntiqueWhite);
            changePannel.add(this.button_OutOfDate_details, "ForeColor", Color.Black);
            changePannel.run();
            fillListBox(dateTimePicker_OutOfDate.Value);
        }

        private void listBox_OutOfDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = listBox_OutOfDate.SelectedIndex;
            if (selectedItem != -1)
            {
                button_OutOfDate_details.Enabled = true;
                medDetails = medsList[selectedItem];
                refreshDetails(medDetails);
            }
        }
        private void refreshDetails(Med medDetails)
        {
            this.PanelDetailsMeds_In_OutOfDate.fillDetails(medDetails);
        }

        private void dateTimePicker_OutOfDate_ValueChanged(object sender, EventArgs e)
        {
            listBox_OutOfDate.Items.Clear();
            fillListBox(dateTimePicker_OutOfDate.Value);
            button_OutOfDate_details.Enabled = false;
        }
    }
}
