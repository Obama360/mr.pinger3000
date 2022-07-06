namespace Mr.Ping_3000
{
    partial class FormMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPingAddress = new System.Windows.Forms.TextBox();
            this.buttonStartPing = new System.Windows.Forms.Button();
            this.richTextBoxStatusConsole = new System.Windows.Forms.RichTextBox();
            this.buttonStopPing = new System.Windows.Forms.Button();
            this.progressBarPing = new System.Windows.Forms.ProgressBar();
            this.groupBoxPingOptions = new System.Windows.Forms.GroupBox();
            this.groupBoxLogging = new System.Windows.Forms.GroupBox();
            this.labelLoggingPath = new System.Windows.Forms.Label();
            this.buttonLoggingPath = new System.Windows.Forms.Button();
            this.checkBoxLogging = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDownPingInterval = new System.Windows.Forms.NumericUpDown();
            this.groupBoxPingTime = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownPingTimeSecond = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownPingTimeMinute = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownPingTimeHour = new System.Windows.Forms.NumericUpDown();
            this.groupBoxPingAmount = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownPingAmount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonPingTime = new System.Windows.Forms.RadioButton();
            this.radioButtonPingAmount = new System.Windows.Forms.RadioButton();
            this.radioButtonPingForever = new System.Windows.Forms.RadioButton();
            this.saveFileDialogLogging = new System.Windows.Forms.SaveFileDialog();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.groupBoxPingOptions.SuspendLayout();
            this.groupBoxLogging.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPingInterval)).BeginInit();
            this.groupBoxPingTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPingTimeSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPingTimeMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPingTimeHour)).BeginInit();
            this.groupBoxPingAmount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPingAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ping Address";
            // 
            // textBoxPingAddress
            // 
            this.textBoxPingAddress.Location = new System.Drawing.Point(15, 38);
            this.textBoxPingAddress.Name = "textBoxPingAddress";
            this.textBoxPingAddress.Size = new System.Drawing.Size(189, 20);
            this.textBoxPingAddress.TabIndex = 1;
            // 
            // buttonStartPing
            // 
            this.buttonStartPing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonStartPing.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStartPing.Location = new System.Drawing.Point(210, 37);
            this.buttonStartPing.Name = "buttonStartPing";
            this.buttonStartPing.Size = new System.Drawing.Size(49, 23);
            this.buttonStartPing.TabIndex = 2;
            this.buttonStartPing.Text = "Ping it!";
            this.buttonStartPing.UseVisualStyleBackColor = false;
            this.buttonStartPing.Click += new System.EventHandler(this.buttonStartPing_Click);
            // 
            // richTextBoxStatusConsole
            // 
            this.richTextBoxStatusConsole.BackColor = System.Drawing.Color.White;
            this.richTextBoxStatusConsole.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBoxStatusConsole.Location = new System.Drawing.Point(15, 66);
            this.richTextBoxStatusConsole.Name = "richTextBoxStatusConsole";
            this.richTextBoxStatusConsole.ReadOnly = true;
            this.richTextBoxStatusConsole.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBoxStatusConsole.Size = new System.Drawing.Size(298, 343);
            this.richTextBoxStatusConsole.TabIndex = 3;
            this.richTextBoxStatusConsole.Text = "";
            // 
            // buttonStopPing
            // 
            this.buttonStopPing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonStopPing.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStopPing.Location = new System.Drawing.Point(265, 37);
            this.buttonStopPing.Name = "buttonStopPing";
            this.buttonStopPing.Size = new System.Drawing.Size(48, 23);
            this.buttonStopPing.TabIndex = 4;
            this.buttonStopPing.Text = "Stop it!";
            this.buttonStopPing.UseVisualStyleBackColor = false;
            this.buttonStopPing.Click += new System.EventHandler(this.buttonStopPing_Click);
            // 
            // progressBarPing
            // 
            this.progressBarPing.Location = new System.Drawing.Point(12, 415);
            this.progressBarPing.MarqueeAnimationSpeed = 50;
            this.progressBarPing.Name = "progressBarPing";
            this.progressBarPing.Size = new System.Drawing.Size(301, 23);
            this.progressBarPing.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBarPing.TabIndex = 5;
            // 
            // groupBoxPingOptions
            // 
            this.groupBoxPingOptions.Controls.Add(this.groupBoxLogging);
            this.groupBoxPingOptions.Controls.Add(this.groupBox1);
            this.groupBoxPingOptions.Controls.Add(this.groupBoxPingTime);
            this.groupBoxPingOptions.Controls.Add(this.groupBoxPingAmount);
            this.groupBoxPingOptions.Controls.Add(this.label2);
            this.groupBoxPingOptions.Controls.Add(this.radioButtonPingTime);
            this.groupBoxPingOptions.Controls.Add(this.radioButtonPingAmount);
            this.groupBoxPingOptions.Controls.Add(this.radioButtonPingForever);
            this.groupBoxPingOptions.Location = new System.Drawing.Point(331, 22);
            this.groupBoxPingOptions.Name = "groupBoxPingOptions";
            this.groupBoxPingOptions.Size = new System.Drawing.Size(300, 416);
            this.groupBoxPingOptions.TabIndex = 6;
            this.groupBoxPingOptions.TabStop = false;
            this.groupBoxPingOptions.Text = "Ping options";
            // 
            // groupBoxLogging
            // 
            this.groupBoxLogging.Controls.Add(this.labelLoggingPath);
            this.groupBoxLogging.Controls.Add(this.buttonLoggingPath);
            this.groupBoxLogging.Controls.Add(this.checkBoxLogging);
            this.groupBoxLogging.Location = new System.Drawing.Point(6, 354);
            this.groupBoxLogging.Name = "groupBoxLogging";
            this.groupBoxLogging.Size = new System.Drawing.Size(288, 50);
            this.groupBoxLogging.TabIndex = 12;
            this.groupBoxLogging.TabStop = false;
            this.groupBoxLogging.Text = "Logging";
            // 
            // labelLoggingPath
            // 
            this.labelLoggingPath.AutoSize = true;
            this.labelLoggingPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.labelLoggingPath.ForeColor = System.Drawing.Color.Gray;
            this.labelLoggingPath.Location = new System.Drawing.Point(174, 20);
            this.labelLoggingPath.Name = "labelLoggingPath";
            this.labelLoggingPath.Size = new System.Drawing.Size(62, 13);
            this.labelLoggingPath.TabIndex = 2;
            this.labelLoggingPath.Text = "No Path set";
            // 
            // buttonLoggingPath
            // 
            this.buttonLoggingPath.Location = new System.Drawing.Point(112, 15);
            this.buttonLoggingPath.Name = "buttonLoggingPath";
            this.buttonLoggingPath.Size = new System.Drawing.Size(57, 23);
            this.buttonLoggingPath.TabIndex = 1;
            this.buttonLoggingPath.Text = "Set path";
            this.buttonLoggingPath.UseVisualStyleBackColor = true;
            this.buttonLoggingPath.Click += new System.EventHandler(this.buttonLoggingPath_Click);
            // 
            // checkBoxLogging
            // 
            this.checkBoxLogging.AutoSize = true;
            this.checkBoxLogging.Location = new System.Drawing.Point(9, 19);
            this.checkBoxLogging.Name = "checkBoxLogging";
            this.checkBoxLogging.Size = new System.Drawing.Size(100, 17);
            this.checkBoxLogging.TabIndex = 0;
            this.checkBoxLogging.Text = "Enable Logging";
            this.checkBoxLogging.UseVisualStyleBackColor = true;
            this.checkBoxLogging.CheckedChanged += new System.EventHandler(this.checkBoxLogging_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.numericUpDownPingInterval);
            this.groupBox1.Location = new System.Drawing.Point(6, 269);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 79);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ping interval";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(186, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "milliseconds";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Ping every";
            // 
            // numericUpDownPingInterval
            // 
            this.numericUpDownPingInterval.Location = new System.Drawing.Point(65, 34);
            this.numericUpDownPingInterval.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numericUpDownPingInterval.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownPingInterval.Name = "numericUpDownPingInterval";
            this.numericUpDownPingInterval.Size = new System.Drawing.Size(115, 20);
            this.numericUpDownPingInterval.TabIndex = 7;
            this.numericUpDownPingInterval.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // groupBoxPingTime
            // 
            this.groupBoxPingTime.Controls.Add(this.label12);
            this.groupBoxPingTime.Controls.Add(this.label11);
            this.groupBoxPingTime.Controls.Add(this.label10);
            this.groupBoxPingTime.Controls.Add(this.label7);
            this.groupBoxPingTime.Controls.Add(this.numericUpDownPingTimeSecond);
            this.groupBoxPingTime.Controls.Add(this.label5);
            this.groupBoxPingTime.Controls.Add(this.numericUpDownPingTimeMinute);
            this.groupBoxPingTime.Controls.Add(this.label6);
            this.groupBoxPingTime.Controls.Add(this.numericUpDownPingTimeHour);
            this.groupBoxPingTime.Location = new System.Drawing.Point(6, 163);
            this.groupBoxPingTime.Name = "groupBoxPingTime";
            this.groupBoxPingTime.Size = new System.Drawing.Size(288, 100);
            this.groupBoxPingTime.TabIndex = 10;
            this.groupBoxPingTime.TabStop = false;
            this.groupBoxPingTime.Text = "Ping for amount of time";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(200, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "second";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(131, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "minute";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(65, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "hour";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(180, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = ":";
            // 
            // numericUpDownPingTimeSecond
            // 
            this.numericUpDownPingTimeSecond.Location = new System.Drawing.Point(196, 41);
            this.numericUpDownPingTimeSecond.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownPingTimeSecond.Name = "numericUpDownPingTimeSecond";
            this.numericUpDownPingTimeSecond.Size = new System.Drawing.Size(49, 20);
            this.numericUpDownPingTimeSecond.TabIndex = 12;
            this.numericUpDownPingTimeSecond.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = ":";
            // 
            // numericUpDownPingTimeMinute
            // 
            this.numericUpDownPingTimeMinute.Location = new System.Drawing.Point(125, 41);
            this.numericUpDownPingTimeMinute.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownPingTimeMinute.Name = "numericUpDownPingTimeMinute";
            this.numericUpDownPingTimeMinute.Size = new System.Drawing.Size(49, 20);
            this.numericUpDownPingTimeMinute.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ping for";
            // 
            // numericUpDownPingTimeHour
            // 
            this.numericUpDownPingTimeHour.Location = new System.Drawing.Point(55, 41);
            this.numericUpDownPingTimeHour.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownPingTimeHour.Name = "numericUpDownPingTimeHour";
            this.numericUpDownPingTimeHour.Size = new System.Drawing.Size(49, 20);
            this.numericUpDownPingTimeHour.TabIndex = 7;
            // 
            // groupBoxPingAmount
            // 
            this.groupBoxPingAmount.Controls.Add(this.label4);
            this.groupBoxPingAmount.Controls.Add(this.label3);
            this.groupBoxPingAmount.Controls.Add(this.numericUpDownPingAmount);
            this.groupBoxPingAmount.Location = new System.Drawing.Point(6, 57);
            this.groupBoxPingAmount.Name = "groupBoxPingAmount";
            this.groupBoxPingAmount.Size = new System.Drawing.Size(288, 100);
            this.groupBoxPingAmount.TabIndex = 8;
            this.groupBoxPingAmount.TabStop = false;
            this.groupBoxPingAmount.Text = "Ping amount of times";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "time(s)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ping";
            // 
            // numericUpDownPingAmount
            // 
            this.numericUpDownPingAmount.Location = new System.Drawing.Point(40, 41);
            this.numericUpDownPingAmount.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDownPingAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPingAmount.Name = "numericUpDownPingAmount";
            this.numericUpDownPingAmount.Size = new System.Drawing.Size(69, 20);
            this.numericUpDownPingAmount.TabIndex = 7;
            this.numericUpDownPingAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ping ...";
            // 
            // radioButtonPingTime
            // 
            this.radioButtonPingTime.AutoSize = true;
            this.radioButtonPingTime.Location = new System.Drawing.Point(206, 21);
            this.radioButtonPingTime.Name = "radioButtonPingTime";
            this.radioButtonPingTime.Size = new System.Drawing.Size(88, 17);
            this.radioButtonPingTime.TabIndex = 5;
            this.radioButtonPingTime.Text = "for XX:XX:XX";
            this.radioButtonPingTime.UseVisualStyleBackColor = true;
            this.radioButtonPingTime.CheckedChanged += new System.EventHandler(this.radioButtonPingTime_CheckedChanged);
            // 
            // radioButtonPingAmount
            // 
            this.radioButtonPingAmount.AutoSize = true;
            this.radioButtonPingAmount.Location = new System.Drawing.Point(141, 21);
            this.radioButtonPingAmount.Name = "radioButtonPingAmount";
            this.radioButtonPingAmount.Size = new System.Drawing.Size(59, 17);
            this.radioButtonPingAmount.TabIndex = 4;
            this.radioButtonPingAmount.Text = "X times";
            this.radioButtonPingAmount.UseVisualStyleBackColor = true;
            this.radioButtonPingAmount.CheckedChanged += new System.EventHandler(this.radioButtonPingAmount_CheckedChanged);
            // 
            // radioButtonPingForever
            // 
            this.radioButtonPingForever.AutoSize = true;
            this.radioButtonPingForever.Checked = true;
            this.radioButtonPingForever.Location = new System.Drawing.Point(55, 21);
            this.radioButtonPingForever.Name = "radioButtonPingForever";
            this.radioButtonPingForever.Size = new System.Drawing.Size(80, 17);
            this.radioButtonPingForever.TabIndex = 3;
            this.radioButtonPingForever.TabStop = true;
            this.radioButtonPingForever.Text = "until i stop it";
            this.radioButtonPingForever.UseVisualStyleBackColor = true;
            this.radioButtonPingForever.CheckedChanged += new System.EventHandler(this.radioButtonPingForever_CheckedChanged);
            // 
            // saveFileDialogLogging
            // 
            this.saveFileDialogLogging.Filter = "Plain Text Logfile|*.txt";
            // 
            // buttonInfo
            // 
            this.buttonInfo.Font = new System.Drawing.Font("Webdings", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonInfo.Location = new System.Drawing.Point(608, 4);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(23, 23);
            this.buttonInfo.TabIndex = 7;
            this.buttonInfo.Text = "i";
            this.buttonInfo.UseVisualStyleBackColor = true;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 450);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.groupBoxPingOptions);
            this.Controls.Add(this.progressBarPing);
            this.Controls.Add(this.buttonStopPing);
            this.Controls.Add(this.richTextBoxStatusConsole);
            this.Controls.Add(this.buttonStartPing);
            this.Controls.Add(this.textBoxPingAddress);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Mr. Pinger 3000";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxPingOptions.ResumeLayout(false);
            this.groupBoxPingOptions.PerformLayout();
            this.groupBoxLogging.ResumeLayout(false);
            this.groupBoxLogging.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPingInterval)).EndInit();
            this.groupBoxPingTime.ResumeLayout(false);
            this.groupBoxPingTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPingTimeSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPingTimeMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPingTimeHour)).EndInit();
            this.groupBoxPingAmount.ResumeLayout(false);
            this.groupBoxPingAmount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPingAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPingAddress;
        private System.Windows.Forms.Button buttonStartPing;
        private System.Windows.Forms.RichTextBox richTextBoxStatusConsole;
        private System.Windows.Forms.Button buttonStopPing;
        private System.Windows.Forms.ProgressBar progressBarPing;
        private System.Windows.Forms.GroupBox groupBoxPingOptions;
        private System.Windows.Forms.RadioButton radioButtonPingTime;
        private System.Windows.Forms.RadioButton radioButtonPingAmount;
        private System.Windows.Forms.RadioButton radioButtonPingForever;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxPingTime;
        private System.Windows.Forms.NumericUpDown numericUpDownPingTimeMinute;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownPingTimeHour;
        private System.Windows.Forms.GroupBox groupBoxPingAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownPingAmount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDownPingInterval;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownPingTimeSecond;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBoxLogging;
        private System.Windows.Forms.Button buttonLoggingPath;
        private System.Windows.Forms.CheckBox checkBoxLogging;
        private System.Windows.Forms.Label labelLoggingPath;
        private System.Windows.Forms.SaveFileDialog saveFileDialogLogging;
        private System.Windows.Forms.Button buttonInfo;
    }
}

