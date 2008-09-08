namespace loci
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.NMEAtabs = new System.Windows.Forms.TabControl();
            this.tabGPGGA = new System.Windows.Forms.TabPage();
            this.lbGGAlon = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbGGADGPSID = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lbGGADGPSupdate = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lbGGAGeoidHeight = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lbGGAHDOP = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbGGAAltitude = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbGGANoOfSats = new System.Windows.Forms.Label();
            this.lbGGAFixQuality = new System.Windows.Forms.Label();
            this.lbGGATimeOfFix = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lbGGAlat = new System.Windows.Forms.Label();
            this.tabWeb = new System.Windows.Forms.TabPage();
            this.web = new System.Windows.Forms.WebBrowser();
            this.tabRaw = new System.Windows.Forms.TabPage();
            this.tbRawLog = new System.Windows.Forms.TextBox();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.mainMenu = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem_File_Exit = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItemGPS_Start = new System.Windows.Forms.MenuItem();
            this.menuItemGPS_Settings = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.notification1 = new Microsoft.WindowsCE.Forms.Notification();
            this.NMEAtabs.SuspendLayout();
            this.tabGPGGA.SuspendLayout();
            this.tabWeb.SuspendLayout();
            this.tabRaw.SuspendLayout();
            this.SuspendLayout();
            // 
            // NMEAtabs
            // 
            this.NMEAtabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.NMEAtabs.Controls.Add(this.tabGPGGA);
            this.NMEAtabs.Controls.Add(this.tabWeb);
            this.NMEAtabs.Controls.Add(this.tabRaw);
            this.NMEAtabs.Dock = System.Windows.Forms.DockStyle.None;
            this.NMEAtabs.Location = new System.Drawing.Point(0, 0);
            this.NMEAtabs.Name = "NMEAtabs";
            this.NMEAtabs.SelectedIndex = 0;
            this.NMEAtabs.Size = new System.Drawing.Size(240, 247);
            this.NMEAtabs.TabIndex = 1;
            // 
            // tabGPGGA
            // 
            this.tabGPGGA.AutoScroll = true;
            this.tabGPGGA.Controls.Add(this.lbGGAlon);
            this.tabGPGGA.Controls.Add(this.label12);
            this.tabGPGGA.Controls.Add(this.lbGGADGPSID);
            this.tabGPGGA.Controls.Add(this.label24);
            this.tabGPGGA.Controls.Add(this.lbGGADGPSupdate);
            this.tabGPGGA.Controls.Add(this.label22);
            this.tabGPGGA.Controls.Add(this.lbGGAGeoidHeight);
            this.tabGPGGA.Controls.Add(this.label20);
            this.tabGPGGA.Controls.Add(this.lbGGAHDOP);
            this.tabGPGGA.Controls.Add(this.label7);
            this.tabGPGGA.Controls.Add(this.lbGGAAltitude);
            this.tabGPGGA.Controls.Add(this.label10);
            this.tabGPGGA.Controls.Add(this.lbGGANoOfSats);
            this.tabGPGGA.Controls.Add(this.lbGGAFixQuality);
            this.tabGPGGA.Controls.Add(this.lbGGATimeOfFix);
            this.tabGPGGA.Controls.Add(this.label14);
            this.tabGPGGA.Controls.Add(this.label15);
            this.tabGPGGA.Controls.Add(this.label16);
            this.tabGPGGA.Controls.Add(this.label17);
            this.tabGPGGA.Controls.Add(this.lbGGAlat);
            this.tabGPGGA.Location = new System.Drawing.Point(0, 0);
            this.tabGPGGA.Name = "tabGPGGA";
            this.tabGPGGA.Size = new System.Drawing.Size(240, 224);
            this.tabGPGGA.Text = "GPGGA";
            // 
            // lbGGAlon
            // 
            this.lbGGAlon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbGGAlon.Location = new System.Drawing.Point(73, 44);
            this.lbGGAlon.Name = "lbGGAlon";
            this.lbGGAlon.Size = new System.Drawing.Size(160, 20);
            this.lbGGAlon.Text = "lon";
            this.lbGGAlon.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(7, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(225, 20);
            this.label12.Text = "Global Positioning System Fix Data";
            // 
            // lbGGADGPSID
            // 
            this.lbGGADGPSID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbGGADGPSID.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lbGGADGPSID.Location = new System.Drawing.Point(113, 204);
            this.lbGGADGPSID.Name = "lbGGADGPSID";
            this.lbGGADGPSID.Size = new System.Drawing.Size(119, 20);
            this.lbGGADGPSID.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label24
            // 
            this.label24.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label24.Location = new System.Drawing.Point(7, 204);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(99, 20);
            this.label24.Text = "DGPS Station ID";
            // 
            // lbGGADGPSupdate
            // 
            this.lbGGADGPSupdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbGGADGPSupdate.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lbGGADGPSupdate.Location = new System.Drawing.Point(113, 184);
            this.lbGGADGPSupdate.Name = "lbGGADGPSupdate";
            this.lbGGADGPSupdate.Size = new System.Drawing.Size(119, 20);
            this.lbGGADGPSupdate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label22.Location = new System.Drawing.Point(7, 184);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(99, 20);
            this.label22.Text = "DGPS update";
            // 
            // lbGGAGeoidHeight
            // 
            this.lbGGAGeoidHeight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbGGAGeoidHeight.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lbGGAGeoidHeight.Location = new System.Drawing.Point(113, 164);
            this.lbGGAGeoidHeight.Name = "lbGGAGeoidHeight";
            this.lbGGAGeoidHeight.Size = new System.Drawing.Size(119, 20);
            this.lbGGAGeoidHeight.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label20.Location = new System.Drawing.Point(7, 164);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(99, 20);
            this.label20.Text = "Height of Geoide";
            // 
            // lbGGAHDOP
            // 
            this.lbGGAHDOP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbGGAHDOP.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lbGGAHDOP.Location = new System.Drawing.Point(125, 144);
            this.lbGGAHDOP.Name = "lbGGAHDOP";
            this.lbGGAHDOP.Size = new System.Drawing.Size(107, 20);
            this.lbGGAHDOP.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label7.Location = new System.Drawing.Point(7, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 20);
            this.label7.Text = "HDOP";
            // 
            // lbGGAAltitude
            // 
            this.lbGGAAltitude.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbGGAAltitude.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lbGGAAltitude.Location = new System.Drawing.Point(125, 124);
            this.lbGGAAltitude.Name = "lbGGAAltitude";
            this.lbGGAAltitude.Size = new System.Drawing.Size(107, 20);
            this.lbGGAAltitude.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label10.Location = new System.Drawing.Point(7, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 20);
            this.label10.Text = "Altitude";
            // 
            // lbGGANoOfSats
            // 
            this.lbGGANoOfSats.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbGGANoOfSats.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lbGGANoOfSats.Location = new System.Drawing.Point(125, 104);
            this.lbGGANoOfSats.Name = "lbGGANoOfSats";
            this.lbGGANoOfSats.Size = new System.Drawing.Size(107, 20);
            this.lbGGANoOfSats.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbGGAFixQuality
            // 
            this.lbGGAFixQuality.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbGGAFixQuality.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lbGGAFixQuality.Location = new System.Drawing.Point(102, 84);
            this.lbGGAFixQuality.Name = "lbGGAFixQuality";
            this.lbGGAFixQuality.Size = new System.Drawing.Size(130, 20);
            this.lbGGAFixQuality.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbGGATimeOfFix
            // 
            this.lbGGATimeOfFix.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbGGATimeOfFix.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.lbGGATimeOfFix.Location = new System.Drawing.Point(102, 64);
            this.lbGGATimeOfFix.Name = "lbGGATimeOfFix";
            this.lbGGATimeOfFix.Size = new System.Drawing.Size(130, 20);
            this.lbGGATimeOfFix.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label14.Location = new System.Drawing.Point(7, 104);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 20);
            this.label14.Text = "Tracked satellites";
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label15.Location = new System.Drawing.Point(7, 84);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 20);
            this.label15.Text = "Fix quality";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label16.Location = new System.Drawing.Point(7, 64);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(89, 20);
            this.label16.Text = "Time of Fix";
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(7, 24);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 20);
            this.label17.Text = "Position";
            // 
            // lbGGAlat
            // 
            this.lbGGAlat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbGGAlat.Location = new System.Drawing.Point(73, 24);
            this.lbGGAlat.Name = "lbGGAlat";
            this.lbGGAlat.Size = new System.Drawing.Size(160, 20);
            this.lbGGAlat.Text = "lat";
            this.lbGGAlat.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tabWeb
            // 
            this.tabWeb.Controls.Add(this.web);
            this.tabWeb.Location = new System.Drawing.Point(0, 0);
            this.tabWeb.Name = "tabWeb";
            this.tabWeb.Size = new System.Drawing.Size(240, 224);
            this.tabWeb.Text = "web";
            // 
            // web
            // 
            this.web.Dock = System.Windows.Forms.DockStyle.Fill;
            this.web.Location = new System.Drawing.Point(0, 0);
            this.web.Name = "web";
            this.web.Size = new System.Drawing.Size(240, 224);
            this.web.Url = new System.Uri("http://loci.engr.utk.edu/search.php");
            // 
            // tabRaw
            // 
            this.tabRaw.Controls.Add(this.tbRawLog);
            this.tabRaw.Location = new System.Drawing.Point(0, 0);
            this.tabRaw.Name = "tabRaw";
            this.tabRaw.Size = new System.Drawing.Size(240, 224);
            this.tabRaw.Text = "Raw";
            // 
            // tbRawLog
            // 
            this.tbRawLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbRawLog.Location = new System.Drawing.Point(0, 0);
            this.tbRawLog.Multiline = true;
            this.tbRawLog.Name = "tbRawLog";
            this.tbRawLog.ReadOnly = true;
            this.tbRawLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbRawLog.Size = new System.Drawing.Size(240, 224);
            this.tbRawLog.TabIndex = 0;
            this.tbRawLog.WordWrap = false;
            // 
            // statusBar1
            // 
            this.statusBar1.Location = new System.Drawing.Point(0, 246);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(240, 22);
            this.statusBar1.Text = "GPS Offline";
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.Add(this.menuItem1);
            this.mainMenu.MenuItems.Add(this.menuItem3);
            this.mainMenu.MenuItems.Add(this.menuItem2);
            // 
            // menuItem1
            // 
            this.menuItem1.MenuItems.Add(this.menuItem_File_Exit);
            this.menuItem1.Text = "&File";
            // 
            // menuItem_File_Exit
            // 
            this.menuItem_File_Exit.Text = "E&xit";
            this.menuItem_File_Exit.Click += new System.EventHandler(this.menuItem_File_Exit_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.MenuItems.Add(this.menuItemGPS_Start);
            this.menuItem3.MenuItems.Add(this.menuItemGPS_Settings);
            this.menuItem3.Text = "&GPS";
            // 
            // menuItemGPS_Start
            // 
            this.menuItemGPS_Start.Text = "&Start";
            this.menuItemGPS_Start.Click += new System.EventHandler(this.menuItemGPS_Start_Click);
            // 
            // menuItemGPS_Settings
            // 
            this.menuItemGPS_Settings.Text = "Settings...";
            this.menuItemGPS_Settings.Click += new System.EventHandler(this.menuItemGPS_Settings_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Text = "refresh web";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // notification1
            // 
            this.notification1.Text = "notification1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.NMEAtabs);
            this.Menu = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "loci";
            this.NMEAtabs.ResumeLayout(false);
            this.tabGPGGA.ResumeLayout(false);
            this.tabWeb.ResumeLayout(false);
            this.tabRaw.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

        private System.Windows.Forms.TabControl NMEAtabs;
        private System.Windows.Forms.TabPage tabGPGGA;
		private System.Windows.Forms.StatusBar statusBar1;
		private System.Windows.Forms.MainMenu mainMenu;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem_File_Exit;
		private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.MenuItem menuItemGPS_Start;
		private System.Windows.Forms.TabPage tabRaw;
        private System.Windows.Forms.TextBox tbRawLog;
        private Microsoft.WindowsCE.Forms.Notification notification1;
		private System.Windows.Forms.Label lbGGAGeoidHeight;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label lbGGAHDOP;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lbGGAAltitude;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label lbGGANoOfSats;
		private System.Windows.Forms.Label lbGGAFixQuality;
		private System.Windows.Forms.Label lbGGATimeOfFix;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label lbGGADGPSID;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label lbGGADGPSupdate;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MenuItem menuItemGPS_Settings;
        private System.Windows.Forms.Label lbGGAlon;
        private System.Windows.Forms.Label lbGGAlat;
        private System.Windows.Forms.TabPage tabWeb;
        private System.Windows.Forms.WebBrowser web;
        private System.Windows.Forms.MenuItem menuItem2;
		//private System.Windows.Forms.MainMenu mainMenu1;
		//private System.Windows.Forms.MenuItem menuItem4;
		//private System.Windows.Forms.MenuItem menuItem_File_Exit;

	}
}

