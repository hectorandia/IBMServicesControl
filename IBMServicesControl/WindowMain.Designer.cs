namespace IBMServicesControl
{
    partial class WindowMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowMain));
            this.panelBottom = new System.Windows.Forms.Panel();
            this.DisableBtn = new System.Windows.Forms.Button();
            this.EnableBtn = new System.Windows.Forms.Button();
            this.restartBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelTop = new System.Windows.Forms.Panel();
            this.searchBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pinTextBox = new System.Windows.Forms.TextBox();
            this.pingBtn = new System.Windows.Forms.Button();
            this.selectServerTypComBox = new System.Windows.Forms.ComboBox();
            this.selectServTypeLabel = new System.Windows.Forms.Label();
            this.selectServiceComBox = new System.Windows.Forms.ComboBox();
            this.selectServiceLabel = new System.Windows.Forms.Label();
            this.selectServerComBox = new System.Windows.Forms.ComboBox();
            this.selectServerLabel = new System.Windows.Forms.Label();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBottom
            // 
            this.panelBottom.AutoScroll = true;
            this.panelBottom.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelBottom.Controls.Add(this.DisableBtn);
            this.panelBottom.Controls.Add(this.EnableBtn);
            this.panelBottom.Controls.Add(this.restartBtn);
            this.panelBottom.Controls.Add(this.stopBtn);
            this.panelBottom.Controls.Add(this.startBtn);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 957);
            this.panelBottom.Margin = new System.Windows.Forms.Padding(4);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1579, 98);
            this.panelBottom.TabIndex = 0;
            // 
            // DisableBtn
            // 
            this.DisableBtn.Location = new System.Drawing.Point(1396, 34);
            this.DisableBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DisableBtn.Name = "DisableBtn";
            this.DisableBtn.Size = new System.Drawing.Size(100, 31);
            this.DisableBtn.TabIndex = 4;
            this.DisableBtn.Text = "Disable";
            this.DisableBtn.UseVisualStyleBackColor = true;
            this.DisableBtn.Click += new System.EventHandler(this.DisableBtn_Click);
            // 
            // EnableBtn
            // 
            this.EnableBtn.Location = new System.Drawing.Point(1213, 34);
            this.EnableBtn.Margin = new System.Windows.Forms.Padding(4);
            this.EnableBtn.Name = "EnableBtn";
            this.EnableBtn.Size = new System.Drawing.Size(100, 31);
            this.EnableBtn.TabIndex = 3;
            this.EnableBtn.Text = "Enable";
            this.EnableBtn.UseVisualStyleBackColor = true;
            this.EnableBtn.Click += new System.EventHandler(this.EnableBtn_Click);
            // 
            // restartBtn
            // 
            this.restartBtn.Location = new System.Drawing.Point(432, 34);
            this.restartBtn.Margin = new System.Windows.Forms.Padding(4);
            this.restartBtn.Name = "restartBtn";
            this.restartBtn.Size = new System.Drawing.Size(100, 31);
            this.restartBtn.TabIndex = 2;
            this.restartBtn.Text = "Restart";
            this.restartBtn.UseVisualStyleBackColor = true;
            this.restartBtn.Click += new System.EventHandler(this.restartBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(251, 34);
            this.stopBtn.Margin = new System.Windows.Forms.Padding(4);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(100, 31);
            this.stopBtn.TabIndex = 1;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(71, 34);
            this.startBtn.Margin = new System.Windows.Forms.Padding(4);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(100, 31);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.place,
            this.serverName,
            this.serviceName,
            this.startType,
            this.state});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(0, 201);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(1579, 756);
            this.dataGridView1.TabIndex = 1;
            // 
            // panelTop
            // 
            this.panelTop.AutoScroll = true;
            this.panelTop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelTop.BackColor = System.Drawing.SystemColors.Control;
            this.panelTop.Controls.Add(this.searchBtn);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.pinTextBox);
            this.panelTop.Controls.Add(this.pingBtn);
            this.panelTop.Controls.Add(this.selectServerTypComBox);
            this.panelTop.Controls.Add(this.selectServTypeLabel);
            this.panelTop.Controls.Add(this.selectServiceComBox);
            this.panelTop.Controls.Add(this.selectServiceLabel);
            this.panelTop.Controls.Add(this.selectServerComBox);
            this.panelTop.Controls.Add(this.selectServerLabel);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1579, 201);
            this.panelTop.TabIndex = 2;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(619, 124);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(4);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(113, 31);
            this.searchBtn.TabIndex = 11;
            this.searchBtn.Text = "Search ";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1204, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Computer Name or IP : ";
            // 
            // pinTextBox
            // 
            this.pinTextBox.Location = new System.Drawing.Point(1364, 47);
            this.pinTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.pinTextBox.Name = "pinTextBox";
            this.pinTextBox.Size = new System.Drawing.Size(132, 22);
            this.pinTextBox.TabIndex = 9;
            this.pinTextBox.TextChanged += new System.EventHandler(this.pinTextBox_TextChanged);
            // 
            // pingBtn
            // 
            this.pingBtn.Location = new System.Drawing.Point(1397, 79);
            this.pingBtn.Margin = new System.Windows.Forms.Padding(4);
            this.pingBtn.Name = "pingBtn";
            this.pingBtn.Size = new System.Drawing.Size(100, 28);
            this.pingBtn.TabIndex = 8;
            this.pingBtn.Text = "Ping";
            this.pingBtn.UseVisualStyleBackColor = true;
            this.pingBtn.Click += new System.EventHandler(this.pingBtn_Click);
            // 
            // selectServerTypComBox
            // 
            this.selectServerTypComBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.selectServerTypComBox.FormattingEnabled = true;
            this.selectServerTypComBox.Location = new System.Drawing.Point(207, 49);
            this.selectServerTypComBox.Margin = new System.Windows.Forms.Padding(4);
            this.selectServerTypComBox.Name = "selectServerTypComBox";
            this.selectServerTypComBox.Size = new System.Drawing.Size(160, 24);
            this.selectServerTypComBox.TabIndex = 5;
            this.selectServerTypComBox.SelectedIndexChanged += new System.EventHandler(this.SelectTypComBox_SelectedIndexChanged);
            // 
            // selectServTypeLabel
            // 
            this.selectServTypeLabel.AutoSize = true;
            this.selectServTypeLabel.Location = new System.Drawing.Point(60, 49);
            this.selectServTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectServTypeLabel.Name = "selectServTypeLabel";
            this.selectServTypeLabel.Size = new System.Drawing.Size(137, 17);
            this.selectServTypeLabel.TabIndex = 4;
            this.selectServTypeLabel.Text = "Select Server Type :";
            // 
            // selectServiceComBox
            // 
            this.selectServiceComBox.FormattingEnabled = true;
            this.selectServiceComBox.Location = new System.Drawing.Point(207, 128);
            this.selectServiceComBox.Margin = new System.Windows.Forms.Padding(4);
            this.selectServiceComBox.Name = "selectServiceComBox";
            this.selectServiceComBox.Size = new System.Drawing.Size(312, 24);
            this.selectServiceComBox.TabIndex = 3;
            this.selectServiceComBox.SelectedIndexChanged += new System.EventHandler(this.selectServiceComBox_SelectedIndexChanged);
            // 
            // selectServiceLabel
            // 
            this.selectServiceLabel.AutoSize = true;
            this.selectServiceLabel.Location = new System.Drawing.Point(60, 132);
            this.selectServiceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectServiceLabel.Name = "selectServiceLabel";
            this.selectServiceLabel.Size = new System.Drawing.Size(106, 17);
            this.selectServiceLabel.TabIndex = 2;
            this.selectServiceLabel.Text = "Select Service :";
            // 
            // selectServerComBox
            // 
            this.selectServerComBox.FormattingEnabled = true;
            this.selectServerComBox.Location = new System.Drawing.Point(207, 87);
            this.selectServerComBox.Margin = new System.Windows.Forms.Padding(4);
            this.selectServerComBox.Name = "selectServerComBox";
            this.selectServerComBox.Size = new System.Drawing.Size(160, 24);
            this.selectServerComBox.TabIndex = 1;
            this.selectServerComBox.SelectedIndexChanged += new System.EventHandler(this.selectServerComBox_SelectedIndexChanged);
            // 
            // selectServerLabel
            // 
            this.selectServerLabel.AutoSize = true;
            this.selectServerLabel.Location = new System.Drawing.Point(60, 91);
            this.selectServerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectServerLabel.Name = "selectServerLabel";
            this.selectServerLabel.Size = new System.Drawing.Size(101, 17);
            this.selectServerLabel.TabIndex = 0;
            this.selectServerLabel.Text = "Select Server :";
            // 
            // Select
            // 
            this.Select.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Select.FalseValue = "false";
            this.Select.HeaderText = "Select";
            this.Select.Name = "Select";
            this.Select.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Select.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Select.TrueValue = "true";
            this.Select.Width = 50;
            // 
            // place
            // 
            this.place.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.place.FillWeight = 340.1361F;
            this.place.HeaderText = "Place";
            this.place.Name = "place";
            this.place.ReadOnly = true;
            // 
            // serverName
            // 
            this.serverName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.serverName.FillWeight = 17.0068F;
            this.serverName.HeaderText = "Server Name";
            this.serverName.Name = "serverName";
            this.serverName.ReadOnly = true;
            // 
            // serviceName
            // 
            this.serviceName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.serviceName.FillWeight = 17.0068F;
            this.serviceName.HeaderText = "Service Name";
            this.serviceName.Name = "serviceName";
            this.serviceName.ReadOnly = true;
            // 
            // startType
            // 
            this.startType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.startType.FillWeight = 17.0068F;
            this.startType.HeaderText = "Start Type";
            this.startType.Name = "startType";
            this.startType.ReadOnly = true;
            // 
            // state
            // 
            this.state.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.state.FillWeight = 108.8435F;
            this.state.HeaderText = "State";
            this.state.Name = "state";
            this.state.ReadOnly = true;
            this.state.Width = 150;
            // 
            // WindowMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1579, 1055);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WindowMain";
            this.Text = "ServicesControl";
            this.Load += new System.EventHandler(this.WindowMain_Load);
            this.panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button restartBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label selectServerLabel;
        private System.Windows.Forms.ComboBox selectServerComBox;
        private System.Windows.Forms.Label selectServiceLabel;
        private System.Windows.Forms.ComboBox selectServiceComBox;
        private System.Windows.Forms.ComboBox selectServerTypComBox;
        private System.Windows.Forms.Label selectServTypeLabel;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pinTextBox;
        private System.Windows.Forms.Button pingBtn;
        private System.Windows.Forms.Button DisableBtn;
        private System.Windows.Forms.Button EnableBtn;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn place;
        private System.Windows.Forms.DataGridViewTextBoxColumn serverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn startType;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
    }
}

