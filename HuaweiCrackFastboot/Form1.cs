using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HuaweiCrackFastboot
{
    public partial class Form1 : Form
    {
        String AdbCommand;
        String OemUnlockCommand;
        long Carpan;
        long Min;
        long Max;
        long Percent;
        bool StartStop;
        long LastCount;
        Process procBg;

        public Form1()
        {
            InitializeComponent();

            this.AdbCommand = "adb.exe";
            this.OemUnlockCommand = "fastboot.exe";
            this.Carpan = 1111111111111111;

            this.calculateValues();
            SetCurrentText("" + this.Carpan * (long)end_num.Value + "");
        }

        private void calculateValues()
        {
            this.Min = this.Carpan * (long) start_num.Value;
            this.Max = this.Carpan * (long) end_num.Value;
            this.Percent = (long) Math.Round((double) (100 / (this.Carpan)));
        }

        public void AppendTextBox(string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendTextBox), new object[] { value });
                return;
            }
            status_box.AppendText(value);
        }

        public void SetCurrentText(string count)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(SetCurrentText), new object[] { count });
                return;
            }
            currentCount.Text = count;
        }

        public void StartBgProc(string proc, string param)
        {
            string procFull = proc + " " + param;
            this.procBg = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = @proc,
                    Arguments = param,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true
                }
            };
            //AppendTextBox("Command: " + procFull + "\n");
            this.procBg.Start();
            this.procBg.WaitForExit();

            //AppendTextBox("Result: " + this.procBg.StandardOutput.ReadToEnd() + "\n");

            if (this.procBg.ExitCode == -1)
                throw new Exception(this.procBg.StandardOutput.ReadToEnd());
        }

        private void runOemUnlock()
        {
            crack.Enabled = false;
            this.calculateValues();

            

            long i = this.Max;

            new Thread(() =>
            {
                while (this.StartStop)
                {
                    this.LastCount = i;

                    SetCurrentText("" + this.LastCount + "");
                    progress.Value = progress.Value + (int)this.Percent;

                    try
                    {
                        this.AppendTextBox("Cracking: " + i + "\n");
                        StartBgProc("fastboot.exe", "oem unlock " + i);
                    }
                    catch (Win32Exception ex)
                    {
                        this.AppendTextBox(ex.Message+"\n");
                    }

                    i--;
                    if (i == this.Min)
                    {
                        break;
                    }
                }
            }).Start();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // crack
            this.StartStop = true;
            this.runOemUnlock();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            this.calculateValues();
            SetCurrentText("" + this.Carpan * (long)end_num.Value + "");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // reboot loader
            try
            {
                this.AppendTextBox("Rebooting... \n");
                StartBgProc("adb.exe", "reboot bootloader");
                this.AppendTextBox("Done. \n");
            }
            catch (Win32Exception ex)
            {
                this.AppendTextBox(ex.Message + "\n");
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void start_num_ValueChanged(object sender, EventArgs e)
        {

        }

        private void progress_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void kill_Click(object sender, EventArgs e)
        {
            this.StartStop = false;
            crack.Enabled = true;
            this.AppendTextBox("Killed.\n");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
