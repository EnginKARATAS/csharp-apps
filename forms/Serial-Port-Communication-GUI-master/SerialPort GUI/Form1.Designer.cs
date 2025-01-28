namespace SerialPort_GUI
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.msgDisplayTextBox = new System.Windows.Forms.TextBox();
            this.openPortButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openSaveFileDialogButton = new System.Windows.Forms.Button();
            this.baudRateComboBox = new System.Windows.Forms.ComboBox();
            this.portNumberComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.writeTimeOutTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sendPeriodTextBox = new System.Windows.Forms.TextBox();
            this.isSendCheckBox = new System.Windows.Forms.CheckBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.sendMsgTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.isSaveFileCheckBox = new System.Windows.Forms.CheckBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // msgDisplayTextBox
            // 
            this.msgDisplayTextBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.msgDisplayTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.msgDisplayTextBox.ForeColor = System.Drawing.Color.LimeGreen;
            this.msgDisplayTextBox.Location = new System.Drawing.Point(18, 20);
            this.msgDisplayTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.msgDisplayTextBox.Multiline = true;
            this.msgDisplayTextBox.Name = "msgDisplayTextBox";
            this.msgDisplayTextBox.ReadOnly = true;
            this.msgDisplayTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.msgDisplayTextBox.Size = new System.Drawing.Size(604, 312);
            this.msgDisplayTextBox.TabIndex = 0;
            this.msgDisplayTextBox.TextChanged += new System.EventHandler(this.msgDisplayTextBox_TextChanged);
            // 
            // openPortButton
            // 
            this.openPortButton.Location = new System.Drawing.Point(18, 540);
            this.openPortButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.openPortButton.Name = "openPortButton";
            this.openPortButton.Size = new System.Drawing.Size(112, 38);
            this.openPortButton.TabIndex = 1;
            this.openPortButton.Text = "Open";
            this.openPortButton.UseVisualStyleBackColor = true;
            this.openPortButton.Click += new System.EventHandler(this.openPortButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 360);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 427);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Baud Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 490);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "File Path";
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Enabled = false;
            this.filePathTextBox.HideSelection = false;
            this.filePathTextBox.Location = new System.Drawing.Point(209, 488);
            this.filePathTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(123, 26);
            this.filePathTextBox.TabIndex = 7;
            // 
            // openSaveFileDialogButton
            // 
            this.openSaveFileDialogButton.Enabled = false;
            this.openSaveFileDialogButton.Location = new System.Drawing.Point(340, 482);
            this.openSaveFileDialogButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.openSaveFileDialogButton.Name = "openSaveFileDialogButton";
            this.openSaveFileDialogButton.Size = new System.Drawing.Size(36, 37);
            this.openSaveFileDialogButton.TabIndex = 8;
            this.openSaveFileDialogButton.Text = "...";
            this.openSaveFileDialogButton.UseVisualStyleBackColor = true;
            this.openSaveFileDialogButton.Click += new System.EventHandler(this.openSaveFileDialogButton_Click);
            // 
            // baudRateComboBox
            // 
            this.baudRateComboBox.FormattingEnabled = true;
            this.baudRateComboBox.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.baudRateComboBox.Location = new System.Drawing.Point(105, 413);
            this.baudRateComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.baudRateComboBox.Name = "baudRateComboBox";
            this.baudRateComboBox.Size = new System.Drawing.Size(180, 28);
            this.baudRateComboBox.TabIndex = 9;
            this.baudRateComboBox.Text = "115200";
            // 
            // portNumberComboBox
            // 
            this.portNumberComboBox.FormattingEnabled = true;
            this.portNumberComboBox.Location = new System.Drawing.Point(105, 347);
            this.portNumberComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.portNumberComboBox.Name = "portNumberComboBox";
            this.portNumberComboBox.Size = new System.Drawing.Size(180, 28);
            this.portNumberComboBox.TabIndex = 10;
            this.portNumberComboBox.Tag = "COM1";
            this.portNumberComboBox.DropDown += new System.EventHandler(this.portNumberComboBox_DropDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.writeTimeOutTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.sendPeriodTextBox);
            this.groupBox1.Controls.Add(this.isSendCheckBox);
            this.groupBox1.Controls.Add(this.sendButton);
            this.groupBox1.Controls.Add(this.sendMsgTextBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(428, 400);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(764, 178);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Send";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(294, 47);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "ms";
            // 
            // writeTimeOutTextBox
            // 
            this.writeTimeOutTextBox.Location = new System.Drawing.Point(135, 30);
            this.writeTimeOutTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.writeTimeOutTextBox.Name = "writeTimeOutTextBox";
            this.writeTimeOutTextBox.Size = new System.Drawing.Size(148, 26);
            this.writeTimeOutTextBox.TabIndex = 16;
            this.writeTimeOutTextBox.Text = "100";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 35);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Write Time Out";
            // 
            // sendPeriodTextBox
            // 
            this.sendPeriodTextBox.Enabled = false;
            this.sendPeriodTextBox.Location = new System.Drawing.Point(308, 146);
            this.sendPeriodTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sendPeriodTextBox.Name = "sendPeriodTextBox";
            this.sendPeriodTextBox.Size = new System.Drawing.Size(178, 26);
            this.sendPeriodTextBox.TabIndex = 15;
            // 
            // isSendCheckBox
            // 
            this.isSendCheckBox.AutoSize = true;
            this.isSendCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.isSendCheckBox.Location = new System.Drawing.Point(135, 145);
            this.isSendCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.isSendCheckBox.Name = "isSendCheckBox";
            this.isSendCheckBox.Size = new System.Drawing.Size(185, 26);
            this.isSendCheckBox.TabIndex = 15;
            this.isSendCheckBox.Text = "Send Periodically :";
            this.isSendCheckBox.UseVisualStyleBackColor = true;
            this.isSendCheckBox.CheckedChanged += new System.EventHandler(this.isSendCheckBox_CheckedChanged);
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(588, 35);
            this.sendButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(112, 90);
            this.sendButton.TabIndex = 13;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // sendMsgTextBox
            // 
            this.sendMsgTextBox.Location = new System.Drawing.Point(135, 80);
            this.sendMsgTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sendMsgTextBox.Name = "sendMsgTextBox";
            this.sendMsgTextBox.Size = new System.Drawing.Size(445, 26);
            this.sendMsgTextBox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 85);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Send Message";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(494, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "ms";
            // 
            // isSaveFileCheckBox
            // 
            this.isSaveFileCheckBox.AutoSize = true;
            this.isSaveFileCheckBox.Location = new System.Drawing.Point(18, 490);
            this.isSaveFileCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.isSaveFileCheckBox.Name = "isSaveFileCheckBox";
            this.isSaveFileCheckBox.Size = new System.Drawing.Size(104, 24);
            this.isSaveFileCheckBox.TabIndex = 13;
            this.isSaveFileCheckBox.Text = "Save File:";
            this.isSaveFileCheckBox.UseVisualStyleBackColor = true;
            this.isSaveFileCheckBox.CheckedChanged += new System.EventHandler(this.isSaveFileCheckBox_CheckedChanged);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(1078, 352);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(112, 38);
            this.clearButton.TabIndex = 14;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(629, 20);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(560, 312);
            this.listView1.TabIndex = 15;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 592);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.isSaveFileCheckBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.portNumberComboBox);
            this.Controls.Add(this.baudRateComboBox);
            this.Controls.Add(this.openSaveFileDialogButton);
            this.Controls.Add(this.filePathTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.openPortButton);
            this.Controls.Add(this.msgDisplayTextBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "USART Recevier";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox msgDisplayTextBox;
        private System.Windows.Forms.Button openPortButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button openSaveFileDialogButton;
        private System.Windows.Forms.ComboBox baudRateComboBox;
        private System.Windows.Forms.ComboBox portNumberComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox sendMsgTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox isSaveFileCheckBox;
        private System.Windows.Forms.TextBox sendPeriodTextBox;
        private System.Windows.Forms.CheckBox isSendCheckBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox writeTimeOutTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView listView1;
    }
}

