using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Windows.Forms;
using static Meds_App.Utils.Utils;
using System.Net;

namespace Meds_App.UserControls
{
    public partial class ReportBug : UserControl
    {
        private string error_email, error_message, error, failed_to_send,   //Strings for texts. These ones were saved here because they can be modified by the language
            imgFile, success, successfully_sent, imgLocation = "", help;

        private readonly ToolTip toolTipForHelp = new ToolTip();   //It initialises a new ToolTip which would be set later

        //Constructor - Generated method
        //
        public ReportBug()
        {
            InitializeComponent();

            toolTipForHelp.SetToolTip(pictureBox_help, help);
            toolTipForHelp.IsBalloon = true;
            toolTipForHelp.ShowAlways = true;
            toolTipForHelp.ToolTipIcon = ToolTipIcon.Info;
            toolTipForHelp.AutoPopDelay = 13000;


            //throw new Exception(message);
        }


        //-------------------------------------------MAIN COMPONENTS--------------------------------------------


        //-------------------------------------------BUTTONS--------------------------------------------


        //-------------------------------------------BUTTONS - ADD BUTTON-------------------------------


        //Generated method
        //
        //This method checks if there is user input in the email and message textboxes. Then it creates a string with the user name from the name textbox
        //or the first part of the email if there is no name. 
        //It creates the mail addresses where and from where the email will be sent and calls the SendEmail method.
        private void button_Report_Send_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_Email.Text))
            {
                Regex regex = new Regex(@"^[a-zA-Z1-9][a-zA-Z1-9\._-]+@(gmail|hotmail|yahoo|live)\.(com)");//something is not ok here, except the regex
                if (!regex.IsMatch(textBox_Email.Text))
                {
                    MessageBox.Show(error_email, error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
            else if (string.IsNullOrWhiteSpace(textBox_Message.Text))
            {
                MessageBox.Show(error_message, error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string name;

                if (string.IsNullOrWhiteSpace(textBox_Name.Text))
                {
                    name = textBox_Email.Text.Substring(0, textBox_Email.Text.IndexOf("@"));
                }
                else
                {
                    name = textBox_Name.Text;
                }
                string subject = $"Report bug from {name}";

                MailAddress from = new MailAddress(Properties.Resources.Email_user, "Report Bug");
                MailAddress to = new MailAddress(textBox_Email.Text, name);
                try
                {
                    SendEmail(subject, textBox_Message.Text, from, to);
                    MessageBox.Show(successfully_sent, success, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show(failed_to_send, error, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        //-------------------------------------------BUTTONS - ADD PICTURE BUTTON-------------------------------


        //Generated method
        //
        //This method runs when the Add Picture button is clicked
        //It opens a dialog where you can search for photos
        //If you selected a photo, this one will be showed next to the button and the location of the photo will be saved in a variable for later use
        private void button_AddPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = imgFile
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pictureBox.ImageLocation = imgLocation;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }


        //-------------------------------------------UTILS--------------------------------------------


        //Input: string, string, MailAddress and MailAddress
        //Output: -
        //
        //This method creates an instance of Simple Mail Transfer Protocol, I used smtp.gmail.com for google mail and port 587.
        //I needed to store the credentials in the resource file to be a little protective. 
        //Next I created a new instance of MailMessage and I filled the variables in order to be sent.
        //After I send the email, I use the Dispose method to release all the resources that mail was using.
        private void SendEmail(string subject, string message, MailAddress from, MailAddress to)
        {
            SmtpClient mailClient = new SmtpClient("smtp.gmail.com", 587);
            NetworkCredential credentials = new NetworkCredential(Properties.Resources.Email_user, Properties.Resources.Email_password);
            MailMessage msgMail;
            msgMail = new MailMessage
            {
                From = from,
                Subject = subject,
                Body = message,
                IsBodyHtml = true,
            };
            msgMail.To.Add(to);
            if (!imgLocation.Equals(""))
                msgMail.Attachments.Add(new Attachment(imgLocation));
            mailClient.Credentials = credentials;
            mailClient.EnableSsl = true;
            mailClient.Send(msgMail); 
            msgMail.Dispose();
        }

        //-------------------------------------LANGUAGE-------------------------------------


        //-------------------------------------LANGUAGE - RO--------------------------------


        public void Set_Language_Ro()
        {
            label_Title.Font = new Font("Microsoft Sans Serif", 18);
            label_Title.Text = Properties.Resources.Title_Report_ro;
            label_Name.Text = Properties.Resources.Name_ro;
            label_Email.Text = Properties.Resources.Email;
            label_Message.Text = Properties.Resources.ProblemDescription_ro;

            button_AddPicture.Text = Properties.Resources.AddPicture_ro;
            button_Send.Text = Properties.Resources.Send_ro;

            imgFile = Properties.Resources.ImageFiles_ro;
            success = Properties.Resources.Success_ro;

            successfully_sent = Properties.Resources.SuccessfullySend_ro;

            help = Properties.Resources.HelpReport_ro;
            toolTipForHelp.SetToolTip(pictureBox_help, help);
            toolTipForHelp.ToolTipTitle = Properties.Resources.HelpReportTitle_ro;

            setErrorsRo();
        }

        private void setErrorsRo()
        {
            error = Properties.Resources.Error_ro;
            error_email = Properties.Resources.ErrorEmail_ro;
            error_message = Properties.Resources.ErrorMessage_ro;

            successfully_sent = Properties.Resources.SuccessfullySend_ro;
            failed_to_send = Properties.Resources.FailedToSend_ro;
        }


        //-------------------------------------LANGUAGE - ENG--------------------------------


        public void Set_Language_Eng()
        {
            label_Title.Font = new Font("Microsoft Sans Serif", 18);
            label_Title.Text = Properties.Resources.Title_Report_eng;
            label_Name.Text = Properties.Resources.Name_eng;
            label_Email.Text = Properties.Resources.Email;
            label_Message.Text = Properties.Resources.ProblemDescription_eng;

            button_AddPicture.Text = Properties.Resources.AddPicture_eng;
            button_Send.Text = Properties.Resources.Send_eng;

            imgFile = Properties.Resources.ImageFiles_eng;
            success = Properties.Resources.Success_eng;

            successfully_sent = Properties.Resources.SuccessfullySend_eng;

            help = Properties.Resources.HelpReport_eng;
            Console.WriteLine(help);
            toolTipForHelp.SetToolTip(pictureBox_help, help);
            toolTipForHelp.ToolTipTitle = Properties.Resources.HelpReportTitle_eng;

            setErrorsEng();
        }

        private void setErrorsEng()
        {
            error = Properties.Resources.Error_eng;
            error_email = Properties.Resources.ErrorEmail_eng;
            error_message = Properties.Resources.ErrorMessage_eng;

            successfully_sent = Properties.Resources.SuccessfullySend_eng;
            failed_to_send = Properties.Resources.FailedToSend_eng;
        }


        //-------------------------------------THEME-------------------------------------


        //-------------------------------------THEME - DARK------------------------------


        internal void Set_Theme_Dark()
        {
            panel_full.BackColor = Color.Black;  //Set the background color of panel to black

            pictureBox_help.Image = Properties.Resources.LOGO_Help_White;   //Set the help logo to white

            label_Title.ForeColor =             //Set the text color of Title to white

                label_Email.ForeColor =         //Set the text color of Email label to white
                textBox_Email.ForeColor =       //Set the text color of Email textbox to white
                label_Name.ForeColor =          //Set the text color of Name label to white
                textBox_Name.ForeColor =        //Set the text color of Name textbox to white
                label_Message.ForeColor =       //Set the text color of Message label to white
                textBox_Message.ForeColor =     //Set the text color of Message textbox to white
               
                button_AddPicture.ForeColor =   //Set the text color of Add Picture button to white
                button_Send.ForeColor =         //Set the text color of Send button to white
                Color.White;

            textBox_Email.BorderStyle = textBox_Name.BorderStyle = textBox_Message.BorderStyle = BorderStyle.FixedSingle;
            //This command add the borders to the textboxes because they cannot be seen if there is not any border

            textBox_Email.BackColor =           //Sets the background color of the Email textbox to RGB value ColorBackground
                textBox_Name.BackColor =        //Sets the background color of the Name textbox to RGB value ColorBackground
                textBox_Message.BackColor =     //Sets the background color of the Message textbox to a RGB value ColorBackground
                ColorBackground;

            button_AddPicture.FlatAppearance.MouseDownBackColor =   //Sets the color of the Add button when it is clicked to a RGB value ColorMouseDownButtonDark
                button_Send.FlatAppearance.MouseDownBackColor =     //Sets the color of the Send button when it is hovered to a RGB value ColorMouseDownButtonDark
                ColorMouseDownButtonDark;

            button_AddPicture.FlatAppearance.MouseOverBackColor =   //Sets the color of the Add button when it is hovered to a RGB value ColorMouseOverButtonDark
                button_Send.FlatAppearance.MouseOverBackColor =     //Sets the color of the Send button when it is hovered to a RGB value ColorMouseOverButtonDark
                ColorMouseOverButtonDark;


            button_AddPicture.BackColor = ColorButton;  //Sets the background color of Add Picture button to a RGB code ColorButton
            button_Send.BackColor =   //Sets the background color of Save button to a RGB code ColorButtonCRUD
                ColorButtonCRUD;
        }


        //-------------------------------------THEME - LIGHT------------------------------


        internal void Set_Theme_Light()
        {
            panel_full.BackColor = Color.OldLace;//Set the background color of panel to OldLace

            pictureBox_help.Image = Properties.Resources.LOGO_Help;   //Set the help logo to black

            label_Title.ForeColor =             //Set the text color of Title to black

                label_Email.ForeColor =         //Set the text color of Email label to black
                textBox_Email.ForeColor =       //Set the text color of Email textbox to black
                label_Name.ForeColor =          //Set the text color of Name label to black
                textBox_Name.ForeColor =        //Set the text color of Name textbox to black
                label_Message.ForeColor =       //Set the text color of Message label to black
                textBox_Message.ForeColor =     //Set the text color of Message textbox to black
                
                button_AddPicture.ForeColor =   //Set the text color of Add Picture button to black
                button_Send.ForeColor =         //Set the text color of Send button to black
                Color.Black;

            textBox_Email.BorderStyle = textBox_Name.BorderStyle = textBox_Message.BorderStyle = BorderStyle.None;
            //This command removes the borders from the textboxes

            textBox_Email.BackColor =           //Sets the background color of the Email textbox to white
                textBox_Name.BackColor =        //Sets the background color of the Name textbox to white
                textBox_Message.BackColor =     //Sets the background color of the Message textbox to white
                Color.White;

            button_AddPicture.FlatAppearance.MouseDownBackColor =   //Sets the color of the Add button when it is clicked to a RGB value ColorMouseDownButtonLight
                button_Send.FlatAppearance.MouseDownBackColor =     //Sets the color of the Send button when it is hovered to a RGB value ColorMouseDownButtonLight
                ColorMouseDownButtonLight;

            button_AddPicture.FlatAppearance.MouseOverBackColor =   //Sets the color of the Add button when it is hovered to a RGB value ColorMouseOverButtonLight
                button_Send.FlatAppearance.MouseOverBackColor =     //Sets the color of the Send button when it is hovered to a RGB value ColorMouseOverButtonLight
                ColorMouseOverButtonLight;


            button_AddPicture.BackColor = Color.AntiqueWhite;  //Sets the background color of Add Picture button to AntiqueWhite
            button_Send.BackColor =   //Sets the background color of Save button to Moccasin
                Color.Moccasin;

        }
    }
}
