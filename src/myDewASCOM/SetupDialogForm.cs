using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using ASCOM.Utilities;
using ASCOM.myDewController;

namespace ASCOM.myDewController
{
    [ComVisible(false)]					    // Form not registered for COM!
    public partial class SetupDialogForm : Form
    {
        public string ComPortName;          // hold comport name of last used comport
        public int ComPortBaudRate;

        public SetupDialogForm()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            // this.MinimizeBox = false;  // do not as user cannot minimize form!!!
        }

        private void cmdOK_Click(object sender, EventArgs e) // OK button event handler
        {
            // validate comport
            if (this.comboBox1.SelectedItem != null)
                Properties.Settings.Default.MyComPort = comboBox1.GetItemText(comboBox1.SelectedItem);
            else
                Properties.Settings.Default.MyComPort = "(None)";

            comportspeed.Enabled = false;
            // get the comportspeed from the listbox
            switch (comportspeed.SelectedIndex)
            {
                case 0: ComPortBaudRate = 9600;
                    break;
                case 1: ComPortBaudRate = 14400;
                    break;
                case 2: ComPortBaudRate = 19200;
                    break;
                case 3: ComPortBaudRate = 28800;
                    break;
                case 4: ComPortBaudRate = 38400;
                    break;
                case 5: ComPortBaudRate = 57600;
                    break;
                case 6: ComPortBaudRate = 115200;
                    break;
                default: ComPortBaudRate = 9600;
                    break;
            }
            // save comportspeed
            Properties.Settings.Default.ComPortSpeed = ComPortBaudRate;
            Properties.Settings.Default.Save();
            comportspeed.Enabled = true;
        }

        private void cmdCancel_Click(object sender, EventArgs e) // Cancel button event handler
        {
            // validate comport
            if (this.comboBox1.SelectedItem != null)
                Properties.Settings.Default.MyComPort = comboBox1.GetItemText(comboBox1.SelectedItem);
            else
                Properties.Settings.Default.MyComPort = "(None)";

            comportspeed.Enabled = false;
            // get the comportspeed from the listbox
            switch (comportspeed.SelectedIndex)
            {
                case 0: ComPortBaudRate = 9600;
                    break;
                case 1: ComPortBaudRate = 14400;
                    break;
                case 2: ComPortBaudRate = 19200;
                    break;
                case 3: ComPortBaudRate = 28800;
                    break;
                case 4: ComPortBaudRate = 38400;
                    break;
                case 5: ComPortBaudRate = 57600;
                    break;
                case 6: ComPortBaudRate = 115200;
                    break;
                default: ComPortBaudRate = 9600;
                    break;
            }
            // save comportspeed
            Properties.Settings.Default.ComPortSpeed = ComPortBaudRate;
            comportspeed.Enabled = true;
            Close();
        }

        private void BrowseToAscom(object sender, EventArgs e) // Click on ASCOM logo event handler
        {
            try
            {
                System.Diagnostics.Process.Start("http://ascom-standards.org/");
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }

        private void SetupDialogForm_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reload();
            this.Location = Properties.Settings.Default.FormLocation;
            // add serial com ports found to list
            this.comboBox1.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());

            ComPortName = Properties.Settings.Default.MyComPort;
            int index = this.comboBox1.FindString(ComPortName);
            if (index < 0)	// < 0 or -1 if not found
            {
                // do nothing
            }
            else
            {
                this.comboBox1.SelectedIndex = index; // set the list to the found comport
            }

            // set up comport speed listbox
            comportspeed.Enabled = false;    // prevent change event from happening
            ComPortBaudRate = Properties.Settings.Default.ComPortSpeed;
            switch (ComPortBaudRate)
            {
                case 9600: comportspeed.SetSelected(0, true); break;
                case 14400: comportspeed.SetSelected(1, true); break;
                case 19200: comportspeed.SetSelected(2, true); break;
                case 28800: comportspeed.SetSelected(3, true); break;
                case 38400: comportspeed.SetSelected(4, true); break;
                case 57600: comportspeed.SetSelected(5, true); break;
                case 115200: comportspeed.SetSelected(6, true); break;
                default: comportspeed.SetSelected(0, true); break;
            }
            comportspeed.Enabled = true;
        }

        private void RefreshComPortBtn_Click(object sender, EventArgs e)
        {
            // erase list box items of comports
            comboBox1.Items.Clear();
            // reload from the system
            comboBox1.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            ComPortName = Properties.Settings.Default.MyComPort;
            int index = comboBox1.FindString(ComPortName);
            if (index < 0)	// < 0 or -1 if not found
            {
                // do nothing
            }
            else
            {
                comboBox1.SelectedIndex = index; // set the list to the found comport
            }
        }

        private void SetupDialogForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.FormLocation = this.Location;
            Properties.Settings.Default.Save();
        }

        private void chkTrace_CheckedChanged(object sender, EventArgs e)
        {
            // chkTrace.Checked = false;
        }
    }
}