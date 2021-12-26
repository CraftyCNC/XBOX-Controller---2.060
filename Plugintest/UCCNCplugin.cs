using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Timers;
using Xbox360Controller;
using SlimDX;
using SlimDX.XInput;



namespace Plugins
{
    public class UCCNCplugin //Class name must be UCCNCplugin to work! 
    {
        bool firstrun = true;  
        public Plugininterface.Entry UC;
        PluginForm myform;
        public bool loopstop = false;
        public bool loopworking = false;
        //
        #region Declarations

        public bool currentStickState1; // Lx
        public bool previousStickState1; // Lx
        public bool currentStickState2;// Ly
        public bool previousStickState2;// Ly
        public bool currentStickState3;// Rx
        public bool previousStickState3;// Rx
        public bool currentStickState4;// Ry
        public bool previousStickState4;//Ry
        public bool currentStickState5;// Rx2
        public bool previousStickState5;// Rx2



        public bool currentA;
        public bool previousA;
        public bool currentB;
        public bool previousB;
        public bool currentX;
        public bool previousX;
        public bool currentY;
        public bool previousY;
        public bool currentBACK;
        public bool previousBACK;
        public bool currentSTART;
        public bool previousSTART;
        public bool currentLS;
        public bool previousLS;
        public bool currentRS;
        public bool previousRS;
        public bool currentUP;
        public bool previousUP;
        public bool currentDOWN;
        public bool previousDOWN;
        public bool currentLEFT;
        public bool previousLEFT;
        public bool currentRIGHT;
        public bool previousRIGHT;


        
        public bool JogEnable;

        public float lsticky;
        public float lstickx;
        public float rsticky;
        public float rstickx;
        public double jogvelLeft;
        public double jogvelRight;
        public double jogvelSet;
        public int originalVel;

        public int JogPlusGo;
        public int JogMinusGo;
        public int JogPlusStop;
        public int JogMinusStop;
        public int JogSelected;
        
        
        // New 12/19
        public double MaxVelL;
        public double MaxvelR;
        public int axis;
        public bool plusdir;
        public bool minusdir;
        public double LSspeedX;
        public double LSspeedY;
        public double RSspeedX;
        public double RSspeedY;
        public double xmaxVel, ymaxVel, zmaxVel, amaxVel, bmaxVel, cmaxVel;
        public double jogvelLeftX, jogvelLeftY, jogvelRightX, jogvelRightY;
        public double LSMaxSpdX, RSMaxSpdX, LSMaxSpdY, RSMaxSpdY;
        public double LXdb, LYdb, RXdb, RYdb, LXscale, LYscale, RXscale, RYscale;
        public bool stepmode;

//

        // initialize controller
        public GamepadState controls;

        //
        #endregion

        #region Main UC Plugin Stuff
        public UCCNCplugin()
        {
            
        }

        //Called when the plugin is initialised.
        //The parameter is the Plugin interface object which contains all functions prototypes for calls and callbacks.
        public void Init_event(Plugininterface.Entry UC)
        {
            this.UC = UC;
            myform = new PluginForm(this);
        }

        //Called when the plugin is loaded, the author of the plugin should set the details of the plugin here.
        public Plugininterface.Entry.Pluginproperties Getproperties_event(Plugininterface.Entry.Pluginproperties Properties)
        {
            Properties.author = "CraftyCNC";
            Properties.pluginname = "XBox360-Veloc. Control"; 
            Properties.pluginversion = "2.020";
            return Properties;
        }

        //Called from UCCNC when the user presses the Configuration button in the Plugin configuration menu.
        //Typically the plugin configuration window is shown to the user.
        public void Configure_event()
        {
            ConfigForm cform = new ConfigForm();
            cform.ShowDialog(); 
        }

        //Called from UCCNC when the plugin is loaded and started.
        public void Startup_event()
        {

            try
            {
                controls = new GamepadState(0);
            }
            catch
            {
                MessageBox.Show("Unable to open xbox control");
            }


            if (myform.IsDisposed)
            {
                myform = new PluginForm(this);
            }
            myform.Show();
            myform.TopMost = false;  //added to send back





            

        }

        //Called when the Pluginshowup(string Pluginfilename); function is executed in the UCCNC.
        public void Showup_event()
        {
            if (myform.IsDisposed)
            {
                myform = new PluginForm(this);
            }
            myform.Show();
            myform.TopMost = false; // added to send back
            myform.BringToFront();
        }

        //Called when the UCCNC software is closing.
        public void Shutdown_event()
        {
            try
            {
                myform.Close();
            }
            catch (Exception) { }
        }

        #endregion

        #region 20HzLoop

        //Called in a loop with a 25Hz interval.
        public void Loop_event() 
        {
               
            if (loopstop)
            {
                return;
            }

            loopworking = true;

            if (myform == null || myform.IsDisposed)
                return;

            if (firstrun)
            {
                Thread.Sleep(1000);
                
                firstrun = false;
                //Write code here which has to be run on first cycle only...   
                //bool testfeed = int.TryParse(myform.comboBox25.Text, out originalVel);



                myform.label38.Text = "Plugin Version:  " + " 2.020";


                //  GET ALL AXIS MAXIMUM VELOCITIES, TO USE FOR CONVERTING SPEEDS TO PCTs.
                xmaxVel = UC.Getfielddouble(true, 9);
                ymaxVel = UC.Getfielddouble(true, 24);
                zmaxVel = UC.Getfielddouble(true, 39);
                amaxVel = UC.Getfielddouble(true, 54);
                bmaxVel = UC.Getfielddouble(true, 69);
                cmaxVel = UC.Getfielddouble(true, 84);

                if (xmaxVel != ymaxVel)
                {
                    MessageBox.Show("Recommend setting X and Y axis max velocities to same value in UCCNC, and restarting");
                }
            }

            try  /// THIS IS THE MAIN LOOP
            {


                myform.checkConnected();

                try
                {
                   controls.Update();

                }

                catch
                {
                    myform.toolStripStatusLabel2.Text = "Error Updating Control Values";
                }

                #region    GET BUTTON/STICK DATA

                lsticky = (controls.LeftStick.Position.Y);
                lstickx = (controls.LeftStick.Position.X);
                rsticky = (controls.RightStick.Position.Y);
                rstickx = (controls.RightStick.Position.X);
                float ltrig = (controls.LeftTrigger);
                float rtrig = (controls.RightTrigger); 
               

                bool A = controls.A;
                bool B = controls.B;
                bool X = controls.X;
                bool Y = controls.Y;
                bool LS = controls.LeftShoulder;
                bool RS = controls.RightShoulder;
                bool up = controls.DPad.Up;
                bool down = controls.DPad.Down;
                bool left = controls.DPad.Left;
                bool right = controls.DPad.Right;
                bool back = controls.Back;
                bool start = controls.Start;

                // Used for testing feedback
                string LSX = Convert.ToString(lstickx);
                string LSY = Convert.ToString(lsticky);
                string RSX = Convert.ToString(rstickx);
                string RSY = Convert.ToString(rsticky);
                string LT = Convert.ToString(ltrig);
                string RT = Convert.ToString(rtrig);


                string Abutton = Convert.ToString(A);
                string Bbutton = Convert.ToString(B);
                string Xbutton = Convert.ToString(X);
                string Ybutton = Convert.ToString(Y);
                string LSbutton = Convert.ToString(LS);
                string RSbutton = Convert.ToString(RS);
                
                string Upbutton = Convert.ToString(up);
                string Downbutton = Convert.ToString(down);
                string Leftbutton = Convert.ToString(left);
                string Rightbutton = Convert.ToString(right);
                string Backbutton = Convert.ToString(back);
                string Startbutton = Convert.ToString(start);

                myform.label1.Text = "LeftX: " + String.Format("{0:0.000}", lstickx); // UC.Getfield(true, 226);
                myform.label2.Text = "LeftY: " + String.Format("{0:0.000}", lsticky);  // UC.Getfield(true, 227);
                myform.label3.Text = "RightX: " + String.Format("{0:0.000}",rstickx); // UC.Getfield(true, 226);
                myform.label4.Text = "RightY: " + String.Format("{0:0.000}",rsticky);  // UC.Getfield(true, 227);
                myform.label5.Text = "Ltrigger: " + String.Format("{0:0.000}",ltrig); // UC.Getfield(true, 228);
                myform.label6.Text = "Rtrigger: " + String.Format("{0:0.000}",rtrig); // UC.Getfield(true, 229); 

                myform.label7.Text = "A: " + Abutton; // UC.Getfield(true, 228);
                myform.label8.Text = "B: " + Bbutton; // UC.Getfield(true, 229); 
                myform.label9.Text = "X: " + Xbutton; // UC.Getfield(true, 867);
                myform.label10.Text = "Y: " + Ybutton; // UC.Getfield(true, 868);

                myform.label11.Text = "LS: " + LSbutton; // UC.Getfield(true, 228);
                myform.label12.Text = "RS: " + RSbutton; // UC.Getfield(true, 229); 
                myform.label13.Text = "Back: " + Backbutton; // UC.Getfield(true, 867);
                myform.label14.Text = "Start: " + Startbutton; // UC.Getfield(true, 868);

                myform.label15.Text = "DpadUp: " + Upbutton; // UC.Getfield(true, 228);
                myform.label16.Text = "DpadDown: " + Downbutton; // UC.Getfield(true, 229); 
                myform.label17.Text = "DpadL: " + Leftbutton; // UC.Getfield(true, 867);
                myform.label18.Text = "DpadR: " + Rightbutton; // UC.Getfield(true, 868);
                // End testing feedback

                //myform.label19.Text = "feedrate: " + Convert.ToString(0); // UC.Getfield(true, 868);
                //myform.label20.Text = "feedrate: " + Convert.ToString(0); // UC.Getfield(true, 868);


                #endregion   
                
                #region SAFETY ENABLE   
                
                if (myform.radioButton7.Checked)
                {
                    if (ltrig > .5 && rtrig > .5 && myform.checkBox1.Checked)
                        JogEnable = true;
                    else
                        JogEnable = false;
                }
                else if (myform.radioButton8.Checked)
                {
                    if ((ltrig>.5 || rtrig>.5) && myform.checkBox1.Checked)
                        JogEnable = true;
                    else
                        JogEnable = false;
                }
                else if (myform.radioButton9.Checked)
                {
                    JogEnable = myform.checkBox1.Checked;
                }



                #endregion 


                #region PerformButtonActions
                
                
                // Start of stick action and sending jog commands to UCCNC


                if (myform.checkBox1.Checked == true)
                //if (JogEnable==true)
                {
                

                CheckStickLX(lstickx);
                CheckStickLY(lsticky);
                CheckStickRX(rstickx);
                CheckStickRY(rsticky);

                CheckA(A);
                CheckB(B);
                CheckX(X);
                CheckY(Y);
                CheckSTART(start);
                CheckBACK(back);
                CheckLS(LS);
                CheckRS(RS);

                CheckUP(up);
                CheckDOWN(down);
                CheckLEFT(left);
                CheckRIGHT(right);
                }

                #endregion


                // Pickup new velocity default value:
                //bool testfeed = int.TryParse(myform.comboBox25.Text, out originalVel);


                #region Velocity_calcs

                LXdb=Convert.ToDouble(myform.nudLXDeadBand.Value); //Deadband settings
                LYdb= Convert.ToDouble(myform.nudLYdeadband.Value);
                RXdb = Convert.ToDouble(myform.nudRXdeadband.Value);
                RYdb = Convert.ToDouble(myform.nudRYdeadband.Value);
                LXscale = 1 / (1 - LXdb);  // scalefactors to set the stick output to be 0-1.0 after taking off d.band
                LYscale = 1 / (1 - LYdb);
                RXscale = 1 / (1 - RXdb);
                RYscale = 1 / (1 - RYdb);

                //==================================================
                //Right stick velocity
                //==================================================

                //if ((Math.Abs(rsticky) >= .01))  // turn on action for velocity source - removed x axis from check


                if ((Math.Abs(rstickx) >= RXdb) || (Math.Abs(rsticky) >= RYdb))  // turn on action for velocity source
                {



                    if (myform.cbMixAxisJogRS.Checked == false)
                    {
                        if (Math.Abs(rstickx) >= (Math.Abs(rsticky)) && !(myform.comboBoxRXStick.Text == "JogStep"))
                        {
                            jogvelRightY = 0;
                            jogvelRightX = (Math.Abs(rstickx) - RXdb)*RXscale;
                        }

                        if (Math.Abs(rstickx) >= (Math.Abs(rsticky)) && (myform.comboBoxRXStick.Text == "JogStep"))
                        {
                            jogvelRightX = 0;
                        }

                        else if (Math.Abs(rstickx) < (Math.Abs(rsticky)))
                        {
                            jogvelRightX = 0;
                            jogvelRightY = (Math.Abs(rsticky) - RYdb)*RYscale;
                        }
                    }
                    else if (myform.cbMixAxisJogRS.Checked == true)
                    {
                        if (Math.Abs(rstickx) >= (Math.Abs(rsticky)) && (myform.comboBoxRXStick.Text == "JogStep"))
                        {
                            jogvelRightX = 0;
                            jogvelRightY = (Math.Abs(rsticky) - RYdb) * RYscale;
                        }
                        else
                        {
                            jogvelRightX = (Math.Abs(rstickx) - RXdb) * RXscale;
                            jogvelRightY = (Math.Abs(rsticky) - RYdb) * RYscale;
                        }

                    }






                    // sensitivity selector
                    if (myform.radioButton4.Checked)
                    {
                        jogvelRight = jogvelRight * 50;
                        jogvelRightX = jogvelRightX * 50;
                        jogvelRightY = jogvelRightY * 50;
                    }
                    else if (myform.radioButton5.Checked)
                    {
                        jogvelRight = jogvelRight * jogvelRight * 50;//jogvel^2
                        jogvelRightX = jogvelRightX * jogvelRightX * 50;//jogvel^2
                        jogvelRightY = jogvelRightY * jogvelRightY * 50;//jogvel^2
                    }
                    else if (myform.radioButton6.Checked)
                    {
                        jogvelRight = jogvelRight * jogvelRight * jogvelRight * 50;//jogvel^3 best
                        jogvelRightX = jogvelRightX * jogvelRightX * jogvelRightX * 50;//jogvel^3 best
                        jogvelRightY = jogvelRightY * jogvelRightY * jogvelRightY * 50;//jogvel^3 best
                    }
                    //else
                    //    MessageBox.Show("error selecting speed");
                    

                    
                    if (myform.radioButton9.Checked)
                    {
                    double accelRight;                  
                    accelRight = (rtrig + 1); // set accel to be between 1-2 with trigger pull
                    
                    jogvelRight = jogvelRight * accelRight;  //velocity is mix of stick and trigger actions
                    jogvelRightX = jogvelRightX * accelRight;  //velocity is mix of stick and trigger actions
                    jogvelRightY = jogvelRightY * accelRight;  //velocity is mix of stick and trigger actions
                    }
                    else if (myform.radioButton7.Checked || myform.radioButton8.Checked)  // If using the shoulder as a safety.... velocity scale to 100
                    {
                    jogvelRight = jogvelRight * 2;
                    jogvelRightX = jogvelRightX * 2;
                    jogvelRightY = jogvelRightY * 2;
                    }


                    if (jogvelRightX > jogvelRightY)
                    {
                        myform.label20.Text = "feedrate: " + String.Format("{0:0.000}", jogvelRightX) + " %";

                    }
                    else
                    {
                        myform.label20.Text = "feedrate: " + String.Format("{0:0.000}", jogvelRightY) + " %";
                    }


                }


                if (myform.cbMixAxisJogRS.Checked == false)
                {
                    if ((Math.Abs(rstickx) < .01) && (Math.Abs(rsticky) < .01))  // turn on action for velocity source
                    {
                        myform.label20.Text = "feedrate: " + Convert.ToString(0); // UC.Getfield(true, 868);
                    }       
                }
                else
                {
                    if ((Math.Abs(rstickx) < .01) && (Math.Abs(rsticky) < .01))  // turn on action for velocity source
                    {
                        myform.label20.Text = "feedrate: " + Convert.ToString(0); // UC.Getfield(true, 868);
                    }
                }








            //==================================================
            //Left stick velocity
            //==================================================

            if ((Math.Abs(lstickx) >= LXdb) || (Math.Abs(lsticky) >=LYdb))  // turn on action for velocity source
                {

                    if (myform.cbMixAxisJogLS.Checked==false)
                    {
                        if (Math.Abs(lstickx) >= (Math.Abs(lsticky)))
                        {
                            jogvelLeftX = (Math.Abs(lstickx) - LXdb)*LXscale;
                            //jogvelLeftX = 0;
                            jogvelLeftY = 0;
                        }
                        else if (Math.Abs(lstickx) < (Math.Abs(lsticky)))
                        {
                            jogvelLeftY = (Math.Abs(lsticky) - LYdb)*LYscale;
                            jogvelLeftX = 0;
                            //jogvelLeftY = 0;
                        }
                    }
                    else if (myform.cbMixAxisJogLS.Checked == true)
                    {
                            //jogvelLeft = 0;                   
                            jogvelLeftX = (Math.Abs(lstickx) - LXdb) * LXscale;
                            jogvelLeftY = (Math.Abs(lsticky) - LYdb) * LYscale;
                     }



                    // sensitivity selector  
                    if (myform.radioButton1.Checked) // jogvel
                    {                    
                        jogvelLeft = jogvelLeft * 50;
                        jogvelLeftX = jogvelLeftX * 50;
                        jogvelLeftY = jogvelLeftY * 50;
                    }
                    else if (myform.radioButton2.Checked)
                    {
                        jogvelLeft = jogvelLeft * jogvelLeft * 50;//jogvel^2
                        jogvelLeftX = jogvelLeftX * jogvelLeftX * 50;//jogvel^2
                        jogvelLeftY = jogvelLeftY * jogvelLeftY * 50;//jogvel^2
                    }
                    else if (myform.radioButton3.Checked)
                    {
                        jogvelLeft = jogvelLeft * jogvelLeft * jogvelLeft* 50;//jogvel^3 best
                        jogvelLeftX = jogvelLeftX * jogvelLeftX * jogvelLeftX * 50;//jogvel^3 best
                        jogvelLeftY = jogvelLeftY * jogvelLeftY * jogvelLeftY * 50;//jogvel^3 best
                    }
                    //else
                    //    MessageBox.Show("error selecting speed");

                    if (myform.radioButton9.Checked) // If the shoulder button is not safety enable, use to modify velocity
                    {
                        double accelLeft;
                        accelLeft = ltrig + 1; // set accel to be between 1-2 with trigger pull

                        jogvelLeft = jogvelLeft * accelLeft;  //velocity is mix of stick and trigger actions
                        jogvelLeftX = jogvelLeftX * accelLeft;  //velocity is mix of stick and trigger actions
                        jogvelLeftY = jogvelLeftY * accelLeft;  //velocity is mix of stick and trigger actions
                    }
                    else if (myform.radioButton7.Checked ||myform.radioButton8.Checked)  // If using the shoulder as a safety.... velocity scale to 100
                    {
                        jogvelLeft = jogvelLeft * 2;
                        jogvelLeftX = jogvelLeftX * 2;
                        jogvelLeftY = jogvelLeftY * 2;
                    }
                    



                        if (jogvelLeftX > jogvelLeftY)
                        {
                            myform.label19.Text = "feedrate: " + String.Format("{0:0.000}", jogvelLeftX) + " %";

                        }
                        else
                        {
                            myform.label19.Text = "feedrate: " + String.Format("{0:0.000}", jogvelLeftY) + " %";
                        }





                }



                if (myform.cbMixAxisJogLS.Checked == false)
                {
                    if ((Math.Abs(lstickx) < .01) && (Math.Abs(lsticky) < .01))  // turn on action for velocity source
                    {
                        myform.label19.Text = "feedrate: " + Convert.ToString(0); // UC.Getfield(true, 868);
                    }
                }
                else
                {
                    if ((Math.Abs(lstickx) < .01) && (Math.Abs(lsticky) < .01))  // turn on action for velocity source
                    {
                        myform.label19.Text = "feedrate: " + Convert.ToString(0); // UC.Getfield(true, 868);
                    }
                }



                #endregion
                //End of Trigger actions


                myform.toolStripStatusLabel2.Text = "Loop OK";








            }
            catch (Exception)
            {
                // MessageBox.Show("Plugin faulted");
                myform.toolStripStatusLabel2.Text = "Loop Fault";
            }

            loopworking = false;
            //Console.WriteLine("" + Convert.ToInt32('A'));
        }

        #endregion

        //Called when the user presses a button on the UCCNC GUI or if a Callbutton function is executed.
        //The int buttonnumber parameter is the ID of the caller button.
        // The bool onscreen parameter is true if the button was pressed on the GUI and is false if the Callbutton function was called.
        public void Buttonpress_event(int buttonnumber, bool onscreen)
        {
            if (onscreen)
            {
                if (buttonnumber == 128)
                {
                    
                }
            }
        }

        #region Sticks Actions



        // Sub to start/stop axis with button presses based on stick positioning




        #region LeftStick

        //  Left Stick =  X Axis
        public void CheckStickLX(double stick)
        {


            // Assign axis/buttons from pulldowns

            string LXAssign = myform.comboBoxLXStick.Text;

            LSMaxSpdX = Convert.ToDouble(myform.nudMaxVelLSH.Value);

            switch (LXAssign)
            {
                case "Xaxis":
                    axis = 0;
                    plusdir = false;
                    minusdir = true;

    
                    LSspeedX = LSMaxSpdX / xmaxVel * jogvelLeftX;
             

                    break;
                case "Yaxis":
                    axis = 1;
                    plusdir = false;
                    minusdir = true;

                    LSspeedX = LSMaxSpdX / ymaxVel * jogvelLeftX;

                    break;
                case "Zaxis":
                    axis = 2;
                    plusdir = false;
                    minusdir = true;

                    LSspeedX = LSMaxSpdX / zmaxVel * jogvelLeftX;

                    break;
                case "Aaxis":
                    axis = 3;
                    plusdir = false;
                    minusdir = true;

                    LSspeedX = LSMaxSpdX / amaxVel * jogvelLeftX;

                    break;
                case "Baxis":
                    axis = 4;
                    plusdir = false;
                    minusdir = true;

                    LSspeedX = LSMaxSpdX / bmaxVel * jogvelLeftX;

                    break;
                case "Caxis":
                    axis = 5;
                    plusdir = false;
                    minusdir = true;

                    LSspeedX = LSMaxSpdX / cmaxVel * jogvelLeftX;

                    break;

                case "Rev_Xaxis":
                    axis = 0;
                    plusdir = true;
                    minusdir = false;

                    LSspeedX = LSMaxSpdX / xmaxVel * jogvelLeftX;

                    break;
                case "Rev_Yaxis":
                    axis = 1;
                    plusdir = true;
                    minusdir = false;

                    LSspeedX = LSMaxSpdX / ymaxVel * jogvelLeftX;


                    break;
                case "Rev_Zaxis":
                    axis = 2;
                    plusdir = true;
                    minusdir = false;

                    LSspeedX = LSMaxSpdX / zmaxVel * jogvelLeftX;

                    break;
                case "Rev_Aaxis":
                    axis = 3;
                    plusdir = true;
                    minusdir = false;

                    LSspeedX = LSMaxSpdX / amaxVel * jogvelLeftX;

                    break;
                case "Rev_Baxis":
                    axis = 4;
                    plusdir = true;
                    minusdir = false;

                    LSspeedX = LSMaxSpdX / bmaxVel * jogvelLeftX;

                    break;
                case "Rev_Caxis":
                    axis = 5;
                    plusdir = true;
                    minusdir = false;

                    LSspeedX = LSMaxSpdX / zmaxVel * jogvelLeftX;

                    break;

                default:
                    axis = 0;
                    plusdir = true;
                    minusdir = false;

                    break;
            }


            //  Ensure limited to 100, and select if max vel or not
            if (LSspeedX>100)
            {
                LSspeedX = 100;
            }

            if (!myform.cbLSMaxVel.Checked)
            {
                LSspeedX = jogvelLeftX;
            }


            currentStickState1 = (Math.Abs(stick) > Convert.ToDouble(myform.nudLXDeadBand.Value));



            if (JogEnable==true && myform.cbLeftStickEnab.Checked)
                {
                    if (stick > Convert.ToDouble(myform.nudLXDeadBand.Value))
                    {
                        UC100.JogOnSpeed(axis, plusdir, LSspeedX); //' X joy velocity set to 0
                    }
                    else if (stick < -1*Convert.ToDouble(myform.nudLXDeadBand.Value))
                    {
                        UC100.JogOnSpeed(axis, minusdir, LSspeedX); //' X joy velocity set to 0
                    }
                }




            if ((currentStickState1 == false && previousStickState1 == true))  //additional functionality if desired
            {
                //button just released, call other code

                UC100.JogOnSpeed(axis, plusdir, 0); //' X joy velocity set to 0
                LSspeedX = 0; // Default speed back to zero to avoid jumpy starts.
                jogvelLeftX = 0;

            }



            previousStickState1 = currentStickState1;
        }





        //  Left Stick =  Y Axis
        public void CheckStickLY(double stick)
        {


            LSMaxSpdY = Convert.ToDouble(myform.nudMaxVelLSV.Value);




            string LYAssign = myform.comboBoxLYStick.Text;


            switch (LYAssign)
            {
                case "Xaxis":
                    axis = 0;
                    plusdir = false;
                    minusdir = true;

                    LSspeedY = LSMaxSpdY / xmaxVel * jogvelLeftY;


                    break;
                case "Yaxis":
                    axis = 1;
                    plusdir = false;
                    minusdir = true;

                    LSspeedY = LSMaxSpdY / ymaxVel * jogvelLeftY;

                    break;
                case "Zaxis":
                    axis = 2;
                    plusdir = false;
                    minusdir = true;

                    LSspeedY = LSMaxSpdY / zmaxVel * jogvelLeftY;

                    break;
                case "Aaxis":
                    axis = 3;
                    plusdir = false;
                    minusdir = true;

                    LSspeedY = LSMaxSpdY / amaxVel * jogvelLeftY;

                    break;
                case "Baxis":
                    axis = 4;
                    plusdir = false;
                    minusdir = true;

                    LSspeedY = LSMaxSpdY / bmaxVel * jogvelLeftY;

                    break;
                case "Caxis":
                    axis = 5;
                    plusdir = false;
                    minusdir = true;

                    LSspeedY = LSMaxSpdY / cmaxVel * jogvelLeftY;

                    break;

                case "Rev_Xaxis":
                    axis = 0;
                    plusdir = true;
                    minusdir = false;

                    LSspeedY = LSMaxSpdY / xmaxVel * jogvelLeftY;

                    break;
                case "Rev_Yaxis":
                    axis = 1;
                    plusdir = true;
                    minusdir = false;

                    LSspeedY = LSMaxSpdY / ymaxVel * jogvelLeftY;


                    break;
                case "Rev_Zaxis":
                    axis = 2;
                    plusdir = true;
                    minusdir = false;

                    LSspeedY = LSMaxSpdY / zmaxVel * jogvelLeftY;

                    break;
                case "Rev_Aaxis":
                    axis = 3;
                    plusdir = true;
                    minusdir = false;

                    LSspeedY = LSMaxSpdY / amaxVel * jogvelLeftY;

                    break;
                case "Rev_Baxis":
                    axis = 4;
                    plusdir = true;
                    minusdir = false;

                    LSspeedY = LSMaxSpdY / bmaxVel * jogvelLeftY;

                    break;
                case "Rev_Caxis":
                    axis = 5;
                    plusdir = true;
                    minusdir = false;

                    LSspeedY = LSMaxSpdY / zmaxVel * jogvelLeftY;

                    break;

                default:
                    axis = 0;
                    plusdir = true;
                    minusdir = false;

                    break;
            }



            //  Ensure limited to 100, and select if max vel or not
            if (LSspeedY > 100)
            {
                LSspeedY = 100;
            }

            if (!myform.cbLSMaxVel.Checked)
            {
                LSspeedY = jogvelLeftY;
            }


            currentStickState2 = (Math.Abs(stick) > Convert.ToDouble(myform.nudLYdeadband.Value));


            if (JogEnable == true && myform.cbLeftStickEnab.Checked)
            {
                if (stick > Convert.ToDouble(myform.nudLYdeadband.Value))
                {
                    UC100.JogOnSpeed(axis, plusdir, LSspeedY); //' X joy velocity set to 0
                }
                else if (stick < -1* Convert.ToDouble(myform.nudLYdeadband.Value))
                {
                    UC100.JogOnSpeed(axis, minusdir, LSspeedY); //' X joy velocity set to 0
                }
            }





            if ((currentStickState2 == false && previousStickState2 == true))  //additional functionality if desired
            {
                UC100.JogOnSpeed(axis, plusdir, 0);
                LSspeedY = 0;
                jogvelLeftY = 0;
            }




            previousStickState2 = currentStickState2;
        }

        #endregion

        #region "Right Stick"

        //  Right Stick =  X Axis
        public void CheckStickRX(double stick)
        {

            RSMaxSpdX = Convert.ToDouble(myform.nudMaxVelRSH.Value);


            currentStickState3 = (Math.Abs(stick) > Convert.ToDouble(myform.nudRXdeadband.Value));


            string RXAssign = myform.comboBoxRXStick.Text;

            bool JogStepSelect=false;

            switch (RXAssign)
            {
                case "Xaxis":
                    axis = 0;
                    plusdir = false;
                    minusdir = true;

                    RSspeedX = RSMaxSpdX / xmaxVel * jogvelRightX;


                    break;
                case "Yaxis":
                    axis = 1;
                    plusdir = false;
                    minusdir = true;

                    RSspeedX = RSMaxSpdX / ymaxVel * jogvelRightX;

                    break;
                case "Zaxis":
                    axis = 2;
                    plusdir = false;
                    minusdir = true;

                    RSspeedX = RSMaxSpdX / zmaxVel * jogvelRightX;

                    break;
                case "Aaxis":
                    axis = 3;
                    plusdir = false;
                    minusdir = true;

                    RSspeedX = RSMaxSpdX / amaxVel * jogvelRightX;

                    break;
                case "Baxis":
                    axis = 4;
                    plusdir = false;
                    minusdir = true;

                    RSspeedX = RSMaxSpdX / bmaxVel * jogvelRightX;

                    break;
                case "Caxis":
                    axis = 5;
                    plusdir = false;
                    minusdir = true;

                    RSspeedX = RSMaxSpdX / cmaxVel * jogvelRightX;

                    break;

                case "Rev_Xaxis":
                    axis = 0;
                    plusdir = true;
                    minusdir = false;

                    RSspeedX = RSMaxSpdX / xmaxVel * jogvelRightX;

                    break;
                case "Rev_Yaxis":
                    axis = 1;
                    plusdir = true;
                    minusdir = false;

                    RSspeedX = RSMaxSpdX / ymaxVel * jogvelRightX;


                    break;
                case "Rev_Zaxis":
                    axis = 2;
                    plusdir = true;
                    minusdir = false;

                    RSspeedX = RSMaxSpdX / zmaxVel * jogvelRightX;

                    break;
                case "Rev_Aaxis":
                    axis = 3;
                    plusdir = true;
                    minusdir = false;

                    RSspeedX = RSMaxSpdX / amaxVel * jogvelRightX;

                    break;
                case "Rev_Baxis":
                    axis = 4;
                    plusdir = true;
                    minusdir = false;

                    RSspeedX = RSMaxSpdX / bmaxVel * jogvelRightX;

                    break;
                case "Rev_Caxis":
                    axis = 5;
                    plusdir = true;
                    minusdir = false;

                    RSspeedX = RSMaxSpdX / zmaxVel * jogvelRightX;

                    break;



                case "JogStep":
                    axis = 0;
                    plusdir = false;
                    minusdir = true;

                    JogStepSelect = true;

                    break;

                default:
                    axis = 0;
                    plusdir = true;
                    minusdir = false;

                    break;
                                       

            }



            if (JogStepSelect == false)
            {

                //  Ensure limited to 100, and select if max vel or not
                if (RSspeedX > 100)
                {
                    RSspeedX = 100;
                }

                if (!myform.cbRSMaxVel.Checked)
                {
                    RSspeedX = jogvelRightX;
                }



                if (JogEnable == true && myform.cbRightStickEnab.Checked)
                {
                    if (stick > Convert.ToDouble(myform.nudRXdeadband.Value))
                    {
                        UC100.JogOnSpeed(axis, plusdir, RSspeedX); //' X joy velocity set to 0
                    }
                    else if (stick < -1* Convert.ToDouble(myform.nudRXdeadband.Value))
                    {
                        UC100.JogOnSpeed(axis, minusdir, RSspeedX); //' X joy velocity set to 0
                    }
                }


                if ((currentStickState3 == false && previousStickState3 == true))  //additional functionality if desired
                {

                    UC100.JogOnSpeed(axis, plusdir, 0);
                    RSspeedX = 0;
                    jogvelRightX = 0;

                }


                previousStickState3 = currentStickState3;

            }


            #region"jog select"

            if (JogStepSelect == true && !UC.IsMoving() && myform.cbRightStickEnab.Checked)
            {


                //int JogSelected = 0;
                currentStickState5 = (Math.Abs(stick) > .8);
                currentStickState3 = (Math.Abs(stick) > .2);

                if (currentStickState5 == true && previousStickState5 == false)
                {
                    //button just pressed, call code

                    //originalVel = Convert.ToDouble(UC.Getfield(false, 913));  // get original feedrate
                    if (((Math.Abs(rstickx) > Math.Abs(rsticky))))
                    {
                        if (stick > 0)
                        {
                            JogSelected = 4;
                            double Jog4;
                            bool test = double.TryParse(myform.jog4.Text, out Jog4);
                            if (test)
                            {
                                UC.Setfield(false, Jog4, 2027);
                                UC.Validatefield(false, 2027);
                            }
                            else  // default value
                            {
                                UC.Callbutton(166);   // Full left code
                            }



                        }
                        else
                        {

                            //full left code  // override value
                            JogSelected = 1;
                            double Jog1;
                            bool test = double.TryParse(myform.jog1.Text, out Jog1);
                            if (test)
                            {
                                UC.Setfield(false, Jog1, 2027);
                                UC.Validatefield(false, 2027);
                            }
                            else  // default value
                            {
                                UC.Callbutton(241);   // Full left code
                            }


                        }
                    }
                }




                if (currentStickState3 == true && previousStickState3 == false)
                {
                    //button just pressed, call code

                    //originalVel = Convert.ToDouble(UC.Getfield(false, 913));  // get original feedrate
                    if (((Math.Abs(rstickx) > Math.Abs(rsticky))))
                    {
                        if (stick > 0)
                        {

                            JogSelected = 3;
                            double Jog3;
                            bool test = double.TryParse(myform.jog3.Text, out Jog3);
                            if (test)
                            {
                                UC.Setfield(false, Jog3, 2027);
                                UC.Validatefield(false, 2027);

                            }
                            else  // default value
                            {
                                UC.Callbutton(165);   // Full left code
                            }


                        }
                        else
                        {

                            //full left code  // override value
                            JogSelected = 2;
                            double Jog2;
                            bool test = double.TryParse(myform.jog2.Text, out Jog2);
                            if (test)
                            {
                                UC.Setfield(false, Jog2, 2027);
                                UC.Validatefield(false, 2027);
                            }
                            else  // default value
                            {
                                UC.Callbutton(164);   // Full left code
                            }
                        }
                    }
                }


                if (currentStickState3 == false && previousStickState3 == true)
                //additional functionality if desired-released
                {

                    if (myform.checkBox4.Checked && !UC.IsMoving())
                    {
                        if (JogSelected == 1)
                        {
                            Shake(1);
                            //Console.Beep();
                            //Console.Beep(10, 50);
                            //System.Media.SystemSounds.Beep.Play();
                        }
                        else if (JogSelected == 2)
                        {
                            Shake(2);
                            //System.Media.SystemSounds.Asterisk.Play();
                        }
                        else if (JogSelected == 3)
                        {
                            Shake(3);
                            //System.Media.SystemSounds.Hand.Play();
                        }
                        else if (JogSelected == 4)
                        {
                            Shake(4);
                            //System.Media.SystemSounds.Exclamation.Play();
                        }
                    }

                }

                previousStickState3 = currentStickState3;
                previousStickState5 = currentStickState5;



            }
        }


        #endregion


        //  Right Stick =  Y Axis
        public void CheckStickRY(double stick)
        {
            currentStickState4 = (Math.Abs(stick) > Convert.ToDouble(myform.nudRYdeadband.Value));


            RSMaxSpdY = Convert.ToDouble(myform.nudMaxVelRSV.Value);



            string RYAssign = myform.comboBoxRYStick.Text;




            switch (RYAssign)
            {
                case "Xaxis":
                    axis = 0;
                    plusdir = false;
                    minusdir = true;

                    RSspeedY = RSMaxSpdY / xmaxVel * jogvelRightY;


                    break;
                case "Yaxis":
                    axis = 1;
                    plusdir = false;
                    minusdir = true;

                    RSspeedY = RSMaxSpdY / ymaxVel * jogvelRightY;

                    break;
                case "Zaxis":
                    axis = 2;
                    plusdir = false;
                    minusdir = true;

                    RSspeedY = RSMaxSpdY / zmaxVel * jogvelRightY;

                    break;
                case "Aaxis":
                    axis = 3;
                    plusdir = false;
                    minusdir = true;

                    RSspeedY = RSMaxSpdY / amaxVel * jogvelRightY;

                    break;
                case "Baxis":
                    axis = 4;
                    plusdir = false;
                    minusdir = true;

                    RSspeedY = RSMaxSpdY / bmaxVel * jogvelRightY;

                    break;
                case "Caxis":
                    axis = 5;
                    plusdir = false;
                    minusdir = true;

                    RSspeedY = RSMaxSpdY / cmaxVel * jogvelRightY;

                    break;

                case "Rev_Xaxis":
                    axis = 0;
                    plusdir = true;
                    minusdir = false;

                    RSspeedY = RSMaxSpdY / xmaxVel * jogvelRightY;

                    break;
                case "Rev_Yaxis":
                    axis = 1;
                    plusdir = true;
                    minusdir = false;

                    RSspeedY = RSMaxSpdY / ymaxVel * jogvelRightY;


                    break;
                case "Rev_Zaxis":
                    axis = 2;
                    plusdir = true;
                    minusdir = false;

                    RSspeedY = RSMaxSpdY / zmaxVel * jogvelRightY;

                    break;
                case "Rev_Aaxis":
                    axis = 3;
                    plusdir = true;
                    minusdir = false;

                    RSspeedY = RSMaxSpdY / amaxVel * jogvelRightY;

                    break;
                case "Rev_Baxis":
                    axis = 4;
                    plusdir = true;
                    minusdir = false;

                    RSspeedY = RSMaxSpdY / bmaxVel * jogvelRightY;

                    break;
                case "Rev_Caxis":
                    axis = 5;
                    plusdir = true;
                    minusdir = false;

                    RSspeedY = RSMaxSpdY / zmaxVel * jogvelRightY;

                    break;



                default:
                    axis = 0;
                    plusdir = true;
                    minusdir = false;

                    break;
            }



            //  Ensure limited to 100, and select if max vel or not
            if (RSspeedY > 100)
            {
                RSspeedY = 100;
            }

            if (!myform.cbRSMaxVel.Checked)
            {
                RSspeedY = jogvelRightY;
            }


            if (JogEnable == true && myform.cbRightStickEnab.Checked)
            {
                if (stick > Convert.ToDouble(myform.nudRYdeadband.Value))
                {
                    UC100.JogOnSpeed(axis, plusdir, RSspeedY); //' X joy velocity set to 0
                }
                else if (stick < -1* Convert.ToDouble(myform.nudRYdeadband.Value))
                {
                    UC100.JogOnSpeed(axis, minusdir, RSspeedY); //' X joy velocity set to 0
                }
            }



            if ((currentStickState4 == false && previousStickState4 == true))  //additional functionality if desired
            {

                UC100.JogOnSpeed(axis, plusdir, 0);
                RSspeedY = 0;
                jogvelRightY = 0;
            }


            previousStickState4 = currentStickState4;
        }

        #endregion

        #endregion


        #region Button Actions
        // Button state checks and actions to perform
        //  A Button
        public void CheckA(bool A)
        {
            currentA = A;

            if (currentA == true && previousA == false)
            {
                //button just pressed, call code
                {
                    int OnA;
                    bool test = Int32.TryParse(myform.comboBox2.Text, out OnA);

                    //int OnA = Convert.ToInt32(myform.comboBox2.Text);
                    if (test)
                    {
                        UC.Callbutton(OnA);  // Z+ Jog code
                    }
                }
            }
            if (currentA == false && previousA == true)  //additional functionality if desired
            {
                //button just released, call other code
                int OffA;
                bool test = Int32.TryParse(myform.comboBox1.Text, out OffA);

                //int OffA = Convert.ToInt32(myform.comboBox1.Text);
                if (test)
                {
                    UC.Callbutton(OffA);// Z Jog stop codes
                }

            }

            previousA = currentA;
        }

        //  B Button
        public void CheckB(bool B)
        {
            currentB = B;

            if (currentB == true && previousB == false)
            {
                //button just pressed, call code

                {
                    int OnB;
                    bool test = Int32.TryParse(myform.comboBox4.Text, out OnB);

                    //int OnA = Convert.ToInt32(myform.comboBox2.Text);
                    if (test)
                    {
                        UC.Callbutton(OnB);  // Z+ Jog code
                    }
                }

            }
            if (currentB == false && previousB == true)  //additional functionality if desired
            {
                //button just released, call other code
                int OffB;
                bool test = Int32.TryParse(myform.comboBox3.Text, out OffB);

                //int OffA = Convert.ToInt32(myform.comboBox1.Text);
                if (test)
                {
                    UC.Callbutton(OffB);// Z Jog stop codes
                }
            }


            previousB = currentB;
        }


        //  X Button
        public void CheckX(bool X)
        {
            currentX = X;

            if (currentX == true && previousX == false)
            {
                //button just pressed, call code
                {
                    int OnX;
                    bool test = Int32.TryParse(myform.comboBox6.Text, out OnX);

                    //int OnA = Convert.ToInt32(myform.comboBox2.Text);
                    if (test)
                    {
                        UC.Callbutton(OnX);  // Z+ Jog code
                    }
                }

            }
            if (currentX == false && previousX == true)  //additional functionality if desired
            {
                //button just released, call other code
                int OffX;
                bool test = Int32.TryParse(myform.comboBox5.Text, out OffX);

                //int OffA = Convert.ToInt32(myform.comboBox1.Text);
                if (test)
                {
                    UC.Callbutton(OffX);// Z Jog stop codes
                }
            }


            previousX = currentX;
        }


        //  Y Button
        public void CheckY(bool Y)
        {
            currentY = Y;

            if (currentY == true && previousY == false)
            {
                //button just pressed, call code
                {
                    int OnY;
                    bool test = Int32.TryParse(myform.comboBox8.Text, out OnY);

                    //int OnA = Convert.ToInt32(myform.comboBox2.Text);
                    if (test)
                    {
                        UC.Callbutton(OnY);  // Z+ Jog code
                    }
                }

            }
            if (currentY == false && previousY == true)  //additional functionality if desired
            {
                //button just released, call other code
                int OffY;
                bool test = Int32.TryParse(myform.comboBox7.Text, out OffY);

                //int OffA = Convert.ToInt32(myform.comboBox1.Text);
                if (test)
                {
                    UC.Callbutton(OffY);// Z Jog stop codes
                }
            }


            previousY = currentY;
        }

        //  LS Button
        public void CheckLS(bool LS)
        {
            currentLS = LS;



            if (!myform.checkBox2.Checked)
            {
                if (!myform.RevZStep.Checked)
                {

                    if (currentLS == true && previousLS == false)
                    {
                        //button just pressed, call code
                        stepmode = UC.GetLED(146);  //True if step mode, false if cont. mode

                        UC.Callbutton(162); // set mode to step jog

                        UC.Callbutton(151); //Jog z+
                    }
                    if (currentLS == false && previousLS == true)  //additional functionality if desired
                    {
                        //button just released, call other code

                        UC.Callbutton(233); // axis stop

                        // Reset back to step or continuous
                        if (stepmode)
                        {
                            UC.Callbutton(162); // set mode to step jog
                        }
                        else
                        {
                            UC.Callbutton(161); // set mode to continuous jog
                        }

                    }
                }
                else
                {
                    if (currentLS == true && previousLS == false)
                    {
                        //button just pressed, call code
                        stepmode = UC.GetLED(146);  //True if step mode, false if cont. mode


                        UC.Callbutton(162); // set mode to step jog

                        UC.Callbutton(152); //Jog z-
                    }
                    if (currentLS == false && previousLS == true)  //additional functionality if desired
                    {
                        //button just released, call other code

                        UC.Callbutton(234); // axis stop

                        // Reset back to step or continuous
                        if (stepmode)
                        {
                        UC.Callbutton(162); // set mode to step jog
                        }
                        else
                        {
                        UC.Callbutton(161); // set mode to continuous jog
                        }


                    }
                }
            }
            else  // Use Customize code in boxes!
            {

                if (currentLS == true && previousLS == false)
                {
                    //button just pressed, call code
                    {
                        int OnLS;
                        bool test = Int32.TryParse(myform.comboBox10.Text, out OnLS);

                        //int OnA = Convert.ToInt32(myform.comboBox2.Text);
                        if (test)
                        {
                            UC.Callbutton(OnLS);  // Z+ Jog code
                        }
                    }

                }
                if (currentLS == false && previousLS == true)  //additional functionality if desired
                {
                    //button just released, call other code
                    int OffLS;
                    bool test = Int32.TryParse(myform.comboBox9.Text, out OffLS);

                    //int OffA = Convert.ToInt32(myform.comboBox1.Text);
                    if (test)
                    {
                        UC.Callbutton(OffLS);// Z Jog stop codes
                    }
                }

            }

            previousLS = currentLS;
        }

        //  RS Button
        public void CheckRS(bool RS)
        {
            currentRS = RS;


            if (!myform.checkBox2.Checked)
            {

                if (!myform.RevZStep.Checked)
                {
                    if (currentRS == true && previousRS == false)
                    {
                        //button just pressed, call code
                        stepmode = UC.GetLED(146);  //True if step mode, false if cont. mode


                        UC.Callbutton(162); // set mode to step jog

                        UC.Callbutton(152); //Jog z-
                    }
                    if (currentRS == false && previousRS == true)  //additional functionality if desired
                    {
                        //button just released, call other code


                        UC.Callbutton(234); // axis stop

                        // Reset back to step or continuous
                        if (stepmode)
                        {
                            UC.Callbutton(162); // set mode to step jog
                        }
                        else
                        {
                            UC.Callbutton(161); // set mode to continuous jog
                        }

                    }
                }
                else
                {
                    if (currentRS == true && previousRS == false)
                    {
                        //button just pressed, call code
                        stepmode = UC.GetLED(146);  //True if step mode, false if cont. mode


                        UC.Callbutton(162); // set mode to step jog

                        UC.Callbutton(151); //Jog z+
                    }
                    if (currentRS == false && previousRS == true)  //additional functionality if desired
                    {
                        //button just released, call other code

                        UC.Callbutton(233); // axis stop

                        // Reset back to step or continuous
                        if (stepmode)
                        {
                            UC.Callbutton(162); // set mode to step jog
                        }
                        else
                        {
                            UC.Callbutton(161); // set mode to continuous jog
                        }

                    }
                }
            }
            else
            {
                {

                    if (currentRS == true && previousRS == false)
                    {
                        //button just pressed, call code
                        {
                            int OnRS;
                            bool test = Int32.TryParse(myform.comboBox12.Text, out OnRS);

                            //int OnA = Convert.ToInt32(myform.comboBox2.Text);
                            if (test)
                            {
                                UC.Callbutton(OnRS);  // Z+ Jog code
                            }
                        }

                    }
                    if (currentRS == false && previousRS == true)  //additional functionality if desired
                    {
                        //button just released, call other code
                        int OffRS;
                        bool test = Int32.TryParse(myform.comboBox11.Text, out OffRS);

                        //int OffA = Convert.ToInt32(myform.comboBox1.Text);
                        if (test)
                        {
                            UC.Callbutton(OffRS);// Z Jog stop codes
                        }
                    }

                }


            }

            previousRS = currentRS;
        }

        //  START Button
        public void CheckSTART(bool START)
        {
            currentSTART = START;

            if (currentSTART == true && previousSTART == false)
            {
                //button just pressed, call code
                {
                    int OnSTART;
                    bool test = Int32.TryParse(myform.comboBox16.Text, out OnSTART);

                    //int OnA = Convert.ToInt32(myform.comboBox2.Text);
                    if (test)
                    {
                        UC.Callbutton(OnSTART);  // Z+ Jog code
                    }
                }

            }
            if (currentSTART == false && previousSTART == true)  //additional functionality if desired
            {
                //button just released, call other code
                int OffSTART;
                bool test = Int32.TryParse(myform.comboBox15.Text, out OffSTART);

                //int OffA = Convert.ToInt32(myform.comboBox1.Text);
                if (test)
                {
                    UC.Callbutton(OffSTART);// Z Jog stop codes
                }
            }


            previousSTART = currentSTART;
        }

        //  BACK Button
        public void CheckBACK(bool BACK)
        {
            currentBACK = BACK;

            if (currentBACK == true && previousBACK == false)
            {
                //button just pressed, call code
                {
                    int OnBACK;
                    bool test = Int32.TryParse(myform.comboBox14.Text, out OnBACK);

                    //int OnA = Convert.ToInt32(myform.comboBox2.Text);
                    if (test)
                    {
                        UC.Callbutton(OnBACK);  // Z+ Jog code
                    }
                }

            }
            if (currentBACK == false && previousBACK == true)  //additional functionality if desired
            {
                //button just released, call other code
                int OffBACK;
                bool test = Int32.TryParse(myform.comboBox13.Text, out OffBACK);

                //int OffA = Convert.ToInt32(myform.comboBox1.Text);
                if (test)
                {
                    UC.Callbutton(OffBACK);// Z Jog stop codes
                }
            }


            previousBACK = currentBACK;
        }


        //  UP Button
        public void CheckUP(bool UP)
        {
            currentUP = UP;


            if (!myform.checkBox2.Checked)
            {
                if (!myform.RevYStep.Checked)
                {

                    if (currentUP == true && previousUP == false)
                    {
                        //button just pressed, call code
                        stepmode = UC.GetLED(146);  //True if step mode, false if cont. mode


                        UC.Callbutton(162); // set mode to step jog

                        UC.Callbutton(149); //Jog y+

                    }

                    if (currentUP == false && previousUP == true)  //additional functionality if desired
                    {
                        //button just released, call other code

                        UC.Callbutton(231); // axis stop

                        // Reset back to step or continuous
                        if (stepmode)
                        {
                            UC.Callbutton(162); // set mode to step jog
                        }
                        else
                        {
                            UC.Callbutton(161); // set mode to continuous jog
                        }


                        //int OffUP = Convert.ToInt32(myform.numericUpDown2.Value);
                        //UC.Callbutton(OffUP);  // Z Jog stop codes
                    }
                }
                else
                {
                    if (currentUP == true && previousUP == false)
                    {
                        //button just pressed, call code
                        stepmode = UC.GetLED(146);  //True if step mode, false if cont. mode


                        UC.Callbutton(162); // set mode to step jog

                        UC.Callbutton(150); //Jog y-
                    }
                    if (currentUP == false && previousUP == true)  //additional functionality if desired
                    {
                        //button just released, call other code

                        UC.Callbutton(232); // axis stop

                        // Reset back to step or continuous
                        if (stepmode)
                        {
                            UC.Callbutton(162); // set mode to step jog
                        }
                        else
                        {
                            UC.Callbutton(161); // set mode to continuous jog
                        }
                    }
                }
            }
            else
            {
                {

                    if (currentUP == true && previousUP == false)
                    {
                        //button just pressed, call code
                        {
                            int OnUP;
                            bool test = Int32.TryParse(myform.comboBox18.Text, out OnUP);

                            //int OnA = Convert.ToInt32(myform.comboBox2.Text);
                            if (test)
                            {
                                UC.Callbutton(OnUP);  // Z+ Jog code
                            }
                        }

                    }
                    if (currentUP == false && previousUP == true)  //additional functionality if desired
                    {
                        //button just released, call other code
                        int OffUP;
                        bool test = Int32.TryParse(myform.comboBox17.Text, out OffUP);

                        //int OffA = Convert.ToInt32(myform.comboBox1.Text);
                        if (test)
                        {
                            UC.Callbutton(OffUP);// Z Jog stop codes
                        }
                    }

                }

            }


            previousUP = currentUP;
        }


        //  DOWN Button
        public void CheckDOWN(bool DOWN)
        {
            currentDOWN = DOWN;


            if (!myform.checkBox2.Checked)
            {
                if (!myform.RevYStep.Checked)
                {

                    if (currentDOWN == true && previousDOWN == false)
                    {
                        //button just pressed, call code
                        stepmode = UC.GetLED(146);  //True if step mode, false if cont. mode


                        UC.Callbutton(162); // set mode to step jog

                        UC.Callbutton(150); //Jog y-
                    }
                    if (currentDOWN == false && previousDOWN == true)  //additional functionality if desired
                    {
                        //button just released, call other code

                        UC.Callbutton(232); // axis stop

                        // Reset back to step or continuous
                        if (stepmode)
                        {
                            UC.Callbutton(162); // set mode to step jog
                        }
                        else
                        {
                            UC.Callbutton(161); // set mode to continuous jog
                        }

                    }
                }
                else
                {
                    if (currentDOWN == true && previousDOWN == false)
                    {
                        //button just pressed, call code
                        stepmode = UC.GetLED(146);  //True if step mode, false if cont. mode


                        UC.Callbutton(162); // set mode to step jog

                        UC.Callbutton(149); //Jog y+
                    }
                    if (currentDOWN == false && previousDOWN == true)  //additional functionality if desired
                    {
                        //button just released, call other code

                        UC.Callbutton(231); // axis stop

                        // Reset back to step or continuous
                        if (stepmode)
                        {
                            UC.Callbutton(162); // set mode to step jog
                        }
                        else
                        {
                            UC.Callbutton(161); // set mode to continuous jog
                        }

                    }
                }
            }
            else
            {
                {

                    if (currentDOWN == true && previousDOWN == false)
                    {
                        //button just pressed, call code
                        {
                            int OnDOWN;
                            bool test = Int32.TryParse(myform.comboBox20.Text, out OnDOWN);

                            //int OnA = Convert.ToInt32(myform.comboBox2.Text);
                            if (test)
                            {
                                UC.Callbutton(OnDOWN);  // Z+ Jog code
                            }
                        }

                    }
                    if (currentDOWN == false && previousDOWN == true)  //additional functionality if desired
                    {
                        //button just released, call other code
                        int OffDOWN;
                        bool test = Int32.TryParse(myform.comboBox19.Text, out OffDOWN);

                        //int OffA = Convert.ToInt32(myform.comboBox1.Text);
                        if (test)
                        {
                            UC.Callbutton(OffDOWN);// Z Jog stop codes
                        }
                    }

                }

            }


            previousDOWN = currentDOWN;
        }


        //  LEFT Button
        public void CheckLEFT(bool LEFT)
        {
            currentLEFT = LEFT;


            if (!myform.checkBox2.Checked)
            {
                if (!myform.RevXStep.Checked)
                {
                    if (currentLEFT == true && previousLEFT == false)
                    {
                        //button just pressed, call code
                        stepmode = UC.GetLED(146);  //True if step mode, false if cont. mode


                        UC.Callbutton(162); // set mode to step jog

                        UC.Callbutton(148); //Jog x-
                    }
                    if (currentLEFT == false && previousLEFT == true)  //additional functionality if desired
                    {
                        //button just released, call other code


                        UC.Callbutton(230); // axis stop

                        // Reset back to step or continuous
                        if (stepmode)
                        {
                            UC.Callbutton(162); // set mode to step jog
                        }
                        else
                        {
                            UC.Callbutton(161); // set mode to continuous jog
                        }

                    }
                }
                else
                {
                    if (currentLEFT == true && previousLEFT == false)
                    {
                        //button just pressed, call code
                        stepmode = UC.GetLED(146);  //True if step mode, false if cont. mode


                        UC.Callbutton(162); // set mode to step jog

                        UC.Callbutton(147); //Jog x-
                    }
                    if (currentLEFT == false && previousLEFT == true)  //additional functionality if desired
                    {
                        //button just released, call other code

                        UC.Callbutton(229); // axis stop

                        // Reset back to step or continuous
                        if (stepmode)
                        {
                            UC.Callbutton(162); // set mode to step jog
                        }
                        else
                        {
                            UC.Callbutton(161); // set mode to continuous jog
                        }
                    }
                }
            }
            else
            {

                if (currentLEFT == true && previousLEFT == false)
                {
                    //button just pressed, call code
                    {
                        int OnLEFT;
                        bool test = Int32.TryParse(myform.comboBox22.Text, out OnLEFT);

                        //int OnA = Convert.ToInt32(myform.comboBox2.Text);
                        if (test)
                        {
                            UC.Callbutton(OnLEFT);  // Z+ Jog code
                        }
                    }

                }
                if (currentLEFT == false && previousLEFT == true)  //additional functionality if desired
                {
                    //button just released, call other code
                    int OffLEFT;
                    bool test = Int32.TryParse(myform.comboBox21.Text, out OffLEFT);

                    //int OffA = Convert.ToInt32(myform.comboBox1.Text);
                    if (test)
                    {
                        UC.Callbutton(OffLEFT);// Z Jog stop codes
                    }
                }

            }


            previousLEFT = currentLEFT;
        }


        //  RIGHT Button
        public void CheckRIGHT(bool RIGHT)
        {
            currentRIGHT = RIGHT;


            if (!myform.checkBox2.Checked)
            {
                if (!myform.RevXStep.Checked)
                {
                    if (currentRIGHT == true && previousRIGHT == false)
                    {
                        //button just pressed, call code
                        stepmode = UC.GetLED(146);  //True if step mode, false if cont. mode


                        UC.Callbutton(162); // set mode to step jog

                        UC.Callbutton(147); //Jog x-
                    }
                    if (currentRIGHT == false && previousRIGHT == true)  //additional functionality if desired
                    {
                        //button just released, call other code

                        UC.Callbutton(229); // axis stop

                        // Reset back to step or continuous
                        if (stepmode)
                        {
                            UC.Callbutton(162); // set mode to step jog
                        }
                        else
                        {
                            UC.Callbutton(161); // set mode to continuous jog
                        }
                    }
                }
                else
                {
                    if (currentRIGHT == true && previousRIGHT == false)
                    {
                        //button just pressed, call code
                        stepmode = UC.GetLED(146);  //True if step mode, false if cont. mode


                        UC.Callbutton(162); // set mode to step jog

                        UC.Callbutton(148); //Jog x-
                    }
                    if (currentRIGHT == false && previousRIGHT == true)  //additional functionality if desired
                    {
                        //button just released, call other code


                        UC.Callbutton(230); // axis stop

                        // Reset back to step or continuous
                        if (stepmode)
                        {
                            UC.Callbutton(162); // set mode to step jog
                        }
                        else
                        {
                            UC.Callbutton(161); // set mode to continuous jog
                        }
                    }

                }
            }
            else
            {
                if (currentRIGHT == true && previousRIGHT == false)
                {
                    //button just pressed, call code
                    {
                        int OnRIGHT;
                        bool test = Int32.TryParse(myform.comboBox24.Text, out OnRIGHT);

                        //int OnA = Convert.ToInt32(myform.comboBox2.Text);
                        if (test)
                        {
                            UC.Callbutton(OnRIGHT);  // Z+ Jog code
                        }
                    }

                }
                if (currentRIGHT == false && previousRIGHT == true)  //additional functionality if desired
                {
                    //button just released, call other code
                    int OffRIGHT;
                    bool test = Int32.TryParse(myform.comboBox23.Text, out OffRIGHT);

                    //int OffA = Convert.ToInt32(myform.comboBox1.Text);
                    if (test)
                    {
                        UC.Callbutton(OffRIGHT);// Z Jog stop codes
                    }
                }

            }


            previousRIGHT = currentRIGHT;
        }

        # endregion buttons


        #region ShakeEvent


        public void Shake(int numShake)
        {
            Thread t = new Thread(Shakethd);
            t.Start(numShake);
        
        }


        public void Shakethd(object numShake)
        {
            int maxShake = Convert.ToInt16(numShake);
            //int countmax  = numShake;
            //Timer timer = new Timer();
            //timer.Interval = Convert.ToInt32(timeOn);

            for (int i = 0; i < maxShake; i++)
            {
                //timer.Start();
                controls.Vibrate(100, 100);
                Thread.Sleep(150);
                controls.Vibrate(0, 0);
                Thread.Sleep(150);

            }

        }



        
        #endregion  

    }


}
