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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button_Home_Click(object sender, EventArgs e)
        {
            Button_Home.BackColor = Color.OldLace;
            Button_Expired.BackColor = Color.Moccasin;
            Button_Details.BackColor = Color.Moccasin;
        }

        private void Button_Expired_Click(object sender, EventArgs e)
        {
            Button_Home.BackColor = Color.Moccasin;
            Button_Expired.BackColor = Color.OldLace;
            Button_Details.BackColor = Color.Moccasin;
        }

        private void Button_Details_Click(object sender, EventArgs e)
        {
            Button_Home.BackColor = Color.Moccasin;
            Button_Expired.BackColor = Color.Moccasin;
            Button_Details.BackColor = Color.OldLace;
        }
    }
}
