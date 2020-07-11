namespace PresentationLayer
{
    partial class ClientManagementDepartment
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manipulateClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manipulateEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.tbContract = new System.Windows.Forms.TabControl();
            this.tbClients = new System.Windows.Forms.TabPage();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBankType = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.PreviousClient = new System.Windows.Forms.Button();
            this.NextClient = new System.Windows.Forms.Button();
            this.LastClient = new System.Windows.Forms.Button();
            this.FirstClient = new System.Windows.Forms.Button();
            this.tblManagement = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtBilling = new System.Windows.Forms.TextBox();
            this.txtAccNumber = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblOption = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.dgvClientManagement = new System.Windows.Forms.DataGridView();
            this.tbContractPage = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvContracts = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.tbContract.SuspendLayout();
            this.tbClients.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientManagement)).BeginInit();
            this.tbContractPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manipulateClientsToolStripMenuItem,
            this.manipulateEmployeesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(960, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manipulateClientsToolStripMenuItem
            // 
            this.manipulateClientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addClientsToolStripMenuItem,
            this.updateClientsToolStripMenuItem,
            this.deleteClientsToolStripMenuItem});
            this.manipulateClientsToolStripMenuItem.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manipulateClientsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.manipulateClientsToolStripMenuItem.Name = "manipulateClientsToolStripMenuItem";
            this.manipulateClientsToolStripMenuItem.Size = new System.Drawing.Size(190, 20);
            this.manipulateClientsToolStripMenuItem.Text = "Manipulate Clients";
            // 
            // addClientsToolStripMenuItem
            // 
            this.addClientsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.addClientsToolStripMenuItem.Name = "addClientsToolStripMenuItem";
            this.addClientsToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.addClientsToolStripMenuItem.Text = "Add Clients";
            this.addClientsToolStripMenuItem.Click += new System.EventHandler(this.addClientsToolStripMenuItem_Click);
            // 
            // updateClientsToolStripMenuItem
            // 
            this.updateClientsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.updateClientsToolStripMenuItem.Name = "updateClientsToolStripMenuItem";
            this.updateClientsToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.updateClientsToolStripMenuItem.Text = "Update Clients";
            this.updateClientsToolStripMenuItem.Click += new System.EventHandler(this.updateClientsToolStripMenuItem_Click);
            // 
            // deleteClientsToolStripMenuItem
            // 
            this.deleteClientsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.deleteClientsToolStripMenuItem.Name = "deleteClientsToolStripMenuItem";
            this.deleteClientsToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.deleteClientsToolStripMenuItem.Text = "Delete Clients";
            this.deleteClientsToolStripMenuItem.Click += new System.EventHandler(this.deleteClientsToolStripMenuItem_Click);
            // 
            // manipulateEmployeesToolStripMenuItem
            // 
            this.manipulateEmployeesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewEmployeesToolStripMenuItem,
            this.addEmployeesToolStripMenuItem,
            this.deleteEmployeesToolStripMenuItem,
            this.updateEmployeesToolStripMenuItem});
            this.manipulateEmployeesToolStripMenuItem.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manipulateEmployeesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.manipulateEmployeesToolStripMenuItem.Name = "manipulateEmployeesToolStripMenuItem";
            this.manipulateEmployeesToolStripMenuItem.Size = new System.Drawing.Size(217, 20);
            this.manipulateEmployeesToolStripMenuItem.Text = "Manipulate Employees";
            this.manipulateEmployeesToolStripMenuItem.Click += new System.EventHandler(this.manipulateEmployeesToolStripMenuItem_Click);
            // 
            // viewEmployeesToolStripMenuItem
            // 
            this.viewEmployeesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.viewEmployeesToolStripMenuItem.Name = "viewEmployeesToolStripMenuItem";
            this.viewEmployeesToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.viewEmployeesToolStripMenuItem.Text = "View Employees";
            this.viewEmployeesToolStripMenuItem.Click += new System.EventHandler(this.viewEmployeesToolStripMenuItem_Click);
            // 
            // addEmployeesToolStripMenuItem
            // 
            this.addEmployeesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.addEmployeesToolStripMenuItem.Name = "addEmployeesToolStripMenuItem";
            this.addEmployeesToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.addEmployeesToolStripMenuItem.Text = "Add Employees";
            this.addEmployeesToolStripMenuItem.Click += new System.EventHandler(this.addEmployeesToolStripMenuItem_Click);
            // 
            // deleteEmployeesToolStripMenuItem
            // 
            this.deleteEmployeesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.deleteEmployeesToolStripMenuItem.Name = "deleteEmployeesToolStripMenuItem";
            this.deleteEmployeesToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.deleteEmployeesToolStripMenuItem.Text = "Delete Employees";
            this.deleteEmployeesToolStripMenuItem.Click += new System.EventHandler(this.deleteEmployeesToolStripMenuItem_Click);
            // 
            // updateEmployeesToolStripMenuItem
            // 
            this.updateEmployeesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Highlight;
            this.updateEmployeesToolStripMenuItem.Name = "updateEmployeesToolStripMenuItem";
            this.updateEmployeesToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.updateEmployeesToolStripMenuItem.Text = "Update Employees ";
            this.updateEmployeesToolStripMenuItem.Click += new System.EventHandler(this.updateEmployeesToolStripMenuItem_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Font = new System.Drawing.Font("Algerian", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.Location = new System.Drawing.Point(885, 2);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(75, 38);
            this.btnMainMenu.TabIndex = 18;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // tbContract
            // 
            this.tbContract.Controls.Add(this.tbClients);
            this.tbContract.Controls.Add(this.tbContractPage);
            this.tbContract.Location = new System.Drawing.Point(0, 24);
            this.tbContract.Name = "tbContract";
            this.tbContract.SelectedIndex = 0;
            this.tbContract.Size = new System.Drawing.Size(960, 454);
            this.tbContract.TabIndex = 21;
            // 
            // tbClients
            // 
            this.tbClients.BackColor = System.Drawing.SystemColors.Highlight;
            this.tbClients.Controls.Add(this.btnViewAll);
            this.tbClients.Controls.Add(this.groupBox1);
            this.tbClients.Controls.Add(this.txtBankType);
            this.tbClients.Controls.Add(this.btnExit);
            this.tbClients.Controls.Add(this.btnBack);
            this.tbClients.Controls.Add(this.PreviousClient);
            this.tbClients.Controls.Add(this.NextClient);
            this.tbClients.Controls.Add(this.LastClient);
            this.tbClients.Controls.Add(this.FirstClient);
            this.tbClients.Controls.Add(this.tblManagement);
            this.tbClients.Controls.Add(this.txtStatus);
            this.tbClients.Controls.Add(this.txtBilling);
            this.tbClients.Controls.Add(this.txtAccNumber);
            this.tbClients.Controls.Add(this.lblSurname);
            this.tbClients.Controls.Add(this.lblOption);
            this.tbClients.Controls.Add(this.lblStatus);
            this.tbClients.Controls.Add(this.lblName);
            this.tbClients.Controls.Add(this.dgvClientManagement);
            this.tbClients.Location = new System.Drawing.Point(4, 22);
            this.tbClients.Name = "tbClients";
            this.tbClients.Padding = new System.Windows.Forms.Padding(3);
            this.tbClients.Size = new System.Drawing.Size(952, 428);
            this.tbClients.TabIndex = 0;
            this.tbClients.Text = "View Clients";
            this.tbClients.Click += new System.EventHandler(this.tbClients_Click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.BackColor = System.Drawing.Color.RosyBrown;
            this.btnViewAll.Font = new System.Drawing.Font("Algerian", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAll.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnViewAll.Location = new System.Drawing.Point(821, 180);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(75, 23);
            this.btnViewAll.TabIndex = 38;
            this.btnViewAll.Text = "View All";
            this.btnViewAll.UseVisualStyleBackColor = false;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(787, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 120);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client Search ";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(6, 51);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(125, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.RosyBrown;
            this.btnSearch.Font = new System.Drawing.Font("Algerian", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Location = new System.Drawing.Point(34, 77);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(64, 23);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(31, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Client ID";
            // 
            // txtBankType
            // 
            this.txtBankType.Location = new System.Drawing.Point(573, 226);
            this.txtBankType.Name = "txtBankType";
            this.txtBankType.Size = new System.Drawing.Size(179, 20);
            this.txtBankType.TabIndex = 36;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.RosyBrown;
            this.btnExit.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(694, 394);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(58, 23);
            this.btnExit.TabIndex = 35;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.RosyBrown;
            this.btnBack.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(19, 394);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(70, 23);
            this.btnBack.TabIndex = 34;
            this.btnBack.Text = "Back ";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // PreviousClient
            // 
            this.PreviousClient.BackColor = System.Drawing.Color.RosyBrown;
            this.PreviousClient.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviousClient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PreviousClient.Location = new System.Drawing.Point(230, 330);
            this.PreviousClient.Name = "PreviousClient";
            this.PreviousClient.Size = new System.Drawing.Size(100, 23);
            this.PreviousClient.TabIndex = 33;
            this.PreviousClient.Text = "<<";
            this.PreviousClient.UseVisualStyleBackColor = false;
            this.PreviousClient.Click += new System.EventHandler(this.PreviousClient_Click_1);
            // 
            // NextClient
            // 
            this.NextClient.BackColor = System.Drawing.Color.RosyBrown;
            this.NextClient.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextClient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NextClient.Location = new System.Drawing.Point(448, 330);
            this.NextClient.Name = "NextClient";
            this.NextClient.Size = new System.Drawing.Size(105, 23);
            this.NextClient.TabIndex = 32;
            this.NextClient.Text = ">>";
            this.NextClient.UseVisualStyleBackColor = false;
            this.NextClient.Click += new System.EventHandler(this.NextClient_Click_1);
            // 
            // LastClient
            // 
            this.LastClient.BackColor = System.Drawing.Color.RosyBrown;
            this.LastClient.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastClient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LastClient.Location = new System.Drawing.Point(656, 330);
            this.LastClient.Name = "LastClient";
            this.LastClient.Size = new System.Drawing.Size(96, 23);
            this.LastClient.TabIndex = 31;
            this.LastClient.Text = ">|";
            this.LastClient.UseVisualStyleBackColor = false;
            this.LastClient.Click += new System.EventHandler(this.LastClient_Click_1);
            // 
            // FirstClient
            // 
            this.FirstClient.BackColor = System.Drawing.Color.RosyBrown;
            this.FirstClient.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstClient.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FirstClient.Location = new System.Drawing.Point(20, 330);
            this.FirstClient.Name = "FirstClient";
            this.FirstClient.Size = new System.Drawing.Size(97, 23);
            this.FirstClient.TabIndex = 30;
            this.FirstClient.Text = "|<";
            this.FirstClient.UseVisualStyleBackColor = false;
            this.FirstClient.Click += new System.EventHandler(this.FirstClient_Click_1);
            // 
            // tblManagement
            // 
            this.tblManagement.AutoSize = true;
            this.tblManagement.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblManagement.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tblManagement.Location = new System.Drawing.Point(213, 12);
            this.tblManagement.Name = "tblManagement";
            this.tblManagement.Size = new System.Drawing.Size(287, 16);
            this.tblManagement.TabIndex = 29;
            this.tblManagement.Text = "Client Management Department";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(573, 270);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(179, 20);
            this.txtStatus.TabIndex = 28;
            // 
            // txtBilling
            // 
            this.txtBilling.Location = new System.Drawing.Point(166, 271);
            this.txtBilling.Name = "txtBilling";
            this.txtBilling.Size = new System.Drawing.Size(188, 20);
            this.txtBilling.TabIndex = 27;
            // 
            // txtAccNumber
            // 
            this.txtAccNumber.Location = new System.Drawing.Point(166, 230);
            this.txtAccNumber.Name = "txtAccNumber";
            this.txtAccNumber.Size = new System.Drawing.Size(188, 20);
            this.txtAccNumber.TabIndex = 26;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSurname.Location = new System.Drawing.Point(16, 275);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(113, 16);
            this.lblSurname.TabIndex = 25;
            this.lblSurname.Text = "Biiling Type";
            // 
            // lblOption
            // 
            this.lblOption.AutoSize = true;
            this.lblOption.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOption.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOption.Location = new System.Drawing.Point(432, 224);
            this.lblOption.Name = "lblOption";
            this.lblOption.Size = new System.Drawing.Size(98, 16);
            this.lblOption.TabIndex = 24;
            this.lblOption.Text = "Bank Type";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStatus.Location = new System.Drawing.Point(432, 271);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(135, 16);
            this.lblStatus.TabIndex = 23;
            this.lblStatus.Text = "Billing Status";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Algerian", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblName.Location = new System.Drawing.Point(16, 234);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(149, 16);
            this.lblName.TabIndex = 22;
            this.lblName.Text = "Account Number";
            // 
            // dgvClientManagement
            // 
            this.dgvClientManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientManagement.Location = new System.Drawing.Point(20, 35);
            this.dgvClientManagement.Name = "dgvClientManagement";
            this.dgvClientManagement.Size = new System.Drawing.Size(732, 168);
            this.dgvClientManagement.TabIndex = 21;
            // 
            // tbContractPage
            // 
            this.tbContractPage.BackColor = System.Drawing.SystemColors.Highlight;
            this.tbContractPage.Controls.Add(this.label2);
            this.tbContractPage.Controls.Add(this.dgvContracts);
            this.tbContractPage.Location = new System.Drawing.Point(4, 22);
            this.tbContractPage.Name = "tbContractPage";
            this.tbContractPage.Padding = new System.Windows.Forms.Padding(3);
            this.tbContractPage.Size = new System.Drawing.Size(952, 428);
            this.tbContractPage.TabIndex = 1;
            this.tbContractPage.Text = "View Contracts";
            this.tbContractPage.Click += new System.EventHandler(this.tbContractPage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(342, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clients\' Contract";
            // 
            // dgvContracts
            // 
            this.dgvContracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContracts.Location = new System.Drawing.Point(49, 126);
            this.dgvContracts.Name = "dgvContracts";
            this.dgvContracts.Size = new System.Drawing.Size(882, 215);
            this.dgvContracts.TabIndex = 0;
            // 
            // ClientManagementDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(960, 476);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.tbContract);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ClientManagementDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client Management Department";
            this.Load += new System.EventHandler(this.ClientManagementDepartment_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tbContract.ResumeLayout(false);
            this.tbClients.ResumeLayout(false);
            this.tbClients.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientManagement)).EndInit();
            this.tbContractPage.ResumeLayout(false);
            this.tbContractPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manipulateClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manipulateEmployeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEmployeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteEmployeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateEmployeesToolStripMenuItem;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.ToolStripMenuItem viewEmployeesToolStripMenuItem;
        private System.Windows.Forms.TabControl tbContract;
        private System.Windows.Forms.TabPage tbClients;
        private System.Windows.Forms.TabPage tbContractPage;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBankType;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button PreviousClient;
        private System.Windows.Forms.Button NextClient;
        private System.Windows.Forms.Button LastClient;
        private System.Windows.Forms.Button FirstClient;
        private System.Windows.Forms.Label tblManagement;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtBilling;
        private System.Windows.Forms.TextBox txtAccNumber;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblOption;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView dgvClientManagement;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvContracts;
    }
}