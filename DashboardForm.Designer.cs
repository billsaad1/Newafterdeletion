namespace HumanitarianProjectManagement.Forms
{
    partial class DashboardForm
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
            this.tlpMainContent = new System.Windows.Forms.TableLayoutPanel();
            this.pnlWelcomeSection = new System.Windows.Forms.Panel();
            this.lblWelcomeSubtitle = new System.Windows.Forms.Label();
            this.lblWelcomeTitle = new System.Windows.Forms.Label();
            this.pnlQuickStats = new System.Windows.Forms.Panel();
            this.flpStatsCards = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlProjectsCard = new System.Windows.Forms.Panel();
            this.lblProjectsLabel = new System.Windows.Forms.Label();
            this.lblProjectsCount = new System.Windows.Forms.Label();
            this.pnlBeneficiariesCard = new System.Windows.Forms.Panel();
            this.lblBeneficiariesLabel = new System.Windows.Forms.Label();
            this.lblBeneficiariesCount = new System.Windows.Forms.Label();
            this.pnlBudgetCard = new System.Windows.Forms.Panel();
            this.lblBudgetLabel = new System.Windows.Forms.Label();
            this.lblBudgetAmount = new System.Windows.Forms.Label();
            this.lblQuickStatsTitle = new System.Windows.Forms.Label();
            this.pnlQuickActions = new System.Windows.Forms.Panel();
            this.flpActionButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNewProject = new System.Windows.Forms.Button();
            this.btnViewReports = new System.Windows.Forms.Button();
            this.btnManageBeneficiaries = new System.Windows.Forms.Button();
            this.lblQuickActionsTitle = new System.Windows.Forms.Label();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlNavigation = new System.Windows.Forms.Panel();
            this.pnlModulesGroup = new System.Windows.Forms.Panel();
            this.flpModuleButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.lblModulesTitle = new System.Windows.Forms.Label();
            this.pnlSectionsGroup = new System.Windows.Forms.Panel();
            this.btnAddSection = new System.Windows.Forms.Button();
            this.tvwSections = new System.Windows.Forms.TreeView();
            this.lblSectionsTitle = new System.Windows.Forms.Label();
            this.pnlSidebarHeader = new System.Windows.Forms.Panel();
            this.btnToggleSidebar = new System.Windows.Forms.Button();
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.mainMenuStrip.SuspendLayout();
            this.mainStatusStrip.SuspendLayout();
            this.pnlMainContainer.SuspendLayout();
            this.pnlMainContent.SuspendLayout();
            this.tlpMainContent.SuspendLayout();
            this.pnlWelcomeSection.SuspendLayout();
            this.pnlQuickStats.SuspendLayout();
            this.flpStatsCards.SuspendLayout();
            this.pnlProjectsCard.SuspendLayout();
            this.pnlBeneficiariesCard.SuspendLayout();
            this.pnlBudgetCard.SuspendLayout();
            this.pnlQuickActions.SuspendLayout();
            this.flpActionButtons.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.pnlNavigation.SuspendLayout();
            this.pnlModulesGroup.SuspendLayout();
            this.pnlSectionsGroup.SuspendLayout();
            this.pnlSidebarHeader.SuspendLayout();
            this.SuspendLayout();
            //
            // mainMenuStrip
            //
            this.mainMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.mainMenuStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Padding = new System.Windows.Forms.Padding(8, 4, 0, 4);
            this.mainMenuStrip.Size = new System.Drawing.Size(1200, 32);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            //
            // fileToolStripMenuItem
            //
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 24);
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
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
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
            this.mainStatusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.mainStatusStrip.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.mainStatusStrip.Location = new System.Drawing.Point(0, 668);
            this.mainStatusStrip.Name = "mainStatusStrip";
            this.mainStatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.mainStatusStrip.Size = new System.Drawing.Size(1200, 22);
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
            this.pnlMainContainer.Location = new System.Drawing.Point(0, 32);
            this.pnlMainContainer.Name = "pnlMainContainer";
            this.pnlMainContainer.Size = new System.Drawing.Size(1200, 636);
            this.pnlMainContainer.TabIndex = 2;
            //
            // pnlMainContent
            //
            this.pnlMainContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.pnlMainContent.Controls.Add(this.tlpMainContent);
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Location = new System.Drawing.Point(280, 0);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Padding = new System.Windows.Forms.Padding(30);
            this.pnlMainContent.Size = new System.Drawing.Size(920, 636);
            this.pnlMainContent.TabIndex = 1;
            //
            // tlpMainContent
            //
            this.tlpMainContent.ColumnCount = 1;
            this.tlpMainContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainContent.Controls.Add(this.pnlWelcomeSection, 0, 0);
            this.tlpMainContent.Controls.Add(this.pnlQuickStats, 0, 1);
            this.tlpMainContent.Controls.Add(this.pnlQuickActions, 0, 2);
            this.tlpMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMainContent.Location = new System.Drawing.Point(30, 30);
            this.tlpMainContent.Name = "tlpMainContent";
            this.tlpMainContent.RowCount = 4;
            this.tlpMainContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpMainContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlpMainContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tlpMainContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainContent.Size = new System.Drawing.Size(860, 576);
            this.tlpMainContent.TabIndex = 0;
            //
            // pnlWelcomeSection
            //
            this.pnlWelcomeSection.BackColor = System.Drawing.Color.White;
            this.pnlWelcomeSection.Controls.Add(this.lblWelcomeSubtitle);
            this.pnlWelcomeSection.Controls.Add(this.lblWelcomeTitle);
            this.pnlWelcomeSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWelcomeSection.Location = new System.Drawing.Point(0, 0);
            this.pnlWelcomeSection.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.pnlWelcomeSection.Name = "pnlWelcomeSection";
            this.pnlWelcomeSection.Padding = new System.Windows.Forms.Padding(30);
            this.pnlWelcomeSection.Size = new System.Drawing.Size(860, 100);
            this.pnlWelcomeSection.TabIndex = 0;
            //
            // lblWelcomeSubtitle
            //
            this.lblWelcomeSubtitle.AutoSize = true;
            this.lblWelcomeSubtitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblWelcomeSubtitle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblWelcomeSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblWelcomeSubtitle.Location = new System.Drawing.Point(30, 75);
            this.lblWelcomeSubtitle.Name = "lblWelcomeSubtitle";
            this.lblWelcomeSubtitle.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.lblWelcomeSubtitle.Size = new System.Drawing.Size(434, 29);
            this.lblWelcomeSubtitle.TabIndex = 1;
            this.lblWelcomeSubtitle.Text = "Manage your humanitarian projects efficiently and effectively";
            //
            // lblWelcomeTitle
            //
            this.lblWelcomeTitle.AutoSize = true;
            this.lblWelcomeTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblWelcomeTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblWelcomeTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblWelcomeTitle.Location = new System.Drawing.Point(30, 30);
            this.lblWelcomeTitle.Name = "lblWelcomeTitle";
            this.lblWelcomeTitle.Size = new System.Drawing.Size(174, 45);
            this.lblWelcomeTitle.TabIndex = 0;
            this.lblWelcomeTitle.Text = "Welcome";
            //
            // pnlQuickStats
            //
            this.pnlQuickStats.BackColor = System.Drawing.Color.White;
            this.pnlQuickStats.Controls.Add(this.flpStatsCards);
            this.pnlQuickStats.Controls.Add(this.lblQuickStatsTitle);
            this.pnlQuickStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlQuickStats.Location = new System.Drawing.Point(0, 140);
            this.pnlQuickStats.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.pnlQuickStats.Name = "pnlQuickStats";
            this.pnlQuickStats.Padding = new System.Windows.Forms.Padding(30);
            this.pnlQuickStats.Size = new System.Drawing.Size(860, 180);
            this.pnlQuickStats.TabIndex = 1;
            //
            // flpStatsCards
            //
            this.flpStatsCards.Controls.Add(this.pnlProjectsCard);
            this.flpStatsCards.Controls.Add(this.pnlBeneficiariesCard);
            this.flpStatsCards.Controls.Add(this.pnlBudgetCard);
            this.flpStatsCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpStatsCards.Location = new System.Drawing.Point(30, 80);
            this.flpStatsCards.Name = "flpStatsCards";
            this.flpStatsCards.Size = new System.Drawing.Size(800, 70);
            this.flpStatsCards.TabIndex = 1;
            this.flpStatsCards.WrapContents = true;
            //
            // pnlProjectsCard
            //
            this.pnlProjectsCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.pnlProjectsCard.Controls.Add(this.lblProjectsLabel);
            this.pnlProjectsCard.Controls.Add(this.lblProjectsCount);
            this.pnlProjectsCard.Location = new System.Drawing.Point(0, 0);
            this.pnlProjectsCard.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.pnlProjectsCard.Name = "pnlProjectsCard";
            this.pnlProjectsCard.Padding = new System.Windows.Forms.Padding(20);
            this.pnlProjectsCard.Size = new System.Drawing.Size(250, 90);
            this.pnlProjectsCard.TabIndex = 0;
            //
            // lblProjectsLabel
            //
            this.lblProjectsLabel.AutoSize = true;
            this.lblProjectsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProjectsLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblProjectsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(254)))));
            this.lblProjectsLabel.Location = new System.Drawing.Point(20, 57);
            this.lblProjectsLabel.Name = "lblProjectsLabel";
            this.lblProjectsLabel.Size = new System.Drawing.Size(88, 19);
            this.lblProjectsLabel.TabIndex = 1;
            this.lblProjectsLabel.Text = "Total Projects";
            //
            // lblProjectsCount
            //
            this.lblProjectsCount.AutoSize = true;
            this.lblProjectsCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblProjectsCount.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblProjectsCount.ForeColor = System.Drawing.Color.White;
            this.lblProjectsCount.Location = new System.Drawing.Point(20, 20);
            this.lblProjectsCount.Name = "lblProjectsCount";
            this.lblProjectsCount.Size = new System.Drawing.Size(32, 37);
            this.lblProjectsCount.TabIndex = 0;
            this.lblProjectsCount.Text = "0";
            //
            // pnlBeneficiariesCard
            //
            this.pnlBeneficiariesCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.pnlBeneficiariesCard.Controls.Add(this.lblBeneficiariesLabel);
            this.pnlBeneficiariesCard.Controls.Add(this.lblBeneficiariesCount);
            this.pnlBeneficiariesCard.Location = new System.Drawing.Point(270, 0);
            this.pnlBeneficiariesCard.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.pnlBeneficiariesCard.Name = "pnlBeneficiariesCard";
            this.pnlBeneficiariesCard.Padding = new System.Windows.Forms.Padding(20);
            this.pnlBeneficiariesCard.Size = new System.Drawing.Size(250, 90);
            this.pnlBeneficiariesCard.TabIndex = 1;
            //
            // lblBeneficiariesLabel
            //
            this.lblBeneficiariesLabel.AutoSize = true;
            this.lblBeneficiariesLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBeneficiariesLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBeneficiariesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(243)))), ((int)(((byte)(208)))));
            this.lblBeneficiariesLabel.Location = new System.Drawing.Point(20, 57);
            this.lblBeneficiariesLabel.Name = "lblBeneficiariesLabel";
            this.lblBeneficiariesLabel.Size = new System.Drawing.Size(84, 19);
            this.lblBeneficiariesLabel.TabIndex = 1;
            this.lblBeneficiariesLabel.Text = "Beneficiaries";
            //
            // lblBeneficiariesCount
            //
            this.lblBeneficiariesCount.AutoSize = true;
            this.lblBeneficiariesCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBeneficiariesCount.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblBeneficiariesCount.ForeColor = System.Drawing.Color.White;
            this.lblBeneficiariesCount.Location = new System.Drawing.Point(20, 20);
            this.lblBeneficiariesCount.Name = "lblBeneficiariesCount";
            this.lblBeneficiariesCount.Size = new System.Drawing.Size(32, 37);
            this.lblBeneficiariesCount.TabIndex = 0;
            this.lblBeneficiariesCount.Text = "0";
            //
            // pnlBudgetCard
            //
            this.pnlBudgetCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.pnlBudgetCard.Controls.Add(this.lblBudgetLabel);
            this.pnlBudgetCard.Controls.Add(this.lblBudgetAmount);
            this.pnlBudgetCard.Location = new System.Drawing.Point(540, 0);
            this.pnlBudgetCard.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.pnlBudgetCard.Name = "pnlBudgetCard";
            this.pnlBudgetCard.Padding = new System.Windows.Forms.Padding(20);
            this.pnlBudgetCard.Size = new System.Drawing.Size(250, 90);
            this.pnlBudgetCard.TabIndex = 2;
            //
            // lblBudgetLabel
            //
            this.lblBudgetLabel.AutoSize = true;
            this.lblBudgetLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBudgetLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBudgetLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(215)))), ((int)(((byte)(170)))));
            this.lblBudgetLabel.Location = new System.Drawing.Point(20, 57);
            this.lblBudgetLabel.Name = "lblBudgetLabel";
            this.lblBudgetLabel.Size = new System.Drawing.Size(84, 19);
            this.lblBudgetLabel.TabIndex = 1;
            this.lblBudgetLabel.Text = "Total Budget";
            //
            // lblBudgetAmount
            //
            this.lblBudgetAmount.AutoSize = true;
            this.lblBudgetAmount.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBudgetAmount.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblBudgetAmount.ForeColor = System.Drawing.Color.White;
            this.lblBudgetAmount.Location = new System.Drawing.Point(20, 20);
            this.lblBudgetAmount.Name = "lblBudgetAmount";
            this.lblBudgetAmount.Size = new System.Drawing.Size(32, 37);
            this.lblBudgetAmount.TabIndex = 0;
            this.lblBudgetAmount.Text = "$0";
            //
            // lblQuickStatsTitle
            //
            this.lblQuickStatsTitle.AutoSize = true;
            this.lblQuickStatsTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblQuickStatsTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblQuickStatsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblQuickStatsTitle.Location = new System.Drawing.Point(30, 30);
            this.lblQuickStatsTitle.Name = "lblQuickStatsTitle";
            this.lblQuickStatsTitle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.lblQuickStatsTitle.Size = new System.Drawing.Size(134, 50);
            this.lblQuickStatsTitle.TabIndex = 0;
            this.lblQuickStatsTitle.Text = "Quick Stats";
            //
            // pnlQuickActions
            //
            this.pnlQuickActions.BackColor = System.Drawing.Color.White;
            this.pnlQuickActions.Controls.Add(this.flpActionButtons);
            this.pnlQuickActions.Controls.Add(this.lblQuickActionsTitle);
            this.pnlQuickActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlQuickActions.Location = new System.Drawing.Point(0, 340);
            this.pnlQuickActions.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.pnlQuickActions.Name = "pnlQuickActions";
            this.pnlQuickActions.Padding = new System.Windows.Forms.Padding(30);
            this.pnlQuickActions.Size = new System.Drawing.Size(860, 160);
            this.pnlQuickActions.TabIndex = 2;
            //
            // flpActionButtons
            //
            this.flpActionButtons.Controls.Add(this.btnNewProject);
            this.flpActionButtons.Controls.Add(this.btnViewReports);
            this.flpActionButtons.Controls.Add(this.btnManageBeneficiaries);
            this.flpActionButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpActionButtons.Location = new System.Drawing.Point(30, 80);
            this.flpActionButtons.Name = "flpActionButtons";
            this.flpActionButtons.Size = new System.Drawing.Size(800, 50);
            this.flpActionButtons.TabIndex = 1;
            //
            // btnNewProject
            //
            this.btnNewProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnNewProject.FlatAppearance.BorderSize = 0;
            this.btnNewProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewProject.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnNewProject.ForeColor = System.Drawing.Color.White;
            this.btnNewProject.Location = new System.Drawing.Point(0, 0);
            this.btnNewProject.Margin = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnNewProject.Name = "btnNewProject";
            this.btnNewProject.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnNewProject.Size = new System.Drawing.Size(180, 70);
            this.btnNewProject.TabIndex = 0;
            this.btnNewProject.Text = "📋 New Project";
            this.btnNewProject.UseVisualStyleBackColor = false;
            this.btnNewProject.Click += new System.EventHandler(this.btnNewProject_Click);
            //
            // btnViewReports
            //
            this.btnViewReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btnViewReports.FlatAppearance.BorderSize = 0;
            this.btnViewReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewReports.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnViewReports.ForeColor = System.Drawing.Color.White;
            this.btnViewReports.Location = new System.Drawing.Point(200, 0);
            this.btnViewReports.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnViewReports.Name = "btnViewReports";
            this.btnViewReports.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnViewReports.Size = new System.Drawing.Size(180, 70);
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
            this.btnManageBeneficiaries.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnManageBeneficiaries.ForeColor = System.Drawing.Color.White;
            this.btnManageBeneficiaries.Location = new System.Drawing.Point(400, 0);
            this.btnManageBeneficiaries.Margin = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnManageBeneficiaries.Name = "btnManageBeneficiaries";
            this.btnManageBeneficiaries.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnManageBeneficiaries.Size = new System.Drawing.Size(200, 70);
            this.btnManageBeneficiaries.TabIndex = 2;
            this.btnManageBeneficiaries.Text = "👥 Manage Beneficiaries";
            this.btnManageBeneficiaries.UseVisualStyleBackColor = false;
            this.btnManageBeneficiaries.Click += new System.EventHandler(this.btnManageBeneficiaries_Click);
            //
            // lblQuickActionsTitle
            //
            this.lblQuickActionsTitle.AutoSize = true;
            this.lblQuickActionsTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblQuickActionsTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblQuickActionsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblQuickActionsTitle.Location = new System.Drawing.Point(30, 30);
            this.lblQuickActionsTitle.Name = "lblQuickActionsTitle";
            this.lblQuickActionsTitle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.lblQuickActionsTitle.Size = new System.Drawing.Size(149, 50);
            this.lblQuickActionsTitle.TabIndex = 0;
            this.lblQuickActionsTitle.Text = "Quick Actions";
            //
            // pnlSidebar
            //
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.pnlSidebar.Controls.Add(this.pnlNavigation);
            this.pnlSidebar.Controls.Add(this.pnlSidebarHeader);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(280, 636);
            this.pnlSidebar.TabIndex = 0;
            //
            // pnlNavigation
            //
            this.pnlNavigation.Controls.Add(this.pnlModulesGroup);
            this.pnlNavigation.Controls.Add(this.pnlSectionsGroup);
            this.pnlNavigation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNavigation.Location = new System.Drawing.Point(0, 70);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Padding = new System.Windows.Forms.Padding(20);
            this.pnlNavigation.Size = new System.Drawing.Size(280, 566);
            this.pnlNavigation.TabIndex = 1;
            //
            // pnlModulesGroup
            //
            this.pnlModulesGroup.Controls.Add(this.flpModuleButtons);
            this.pnlModulesGroup.Controls.Add(this.lblModulesTitle);
            this.pnlModulesGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlModulesGroup.Location = new System.Drawing.Point(20, 300);
            this.pnlModulesGroup.Name = "pnlModulesGroup";
            this.pnlModulesGroup.Size = new System.Drawing.Size(240, 246);
            this.pnlModulesGroup.TabIndex = 1;
            //
            // flpModuleButtons
            //
            this.flpModuleButtons.AutoScroll = true;
            this.flpModuleButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpModuleButtons.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpModuleButtons.Location = new System.Drawing.Point(0, 52);
            this.flpModuleButtons.Name = "flpModuleButtons";
            this.flpModuleButtons.Size = new System.Drawing.Size(240, 194);
            this.flpModuleButtons.TabIndex = 1;
            this.flpModuleButtons.WrapContents = false;
            //
            // lblModulesTitle
            //
            this.lblModulesTitle.AutoSize = true;
            this.lblModulesTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblModulesTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblModulesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.lblModulesTitle.Location = new System.Drawing.Point(0, 0);
            this.lblModulesTitle.Name = "lblModulesTitle";
            this.lblModulesTitle.Padding = new System.Windows.Forms.Padding(0, 20, 0, 12);
            this.lblModulesTitle.Size = new System.Drawing.Size(67, 52);
            this.lblModulesTitle.TabIndex = 0;
            this.lblModulesTitle.Text = "Modules";
            //
            // pnlSectionsGroup
            //
            this.pnlSectionsGroup.Controls.Add(this.btnAddSection);
            this.pnlSectionsGroup.Controls.Add(this.tvwSections);
            this.pnlSectionsGroup.Controls.Add(this.lblSectionsTitle);
            this.pnlSectionsGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSectionsGroup.Location = new System.Drawing.Point(20, 20);
            this.pnlSectionsGroup.Name = "pnlSectionsGroup";
            this.pnlSectionsGroup.Size = new System.Drawing.Size(240, 280);
            this.pnlSectionsGroup.TabIndex = 0;
            //
            // btnAddSection
            //
            this.btnAddSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btnAddSection.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddSection.FlatAppearance.BorderSize = 0;
            this.btnAddSection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSection.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddSection.ForeColor = System.Drawing.Color.White;
            this.btnAddSection.Location = new System.Drawing.Point(0, 240);
            this.btnAddSection.Name = "btnAddSection";
            this.btnAddSection.Padding = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.btnAddSection.Size = new System.Drawing.Size(240, 40);
            this.btnAddSection.TabIndex = 2;
            this.btnAddSection.Text = "+ Add New Section";
            this.btnAddSection.UseVisualStyleBackColor = false;
            this.btnAddSection.Click += new System.EventHandler(this.btnAddSection_Click);
            //
            // tvwSections
            //
            this.tvwSections.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.tvwSections.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvwSections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvwSections.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tvwSections.ForeColor = System.Drawing.Color.White;
            this.tvwSections.Location = new System.Drawing.Point(0, 32);
            this.tvwSections.Name = "tvwSections";
            this.tvwSections.Size = new System.Drawing.Size(240, 208);
            this.tvwSections.TabIndex = 1;
            this.tvwSections.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwSections_AfterSelect);
            //
            // lblSectionsTitle
            //
            this.lblSectionsTitle.AutoSize = true;
            this.lblSectionsTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSectionsTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSectionsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(163)))), ((int)(((byte)(175)))));
            this.lblSectionsTitle.Location = new System.Drawing.Point(0, 0);
            this.lblSectionsTitle.Name = "lblSectionsTitle";
            this.lblSectionsTitle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.lblSectionsTitle.Size = new System.Drawing.Size(67, 32);
            this.lblSectionsTitle.TabIndex = 0;
            this.lblSectionsTitle.Text = "Sections";
            //
            // pnlSidebarHeader
            //
            this.pnlSidebarHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.pnlSidebarHeader.Controls.Add(this.btnToggleSidebar);
            this.pnlSidebarHeader.Controls.Add(this.lblAppTitle);
            this.pnlSidebarHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSidebarHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebarHeader.Name = "pnlSidebarHeader";
            this.pnlSidebarHeader.Padding = new System.Windows.Forms.Padding(20, 16, 20, 16);
            this.pnlSidebarHeader.Size = new System.Drawing.Size(280, 70);
            this.pnlSidebarHeader.TabIndex = 0;
            //
            // btnToggleSidebar
            //
            this.btnToggleSidebar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToggleSidebar.BackColor = System.Drawing.Color.Transparent;
            this.btnToggleSidebar.FlatAppearance.BorderSize = 0;
            this.btnToggleSidebar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleSidebar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnToggleSidebar.ForeColor = System.Drawing.Color.White;
            this.btnToggleSidebar.Location = new System.Drawing.Point(240, 16);
            this.btnToggleSidebar.Name = "btnToggleSidebar";
            this.btnToggleSidebar.Size = new System.Drawing.Size(30, 30);
            this.btnToggleSidebar.TabIndex = 1;
            this.btnToggleSidebar.Text = "☰";
            this.btnToggleSidebar.UseVisualStyleBackColor = false;
            this.btnToggleSidebar.Click += new System.EventHandler(this.btnToggleSidebar_Click);
            //
            // lblAppTitle
            //
            this.lblAppTitle.AutoSize = true;
            this.lblAppTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblAppTitle.ForeColor = System.Drawing.Color.White;
            this.lblAppTitle.Location = new System.Drawing.Point(20, 22);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(180, 25);
            this.lblAppTitle.TabIndex = 0;
            this.lblAppTitle.Text = "Humanitarian PM";
            //
            // DashboardForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1200, 690);
            this.Controls.Add(this.pnlMainContainer);
            this.Controls.Add(this.mainStatusStrip);
            this.Controls.Add(this.mainMenuStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MainMenuStrip = this.mainMenuStrip;
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Humanitarian Project Management System - Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DashboardForm_FormClosing);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.mainStatusStrip.ResumeLayout(false);
            this.mainStatusStrip.PerformLayout();
            this.pnlMainContainer.ResumeLayout(false);
            this.pnlMainContent.ResumeLayout(false);
            this.tlpMainContent.ResumeLayout(false);
            this.pnlWelcomeSection.ResumeLayout(false);
            this.pnlWelcomeSection.PerformLayout();
            this.pnlQuickStats.ResumeLayout(false);
            this.pnlQuickStats.PerformLayout();
            this.flpStatsCards.ResumeLayout(false);
            this.pnlProjectsCard.ResumeLayout(false);
            this.pnlProjectsCard.PerformLayout();
            this.pnlBeneficiariesCard.ResumeLayout(false);
            this.pnlBeneficiariesCard.PerformLayout();
            this.pnlBudgetCard.ResumeLayout(false);
            this.pnlBudgetCard.PerformLayout();
            this.pnlQuickActions.ResumeLayout(false);
            this.pnlQuickActions.PerformLayout();
            this.flpActionButtons.ResumeLayout(false);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlNavigation.ResumeLayout(false);
            this.pnlModulesGroup.ResumeLayout(false);
            this.pnlModulesGroup.PerformLayout();
            this.pnlSectionsGroup.ResumeLayout(false);
            this.pnlSectionsGroup.PerformLayout();
            this.pnlSidebarHeader.ResumeLayout(false);
            this.pnlSidebarHeader.PerformLayout();
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
        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.Panel pnlWelcomeSection;
        private System.Windows.Forms.Label lblWelcomeTitle;
        private System.Windows.Forms.Label lblWelcomeSubtitle;
        private System.Windows.Forms.Panel pnlQuickStats;
        private System.Windows.Forms.Label lblQuickStatsTitle;
        private System.Windows.Forms.Panel pnlProjectsCard;
        private System.Windows.Forms.Label lblProjectsLabel;
        private System.Windows.Forms.Label lblProjectsCount;
        private System.Windows.Forms.Panel pnlBeneficiariesCard;
        private System.Windows.Forms.Label lblBeneficiariesLabel;
        private System.Windows.Forms.Label lblBeneficiariesCount;
        private System.Windows.Forms.Panel pnlBudgetCard;
        private System.Windows.Forms.Label lblBudgetLabel;
        private System.Windows.Forms.Label lblBudgetAmount;
        private System.Windows.Forms.Panel pnlQuickActions;
        private System.Windows.Forms.Label lblQuickActionsTitle;
        private System.Windows.Forms.Button btnNewProject;
        private System.Windows.Forms.Button btnViewReports;
        private System.Windows.Forms.Button btnManageBeneficiaries;
        private System.Windows.Forms.TableLayoutPanel tlpMainContent;
        private System.Windows.Forms.FlowLayoutPanel flpStatsCards;
        private System.Windows.Forms.FlowLayoutPanel flpActionButtons;
    }
}
