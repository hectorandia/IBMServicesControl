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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowMain));
            this.panelBottom = new MetroFramework.Controls.MetroPanel();
            this.DisableBtn = new MetroFramework.Controls.MetroButton();
            this.EnableBtn = new MetroFramework.Controls.MetroButton();
            this.restartBtn = new MetroFramework.Controls.MetroButton();
            this.stopBtn = new MetroFramework.Controls.MetroButton();
            this.startBtn = new MetroFramework.Controls.MetroButton();
            this.dataGridView1 = new MetroFramework.Controls.MetroGrid();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTop = new MetroFramework.Controls.MetroPanel();
            this.searchBtn = new MetroFramework.Controls.MetroButton();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.pinTextBox = new MetroFramework.Controls.MetroTextBox();
            this.pingBtn = new MetroFramework.Controls.MetroButton();
            this.selectServerTypComBox = new MetroFramework.Controls.MetroComboBox();
            this.selectServTypeLabel = new MetroFramework.Controls.MetroLabel();
            this.selectServiceComBox = new MetroFramework.Controls.MetroComboBox();
            this.selectServiceLabel = new MetroFramework.Controls.MetroLabel();
            this.selectServerComBox = new MetroFramework.Controls.MetroComboBox();
            this.selectServerLabel = new MetroFramework.Controls.MetroLabel();
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
            this.panelBottom.HorizontalScrollbar = true;
            this.panelBottom.HorizontalScrollbarBarColor = true;
            this.panelBottom.HorizontalScrollbarHighlightOnWheel = false;
            this.panelBottom.HorizontalScrollbarSize = 10;
            this.panelBottom.Location = new System.Drawing.Point(15, 761);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1154, 80);
            this.panelBottom.TabIndex = 0;
            this.panelBottom.VerticalScrollbar = true;
            this.panelBottom.VerticalScrollbarBarColor = true;
            this.panelBottom.VerticalScrollbarHighlightOnWheel = false;
            this.panelBottom.VerticalScrollbarSize = 10;
            // 
            // DisableBtn
            // 
            this.DisableBtn.Location = new System.Drawing.Point(1047, 28);
            this.DisableBtn.Name = "DisableBtn";
            this.DisableBtn.Size = new System.Drawing.Size(75, 25);
            this.DisableBtn.TabIndex = 4;
            this.DisableBtn.Text = "Disable";
            this.DisableBtn.UseSelectable = false;
            this.DisableBtn.Click += new System.EventHandler(this.DisableBtn_Click);
            // 
            // EnableBtn
            // 
            this.EnableBtn.Location = new System.Drawing.Point(910, 28);
            this.EnableBtn.Name = "EnableBtn";
            this.EnableBtn.Size = new System.Drawing.Size(75, 25);
            this.EnableBtn.TabIndex = 3;
            this.EnableBtn.Text = "Enable";
            this.EnableBtn.UseSelectable = false;
            this.EnableBtn.Click += new System.EventHandler(this.EnableBtn_Click);
            // 
            // restartBtn
            // 
            this.restartBtn.Location = new System.Drawing.Point(324, 28);
            this.restartBtn.Name = "restartBtn";
            this.restartBtn.Size = new System.Drawing.Size(75, 25);
            this.restartBtn.TabIndex = 2;
            this.restartBtn.Text = "Restart";
            this.restartBtn.UseSelectable = false;
            this.restartBtn.Click += new System.EventHandler(this.restartBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(188, 28);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(75, 25);
            this.stopBtn.TabIndex = 1;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseSelectable = false;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.startBtn.Location = new System.Drawing.Point(53, 28);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 25);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start";
            this.startBtn.UseSelectable = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select,
            this.place,
            this.serverName,
            this.serviceName,
            this.startType,
            this.state});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(15, 223);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1154, 538);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.Theme = MetroFramework.MetroThemeStyle.Light;
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
            this.panelTop.HorizontalScrollbar = true;
            this.panelTop.HorizontalScrollbarBarColor = true;
            this.panelTop.HorizontalScrollbarHighlightOnWheel = false;
            this.panelTop.HorizontalScrollbarSize = 10;
            this.panelTop.Location = new System.Drawing.Point(15, 60);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1154, 163);
            this.panelTop.TabIndex = 2;
            this.panelTop.Theme = MetroFramework.MetroThemeStyle.Light;
            this.panelTop.VerticalScrollbar = true;
            this.panelTop.VerticalScrollbarBarColor = true;
            this.panelTop.VerticalScrollbarHighlightOnWheel = false;
            this.panelTop.VerticalScrollbarSize = 10;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(464, 114);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(85, 25);
            this.searchBtn.TabIndex = 0;
            this.searchBtn.Text = "Search ";
            this.searchBtn.UseSelectable = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(854, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Computer Name or IP : ";
            // 
            // pinTextBox
            // 
            // 
            // 
            // 
            this.pinTextBox.CustomButton.Image = null;
            this.pinTextBox.CustomButton.Location = new System.Drawing.Point(82, 2);
            this.pinTextBox.CustomButton.Name = "";
            this.pinTextBox.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.pinTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.pinTextBox.CustomButton.TabIndex = 1;
            this.pinTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pinTextBox.CustomButton.UseSelectable = true;
            this.pinTextBox.CustomButton.Visible = false;
            this.pinTextBox.Lines = new string[0];
            this.pinTextBox.Location = new System.Drawing.Point(1023, 38);
            this.pinTextBox.MaxLength = 32767;
            this.pinTextBox.Name = "pinTextBox";
            this.pinTextBox.PasswordChar = '\0';
            this.pinTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pinTextBox.SelectedText = "";
            this.pinTextBox.SelectionLength = 0;
            this.pinTextBox.SelectionStart = 0;
            this.pinTextBox.ShortcutsEnabled = true;
            this.pinTextBox.Size = new System.Drawing.Size(100, 20);
            this.pinTextBox.TabIndex = 9;
            this.pinTextBox.UseSelectable = true;
            this.pinTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.pinTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.pinTextBox.TextChanged += new System.EventHandler(this.pinTextBox_TextChanged);
            // 
            // pingBtn
            // 
            this.pingBtn.Location = new System.Drawing.Point(1048, 64);
            this.pingBtn.Name = "pingBtn";
            this.pingBtn.Size = new System.Drawing.Size(75, 23);
            this.pingBtn.TabIndex = 8;
            this.pingBtn.Text = "Ping";
            this.pingBtn.UseSelectable = true;
            this.pingBtn.Click += new System.EventHandler(this.pingBtn_Click);
            // 
            // selectServerTypComBox
            // 
            this.selectServerTypComBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.selectServerTypComBox.FormattingEnabled = true;
            this.selectServerTypComBox.ItemHeight = 23;
            this.selectServerTypComBox.Location = new System.Drawing.Point(174, 37);
            this.selectServerTypComBox.Name = "selectServerTypComBox";
            this.selectServerTypComBox.Size = new System.Drawing.Size(186, 29);
            this.selectServerTypComBox.TabIndex = 5;
            this.selectServerTypComBox.UseSelectable = true;
            this.selectServerTypComBox.SelectedIndexChanged += new System.EventHandler(this.SelectTypComBox_SelectedIndexChanged);
            // 
            // selectServTypeLabel
            // 
            this.selectServTypeLabel.AutoSize = true;
            this.selectServTypeLabel.Location = new System.Drawing.Point(45, 37);
            this.selectServTypeLabel.Name = "selectServTypeLabel";
            this.selectServTypeLabel.Size = new System.Drawing.Size(123, 19);
            this.selectServTypeLabel.TabIndex = 4;
            this.selectServTypeLabel.Text = "Select Server Type :";
            // 
            // selectServiceComBox
            // 
            this.selectServiceComBox.FormattingEnabled = true;
            this.selectServiceComBox.ItemHeight = 23;
            this.selectServiceComBox.Location = new System.Drawing.Point(174, 114);
            this.selectServiceComBox.Name = "selectServiceComBox";
            this.selectServiceComBox.Size = new System.Drawing.Size(235, 29);
            this.selectServiceComBox.TabIndex = 3;
            this.selectServiceComBox.UseSelectable = true;
            this.selectServiceComBox.SelectedIndexChanged += new System.EventHandler(this.selectServiceComBox_SelectedIndexChanged);
            // 
            // selectServiceLabel
            // 
            this.selectServiceLabel.AutoSize = true;
            this.selectServiceLabel.Location = new System.Drawing.Point(45, 114);
            this.selectServiceLabel.Name = "selectServiceLabel";
            this.selectServiceLabel.Size = new System.Drawing.Size(96, 19);
            this.selectServiceLabel.TabIndex = 2;
            this.selectServiceLabel.Text = "Select Service :";
            // 
            // selectServerComBox
            // 
            this.selectServerComBox.FormattingEnabled = true;
            this.selectServerComBox.ItemHeight = 23;
            this.selectServerComBox.Location = new System.Drawing.Point(174, 76);
            this.selectServerComBox.Name = "selectServerComBox";
            this.selectServerComBox.Size = new System.Drawing.Size(186, 29);
            this.selectServerComBox.TabIndex = 1;
            this.selectServerComBox.UseSelectable = true;
            this.selectServerComBox.SelectedIndexChanged += new System.EventHandler(this.selectServerComBox_SelectedIndexChanged);
            // 
            // selectServerLabel
            // 
            this.selectServerLabel.AutoSize = true;
            this.selectServerLabel.Location = new System.Drawing.Point(45, 76);
            this.selectServerLabel.Name = "selectServerLabel";
            this.selectServerLabel.Size = new System.Drawing.Size(92, 19);
            this.selectServerLabel.TabIndex = 0;
            this.selectServerLabel.Text = "Select Server :";
            // 
            // WindowMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 857);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WindowMain";
            this.Padding = new System.Windows.Forms.Padding(15, 60, 15, 16);
            this.Text = "Services Control";
            this.Load += new System.EventHandler(this.WindowMain_Load);
            this.panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panelBottom;
        //private System.Windows.Forms.Panel panelBottom;
        //private System.Windows.Forms.Button restartBtn;
        //private System.Windows.Forms.Button stopBtn;
        //private System.Windows.Forms.Button startBtn;
        private MetroFramework.Controls.MetroButton stopBtn;
        private MetroFramework.Controls.MetroButton restartBtn;
        private MetroFramework.Controls.MetroButton startBtn;
        //private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroGrid dataGridView1;
        //private System.Windows.Forms.Label selectServerLabel;
        private MetroFramework.Controls.MetroLabel selectServerLabel;
        //private System.Windows.Forms.ComboBox selectServerComBox;
        private MetroFramework.Controls.MetroComboBox selectServerComBox;
        //private System.Windows.Forms.Label selectServiceLabel;
        private MetroFramework.Controls.MetroLabel selectServiceLabel;
        //private System.Windows.Forms.ComboBox selectServiceComBox;
        //private System.Windows.Forms.ComboBox selectServerTypComBox;
        private MetroFramework.Controls.MetroComboBox selectServiceComBox;
        private MetroFramework.Controls.MetroComboBox selectServerTypComBox;
        //private System.Windows.Forms.Label selectServTypeLabel;
        private MetroFramework.Controls.MetroLabel selectServTypeLabel;
        //private System.Windows.Forms.Button searchBtn;
        private MetroFramework.Controls.MetroButton searchBtn;
        //private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroLabel label1;
        //private System.Windows.Forms.TextBox pinTextBox;
        private MetroFramework.Controls.MetroTextBox pinTextBox;
        //private System.Windows.Forms.Button pingBtn;
        //private System.Windows.Forms.Button DisableBtn;
        //private System.Windows.Forms.Button EnableBtn;
        private MetroFramework.Controls.MetroButton pingBtn;
        private MetroFramework.Controls.MetroButton DisableBtn;
        private MetroFramework.Controls.MetroButton EnableBtn;
        //private System.Windows.Forms.Panel panelTop;
        private MetroFramework.Controls.MetroPanel panelTop;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn place;
        private System.Windows.Forms.DataGridViewTextBoxColumn serverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn startType;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
    }
}

