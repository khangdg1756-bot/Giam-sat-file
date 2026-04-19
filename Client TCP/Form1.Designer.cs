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
            label2.Location = new Point(281, 26);
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
            txtIP.Location = new Point(423, 25);
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(121, 23);
            txtIP.TabIndex = 3;
            txtIP.Text = "127.0.0.1";
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(163, 80);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(75, 23);
            btnConnect.TabIndex = 4;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // btnDisconnect
            // 
            btnDisconnect.Location = new Point(281, 80);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new Size(75, 23);
            btnDisconnect.TabIndex = 5;
            btnDisconnect.Text = "Disconnect";
            btnDisconnect.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(77, 133);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(122, 15);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "Waitting Connected...";
            // 
            // txtLog
            // 
            txtLog.Location = new Point(77, 172);
            txtLog.Name = "txtLog";
            txtLog.ReadOnly = true;
            txtLog.Size = new Size(352, 96);
            txtLog.TabIndex = 7;
            txtLog.Text = "";
            // 
            // btnSend
            // 
            btnSend.Location = new Point(347, 335);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(75, 23);
            btnSend.TabIndex = 8;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(140, 335);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(187, 23);
            txtMessage.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
