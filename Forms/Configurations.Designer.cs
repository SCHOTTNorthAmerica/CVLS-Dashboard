using SCHOTT.WinForms.Controls.Group_Boxes;

namespace SCHOTT.CVLS.Dashboard.Forms
{
    partial class Configurations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configurations));
            this.scrollPanel = new System.Windows.Forms.Panel();
            this.mainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ControlsTable = new System.Windows.Forms.TableLayoutPanel();
            this.PersistentMemory = new GrowGroupbox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.settingsRestore = new System.Windows.Forms.Button();
            this.settingsSave = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.FactoryDefaults = new GrowGroupbox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.factoryPreserveNetwork = new System.Windows.Forms.Button();
            this.factoryRestoreAll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ImportExport = new GrowGroupbox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.importINI = new System.Windows.Forms.Button();
            this.exportINI = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.UserLevel = new GrowGroupbox();
            this.tableLayoutPanel21 = new System.Windows.Forms.TableLayoutPanel();
            this.label56 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.Connection = new GrowGroupbox();
            this.tableLayoutPanel26 = new System.Windows.Forms.TableLayoutPanel();
            this.label59 = new System.Windows.Forms.Label();
            this.scrollPanel.SuspendLayout();
            this.mainLayoutPanel.SuspendLayout();
            this.ControlsTable.SuspendLayout();
            this.PersistentMemory.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.FactoryDefaults.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.ImportExport.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.UserLevel.SuspendLayout();
            this.tableLayoutPanel21.SuspendLayout();
            this.Connection.SuspendLayout();
            this.tableLayoutPanel26.SuspendLayout();
            this.SuspendLayout();
            // 
            // scrollPanel
            // 
            this.scrollPanel.AutoScroll = true;
            this.scrollPanel.Controls.Add(this.mainLayoutPanel);
            this.scrollPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollPanel.Location = new System.Drawing.Point(0, 0);
            this.scrollPanel.Name = "scrollPanel";
            this.scrollPanel.Size = new System.Drawing.Size(847, 470);
            this.scrollPanel.TabIndex = 0;
            // 
            // mainLayoutPanel
            // 
            this.mainLayoutPanel.AutoSize = true;
            this.mainLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainLayoutPanel.ColumnCount = 1;
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayoutPanel.Controls.Add(this.ControlsTable, 0, 2);
            this.mainLayoutPanel.Controls.Add(this.UserLevel, 0, 0);
            this.mainLayoutPanel.Controls.Add(this.Connection, 0, 1);
            this.mainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainLayoutPanel.Margin = new System.Windows.Forms.Padding(1);
            this.mainLayoutPanel.Name = "mainLayoutPanel";
            this.mainLayoutPanel.Padding = new System.Windows.Forms.Padding(1);
            this.mainLayoutPanel.RowCount = 3;
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainLayoutPanel.Size = new System.Drawing.Size(830, 513);
            this.mainLayoutPanel.TabIndex = 0;
            // 
            // ControlsTable
            // 
            this.ControlsTable.AutoSize = true;
            this.ControlsTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ControlsTable.ColumnCount = 1;
            this.ControlsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ControlsTable.Controls.Add(this.PersistentMemory, 0, 0);
            this.ControlsTable.Controls.Add(this.FactoryDefaults, 0, 2);
            this.ControlsTable.Controls.Add(this.ImportExport, 0, 1);
            this.ControlsTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.ControlsTable.Location = new System.Drawing.Point(1, 166);
            this.ControlsTable.Margin = new System.Windows.Forms.Padding(0);
            this.ControlsTable.Name = "ControlsTable";
            this.ControlsTable.RowCount = 3;
            this.ControlsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ControlsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ControlsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ControlsTable.Size = new System.Drawing.Size(828, 346);
            this.ControlsTable.TabIndex = 1;
            // 
            // PersistentMemory
            // 
            this.PersistentMemory.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PersistentMemory.Controls.Add(this.tableLayoutPanel1);
            this.PersistentMemory.Dock = System.Windows.Forms.DockStyle.Top;
            this.PersistentMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersistentMemory.Location = new System.Drawing.Point(3, 3);
            this.PersistentMemory.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.PersistentMemory.Name = "PersistentMemory";
            this.PersistentMemory.Padding = new System.Windows.Forms.Padding(7);
            this.PersistentMemory.Size = new System.Drawing.Size(822, 111);
            this.PersistentMemory.TabIndex = 4;
            this.PersistentMemory.TabStop = false;
            this.PersistentMemory.Text = "Persistent Memory";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.settingsRestore, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.settingsSave, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(808, 76);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // settingsRestore
            // 
            this.settingsRestore.AutoSize = true;
            this.settingsRestore.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.settingsRestore.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsRestore.Location = new System.Drawing.Point(407, 48);
            this.settingsRestore.MinimumSize = new System.Drawing.Size(0, 25);
            this.settingsRestore.Name = "settingsRestore";
            this.settingsRestore.Size = new System.Drawing.Size(398, 25);
            this.settingsRestore.TabIndex = 0;
            this.settingsRestore.Text = "Restore";
            this.settingsRestore.UseVisualStyleBackColor = true;
            this.settingsRestore.Click += new System.EventHandler(this.settingsRestore_Click);
            // 
            // settingsSave
            // 
            this.settingsSave.AutoSize = true;
            this.settingsSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.settingsSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsSave.Location = new System.Drawing.Point(3, 48);
            this.settingsSave.MinimumSize = new System.Drawing.Size(0, 25);
            this.settingsSave.Name = "settingsSave";
            this.settingsSave.Size = new System.Drawing.Size(398, 25);
            this.settingsSave.TabIndex = 0;
            this.settingsSave.Text = "Save";
            this.settingsSave.UseVisualStyleBackColor = true;
            this.settingsSave.Click += new System.EventHandler(this.settingsSave_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label14, 2);
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 3);
            this.label14.Margin = new System.Windows.Forms.Padding(3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(802, 39);
            this.label14.TabIndex = 5;
            this.label14.Text = resources.GetString("label14.Text");
            // 
            // FactoryDefaults
            // 
            this.FactoryDefaults.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FactoryDefaults.Controls.Add(this.tableLayoutPanel2);
            this.FactoryDefaults.Dock = System.Windows.Forms.DockStyle.Top;
            this.FactoryDefaults.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FactoryDefaults.Location = new System.Drawing.Point(3, 251);
            this.FactoryDefaults.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.FactoryDefaults.Name = "FactoryDefaults";
            this.FactoryDefaults.Padding = new System.Windows.Forms.Padding(7);
            this.FactoryDefaults.Size = new System.Drawing.Size(822, 85);
            this.FactoryDefaults.TabIndex = 5;
            this.FactoryDefaults.TabStop = false;
            this.FactoryDefaults.Text = "Factory Defaults";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.factoryPreserveNetwork, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.factoryRestoreAll, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(7, 20);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(808, 50);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // factoryPreserveNetwork
            // 
            this.factoryPreserveNetwork.AutoSize = true;
            this.factoryPreserveNetwork.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.factoryPreserveNetwork.Dock = System.Windows.Forms.DockStyle.Top;
            this.factoryPreserveNetwork.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.factoryPreserveNetwork.Location = new System.Drawing.Point(407, 22);
            this.factoryPreserveNetwork.MinimumSize = new System.Drawing.Size(0, 25);
            this.factoryPreserveNetwork.Name = "factoryPreserveNetwork";
            this.factoryPreserveNetwork.Size = new System.Drawing.Size(398, 25);
            this.factoryPreserveNetwork.TabIndex = 0;
            this.factoryPreserveNetwork.Text = "Preserve Network";
            this.factoryPreserveNetwork.UseVisualStyleBackColor = true;
            this.factoryPreserveNetwork.Click += new System.EventHandler(this.factoryPreserveNetwork_Click);
            // 
            // factoryRestoreAll
            // 
            this.factoryRestoreAll.AutoSize = true;
            this.factoryRestoreAll.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.factoryRestoreAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.factoryRestoreAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.factoryRestoreAll.Location = new System.Drawing.Point(3, 22);
            this.factoryRestoreAll.MinimumSize = new System.Drawing.Size(0, 25);
            this.factoryRestoreAll.Name = "factoryRestoreAll";
            this.factoryRestoreAll.Size = new System.Drawing.Size(398, 25);
            this.factoryRestoreAll.TabIndex = 0;
            this.factoryRestoreAll.Text = "Restore All";
            this.factoryRestoreAll.UseVisualStyleBackColor = true;
            this.factoryRestoreAll.Click += new System.EventHandler(this.factoryRestoreAll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(802, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "The buttons in this section will restore the unit to factory defaults. Using the " +
    "\"Preserve Network\" will not overwrite the current network settings with factory " +
    "defaults.";
            // 
            // ImportExport
            // 
            this.ImportExport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ImportExport.Controls.Add(this.tableLayoutPanel3);
            this.ImportExport.Dock = System.Windows.Forms.DockStyle.Top;
            this.ImportExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportExport.Location = new System.Drawing.Point(3, 127);
            this.ImportExport.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.ImportExport.Name = "ImportExport";
            this.ImportExport.Padding = new System.Windows.Forms.Padding(7);
            this.ImportExport.Size = new System.Drawing.Size(822, 111);
            this.ImportExport.TabIndex = 5;
            this.ImportExport.TabStop = false;
            this.ImportExport.Text = "Import / Export";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.importINI, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.exportINI, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(7, 20);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(808, 76);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // importINI
            // 
            this.importINI.AutoSize = true;
            this.importINI.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.importINI.Dock = System.Windows.Forms.DockStyle.Top;
            this.importINI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importINI.Location = new System.Drawing.Point(407, 48);
            this.importINI.MinimumSize = new System.Drawing.Size(0, 25);
            this.importINI.Name = "importINI";
            this.importINI.Size = new System.Drawing.Size(398, 25);
            this.importINI.TabIndex = 0;
            this.importINI.Text = "Import";
            this.importINI.UseVisualStyleBackColor = true;
            this.importINI.Click += new System.EventHandler(this.importINI_Click);
            // 
            // exportINI
            // 
            this.exportINI.AutoSize = true;
            this.exportINI.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exportINI.Dock = System.Windows.Forms.DockStyle.Top;
            this.exportINI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportINI.Location = new System.Drawing.Point(3, 48);
            this.exportINI.MinimumSize = new System.Drawing.Size(0, 25);
            this.exportINI.Name = "exportINI";
            this.exportINI.Size = new System.Drawing.Size(398, 25);
            this.exportINI.TabIndex = 0;
            this.exportINI.Text = "Export";
            this.exportINI.UseVisualStyleBackColor = true;
            this.exportINI.Click += new System.EventHandler(this.exportINI_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tableLayoutPanel3.SetColumnSpan(this.label2, 2);
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(802, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // UserLevel
            // 
            this.UserLevel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UserLevel.Controls.Add(this.tableLayoutPanel21);
            this.UserLevel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLevel.Location = new System.Drawing.Point(4, 4);
            this.UserLevel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.UserLevel.Name = "UserLevel";
            this.UserLevel.Padding = new System.Windows.Forms.Padding(7);
            this.UserLevel.Size = new System.Drawing.Size(822, 85);
            this.UserLevel.TabIndex = 6;
            this.UserLevel.TabStop = false;
            this.UserLevel.Text = "Authentication Required";
            this.UserLevel.Visible = false;
            // 
            // tableLayoutPanel21
            // 
            this.tableLayoutPanel21.AutoSize = true;
            this.tableLayoutPanel21.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel21.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel21.ColumnCount = 1;
            this.tableLayoutPanel21.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel21.Controls.Add(this.label56, 0, 0);
            this.tableLayoutPanel21.Controls.Add(this.login, 0, 1);
            this.tableLayoutPanel21.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel21.Location = new System.Drawing.Point(7, 20);
            this.tableLayoutPanel21.Name = "tableLayoutPanel21";
            this.tableLayoutPanel21.RowCount = 2;
            this.tableLayoutPanel21.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel21.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel21.Size = new System.Drawing.Size(808, 50);
            this.tableLayoutPanel21.TabIndex = 2;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label56.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.Location = new System.Drawing.Point(3, 3);
            this.label56.Margin = new System.Windows.Forms.Padding(3);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(802, 13);
            this.label56.TabIndex = 5;
            this.label56.Text = "You must be logged with a minimum of \"Admin\" rights to view the controls on this " +
    "page. Click the login button below to use this page.";
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.login.Dock = System.Windows.Forms.DockStyle.Top;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Location = new System.Drawing.Point(3, 22);
            this.login.MinimumSize = new System.Drawing.Size(0, 25);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(802, 25);
            this.login.TabIndex = 6;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // Connection
            // 
            this.Connection.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Connection.Controls.Add(this.tableLayoutPanel26);
            this.Connection.Dock = System.Windows.Forms.DockStyle.Top;
            this.Connection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connection.Location = new System.Drawing.Point(4, 102);
            this.Connection.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.Connection.Name = "Connection";
            this.Connection.Padding = new System.Windows.Forms.Padding(7);
            this.Connection.Size = new System.Drawing.Size(822, 54);
            this.Connection.TabIndex = 7;
            this.Connection.TabStop = false;
            this.Connection.Text = "Connection Required";
            this.Connection.Visible = false;
            // 
            // tableLayoutPanel26
            // 
            this.tableLayoutPanel26.AutoSize = true;
            this.tableLayoutPanel26.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel26.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel26.ColumnCount = 1;
            this.tableLayoutPanel26.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel26.Controls.Add(this.label59, 0, 0);
            this.tableLayoutPanel26.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel26.Location = new System.Drawing.Point(7, 20);
            this.tableLayoutPanel26.Name = "tableLayoutPanel26";
            this.tableLayoutPanel26.RowCount = 1;
            this.tableLayoutPanel26.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel26.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel26.Size = new System.Drawing.Size(808, 19);
            this.tableLayoutPanel26.TabIndex = 2;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label59.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.Location = new System.Drawing.Point(3, 3);
            this.label59.Margin = new System.Windows.Forms.Padding(3);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(802, 13);
            this.label59.TabIndex = 5;
            this.label59.Text = "You must be connected to a unit with USB or Ethernet to display controls on this " +
    "page.";
            // 
            // Configurations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 470);
            this.Controls.Add(this.scrollPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HideOnClose = true;
            this.Name = "Configurations";
            this.Text = "Configurations";
            this.Load += new System.EventHandler(this.form_Load);
            this.VisibleChanged += new System.EventHandler(this.formConfigurations_VisibleChanged);
            this.scrollPanel.ResumeLayout(false);
            this.scrollPanel.PerformLayout();
            this.mainLayoutPanel.ResumeLayout(false);
            this.mainLayoutPanel.PerformLayout();
            this.ControlsTable.ResumeLayout(false);
            this.PersistentMemory.ResumeLayout(false);
            this.PersistentMemory.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.FactoryDefaults.ResumeLayout(false);
            this.FactoryDefaults.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ImportExport.ResumeLayout(false);
            this.ImportExport.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.UserLevel.ResumeLayout(false);
            this.UserLevel.PerformLayout();
            this.tableLayoutPanel21.ResumeLayout(false);
            this.tableLayoutPanel21.PerformLayout();
            this.Connection.ResumeLayout(false);
            this.Connection.PerformLayout();
            this.tableLayoutPanel26.ResumeLayout(false);
            this.tableLayoutPanel26.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel scrollPanel;
        private System.Windows.Forms.TableLayoutPanel mainLayoutPanel;
        private GrowGroupbox PersistentMemory; //grow
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button settingsRestore;
        private System.Windows.Forms.Button settingsSave;
        private System.Windows.Forms.Label label14;
        private GrowGroupbox FactoryDefaults; //grow
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button factoryPreserveNetwork;
        private System.Windows.Forms.Button factoryRestoreAll;
        private System.Windows.Forms.Label label1;
        private GrowGroupbox ImportExport; //grow
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button importINI;
        private System.Windows.Forms.Button exportINI;
        private System.Windows.Forms.Label label2;
        private GrowGroupbox UserLevel; //grow
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel21;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Button login;
        private GrowGroupbox Connection; //grow
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel26;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.TableLayoutPanel ControlsTable;
    }
}