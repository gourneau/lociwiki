
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace loci
{
	public partial class MainForm : Form
	{
		public static FrmGpsSettings frmGpsSettings;

		public MainForm()
		{
			InitializeComponent();

			GPS = new PocketGpsLib.GPSHandler(this); //Initialize GPS handler
			GPS.TimeOut = 5; //Set timeout to 5 seconds
			GPS.NewGPSFix += new PocketGpsLib.GPSHandler.NewGPSFixHandler(this.GPSEventHandler); //Hook up GPS data events to a handler
			frmGpsSettings = new FrmGpsSettings();
		}
		public static PocketGpsLib.GPSHandler GPS;

		private void menuItemGPS_Start_Click(object sender, EventArgs e)
		{
			
			
			if (!GPS.IsPortOpen)
			{
				try
				{
					GPS.Start("COM1", 4800); //Open serial port 1 at 4800baud
					menuItemGPS_Start.Text = "Stop";
				}
				catch (System.Exception ex)
				{
					MessageBox.Show("An error occured when trying to open port: " + ex.Message);
				}
			}
			else
			{
				GPS.Stop(); //Close serial port
				menuItemGPS_Start.Text = "Start";
			}	
		}

		/// <summary>
		/// Responds to sentence events from GPS receiver
		/// </summary>
		private void GPSEventHandler(object sender, PocketGpsLib.GPSHandler.GPSEventArgs e)
		{
			tbRawLog.Text += e.Sentence + "\r\n";
			tbRawLog.Text.Substring(tbRawLog.Text.Length - 2000); //only show last 2000 characters
			tbRawLog.ScrollToCaret(); //Scroll to bottom
			
			switch (e.TypeOfEvent)
			{
				case PocketGpsLib.GPSEventType.GPRMC:  //Recommended minimum specific GPS/Transit data
					if (GPS.HasGPSFix) //Is a GPS fix available?
					{
                        statusBar1.Text = "Fix";
					}
					else
					{
						statusBar1.Text = "No fix";
					}
					break;
				case PocketGpsLib.GPSEventType.GPGGA: //Global Positioning System Fix Data
                    lbGGAlon.Text = GPS.GPGGA.Position.Longitude.ToString();
                    lbGGAlat.Text = GPS.GPGGA.Position.Latitude.ToString();
                    lbGGATimeOfFix.Text = GPS.GPGGA.TimeOfFix.Hours.ToString() + ":" + GPS.GPGGA.TimeOfFix.Minutes.ToString() + ":" + GPS.GPGGA.TimeOfFix.Seconds.ToString();
					lbGGAFixQuality.Text = GPS.GPGGA.FixQuality.ToString();
					lbGGANoOfSats.Text = GPS.GPGGA.NoOfSats.ToString();
					lbGGAAltitude.Text = GPS.GPGGA.Altitude.ToString() + " " + GPS.GPGGA.AltitudeUnits;
					lbGGAHDOP.Text = GPS.GPGGA.Dilution.ToString();
					lbGGAGeoidHeight.Text = GPS.GPGGA.HeightOfGeoid.ToString();
					lbGGADGPSupdate.Text = GPS.GPGGA.DGPSUpdate.ToString();
					lbGGADGPSID.Text = GPS.GPGGA.DGPSStationID;
					break;
				case PocketGpsLib.GPSEventType.TimeOut: //Serialport timeout.
					statusBar1.Text = "Serialport timeout";
					notification1.Caption = "GPS Serialport timeout";
					notification1.InitialDuration = 5;
					notification1.Text = "Check your settings and connection";
					notification1.Critical = false;
					notification1.Visible = true;
					break;
			}
		}

		private void menuItem_File_Exit_Click(object sender, EventArgs e)
		{
			GPS.Dispose();  //Closes serial port and cleans up. This is important !
			Application.Exit();
		}

		private void menuItemGPS_Settings_Click(object sender, EventArgs e)
		{
			frmGpsSettings.Show();
		}

        private void menuItem2_Click(object sender, EventArgs e)
        {

            string url = "http://loci.engr.utk.edu/search.php?lat=";
            string urllat = GPS.GPGGA.Position.Latitude.ToString();
            if (urllat.StartsWith("-"))
            {
                urllat = urllat.Substring(0, 9);
            }
            else
            {
                urllat = urllat.Substring(0, 8);
            }
            string urllng = GPS.GPGGA.Position.Longitude.ToString();
            int gto = 0;
            if (GPS.GPGGA.Position.Longitude >= 100)
            {
                gto=1;
            }

            if (urllng.StartsWith("-"))
            {
                urllng = urllng.Substring(0, 9 + gto);
            }
            else
            {
                urllng = urllng.Substring(0, 8 + gto);
            }
            url = url + urllat;
            url = url + "&lng=";
            url = url + urllng;
            web.Navigate(new Uri(url));
           

        }

	}
}