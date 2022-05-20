namespace MonitorTest
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBoxUid = new System.Windows.Forms.GroupBox();
            this.textBoxUid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.groupBoxApiRoot = new System.Windows.Forms.GroupBox();
            this.textBoxApiRoot = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelEcho = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBoxUid.SuspendLayout();
            this.groupBoxApiRoot.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUid
            // 
            this.groupBoxUid.Controls.Add(this.textBoxUid);
            this.groupBoxUid.Location = new System.Drawing.Point(286, 78);
            this.groupBoxUid.Name = "groupBoxUid";
            this.groupBoxUid.Size = new System.Drawing.Size(100, 49);
            this.groupBoxUid.TabIndex = 18;
            this.groupBoxUid.TabStop = false;
            this.groupBoxUid.Text = "UID";
            // 
            // textBoxUid
            // 
            this.textBoxUid.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxUid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUid.Location = new System.Drawing.Point(18, 19);
            this.textBoxUid.Name = "textBoxUid";
            this.textBoxUid.Size = new System.Drawing.Size(76, 13);
            this.textBoxUid.TabIndex = 0;
            this.textBoxUid.Text = "EXAM0001";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "NET Framework 4.7 Client Test";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(141, 333);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(130, 23);
            this.buttonConnect.TabIndex = 16;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            // 
            // groupBoxApiRoot
            // 
            this.groupBoxApiRoot.Controls.Add(this.textBoxApiRoot);
            this.groupBoxApiRoot.Location = new System.Drawing.Point(28, 78);
            this.groupBoxApiRoot.Name = "groupBoxApiRoot";
            this.groupBoxApiRoot.Size = new System.Drawing.Size(243, 49);
            this.groupBoxApiRoot.TabIndex = 14;
            this.groupBoxApiRoot.TabStop = false;
            this.groupBoxApiRoot.Text = "API ROOT";
            // 
            // textBoxApiRoot
            // 
            this.textBoxApiRoot.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxApiRoot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxApiRoot.Location = new System.Drawing.Point(22, 19);
            this.textBoxApiRoot.Name = "textBoxApiRoot";
            this.textBoxApiRoot.Size = new System.Drawing.Size(205, 13);
            this.textBoxApiRoot.TabIndex = 0;
            this.textBoxApiRoot.Text = "http://localhost:9090/";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxData);
            this.groupBox1.Location = new System.Drawing.Point(28, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 168);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATA";
            // 
            // textBoxData
            // 
            this.textBoxData.BackColor = System.Drawing.Color.White;
            this.textBoxData.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxData.Location = new System.Drawing.Point(22, 32);
            this.textBoxData.Multiline = true;
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.ReadOnly = true;
            this.textBoxData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxData.Size = new System.Drawing.Size(313, 121);
            this.textBoxData.TabIndex = 0;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelEcho});
            this.statusStrip.Location = new System.Drawing.Point(0, 372);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(413, 22);
            this.statusStrip.TabIndex = 20;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabelEcho
            // 
            this.toolStripStatusLabelEcho.Name = "toolStripStatusLabelEcho";
            this.toolStripStatusLabelEcho.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.toolStripStatusLabelEcho.Size = new System.Drawing.Size(6, 17);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 394);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxUid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.groupBoxApiRoot);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Monitor Test";
            this.groupBoxUid.ResumeLayout(false);
            this.groupBoxUid.PerformLayout();
            this.groupBoxApiRoot.ResumeLayout(false);
            this.groupBoxApiRoot.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUid;
        private System.Windows.Forms.TextBox textBoxUid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.GroupBox groupBoxApiRoot;
        private System.Windows.Forms.TextBox textBoxApiRoot;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelEcho;
        private System.Windows.Forms.TextBox textBoxData;
    }
}

