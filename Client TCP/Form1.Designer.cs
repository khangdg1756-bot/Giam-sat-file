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
            ((System.ComponentModel.ISupportInitialize)numPort).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 19);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 0;
            label1.Text = "Port";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(256, 19);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 1;
            label2.Text = "Connect To IP Server";
            // 
            // numPort
            // 
            numPort.Location = new Point(121, 17);
            numPort.Maximum = new decimal(new int[] { 65656, 0, 0, 0 });
            numPort.Name = "numPort";
            numPort.Size = new Size(55, 23);
            numPort.TabIndex = 2;
            numPort.Value = new decimal(new int[] { 9999, 0, 0, 0 });
            // 
            // txtIP
            // 
            txtIP.FormattingEnabled = true;
            txtIP.Location = new Point(377, 12);
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(121, 23);
            txtIP.TabIndex = 3;
            txtIP.Text = "127.0.0.1";
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(121, 63);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(75, 23);
            btnConnect.TabIndex = 4;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // btnDisconnect
            // 
            btnDisconnect.Location = new Point(256, 63);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new Size(75, 23);
            btnDisconnect.TabIndex = 5;
            btnDisconnect.Text = "Disconnect";
            btnDisconnect.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(77, 109);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(122, 15);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "Waitting Connected...";
            // 
            // txtLog
            // 
            txtLog.Location = new Point(77, 288);
            txtLog.Name = "txtLog";
            txtLog.ReadOnly = true;
            txtLog.Size = new Size(352, 96);
            txtLog.TabIndex = 7;
            txtLog.Text = "";
            // 
            // btnSend
            // 
            btnSend.Location = new Point(321, 401);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(75, 23);
            btnSend.TabIndex = 8;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(97, 402);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(187, 23);
            txtMessage.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 160);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 10;
            label3.Text = "Folder Following";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(79, 193);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 11;
            label4.Text = "Apply Filter";
            // 
            // txtFolder
            // 
            txtFolder.Location = new Point(188, 157);
            txtFolder.Name = "txtFolder";
            txtFolder.ReadOnly = true;
            txtFolder.Size = new Size(175, 23);
            txtFolder.TabIndex = 12;
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(188, 193);
            txtFilter.Name = "txtFilter";
            txtFilter.ReadOnly = true;
            txtFilter.Size = new Size(175, 23);
            txtFilter.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "Form1";
            Text = "Client Mode";
            ((System.ComponentModel.ISupportInitialize)numPort).EndInit();
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
    }
}
