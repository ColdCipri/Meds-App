using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meds_App
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
            this.button_Back.Visible = false;
            this.button_Add_Home.Visible = true;
            this.PanelAddMeds_In_Home.Visible = false;
            this.PanelDetails_In_Home.Visible = false;
        }

        private void button_Add_Home_Click(object sender, EventArgs e)
        {
            this.button_Add_Home.Visible = false;
            this.button_Details.Visible = false;
            this.button_Back.Visible = true;
            this.PanelDetails_In_Home.Visible = false;
            this.PanelAddMeds_In_Home.Visible = true;
            this.button_Back.BringToFront();
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.button_Back.Visible = false;
            this.button_Add_Home.Visible = true;
            this.button_Details.Visible = true;
            this.PanelAddMeds_In_Home.Visible = false;
            this.PanelDetails_In_Home.Visible = false;
            this.button_Add_Home.BringToFront();
        }

        private void button_Details_Click(object sender, EventArgs e)
        {
            this.button_Add_Home.Visible = false;
            this.button_Details.Visible = false;
            this.button_Back.Visible = true;
            this.PanelAddMeds_In_Home.Visible = false;
            this.PanelDetails_In_Home.Visible = true;
            this.button_Back.BringToFront();
        }
    }
}
