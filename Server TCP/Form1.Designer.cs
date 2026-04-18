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
            ((System.ComponentModel.ISupportInitialize)numPort).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 79);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 0;
            label1.Text = "Port";
            // 
            // numPort
            // 
            numPort.Location = new Point(229, 77);
            numPort.Maximum = new decimal(new int[] { 5656485, 0, 0, 0 });
            numPort.Name = "numPort";
            numPort.Size = new Size(120, 23);
            numPort.TabIndex = 4;
            numPort.Value = new decimal(new int[] { 9999, 0, 0, 0 });
            // 
            // btnStartserver
            // 
            btnStartserver.Location = new Point(501, 77);
            btnStartserver.Name = "btnStartserver";
            btnStartserver.Size = new Size(75, 23);
            btnStartserver.TabIndex = 5;
            btnStartserver.Text = "Start Server";
            btnStartserver.UseVisualStyleBackColor = true;
            btnStartserver.Click += btnStartserver_Click;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(132, 175);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 6;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(406, 175);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(75, 23);
            btnStop.TabIndex = 7;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            // 
            // rtbLog
            // 
            rtbLog.Location = new Point(77, 265);
            rtbLog.Name = "rtbLog";
            rtbLog.ReadOnly = true;
            rtbLog.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtbLog.Size = new Size(499, 163);
            rtbLog.TabIndex = 8;
            rtbLog.Text = "";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(77, 225);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(60, 15);
            lblStatus.TabIndex = 9;
            lblStatus.Text = "Waiting....";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblStatus);
            Controls.Add(rtbLog);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(btnStartserver);
            Controls.Add(numPort);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numPort).EndInit();
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
    }
}
