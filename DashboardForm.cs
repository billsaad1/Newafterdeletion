using System;
using System.Drawing;
using System.Windows.Forms;
using HumanitarianProjectManagement.UI;
using HumanitarianProjectManagement.Forms;
using HumanitarianProjectManagement.Models;
using System.Collections.Generic;
using HumanitarianProjectManagement.DataAccessLayer;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Globalization;
using System.Threading;
using System.Drawing.Drawing2D;

namespace HumanitarianProjectManagement.Forms
{
    public partial class DashboardForm : Form
    {
        private readonly SectionService _sectionService;
        private readonly ProjectService _projectService;
        private bool _sidebarCollapsed = false;
        private int _originalSidebarWidth = 280;

        public DashboardForm()
        {
            InitializeComponent();
            ApplicationStyleManager.InitializeModernTheme(this);
            ApplyDashboardStyles();

            _sectionService = new SectionService();
            _projectService = new ProjectService();

            // Wire up event handlers
            this.Load += DashboardForm_Load;
            ApplicationStyleManager.LanguageChanged += (s, e) => ApplyLocalization();


            // Set up hover effects for buttons
            SetupButtonHoverEffects();

            // Initialize dashboard data
            InitializeDashboardData();

            // Accessibility Enhancements
            SetupAccessibility();

            ApplyLocalization();
        }

        private void ApplyLocalization()
        {
            // Set Right-to-Left layout if the language is Arabic
            if (Thread.CurrentThread.CurrentUICulture.Name == "ar")
            {
                this.RightToLeft = RightToLeft.Yes;
                this.RightToLeftLayout = true;
                pnlSidebar.Dock = DockStyle.Right;
                pnlMainContent.Dock = DockStyle.Fill;
            }
            else
            {
                this.RightToLeft = RightToLeft.No;
                this.RightToLeftLayout = false;
                pnlSidebar.Dock = DockStyle.Left;
                pnlMainContent.Dock = DockStyle.Fill;
            }

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.fileToolStripMenuItem.Text = resources.GetString("fileToolStripMenuItem.Text");
            this.settingsToolStripMenuItem.Text = resources.GetString("settingsToolStripMenuItem.Text");
            this.exitToolStripMenuItem.Text = resources.GetString("exitToolStripMenuItem.Text");
            this.helpToolStripMenuItem.Text = resources.GetString("helpToolStripMenuItem.Text");
            this.aboutToolStripMenuItem.Text = resources.GetString("aboutToolStripMenuItem.Text");
            this.lblWelcomeTitle.Text = string.Format(resources.GetString("lblWelcomeTitle.Text"), Environment.UserName);
            this.lblQuickStatsTitle.Text = resources.GetString("lblQuickStatsTitle.Text");
            this.lblProjectsLabel.Text = resources.GetString("lblProjectsLabel.Text");
            this.lblBeneficiariesLabel.Text = resources.GetString("lblBeneficiariesLabel.Text");
            this.lblBudgetLabel.Text = resources.GetString("lblBudgetLabel.Text");
            this.lblQuickActionsTitle.Text = resources.GetString("lblQuickActionsTitle.Text");
            this.btnNewProject.Text = resources.GetString("btnNewProject.Text");
            this.btnViewReports.Text = resources.GetString("btnViewReports.Text");
            this.btnManageBeneficiaries.Text = resources.GetString("btnManageBeneficiaries.Text");
            this.lblSectionsTitle.Text = resources.GetString("lblSectionsTitle.Text");
            this.btnAddSection.Text = resources.GetString("btnAddSection.Text");
            this.lblModulesTitle.Text = resources.GetString("lblModulesTitle.Text");
        }


        private void ApplyDashboardStyles()
        {
            // Apply theme to sidebar
            pnlSidebar.BackColor = Color.FromArgb(29, 78, 216); // Fallback color
            pnlSidebarHeader.BackColor = Color.Transparent; // Make header transparent to show gradient
            pnlSidebar.Paint += PnlSidebar_Paint;

            // Adjust sidebar text for dark theme
            lblAppTitle.ForeColor = Color.White;
            lblSectionsTitle.ForeColor = Color.FromArgb(191, 219, 254);
            lblModulesTitle.ForeColor = Color.FromArgb(191, 219, 254);
            btnToggleSidebar.ForeColor = Color.White;
            tvwSections.BackColor = Color.FromArgb(29, 78, 216);

            // Apply theme to main content
            pnlMainContent.BackColor = Color.FromArgb(249, 250, 251);

            // Style welcome section
            ApplicationStyleManager.ApplyCardStyling(pnlWelcomeSection);
            lblWelcomeTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblWelcomeTitle.ForeColor = Color.FromArgb(31, 41, 55);
            lblWelcomeSubtitle.Font = new Font("Segoe UI", 12F);
            lblWelcomeSubtitle.ForeColor = Color.FromArgb(107, 114, 128);

            // Style quick stats section
            ApplicationStyleManager.ApplyCardStyling(pnlQuickStats);
            lblQuickStatsTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblQuickStatsTitle.ForeColor = Color.FromArgb(31, 41, 55);

            // Style quick actions section
            ApplicationStyleManager.ApplyCardStyling(pnlQuickActions);
            lblQuickActionsTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblQuickActionsTitle.ForeColor = Color.FromArgb(31, 41, 55);

            // Style stat cards with rounded corners effect
            ApplicationStyleManager.StyleStatCard(pnlProjectsCard, Color.FromArgb(37, 99, 235));
            ApplicationStyleManager.StyleStatCard(pnlBeneficiariesCard, Color.FromArgb(16, 185, 129));
            ApplicationStyleManager.StyleStatCard(pnlBudgetCard, Color.FromArgb(245, 158, 11));
        }

        private void PnlSidebar_Paint(object sender, PaintEventArgs e)
        {
            Color startColor = Color.FromArgb(29, 78, 216);
            Color endColor = Color.FromArgb(37, 99, 235);
            using (LinearGradientBrush brush = new LinearGradientBrush(pnlSidebar.ClientRectangle, startColor, endColor, 90F))
            {
                e.Graphics.FillRectangle(brush, pnlSidebar.ClientRectangle);
            }
        }

        private void SetupButtonHoverEffects()
        {
            // Setup hover effects for action buttons
            SetupButtonHover(btnNewProject, Color.FromArgb(37, 99, 235), Color.FromArgb(29, 78, 216));
            SetupButtonHover(btnViewReports, Color.FromArgb(16, 185, 129), Color.FromArgb(5, 150, 105));
            SetupButtonHover(btnManageBeneficiaries, Color.FromArgb(245, 158, 11), Color.FromArgb(217, 119, 6));
            SetupButtonHover(btnAddSection, Color.FromArgb(37, 99, 235), Color.FromArgb(29, 78, 216));
            SetupButtonHover(btnToggleSidebar, Color.Transparent, Color.FromArgb(229, 231, 235));
        }

        private void SetupButtonHover(Button button, Color normalColor, Color hoverColor)
        {
            button.FlatAppearance.MouseOverBackColor = hoverColor;
            button.FlatAppearance.MouseDownBackColor = hoverColor;
            button.BackColor = normalColor;

            button.MouseEnter += (sender, e) =>
            {
                button.Cursor = Cursors.Hand;
            };

            button.MouseLeave += (sender, e) =>
            {
                button.Cursor = Cursors.Default;
            };
        }

        private void InitializeDashboardData()
        {
            // Set welcome message with current user
            lblWelcomeTitle.Text = $"Welcome, {Environment.UserName}!";

            // Initialize status
            statusLabel.Text = "Dashboard loaded successfully";
        }

        private void SetupAccessibility()
        {
            // Main menu accessibility
            mainMenuStrip.AccessibleName = "Main application menu";
            fileToolStripMenuItem.AccessibleName = "File Menu";
            settingsToolStripMenuItem.AccessibleName = "Application Settings";
            exitToolStripMenuItem.AccessibleName = "Exit Application";
            helpToolStripMenuItem.AccessibleName = "Help Menu";
            aboutToolStripMenuItem.AccessibleName = "About Application";

            // Dashboard elements accessibility
            lblWelcomeTitle.AccessibleName = "Welcome message";
            pnlQuickStats.AccessibleName = "Quick statistics panel";
            pnlQuickActions.AccessibleName = "Quick actions panel";

            // Sidebar accessibility
            pnlSidebar.AccessibleName = "Navigation sidebar";
            tvwSections.AccessibleName = "Sections tree view";
            flpModuleButtons.AccessibleName = "Module buttons panel";

            // Quick stats accessibility
            lblProjectsCount.AccessibleName = "Total projects count";
            lblProjectsLabel.AccessibleName = "Total projects label";
            lblBeneficiariesCount.AccessibleName = "Total beneficiaries count";
            lblBeneficiariesLabel.AccessibleName = "Total beneficiaries label";
            lblBudgetAmount.AccessibleName = "Total budget amount";
            lblBudgetLabel.AccessibleName = "Total budget label";

            // Quick actions accessibility
            btnNewProject.AccessibleName = "New project button";
            btnViewReports.AccessibleName = "View reports button";
            btnManageBeneficiaries.AccessibleName = "Manage beneficiaries button";
        }

        private async void DashboardForm_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadSectionsTreeViewAsync();
                AddOtherModuleButtons();
                await LoadDashboardStatsAsync();
                statusLabel.Text = "Dashboard ready";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading dashboard: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                statusLabel.Text = "Error loading dashboard";
            }
        }

        private async Task LoadSectionsTreeViewAsync()
        {
            tvwSections.Nodes.Clear();
            TreeNode sectionsRootNode = new TreeNode("📁 Sections")
            {
                ForeColor = Color.White
            };
            tvwSections.Nodes.Add(sectionsRootNode);

            try
            {
                var sections = await _sectionService.GetSectionsAsync();
                if (sections != null)
                {
                    foreach (var section in sections)
                    {
                        TreeNode sectionNode = new TreeNode($"📂 {section.SectionName}")
                        {
                            Tag = section.SectionID,
                            ForeColor = Color.FromArgb(191, 219, 254)
                        };
                        sectionsRootNode.Nodes.Add(sectionNode);
                    }
                }
                sectionsRootNode.Expand();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading sections: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadDashboardStatsAsync()
        {
            try
            {
                // Load project count
                var projects = await _projectService.GetAllProjectsAsync(); // Updated method name
                lblProjectsCount.Text = projects?.Count.ToString() ?? "0";

                // Load beneficiaries count (placeholder)
                lblBeneficiariesCount.Text = "0"; // TODO: Implement beneficiaries service

                // Load budget total (placeholder)
                lblBudgetAmount.Text = "$0"; // TODO: Implement budget calculation

                statusLabel.Text = "Statistics updated";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading statistics: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AddOtherModuleButtons()
        {
            flpModuleButtons.Controls.Clear();

            var moduleButtonProperties = new[]
            {
                new { Text = "📊 Projects (All)", Icon = "📊", FormType = typeof(ProjectListForm) },
                new { Text = "📈 Monitoring & Evaluation", Icon = "📈", FormType = typeof(ProjectListForm) },
                new { Text = "👥 Beneficiaries", Icon = "👥", FormType = typeof(BeneficiaryListManagementForm) },
            };

            foreach (var props in moduleButtonProperties)
            {
                Button btnModule = CreateModuleButton(props.Text, props.FormType);
                flpModuleButtons.Controls.Add(btnModule);
            }
        }

        private Button CreateModuleButton(string text, Type formType)
        {
            Button btnModule = new Button
            {
                Text = text,
                Height = 45,
                Width = flpModuleButtons.ClientSize.Width - 20,
                Margin = new Padding(0, 0, 0, 8),
                BackColor = Color.FromArgb(37, 99, 235),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 9F, FontStyle.Regular),
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(15, 0, 0, 0)
            };

            btnModule.FlatAppearance.BorderSize = 0;

            // Add hover effect
            SetupButtonHover(btnModule, Color.FromArgb(29, 78, 216), Color.FromArgb(37, 99, 235));

            btnModule.Click += (sender, e) =>
            {
                try
                {
                    Form formToOpen = (Form)Activator.CreateInstance(formType);
                    OpenFormInPanel(formToOpen);
                    statusLabel.Text = $"Opened {text}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error opening {text}: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };

            return btnModule;
        }

        private void OpenFormInPanel(Form formToOpen)
        {
            // Clear existing content
            foreach (Control ctrl in pnlMainContent.Controls)
            {
                if (ctrl is Form currentForm)
                {
                    currentForm.Close();
                }
            }
            pnlMainContent.Controls.Clear();

            // Add new form
            formToOpen.TopLevel = false;
            formToOpen.FormBorderStyle = FormBorderStyle.None;
            formToOpen.Dock = DockStyle.Fill;
            pnlMainContent.Controls.Add(formToOpen);
            formToOpen.Tag = "DynamicForm";
            formToOpen.Show();
        }

        private void btnToggleSidebar_Click(object sender, EventArgs e)
        {
            _sidebarCollapsed = !_sidebarCollapsed;

            if (_sidebarCollapsed)
            {
                pnlSidebar.Width = 60;
                lblAppTitle.Visible = false;
                lblSectionsTitle.Visible = false;
                lblModulesTitle.Visible = false;
                tvwSections.Visible = false;
                btnAddSection.Visible = false;

                // Hide module button text
                foreach (Button btn in flpModuleButtons.Controls)
                {
                    btn.Width = 40;
                    btn.Text = btn.Text.Split(' ')[0]; // Show only icon
                }
            }
            else
            {
                pnlSidebar.Width = _originalSidebarWidth;
                lblAppTitle.Visible = true;
                lblSectionsTitle.Visible = true;
                lblModulesTitle.Visible = true;
                tvwSections.Visible = true;
                btnAddSection.Visible = true;

                // Restore module button text
                AddOtherModuleButtons();
            }
        }

        private async void btnAddSection_Click(object sender, EventArgs e)
        {
            string sectionName = Interaction.InputBox(
                "Enter the name for the new section:",
                "Add New Section",
                "");

            if (!string.IsNullOrWhiteSpace(sectionName))
            {
                string sectionDescription = Interaction.InputBox(
                    "Enter the description for the new section (optional):",
                    "Add Section Description",
                    "");

                Section newSection = new Section
                {
                    SectionName = sectionName,
                    Description = sectionDescription
                };

                try
                {
                    int newSectionId = await _sectionService.AddSectionAsync(newSection);
                    if (newSectionId > 0)
                    {
                        MessageBox.Show("Section added successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await LoadSectionsTreeViewAsync();
                        statusLabel.Text = "New section added";
                    }
                    else
                    {
                        MessageBox.Show("Failed to add section.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error adding section: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tvwSections_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node != null && e.Node.Tag != null && e.Node.Parent == tvwSections.Nodes[0])
            {
                if (int.TryParse(e.Node.Tag.ToString(), out int sectionId))
                {
                    ProjectListForm projectListForm = new ProjectListForm(sectionId);
                    OpenFormInPanel(projectListForm);
                    statusLabel.Text = $"Viewing projects for {e.Node.Text}";
                }
            }
        }

        // Quick Action Button Events
        private void btnNewProject_Click(object sender, EventArgs e)
        {
            try
            {
                // Specify the constructor explicitly to resolve ambiguity
                ProjectCreateEditForm newProjectForm = new ProjectCreateEditForm(null, null);
                OpenFormInPanel(newProjectForm);
                statusLabel.Text = "Creating new project";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening new project form: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViewReports_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reports functionality will be implemented soon.", "Reports",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            statusLabel.Text = "Reports feature coming soon";
        }

        private void btnManageBeneficiaries_Click(object sender, EventArgs e)
        {
            try
            {
                BeneficiaryListManagementForm beneficiariesForm = new BeneficiaryListManagementForm();
                OpenFormInPanel(beneficiariesForm);
                statusLabel.Text = "Managing beneficiaries";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening beneficiaries form: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Menu Event Handlers
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Humanitarian Project Management System\n" +
                "Version 2.0 - Modern Edition\n\n" +
                "Enhanced with modern UI design\n" +
                "Developed for humanitarian organizations",
                "About",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void DashboardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Ensure all MDI children are closed
                if (this.IsMdiContainer)
                {
                    foreach (Form mdiChild in this.MdiChildren)
                    {
                        mdiChild.Close();
                    }
                }
                Application.Exit();
            }
        }

        // Method to refresh dashboard data
        public async void RefreshDashboard()
        {
            try
            {
                await LoadSectionsTreeViewAsync();
                await LoadDashboardStatsAsync();
                statusLabel.Text = "Dashboard refreshed";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error refreshing dashboard: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
