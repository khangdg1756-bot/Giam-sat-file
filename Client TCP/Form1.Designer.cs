namespace Client_TCP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            numPort = new NumericUpDown();
            txtIP = new ComboBox();
            btnConnect = new Button();
            btnDisconnect = new Button();
            lblStatus = new Label();
            txtLog = new RichTextBox();
            btnSend = new Button();
            txtMessage = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtFolder = new TextBox();
            txtFilter = new TextBox();
            label5 = new Label();
            btnClear = new Button();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)numPort).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(338, 151);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 0;
            label1.Text = "Port";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 151);
            label2.Name = "label2";
            label2.Size = new Size(144, 20);
            label2.TabIndex = 1;
            label2.Text = "Connect To IP Server";
            // 
            // numPort
            // 
            numPort.Location = new Point(378, 147);
            numPort.Margin = new Padding(3, 4, 3, 4);
            numPort.Maximum = new decimal(new int[] { 65656, 0, 0, 0 });
            numPort.Name = "numPort";
            numPort.Size = new Size(63, 27);
            numPort.TabIndex = 2;
            numPort.Value = new decimal(new int[] { 9999, 0, 0, 0 });
            // 
            // txtIP
            // 
            txtIP.FormattingEnabled = true;
            txtIP.Location = new Point(183, 147);
            txtIP.Margin = new Padding(3, 4, 3, 4);
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(138, 28);
            txtIP.TabIndex = 3;
            txtIP.Text = "127.0.0.1";
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(483, 133);
            btnConnect.Margin = new Padding(3, 4, 3, 4);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(96, 55);
            btnConnect.TabIndex = 4;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // btnDisconnect
            // 
            btnDisconnect.Location = new Point(603, 132);
            btnDisconnect.Margin = new Padding(3, 4, 3, 4);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new Size(96, 55);
            btnDisconnect.TabIndex = 5;
            btnDisconnect.Text = "Disconnect";
            btnDisconnect.UseVisualStyleBackColor = true;
            btnDisconnect.Click += btnDisconnect_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(45, 199);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(149, 20);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "Waitting Connected...";
            // 
            // txtLog
            // 
            txtLog.Location = new Point(45, 361);
            txtLog.Margin = new Padding(3, 4, 3, 4);
            txtLog.Name = "txtLog";
            txtLog.ReadOnly = true;
            txtLog.Size = new Size(534, 156);
            txtLog.TabIndex = 7;
            txtLog.Text = "";
            // 
            // btnSend
            // 
            btnSend.Location = new Point(483, 529);
            btnSend.Margin = new Padding(3, 4, 3, 4);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(96, 51);
            btnSend.TabIndex = 8;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(128, 541);
            txtMessage.Margin = new Padding(3, 4, 3, 4);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(348, 27);
            txtMessage.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 309);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 10;
            label3.Text = "Folder Following";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 268);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 11;
            label4.Text = "Apply Filter";
            // 
            // txtFolder
            // 
            txtFolder.Location = new Point(159, 305);
            txtFolder.Margin = new Padding(3, 4, 3, 4);
            txtFolder.Name = "txtFolder";
            txtFolder.ReadOnly = true;
            txtFolder.Size = new Size(420, 27);
            txtFolder.TabIndex = 12;
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(159, 264);
            txtFilter.Margin = new Padding(3, 4, 3, 4);
            txtFilter.Name = "txtFilter";
            txtFilter.ReadOnly = true;
            txtFilter.Size = new Size(420, 27);
            txtFilter.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 545);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 14;
            label5.Text = "Text To Box";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(603, 361);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(96, 59);
            btnClear.TabIndex = 15;
            btnClear.Text = "Clear ";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(46, 16);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(182, 105);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(234, 28);
            label6.Name = "label6";
            label6.Size = new Size(479, 67);
            label6.TabIndex = 17;
            label6.Text = "System Monitoring";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 607);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(btnClear);
            Controls.Add(label5);
            Controls.Add(txtFilter);
            Controls.Add(txtFolder);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtMessage);
            Controls.Add(btnSend);
            Controls.Add(txtLog);
            Controls.Add(lblStatus);
            Controls.Add(btnDisconnect);
            Controls.Add(btnConnect);
            Controls.Add(txtIP);
            Controls.Add(numPort);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Client Mode";
            ((System.ComponentModel.ISupportInitialize)numPort).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private NumericUpDown numPort;
        private ComboBox txtIP;
        private Button btnConnect;
        private Button btnDisconnect;
        private Label lblStatus;
        private RichTextBox txtLog;
        private Button btnSend;
        private TextBox txtMessage;
        private Label label3;
        private Label label4;
        private TextBox txtFolder;
        private TextBox txtFilter;
        private Label label5;
        private Button btnClear;
        private PictureBox pictureBox1;
        private Label label6;
    }
}
