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
            grpControl = new GroupBox();
            chkPng = new CheckBox();
            chkJpg = new CheckBox();
            chkExe = new CheckBox();
            chkPdf = new CheckBox();
            chkDocx = new CheckBox();
            chkTxt = new CheckBox();
            btnBrowse = new Button();
            txtFolderPath = new TextBox();
            label2 = new Label();
            btnClearLog = new Button();
            btnExportExcel = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)numPort).BeginInit();
            grpSystem.SuspendLayout();
            grpControl.SuspendLayout();
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
            btnStart.Location = new Point(95, 138);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(106, 45);
            btnStart.TabIndex = 6;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(240, 138);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(106, 45);
            btnStop.TabIndex = 7;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // rtbLog
            // 
            rtbLog.Location = new Point(35, 407);
            rtbLog.Name = "rtbLog";
            rtbLog.ReadOnly = true;
            rtbLog.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtbLog.Size = new Size(520, 163);
            rtbLog.TabIndex = 8;
            rtbLog.Text = "";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(15, 76);
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
            lblClientInfo.Location = new Point(15, 118);
            lblClientInfo.Name = "lblClientInfo";
            lblClientInfo.Size = new Size(133, 15);
            lblClientInfo.TabIndex = 11;
            lblClientInfo.Text = "Client: Don't have client";
            // 
            // grpSystem
            // 
            grpSystem.Controls.Add(lblClientInfo);
            grpSystem.Controls.Add(label1);
            grpSystem.Controls.Add(numPort);
            grpSystem.Controls.Add(lblStatus);
            grpSystem.Controls.Add(btnStopserver);
            grpSystem.Controls.Add(btnStartserver);
            grpSystem.Location = new Point(35, 27);
            grpSystem.Name = "grpSystem";
            grpSystem.Size = new Size(520, 146);
            grpSystem.TabIndex = 12;
            grpSystem.TabStop = false;
            grpSystem.Text = "Group System";
            // 
            // grpControl
            // 
            grpControl.Controls.Add(chkPng);
            grpControl.Controls.Add(chkJpg);
            grpControl.Controls.Add(chkExe);
            grpControl.Controls.Add(btnStop);
            grpControl.Controls.Add(chkPdf);
            grpControl.Controls.Add(btnStart);
            grpControl.Controls.Add(btnBrowse);
            grpControl.Controls.Add(chkDocx);
            grpControl.Controls.Add(chkTxt);
            grpControl.Controls.Add(txtFolderPath);
            grpControl.Controls.Add(label2);
            grpControl.Location = new Point(35, 179);
            grpControl.Name = "grpControl";
            grpControl.Size = new Size(520, 200);
            grpControl.TabIndex = 13;
            grpControl.TabStop = false;
            grpControl.Text = "Group Control";
            // 
            // chkPng
            // 
            chkPng.AutoSize = true;
            chkPng.Location = new Point(125, 101);
            chkPng.Name = "chkPng";
            chkPng.Size = new Size(50, 19);
            chkPng.TabIndex = 9;
            chkPng.Text = ".png";
            chkPng.UseVisualStyleBackColor = true;
            // 
            // chkJpg
            // 
            chkJpg.AutoSize = true;
            chkJpg.Location = new Point(64, 101);
            chkJpg.Name = "chkJpg";
            chkJpg.Size = new Size(46, 19);
            chkJpg.TabIndex = 8;
            chkJpg.Text = ".jpg";
            chkJpg.UseVisualStyleBackColor = true;
            // 
            // chkExe
            // 
            chkExe.AutoSize = true;
            chkExe.Location = new Point(15, 101);
            chkExe.Name = "chkExe";
            chkExe.Size = new Size(47, 19);
            chkExe.TabIndex = 7;
            chkExe.Text = ".exe";
            chkExe.UseVisualStyleBackColor = true;
            // 
            // chkPdf
            // 
            chkPdf.AutoSize = true;
            chkPdf.Location = new Point(125, 76);
            chkPdf.Name = "chkPdf";
            chkPdf.Size = new Size(47, 19);
            chkPdf.TabIndex = 6;
            chkPdf.Text = ".pdf";
            chkPdf.UseVisualStyleBackColor = true;
            // 
            // chkDocx
            // 
            chkDocx.AutoSize = true;
            chkDocx.Location = new Point(64, 76);
            chkDocx.Name = "chkDocx";
            chkDocx.Size = new Size(55, 19);
            chkDocx.TabIndex = 5;
            chkDocx.Text = ".docx";
            chkDocx.UseVisualStyleBackColor = true;
            // 
            // chkTxt
            // 
            chkTxt.AutoSize = true;
            chkTxt.Location = new Point(15, 76);
            chkTxt.Name = "chkTxt";
            chkTxt.Size = new Size(43, 19);
            chkTxt.TabIndex = 4;
            chkTxt.Text = ".txt";
            chkTxt.UseVisualStyleBackColor = true;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(240, 21);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(106, 45);
            btnBrowse.TabIndex = 3;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // txtFolderPath
            // 
            txtFolderPath.Location = new Point(81, 33);
            txtFolderPath.Name = "txtFolderPath";
            txtFolderPath.ReadOnly = true;
            txtFolderPath.Size = new Size(120, 23);
            txtFolderPath.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 36);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 1;
            label2.Text = "Folder:";
            // 
            // btnClearLog
            // 
            btnClearLog.Location = new Point(583, 422);
            btnClearLog.Name = "btnClearLog";
            btnClearLog.Size = new Size(106, 45);
            btnClearLog.TabIndex = 14;
            btnClearLog.Text = "Clear Log";
            btnClearLog.UseVisualStyleBackColor = true;
            btnClearLog.Click += btnClearLog_Click;
            // 
            // btnExportExcel
            // 
            btnExportExcel.Location = new Point(583, 487);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(106, 45);
            btnExportExcel.TabIndex = 15;
            btnExportExcel.Text = "Export Log";
            btnExportExcel.UseVisualStyleBackColor = true;
            btnExportExcel.Click += btnExportExcel_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 389);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 16;
            label3.Text = "System Log";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 661);
            Controls.Add(label3);
            Controls.Add(btnExportExcel);
            Controls.Add(btnClearLog);
            Controls.Add(grpControl);
            Controls.Add(grpSystem);
            Controls.Add(rtbLog);
            Name = "Form1";
            Text = "Server Mode";
            ((System.ComponentModel.ISupportInitialize)numPort).EndInit();
            grpSystem.ResumeLayout(false);
            grpSystem.PerformLayout();
            grpControl.ResumeLayout(false);
            grpControl.PerformLayout();
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
        private Label label3;
    }
}
