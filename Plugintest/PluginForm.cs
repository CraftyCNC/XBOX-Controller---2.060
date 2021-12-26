using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using FormSerialisation;
using Xbox360Controller;

namespace Plugins
{
    public partial class PluginForm : Form
    {
        private Plugininterface.Entry UC;
        UCCNCplugin Pluginmain;
        bool mustclose = false;
        
        //public GamepadState controls;

        private bool goingtoclose = false;
        //private DialogResult res = ;
        DialogResult res;




        public PluginForm(UCCNCplugin Pluginmain)
        {
            this.UC = Pluginmain.UC;
            this.Pluginmain = Pluginmain;
            InitializeComponent();
        }

        private void PluginForm_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            FormSerialisor.Deserialise(this, Application.StartupPath + @"\plugins\xboxcontroller.xml"); // get settings


            //controls = new GamepadState(0);

            System.Threading.Thread.Sleep(1000); // Allow time to load up before proceed.

            // Set hidden items to show if checkboxes 
            checkcustompad();
            check_rightCustomVel();
            check_leftCustomVel();


            if (!checkBox1.Checked)
            {
                DoDisable();
            }
            else
            {
                DoEnable();
            }
        }

  

        private void PluginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Do not close the form when the red X button is pressed
            //But start a Thread which will stop the Loop call from the UCCNC
            //to prevent the form closing while there is a GUI update in the Loop event


            if (goingtoclose==false)
            {
                res = MessageBox.Show("OK to close, Cancel to minimize to taskbar.", "Close?", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }



            if (res == DialogResult.Cancel)
            {
                //if (e.CloseReason == CloseReason.UserClosing)
                e.Cancel = true;
                this.WindowState = FormWindowState.Minimized;

                // MessageBox.Show("You have clicked Cancel Button");
                //Some task…  
            }
                       
            else //if (res == DialogResult.OK)
            {

                if (!mustclose)
                {
                    e.Cancel = true;
                    Thread closethr = new Thread(new ThreadStart(Closeform));
                    closethr.Start();
                    goingtoclose = true;
                }
                else
                {
                    //Form is closing here...
                }
                //MessageBox.Show("You have clicked Ok Button");
                //Some task…  
            }





        }

        public void Closeform()
        {

            

            //Stop the Loop event to update the GUI

            Pluginmain.loopstop = true;
            //Wait until the loop exited
            while (Pluginmain.loopworking)
            {
                Thread.Sleep(10);
            }
            //Set the mustclose variable to true and call the .Close() function to close the Form
            mustclose = true;
            //this.Hide();
            this.Close();
            
        }







        private void button2_Click(object sender, EventArgs e)
        {
            //FormSerialisor.Deserialise(this, Application.StartupPath + @"\plugins\xboxcontroller.xml"); // get settings
        }



        private void button1_Click(object sender, EventArgs e)
        {
            FormSerialisor.Serialise(this, Application.StartupPath + @"\plugins\xboxcontroller.xml");// save settings
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            Pluginmain.controls.Vibrate(5, 0);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pluginmain.controls.Vibrate(0, 0);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }



        private void VisitLink()
        {
            // Change the color of the link text by setting LinkVisited 
            // to true.
            linkLabel1.LinkVisited = true;
            //Call the Process.Start method to open the default browser 
            //with a URL:
            System.Diagnostics.Process.Start("mailto:eabrust@craftycnc.com");
        }



        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Change the color of the link text by setting LinkVisited 
            // to true.
            linkLabel1.LinkVisited = true;
            //Call the Process.Start method to open the default browser 
            //with a URL:
            System.Diagnostics.Process.Start("http:\\www.craftycnc.com");
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                VisitLink2();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }



        private void VisitLink2()
        {
            // Change the color of the link text by setting LinkVisited 
            // to true.
            linkLabel1.LinkVisited = true;
            //Call the Process.Start method to open the default browser 
            //with a URL:
            System.Diagnostics.Process.Start(Application.StartupPath + @"\documentation\Buttons_by_number.htm");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FormSerialisor.Deserialise(this, Application.StartupPath + @"\plugins\xboxcontroller.xml"); // get settings

        }



        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {


            if (Pluginmain.controls.Connected)
            {
                if (checkBox1.Checked == true)
                {
                    cbLeftStickEnab.Enabled = true;
                    cbRightStickEnab.Enabled = true;
                }
                else
                {
                    cbLeftStickEnab.Enabled = false;
                    cbRightStickEnab.Enabled = false;
                }
            }
            else
            {
                NotifyIcon1.BalloonTipTitle = "XBox Controler Not Connected";
                NotifyIcon1.BalloonTipText = "Unable to enable, not connected";
                NotifyIcon1.Text = "XBox Control Not Connected";
                NotifyIcon1.ShowBalloonTip(100);
                NotifyIcon1.Icon = Properties.Resources.XBOFF;

                checkBox1.Checked = false; //"Click to disable"
            }
            
        }


        private void DoEnable()
        {
            //enablemail = True;
            try
            {

            if (Pluginmain.controls.Connected)
            {
                NotifyIcon1.BalloonTipTitle = "XBox Control Activated";
                NotifyIcon1.BalloonTipText = "Enabling Jogging";
                NotifyIcon1.Text = "XBox Control Enabled";
                NotifyIcon1.ShowBalloonTip(100);
                NotifyIcon1.Icon = Properties.Resources.XBON;

            checkBox1.Checked = true; //"Click to disable"
            }
            else
            {
                NotifyIcon1.BalloonTipTitle = "XBox Controler Not Connected";
                NotifyIcon1.BalloonTipText = "Unable to enable, not connected";
                NotifyIcon1.Text = "XBox Control Not Connected";
                NotifyIcon1.ShowBalloonTip(100);
                NotifyIcon1.Icon = Properties.Resources.XBOFF;

                checkBox1.Checked = false; //"Click to disable"
            }
            }
            catch
            {

            }
            



        }

        private void DoDisable()
        {
            NotifyIcon1.BalloonTipTitle = "XBox Control Deactivated";
            NotifyIcon1.BalloonTipText = "Disabling Jogging";
            NotifyIcon1.Text = "XBox Control Disabled";
            NotifyIcon1.ShowBalloonTip(100);
            NotifyIcon1.Icon = Properties.Resources.XBOFF;

            checkBox1.Checked = false; //"Click to disable"

        }


        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //checkBox1.Checked = !checkBox1.Checked;
                if (checkBox1.Checked)
                {
                    DoDisable();
                }
                else
                {
                    DoEnable();
                }
            }

        }




        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void PluginForm_ResizeBegin(object sender, EventArgs e)
        //{

        //    NotifyIcon1.Visible = true;
        //    this.Hide();


        //}

        private void PluginForm_Resize(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Minimized)
            {
                NotifyIcon1.Visible = true;
                this.Hide();
            }
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            if (!Pluginmain.controls.Connected)
            {
                MessageBox.Show("Not connected");

            }
            else
            {
                MessageBox.Show("Connected");
            }
            //controls = new GamepadState(0);
            //    if (controls.Connected)
            //    {

            //    }

            //checkConnected();

            



        }

        public void checkConnected()
        {

            if (Pluginmain.controls.Connected)
            {
                toolStripStatusLabel1.Text = "Connected";
                toolStripStatusLabel1.BackColor = Color.LightGreen;
                //btnConnect.Text = "Connected";
                //btnConnect.BackColor = Color.LightGreen;

            }
            else
            {
                toolStripStatusLabel1.Text = "Not Connected";
                toolStripStatusLabel1.BackColor = Color.MistyRose;
                //btnConnect.Text = "Not Connected";
                //btnConnect.BackColor = Color.MistyRose;
            }
        }




        private void checkcustompad()
        {
            if (checkBox2.Checked) //Customize checkbox is on
            {
                comboBox9.Visible = true;
                comboBox10.Visible = true;
                comboBox11.Visible = true;
                comboBox12.Visible = true;
                comboBox17.Visible = true;
                comboBox18.Visible = true;
                comboBox19.Visible = true;
                comboBox20.Visible = true;
                comboBox21.Visible = true;
                comboBox22.Visible = true;
                comboBox23.Visible = true;
                comboBox24.Visible = true;
                comboBox9.Enabled = true;
                comboBox10.Enabled = true;
                comboBox11.Enabled = true;
                comboBox12.Enabled = true;
                comboBox17.Enabled = true;
                comboBox18.Enabled = true;
                comboBox19.Enabled = true;
                comboBox20.Enabled = true;
                comboBox21.Enabled = true;
                comboBox22.Enabled = true;
                comboBox23.Enabled = true;
                comboBox24.Enabled = true;

                label23.Visible = false;
                label24.Visible = false;
                label25.Visible = false;
                label26.Visible = false;
                label27.Visible = false;
                label28.Visible = false;

                RevXStep.Visible = false;
                RevYStep.Visible = false;
                RevZStep.Visible = false;
            }
            else
            {
                comboBox9.Visible = false;
                comboBox10.Visible = false;
                comboBox11.Visible = false;
                comboBox12.Visible = false;
                comboBox17.Visible = false;
                comboBox18.Visible = false;
                comboBox19.Visible = false;
                comboBox20.Visible = false;
                comboBox21.Visible = false;
                comboBox22.Visible = false;
                comboBox23.Visible = false;
                comboBox24.Visible = false;
                comboBox9.Enabled = false;
                comboBox10.Enabled = false;
                comboBox11.Enabled = false;
                comboBox12.Enabled = false;
                comboBox17.Enabled = false;
                comboBox18.Enabled = false;
                comboBox19.Enabled = false;
                comboBox20.Enabled = false;
                comboBox21.Enabled = false;
                comboBox22.Enabled = false;
                comboBox23.Enabled = false;
                comboBox24.Enabled = false;

                label23.Visible = true;
                label24.Visible = true;
                label25.Visible = true;
                label26.Visible = true;
                label27.Visible = true;
                label28.Visible = true;

                RevXStep.Visible = true;
                RevYStep.Visible = true;
                RevZStep.Visible = true;
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkcustompad();
        }
        // Check of max velocity numeric boxes:

        private void nudMaxVelLSH_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudMaxVelLSV_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudMaxVelRSH_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudMaxVelRSV_ValueChanged(object sender, EventArgs e)
        {

        }

        private void check_leftCustomVel()
        {
            if (cbLSMaxVel.Checked)
            {
                nudMaxVelLSH.Visible = true;
                nudMaxVelLSV.Visible = true;
                label39.Visible = true;
                label46.Visible = true;
            }
            else
            {
                nudMaxVelLSH.Visible = false;
                nudMaxVelLSV.Visible = false;
                label39.Visible = false;
                label46.Visible = false;
            }
        }

        private void check_rightCustomVel()
        {
            if (cbRSMaxVel.Checked)
            {
                nudMaxVelRSH.Visible = true;
                nudMaxVelRSV.Visible = true;
                label40.Visible = true;
                label47.Visible = true;
            }
            else
            {
                nudMaxVelRSH.Visible = false;
                nudMaxVelRSV.Visible = false;
                label40.Visible = false;
                label47.Visible = false;
            }
        }

        private void cbLSMaxVel_CheckedChanged(object sender, EventArgs e)
        {
            check_leftCustomVel();
        }

        private void cbRSMaxVel_CheckedChanged(object sender, EventArgs e)
        {
            check_rightCustomVel();
        }


    }
}
