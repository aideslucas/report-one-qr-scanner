namespace Camera_Viewer_Connect_USB_WF
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.connectBt = new System.Windows.Forms.Button();
            this.disconnectBt = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.liveViewer = new Ozeki.Media.VideoViewerWF();
            this.txtDecodedData = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectBt
            // 
            this.connectBt.Location = new System.Drawing.Point(12, 9);
            this.connectBt.Name = "connectBt";
            this.connectBt.Size = new System.Drawing.Size(131, 23);
            this.connectBt.TabIndex = 0;
            this.connectBt.Text = "Connect to web camera";
            this.connectBt.UseVisualStyleBackColor = true;
            this.connectBt.Click += new System.EventHandler(this.connectBt_Click);
            // 
            // disconnectBt
            // 
            this.disconnectBt.Enabled = false;
            this.disconnectBt.Location = new System.Drawing.Point(261, 9);
            this.disconnectBt.Name = "disconnectBt";
            this.disconnectBt.Size = new System.Drawing.Size(169, 23);
            this.disconnectBt.TabIndex = 2;
            this.disconnectBt.Text = "Disconnect from web camera";
            this.disconnectBt.UseVisualStyleBackColor = true;
            this.disconnectBt.Click += new System.EventHandler(this.disconnectBt_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.liveViewer);
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 428);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Live";
            // 
            // liveViewer
            // 
            this.liveViewer.BackColor = System.Drawing.Color.Black;
            this.liveViewer.ContextMenuEnabled = true;
            this.liveViewer.FlipMode = Ozeki.Media.FlipMode.None;
            this.liveViewer.FrameStretch = Ozeki.Media.FrameStretch.Uniform;
            this.liveViewer.FullScreenEnabled = true;
            this.liveViewer.Location = new System.Drawing.Point(6, 19);
            this.liveViewer.Name = "liveViewer";
            this.liveViewer.RotateAngle = 0;
            this.liveViewer.Size = new System.Drawing.Size(412, 403);
            this.liveViewer.TabIndex = 0;
            this.liveViewer.Text = "liveViewer";
            // 
            // txtDecodedData
            // 
            this.txtDecodedData.Location = new System.Drawing.Point(12, 476);
            this.txtDecodedData.Multiline = true;
            this.txtDecodedData.Name = "txtDecodedData";
            this.txtDecodedData.Size = new System.Drawing.Size(424, 108);
            this.txtDecodedData.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(445, 596);
            this.Controls.Add(this.txtDecodedData);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.disconnectBt);
            this.Controls.Add(this.connectBt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frame capture";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectBt;
        private System.Windows.Forms.Button disconnectBt;
        private System.Windows.Forms.GroupBox groupBox1;
        private Ozeki.Media.VideoViewerWF liveViewer;
        private System.Windows.Forms.TextBox txtDecodedData;
    }
}