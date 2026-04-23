namespace Server_TCP
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
            numPort = new NumericUpDown();
            btnStartserver = new Button();
            btnStart = new Button();
            btnStop = new Button();
            rtbLog = new RichTextBox();
            lblStatus = new Label();
            btnStopserver = new Button();
            lblClientInfo = new Label();
            grpSystem = new GroupBox();
            label3 = new Label();
            grpControl = new GroupBox();
            label4 = new Label();
            chkPng = new CheckBox();
            chkJpg = new CheckBox();
            chkExe = new CheckBox();
            chkPdf = new CheckBox();
            btnBrowse = new Button();
            chkDocx = new CheckBox();
            chkTxt = new CheckBox();
            txtFolderPath = new TextBox();
            label2 = new Label();
            btnClearLog = new Button();
            btnExportExcel = new Button();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)numPort).BeginInit();
            grpSystem.SuspendLayout();
            grpControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 36);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 0;
            label1.Text = "Port";
            // 
            // numPort
            // 
            numPort.Location = new Point(81, 34);
            numPort.Maximum = new decimal(new int[] { 5656485, 0, 0, 0 });
            numPort.Name = "numPort";
            numPort.Size = new Size(120, 23);
            numPort.TabIndex = 4;
            numPort.Value = new decimal(new int[] { 9999, 0, 0, 0 });
            // 
            // btnStartserver
            // 
            btnStartserver.Location = new Point(240, 26);
            btnStartserver.Name = "btnStartserver";
            btnStartserver.Size = new Size(106, 45);
            btnStartserver.TabIndex = 5;
            btnStartserver.Text = "Start Server";
            btnStartserver.UseVisualStyleBackColor = true;
            btnStartserver.Click += btnStartserver_Click;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(240, 109);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(106, 45);
            btnStart.TabIndex = 6;
            btnStart.Text = "Start Monitoring";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(386, 109);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(106, 45);
            btnStop.TabIndex = 7;
            btnStop.Text = "Stop Monitoring";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // rtbLog
            // 
            rtbLog.Location = new Point(6, 22);
            rtbLog.Name = "rtbLog";
            rtbLog.ReadOnly = true;
            rtbLog.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtbLog.Size = new Size(531, 163);
            rtbLog.TabIndex = 8;
            rtbLog.Text = "";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(60, 77);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(60, 15);
            lblStatus.TabIndex = 9;
            lblStatus.Text = "Waiting....";
            // 
            // btnStopserver
            // 
            btnStopserver.Location = new Point(386, 26);
            btnStopserver.Name = "btnStopserver";
            btnStopserver.Size = new Size(106, 44);
            btnStopserver.TabIndex = 10;
            btnStopserver.Text = "Stop Server";
            btnStopserver.UseVisualStyleBackColor = true;
            btnStopserver.Click += btnStopserver_Click;
            // 
            // lblClientInfo
            // 
            lblClientInfo.AutoSize = true;
            lblClientInfo.Location = new Point(15, 106);
            lblClientInfo.Name = "lblClientInfo";
            lblClientInfo.Size = new Size(133, 15);
            lblClientInfo.TabIndex = 11;
            lblClientInfo.Text = "Client: Don't have client";
            // 
            // grpSystem
            // 
            grpSystem.Controls.Add(label3);
            grpSystem.Controls.Add(lblClientInfo);
            grpSystem.Controls.Add(label1);
            grpSystem.Controls.Add(numPort);
            grpSystem.Controls.Add(lblStatus);
            grpSystem.Controls.Add(btnStopserver);
            grpSystem.Controls.Add(btnStartserver);
            grpSystem.Location = new Point(35, 106);
            grpSystem.Name = "grpSystem";
            grpSystem.Size = new Size(685, 135);
            grpSystem.TabIndex = 12;
            grpSystem.TabStop = false;
            grpSystem.Text = "Group System";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 77);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 12;
            label3.Text = "Status:";
            // 
            // grpControl
            // 
            grpControl.Controls.Add(label4);
            grpControl.Controls.Add(chkPng);
            grpControl.Controls.Add(chkJpg);
            grpControl.Controls.Add(chkExe);
            grpControl.Controls.Add(btnStop);
            grpControl.Controls.Add(chkPdf);
            grpControl.Controls.Add(btnBrowse);
            grpControl.Controls.Add(btnStart);
            grpControl.Controls.Add(chkDocx);
            grpControl.Controls.Add(chkTxt);
            grpControl.Controls.Add(txtFolderPath);
            grpControl.Controls.Add(label2);
            grpControl.Location = new Point(35, 247);
            grpControl.Name = "grpControl";
            grpControl.Size = new Size(685, 172);
            grpControl.TabIndex = 13;
            grpControl.TabStop = false;
            grpControl.Text = "Group Control";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 28);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 10;
            label4.Text = "File filter:";
            // 
            // chkPng
            // 
            chkPng.AutoSize = true;
            chkPng.Location = new Point(345, 28);
            chkPng.Name = "chkPng";
            chkPng.Size = new Size(50, 19);
            chkPng.TabIndex = 9;
            chkPng.Text = ".png";
            chkPng.UseVisualStyleBackColor = true;
            // 
            // chkJpg
            // 
            chkJpg.AutoSize = true;
            chkJpg.Location = new Point(293, 28);
            chkJpg.Name = "chkJpg";
            chkJpg.Size = new Size(46, 19);
            chkJpg.TabIndex = 8;
            chkJpg.Text = ".jpg";
            chkJpg.UseVisualStyleBackColor = true;
            // 
            // chkExe
            // 
            chkExe.AutoSize = true;
            chkExe.Location = new Point(240, 28);
            chkExe.Name = "chkExe";
            chkExe.Size = new Size(47, 19);
            chkExe.TabIndex = 7;
            chkExe.Text = ".exe";
            chkExe.UseVisualStyleBackColor = true;
            // 
            // chkPdf
            // 
            chkPdf.AutoSize = true;
            chkPdf.Location = new Point(126, 28);
            chkPdf.Name = "chkPdf";
            chkPdf.Size = new Size(47, 19);
            chkPdf.TabIndex = 6;
            chkPdf.Text = ".pdf";
            chkPdf.UseVisualStyleBackColor = true;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(548, 28);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(116, 59);
            btnBrowse.TabIndex = 3;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // chkDocx
            // 
            chkDocx.AutoSize = true;
            chkDocx.Location = new Point(179, 28);
            chkDocx.Name = "chkDocx";
            chkDocx.Size = new Size(55, 19);
            chkDocx.TabIndex = 5;
            chkDocx.Text = ".docx";
            chkDocx.UseVisualStyleBackColor = true;
            // 
            // chkTxt
            // 
            chkTxt.AutoSize = true;
            chkTxt.Location = new Point(77, 28);
            chkTxt.Name = "chkTxt";
            chkTxt.Size = new Size(43, 19);
            chkTxt.TabIndex = 4;
            chkTxt.Text = ".txt";
            chkTxt.UseVisualStyleBackColor = true;
            // 
            // txtFolderPath
            // 
            txtFolderPath.Location = new Point(138, 64);
            txtFolderPath.Name = "txtFolderPath";
            txtFolderPath.ReadOnly = true;
            txtFolderPath.Size = new Size(399, 23);
            txtFolderPath.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 67);
            label2.Name = "label2";
            label2.Size = new Size(117, 15);
            label2.TabIndex = 1;
            label2.Text = "Monitoring directory";
            // 
            // btnClearLog
            // 
            btnClearLog.Location = new Point(558, 108);
            btnClearLog.Name = "btnClearLog";
            btnClearLog.Size = new Size(106, 45);
            btnClearLog.TabIndex = 14;
            btnClearLog.Text = "Clear Log";
            btnClearLog.UseVisualStyleBackColor = true;
            btnClearLog.Click += btnClearLog_Click;
            // 
            // btnExportExcel
            // 
            btnExportExcel.Location = new Point(558, 42);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(106, 45);
            btnExportExcel.TabIndex = 15;
            btnExportExcel.Text = "Export Log";
            btnExportExcel.UseVisualStyleBackColor = true;
            btnExportExcel.Click += btnExportExcel_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(35, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(148, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 32.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(189, 30);
            label6.Name = "label6";
            label6.Size = new Size(578, 59);
            label6.TabIndex = 18;
            label6.Text = "Remote Filesystem Monitor";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rtbLog);
            groupBox1.Controls.Add(btnExportExcel);
            groupBox1.Controls.Add(btnClearLog);
            groupBox1.Location = new Point(35, 425);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(685, 199);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "System Log";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 635);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(grpControl);
            Controls.Add(grpSystem);
            Name = "Form1";
            Text = "Server Mode";
            ((System.ComponentModel.ISupportInitialize)numPort).EndInit();
            grpSystem.ResumeLayout(false);
            grpSystem.PerformLayout();
            grpControl.ResumeLayout(false);
            grpControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown numPort;
        private Button btnStartserver;
        private Button btnStart;
        private Button btnStop;
        private RichTextBox rtbLog;
        private Label lblStatus;
        private Button btnStopserver;
        private Label lblClientInfo;
        private GroupBox grpSystem;
        private GroupBox grpControl;
        private CheckBox chkTxt;
        private Button btnBrowse;
        private TextBox txtFolderPath;
        private Label label2;
        private CheckBox chkPng;
        private CheckBox chkJpg;
        private CheckBox chkExe;
        private CheckBox chkPdf;
        private CheckBox chkDocx;
        private Button btnClearLog;
        private Button btnExportExcel;
        private PictureBox pictureBox1;
        private Label label6;
        private Label label4;
        private GroupBox groupBox1;
        private Label label3;
    }
}
