namespace Flight_Schedule_Viewer
{
    partial class mainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbViewMode = new System.Windows.Forms.GroupBox();
            this.lbSystemLogs = new System.Windows.Forms.Label();
            this.lstSystemLog1 = new System.Windows.Forms.ListBox();
            this.btReqData = new System.Windows.Forms.Button();
            this.gridFlightViewer = new System.Windows.Forms.DataGridView();
            this.lbTimeDisplay = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.btConnectStatus = new System.Windows.Forms.Button();
            this.btConnect = new System.Windows.Forms.Button();
            this.lbDateDisplay = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbFlightScheduleHidden = new System.Windows.Forms.Label();
            this.lbAirlineOperatedHidden = new System.Windows.Forms.Label();
            this.lbFlightSchedule = new System.Windows.Forms.Label();
            this.lbAirlinesOperated = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbSearchBox = new System.Windows.Forms.GroupBox();
            this.lbsyslog = new System.Windows.Forms.Label();
            this.lstSystemLog = new System.Windows.Forms.ListBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.lbSearchMode = new System.Windows.Forms.Label();
            this.lbSearch = new System.Windows.Forms.Label();
            this.rbAirlinesOperated = new System.Windows.Forms.RadioButton();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.rbFlightSchedule = new System.Windows.Forms.RadioButton();
            this.btDisconnect = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.tabPage1.SuspendLayout();
            this.gbViewMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFlightViewer)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbSearchBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tabPage1.Controls.Add(this.gbViewMode);
            this.tabPage1.Controls.Add(this.gridFlightViewer);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1241, 575);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Flight Schedule Viewer";
            // 
            // gbViewMode
            // 
            this.gbViewMode.Controls.Add(this.lbSystemLogs);
            this.gbViewMode.Controls.Add(this.lstSystemLog1);
            this.gbViewMode.Controls.Add(this.btReqData);
            this.gbViewMode.Location = new System.Drawing.Point(6, 432);
            this.gbViewMode.Name = "gbViewMode";
            this.gbViewMode.Size = new System.Drawing.Size(1229, 137);
            this.gbViewMode.TabIndex = 17;
            this.gbViewMode.TabStop = false;
            this.gbViewMode.Text = "ViewMode";
            // 
            // lbSystemLogs
            // 
            this.lbSystemLogs.AutoSize = true;
            this.lbSystemLogs.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSystemLogs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbSystemLogs.Location = new System.Drawing.Point(814, 16);
            this.lbSystemLogs.Name = "lbSystemLogs";
            this.lbSystemLogs.Size = new System.Drawing.Size(119, 17);
            this.lbSystemLogs.TabIndex = 22;
            this.lbSystemLogs.Text = "System Messages:";
            // 
            // lstSystemLog1
            // 
            this.lstSystemLog1.BackColor = System.Drawing.Color.Gainsboro;
            this.lstSystemLog1.FormattingEnabled = true;
            this.lstSystemLog1.Location = new System.Drawing.Point(817, 36);
            this.lstSystemLog1.Name = "lstSystemLog1";
            this.lstSystemLog1.Size = new System.Drawing.Size(393, 95);
            this.lstSystemLog1.TabIndex = 0;
            // 
            // btReqData
            // 
            this.btReqData.Location = new System.Drawing.Point(16, 36);
            this.btReqData.Name = "btReqData";
            this.btReqData.Size = new System.Drawing.Size(136, 23);
            this.btReqData.TabIndex = 2;
            this.btReqData.Text = "Request Flight Schedule";
            this.btReqData.UseVisualStyleBackColor = true;
            this.btReqData.Click += new System.EventHandler(this.btReqData_Click);
            // 
            // gridFlightViewer
            // 
            this.gridFlightViewer.AllowUserToAddRows = false;
            this.gridFlightViewer.AllowUserToDeleteRows = false;
            this.gridFlightViewer.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.gridFlightViewer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridFlightViewer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridFlightViewer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridFlightViewer.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gridFlightViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridFlightViewer.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridFlightViewer.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridFlightViewer.Location = new System.Drawing.Point(6, 23);
            this.gridFlightViewer.Name = "gridFlightViewer";
            this.gridFlightViewer.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridFlightViewer.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridFlightViewer.ShowEditingIcon = false;
            this.gridFlightViewer.Size = new System.Drawing.Size(1229, 403);
            this.gridFlightViewer.TabIndex = 6;
            // 
            // lbTimeDisplay
            // 
            this.lbTimeDisplay.AutoSize = true;
            this.lbTimeDisplay.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbTimeDisplay.Location = new System.Drawing.Point(177, 38);
            this.lbTimeDisplay.Name = "lbTimeDisplay";
            this.lbTimeDisplay.Size = new System.Drawing.Size(86, 17);
            this.lbTimeDisplay.TabIndex = 18;
            this.lbTimeDisplay.Text = "Time Display";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbTime.Location = new System.Drawing.Point(137, 38);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(41, 17);
            this.lbTime.TabIndex = 17;
            this.lbTime.Text = "Time:";
            // 
            // btConnectStatus
            // 
            this.btConnectStatus.BackColor = System.Drawing.Color.Red;
            this.btConnectStatus.Enabled = false;
            this.btConnectStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConnectStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConnectStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btConnectStatus.Location = new System.Drawing.Point(1053, 15);
            this.btConnectStatus.Name = "btConnectStatus";
            this.btConnectStatus.Size = new System.Drawing.Size(117, 23);
            this.btConnectStatus.TabIndex = 11;
            this.btConnectStatus.Text = "Disconnected";
            this.btConnectStatus.UseVisualStyleBackColor = false;
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(972, 15);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(75, 23);
            this.btConnect.TabIndex = 3;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // lbDateDisplay
            // 
            this.lbDateDisplay.AutoSize = true;
            this.lbDateDisplay.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateDisplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbDateDisplay.Location = new System.Drawing.Point(47, 38);
            this.lbDateDisplay.Name = "lbDateDisplay";
            this.lbDateDisplay.Size = new System.Drawing.Size(89, 17);
            this.lbDateDisplay.TabIndex = 9;
            this.lbDateDisplay.Text = "Date Display";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbDate.Location = new System.Drawing.Point(4, 38);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(44, 17);
            this.lbDate.TabIndex = 8;
            this.lbDate.Text = "Date:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 69);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1249, 601);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tabPage2.Controls.Add(this.lbFlightScheduleHidden);
            this.tabPage2.Controls.Add(this.lbAirlineOperatedHidden);
            this.tabPage2.Controls.Add(this.lbFlightSchedule);
            this.tabPage2.Controls.Add(this.lbAirlinesOperated);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.gbSearchBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1241, 575);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Flight Schedule Search";
            // 
            // lbFlightScheduleHidden
            // 
            this.lbFlightScheduleHidden.AutoSize = true;
            this.lbFlightScheduleHidden.Location = new System.Drawing.Point(343, 17);
            this.lbFlightScheduleHidden.Name = "lbFlightScheduleHidden";
            this.lbFlightScheduleHidden.Size = new System.Drawing.Size(0, 13);
            this.lbFlightScheduleHidden.TabIndex = 40;
            // 
            // lbAirlineOperatedHidden
            // 
            this.lbAirlineOperatedHidden.AutoSize = true;
            this.lbAirlineOperatedHidden.Location = new System.Drawing.Point(127, 17);
            this.lbAirlineOperatedHidden.Name = "lbAirlineOperatedHidden";
            this.lbAirlineOperatedHidden.Size = new System.Drawing.Size(0, 13);
            this.lbAirlineOperatedHidden.TabIndex = 39;
            // 
            // lbFlightSchedule
            // 
            this.lbFlightSchedule.AutoSize = true;
            this.lbFlightSchedule.Location = new System.Drawing.Point(241, 17);
            this.lbFlightSchedule.Name = "lbFlightSchedule";
            this.lbFlightSchedule.Size = new System.Drawing.Size(86, 13);
            this.lbFlightSchedule.TabIndex = 38;
            this.lbFlightSchedule.Text = "Flight Schedule: ";
            // 
            // lbAirlinesOperated
            // 
            this.lbAirlinesOperated.AutoSize = true;
            this.lbAirlinesOperated.Location = new System.Drawing.Point(17, 17);
            this.lbAirlinesOperated.Name = "lbAirlinesOperated";
            this.lbAirlinesOperated.Size = new System.Drawing.Size(104, 13);
            this.lbAirlinesOperated.TabIndex = 37;
            this.lbAirlinesOperated.Text = "Airlines Operation In:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView2.Location = new System.Drawing.Point(5, 39);
            this.dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.ShowEditingIcon = false;
            this.dataGridView2.Size = new System.Drawing.Size(194, 381);
            this.dataGridView2.TabIndex = 36;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(205, 39);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(1030, 384);
            this.dataGridView1.TabIndex = 35;
            // 
            // gbSearchBox
            // 
            this.gbSearchBox.Controls.Add(this.lbsyslog);
            this.gbSearchBox.Controls.Add(this.lstSystemLog);
            this.gbSearchBox.Controls.Add(this.btSearch);
            this.gbSearchBox.Controls.Add(this.lbSearchMode);
            this.gbSearchBox.Controls.Add(this.lbSearch);
            this.gbSearchBox.Controls.Add(this.rbAirlinesOperated);
            this.gbSearchBox.Controls.Add(this.tbSearch);
            this.gbSearchBox.Controls.Add(this.rbFlightSchedule);
            this.gbSearchBox.Location = new System.Drawing.Point(6, 426);
            this.gbSearchBox.Name = "gbSearchBox";
            this.gbSearchBox.Size = new System.Drawing.Size(1229, 143);
            this.gbSearchBox.TabIndex = 33;
            this.gbSearchBox.TabStop = false;
            this.gbSearchBox.Text = "SearchBox";
            // 
            // lbsyslog
            // 
            this.lbsyslog.AutoSize = true;
            this.lbsyslog.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsyslog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbsyslog.Location = new System.Drawing.Point(814, 16);
            this.lbsyslog.Name = "lbsyslog";
            this.lbsyslog.Size = new System.Drawing.Size(119, 17);
            this.lbsyslog.TabIndex = 33;
            this.lbsyslog.Text = "System Messages:";
            // 
            // lstSystemLog
            // 
            this.lstSystemLog.BackColor = System.Drawing.Color.Gainsboro;
            this.lstSystemLog.FormattingEnabled = true;
            this.lstSystemLog.Location = new System.Drawing.Point(817, 36);
            this.lstSystemLog.Name = "lstSystemLog";
            this.lstSystemLog.Size = new System.Drawing.Size(393, 95);
            this.lstSystemLog.TabIndex = 0;
            // 
            // btSearch
            // 
            this.btSearch.Location = new System.Drawing.Point(73, 106);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(75, 23);
            this.btSearch.TabIndex = 8;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // lbSearchMode
            // 
            this.lbSearchMode.AutoSize = true;
            this.lbSearchMode.Location = new System.Drawing.Point(22, 62);
            this.lbSearchMode.Name = "lbSearchMode";
            this.lbSearchMode.Size = new System.Drawing.Size(37, 13);
            this.lbSearchMode.TabIndex = 32;
            this.lbSearchMode.Text = "Mode:";
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Location = new System.Drawing.Point(22, 30);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(44, 13);
            this.lbSearch.TabIndex = 28;
            this.lbSearch.Text = "Search:";
            // 
            // rbAirlinesOperated
            // 
            this.rbAirlinesOperated.AutoSize = true;
            this.rbAirlinesOperated.Location = new System.Drawing.Point(73, 83);
            this.rbAirlinesOperated.Name = "rbAirlinesOperated";
            this.rbAirlinesOperated.Size = new System.Drawing.Size(105, 17);
            this.rbAirlinesOperated.TabIndex = 7;
            this.rbAirlinesOperated.Text = "Airlines Operated";
            this.rbAirlinesOperated.UseVisualStyleBackColor = true;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(73, 27);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(121, 20);
            this.tbSearch.TabIndex = 5;
            // 
            // rbFlightSchedule
            // 
            this.rbFlightSchedule.AutoSize = true;
            this.rbFlightSchedule.Checked = true;
            this.rbFlightSchedule.Location = new System.Drawing.Point(73, 60);
            this.rbFlightSchedule.Name = "rbFlightSchedule";
            this.rbFlightSchedule.Size = new System.Drawing.Size(98, 17);
            this.rbFlightSchedule.TabIndex = 6;
            this.rbFlightSchedule.TabStop = true;
            this.rbFlightSchedule.Text = "Flight Schedule";
            this.rbFlightSchedule.UseVisualStyleBackColor = true;
            // 
            // btDisconnect
            // 
            this.btDisconnect.Enabled = false;
            this.btDisconnect.Location = new System.Drawing.Point(1176, 15);
            this.btDisconnect.Name = "btDisconnect";
            this.btDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btDisconnect.TabIndex = 4;
            this.btDisconnect.Text = "Disconnect";
            this.btDisconnect.UseVisualStyleBackColor = true;
            this.btDisconnect.Click += new System.EventHandler(this.btDisconnect_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbTitle.Location = new System.Drawing.Point(506, 32);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(218, 23);
            this.lbTitle.TabIndex = 21;
            this.lbTitle.Text = "Flight Schedule Viewer";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1264, 699);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btDisconnect);
            this.Controls.Add(this.lbTimeDisplay);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btConnectStatus);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbDateDisplay);
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "Flight Schedule Viewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.tabPage1.ResumeLayout(false);
            this.gbViewMode.ResumeLayout(false);
            this.gbViewMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFlightViewer)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbSearchBox.ResumeLayout(false);
            this.gbSearchBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btConnectStatus;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.Label lbDateDisplay;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.DataGridView gridFlightViewer;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label lbTimeDisplay;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.GroupBox gbViewMode;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lbSearchMode;
        private System.Windows.Forms.RadioButton rbAirlinesOperated;
        private System.Windows.Forms.RadioButton rbFlightSchedule;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.GroupBox gbSearchBox;
        private System.Windows.Forms.Button btDisconnect;
        private System.Windows.Forms.Button btReqData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lbFlightScheduleHidden;
        private System.Windows.Forms.Label lbAirlineOperatedHidden;
        private System.Windows.Forms.Label lbFlightSchedule;
        private System.Windows.Forms.Label lbAirlinesOperated;
        private System.Windows.Forms.ListBox lstSystemLog;
        private System.Windows.Forms.ListBox lstSystemLog1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbSystemLogs;
        private System.Windows.Forms.Label lbsyslog;

    }
}

