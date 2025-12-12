namespace HumanitarianProjectManagement.Forms
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlMainContainer = new System.Windows.Forms.Panel();
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.pnlDashboardCards = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlQuickStats = new System.Windows.Forms.Panel();
            this.lblQuickStatsTitle = new System.Windows.Forms.Label();
            this.pnlStatsCards = new System.Windows.Forms.Panel();
            this.pnlProjectsCard = new System.Windows.Forms.Panel();
            this.lblProjectsCount = new System.Windows.Forms.Label();
            this.lblProjectsLabel = new System.Windows.Forms.Label();
            this.pnlBeneficiariesCard = new System.Windows.Forms.Panel();
            this.lblBeneficiariesCount = new System.Windows.Forms.Label();
            this.lblBeneficiariesLabel = new System.Windows.Forms.Label();
            this.pnlBudgetCard = new System.Windows.Forms.Panel();
            this.lblBudgetAmount = new System.Windows.Forms.Label();
            this.lblBudgetLabel = new System.Windows.Forms.Label();
            this.pnlWelcomeSection = new System.Windows.Forms.Panel();
            this.lblWelcomeTitle = new System.Windows.Forms.Label();
            this.lblWelcomeSubtitle = new System.Windows.Forms.Label();
            this.pnlQuickActions = new System.Windows.Forms.Panel();
            this.lblQuickActionsTitle = new System.Windows.Forms.Label();
            this.pnlActionButtons = new System.Windows.Forms.Panel();
            this.btnNewProject = new System.Windows.Forms.Button();
            this.btnViewReports = new System.Windows.Forms.Button();
            this.btnManageBeneficiaries = new System.Windows.Forms.Button();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlSidebarHeader = new System.Windows.Forms.Panel();
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.btnToggleSidebar = new System.Windows.Forms.Button();
            this.pnlNavigation = new System.Windows.Forms.Panel();
            this.pnlSectionsGroup = new System.Windows.Forms.Panel();
            this.lblSectionsTitle = new System.Windows.Forms.Label();
            this.tvwSections = new System.Windows.Forms.TreeView();
            this.btnAddSection = new System.Windows.Forms.Button();
            this.pnlModulesGroup = new System.Windows.Forms.Panel();
            this.lblModulesTitle = new System.Windows.Forms.Label();
            this.flpModuleButtons = new System.Windows.Forms.FlowLayoutPanel();

            this.mainMenuStrip.SuspendLayout();
            this.mainStatusStrip.SuspendLayout();
            this.pnlMainContainer.SuspendLayout();
            this.pnlMainContent.SuspendLayout();
            this.pnlDashboardCards.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlQuickStats.SuspendLayout();
            this.pnlStatsCards.SuspendLayout();
            this.pnlProjectsCard.SuspendLayout();
            this.pnlBeneficiariesCard.SuspendLayout();
            this.pnlBudgetCard.SuspendLayout();
            this.pnlWelcomeSection.SuspendLayout();
            this.pnlQuickActions.SuspendLayout();
            this.pnlActionButtons.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.pnlSidebarHeader.SuspendLayout();
            this.pnlNavigation.SuspendLayout();
            this.pnlSectionsGroup.SuspendLayout();
            this.pnlModulesGroup.SuspendLayout();
            this.SuspendLayout();

            // mainMenuStrip
            //
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(1264, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "mainMenuStrip";
            //
            // fileToolStripMenuItem
            //
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            //
            // settingsToolStripMenuItem
            //
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "&Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            //
            // exitToolStripMenuItem
            //
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            //
            // helpToolStripMenuItem
            //
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            //
            // aboutToolStripMenuItem
            //
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            //
            // mainStatusStrip
            //
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 659);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Size = new System.Drawing.Size(1264, 22);
            this.mainStatusStrip.TabIndex = 1;
            this.mainStatusStrip.Text = "statusStrip1";
            //
            // statusLabel
            //
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(39, 17);
            this.statusLabel.Text = "Ready";
            //
            // pnlMainContainer
            //
            this.pnlMainContainer.Controls.Add(this.pnlMainContent);
            this.pnlMainContainer.Controls.Add(this.pnlSidebar);
            this.pnlMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContainer.Location = new System.Drawing.Point(0, 24);
            this.pnlMainContainer.Name = "pnlMainContainer";
            this.pnlMainContainer.Size = new System.Drawing.Size(1264, 635);
            this.pnlMainContainer.TabIndex = 2;
            //
            // pnlMainContent
            //
            this.pnlMainContent.Controls.Add(this.pnlDashboardCards);
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Location = new System.Drawing.Point(280, 0);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Padding = new System.Windows.Forms.Padding(30);
            this.pnlMainContent.Size = new System.Drawing.Size(984, 635);
            this.pnlMainContent.TabIndex = 1;
            //
            // pnlDashboardCards
            //
            this.pnlDashboardCards.AutoScroll = true;
            this.pnlDashboardCards.Controls.Add(this.tableLayoutPanel1);
            this.pnlDashboardCards.Controls.Add(this.pnlWelcomeSection);
            this.pnlDashboardCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashboardCards.Location = new System.Drawing.Point(30, 30);
            this.pnlDashboardCards.Name = "pnlDashboardCards";
            this.pnlDashboardCards.Size = new System.Drawing.Size(924, 575);
            this.pnlDashboardCards.TabIndex = 0;
            //
            // tableLayoutPanel1
            //
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pnlQuickStats, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlQuickActions, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 120);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(924, 455);
            this.tableLayoutPanel1.TabIndex = 3;
            //
            // pnlQuickStats
            //
            this.pnlQuickStats.Controls.Add(this.lblQuickStatsTitle);
            this.pnlQuickStats.Controls.Add(this.pnlStatsCards);
            this.pnlQuickStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlQuickStats.Location = new System.Drawing.Point(10, 10);
            this.pnlQuickStats.Margin = new System.Windows.Forms.Padding(10);
            this.pnlQuickStats.Name = "pnlQuickStats";
            this.pnlQuickStats.Size = new System.Drawing.Size(442, 435);
            this.pnlQuickStats.TabIndex = 1;
            //
            // lblQuickStatsTitle
            //
            this.lblQuickStatsTitle.AutoSize = true;
            this.lblQuickStatsTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblQuickStatsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblQuickStatsTitle.Location = new System.Drawing.Point(15, 15);
            this.lblQuickStatsTitle.Name = "lblQuickStatsTitle";
            this.lblQuickStatsTitle.Size = new System.Drawing.Size(98, 21);
            this.lblQuickStatsTitle.TabIndex = 0;
            this.lblQuickStatsTitle.Text = "Quick Stats";
            //
            // pnlStatsCards
            //
            this.pnlStatsCards.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlStatsCards.Controls.Add(this.pnlProjectsCard);
            this.pnlStatsCards.Controls.Add(this.pnlBeneficiariesCard);
            this.pnlStatsCards.Controls.Add(this.pnlBudgetCard);
            this.pnlStatsCards.Location = new System.Drawing.Point(15, 50);
            this.pnlStatsCards.Name = "pnlStatsCards";
            this.pnlStatsCards.Size = new System.Drawing.Size(412, 120);
            this.pnlStatsCards.TabIndex = 1;
            //
            // pnlProjectsCard
            //
            this.pnlProjectsCard.Controls.Add(this.lblProjectsCount);
            this.pnlProjectsCard.Controls.Add(this.lblProjectsLabel);
            this.pnlProjectsCard.Location = new System.Drawing.Point(0, 0);
            this.pnlProjectsCard.Name = "pnlProjectsCard";
            this.pnlProjectsCard.Size = new System.Drawing.Size(125, 120);
            this.pnlProjectsCard.TabIndex = 0;
            //
            // lblProjectsCount
            //
            this.lblProjectsCount.AutoSize = true;
            this.lblProjectsCount.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblProjectsCount.ForeColor = System.Drawing.Color.White;
            this.lblProjectsCount.Location = new System.Drawing.Point(20, 20);
            this.lblProjectsCount.Name = "lblProjectsCount";
            this.lblProjectsCount.Size = new System.Drawing.Size(23, 25);
            this.lblProjectsCount.TabIndex = 0;
            this.lblProjectsCount.Text = "0";
            //
            // lblProjectsLabel
            //
            this.lblProjectsLabel.AutoSize = true;
            this.lblProjectsLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblProjectsLabel.ForeColor = System.Drawing.Color.White;
            this.lblProjectsLabel.Location = new System.Drawing.Point(20, 60);
            this.lblProjectsLabel.Name = "lblProjectsLabel";
            this.lblProjectsLabel.Size = new System.Drawing.Size(58, 19);
            this.lblProjectsLabel.TabIndex = 1;
            this.lblProjectsLabel.Text = "Projects";
            //
            // pnlBeneficiariesCard
            //
            this.pnlBeneficiariesCard.Controls.Add(this.lblBeneficiariesCount);
            this.pnlBeneficiariesCard.Controls.Add(this.lblBeneficiariesLabel);
            this.pnlBeneficiariesCard.Location = new System.Drawing.Point(145, 0);
            this.pnlBeneficiariesCard.Name = "pnlBeneficiariesCard";
            this.pnlBeneficiariesCard.Size = new System.Drawing.Size(125, 120);
            this.pnlBeneficiariesCard.TabIndex = 1;
            //
            // lblBeneficiariesCount
            //
            this.lblBeneficiariesCount.AutoSize = true;
            this.lblBeneficiariesCount.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblBeneficiariesCount.ForeColor = System.Drawing.Color.White;
            this.lblBeneficiariesCount.Location = new System.Drawing.Point(20, 20);
            this.lblBeneficiariesCount.Name = "lblBeneficiariesCount";
            this.lblBeneficiariesCount.Size = new System.Drawing.Size(23, 25);
            this.lblBeneficiariesCount.TabIndex = 0;
            this.lblBeneficiariesCount.Text = "0";
            //
            // lblBeneficiariesLabel
            //
            this.lblBeneficiariesLabel.AutoSize = true;
            this.lblBeneficiariesLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBeneficiariesLabel.ForeColor = System.Drawing.Color.White;
            this.lblBeneficiariesLabel.Location = new System.Drawing.Point(20, 60);
            this.lblBeneficiariesLabel.Name = "lblBeneficiariesLabel";
            this.lblBeneficiariesLabel.Size = new System.Drawing.Size(86, 19);
            this.lblBeneficiariesLabel.TabIndex = 1;
            this.lblBeneficiariesLabel.Text = "Beneficiaries";
            //
            // pnlBudgetCard
            //
            this.pnlBudgetCard.Controls.Add(this.lblBudgetAmount);
            this.pnlBudgetCard.Controls.Add(this.lblBudgetLabel);
            this.pnlBudgetCard.Location = new System.Drawing.Point(290, 0);
            this.pnlBudgetCard.Name = "pnlBudgetCard";
            this.pnlBudgetCard.Size = new System.Drawing.Size(125, 120);
            this.pnlBudgetCard.TabIndex = 2;
            //
            // lblBudgetAmount
            //
            this.lblBudgetAmount.AutoSize = true;
            this.lblBudgetAmount.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblBudgetAmount.ForeColor = System.Drawing.Color.White;
            this.lblBudgetAmount.Location = new System.Drawing.Point(20, 20);
            this.lblBudgetAmount.Name = "lblBudgetAmount";
            this.lblBudgetAmount.Size = new System.Drawing.Size(34, 25);
            this.lblBudgetAmount.TabIndex = 0;
            this.lblBudgetAmount.Text = "$0";
            //
            // lblBudgetLabel
            //
            this.lblBudgetLabel.AutoSize = true;
            this.lblBudgetLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBudgetLabel.ForeColor = System.Drawing.Color.White;
            this.lblBudgetLabel.Location = new System.Drawing.Point(20, 60);
            this.lblBudgetLabel.Name = "lblBudgetLabel";
            this.lblBudgetLabel.Size = new System.Drawing.Size(53, 19);
            this.lblBudgetLabel.TabIndex = 1;
            this.lblBudgetLabel.Text = "Budget";
            //
            // pnlWelcomeSection
            //
            this.pnlWelcomeSection.Controls.Add(this.lblWelcomeTitle);
            this.pnlWelcomeSection.Controls.Add(this.lblWelcomeSubtitle);
            this.pnlWelcomeSection.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlWelcomeSection.Location = new System.Drawing.Point(0, 0);
            this.pnlWelcomeSection.Name = "pnlWelcomeSection";
            this.pnlWelcomeSection.Padding = new System.Windows.Forms.Padding(20);
            this.pnlWelcomeSection.Size = new System.Drawing.Size(924, 120);
            this.pnlWelcomeSection.TabIndex = 0;
            //
            // lblWelcomeTitle
            //
            this.lblWelcomeTitle.AutoSize = true;
            this.lblWelcomeTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblWelcomeTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblWelcomeTitle.Location = new System.Drawing.Point(20, 20);
            this.lblWelcomeTitle.Name = "lblWelcomeTitle";
            this.lblWelcomeTitle.Size = new System.Drawing.Size(176, 30);
            this.lblWelcomeTitle.TabIndex = 0;
            this.lblWelcomeTitle.Text = "Welcome, User!";
            //
            // lblWelcomeSubtitle
            //
            this.lblWelcomeSubtitle.AutoSize = true;
            this.lblWelcomeSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblWelcomeSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblWelcomeSubtitle.Location = new System.Drawing.Point(20, 60);
            this.lblWelcomeSubtitle.Name = "lblWelcomeSubtitle";
            this.lblWelcomeSubtitle.Size = new System.Drawing.Size(262, 19);
            this.lblWelcomeSubtitle.TabIndex = 1;
            this.lblWelcomeSubtitle.Text = "Your central hub for managing projects.";
            //
            // pnlQuickActions
            //
            this.pnlQuickActions.Controls.Add(this.lblQuickActionsTitle);
            this.pnlQuickActions.Controls.Add(this.pnlActionButtons);
            this.pnlQuickActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlQuickActions.Location = new System.Drawing.Point(472, 10);
            this.pnlQuickActions.Margin = new System.Windows.Forms.Padding(10);
            this.pnlQuickActions.Name = "pnlQuickActions";
            this.pnlQuickActions.Size = new System.Drawing.Size(442, 435);
            this.pnlQuickActions.TabIndex = 2;
            //
            // lblQuickActionsTitle
            //
            this.lblQuickActionsTitle.AutoSize = true;
            this.lblQuickActionsTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblQuickActionsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.lblQuickActionsTitle.Location = new System.Drawing.Point(15, 15);
            this.lblQuickActionsTitle.Name = "lblQuickActionsTitle";
            this.lblQuickActionsTitle.Size = new System.Drawing.Size(117, 21);
            this.lblQuickActionsTitle.TabIndex = 0;
            this.lblQuickActionsTitle.Text = "Quick Actions";
            //
            // pnlActionButtons
            //
            this.pnlActionButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlActionButtons.Controls.Add(this.btnNewProject);
            this.pnlActionButtons.Controls.Add(this.btnViewReports);
            this.pnlActionButtons.Controls.Add(this.btnManageBeneficiaries);
            this.pnlActionButtons.Location = new System.Drawing.Point(15, 50);
            this.pnlActionButtons.Name = "pnlActionButtons";
            this.pnlActionButtons.Size = new System.Drawing.Size(412, 100);
            this.pnlActionButtons.TabIndex = 1;
            //
            // btnNewProject
            //
            this.btnNewProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnNewProject.FlatAppearance.BorderSize = 0;
            this.btnNewProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewProject.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnNewProject.ForeColor = System.Drawing.Color.White;
            this.btnNewProject.Location = new System.Drawing.Point(0, 0);
            this.btnNewProject.Name = "btnNewProject";
            this.btnNewProject.Size = new System.Drawing.Size(125, 40);
            this.btnNewProject.TabIndex = 0;
            this.btnNewProject.Text = "🚀 New Project";
            this.btnNewProject.UseVisualStyleBackColor = false;
            this.btnNewProject.Click += new System.EventHandler(this.btnNewProject_Click);
            //
            // btnViewReports
            //
            this.btnViewReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnViewReports.FlatAppearance.BorderSize = 0;
            this.btnViewReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewReports.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnViewReports.ForeColor = System.Drawing.Color.White;
            this.btnViewReports.Location = new System.Drawing.Point(145, 0);
            this.btnViewReports.Name = "btnViewReports";
            this.btnViewReports.Size = new System.Drawing.Size(125, 40);
            this.btnViewReports.TabIndex = 1;
            this.btnViewReports.Text = "📊 View Reports";
            this.btnViewReports.UseVisualStyleBackColor = false;
            this.btnViewReports.Click += new System.EventHandler(this.btnViewReports_Click);
            //
            // btnManageBeneficiaries
            //
            this.btnManageBeneficiaries.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.btnManageBeneficiaries.FlatAppearance.BorderSize = 0;
            this.btnManageBeneficiaries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageBeneficiaries.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnManageBeneficiaries.ForeColor = System.Drawing.Color.White;
            this.btnManageBeneficiaries.Location = new System.Drawing.Point(290, 0);
            this.btnManageBeneficiaries.Name = "btnManageBeneficiaries";
            this.btnManageBeneficiaries.Size = new System.Drawing.Size(125, 40);
            this.btnManageBeneficiaries.TabIndex = 2;
            this.btnManageBeneficiaries.Text = "👥 Beneficiaries";
            this.btnManageBeneficiaries.UseVisualStyleBackColor = false;
            this.btnManageBeneficiaries.Click += new System.EventHandler(this.btnManageBeneficiaries_Click);
            //
            // pnlSidebar
            //
            this.pnlSidebar.Controls.Add(this.pnlNavigation);
            this.pnlSidebar.Controls.Add(this.pnlSidebarHeader);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(280, 635);
            this.pnlSidebar.TabIndex = 0;
            //
            // pnlSidebarHeader
            //
            this.pnlSidebarHeader.Controls.Add(this.lblAppTitle);
            this.pnlSidebarHeader.Controls.Add(this.btnToggleSidebar);
            this.pnlSidebarHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSidebarHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebarHeader.Name = "pnlSidebarHeader";
            this.pnlSidebarHeader.Size = new System.Drawing.Size(280, 60);
            this.pnlSidebarHeader.TabIndex = 0;
            //
            // lblAppTitle
            //
            this.lblAppTitle.AutoSize = true;
            this.lblAppTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblAppTitle.ForeColor = System.Drawing.Color.White;
            this.lblAppTitle.Location = new System.Drawing.Point(20, 20);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(107, 21);
            this.lblAppTitle.TabIndex = 0;
            this.lblAppTitle.Text = "ProjectHope";
            //
            // btnToggleSidebar
            //
            this.btnToggleSidebar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToggleSidebar.FlatAppearance.BorderSize = 0;
            this.btnToggleSidebar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleSidebar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnToggleSidebar.ForeColor = System.Drawing.Color.White;
            this.btnToggleSidebar.Location = new System.Drawing.Point(230, 10);
            this.btnToggleSidebar.Name = "btnToggleSidebar";
            this.btnToggleSidebar.Size = new System.Drawing.Size(40, 40);
            this.btnToggleSidebar.TabIndex = 1;
            this.btnToggleSidebar.Text = "≡";
            this.btnToggleSidebar.UseVisualStyleBackColor = true;
            this.btnToggleSidebar.Click += new System.EventHandler(this.btnToggleSidebar_Click);
            //
            // pnlNavigation
            //
            this.pnlNavigation.Controls.Add(this.pnlModulesGroup);
            this.pnlNavigation.Controls.Add(this.pnlSectionsGroup);
            this.pnlNavigation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNavigation.Location = new System.Drawing.Point(0, 60);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Padding = new System.Windows.Forms.Padding(15);
            this.pnlNavigation.Size = new System.Drawing.Size(280, 575);
            this.pnlNavigation.TabIndex = 1;
            //
            // pnlSectionsGroup
            //
            this.pnlSectionsGroup.Controls.Add(this.lblSectionsTitle);
            this.pnlSectionsGroup.Controls.Add(this.tvwSections);
            this.pnlSectionsGroup.Controls.Add(this.btnAddSection);
            this.pnlSectionsGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSectionsGroup.Location = new System.Drawing.Point(15, 15);
            this.pnlSectionsGroup.Name = "pnlSectionsGroup";
            this.pnlSectionsGroup.Size = new System.Drawing.Size(250, 250);
            this.pnlSectionsGroup.TabIndex = 0;
            //
            // lblSectionsTitle
            //
            this.lblSectionsTitle.AutoSize = true;
            this.lblSectionsTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSectionsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.lblSectionsTitle.Location = new System.Drawing.Point(0, 0);
            this.lblSectionsTitle.Name = "lblSectionsTitle";
            this.lblSectionsTitle.Size = new System.Drawing.Size(65, 19);
            this.lblSectionsTitle.TabIndex = 0;
            this.lblSectionsTitle.Text = "Sections";
            //
            // tvwSections
            //
            this.tvwSections.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvwSections.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.tvwSections.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvwSections.ForeColor = System.Drawing.Color.White;
            this.tvwSections.Location = new System.Drawing.Point(0, 30);
            this.tvwSections.Name = "tvwSections";
            this.tvwSections.Size = new System.Drawing.Size(250, 160);
            this.tvwSections.TabIndex = 1;
            this.tvwSections.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwSections_AfterSelect);
            //
            // btnAddSection
            //
            this.btnAddSection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnAddSection.FlatAppearance.BorderSize = 0;
            this.btnAddSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSection.ForeColor = System.Drawing.Color.White;
            this.btnAddSection.Location = new System.Drawing.Point(0, 200);
            this.btnAddSection.Name = "btnAddSection";
            this.btnAddSection.Size = new System.Drawing.Size(250, 35);
            this.btnAddSection.TabIndex = 2;
            this.btnAddSection.Text = "+ Add Section";
            this.btnAddSection.UseVisualStyleBackColor = false;
            this.btnAddSection.Click += new System.EventHandler(this.btnAddSection_Click);
            //
            // pnlModulesGroup
            //
            this.pnlModulesGroup.Controls.Add(this.lblModulesTitle);
            this.pnlModulesGroup.Controls.Add(this.flpModuleButtons);
            this.pnlModulesGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlModulesGroup.Location = new System.Drawing.Point(15, 265);
            this.pnlModulesGroup.Name = "pnlModulesGroup";
            this.pnlModulesGroup.Size = new System.Drawing.Size(250, 250);
            this.pnlModulesGroup.TabIndex = 1;
            //
            // lblModulesTitle
            //
            this.lblModulesTitle.AutoSize = true;
            this.lblModulesTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblModulesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.lblModulesTitle.Location = new System.Drawing.Point(0, 15);
            this.lblModulesTitle.Name = "lblModulesTitle";
            this.lblModulesTitle.Size = new System.Drawing.Size(67, 19);
            this.lblModulesTitle.TabIndex = 0;
            this.lblModulesTitle.Text = "Modules";
            //
            // flpModuleButtons
            //
            this.flpModuleButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpModuleButtons.Location = new System.Drawing.Point(0, 45);
            this.flpModuleButtons.Name = "flpModuleButtons";
            this.flpModuleButtons.Size = new System.Drawing.Size(250, 205);
            this.flpModuleButtons.TabIndex = 1;

            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pnlQuickStats, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlQuickActions, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 120);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(860, 456);
            this.tableLayoutPanel1.TabIndex = 3;

            // 
            // pnlDashboardCards
            // 
            this.pnlDashboardCards.AutoScroll = true;
            this.pnlDashboardCards.Controls.Add(this.tableLayoutPanel1);
            this.pnlDashboardCards.Controls.Add(this.pnlWelcomeSection);
            this.pnlDashboardCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashboardCards.Location = new System.Drawing.Point(30, 30);
            this.pnlDashboardCards.Name = "pnlDashboardCards";
            this.pnlDashboardCards.Size = new System.Drawing.Size(860, 576);
            this.pnlDashboardCards.TabIndex = 0;

            // ... The rest of the designer file is the same
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pnlMainContainer);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "DashboardForm";
            this.Text = "Humanitarian Project Management Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DashboardForm_FormClosing);

            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.pnlMainContainer.ResumeLayout(false);
            this.pnlMainContent.ResumeLayout(false);
            this.pnlDashboardCards.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlQuickStats.ResumeLayout(false);
            this.pnlQuickStats.PerformLayout();
            this.pnlStatsCards.ResumeLayout(false);
            this.pnlProjectsCard.ResumeLayout(false);
            this.pnlProjectsCard.PerformLayout();
            this.pnlBeneficiariesCard.ResumeLayout(false);
            this.pnlBeneficiariesCard.PerformLayout();
            this.pnlBudgetCard.ResumeLayout(false);
            this.pnlBudgetCard.PerformLayout();
            this.pnlWelcomeSection.ResumeLayout(false);
            this.pnlWelcomeSection.PerformLayout();
            this.pnlQuickActions.ResumeLayout(false);
            this.pnlQuickActions.PerformLayout();
            this.pnlActionButtons.ResumeLayout(false);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebarHeader.ResumeLayout(false);
            this.pnlSidebarHeader.PerformLayout();
            this.pnlNavigation.ResumeLayout(false);
            this.pnlSectionsGroup.ResumeLayout(false);
            this.pnlSectionsGroup.PerformLayout();
            this.pnlModulesGroup.ResumeLayout(false);
            this.pnlModulesGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip mainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Panel pnlMainContainer;
        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.Panel pnlDashboardCards;
        private System.Windows.Forms.Panel pnlQuickStats;
        private System.Windows.Forms.Label lblQuickStatsTitle;
        private System.Windows.Forms.Panel pnlStatsCards;
        private System.Windows.Forms.Panel pnlProjectsCard;
        private System.Windows.Forms.Label lblProjectsCount;
        private System.Windows.Forms.Label lblProjectsLabel;
        private System.Windows.Forms.Panel pnlBeneficiariesCard;
        private System.Windows.Forms.Label lblBeneficiariesCount;
        private System.Windows.Forms.Label lblBeneficiariesLabel;
        private System.Windows.Forms.Panel pnlBudgetCard;
        private System.Windows.Forms.Label lblBudgetAmount;
        private System.Windows.Forms.Label lblBudgetLabel;
        private System.Windows.Forms.Panel pnlWelcomeSection;
        private System.Windows.Forms.Label lblWelcomeTitle;
        private System.Windows.Forms.Label lblWelcomeSubtitle;
        private System.Windows.Forms.Panel pnlQuickActions;
        private System.Windows.Forms.Label lblQuickActionsTitle;
        private System.Windows.Forms.Panel pnlActionButtons;
        private System.Windows.Forms.Button btnNewProject;
        private System.Windows.Forms.Button btnViewReports;
        private System.Windows.Forms.Button btnManageBeneficiaries;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlSidebarHeader;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.Button btnToggleSidebar;
        private System.Windows.Forms.Panel pnlNavigation;
        private System.Windows.Forms.Panel pnlSectionsGroup;
        private System.Windows.Forms.Label lblSectionsTitle;
        private System.Windows.Forms.TreeView tvwSections;
        private System.Windows.Forms.Button btnAddSection;
        private System.Windows.Forms.Panel pnlModulesGroup;
        private System.Windows.Forms.Label lblModulesTitle;
        private System.Windows.Forms.FlowLayoutPanel flpModuleButtons;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
