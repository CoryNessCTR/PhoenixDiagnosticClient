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
            this.deviceSpecificControls = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.blinkButton = new System.Windows.Forms.Button();
            this.selftTestButton = new System.Windows.Forms.Button();
            this.ipAddrSelector = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.deviceView = new System.Windows.Forms.ListView();
            this.deviceName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hardwareName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deviceID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.firmwareVers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.manDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bootRev = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.softStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitContainer6 = new System.Windows.Forms.SplitContainer();
            this.nameChanger = new System.Windows.Forms.TextBox();
            this.nameChangeButton = new System.Windows.Forms.Button();
            this.splitContainer7 = new System.Windows.Forms.SplitContainer();
            this.idChanger = new System.Windows.Forms.NumericUpDown();
            this.idChangeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.deviceSpecificControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).BeginInit();
            this.splitContainer6.Panel1.SuspendLayout();
            this.splitContainer6.Panel2.SuspendLayout();
            this.splitContainer6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).BeginInit();
            this.splitContainer7.Panel1.SuspendLayout();
            this.splitContainer7.Panel2.SuspendLayout();
            this.splitContainer7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.idChanger)).BeginInit();
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
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
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
            this.splitContainer3.Panel2.Controls.Add(this.deviceSpecificControls);
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
            this.splitContainer4.SplitterDistance = 56;
            this.splitContainer4.TabIndex = 3;
            // 
            // connectedIndicator
            // 
            this.connectedIndicator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.connectedIndicator.AutoSize = true;
            this.connectedIndicator.Enabled = false;
            this.connectedIndicator.Location = new System.Drawing.Point(39, 42);
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
            this.connectButton.Size = new System.Drawing.Size(56, 41);
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
            this.refreshButton.Size = new System.Drawing.Size(65, 41);
            this.refreshButton.TabIndex = 1;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // deviceSpecificControls
            // 
            this.deviceSpecificControls.ColumnCount = 1;
            this.deviceSpecificControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.deviceSpecificControls.Controls.Add(this.splitContainer5, 0, 0);
            this.deviceSpecificControls.Controls.Add(this.splitContainer6, 0, 2);
            this.deviceSpecificControls.Controls.Add(this.splitContainer7, 0, 4);
            this.deviceSpecificControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deviceSpecificControls.Location = new System.Drawing.Point(0, 0);
            this.deviceSpecificControls.Name = "deviceSpecificControls";
            this.deviceSpecificControls.RowCount = 7;
            this.deviceSpecificControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.17885F));
            this.deviceSpecificControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.761533F));
            this.deviceSpecificControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.17885F));
            this.deviceSpecificControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.761533F));
            this.deviceSpecificControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.17885F));
            this.deviceSpecificControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.761533F));
            this.deviceSpecificControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.17885F));
            this.deviceSpecificControls.Size = new System.Drawing.Size(125, 307);
            this.deviceSpecificControls.TabIndex = 0;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(3, 3);
            this.splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.blinkButton);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.selftTestButton);
            this.splitContainer5.Size = new System.Drawing.Size(119, 62);
            this.splitContainer5.SplitterDistance = 52;
            this.splitContainer5.TabIndex = 0;
            // 
            // blinkButton
            // 
            this.blinkButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blinkButton.Location = new System.Drawing.Point(0, 0);
            this.blinkButton.Name = "blinkButton";
            this.blinkButton.Size = new System.Drawing.Size(52, 62);
            this.blinkButton.TabIndex = 0;
            this.blinkButton.Text = "Blink";
            this.blinkButton.UseVisualStyleBackColor = true;
            this.blinkButton.Click += new System.EventHandler(this.blinkButton_Click);
            // 
            // selftTestButton
            // 
            this.selftTestButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selftTestButton.Location = new System.Drawing.Point(0, 0);
            this.selftTestButton.Name = "selftTestButton";
            this.selftTestButton.Size = new System.Drawing.Size(63, 62);
            this.selftTestButton.TabIndex = 0;
            this.selftTestButton.Text = "Self Test";
            this.selftTestButton.UseVisualStyleBackColor = true;
            // 
            // ipAddrSelector
            // 
            this.ipAddrSelector.Dock = System.Windows.Forms.DockStyle.Top;
            this.ipAddrSelector.FormattingEnabled = true;
            this.ipAddrSelector.Location = new System.Drawing.Point(0, 13);
            this.ipAddrSelector.Name = "ipAddrSelector";
            this.ipAddrSelector.Size = new System.Drawing.Size(125, 21);
            this.ipAddrSelector.TabIndex = 0;
            this.ipAddrSelector.TextUpdate += new System.EventHandler(this.ipAddrSelector_TextChanged);
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
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.deviceView);
            this.splitContainer1.Size = new System.Drawing.Size(671, 400);
            this.splitContainer1.SplitterDistance = 138;
            this.splitContainer1.TabIndex = 0;
            // 
            // deviceView
            // 
            this.deviceView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.deviceName,
            this.hardwareName,
            this.deviceID,
            this.firmwareVers,
            this.manDate,
            this.bootRev,
            this.softStatus});
            this.deviceView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deviceView.FullRowSelect = true;
            this.deviceView.GridLines = true;
            this.deviceView.Location = new System.Drawing.Point(0, 0);
            this.deviceView.Name = "deviceView";
            this.deviceView.Size = new System.Drawing.Size(671, 138);
            this.deviceView.TabIndex = 0;
            this.deviceView.UseCompatibleStateImageBehavior = false;
            this.deviceView.View = System.Windows.Forms.View.Details;
            this.deviceView.SelectedIndexChanged += new System.EventHandler(this.deviceView_SelectedIndexChanged);
            // 
            // deviceName
            // 
            this.deviceName.Text = "Device Name";
            this.deviceName.Width = 100;
            // 
            // hardwareName
            // 
            this.hardwareName.Text = "Hardware";
            this.hardwareName.Width = 150;
            // 
            // deviceID
            // 
            this.deviceID.Text = "ID";
            this.deviceID.Width = 40;
            // 
            // firmwareVers
            // 
            this.firmwareVers.Text = "Firmware Version";
            this.firmwareVers.Width = 100;
            // 
            // manDate
            // 
            this.manDate.Text = "Manufacturer Date";
            this.manDate.Width = 134;
            // 
            // bootRev
            // 
            this.bootRev.Text = "Bootloader Revision";
            this.bootRev.Width = 117;
            // 
            // softStatus
            // 
            this.softStatus.Text = "Software Status";
            this.softStatus.Width = 111;
            // 
            // splitContainer6
            // 
            this.splitContainer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer6.Location = new System.Drawing.Point(3, 82);
            this.splitContainer6.Name = "splitContainer6";
            this.splitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer6.Panel1
            // 
            this.splitContainer6.Panel1.Controls.Add(this.nameChanger);
            // 
            // splitContainer6.Panel2
            // 
            this.splitContainer6.Panel2.Controls.Add(this.nameChangeButton);
            this.splitContainer6.Size = new System.Drawing.Size(119, 62);
            this.splitContainer6.SplitterDistance = 25;
            this.splitContainer6.TabIndex = 1;
            // 
            // nameChanger
            // 
            this.nameChanger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameChanger.Location = new System.Drawing.Point(0, 0);
            this.nameChanger.Name = "nameChanger";
            this.nameChanger.Size = new System.Drawing.Size(119, 20);
            this.nameChanger.TabIndex = 0;
            // 
            // nameChangeButton
            // 
            this.nameChangeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameChangeButton.Location = new System.Drawing.Point(0, 0);
            this.nameChangeButton.Name = "nameChangeButton";
            this.nameChangeButton.Size = new System.Drawing.Size(119, 33);
            this.nameChangeButton.TabIndex = 0;
            this.nameChangeButton.Text = "Change Name";
            this.nameChangeButton.UseVisualStyleBackColor = true;
            this.nameChangeButton.Click += new System.EventHandler(this.nameChangeButton_Click);
            // 
            // splitContainer7
            // 
            this.splitContainer7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer7.Location = new System.Drawing.Point(3, 161);
            this.splitContainer7.Name = "splitContainer7";
            this.splitContainer7.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer7.Panel1
            // 
            this.splitContainer7.Panel1.Controls.Add(this.idChanger);
            // 
            // splitContainer7.Panel2
            // 
            this.splitContainer7.Panel2.Controls.Add(this.idChangeButton);
            this.splitContainer7.Size = new System.Drawing.Size(119, 62);
            this.splitContainer7.SplitterDistance = 25;
            this.splitContainer7.TabIndex = 2;
            // 
            // idChanger
            // 
            this.idChanger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.idChanger.Location = new System.Drawing.Point(0, 0);
            this.idChanger.Maximum = new decimal(new int[] {
            63,
            0,
            0,
            0});
            this.idChanger.Name = "idChanger";
            this.idChanger.Size = new System.Drawing.Size(119, 20);
            this.idChanger.TabIndex = 0;
            // 
            // idChangeButton
            // 
            this.idChangeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.idChangeButton.Location = new System.Drawing.Point(0, 0);
            this.idChangeButton.Name = "idChangeButton";
            this.idChangeButton.Size = new System.Drawing.Size(119, 33);
            this.idChangeButton.TabIndex = 0;
            this.idChangeButton.Text = "Change ID";
            this.idChangeButton.UseVisualStyleBackColor = true;
            this.idChangeButton.Click += new System.EventHandler(this.idChangeButton_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.splitContainer2);
            this.Name = "Form1";
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.deviceSpecificControls.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer6.Panel1.ResumeLayout(false);
            this.splitContainer6.Panel1.PerformLayout();
            this.splitContainer6.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer6)).EndInit();
            this.splitContainer6.ResumeLayout(false);
            this.splitContainer7.Panel1.ResumeLayout(false);
            this.splitContainer7.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).EndInit();
            this.splitContainer7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.idChanger)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ComboBox ipAddrSelector;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton connectedIndicator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView deviceView;
        private System.Windows.Forms.ColumnHeader deviceName;
        private System.Windows.Forms.ColumnHeader hardwareName;
        private System.Windows.Forms.ColumnHeader deviceID;
        private System.Windows.Forms.ColumnHeader firmwareVers;
        private System.Windows.Forms.ColumnHeader manDate;
        private System.Windows.Forms.ColumnHeader bootRev;
        private System.Windows.Forms.ColumnHeader softStatus;
        private System.Windows.Forms.TableLayoutPanel deviceSpecificControls;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.Button blinkButton;
        private System.Windows.Forms.Button selftTestButton;
        private System.Windows.Forms.SplitContainer splitContainer6;
        private System.Windows.Forms.TextBox nameChanger;
        private System.Windows.Forms.Button nameChangeButton;
        private System.Windows.Forms.SplitContainer splitContainer7;
        private System.Windows.Forms.NumericUpDown idChanger;
        private System.Windows.Forms.Button idChangeButton;
    }
}

