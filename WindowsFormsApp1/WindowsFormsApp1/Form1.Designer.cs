namespace WindowsFormsApp1
{
    partial class MainPage
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.afDataChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.piSystemPicker1 = new OSIsoft.AF.UI.PISystemPicker();
            this.afDatabasePicker1 = new OSIsoft.AF.UI.AFDatabasePicker();
            this.afTreeView1 = new OSIsoft.AF.UI.AFTreeView();
            this.afTreeView2 = new OSIsoft.AF.UI.AFTreeView();
            this.gbDetails = new System.Windows.Forms.GroupBox();
            this.lbTimestamp = new System.Windows.Forms.Label();
            this.cbUOM = new System.Windows.Forms.ComboBox();
            this.btnInspectTag = new System.Windows.Forms.Button();
            this.lbTagName = new System.Windows.Forms.Label();
            this.lbCurrentVal = new System.Windows.Forms.Label();
            this.lbAttribName = new System.Windows.Forms.Label();
            this.lbAttributeName = new System.Windows.Forms.Label();
            this.lbCurrentValue = new System.Windows.Forms.Label();
            this.lbPITagName = new System.Windows.Forms.Label();
            this.lbUOM = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bntShowTrend = new System.Windows.Forms.Button();
            this.lbData = new System.Windows.Forms.ListBox();
            this.afEndTime = new OSIsoft.AF.UI.AFDateTimePickerCtrl();
            this.afStartDate = new OSIsoft.AF.UI.AFDateTimePickerCtrl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.piDataChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.piInstrumentTag = new System.Windows.Forms.Label();
            this.piLocation5 = new System.Windows.Forms.Label();
            this.piLocation4 = new System.Windows.Forms.Label();
            this.piLocation3 = new System.Windows.Forms.Label();
            this.piLocation2 = new System.Windows.Forms.Label();
            this.piLocation1 = new System.Windows.Forms.Label();
            this.piCreator = new System.Windows.Forms.Label();
            this.lbInstrumentTag = new System.Windows.Forms.Label();
            this.lbLocation5 = new System.Windows.Forms.Label();
            this.piCreationDate = new System.Windows.Forms.Label();
            this.piPointSource = new System.Windows.Forms.Label();
            this.piPointType = new System.Windows.Forms.Label();
            this.piEngUnits = new System.Windows.Forms.Label();
            this.piDescriptor = new System.Windows.Forms.Label();
            this.lbPointType = new System.Windows.Forms.Label();
            this.lbPointSource = new System.Windows.Forms.Label();
            this.lbCreationDate = new System.Windows.Forms.Label();
            this.lbCreator = new System.Windows.Forms.Label();
            this.lbLocation1 = new System.Windows.Forms.Label();
            this.lbLocation2 = new System.Windows.Forms.Label();
            this.lbLocation3 = new System.Windows.Forms.Label();
            this.lbLocation4 = new System.Windows.Forms.Label();
            this.piTag = new System.Windows.Forms.Label();
            this.lbDescriptor = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbEngUnits = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.piCurrentTimestamp = new System.Windows.Forms.Label();
            this.lbPIData = new System.Windows.Forms.ListBox();
            this.btnGetTagData = new System.Windows.Forms.Button();
            this.piCurrentValue = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.piEndTime = new OSIsoft.AF.UI.AFDateTimePickerCtrl();
            this.piStartTime = new OSIsoft.AF.UI.AFDateTimePickerCtrl();
            this.label30 = new System.Windows.Forms.Label();
            this.lbStartTime = new System.Windows.Forms.Label();
            this.lbEndTime = new System.Windows.Forms.Label();
            this.lbTag = new System.Windows.Forms.Label();
            this.gbEnterTagDetails = new System.Windows.Forms.GroupBox();
            this.lbTagFound = new System.Windows.Forms.Label();
            this.piServerPicker1 = new OSIsoft.AF.UI.PIServerPicker();
            this.btnGetTagInfo = new System.Windows.Forms.Button();
            this.lbSelectServer = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.tbEnterTag = new System.Windows.Forms.TextBox();
            this.lbEnterTag = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.lbConnectionStatus = new System.Windows.Forms.Label();
            this.lbConnectionStatusLabel = new System.Windows.Forms.Label();
            this.lbAuthenticationStatus = new System.Windows.Forms.Label();
            this.lbAuthenticationStatusLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbAverageReturnTime = new System.Windows.Forms.Label();
            this.lbReturnTime = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbPingFailure = new System.Windows.Forms.Label();
            this.pingResults = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbPingResult = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.piServerPicker2 = new OSIsoft.AF.UI.PIServerPicker();
            this.btnPing = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lbMinReturnTime = new System.Windows.Forms.Label();
            this.lbMaxReturnTime = new System.Windows.Forms.Label();
            this.lbMinTime = new System.Windows.Forms.Label();
            this.lbMaxTime = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.afDataChart)).BeginInit();
            this.gbDetails.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piDataChart)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbEnterTagDetails.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pingResults)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Time-Series Data:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Start time:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1021, 437);
            this.tabControl1.TabIndex = 24;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.piSystemPicker1);
            this.tabPage1.Controls.Add(this.afDatabasePicker1);
            this.tabPage1.Controls.Add(this.afTreeView1);
            this.tabPage1.Controls.Add(this.afTreeView2);
            this.tabPage1.Controls.Add(this.gbDetails);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1013, 411);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Asset Framework";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.afDataChart);
            this.groupBox5.Location = new System.Drawing.Point(705, 200);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(302, 203);
            this.groupBox5.TabIndex = 35;
            this.groupBox5.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 15);
            this.label7.TabIndex = 22;
            this.label7.Text = "Time-series data:";
            // 
            // afDataChart
            // 
            this.afDataChart.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            this.afDataChart.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.afDataChart.ChartAreas.Add(chartArea1);
            this.afDataChart.Location = new System.Drawing.Point(3, 19);
            this.afDataChart.Margin = new System.Windows.Forms.Padding(0);
            this.afDataChart.Name = "afDataChart";
            this.afDataChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "dataSeries";
            this.afDataChart.Series.Add(series1);
            this.afDataChart.Size = new System.Drawing.Size(296, 171);
            this.afDataChart.TabIndex = 0;
            this.afDataChart.Text = "chart1";
            title1.Name = "Title1";
            this.afDataChart.Titles.Add(title1);
            // 
            // piSystemPicker1
            // 
            this.piSystemPicker1.AccessibleDescription = "PI System Picker";
            this.piSystemPicker1.AccessibleName = "PI System Picker";
            this.piSystemPicker1.Cursor = System.Windows.Forms.Cursors.Default;
            this.piSystemPicker1.EnableDelete = false;
            this.piSystemPicker1.EnableEnd = false;
            this.piSystemPicker1.EnableNavigation = false;
            this.piSystemPicker1.EnableNew = false;
            this.piSystemPicker1.EnableNext = false;
            this.piSystemPicker1.EnablePrevious = false;
            this.piSystemPicker1.Location = new System.Drawing.Point(6, 6);
            this.piSystemPicker1.LoginPromptSetting = OSIsoft.AF.UI.PISystemPicker.LoginPromptSettingOptions.Default;
            this.piSystemPicker1.Name = "piSystemPicker1";
            this.piSystemPicker1.ShowBegin = false;
            this.piSystemPicker1.ShowDelete = false;
            this.piSystemPicker1.ShowEnd = false;
            this.piSystemPicker1.ShowFind = false;
            this.piSystemPicker1.ShowList = false;
            this.piSystemPicker1.ShowNavigation = false;
            this.piSystemPicker1.ShowNew = false;
            this.piSystemPicker1.ShowNext = false;
            this.piSystemPicker1.ShowNoEntries = false;
            this.piSystemPicker1.ShowPrevious = false;
            this.piSystemPicker1.ShowProperties = false;
            this.piSystemPicker1.Size = new System.Drawing.Size(226, 22);
            this.piSystemPicker1.TabIndex = 25;
            // 
            // afDatabasePicker1
            // 
            this.afDatabasePicker1.AccessibleDescription = "Database Picker";
            this.afDatabasePicker1.AccessibleName = "Database Picker";
            this.afDatabasePicker1.Location = new System.Drawing.Point(6, 34);
            this.afDatabasePicker1.Name = "afDatabasePicker1";
            this.afDatabasePicker1.ShowBegin = false;
            this.afDatabasePicker1.ShowConfigurationDatabase = OSIsoft.AF.UI.ShowConfigurationDatabase.Hide;
            this.afDatabasePicker1.ShowDelete = false;
            this.afDatabasePicker1.ShowEnd = false;
            this.afDatabasePicker1.ShowFind = false;
            this.afDatabasePicker1.ShowNavigation = false;
            this.afDatabasePicker1.ShowNew = false;
            this.afDatabasePicker1.ShowNext = false;
            this.afDatabasePicker1.ShowNoEntries = false;
            this.afDatabasePicker1.ShowPrevious = false;
            this.afDatabasePicker1.ShowProperties = false;
            this.afDatabasePicker1.Size = new System.Drawing.Size(226, 22);
            this.afDatabasePicker1.TabIndex = 25;
            this.afDatabasePicker1.SelectionChange += new OSIsoft.AF.UI.SelectionChangeEventHandler(this.afDatabasePicker1_SelectionChange);
            // 
            // afTreeView1
            // 
            this.afTreeView1.HideSelection = false;
            this.afTreeView1.Location = new System.Drawing.Point(6, 62);
            this.afTreeView1.Name = "afTreeView1";
            this.afTreeView1.ShowNodeToolTips = true;
            this.afTreeView1.Size = new System.Drawing.Size(191, 341);
            this.afTreeView1.TabIndex = 25;
            this.afTreeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.afTreeView1_AfterSelect);
            // 
            // afTreeView2
            // 
            this.afTreeView2.HideSelection = false;
            this.afTreeView2.Location = new System.Drawing.Point(203, 62);
            this.afTreeView2.Name = "afTreeView2";
            this.afTreeView2.ShowNodeToolTips = true;
            this.afTreeView2.Size = new System.Drawing.Size(190, 341);
            this.afTreeView2.TabIndex = 25;
            this.afTreeView2.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.afTreeView2_AfterSelect);
            // 
            // gbDetails
            // 
            this.gbDetails.BackColor = System.Drawing.SystemColors.Window;
            this.gbDetails.Controls.Add(this.lbTimestamp);
            this.gbDetails.Controls.Add(this.cbUOM);
            this.gbDetails.Controls.Add(this.btnInspectTag);
            this.gbDetails.Controls.Add(this.lbTagName);
            this.gbDetails.Controls.Add(this.lbCurrentVal);
            this.gbDetails.Controls.Add(this.lbAttribName);
            this.gbDetails.Controls.Add(this.lbAttributeName);
            this.gbDetails.Controls.Add(this.lbCurrentValue);
            this.gbDetails.Controls.Add(this.lbPITagName);
            this.gbDetails.Controls.Add(this.lbUOM);
            this.gbDetails.Location = new System.Drawing.Point(399, 62);
            this.gbDetails.Name = "gbDetails";
            this.gbDetails.Size = new System.Drawing.Size(608, 132);
            this.gbDetails.TabIndex = 25;
            this.gbDetails.TabStop = false;
            // 
            // lbTimestamp
            // 
            this.lbTimestamp.AutoSize = true;
            this.lbTimestamp.Location = new System.Drawing.Point(284, 51);
            this.lbTimestamp.Name = "lbTimestamp";
            this.lbTimestamp.Size = new System.Drawing.Size(0, 13);
            this.lbTimestamp.TabIndex = 29;
            // 
            // cbUOM
            // 
            this.cbUOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUOM.FormattingEnabled = true;
            this.cbUOM.Location = new System.Drawing.Point(165, 77);
            this.cbUOM.MaxDropDownItems = 20;
            this.cbUOM.Name = "cbUOM";
            this.cbUOM.Size = new System.Drawing.Size(121, 21);
            this.cbUOM.TabIndex = 28;
            this.cbUOM.SelectedIndexChanged += new System.EventHandler(this.cbUOM_SelectedIndexChanged);
            // 
            // btnInspectTag
            // 
            this.btnInspectTag.Location = new System.Drawing.Point(527, 100);
            this.btnInspectTag.Name = "btnInspectTag";
            this.btnInspectTag.Size = new System.Drawing.Size(75, 23);
            this.btnInspectTag.TabIndex = 27;
            this.btnInspectTag.Text = "Inspect Tag";
            this.btnInspectTag.UseVisualStyleBackColor = true;
            this.btnInspectTag.Click += new System.EventHandler(this.btnInspectTag_Click);
            // 
            // lbTagName
            // 
            this.lbTagName.AutoSize = true;
            this.lbTagName.Location = new System.Drawing.Point(161, 105);
            this.lbTagName.Name = "lbTagName";
            this.lbTagName.Size = new System.Drawing.Size(0, 13);
            this.lbTagName.TabIndex = 15;
            // 
            // lbCurrentVal
            // 
            this.lbCurrentVal.AutoSize = true;
            this.lbCurrentVal.Location = new System.Drawing.Point(161, 53);
            this.lbCurrentVal.Name = "lbCurrentVal";
            this.lbCurrentVal.Size = new System.Drawing.Size(0, 13);
            this.lbCurrentVal.TabIndex = 13;
            // 
            // lbAttribName
            // 
            this.lbAttribName.AutoSize = true;
            this.lbAttribName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAttribName.Location = new System.Drawing.Point(161, 12);
            this.lbAttribName.Name = "lbAttribName";
            this.lbAttribName.Size = new System.Drawing.Size(0, 20);
            this.lbAttribName.TabIndex = 12;
            // 
            // lbAttributeName
            // 
            this.lbAttributeName.AutoSize = true;
            this.lbAttributeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAttributeName.Location = new System.Drawing.Point(6, 12);
            this.lbAttributeName.Name = "lbAttributeName";
            this.lbAttributeName.Size = new System.Drawing.Size(114, 16);
            this.lbAttributeName.TabIndex = 8;
            this.lbAttributeName.Text = "Attribute Name:";
            // 
            // lbCurrentValue
            // 
            this.lbCurrentValue.AutoSize = true;
            this.lbCurrentValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentValue.Location = new System.Drawing.Point(7, 51);
            this.lbCurrentValue.Name = "lbCurrentValue";
            this.lbCurrentValue.Size = new System.Drawing.Size(98, 15);
            this.lbCurrentValue.TabIndex = 9;
            this.lbCurrentValue.Text = "Current Value:";
            // 
            // lbPITagName
            // 
            this.lbPITagName.AutoSize = true;
            this.lbPITagName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPITagName.Location = new System.Drawing.Point(7, 103);
            this.lbPITagName.Name = "lbPITagName";
            this.lbPITagName.Size = new System.Drawing.Size(94, 15);
            this.lbPITagName.TabIndex = 11;
            this.lbPITagName.Text = "PI Tag Name:";
            // 
            // lbUOM
            // 
            this.lbUOM.AutoSize = true;
            this.lbUOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUOM.Location = new System.Drawing.Point(7, 77);
            this.lbUOM.Name = "lbUOM";
            this.lbUOM.Size = new System.Drawing.Size(113, 15);
            this.lbUOM.TabIndex = 10;
            this.lbUOM.Text = "Unit of Measure:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.bntShowTrend);
            this.groupBox1.Controls.Add(this.lbData);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.afEndTime);
            this.groupBox1.Controls.Add(this.afStartDate);
            this.groupBox1.Location = new System.Drawing.Point(399, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 203);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(110, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "End time:";
            // 
            // bntShowTrend
            // 
            this.bntShowTrend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bntShowTrend.BackgroundImage")));
            this.bntShowTrend.Location = new System.Drawing.Point(206, 71);
            this.bntShowTrend.Name = "bntShowTrend";
            this.bntShowTrend.Size = new System.Drawing.Size(30, 29);
            this.bntShowTrend.TabIndex = 16;
            this.bntShowTrend.UseVisualStyleBackColor = true;
            this.bntShowTrend.Click += new System.EventHandler(this.bntShowTrend_Click);
            // 
            // lbData
            // 
            this.lbData.FormattingEnabled = true;
            this.lbData.Location = new System.Drawing.Point(10, 102);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(284, 95);
            this.lbData.TabIndex = 26;
            // 
            // afEndTime
            // 
            this.afEndTime.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.afEndTime.ImageIndex = 1;
            this.afEndTime.Location = new System.Drawing.Point(113, 71);
            this.afEndTime.Margin = new System.Windows.Forms.Padding(4);
            this.afEndTime.MinimumSize = new System.Drawing.Size(0, 22);
            this.afEndTime.Name = "afEndTime";
            this.afEndTime.Size = new System.Drawing.Size(86, 24);
            this.afEndTime.TabIndex = 25;
            this.afEndTime.TextCue = "";
            // 
            // afStartDate
            // 
            this.afStartDate.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.afStartDate.ImageIndex = 1;
            this.afStartDate.Location = new System.Drawing.Point(10, 71);
            this.afStartDate.Margin = new System.Windows.Forms.Padding(4);
            this.afStartDate.MinimumSize = new System.Drawing.Size(0, 22);
            this.afStartDate.Name = "afStartDate";
            this.afStartDate.Size = new System.Drawing.Size(95, 24);
            this.afStartDate.TabIndex = 24;
            this.afStartDate.TextCue = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.lbTag);
            this.tabPage2.Controls.Add(this.gbEnterTagDetails);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1013, 411);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Data Archive";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.piDataChart);
            this.groupBox4.Location = new System.Drawing.Point(517, 169);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(484, 236);
            this.groupBox4.TabIndex = 34;
            this.groupBox4.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "Time-series data:";
            // 
            // piDataChart
            // 
            this.piDataChart.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            this.piDataChart.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.piDataChart.ChartAreas.Add(chartArea2);
            this.piDataChart.Location = new System.Drawing.Point(6, 19);
            this.piDataChart.Name = "piDataChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Name = "dataSeries";
            this.piDataChart.Series.Add(series2);
            this.piDataChart.Size = new System.Drawing.Size(472, 202);
            this.piDataChart.TabIndex = 0;
            this.piDataChart.Text = "chart1";
            title2.Name = "Title1";
            this.piDataChart.Titles.Add(title2);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.piInstrumentTag);
            this.groupBox3.Controls.Add(this.piLocation5);
            this.groupBox3.Controls.Add(this.piLocation4);
            this.groupBox3.Controls.Add(this.piLocation3);
            this.groupBox3.Controls.Add(this.piLocation2);
            this.groupBox3.Controls.Add(this.piLocation1);
            this.groupBox3.Controls.Add(this.piCreator);
            this.groupBox3.Controls.Add(this.lbInstrumentTag);
            this.groupBox3.Controls.Add(this.lbLocation5);
            this.groupBox3.Controls.Add(this.piCreationDate);
            this.groupBox3.Controls.Add(this.piPointSource);
            this.groupBox3.Controls.Add(this.piPointType);
            this.groupBox3.Controls.Add(this.piEngUnits);
            this.groupBox3.Controls.Add(this.piDescriptor);
            this.groupBox3.Controls.Add(this.lbPointType);
            this.groupBox3.Controls.Add(this.lbPointSource);
            this.groupBox3.Controls.Add(this.lbCreationDate);
            this.groupBox3.Controls.Add(this.lbCreator);
            this.groupBox3.Controls.Add(this.lbLocation1);
            this.groupBox3.Controls.Add(this.lbLocation2);
            this.groupBox3.Controls.Add(this.lbLocation3);
            this.groupBox3.Controls.Add(this.lbLocation4);
            this.groupBox3.Controls.Add(this.piTag);
            this.groupBox3.Controls.Add(this.lbDescriptor);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.lbEngUnits);
            this.groupBox3.Location = new System.Drawing.Point(461, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(546, 163);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            // 
            // piInstrumentTag
            // 
            this.piInstrumentTag.AutoSize = true;
            this.piInstrumentTag.Location = new System.Drawing.Point(393, 122);
            this.piInstrumentTag.Name = "piInstrumentTag";
            this.piInstrumentTag.Size = new System.Drawing.Size(13, 13);
            this.piInstrumentTag.TabIndex = 33;
            this.piInstrumentTag.Text = "..";
            // 
            // piLocation5
            // 
            this.piLocation5.AutoSize = true;
            this.piLocation5.Location = new System.Drawing.Point(393, 104);
            this.piLocation5.Name = "piLocation5";
            this.piLocation5.Size = new System.Drawing.Size(13, 13);
            this.piLocation5.TabIndex = 32;
            this.piLocation5.Text = "..";
            // 
            // piLocation4
            // 
            this.piLocation4.AutoSize = true;
            this.piLocation4.Location = new System.Drawing.Point(393, 91);
            this.piLocation4.Name = "piLocation4";
            this.piLocation4.Size = new System.Drawing.Size(13, 13);
            this.piLocation4.TabIndex = 31;
            this.piLocation4.Text = "..";
            // 
            // piLocation3
            // 
            this.piLocation3.AutoSize = true;
            this.piLocation3.Location = new System.Drawing.Point(393, 76);
            this.piLocation3.Name = "piLocation3";
            this.piLocation3.Size = new System.Drawing.Size(13, 13);
            this.piLocation3.TabIndex = 30;
            this.piLocation3.Text = "..";
            // 
            // piLocation2
            // 
            this.piLocation2.AutoSize = true;
            this.piLocation2.Location = new System.Drawing.Point(393, 63);
            this.piLocation2.Name = "piLocation2";
            this.piLocation2.Size = new System.Drawing.Size(13, 13);
            this.piLocation2.TabIndex = 29;
            this.piLocation2.Text = "..";
            // 
            // piLocation1
            // 
            this.piLocation1.AutoSize = true;
            this.piLocation1.Location = new System.Drawing.Point(393, 50);
            this.piLocation1.Name = "piLocation1";
            this.piLocation1.Size = new System.Drawing.Size(13, 13);
            this.piLocation1.TabIndex = 28;
            this.piLocation1.Text = "..";
            // 
            // piCreator
            // 
            this.piCreator.AutoSize = true;
            this.piCreator.Location = new System.Drawing.Point(92, 138);
            this.piCreator.Name = "piCreator";
            this.piCreator.Size = new System.Drawing.Size(13, 13);
            this.piCreator.TabIndex = 27;
            this.piCreator.Text = "..";
            // 
            // lbInstrumentTag
            // 
            this.lbInstrumentTag.AutoSize = true;
            this.lbInstrumentTag.Location = new System.Drawing.Point(305, 122);
            this.lbInstrumentTag.Name = "lbInstrumentTag";
            this.lbInstrumentTag.Size = new System.Drawing.Size(81, 13);
            this.lbInstrumentTag.TabIndex = 26;
            this.lbInstrumentTag.Text = "Instrument Tag:";
            // 
            // lbLocation5
            // 
            this.lbLocation5.AutoSize = true;
            this.lbLocation5.Location = new System.Drawing.Point(305, 102);
            this.lbLocation5.Name = "lbLocation5";
            this.lbLocation5.Size = new System.Drawing.Size(57, 13);
            this.lbLocation5.TabIndex = 25;
            this.lbLocation5.Text = "Location5:";
            // 
            // piCreationDate
            // 
            this.piCreationDate.AutoSize = true;
            this.piCreationDate.Location = new System.Drawing.Point(92, 125);
            this.piCreationDate.Name = "piCreationDate";
            this.piCreationDate.Size = new System.Drawing.Size(13, 13);
            this.piCreationDate.TabIndex = 24;
            this.piCreationDate.Text = "..";
            // 
            // piPointSource
            // 
            this.piPointSource.AutoSize = true;
            this.piPointSource.Location = new System.Drawing.Point(92, 102);
            this.piPointSource.Name = "piPointSource";
            this.piPointSource.Size = new System.Drawing.Size(13, 13);
            this.piPointSource.TabIndex = 23;
            this.piPointSource.Text = "..";
            // 
            // piPointType
            // 
            this.piPointType.AutoSize = true;
            this.piPointType.Location = new System.Drawing.Point(92, 89);
            this.piPointType.Name = "piPointType";
            this.piPointType.Size = new System.Drawing.Size(13, 13);
            this.piPointType.TabIndex = 22;
            this.piPointType.Text = "..";
            // 
            // piEngUnits
            // 
            this.piEngUnits.AutoSize = true;
            this.piEngUnits.Location = new System.Drawing.Point(92, 76);
            this.piEngUnits.Name = "piEngUnits";
            this.piEngUnits.Size = new System.Drawing.Size(13, 13);
            this.piEngUnits.TabIndex = 21;
            this.piEngUnits.Text = "..";
            // 
            // piDescriptor
            // 
            this.piDescriptor.AutoSize = true;
            this.piDescriptor.Location = new System.Drawing.Point(92, 50);
            this.piDescriptor.Name = "piDescriptor";
            this.piDescriptor.Size = new System.Drawing.Size(13, 13);
            this.piDescriptor.TabIndex = 20;
            this.piDescriptor.Text = "..";
            // 
            // lbPointType
            // 
            this.lbPointType.AutoSize = true;
            this.lbPointType.Location = new System.Drawing.Point(12, 89);
            this.lbPointType.Name = "lbPointType";
            this.lbPointType.Size = new System.Drawing.Size(61, 13);
            this.lbPointType.TabIndex = 19;
            this.lbPointType.Text = "Point Type:";
            // 
            // lbPointSource
            // 
            this.lbPointSource.AutoSize = true;
            this.lbPointSource.Location = new System.Drawing.Point(12, 102);
            this.lbPointSource.Name = "lbPointSource";
            this.lbPointSource.Size = new System.Drawing.Size(71, 13);
            this.lbPointSource.TabIndex = 18;
            this.lbPointSource.Text = "Point Source:";
            // 
            // lbCreationDate
            // 
            this.lbCreationDate.AutoSize = true;
            this.lbCreationDate.Location = new System.Drawing.Point(12, 125);
            this.lbCreationDate.Name = "lbCreationDate";
            this.lbCreationDate.Size = new System.Drawing.Size(75, 13);
            this.lbCreationDate.TabIndex = 17;
            this.lbCreationDate.Text = "Creation Date:";
            // 
            // lbCreator
            // 
            this.lbCreator.AutoSize = true;
            this.lbCreator.Location = new System.Drawing.Point(12, 138);
            this.lbCreator.Name = "lbCreator";
            this.lbCreator.Size = new System.Drawing.Size(44, 13);
            this.lbCreator.TabIndex = 16;
            this.lbCreator.Text = "Creator:";
            // 
            // lbLocation1
            // 
            this.lbLocation1.AutoSize = true;
            this.lbLocation1.Location = new System.Drawing.Point(305, 50);
            this.lbLocation1.Name = "lbLocation1";
            this.lbLocation1.Size = new System.Drawing.Size(57, 13);
            this.lbLocation1.TabIndex = 15;
            this.lbLocation1.Text = "Location1:";
            // 
            // lbLocation2
            // 
            this.lbLocation2.AutoSize = true;
            this.lbLocation2.Location = new System.Drawing.Point(305, 63);
            this.lbLocation2.Name = "lbLocation2";
            this.lbLocation2.Size = new System.Drawing.Size(57, 13);
            this.lbLocation2.TabIndex = 14;
            this.lbLocation2.Text = "Location2:";
            // 
            // lbLocation3
            // 
            this.lbLocation3.AutoSize = true;
            this.lbLocation3.Location = new System.Drawing.Point(305, 76);
            this.lbLocation3.Name = "lbLocation3";
            this.lbLocation3.Size = new System.Drawing.Size(57, 13);
            this.lbLocation3.TabIndex = 13;
            this.lbLocation3.Text = "Location3:";
            // 
            // lbLocation4
            // 
            this.lbLocation4.AutoSize = true;
            this.lbLocation4.Location = new System.Drawing.Point(305, 89);
            this.lbLocation4.Name = "lbLocation4";
            this.lbLocation4.Size = new System.Drawing.Size(57, 13);
            this.lbLocation4.TabIndex = 12;
            this.lbLocation4.Text = "Location4:";
            // 
            // piTag
            // 
            this.piTag.AutoSize = true;
            this.piTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.piTag.Location = new System.Drawing.Point(111, 19);
            this.piTag.Name = "piTag";
            this.piTag.Size = new System.Drawing.Size(0, 16);
            this.piTag.TabIndex = 11;
            // 
            // lbDescriptor
            // 
            this.lbDescriptor.AutoSize = true;
            this.lbDescriptor.Location = new System.Drawing.Point(12, 50);
            this.lbDescriptor.Name = "lbDescriptor";
            this.lbDescriptor.Size = new System.Drawing.Size(58, 13);
            this.lbDescriptor.TabIndex = 10;
            this.lbDescriptor.Text = "Descriptor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tag details:";
            // 
            // lbEngUnits
            // 
            this.lbEngUnits.AutoSize = true;
            this.lbEngUnits.Location = new System.Drawing.Point(12, 76);
            this.lbEngUnits.Name = "lbEngUnits";
            this.lbEngUnits.Size = new System.Drawing.Size(56, 13);
            this.lbEngUnits.TabIndex = 5;
            this.lbEngUnits.Text = "Eng Units:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.piCurrentTimestamp);
            this.groupBox2.Controls.Add(this.lbPIData);
            this.groupBox2.Controls.Add(this.btnGetTagData);
            this.groupBox2.Controls.Add(this.piCurrentValue);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.piEndTime);
            this.groupBox2.Controls.Add(this.piStartTime);
            this.groupBox2.Controls.Add(this.label30);
            this.groupBox2.Controls.Add(this.lbStartTime);
            this.groupBox2.Controls.Add(this.lbEndTime);
            this.groupBox2.Location = new System.Drawing.Point(6, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(505, 236);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // piCurrentTimestamp
            // 
            this.piCurrentTimestamp.AutoSize = true;
            this.piCurrentTimestamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.piCurrentTimestamp.Location = new System.Drawing.Point(332, 61);
            this.piCurrentTimestamp.Name = "piCurrentTimestamp";
            this.piCurrentTimestamp.Size = new System.Drawing.Size(0, 15);
            this.piCurrentTimestamp.TabIndex = 21;
            // 
            // lbPIData
            // 
            this.lbPIData.FormattingEnabled = true;
            this.lbPIData.Location = new System.Drawing.Point(25, 111);
            this.lbPIData.Name = "lbPIData";
            this.lbPIData.Size = new System.Drawing.Size(454, 108);
            this.lbPIData.TabIndex = 18;
            // 
            // btnGetTagData
            // 
            this.btnGetTagData.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGetTagData.BackgroundImage")));
            this.btnGetTagData.Enabled = false;
            this.btnGetTagData.Location = new System.Drawing.Point(268, 47);
            this.btnGetTagData.Name = "btnGetTagData";
            this.btnGetTagData.Size = new System.Drawing.Size(30, 29);
            this.btnGetTagData.TabIndex = 17;
            this.btnGetTagData.UseVisualStyleBackColor = true;
            this.btnGetTagData.Click += new System.EventHandler(this.btnGetTagData_Click);
            // 
            // piCurrentValue
            // 
            this.piCurrentValue.AutoSize = true;
            this.piCurrentValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.piCurrentValue.Location = new System.Drawing.Point(360, 45);
            this.piCurrentValue.Name = "piCurrentValue";
            this.piCurrentValue.Size = new System.Drawing.Size(0, 15);
            this.piCurrentValue.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Get tag data:";
            // 
            // piEndTime
            // 
            this.piEndTime.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.piEndTime.Enabled = false;
            this.piEndTime.ImageIndex = 1;
            this.piEndTime.Location = new System.Drawing.Point(118, 70);
            this.piEndTime.Margin = new System.Windows.Forms.Padding(4);
            this.piEndTime.MinimumSize = new System.Drawing.Size(0, 22);
            this.piEndTime.Name = "piEndTime";
            this.piEndTime.Size = new System.Drawing.Size(143, 24);
            this.piEndTime.TabIndex = 9;
            // 
            // piStartTime
            // 
            this.piStartTime.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.piStartTime.Enabled = false;
            this.piStartTime.ImageIndex = 1;
            this.piStartTime.Location = new System.Drawing.Point(118, 43);
            this.piStartTime.Margin = new System.Windows.Forms.Padding(4);
            this.piStartTime.MinimumSize = new System.Drawing.Size(0, 22);
            this.piStartTime.Name = "piStartTime";
            this.piStartTime.Size = new System.Drawing.Size(143, 24);
            this.piStartTime.TabIndex = 8;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(332, 22);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(98, 15);
            this.label30.TabIndex = 0;
            this.label30.Text = "Current Value:";
            // 
            // lbStartTime
            // 
            this.lbStartTime.AutoSize = true;
            this.lbStartTime.Location = new System.Drawing.Point(22, 47);
            this.lbStartTime.Name = "lbStartTime";
            this.lbStartTime.Size = new System.Drawing.Size(54, 13);
            this.lbStartTime.TabIndex = 6;
            this.lbStartTime.Text = "Start time:";
            // 
            // lbEndTime
            // 
            this.lbEndTime.AutoSize = true;
            this.lbEndTime.Location = new System.Drawing.Point(22, 73);
            this.lbEndTime.Name = "lbEndTime";
            this.lbEndTime.Size = new System.Drawing.Size(51, 13);
            this.lbEndTime.TabIndex = 7;
            this.lbEndTime.Text = "End time:";
            // 
            // lbTag
            // 
            this.lbTag.AutoSize = true;
            this.lbTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTag.Location = new System.Drawing.Point(136, 123);
            this.lbTag.Name = "lbTag";
            this.lbTag.Size = new System.Drawing.Size(0, 20);
            this.lbTag.TabIndex = 1;
            // 
            // gbEnterTagDetails
            // 
            this.gbEnterTagDetails.Controls.Add(this.lbTagFound);
            this.gbEnterTagDetails.Controls.Add(this.piServerPicker1);
            this.gbEnterTagDetails.Controls.Add(this.btnGetTagInfo);
            this.gbEnterTagDetails.Controls.Add(this.lbSelectServer);
            this.gbEnterTagDetails.Controls.Add(this.lbTitle);
            this.gbEnterTagDetails.Controls.Add(this.tbEnterTag);
            this.gbEnterTagDetails.Controls.Add(this.lbEnterTag);
            this.gbEnterTagDetails.Location = new System.Drawing.Point(6, 0);
            this.gbEnterTagDetails.Name = "gbEnterTagDetails";
            this.gbEnterTagDetails.Size = new System.Drawing.Size(449, 163);
            this.gbEnterTagDetails.TabIndex = 11;
            this.gbEnterTagDetails.TabStop = false;
            // 
            // lbTagFound
            // 
            this.lbTagFound.AutoSize = true;
            this.lbTagFound.Location = new System.Drawing.Point(350, 90);
            this.lbTagFound.Name = "lbTagFound";
            this.lbTagFound.Size = new System.Drawing.Size(0, 13);
            this.lbTagFound.TabIndex = 13;
            // 
            // piServerPicker1
            // 
            this.piServerPicker1.AccessibleDescription = "PI Data Archive Picker";
            this.piServerPicker1.AccessibleName = "PI Data Archive Picker";
            this.piServerPicker1.Cursor = System.Windows.Forms.Cursors.Default;
            this.piServerPicker1.Location = new System.Drawing.Point(108, 51);
            this.piServerPicker1.Name = "piServerPicker1";
            this.piServerPicker1.ShowBegin = false;
            this.piServerPicker1.ShowConnect = false;
            this.piServerPicker1.ShowDelete = false;
            this.piServerPicker1.ShowEnd = false;
            this.piServerPicker1.ShowFind = false;
            this.piServerPicker1.ShowList = false;
            this.piServerPicker1.ShowNavigation = false;
            this.piServerPicker1.ShowNew = false;
            this.piServerPicker1.ShowNext = false;
            this.piServerPicker1.ShowNoEntries = false;
            this.piServerPicker1.ShowPrevious = false;
            this.piServerPicker1.ShowProperties = false;
            this.piServerPicker1.Size = new System.Drawing.Size(224, 22);
            this.piServerPicker1.TabIndex = 12;
            this.piServerPicker1.SelectionChange += new OSIsoft.AF.UI.SelectionChangeEventHandler(this.piServerPicker1_SelectionChange);
            // 
            // btnGetTagInfo
            // 
            this.btnGetTagInfo.Location = new System.Drawing.Point(161, 123);
            this.btnGetTagInfo.Name = "btnGetTagInfo";
            this.btnGetTagInfo.Size = new System.Drawing.Size(100, 23);
            this.btnGetTagInfo.TabIndex = 12;
            this.btnGetTagInfo.Text = "Get Tag Details";
            this.btnGetTagInfo.UseVisualStyleBackColor = true;
            this.btnGetTagInfo.Click += new System.EventHandler(this.btnGetTagInfo_Click);
            // 
            // lbSelectServer
            // 
            this.lbSelectServer.AutoSize = true;
            this.lbSelectServer.Location = new System.Drawing.Point(12, 60);
            this.lbSelectServer.Name = "lbSelectServer";
            this.lbSelectServer.Size = new System.Drawing.Size(72, 13);
            this.lbSelectServer.TabIndex = 10;
            this.lbSelectServer.Text = "Select server:";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(12, 19);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(109, 16);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Search for tag:";
            // 
            // tbEnterTag
            // 
            this.tbEnterTag.Location = new System.Drawing.Point(108, 87);
            this.tbEnterTag.Name = "tbEnterTag";
            this.tbEnterTag.Size = new System.Drawing.Size(224, 20);
            this.tbEnterTag.TabIndex = 4;
            // 
            // lbEnterTag
            // 
            this.lbEnterTag.AutoSize = true;
            this.lbEnterTag.Location = new System.Drawing.Point(12, 92);
            this.lbEnterTag.Name = "lbEnterTag";
            this.lbEnterTag.Size = new System.Drawing.Size(79, 13);
            this.lbEnterTag.TabIndex = 5;
            this.lbEnterTag.Text = "Enter tagname:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox8);
            this.tabPage3.Controls.Add(this.lbAverageReturnTime);
            this.tabPage3.Controls.Add(this.lbReturnTime);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.lbPingFailure);
            this.tabPage3.Controls.Add(this.pingResults);
            this.tabPage3.Controls.Add(this.lbPingResult);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.groupBox7);
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1013, 411);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Server Diagnostics";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.lbConnectionStatus);
            this.groupBox8.Controls.Add(this.lbConnectionStatusLabel);
            this.groupBox8.Controls.Add(this.lbAuthenticationStatus);
            this.groupBox8.Controls.Add(this.lbAuthenticationStatusLabel);
            this.groupBox8.Controls.Add(this.label10);
            this.groupBox8.Location = new System.Drawing.Point(6, 293);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(1001, 112);
            this.groupBox8.TabIndex = 29;
            this.groupBox8.TabStop = false;
            // 
            // lbConnectionStatus
            // 
            this.lbConnectionStatus.AutoSize = true;
            this.lbConnectionStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConnectionStatus.Location = new System.Drawing.Point(319, 77);
            this.lbConnectionStatus.Name = "lbConnectionStatus";
            this.lbConnectionStatus.Size = new System.Drawing.Size(13, 13);
            this.lbConnectionStatus.TabIndex = 31;
            this.lbConnectionStatus.Text = "..";
            this.lbConnectionStatus.Visible = false;
            // 
            // lbConnectionStatusLabel
            // 
            this.lbConnectionStatusLabel.AutoSize = true;
            this.lbConnectionStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConnectionStatusLabel.Location = new System.Drawing.Point(153, 75);
            this.lbConnectionStatusLabel.Name = "lbConnectionStatusLabel";
            this.lbConnectionStatusLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbConnectionStatusLabel.Size = new System.Drawing.Size(125, 15);
            this.lbConnectionStatusLabel.TabIndex = 32;
            this.lbConnectionStatusLabel.Text = "Connection status:";
            this.lbConnectionStatusLabel.Visible = false;
            // 
            // lbAuthenticationStatus
            // 
            this.lbAuthenticationStatus.AutoSize = true;
            this.lbAuthenticationStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAuthenticationStatus.Location = new System.Drawing.Point(319, 49);
            this.lbAuthenticationStatus.Name = "lbAuthenticationStatus";
            this.lbAuthenticationStatus.Size = new System.Drawing.Size(13, 13);
            this.lbAuthenticationStatus.TabIndex = 30;
            this.lbAuthenticationStatus.Text = "..";
            this.lbAuthenticationStatus.Visible = false;
            // 
            // lbAuthenticationStatusLabel
            // 
            this.lbAuthenticationStatusLabel.AutoSize = true;
            this.lbAuthenticationStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAuthenticationStatusLabel.Location = new System.Drawing.Point(153, 47);
            this.lbAuthenticationStatusLabel.Name = "lbAuthenticationStatusLabel";
            this.lbAuthenticationStatusLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbAuthenticationStatusLabel.Size = new System.Drawing.Size(144, 15);
            this.lbAuthenticationStatusLabel.TabIndex = 30;
            this.lbAuthenticationStatusLabel.Text = "Authentication status:";
            this.lbAuthenticationStatusLabel.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(45, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 16);
            this.label10.TabIndex = 30;
            this.label10.Text = "PI Connection:";
            // 
            // lbAverageReturnTime
            // 
            this.lbAverageReturnTime.AutoSize = true;
            this.lbAverageReturnTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAverageReturnTime.Location = new System.Drawing.Point(953, 136);
            this.lbAverageReturnTime.Name = "lbAverageReturnTime";
            this.lbAverageReturnTime.Size = new System.Drawing.Size(13, 13);
            this.lbAverageReturnTime.TabIndex = 21;
            this.lbAverageReturnTime.Text = "..";
            this.lbAverageReturnTime.Visible = false;
            // 
            // lbReturnTime
            // 
            this.lbReturnTime.AutoSize = true;
            this.lbReturnTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReturnTime.Location = new System.Drawing.Point(811, 134);
            this.lbReturnTime.Name = "lbReturnTime";
            this.lbReturnTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbReturnTime.Size = new System.Drawing.Size(136, 15);
            this.lbReturnTime.TabIndex = 20;
            this.lbReturnTime.Text = "Average return time:";
            this.lbReturnTime.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(51, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Ping Results:";
            // 
            // lbPingFailure
            // 
            this.lbPingFailure.AutoSize = true;
            this.lbPingFailure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPingFailure.Location = new System.Drawing.Point(393, 129);
            this.lbPingFailure.Name = "lbPingFailure";
            this.lbPingFailure.Size = new System.Drawing.Size(0, 20);
            this.lbPingFailure.TabIndex = 18;
            // 
            // pingResults
            // 
            chartArea3.AxisX.MajorGrid.Enabled = false;
            chartArea3.AxisY.MajorGrid.Enabled = false;
            chartArea3.AxisY.Title = "(milliseconds)";
            chartArea3.Name = "ChartArea1";
            this.pingResults.ChartAreas.Add(chartArea3);
            this.pingResults.Location = new System.Drawing.Point(45, 106);
            this.pingResults.Name = "pingResults";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Name = "ping";
            this.pingResults.Series.Add(series3);
            this.pingResults.Size = new System.Drawing.Size(760, 167);
            this.pingResults.TabIndex = 17;
            this.pingResults.Text = "chart1";
            // 
            // lbPingResult
            // 
            this.lbPingResult.AutoSize = true;
            this.lbPingResult.Location = new System.Drawing.Point(705, 90);
            this.lbPingResult.Name = "lbPingResult";
            this.lbPingResult.Size = new System.Drawing.Size(13, 13);
            this.lbPingResult.TabIndex = 16;
            this.lbPingResult.Text = "..";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Select server:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.piServerPicker2);
            this.groupBox7.Controls.Add(this.btnPing);
            this.groupBox7.Location = new System.Drawing.Point(6, 7);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(1001, 60);
            this.groupBox7.TabIndex = 23;
            this.groupBox7.TabStop = false;
            // 
            // piServerPicker2
            // 
            this.piServerPicker2.AccessibleDescription = "PI Data Archive Picker";
            this.piServerPicker2.AccessibleName = "PI Data Archive Picker";
            this.piServerPicker2.AllowNoneEntry = true;
            this.piServerPicker2.Cursor = System.Windows.Forms.Cursors.Default;
            this.piServerPicker2.EnableFind = true;
            this.piServerPicker2.Location = new System.Drawing.Point(92, 27);
            this.piServerPicker2.Name = "piServerPicker2";
            this.piServerPicker2.ShowBegin = false;
            this.piServerPicker2.ShowConnect = false;
            this.piServerPicker2.ShowDelete = false;
            this.piServerPicker2.ShowEnd = false;
            this.piServerPicker2.ShowFind = false;
            this.piServerPicker2.ShowList = false;
            this.piServerPicker2.ShowNavigation = false;
            this.piServerPicker2.ShowNew = false;
            this.piServerPicker2.ShowNext = false;
            this.piServerPicker2.ShowPrevious = false;
            this.piServerPicker2.ShowProperties = false;
            this.piServerPicker2.Size = new System.Drawing.Size(224, 22);
            this.piServerPicker2.TabIndex = 13;
            // 
            // btnPing
            // 
            this.btnPing.Location = new System.Drawing.Point(322, 26);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(113, 23);
            this.btnPing.TabIndex = 15;
            this.btnPing.Text = "Run Diagnostics";
            this.btnPing.UseVisualStyleBackColor = true;
            this.btnPing.Click += new System.EventHandler(this.btnPing_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lbMinReturnTime);
            this.groupBox6.Controls.Add(this.lbMaxReturnTime);
            this.groupBox6.Controls.Add(this.lbMinTime);
            this.groupBox6.Controls.Add(this.lbMaxTime);
            this.groupBox6.Location = new System.Drawing.Point(6, 73);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1001, 214);
            this.groupBox6.TabIndex = 22;
            this.groupBox6.TabStop = false;
            // 
            // lbMinReturnTime
            // 
            this.lbMinReturnTime.AutoSize = true;
            this.lbMinReturnTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMinReturnTime.Location = new System.Drawing.Point(947, 117);
            this.lbMinReturnTime.Name = "lbMinReturnTime";
            this.lbMinReturnTime.Size = new System.Drawing.Size(13, 13);
            this.lbMinReturnTime.TabIndex = 27;
            this.lbMinReturnTime.Text = "..";
            this.lbMinReturnTime.Visible = false;
            // 
            // lbMaxReturnTime
            // 
            this.lbMaxReturnTime.AutoSize = true;
            this.lbMaxReturnTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaxReturnTime.Location = new System.Drawing.Point(947, 90);
            this.lbMaxReturnTime.Name = "lbMaxReturnTime";
            this.lbMaxReturnTime.Size = new System.Drawing.Size(13, 13);
            this.lbMaxReturnTime.TabIndex = 25;
            this.lbMaxReturnTime.Text = "..";
            this.lbMaxReturnTime.Visible = false;
            // 
            // lbMinTime
            // 
            this.lbMinTime.AutoSize = true;
            this.lbMinTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMinTime.Location = new System.Drawing.Point(805, 115);
            this.lbMinTime.Name = "lbMinTime";
            this.lbMinTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbMinTime.Size = new System.Drawing.Size(109, 15);
            this.lbMinTime.TabIndex = 26;
            this.lbMinTime.Text = "Min return time:";
            this.lbMinTime.Visible = false;
            // 
            // lbMaxTime
            // 
            this.lbMaxTime.AutoSize = true;
            this.lbMaxTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaxTime.Location = new System.Drawing.Point(805, 88);
            this.lbMaxTime.Name = "lbMaxTime";
            this.lbMaxTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbMaxTime.Size = new System.Drawing.Size(112, 15);
            this.lbMaxTime.TabIndex = 24;
            this.lbMaxTime.Text = "Max return time:";
            this.lbMaxTime.Visible = false;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 461);
            this.Controls.Add(this.tabControl1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "MainPage";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.afDataChart)).EndInit();
            this.gbDetails.ResumeLayout(false);
            this.gbDetails.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piDataChart)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbEnterTagDetails.ResumeLayout(false);
            this.gbEnterTagDetails.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pingResults)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lbData;
        private System.Windows.Forms.Button bntShowTrend;
        private System.Windows.Forms.Label label3;
        private OSIsoft.AF.UI.AFDateTimePickerCtrl afEndTime;
        private OSIsoft.AF.UI.AFDateTimePickerCtrl afStartDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbDetails;
        private System.Windows.Forms.Label lbTagName;
        private System.Windows.Forms.Label lbCurrentVal;
        private System.Windows.Forms.Label lbAttribName;
        private System.Windows.Forms.Label lbAttributeName;
        private System.Windows.Forms.Label lbCurrentValue;
        private System.Windows.Forms.Label lbPITagName;
        private System.Windows.Forms.Label lbUOM;
        private OSIsoft.AF.UI.AFTreeView afTreeView2;
        private OSIsoft.AF.UI.PISystemPicker piSystemPicker1;
        private OSIsoft.AF.UI.AFDatabasePicker afDatabasePicker1;
        private OSIsoft.AF.UI.AFTreeView afTreeView1;
        private System.Windows.Forms.ComboBox cbUOM;
        private System.Windows.Forms.Button btnInspectTag;
        private System.Windows.Forms.Label lbTimestamp;
        private System.Windows.Forms.Label lbTag;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.GroupBox gbEnterTagDetails;
        private System.Windows.Forms.Button btnGetTagInfo;
        private System.Windows.Forms.Label lbSelectServer;
        private OSIsoft.AF.UI.AFDateTimePickerCtrl piEndTime;
        private OSIsoft.AF.UI.AFDateTimePickerCtrl piStartTime;
        private System.Windows.Forms.TextBox tbEnterTag;
        private System.Windows.Forms.Label lbEndTime;
        private System.Windows.Forms.Label lbEnterTag;
        private System.Windows.Forms.Label lbStartTime;
        private OSIsoft.AF.UI.PIServerPicker piServerPicker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbEngUnits;
        private System.Windows.Forms.Button btnGetTagData;
        private System.Windows.Forms.Label lbDescriptor;
        private System.Windows.Forms.Label lbPointType;
        private System.Windows.Forms.Label lbPointSource;
        private System.Windows.Forms.Label lbCreationDate;
        private System.Windows.Forms.Label lbCreator;
        private System.Windows.Forms.Label lbLocation1;
        private System.Windows.Forms.Label lbLocation2;
        private System.Windows.Forms.Label lbLocation3;
        private System.Windows.Forms.Label lbLocation4;
        private System.Windows.Forms.Label piTag;
        private System.Windows.Forms.Label piInstrumentTag;
        private System.Windows.Forms.Label piLocation5;
        private System.Windows.Forms.Label piLocation4;
        private System.Windows.Forms.Label piLocation3;
        private System.Windows.Forms.Label piLocation2;
        private System.Windows.Forms.Label piLocation1;
        private System.Windows.Forms.Label piCreator;
        private System.Windows.Forms.Label lbInstrumentTag;
        private System.Windows.Forms.Label lbLocation5;
        private System.Windows.Forms.Label piCreationDate;
        private System.Windows.Forms.Label piPointSource;
        private System.Windows.Forms.Label piPointType;
        private System.Windows.Forms.Label piEngUnits;
        private System.Windows.Forms.Label piDescriptor;
        private System.Windows.Forms.Label lbTagFound;
        private System.Windows.Forms.ListBox lbPIData;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label piCurrentTimestamp;
        private System.Windows.Forms.Label piCurrentValue;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.DataVisualization.Charting.Chart piDataChart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart afDataChart;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label8;
        private OSIsoft.AF.UI.PIServerPicker piServerPicker2;
        private System.Windows.Forms.Label lbPingResult;
        private System.Windows.Forms.Button btnPing;
        private System.Windows.Forms.DataVisualization.Charting.Chart pingResults;
        private System.Windows.Forms.Label lbPingFailure;
        private System.Windows.Forms.Label lbAverageReturnTime;
        private System.Windows.Forms.Label lbReturnTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lbMinReturnTime;
        private System.Windows.Forms.Label lbMaxReturnTime;
        private System.Windows.Forms.Label lbMinTime;
        private System.Windows.Forms.Label lbMaxTime;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbConnectionStatus;
        private System.Windows.Forms.Label lbConnectionStatusLabel;
        private System.Windows.Forms.Label lbAuthenticationStatus;
        private System.Windows.Forms.Label lbAuthenticationStatusLabel;
    }
}

