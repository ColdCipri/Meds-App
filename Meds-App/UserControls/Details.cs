using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meds_App.UserControls
{
    public partial class Report : UserControl
    {
        public Report()
        {
            InitializeComponent();
        }

        private void button_github_app_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ColdCipri/Meds-App");
        }

        private void button_github_server_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/ColdCipri/Meds-Server");
        }

        public void Set_Language_Ro()
        {
            label_github_app.Text = Properties.Resources.SourceCodeApp_ro;
            label_github_server.Text = Properties.Resources.SourceCodeServer_ro;
            label_details_title.Text = Properties.Resources.Details_ro;
            label_copyright.Text = Properties.Resources.Copyright_ro;
            label_copyright_github.Text = Properties.Resources.CopyrightGithub;
            label_copyright_home.Text = Properties.Resources.CopyrightHome;
            label_copyright_flag.Text = Properties.Resources.CopyrightFlag;
        }

        public void Set_Language_Eng()
        {
            label_github_app.Text = Properties.Resources.SourceCodeApp_eng;
            label_github_server.Text = Properties.Resources.SourceCodeServer_eng;
            label_details_title.Text = Properties.Resources.Details_eng;
            label_copyright.Text = Properties.Resources.Copyright_eng;
            label_copyright_github.Text = Properties.Resources.CopyrightGithub;
            label_copyright_home.Text = Properties.Resources.CopyrightHome;
            label_copyright_flag.Text = Properties.Resources.CopyrightFlag;
        }

        private void button_copyright_github_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/logos");
        }

        private void button_copyright_home_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.iconfinder.com/icons/126572/home_house_icon");
        }

        private void button_copyright_flag_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.pngguru.com/free-transparent-background-png-clipart-beige");
        }
    }
}
