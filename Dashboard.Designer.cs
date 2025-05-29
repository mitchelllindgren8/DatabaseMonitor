namespace LiveStats
{
    partial class Dashboard
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
            tabControl1 = new TabControl();
            View = new TabPage();
            tlpMainTable = new TableLayoutPanel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Settings = new TabPage();
            panel6 = new Panel();
            panel4 = new Panel();
            plConnectionStringTypeStatus = new Panel();
            plConnectionStringStatus = new Panel();
            btnTestConnection = new Button();
            plTableStatus = new Panel();
            tbConnectionString = new TextBox();
            btnLoadTables = new Button();
            label12 = new Label();
            label10 = new Label();
            cbDatabases = new ComboBox();
            label11 = new Label();
            plBaseTableView = new Panel();
            plTableCheckBoxes = new Panel();
            plSpacer = new Panel();
            panel2 = new Panel();
            plDatabaseStatus = new Panel();
            tbServer = new TextBox();
            cbInstances = new ComboBox();
            btnLoadDatabases = new Button();
            label7 = new Label();
            label8 = new Label();
            panel1 = new Panel();
            plInstanceStatus = new Panel();
            label9 = new Label();
            btnLoadSSMS = new Button();
            panelSQLAuth = new Panel();
            tbDBusername = new TextBox();
            tbDBpassword = new TextBox();
            rbWindowsAuth = new RadioButton();
            rbSQLAuth = new RadioButton();
            label13 = new Label();
            panel3 = new Panel();
            panel5 = new Panel();
            btnLoadTableView = new Button();
            tabControl1.SuspendLayout();
            View.SuspendLayout();
            tlpMainTable.SuspendLayout();
            Settings.SuspendLayout();
            panel4.SuspendLayout();
            plBaseTableView.SuspendLayout();
            plTableCheckBoxes.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panelSQLAuth.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(View);
            tabControl1.Controls.Add(Settings);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(796, 679);
            tabControl1.TabIndex = 0;
            // 
            // View
            // 
            View.AutoScroll = true;
            View.Controls.Add(tlpMainTable);
            View.Location = new Point(4, 24);
            View.Name = "View";
            View.Padding = new Padding(3);
            View.Size = new Size(788, 651);
            View.TabIndex = 0;
            View.Text = "DatabaseView";
            View.UseVisualStyleBackColor = true;
            // 
            // tlpMainTable
            // 
            tlpMainTable.ColumnCount = 6;
            tlpMainTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tlpMainTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tlpMainTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tlpMainTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tlpMainTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tlpMainTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tlpMainTable.Controls.Add(label6, 0, 0);
            tlpMainTable.Controls.Add(label5, 0, 0);
            tlpMainTable.Controls.Add(label4, 3, 0);
            tlpMainTable.Controls.Add(label3, 2, 0);
            tlpMainTable.Controls.Add(label2, 1, 0);
            tlpMainTable.Controls.Add(label1, 0, 0);
            tlpMainTable.Location = new Point(5, 6);
            tlpMainTable.Name = "tlpMainTable";
            tlpMainTable.RowCount = 1;
            tlpMainTable.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMainTable.Size = new Size(778, 39);
            tlpMainTable.TabIndex = 0;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(274, 12);
            label6.Name = "label6";
            label6.Size = new Size(97, 15);
            label6.TabIndex = 5;
            label6.Text = "Record Average";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(152, 12);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 4;
            label5.Text = "Record Count";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(665, 12);
            label4.Name = "label4";
            label4.Size = new Size(93, 15);
            label4.TabIndex = 3;
            label4.Text = "Newest Record";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(537, 12);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 2;
            label3.Text = "Oldest Record";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(396, 12);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 1;
            label2.Text = "Record Difference";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(28, 12);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 0;
            label1.Text = "Table Name";
            // 
            // Settings
            // 
            Settings.Controls.Add(panel3);
            Settings.Controls.Add(label13);
            Settings.Controls.Add(panel6);
            Settings.Controls.Add(panel4);
            Settings.Controls.Add(label11);
            Settings.Controls.Add(plBaseTableView);
            Settings.Controls.Add(panel2);
            Settings.Controls.Add(panel1);
            Settings.Location = new Point(4, 24);
            Settings.Name = "Settings";
            Settings.Padding = new Padding(3);
            Settings.Size = new Size(788, 651);
            Settings.TabIndex = 1;
            Settings.Text = "Settings";
            Settings.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.BackColor = Color.DimGray;
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(703, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(82, 645);
            panel6.TabIndex = 22;
            // 
            // panel4
            // 
            panel4.AutoScroll = true;
            panel4.BackColor = Color.LightGray;
            panel4.Controls.Add(plConnectionStringTypeStatus);
            panel4.Controls.Add(plConnectionStringStatus);
            panel4.Controls.Add(btnTestConnection);
            panel4.Controls.Add(plTableStatus);
            panel4.Controls.Add(tbConnectionString);
            panel4.Controls.Add(btnLoadTables);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(cbDatabases);
            panel4.Location = new Point(14, 365);
            panel4.Name = "panel4";
            panel4.Size = new Size(297, 164);
            panel4.TabIndex = 21;
            // 
            // plConnectionStringTypeStatus
            // 
            plConnectionStringTypeStatus.BackColor = Color.DarkGray;
            plConnectionStringTypeStatus.BorderStyle = BorderStyle.FixedSingle;
            plConnectionStringTypeStatus.Location = new Point(100, 47);
            plConnectionStringTypeStatus.Name = "plConnectionStringTypeStatus";
            plConnectionStringTypeStatus.Size = new Size(34, 10);
            plConnectionStringTypeStatus.TabIndex = 26;
            // 
            // plConnectionStringStatus
            // 
            plConnectionStringStatus.BackColor = Color.DarkGray;
            plConnectionStringStatus.BorderStyle = BorderStyle.FixedSingle;
            plConnectionStringStatus.Location = new Point(118, 136);
            plConnectionStringStatus.Name = "plConnectionStringStatus";
            plConnectionStringStatus.Size = new Size(23, 23);
            plConnectionStringStatus.TabIndex = 25;
            // 
            // btnTestConnection
            // 
            btnTestConnection.BackColor = SystemColors.GradientActiveCaption;
            btnTestConnection.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTestConnection.Location = new Point(5, 136);
            btnTestConnection.Name = "btnTestConnection";
            btnTestConnection.Size = new Size(107, 23);
            btnTestConnection.TabIndex = 24;
            btnTestConnection.Text = "Test Connection";
            btnTestConnection.UseVisualStyleBackColor = false;
            btnTestConnection.Click += btnTestConnection_Click;
            // 
            // plTableStatus
            // 
            plTableStatus.BackColor = Color.DarkGray;
            plTableStatus.BorderStyle = BorderStyle.FixedSingle;
            plTableStatus.Location = new Point(269, 136);
            plTableStatus.Name = "plTableStatus";
            plTableStatus.Size = new Size(23, 23);
            plTableStatus.TabIndex = 21;
            // 
            // tbConnectionString
            // 
            tbConnectionString.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbConnectionString.Location = new Point(5, 61);
            tbConnectionString.Multiline = true;
            tbConnectionString.Name = "tbConnectionString";
            tbConnectionString.Size = new Size(287, 69);
            tbConnectionString.TabIndex = 22;
            tbConnectionString.TextChanged += tbConnectionString_TextChanged;
            // 
            // btnLoadTables
            // 
            btnLoadTables.BackColor = SystemColors.GradientActiveCaption;
            btnLoadTables.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoadTables.Location = new Point(156, 136);
            btnLoadTables.Name = "btnLoadTables";
            btnLoadTables.Size = new Size(107, 23);
            btnLoadTables.TabIndex = 18;
            btnLoadTables.Text = "Load Tables";
            btnLoadTables.UseVisualStyleBackColor = false;
            btnLoadTables.Click += btnLoadTables_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(3, 45);
            label12.Name = "label12";
            label12.Size = new Size(98, 13);
            label12.TabIndex = 23;
            label12.Text = "ConnectionString";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(5, 9);
            label10.Name = "label10";
            label10.Size = new Size(63, 13);
            label10.TabIndex = 17;
            label10.Text = "Databases:";
            // 
            // cbDatabases
            // 
            cbDatabases.FormattingEnabled = true;
            cbDatabases.Location = new Point(74, 8);
            cbDatabases.Name = "cbDatabases";
            cbDatabases.Size = new Size(218, 23);
            cbDatabases.TabIndex = 16;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(322, 6);
            label11.Name = "label11";
            label11.Size = new Size(112, 17);
            label11.TabIndex = 19;
            label11.Text = "Database Tables:";
            // 
            // plBaseTableView
            // 
            plBaseTableView.BackColor = Color.LightGray;
            plBaseTableView.Controls.Add(plTableCheckBoxes);
            plBaseTableView.Location = new Point(322, 30);
            plBaseTableView.Name = "plBaseTableView";
            plBaseTableView.Size = new Size(375, 615);
            plBaseTableView.TabIndex = 20;
            // 
            // plTableCheckBoxes
            // 
            plTableCheckBoxes.AutoScroll = true;
            plTableCheckBoxes.BackColor = Color.White;
            plTableCheckBoxes.Controls.Add(plSpacer);
            plTableCheckBoxes.Location = new Point(10, 10);
            plTableCheckBoxes.Name = "plTableCheckBoxes";
            plTableCheckBoxes.Size = new Size(355, 595);
            plTableCheckBoxes.TabIndex = 0;
            // 
            // plSpacer
            // 
            plSpacer.BackColor = Color.FromArgb(255, 192, 192);
            plSpacer.Dock = DockStyle.Bottom;
            plSpacer.Location = new Point(0, 582);
            plSpacer.Name = "plSpacer";
            plSpacer.Size = new Size(355, 13);
            plSpacer.TabIndex = 24;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(plDatabaseStatus);
            panel2.Controls.Add(tbServer);
            panel2.Controls.Add(cbInstances);
            panel2.Controls.Add(btnLoadDatabases);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label8);
            panel2.Location = new Point(14, 218);
            panel2.Name = "panel2";
            panel2.Size = new Size(297, 137);
            panel2.TabIndex = 19;
            // 
            // plDatabaseStatus
            // 
            plDatabaseStatus.BackColor = Color.DarkGray;
            plDatabaseStatus.BorderStyle = BorderStyle.FixedSingle;
            plDatabaseStatus.Location = new Point(210, 104);
            plDatabaseStatus.Name = "plDatabaseStatus";
            plDatabaseStatus.Size = new Size(23, 23);
            plDatabaseStatus.TabIndex = 20;
            // 
            // tbServer
            // 
            tbServer.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbServer.Location = new Point(23, 21);
            tbServer.Name = "tbServer";
            tbServer.Size = new Size(229, 25);
            tbServer.TabIndex = 6;
            tbServer.Text = "MITCHELLL7770";
            // 
            // cbInstances
            // 
            cbInstances.FormattingEnabled = true;
            cbInstances.Location = new Point(23, 75);
            cbInstances.Name = "cbInstances";
            cbInstances.Size = new Size(229, 23);
            cbInstances.TabIndex = 0;
            // 
            // btnLoadDatabases
            // 
            btnLoadDatabases.BackColor = SystemColors.GradientActiveCaption;
            btnLoadDatabases.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoadDatabases.Location = new Point(59, 104);
            btnLoadDatabases.Name = "btnLoadDatabases";
            btnLoadDatabases.Size = new Size(144, 23);
            btnLoadDatabases.TabIndex = 3;
            btnLoadDatabases.Text = "Load Database";
            btnLoadDatabases.UseVisualStyleBackColor = false;
            btnLoadDatabases.Click += btnLoadDatabases_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(9, 5);
            label7.Name = "label7";
            label7.Size = new Size(42, 13);
            label7.TabIndex = 12;
            label7.Text = "Server:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(9, 59);
            label8.Name = "label8";
            label8.Size = new Size(53, 13);
            label8.TabIndex = 13;
            label8.Text = "Instance:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(plInstanceStatus);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(btnLoadSSMS);
            panel1.Controls.Add(panelSQLAuth);
            panel1.Controls.Add(rbWindowsAuth);
            panel1.Controls.Add(rbSQLAuth);
            panel1.Location = new Point(14, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(297, 179);
            panel1.TabIndex = 15;
            // 
            // plInstanceStatus
            // 
            plInstanceStatus.BackColor = Color.DarkGray;
            plInstanceStatus.BorderStyle = BorderStyle.FixedSingle;
            plInstanceStatus.Location = new Point(210, 144);
            plInstanceStatus.Name = "plInstanceStatus";
            plInstanceStatus.Size = new Size(23, 23);
            plInstanceStatus.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(6, 58);
            label9.Name = "label9";
            label9.Size = new Size(91, 13);
            label9.TabIndex = 14;
            label9.Text = "SQL Credentials:";
            // 
            // btnLoadSSMS
            // 
            btnLoadSSMS.BackColor = SystemColors.GradientActiveCaption;
            btnLoadSSMS.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoadSSMS.Location = new Point(59, 144);
            btnLoadSSMS.Name = "btnLoadSSMS";
            btnLoadSSMS.Size = new Size(144, 23);
            btnLoadSSMS.TabIndex = 18;
            btnLoadSSMS.Text = "Load Instances";
            btnLoadSSMS.UseVisualStyleBackColor = false;
            btnLoadSSMS.Click += btnLoadSSMS_Click;
            // 
            // panelSQLAuth
            // 
            panelSQLAuth.BackColor = Color.DarkGray;
            panelSQLAuth.BorderStyle = BorderStyle.Fixed3D;
            panelSQLAuth.Controls.Add(tbDBusername);
            panelSQLAuth.Controls.Add(tbDBpassword);
            panelSQLAuth.Location = new Point(9, 74);
            panelSQLAuth.Name = "panelSQLAuth";
            panelSQLAuth.Size = new Size(256, 64);
            panelSQLAuth.TabIndex = 6;
            // 
            // tbDBusername
            // 
            tbDBusername.BackColor = Color.Silver;
            tbDBusername.Enabled = false;
            tbDBusername.Location = new Point(12, 4);
            tbDBusername.Name = "tbDBusername";
            tbDBusername.PlaceholderText = "Username";
            tbDBusername.Size = new Size(229, 23);
            tbDBusername.TabIndex = 4;
            // 
            // tbDBpassword
            // 
            tbDBpassword.BackColor = Color.Silver;
            tbDBpassword.Enabled = false;
            tbDBpassword.Location = new Point(12, 33);
            tbDBpassword.Name = "tbDBpassword";
            tbDBpassword.PlaceholderText = "Password";
            tbDBpassword.Size = new Size(229, 23);
            tbDBpassword.TabIndex = 5;
            // 
            // rbWindowsAuth
            // 
            rbWindowsAuth.AutoSize = true;
            rbWindowsAuth.Checked = true;
            rbWindowsAuth.Location = new Point(9, 7);
            rbWindowsAuth.Name = "rbWindowsAuth";
            rbWindowsAuth.Size = new Size(156, 19);
            rbWindowsAuth.TabIndex = 10;
            rbWindowsAuth.TabStop = true;
            rbWindowsAuth.Text = "Windows Authentication";
            rbWindowsAuth.UseVisualStyleBackColor = true;
            rbWindowsAuth.CheckedChanged += rbWindowsAuth_CheckedChanged;
            // 
            // rbSQLAuth
            // 
            rbSQLAuth.AutoSize = true;
            rbSQLAuth.Location = new Point(9, 32);
            rbSQLAuth.Name = "rbSQLAuth";
            rbSQLAuth.Size = new Size(163, 19);
            rbSQLAuth.TabIndex = 11;
            rbSQLAuth.Text = "SQL Server Authentication";
            rbSQLAuth.UseVisualStyleBackColor = true;
            rbSQLAuth.CheckedChanged += rbSQLAuth_CheckedChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(14, 6);
            label13.Name = "label13";
            label13.Size = new Size(165, 17);
            label13.TabIndex = 23;
            label13.Text = "Database Configurations:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGray;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(btnLoadTableView);
            panel3.Location = new Point(14, 612);
            panel3.Name = "panel3";
            panel3.Size = new Size(297, 33);
            panel3.TabIndex = 21;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkGray;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Location = new Point(267, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(23, 23);
            panel5.TabIndex = 20;
            // 
            // btnLoadTableView
            // 
            btnLoadTableView.BackColor = SystemColors.GradientActiveCaption;
            btnLoadTableView.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoadTableView.Location = new Point(117, 3);
            btnLoadTableView.Name = "btnLoadTableView";
            btnLoadTableView.Size = new Size(144, 23);
            btnLoadTableView.TabIndex = 3;
            btnLoadTableView.Text = "Load Table View";
            btnLoadTableView.UseVisualStyleBackColor = false;
            btnLoadTableView.Click += btnLoadTableView_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 679);
            Controls.Add(tabControl1);
            Name = "Dashboard";
            Text = "Dashboard";
            tabControl1.ResumeLayout(false);
            View.ResumeLayout(false);
            tlpMainTable.ResumeLayout(false);
            tlpMainTable.PerformLayout();
            Settings.ResumeLayout(false);
            Settings.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            plBaseTableView.ResumeLayout(false);
            plTableCheckBoxes.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelSQLAuth.ResumeLayout(false);
            panelSQLAuth.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage View;
        private TabPage Settings;
        private TableLayoutPanel tlpMainTable;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label5;
        private TextBox tbDBusername;
        private Button btnLoadDatabases;
        private ComboBox cbInstances;
        private TextBox tbDBpassword;
        private Panel panelSQLAuth;
        private RadioButton rbSQLAuth;
        private RadioButton rbWindowsAuth;
        private TextBox tbServer;
        private Label label8;
        private Label label7;
        private Label label9;
        private Panel panel1;
        private Label label10;
        private ComboBox cbDatabases;
        private Button btnLoadSSMS;
        private Button btnLoadTables;
        private Panel panel2;
        private Panel plBaseTableView;
        private Label label11;
        private Panel plInstanceStatus;
        private Panel plTableStatus;
        private Panel plDatabaseStatus;
        private Panel panel4;
        private TextBox tbConnectionString;
        private Label label12;
        private Panel plConnectionStringStatus;
        private Button btnTestConnection;
        private Panel plConnectionStringTypeStatus;
        private Panel plTableCheckBoxes;
        private Panel plSpacer;
        private Panel panel6;
        private Label label13;
        private Panel panel3;
        private Panel panel5;
        private Button btnLoadTableView;
    }
}
