namespace DiagServerAccessor
{
    partial class Form1
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
            if (disposing && (components != null))
            {
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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.connectedIndicator = new System.Windows.Forms.RadioButton();
            this.connectButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            this.ipAddrSelector = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.actionSelector = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.deviceSelector = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.deviceIDSelector = new System.Windows.Forms.NumericUpDown();
            this.executeAction = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deviceIDSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
            this.splitContainer2.Panel1.Controls.Add(this.ipAddrSelector);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Size = new System.Drawing.Size(800, 400);
            this.splitContainer2.SplitterDistance = 125;
            this.splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer3.Location = new System.Drawing.Point(0, 34);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.executeAction);
            this.splitContainer3.Panel2.Controls.Add(this.deviceIDSelector);
            this.splitContainer3.Panel2.Controls.Add(this.label5);
            this.splitContainer3.Panel2.Controls.Add(this.deviceSelector);
            this.splitContainer3.Panel2.Controls.Add(this.label4);
            this.splitContainer3.Panel2.Controls.Add(this.actionSelector);
            this.splitContainer3.Panel2.Controls.Add(this.label3);
            this.splitContainer3.Size = new System.Drawing.Size(125, 366);
            this.splitContainer3.SplitterDistance = 55;
            this.splitContainer3.TabIndex = 3;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.connectedIndicator);
            this.splitContainer4.Panel1.Controls.Add(this.connectButton);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.label2);
            this.splitContainer4.Panel2.Controls.Add(this.refreshButton);
            this.splitContainer4.Size = new System.Drawing.Size(125, 55);
            this.splitContainer4.SplitterDistance = 58;
            this.splitContainer4.TabIndex = 3;
            // 
            // connectedIndicator
            // 
            this.connectedIndicator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.connectedIndicator.AutoSize = true;
            this.connectedIndicator.Enabled = false;
            this.connectedIndicator.Location = new System.Drawing.Point(41, 42);
            this.connectedIndicator.Name = "connectedIndicator";
            this.connectedIndicator.Size = new System.Drawing.Size(14, 13);
            this.connectedIndicator.TabIndex = 0;
            this.connectedIndicator.UseVisualStyleBackColor = true;
            // 
            // connectButton
            // 
            this.connectButton.AutoSize = true;
            this.connectButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.connectButton.Location = new System.Drawing.Point(0, 0);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(58, 41);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(0, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Connected";
            // 
            // refreshButton
            // 
            this.refreshButton.AutoSize = true;
            this.refreshButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.refreshButton.Location = new System.Drawing.Point(0, 0);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(63, 41);
            this.refreshButton.TabIndex = 1;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // ipAddrSelector
            // 
            this.ipAddrSelector.Dock = System.Windows.Forms.DockStyle.Top;
            this.ipAddrSelector.FormattingEnabled = true;
            this.ipAddrSelector.Location = new System.Drawing.Point(0, 13);
            this.ipAddrSelector.Name = "ipAddrSelector";
            this.ipAddrSelector.Size = new System.Drawing.Size(125, 21);
            this.ipAddrSelector.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "IP Address Selector";
            // 
            // actionSelector
            // 
            this.actionSelector.Dock = System.Windows.Forms.DockStyle.Top;
            this.actionSelector.FormattingEnabled = true;
            this.actionSelector.Location = new System.Drawing.Point(0, 13);
            this.actionSelector.Name = "actionSelector";
            this.actionSelector.Size = new System.Drawing.Size(125, 21);
            this.actionSelector.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Action";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(0, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Device";
            // 
            // deviceSelector
            // 
            this.deviceSelector.Dock = System.Windows.Forms.DockStyle.Top;
            this.deviceSelector.FormattingEnabled = true;
            this.deviceSelector.Location = new System.Drawing.Point(0, 47);
            this.deviceSelector.Name = "deviceSelector";
            this.deviceSelector.Size = new System.Drawing.Size(125, 21);
            this.deviceSelector.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(0, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Device ID";
            // 
            // deviceIDSelector
            // 
            this.deviceIDSelector.Dock = System.Windows.Forms.DockStyle.Top;
            this.deviceIDSelector.Location = new System.Drawing.Point(0, 81);
            this.deviceIDSelector.Maximum = new decimal(new int[] {
            63,
            0,
            0,
            0});
            this.deviceIDSelector.Name = "deviceIDSelector";
            this.deviceIDSelector.Size = new System.Drawing.Size(125, 20);
            this.deviceIDSelector.TabIndex = 10;
            // 
            // executeAction
            // 
            this.executeAction.Dock = System.Windows.Forms.DockStyle.Top;
            this.executeAction.Location = new System.Drawing.Point(0, 101);
            this.executeAction.Name = "executeAction";
            this.executeAction.Size = new System.Drawing.Size(125, 23);
            this.executeAction.TabIndex = 11;
            this.executeAction.Text = "Send Action";
            this.executeAction.UseVisualStyleBackColor = true;
            this.executeAction.Click += new System.EventHandler(this.executeAction_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.splitContainer2);
            this.Name = "Form1";
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deviceIDSelector)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ComboBox ipAddrSelector;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton connectedIndicator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.ComboBox actionSelector;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox deviceSelector;
        private System.Windows.Forms.NumericUpDown deviceIDSelector;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button executeAction;
    }
}

