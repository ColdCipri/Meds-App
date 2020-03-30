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

namespace Meds_App
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
            this.button_Back.Location = new Point(1000, 0);
            this.button_Add_Home.Visible = true;
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
        }

        private void button_Details_Click(object sender, EventArgs e)
        {
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
            this.button_Back.BringToFront();
        }
    }
}
