

namespace loci
{
	partial class FrmGpsSettings
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
			this.cmbPorts = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tbBaudRate = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// cmbPorts
			// 
			this.cmbPorts.Location = new System.Drawing.Point(115, 24);
			this.cmbPorts.Name = "cmbPorts";
			this.cmbPorts.Size = new System.Drawing.Size(100, 22);
			this.cmbPorts.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(4, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 20);
			this.label1.Text = "Serial port";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(4, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 20);
			this.label2.Text = "Baudrate";
			// 
			// tbBaudRate
			// 
			this.tbBaudRate.Location = new System.Drawing.Point(115, 53);
			this.tbBaudRate.Name = "tbBaudRate";
			this.tbBaudRate.Size = new System.Drawing.Size(100, 21);
			this.tbBaudRate.TabIndex = 3;
			this.tbBaudRate.Text = "4800";
			// 
			// frmGpsSettings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(240, 294);
			this.Controls.Add(this.tbBaudRate);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmbPorts);
			this.MinimizeBox = false;
			this.Name = "frmGpsSettings";
			this.Text = "GPS Settings";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox cmbPorts;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbBaudRate;
	}
}