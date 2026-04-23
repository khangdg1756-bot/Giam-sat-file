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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            lblMonitor = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)numPort).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(266, 35);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 0;
            label1.Text = "Port";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 35);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 1;
            label2.Text = "Connect To IP Server";
            // 
            // numPort
            // 
            numPort.Location = new Point(301, 32);
            numPort.Maximum = new decimal(new int[] { 65656, 0, 0, 0 });
            numPort.Name = "numPort";
            numPort.Size = new Size(55, 23);
            numPort.TabIndex = 2;
            numPort.Value = new decimal(new int[] { 9999, 0, 0, 0 });
            // 
            // txtIP
            // 
            txtIP.FormattingEnabled = true;
            txtIP.Location = new Point(130, 32);
            txtIP.Name = "txtIP";
            txtIP.Size = new Size(121, 23);
            txtIP.TabIndex = 3;
            txtIP.Text = "127.0.0.1";
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(373, 22);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(84, 41);
            btnConnect.TabIndex = 4;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // btnDisconnect
            // 
            btnDisconnect.Location = new Point(464, 21);
            btnDisconnect.Name = "btnDisconnect";
            btnDisconnect.Size = new Size(84, 41);
            btnDisconnect.TabIndex = 5;
            btnDisconnect.Text = "Disconnect";
            btnDisconnect.UseVisualStyleBackColor = true;
            btnDisconnect.Click += btnDisconnect_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(9, 71);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(160, 15);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "Status: Waitting Connected...\r\n";
            // 
            // txtLog
            // 
            txtLog.Location = new Point(40, 341);
            txtLog.Name = "txtLog";
            txtLog.ReadOnly = true;
            txtLog.Size = new Size(457, 118);
            txtLog.TabIndex = 7;
            txtLog.Text = "";
            // 
            // btnSend
            // 
            btnSend.Location = new Point(523, 425);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(84, 69);
            btnSend.TabIndex = 8;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(112, 471);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(385, 23);
            txtMessage.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 56);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 10;
            label3.Text = "Folder Following";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 25);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 11;
            label4.Text = "Apply Filter";
            // 
            // txtFolder
            // 
            txtFolder.Location = new Point(108, 53);
            txtFolder.Name = "txtFolder";
            txtFolder.ReadOnly = true;
            txtFolder.Size = new Size(440, 23);
            txtFolder.TabIndex = 12;
            // 
            // txtFilter
            // 
            txtFilter.Location = new Point(108, 22);
            txtFilter.Name = "txtFilter";
            txtFilter.ReadOnly = true;
            txtFilter.Size = new Size(440, 23);
            txtFilter.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 474);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 14;
            label5.Text = "Text To Box";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(523, 341);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(84, 69);
            btnClear.TabIndex = 15;
            btnClear.Text = "Clear ";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(40, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(177, 21);
            label6.Name = "label6";
            label6.Size = new Size(411, 59);
            label6.TabIndex = 17;
            label6.Text = "System Monitoring";
            // 
            // lblMonitor
            // 
            lblMonitor.AutoSize = true;
            lblMonitor.Location = new Point(8, 82);
            lblMonitor.Name = "lblMonitor";
            lblMonitor.Size = new Size(120, 15);
            lblMonitor.TabIndex = 18;
            lblMonitor.Text = "Waiting Monitoring...";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnConnect);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(numPort);
            groupBox1.Controls.Add(txtIP);
            groupBox1.Controls.Add(btnDisconnect);
            groupBox1.Controls.Add(lblStatus);
            groupBox1.Location = new Point(40, 97);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(567, 100);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtFilter);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(lblMonitor);
            groupBox2.Controls.Add(txtFolder);
            groupBox2.Location = new Point(40, 203);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(567, 111);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Monitoring Profile";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(40, 317);
            label7.Name = "label7";
            label7.Size = new Size(115, 21);
            label7.TabIndex = 21;
            label7.Text = "Activity History";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 507);
            Controls.Add(label7);
            Controls.Add(btnClear);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(txtMessage);
            Controls.Add(btnSend);
            Controls.Add(txtLog);
            Name = "Form1";
            Text = "Client Mode";
            ((System.ComponentModel.ISupportInitialize)numPort).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
        private Label lblMonitor;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label7;
    }
}
