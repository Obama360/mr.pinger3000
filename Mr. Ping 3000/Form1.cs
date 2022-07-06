using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Mr.Ping_3000
{
    public partial class FormMain : Form
    {
        private Thread threadPing { get; set; }
        private Thread threadTimer { get; set; }
        private string pingFunction { get; set; }
        private int pingAmount { get; set; }
        private bool timerDone { get; set; }
        private int timerTime { get; set; }
        private bool loggingActive { get; set; }
        private string loggingPath { get; set; }

        public FormMain()
        {
            InitializeComponent();
        }

        DateTime timeNow = new DateTime();
        Ping newPing = new Ping();

        float pingSucc;
        float pingFail;
        float pingAmon;

        private void buttonStartPing_Click(object sender, EventArgs e)
        {
            if (numericUpDownPingTimeHour.Value == 0 && numericUpDownPingTimeMinute.Value == 0 && numericUpDownPingTimeSecond.Value == 0)
                numericUpDownPingTimeSecond.Value = 1;

            pingSucc = 0;
            pingFail = 0;
            pingAmon = 0;

            ProcessBar("continuous", 1);
            pingAmount = Convert.ToInt32(numericUpDownPingAmount.Value);
            if (textBoxPingAddress.Text != "")
            {
                richTextBoxStatusConsole.Text = "";
                threadPing = new Thread(this.PingPong);
                threadPing.Start();
            }
        }

        private void StatusUpdate (string input)
        {
            richTextBoxStatusConsole.Invoke((Action)delegate
            {
                timeNow = DateTime.Now;
                richTextBoxStatusConsole.AppendText(timeNow.ToString("HH:mm:ss") + " - " + input + Environment.NewLine);

                if (loggingActive)
                {
                    File.AppendAllText(loggingPath, timeNow.ToString("HH:mm:ss") + " - " + input + Environment.NewLine);
                }

                richTextBoxStatusConsole.SelectionStart = richTextBoxStatusConsole.Text.Length;
                richTextBoxStatusConsole.ScrollToCaret();

            });
        }

        private void PingPong ()
        {
            StatusUpdate("Sending Ping(s) to address: " + textBoxPingAddress.Text + "\n");
            PingButtonActive(false);

            switch (pingFunction)
            {

                //Ping until stopped
                case "forever":
                    ProcessBar("marquee", 1);
                    try
                    {                        
                        while (true)
                        {
                            
                            Ping newPing = new Ping();
                            PingReply reply = newPing.Send(textBoxPingAddress.Text, 1);
                            StatusUpdate("Status :  " + reply.Status + " \nTime : " + reply.RoundtripTime.ToString() + " \n Reply-address : " + reply.Address + "\n");

                            if (Convert.ToString(reply.Status) == "Success")
                            {
                                pingSucc++;
                            } else
                            {
                                pingFail++;
                            }
                            pingAmon++;
                            Thread.Sleep(Convert.ToInt32(numericUpDownPingInterval.Value));
                        }
                    }
                    catch
                    {
                        StatusUpdate("Pinging finished.");
                        ProcessBar("continuous", 1);
                        PingButtonActive(true);
                    }
                    break;

                //Ping for amount of times
                case "amount":
                    try
                    {
                        ProcessBar("continuous", Convert.ToInt32(numericUpDownPingAmount.Value));
                        for (int i = 0; i < pingAmount; i++)
                        {
                            ProcessBar("update", i + 1);
                            PingReply reply = newPing.Send(textBoxPingAddress.Text, 1);
                            StatusUpdate("Status :  " + reply.Status + " \nTime : " + reply.RoundtripTime.ToString() + " \n Reply-address : " + reply.Address + "\n");

                            if (Convert.ToString(reply.Status) == "Success")
                            {
                                pingSucc++;
                            }
                            else
                            {
                                pingFail++;
                            }
                            pingAmon++;

                            Thread.Sleep(Convert.ToInt32(numericUpDownPingInterval.Value));
                        }
                        StatusUpdate("Pinging finished");
                        ProcessBar("continuous", 1);
                        PingButtonActive(true);
                        Summary();
                    }
                    catch

                    {
                        StatusUpdate("Pinging finished.");
                        ProcessBar("continuous", 1);
                        PingButtonActive(true);
                        Summary();
                    }
                    break;

                //Ping for amount of time
                case "time":
                    try
                    {
                        timerTime = ((Convert.ToInt32(numericUpDownPingTimeSecond.Value)) + (Convert.ToInt32(numericUpDownPingTimeMinute.Value) * 60) + (Convert.ToInt32(numericUpDownPingTimeHour.Value) * 60 * 60));
                        ProcessBar("continuous", timerTime);
                        threadTimer = new Thread(this.Timer);
                        threadTimer.Start();
                        while (!timerDone)
                        {
                            
                            PingReply reply = newPing.Send(textBoxPingAddress.Text, 1);
                            StatusUpdate("Status :  " + reply.Status + " \nTime : " + reply.RoundtripTime.ToString() + " \n Reply-address : " + reply.Address + "\n");

                            if (Convert.ToString(reply.Status) == "Success")
                            {
                                pingSucc++;
                            }
                            else
                            {
                                pingFail++;
                            }
                            pingAmon++;

                            Thread.Sleep(Convert.ToInt32(numericUpDownPingInterval.Value));
                        }
                        StatusUpdate("Pinging finished.");
                        ProcessBar("continuous", 1);
                        threadTimer.Abort();
                        PingButtonActive(true);
                        Summary();
                    } catch
                    {
                        StatusUpdate("Pinging finished.");
                        ProcessBar("continuous", 1);
                        threadTimer.Abort();
                        PingButtonActive(true);
                        Summary();
                    }
                    break;

                default:
                    StatusUpdate("what is " + pingFunction + " supposed to mean? bruh");
                    break;
            }
        }

        private void buttonStopPing_Click(object sender, EventArgs e)
        {
            if (threadPing != null)
            {
                threadPing.Abort();
                ProcessBar("continuous", 0);
                if (!buttonStartPing.Enabled)
                    Summary();

            } else
            {
                StatusUpdate("Failed to stop :(");
            }

            if (threadTimer != null)
                threadTimer.Abort();
            PingButtonActive(true);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            progressBarPing.Style = ProgressBarStyle.Continuous;

            if (radioButtonPingForever.Checked)
            {
                pingFunction = "forever";
                groupBoxPingAmount.Enabled = false;
                groupBoxPingTime.Enabled = false;
            }

            if (radioButtonPingAmount.Checked)
            {
                pingFunction = "amount";
                groupBoxPingAmount.Enabled = true;
                groupBoxPingTime.Enabled = false;
            }

            if (radioButtonPingTime.Checked)
            {
                pingFunction = "time";
                groupBoxPingAmount.Enabled = false;
                groupBoxPingTime.Enabled = true;
            }

        }

        private void ProcessBar (string option, int amount)
        {
            switch (option)
            {
                case "marquee":
                    progressBarPing.Invoke((Action)delegate
                    {
                        progressBarPing.Style = ProgressBarStyle.Marquee;
                    });
                    break;

                case "continuous":
                    progressBarPing.Invoke((Action)delegate
                    {
                        progressBarPing.Style = ProgressBarStyle.Continuous;
                        progressBarPing.Value = 0;
                        progressBarPing.Maximum = Convert.ToInt32(amount);
                    });
                    break;

                case "update":
                    progressBarPing.Invoke((Action)delegate
                    {
                        progressBarPing.Value = amount;
                    });
                    break;
            }
        }

        private void Timer()
        {
            timerDone = false;
            for (int i = 0; i < timerTime; i++)
            {
                ProcessBar("update", i+1);
                Thread.Sleep(1000);
            }

            try
            {
                threadPing.Abort();
            } catch
            {
            }
            timerDone = true;
        }

        private void Summary()
        {
            MessageBox.Show("Ping Summary:\n\nTimes pinged:    " + pingAmon + "\nSucceeded:         " + pingSucc + "\nFailed:                 " + pingFail + "\n\nSuccess rate:       " + Math.Round((pingSucc / pingAmon) * 100, 2) + "%", "Pinging finished", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            if (loggingActive)
            
            {
                File.AppendAllText(loggingPath, "\n================\nPing Summary:\n\nTimes pinged: " + pingAmon + "\nSucceeded: " + pingSucc + "\nFailed: " + pingFail + "\nSuccess rate: " + (pingSucc / pingAmon) * 100 + "%\n================\n");
            }
        }

        private void PingButtonActive(bool mode)
        {
            buttonStartPing.Invoke((Action)delegate
            {
                buttonStartPing.Enabled = mode;
            });

            groupBoxPingOptions.Invoke((Action)delegate
            {
                groupBoxPingOptions.Enabled = mode;
            });

            textBoxPingAddress.Invoke((Action)delegate
            {
                textBoxPingAddress.Enabled = mode;
            });
        }

        private void radioButtonPingForever_CheckedChanged(object sender, EventArgs e)
        {
            pingFunction = "forever";
            groupBoxPingAmount.Enabled = false;
            groupBoxPingTime.Enabled = false;
        }

        private void radioButtonPingAmount_CheckedChanged(object sender, EventArgs e)
        {
            pingFunction = "amount";
            groupBoxPingAmount.Enabled = true;
            groupBoxPingTime.Enabled = false;
        }

        private void radioButtonPingTime_CheckedChanged(object sender, EventArgs e)
        {
            pingFunction = "time";
            groupBoxPingAmount.Enabled = false;
            groupBoxPingTime.Enabled = true;
        }

        private void buttonLoggingPath_Click(object sender, EventArgs e)
        {
            if (saveFileDialogLogging.ShowDialog() == DialogResult.OK && saveFileDialogLogging.FileName != "")
            {
                labelLoggingPath.Text = saveFileDialogLogging.FileName;
                labelLoggingPath.ForeColor = Color.Gray;
                loggingPath = saveFileDialogLogging.FileName;
                checkBoxLogging.Checked = true;
            }
        }

        private void checkBoxLogging_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLogging.Checked)
            {
                if (labelLoggingPath.Text == "No Path set")
                {
                    checkBoxLogging.Checked = false;
                    labelLoggingPath.ForeColor = Color.Red;
                    loggingActive = false;
                }
                else
                {
                    loggingActive = true;
                }
            } else
            {
                loggingActive = false;
            }
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            Form AboutForm = new AboutBoxPinger3000();
            AboutForm.Show();
        }
    }
}
