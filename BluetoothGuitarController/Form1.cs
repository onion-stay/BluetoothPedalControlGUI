using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using System.IO.Ports;


namespace BluetoothGuitarController
{
    public partial class Form1 : Form
    {
        DirectoryInfo pwd = new DirectoryInfo(@"C:\Users\Eric\Documents\BluetoothGuitarProfiles");
        int maximumPosition = 0;
        int defaultPosition = 0;
        List<Effect> effectList = new List<Effect>();
        string[] effectNames = { "Chorus", "Delay", "Distortion", "Reverb", "Volume"};
        bool profileActive = false;
        
        /*******************************************
         *  Form Event Handlers
         ********************************************/
        public Form1()
        {
            InitializeComponent();
            InitializeEffectObjects();
            InitializeTrackBars();
            UpdateProfileList(); // use default folder
            getAvailablePorts();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        /*******************************************
         *  Button Event Handlers
         ********************************************/
        // Effect Profile Events
        private void btnSaveProfile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            
            saveFileDialog1.RestoreDirectory = false;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string profileStr = "";
                for(int i=0;i<effectList.Count;i++)
                {
                    profileStr += i.ToString() + ":";
                    profileStr += effectList.ElementAt(i).volume[1];
                    for (int j = 0; j < effectList.ElementAt(i).controls.Count;j++)
                    {
                        profileStr += "," + j.ToString();
                        profileStr += "-" + effectList.ElementAt(i).controls.ElementAt(j).buffer[1];
                    }
                    profileStr += "|";
                }

                System.IO.File.WriteAllText(saveFileDialog1.FileName, profileStr);
            }
            UpdateProfileList();
        }

        private void btnOpenProfile_Click(object sender, EventArgs e)
        {
            OpenProfile(lbProfiles.SelectedItem.ToString());
        }

        // Bluetooth Serial Port Events
        private void btnOpenPort_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbPort.Text == "" || cmbBaudRate.Text == "")
                {
                    MessageBox.Show("Please select a valid port and baud rate.");
                }
                else
                {
                    serialPort1.PortName = cmbPort.Text;
                    serialPort1.BaudRate = Convert.ToInt32(cmbBaudRate.Text);
                    serialPort1.Open();
                    toolStripLabel.Text = "Connected!";
                    btnOpenPort.Enabled = false;
                    btnClosePort.Enabled = true;
                    btnSendFX.Enabled = true;
                    toolStripProgressBar.Value = 100;
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Unauthorized Access to selected port.");
            }
        }

        private void btnClosePort_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            toolStripLabel.Text = "Not Connected";
            btnOpenPort.Enabled = true;
            btnClosePort.Enabled = false;
            btnSendFX.Enabled = false;
            toolStripProgressBar.Value = 0;
        }

        private void btnSendFX_Click(object sender, EventArgs e)
        {
            sendFXData();
        }

        /*******************************************
         *  TrackBar Event Handlers
         ********************************************/
        // Effect parameter changes
        private void tbDistGain_ValueChanged(object sender, EventArgs e)
        {
            txtDistGain.Text = (100 * tbDistGain.Value / maximumPosition).ToString("X");
            if (txtDistGain.Text.Length < 2)
                txtDistGain.Text = "0" + txtDistGain.Text;
            UpdateEffectObjects("Form", "Distortion", "Gain");
            txtDistGain.Text = (100 * tbDistGain.Value / maximumPosition).ToString();
        }

        private void tbDistTone_ValueChanged(object sender, EventArgs e)
        {
            txtDistTone.Text = (100 * tbDistTone.Value / maximumPosition).ToString("X");
            if (txtDistTone.Text.Length < 2)
                txtDistTone.Text = "0" + txtDistTone.Text;
            UpdateEffectObjects("Form", "Distortion", "Tone");
            txtDistTone.Text = (100 * tbDistTone.Value / maximumPosition).ToString();
        }

        private void tbRevReverb_ValueChanged(object sender, EventArgs e)
        {
            txtRevReverb.Text = (100 * tbRevReverb.Value / maximumPosition).ToString("X");
            if (txtRevReverb.Text.Length < 2)
                txtRevReverb.Text = "0" + txtRevReverb.Text;
            UpdateEffectObjects("Form", "Reverb", "Reverb");
            txtRevReverb.Text = (100 * tbRevReverb.Value / maximumPosition).ToString();
        }

        private void tbDelDelay_ValueChanged(object sender, EventArgs e)
        {
            txtDelDelay.Text = (100 * tbDelDelay.Value / maximumPosition).ToString("X");
            if (txtDelDelay.Text.Length < 2)
                txtDelDelay.Text = "0" + txtDelDelay.Text;
            UpdateEffectObjects("Form", "Delay", "Delay");
            txtDelDelay.Text = (100 * tbDelDelay.Value / maximumPosition).ToString();
        }

        private void tbDelIntensity_ValueChanged(object sender, EventArgs e)
        {
            txtDelIntensity.Text = (100 * tbDelIntensity.Value / maximumPosition).ToString("X");
            if (txtDelIntensity.Text.Length < 2)
                txtDelIntensity.Text = "0" + txtDelIntensity.Text;
            UpdateEffectObjects("Form", "Delay", "Intensity");
            txtDelIntensity.Text = (100 * tbDelIntensity.Value / maximumPosition).ToString();
        }

        private void tbChorDepth_ValueChanged(object sender, EventArgs e)
        {
            txtChorDepth.Text = (100 * tbChorDepth.Value / maximumPosition).ToString("X");
            if (txtChorDepth.Text.Length < 2)
                txtChorDepth.Text = "0" + txtChorDepth.Text;
            UpdateEffectObjects("Form", "Chorus", "Depth");
            txtChorDepth.Text = (100 * tbChorDepth.Value / maximumPosition).ToString();
        }

        private void tbChorRate_ValueChanged(object sender, EventArgs e)
        {
            txtChorRate.Text = (100 * tbChorRate.Value / maximumPosition).ToString("X");
            if (txtChorRate.Text.Length < 2)
                txtChorRate.Text = "0" + txtChorRate.Text;
            UpdateEffectObjects("Form", "Chorus", "Rate");
            txtChorRate.Text = (100 * tbChorRate.Value / maximumPosition).ToString();
        }

        // Effect volume changes
        private void tbLvlMaster_ValueChanged(object sender, EventArgs e)
        {
            txtLvlMaster.Text = tbLvlMaster.Value.ToString("X");
            if (txtLvlMaster.Text.Length < 2)
                txtLvlMaster.Text = "0" + txtLvlMaster.Text;
            UpdateEffectObjects("Form", "Volume", "Master");
            txtLvlMaster.Text = tbLvlMaster.Value.ToString();
        }

        private void tbLvlDist_ValueChanged(object sender, EventArgs e)
        {
            txtLvlDist.Text = tbLvlDist.Value.ToString("X");
            if (txtLvlDist.Text.Length < 2)
                txtLvlDist.Text = "0" + txtLvlDist.Text;
            UpdateEffectObjects("Form", "Distortion", "Volume");
            txtLvlDist.Text = tbLvlDist.Value.ToString();
        }

        private void tbLvlDel_ValueChanged(object sender, EventArgs e)
        {
            txtLvlDel.Text = tbLvlDel.Value.ToString("X");
            if (txtLvlDel.Text.Length < 2)
                txtLvlDel.Text = "0" + txtLvlDel.Text;
            UpdateEffectObjects("Form", "Delay", "Volume");
            txtLvlDel.Text = tbLvlDel.Value.ToString();
        }

        private void tbLvlRev_ValueChanged(object sender, EventArgs e)
        {
            txtLvlRev.Text = tbLvlRev.Value.ToString("X");
            if (txtLvlRev.Text.Length < 2)
                txtLvlRev.Text = "0" + txtLvlRev.Text;
            UpdateEffectObjects("Form", "Reverb", "Volume");
            txtLvlRev.Text = tbLvlRev.Value.ToString();
        }

        private void tbLvlChor_ValueChanged(object sender, EventArgs e)
        {
            txtLvlChor.Text = tbLvlChor.Value.ToString("X");
            if (txtLvlChor.Text.Length < 2)
                txtLvlChor.Text = "0" + txtLvlChor.Text;
            UpdateEffectObjects("Form", "Chorus", "Volume");
            txtLvlChor.Text = tbLvlChor.Value.ToString();
        }

        /*******************************************
         *  Helper Functions
         ********************************************/
        // Initialization Functions
        private void InitializeTrackBars()
        {
            // Initialize FX Settings TrackBars
            maximumPosition = tbChorDepth.Maximum;
            defaultPosition = (int)maximumPosition / 2;
            tbChorDepth.Value = defaultPosition;
            tbChorRate.Value = defaultPosition;
            tbDelDelay.Value = defaultPosition;
            tbDelIntensity.Value = defaultPosition;
            tbDistGain.Value = defaultPosition;
            tbDistTone.Value = defaultPosition;
            tbRevReverb.Value = defaultPosition;
            // Initialize Volume Level TrackBars
            tbLvlChor.Value = 0;
            tbLvlDel.Value = 0;
            tbLvlDist.Value = 0;
            tbLvlRev.Value = 0;
            tbLvlMaster.Value = tbLvlMaster.Maximum;
            // Initialize FX Setting Text Boxes
            txtChorDepth.Text = (100 * tbChorDepth.Value / maximumPosition).ToString();
            txtChorRate.Text = (100 * tbChorRate.Value / maximumPosition).ToString();
            txtDelDelay.Text = (100 * tbDelDelay.Value / maximumPosition).ToString();
            txtDelIntensity.Text = (100 * tbDelIntensity.Value / maximumPosition).ToString();
            txtDistGain.Text = (100 * tbDistGain.Value / maximumPosition).ToString();
            txtDistTone.Text = (100 * tbDistTone.Value / maximumPosition).ToString();
            txtRevReverb.Text = (100 * tbRevReverb.Value / maximumPosition).ToString();
            // Initialize Volume Level Text Boxes
            txtLvlChor.Text = (tbLvlChor.Value).ToString();
            txtLvlDel.Text = (tbLvlDel.Value).ToString();
            txtLvlDist.Text = (tbLvlDist.Value).ToString();
            txtLvlRev.Text = (tbLvlRev.Value).ToString();
            txtLvlMaster.Text = (tbLvlMaster.Value).ToString();
        }

        private void InitializeEffectObjects()
        {
            foreach (string name in effectNames)
            {
                List<EffectControl> ctrls = new List<EffectControl>();
                EffectControl[] tempc = new EffectControl[] { new EffectControl(), new EffectControl() };
                Effect tempe = new Effect();
                tempe.volume = new string[] { "FF", "FF", "FF" }; // 255%
                tempc[0].buffer = new string[] { "FF", "FF", "FF" }; // 255%
                tempc[1].buffer = new string[] { "FF", "FF", "FF" }; // 255%
                switch (name)
                {
                    case "Chorus":
                        tempc[0].ctrlName = "Depth";
                        ctrls.Add(tempc[0]);
                        tempc[1].ctrlName = "Rate";
                        ctrls.Add(tempc[1]);
                        break;
                    case "Delay":
                        tempc[0].ctrlName = "Delay";
                        ctrls.Add(tempc[0]);
                        tempc[1].ctrlName = "Intensity";
                        ctrls.Add(tempc[1]);
                        break;
                    case "Distortion":
                        tempc[0].ctrlName = "Gain";
                        ctrls.Add(tempc[0]);
                        tempc[1].ctrlName = "Tone";
                        ctrls.Add(tempc[1]);
                        break;
                    case "Reverb":
                        tempc[0].ctrlName = "Reverb";
                        ctrls.Add(tempc[0]);
                        break;
                    case "Volume":
                        tempc[0].ctrlName = "Master";
                        ctrls.Add(tempc[0]);
                        break;

                }
                tempe.controls = ctrls;
                tempe.name = name;
                effectList.Add(tempe);
            }
        }

        private void getAvailablePorts()
        {
            String[] ports = SerialPort.GetPortNames();
            cmbPort.Items.AddRange(ports);
        }

        // Effect Object Management
        private void UpdateEffectObjects(string updateSource, string effectUpdates, string controlUpdates)
        {
            progBarSendFX.Value = 0;
            switch (updateSource)
            {
                case "Form":
                    int index = effectList.FindIndex(x => x.name == effectUpdates);
                    switch (effectUpdates)
                    {
                        case "Chorus":
                            if (controlUpdates == "Volume")
                            {
                                effectList.ElementAt(index).volume[1] = txtLvlChor.Text;
                            }
                            else if (controlUpdates == "Depth")
                            {
                                effectList.ElementAt(index).controls.ElementAt(0).buffer[1] = txtChorDepth.Text; // Depth control
                            }
                            else
                            {
                                effectList.ElementAt(index).controls.ElementAt(1).buffer[1] = txtChorRate.Text; // Rate control
                            }
                            break;
                        case "Delay":
                            if (controlUpdates == "Volume")
                            {
                                effectList.ElementAt(index).volume[1] = txtLvlDel.Text;
                            }
                            else if (controlUpdates == "Delay")
                            {
                                effectList.ElementAt(index).controls.ElementAt(0).buffer[1] = txtDelDelay.Text; // Delay control
                            }
                            else
                            {
                                effectList.ElementAt(index).controls.ElementAt(1).buffer[1] = txtDelIntensity.Text; // Intensity control
                            }
                            break;
                        case "Distortion":
                            if (controlUpdates == "Volume")
                            {
                                effectList.ElementAt(index).volume[1] = txtLvlDist.Text;
                            }
                            else if (controlUpdates == "Gain")
                            {
                                effectList.ElementAt(index).controls.ElementAt(0).buffer[1] = txtDistGain.Text; // Gain control
                            }
                            else
                            {
                                effectList.ElementAt(index).controls.ElementAt(1).buffer[1] = txtDistTone.Text; // Tone control
                            }
                            break;
                        case "Reverb":
                            if (controlUpdates == "Volume")
                            {
                                effectList.ElementAt(index).volume[1] = txtLvlRev.Text;
                            }
                            else if (controlUpdates == "Reverb")
                            {
                                effectList.ElementAt(index).controls.ElementAt(0).buffer[1] = txtRevReverb.Text; // Reverb control
                            }
                            break;
                        case "Volume":
                            effectList.ElementAt(index).volume[1] = txtLvlMaster.Text;
                            break;
                    }
                    break;
                case "Profile":
                    // Unused as of now
                    break;
            }
        }

        private void UpdateEffectObjectsAfterTX(List<string> changedCtrls)
        {
            int effect = 0;
            int control = 0;
            foreach (string str in changedCtrls)
            {
                effect = Convert.ToInt32(str.Substring(0, 1)); // effect address character
                control = Convert.ToInt32(str.Substring(1, 1), 16); // control address character
                if (control == Convert.ToInt32("F",16)) // control is the effect volume
                {
                    effectList.ElementAt(effect).volume[0] = str.Substring(2, 2);
                }
                else // control is not the volume
                {
                    effectList.ElementAt(effect).controls[control].buffer[0] = str.Substring(2, 2);
                }
            }
        }

        // Effect Profile Management
        private void UpdateProfileList()
        {
            FileInfo[] Files = pwd.GetFiles("*.txt");
            lbProfiles.Items.Clear();
            foreach (FileInfo file in Files)
            {
                lbProfiles.Items.Add(file.Name);
            }
            if (lbProfiles.Items.Count > 0)
            {
                lbProfiles.SelectedIndex = 0;
            }
        }

        private void OpenProfile(string fileName)
        {
            // 1. Open Profile is called
            // 2. File opened and parsed, values stored into 3rd buffer location for Effect Objects
            // 3. Form values are updated based on Effect Object buffer values
            // 4. Text boxes are changed to reflect new values

            string filePath = pwd.ToString() + @"\" + fileName;
            string settings = File.ReadAllText(filePath);
            //MessageBox.Show(filePath+"\n"+settings);
            profileActive = true;
            /* Begin Parsing Procedure */
            int index = 0;
            int temp = 0;
            string sub = "";
            char[] delims = { ':', ',', '-', '|' }; // volume, control index, control value

            while (index < settings.Length)
            {
                sub = settings.Substring(index, settings.IndexOf('|', index)-index+1);
                string[] profile = sub.Split(delims);
                temp = Int32.Parse(profile[0]);
                // Apply Profile settings for the selected effecttemp = Int32.Parse(profile[0]);
                effectList.ElementAt(temp).volume[2] = profile[1];
                for (int i = 0; i < effectList.ElementAt(temp).controls.Count; i++)
                {
                    effectList.ElementAt(temp).controls[i].buffer[2] = profile[2*i+3];
                }
                index = settings.IndexOf('|', index)+1; // update the index to start of the next effect setting
            }
            LoadProfileToForm();
        }

        private void LoadProfileToForm()
        {
            for (int i = 0; i < effectList.Count; i++)
            {
                switch (effectList.ElementAt(i).name)
                {
                    // Text Box update is handled by event handler for ValueChanged on TrackBar and profileActive == true
                    case "Chorus":
                        // Update TrackBar Values
                        tbLvlChor.Value = Convert.ToInt32(effectList.ElementAt(i).volume[2], 16);
                        tbChorDepth.Value = Convert.ToInt32(effectList.ElementAt(i).controls[0].buffer[2], 16);
                        tbChorRate.Value = Convert.ToInt32(effectList.ElementAt(i).controls[1].buffer[2], 16);
                        // Update Text Boxes
                        txtLvlChor.Text = tbLvlChor.Value.ToString();
                        txtChorDepth.Text = tbChorDepth.Value.ToString();
                        txtChorRate.Text = tbChorRate.Value.ToString();
                        break;
                    case "Delay":
                        // Update TrackBar Values
                        tbLvlDel.Value = Convert.ToInt32(effectList.ElementAt(i).volume[2], 16);
                        tbDelDelay.Value = Convert.ToInt32(effectList.ElementAt(i).controls[0].buffer[2], 16);
                        tbDelIntensity.Value = Convert.ToInt32(effectList.ElementAt(i).controls[1].buffer[2], 16);
                        // Update Text Boxes
                        txtLvlDel.Text = tbLvlDel.Value.ToString();
                        txtDelDelay.Text = tbDelDelay.Value.ToString();
                        txtDelIntensity.Text = tbDelIntensity.Value.ToString();
                        break;
                    case "Distortion":
                        // Update TrackBar Values
                        tbLvlDist.Value = Convert.ToInt32(effectList.ElementAt(i).volume[2], 16);
                        tbDistGain.Value = Convert.ToInt32(effectList.ElementAt(i).controls[0].buffer[2], 16);
                        tbDistTone.Value = Convert.ToInt32(effectList.ElementAt(i).controls[1].buffer[2], 16);
                        // Update Text Boxes
                        txtLvlDist.Text = tbLvlDist.Value.ToString();
                        txtDistGain.Text = tbDistGain.Value.ToString();
                        txtDistTone.Text = tbDistTone.Value.ToString();
                        break;
                    case "Reverb":
                        // Update TrackBar Values
                        tbLvlRev.Value = Convert.ToInt32(effectList.ElementAt(i).volume[2], 16);
                        tbRevReverb.Value = Convert.ToInt32(effectList.ElementAt(i).controls[0].buffer[2], 16);
                        // Update Text Boxes
                        txtLvlRev.Text = tbLvlRev.Value.ToString();
                        txtRevReverb.Text = tbRevReverb.Value.ToString();
                        break;
                    case "Volume":
                        // Update TrackBar Values
                        tbLvlMaster.Value = Convert.ToInt32(effectList.ElementAt(i).volume[2], 16);
                        // Update Text Boxes
                        txtLvlMaster.Text = tbLvlMaster.Value.ToString();
                        break;
                }
            }
        }

        // Bluetooth COM Port functions
        private void sendFXData()
        {
            List<string> output = new List<string>();
            // Determine which effect controls changed in order to only transmit those
            output = findChangedControls();
            progBarSendFX.Value = 33;
            // Parse data strings and send out data
            serialPort1.Write("<"+output.Count.ToString("X")); // notify the MSP432 how many settings were changed
            foreach (string str in output)
            {
                serialPort1.Write(str);
            }
            serialPort1.WriteLine(">\r"); // notify the MSP432 that all changed settings have been sent
            progBarSendFX.Value = 66;
            // Consolidate the old values of the affected Effect objects to match newly sent values
            UpdateEffectObjectsAfterTX(output);
            progBarSendFX.Value = 100;
        }

        private List<string> findChangedControls()
        {
            List<string> temp = new List<string>();
            string profileStr = "";

            for (int i = 0; i < effectList.Count; i++)
            {
                if (false & profileActive) // Profile settings
                {
                    // only the buffer values at [2] should be compared to the old value at [0]
                    // Check for volume changes
                    if (effectList.ElementAt(i).volume[0] != effectList.ElementAt(i).volume[2])
                    {
                        profileStr += i.ToString();
                        profileStr += "F" + effectList.ElementAt(i).volume[2]; // note: "F" is used as the address of the volume control
                        temp.Add(profileStr);
                    }
                    profileStr = "";
                    // Check for control changes
                    for (int j = 0; j < effectList.ElementAt(i).controls.Count; j++)
                    {
                        profileStr = "";
                        if (effectList.ElementAt(i).controls[j].buffer[0] != effectList.ElementAt(i).controls[j].buffer[2])
                        {
                            profileStr += i.ToString();
                            profileStr += j.ToString() + effectList.ElementAt(i).controls[j].buffer[2];
                            temp.Add(profileStr);
                        }
                    }
                    profileStr = "";
                }
                else // Custom settings
                {
                    // Check for volume changes
                    if (effectList.ElementAt(i).volume[0] != effectList.ElementAt(i).volume[1])
                    {
                        profileStr += i.ToString();
                        profileStr += "F" + effectList.ElementAt(i).volume[1]; // note: "F" is used as the address of the volume control
                        temp.Add(profileStr);
                    }
                    profileStr = "";
                    // Check for control changes
                    for (int j = 0; j < effectList.ElementAt(i).controls.Count; j++)
                    {
                        profileStr = "";
                        if (effectList.ElementAt(i).controls[j].buffer[0] != effectList.ElementAt(i).controls[j].buffer[1])
                        {
                            profileStr += i.ToString();
                            profileStr += j.ToString() + effectList.ElementAt(i).controls[j].buffer[1];
                            temp.Add(profileStr);
                        }
                    }
                    profileStr = "";
                }
            }
            return temp;
        }
        
    }
}
