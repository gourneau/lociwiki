
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace loci
{
	public partial class FrmGpsSettings : Form
	{
		public FrmGpsSettings()
		{
			InitializeComponent();
			cmbPorts.DataSource = System.IO.Ports.SerialPort.GetPortNames();
		}
		public string SerialPort
		{
			get { return cmbPorts.SelectedValue.ToString(); }
		}
		public int BaudRate
		{
			get { return int.Parse(tbBaudRate.Text); }
			set { tbBaudRate.Text = value.ToString(); }
		}
	}
}