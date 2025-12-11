using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HumanitarianProjectManagement.Migrations
{
    public partial class CascadeFix_AllRelationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(maxLength: 100, nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleID);
                });

            migrationBuilder.CreateTable(
                name: "Sections",
                columns: table => new
                {
                    SectionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SectionName = table.Column<string>(maxLength: 255, nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sections", x => x.SectionID);
                });

            migrationBuilder.CreateTable(
                name: "StockItem",
                columns: table => new
                {
                    StockItemID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(maxLength: 255, nullable: false),
                    Description = table.Column<string>(nullable: true),
                    UnitOfMeasure = table.Column<string>(maxLength: 100, nullable: true),
                    CurrentQuantity = table.Column<int>(nullable: false),
                    MinStockLevel = table.Column<int>(nullable: false),
                    MaxStockLevel = table.Column<int>(nullable: true),
                    LastStockUpdate = table.Column<DateTime>(nullable: false),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockItem", x => x.StockItemID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(maxLength: 100, nullable: false),
                    PasswordHash = table.Column<string>(maxLength: 255, nullable: false),
                    Email = table.Column<string>(maxLength: 255, nullable: true),
                    FullName = table.Column<string>(maxLength: 255, nullable: true),
                    PhoneNumber = table.Column<string>(maxLength: 50, nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    LastLogin = table.Column<DateTime>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ProjectID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectName = table.Column<string>(maxLength: 255, nullable: false),
                    ProjectCode = table.Column<string>(maxLength: 50, nullable: true),
                    SectionID = table.Column<int>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: true),
                    EndDate = table.Column<DateTime>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    OverallObjective = table.Column<string>(nullable: true),
                    ManagerUserID = table.Column<int>(nullable: true),
                    Status = table.Column<string>(maxLength: 100, nullable: true),
                    TotalBudget = table.Column<decimal>(type: "decimal(18, 2)", nullable: true),
                    Donor = table.Column<string>(maxLength: 255, nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ProjectID);
                    table.ForeignKey(
                        name: "FK_Projects_Users_ManagerUserID",
                        column: x => x.ManagerUserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Projects_Sections_SectionID",
                        column: x => x.SectionID,
                        principalTable: "Sections",
                        principalColumn: "SectionID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false),
                    RoleID = table.Column<int>(nullable: false),
                    UserRoleID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserID, x.RoleID });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Roles",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BeneficiaryList",
                columns: table => new
                {
                    BeneficiaryListID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectID = table.Column<int>(nullable: false),
                    ListName = table.Column<string>(maxLength: 255, nullable: false),
                    Description = table.Column<string>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BeneficiaryList", x => x.BeneficiaryListID);
                    table.ForeignKey(
                        name: "FK_BeneficiaryList_Projects_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Projects",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Budgets",
                columns: table => new
                {
                    BudgetID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectID = table.Column<int>(nullable: false),
                    BudgetName = table.Column<string>(maxLength: 255, nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    StartDate = table.Column<DateTime>(nullable: true),
                    EndDate = table.Column<DateTime>(nullable: true),
                    Currency = table.Column<string>(maxLength: 10, nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    VersionNumber = table.Column<int>(nullable: false),
                    IsApproved = table.Column<bool>(nullable: false),
                    ApprovedByUserID = table.Column<int>(nullable: true),
                    ApprovalDate = table.Column<DateTime>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Budgets", x => x.BudgetID);
                    table.ForeignKey(
                        name: "FK_Budgets_Users_ApprovedByUserID",
                        column: x => x.ApprovedByUserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Budgets_Projects_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Projects",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BudgetSubCategory",
                columns: table => new
                {
                    BudgetSubCategoryID = table.Column<Guid>(nullable: false),
                    ProjectId = table.Column<int>(nullable: false),
                    MainCategory = table.Column<int>(nullable: false),
                    SubCategoryCodeSuffix = table.Column<string>(nullable: true),
                    SubCategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BudgetSubCategory", x => x.BudgetSubCategoryID);
                    table.ForeignKey(
                        name: "FK_BudgetSubCategory_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Outcome",
                columns: table => new
                {
                    OutcomeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectID = table.Column<int>(nullable: false),
                    OutcomeDescription = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Outcome", x => x.OutcomeID);
                    table.ForeignKey(
                        name: "FK_Outcome_Projects_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Projects",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectReport",
                columns: table => new
                {
                    ReportID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectID = table.Column<int>(nullable: false),
                    ReportTitle = table.Column<string>(maxLength: 255, nullable: false),
                    ReportType = table.Column<string>(maxLength: 100, nullable: true),
                    ReportingPeriodStartDate = table.Column<DateTime>(nullable: true),
                    ReportingPeriodEndDate = table.Column<DateTime>(nullable: true),
                    SubmissionDate = table.Column<DateTime>(nullable: false),
                    SubmittedByUserID = table.Column<int>(nullable: true),
                    ExecutiveSummary = table.Column<string>(nullable: true),
                    Achievements = table.Column<string>(nullable: true),
                    Challenges = table.Column<string>(nullable: true),
                    LessonsLearned = table.Column<string>(nullable: true),
                    FinancialSummary = table.Column<string>(nullable: true),
                    FilePath = table.Column<string>(maxLength: 260, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectReport", x => x.ReportID);
                    table.ForeignKey(
                        name: "FK_ProjectReport_Projects_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Projects",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectReport_Users_SubmittedByUserID",
                        column: x => x.SubmittedByUserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Beneficiary",
                columns: table => new
                {
                    BeneficiaryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeneficiaryListID = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 255, nullable: false),
                    LastName = table.Column<string>(maxLength: 255, nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: true),
                    Gender = table.Column<string>(maxLength: 50, nullable: true),
                    NationalID = table.Column<string>(maxLength: 100, nullable: true),
                    Address = table.Column<string>(nullable: true),
                    ContactNumber = table.Column<string>(maxLength: 50, nullable: true),
                    HouseholdSize = table.Column<int>(nullable: true),
                    VulnerabilityCriteria = table.Column<string>(nullable: true),
                    RegistrationDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beneficiary", x => x.BeneficiaryID);
                    table.ForeignKey(
                        name: "FK_Beneficiary_BeneficiaryList_BeneficiaryListID",
                        column: x => x.BeneficiaryListID,
                        principalTable: "BeneficiaryList",
                        principalColumn: "BeneficiaryListID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Purchase",
                columns: table => new
                {
                    PurchaseID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BudgetID = table.Column<int>(nullable: false),
                    ItemName = table.Column<string>(maxLength: 255, nullable: false),
                    ItemSpecification = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    UnitCost = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    TotalCost = table.Column<decimal>(type: "decimal(20, 2)", nullable: false),
                    Supplier = table.Column<string>(maxLength: 255, nullable: true),
                    PurchaseDate = table.Column<DateTime>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchase", x => x.PurchaseID);
                    table.ForeignKey(
                        name: "FK_Purchase_Budgets_BudgetID",
                        column: x => x.BudgetID,
                        principalTable: "Budgets",
                        principalColumn: "BudgetID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Salaries",
                columns: table => new
                {
                    SalaryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BudgetID = table.Column<int>(nullable: false),
                    PositionTitle = table.Column<string>(maxLength: 255, nullable: false),
                    EmployeeName = table.Column<string>(maxLength: 255, nullable: true),
                    MonthlySalary = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    NumberOfMonths = table.Column<decimal>(type: "decimal(5, 2)", nullable: false),
                    TotalSalaryAmount = table.Column<decimal>(type: "decimal(20, 4)", nullable: false),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salaries", x => x.SalaryID);
                    table.ForeignKey(
                        name: "FK_Salaries_Budgets_BudgetID",
                        column: x => x.BudgetID,
                        principalTable: "Budgets",
                        principalColumn: "BudgetID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetailedBudgetLine",
                columns: table => new
                {
                    DetailedBudgetLineID = table.Column<Guid>(nullable: false),
                    ProjectId = table.Column<int>(nullable: false),
                    BudgetSubCategoryID = table.Column<Guid>(nullable: false),
                    Category = table.Column<int>(nullable: false),
                    Code = table.Column<string>(nullable: true),
                    ItemName = table.Column<string>(maxLength: 255, nullable: true),
                    Description = table.Column<string>(maxLength: 1500, nullable: true),
                    Unit = table.Column<string>(maxLength: 50, nullable: true),
                    Quantity = table.Column<decimal>(type: "decimal(18, 3)", nullable: false),
                    UnitCost = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Duration = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    PercentageChargedToCBPF = table.Column<decimal>(type: "decimal(5, 2)", nullable: false),
                    TotalCost = table.Column<decimal>(type: "decimal(18, 2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailedBudgetLine", x => x.DetailedBudgetLineID);
                    table.ForeignKey(
                        name: "FK_DetailedBudgetLine_BudgetSubCategory_BudgetSubCategoryID",
                        column: x => x.BudgetSubCategoryID,
                        principalTable: "BudgetSubCategory",
                        principalColumn: "BudgetSubCategoryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetailedBudgetLine_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Output",
                columns: table => new
                {
                    OutputID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OutcomeID = table.Column<int>(nullable: false),
                    OutputDescription = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Output", x => x.OutputID);
                    table.ForeignKey(
                        name: "FK_Output_Outcome_OutcomeID",
                        column: x => x.OutcomeID,
                        principalTable: "Outcome",
                        principalColumn: "OutcomeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Feedback",
                columns: table => new
                {
                    FeedbackID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectID = table.Column<int>(nullable: true),
                    BeneficiaryID = table.Column<int>(nullable: true),
                    FeedbackDate = table.Column<DateTime>(nullable: false),
                    FeedbackSource = table.Column<string>(maxLength: 255, nullable: true),
                    FeedbackType = table.Column<string>(maxLength: 100, nullable: true),
                    Details = table.Column<string>(nullable: false),
                    SubmittedBy = table.Column<string>(maxLength: 255, nullable: true),
                    ContactInfo = table.Column<string>(maxLength: 255, nullable: true),
                    Status = table.Column<string>(maxLength: 100, nullable: true),
                    Priority = table.Column<string>(maxLength: 50, nullable: true),
                    RecordedByUserID = table.Column<int>(nullable: true),
                    ResolutionDetails = table.Column<string>(nullable: true),
                    ResolutionDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedback", x => x.FeedbackID);
                    table.ForeignKey(
                        name: "FK_Feedback_Beneficiary_BeneficiaryID",
                        column: x => x.BeneficiaryID,
                        principalTable: "Beneficiary",
                        principalColumn: "BeneficiaryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Feedback_Projects_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Projects",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Feedback_Users_RecordedByUserID",
                        column: x => x.RecordedByUserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FollowUpVisit",
                columns: table => new
                {
                    VisitID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectID = table.Column<int>(nullable: false),
                    BeneficiaryID = table.Column<int>(nullable: true),
                    VisitDate = table.Column<DateTime>(nullable: false),
                    VisitedByUserID = table.Column<int>(nullable: true),
                    VisitPurpose = table.Column<string>(nullable: true),
                    Observations = table.Column<string>(nullable: true),
                    ActionItems = table.Column<string>(nullable: true),
                    NextFollowUpDate = table.Column<DateTime>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FollowUpVisit", x => x.VisitID);
                    table.ForeignKey(
                        name: "FK_FollowUpVisit_Beneficiary_BeneficiaryID",
                        column: x => x.BeneficiaryID,
                        principalTable: "Beneficiary",
                        principalColumn: "BeneficiaryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FollowUpVisit_Projects_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Projects",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FollowUpVisit_Users_VisitedByUserID",
                        column: x => x.VisitedByUserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseOrder",
                columns: table => new
                {
                    PurchaseOrderID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectID = table.Column<int>(nullable: false),
                    PurchaseID = table.Column<int>(nullable: true),
                    SupplierName = table.Column<string>(maxLength: 255, nullable: false),
                    OrderDate = table.Column<DateTime>(nullable: false),
                    ExpectedDeliveryDate = table.Column<DateTime>(nullable: true),
                    ActualDeliveryDate = table.Column<DateTime>(nullable: true),
                    TotalAmount = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Status = table.Column<string>(maxLength: 100, nullable: true),
                    ShippingAddress = table.Column<string>(nullable: true),
                    BillingAddress = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    CreatedByUserID = table.Column<int>(nullable: true),
                    ApprovedByUserID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrder", x => x.PurchaseOrderID);
                    table.ForeignKey(
                        name: "FK_PurchaseOrder_Users_ApprovedByUserID",
                        column: x => x.ApprovedByUserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchaseOrder_Users_CreatedByUserID",
                        column: x => x.CreatedByUserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchaseOrder_Projects_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Projects",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PurchaseOrder_Purchase_PurchaseID",
                        column: x => x.PurchaseID,
                        principalTable: "Purchase",
                        principalColumn: "PurchaseID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ItemizedBudgetDetail",
                columns: table => new
                {
                    ItemizedBudgetDetailID = table.Column<Guid>(nullable: false),
                    ParentBudgetLineID = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemizedBudgetDetail", x => x.ItemizedBudgetDetailID);
                    table.ForeignKey(
                        name: "FK_ItemizedBudgetDetail_DetailedBudgetLine_ParentBudgetLineID",
                        column: x => x.ParentBudgetLineID,
                        principalTable: "DetailedBudgetLine",
                        principalColumn: "DetailedBudgetLineID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Activity",
                columns: table => new
                {
                    ActivityID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OutputID = table.Column<int>(nullable: false),
                    ActivityDescription = table.Column<string>(nullable: false),
                    PlannedMonths = table.Column<string>(nullable: true),
                    BudgetID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activity", x => x.ActivityID);
                    table.ForeignKey(
                        name: "FK_Activity_Budgets_BudgetID",
                        column: x => x.BudgetID,
                        principalTable: "Budgets",
                        principalColumn: "BudgetID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Activity_Output_OutputID",
                        column: x => x.OutputID,
                        principalTable: "Output",
                        principalColumn: "OutputID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectIndicator",
                columns: table => new
                {
                    ProjectIndicatorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectID = table.Column<int>(nullable: false),
                    OutputID = table.Column<int>(nullable: true),
                    IndicatorName = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    TargetValue = table.Column<string>(maxLength: 255, nullable: true),
                    TargetMen = table.Column<int>(nullable: false),
                    TargetWomen = table.Column<int>(nullable: false),
                    TargetBoys = table.Column<int>(nullable: false),
                    TargetGirls = table.Column<int>(nullable: false),
                    TargetTotal = table.Column<int>(nullable: false),
                    ActualValue = table.Column<string>(maxLength: 255, nullable: true),
                    UnitOfMeasure = table.Column<string>(maxLength: 100, nullable: true),
                    BaselineValue = table.Column<string>(maxLength: 255, nullable: true),
                    StartDate = table.Column<DateTime>(nullable: true),
                    EndDate = table.Column<DateTime>(nullable: true),
                    IsKeyIndicator = table.Column<bool>(nullable: false),
                    MeansOfVerification = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectIndicator", x => x.ProjectIndicatorID);
                    table.ForeignKey(
                        name: "FK_ProjectIndicator_Output_OutputID",
                        column: x => x.OutputID,
                        principalTable: "Output",
                        principalColumn: "OutputID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProjectIndicator_Projects_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Projects",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StockTransaction",
                columns: table => new
                {
                    TransactionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StockItemID = table.Column<int>(nullable: false),
                    TransactionType = table.Column<string>(maxLength: 50, nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    TransactionDate = table.Column<DateTime>(nullable: false),
                    ProjectID = table.Column<int>(nullable: true),
                    PurchaseOrderID = table.Column<int>(nullable: true),
                    ActivityID = table.Column<int>(nullable: true),
                    BeneficiaryID = table.Column<int>(nullable: true),
                    DistributedTo = table.Column<string>(maxLength: 255, nullable: true),
                    Reason = table.Column<string>(nullable: true),
                    RecordedByUserID = table.Column<int>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockTransaction", x => x.TransactionID);
                    table.ForeignKey(
                        name: "FK_StockTransaction_Activity_ActivityID",
                        column: x => x.ActivityID,
                        principalTable: "Activity",
                        principalColumn: "ActivityID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockTransaction_Beneficiary_BeneficiaryID",
                        column: x => x.BeneficiaryID,
                        principalTable: "Beneficiary",
                        principalColumn: "BeneficiaryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockTransaction_Projects_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Projects",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockTransaction_PurchaseOrder_PurchaseOrderID",
                        column: x => x.PurchaseOrderID,
                        principalTable: "PurchaseOrder",
                        principalColumn: "PurchaseOrderID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockTransaction_Users_RecordedByUserID",
                        column: x => x.RecordedByUserID,
                        principalTable: "Users",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockTransaction_StockItem_StockItemID",
                        column: x => x.StockItemID,
                        principalTable: "StockItem",
                        principalColumn: "StockItemID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VerificationMeans",
                columns: table => new
                {
                    VerificationMeanID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IndicatorID = table.Column<int>(nullable: false),
                    MeanDescription = table.Column<string>(nullable: false),
                    Frequency = table.Column<string>(maxLength: 100, nullable: true),
                    ResponsibleParty = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VerificationMeans", x => x.VerificationMeanID);
                    table.ForeignKey(
                        name: "FK_VerificationMeans_ProjectIndicator_IndicatorID",
                        column: x => x.IndicatorID,
                        principalTable: "ProjectIndicator",
                        principalColumn: "ProjectIndicatorID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Activity_BudgetID",
                table: "Activity",
                column: "BudgetID");

            migrationBuilder.CreateIndex(
                name: "IX_Activity_OutputID",
                table: "Activity",
                column: "OutputID");

            migrationBuilder.CreateIndex(
                name: "IX_Beneficiary_BeneficiaryListID",
                table: "Beneficiary",
                column: "BeneficiaryListID");

            migrationBuilder.CreateIndex(
                name: "IX_BeneficiaryList_ProjectID",
                table: "BeneficiaryList",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_Budgets_ApprovedByUserID",
                table: "Budgets",
                column: "ApprovedByUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Budgets_ProjectID",
                table: "Budgets",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_BudgetSubCategory_ProjectId",
                table: "BudgetSubCategory",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailedBudgetLine_BudgetSubCategoryID",
                table: "DetailedBudgetLine",
                column: "BudgetSubCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_DetailedBudgetLine_ProjectId",
                table: "DetailedBudgetLine",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedback_BeneficiaryID",
                table: "Feedback",
                column: "BeneficiaryID");

            migrationBuilder.CreateIndex(
                name: "IX_Feedback_ProjectID",
                table: "Feedback",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_Feedback_RecordedByUserID",
                table: "Feedback",
                column: "RecordedByUserID");

            migrationBuilder.CreateIndex(
                name: "IX_FollowUpVisit_BeneficiaryID",
                table: "FollowUpVisit",
                column: "BeneficiaryID");

            migrationBuilder.CreateIndex(
                name: "IX_FollowUpVisit_ProjectID",
                table: "FollowUpVisit",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_FollowUpVisit_VisitedByUserID",
                table: "FollowUpVisit",
                column: "VisitedByUserID");

            migrationBuilder.CreateIndex(
                name: "IX_ItemizedBudgetDetail_ParentBudgetLineID",
                table: "ItemizedBudgetDetail",
                column: "ParentBudgetLineID");

            migrationBuilder.CreateIndex(
                name: "IX_Outcome_ProjectID",
                table: "Outcome",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_Output_OutcomeID",
                table: "Output",
                column: "OutcomeID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectIndicator_OutputID",
                table: "ProjectIndicator",
                column: "OutputID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectIndicator_ProjectID",
                table: "ProjectIndicator",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectReport_ProjectID",
                table: "ProjectReport",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectReport_SubmittedByUserID",
                table: "ProjectReport",
                column: "SubmittedByUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ManagerUserID",
                table: "Projects",
                column: "ManagerUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_SectionID",
                table: "Projects",
                column: "SectionID");

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_BudgetID",
                table: "Purchase",
                column: "BudgetID");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrder_ApprovedByUserID",
                table: "PurchaseOrder",
                column: "ApprovedByUserID");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrder_CreatedByUserID",
                table: "PurchaseOrder",
                column: "CreatedByUserID");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrder_ProjectID",
                table: "PurchaseOrder",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseOrder_PurchaseID",
                table: "PurchaseOrder",
                column: "PurchaseID");

            migrationBuilder.CreateIndex(
                name: "IX_Salaries_BudgetID",
                table: "Salaries",
                column: "BudgetID");

            migrationBuilder.CreateIndex(
                name: "IX_StockTransaction_ActivityID",
                table: "StockTransaction",
                column: "ActivityID");

            migrationBuilder.CreateIndex(
                name: "IX_StockTransaction_BeneficiaryID",
                table: "StockTransaction",
                column: "BeneficiaryID");

            migrationBuilder.CreateIndex(
                name: "IX_StockTransaction_ProjectID",
                table: "StockTransaction",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_StockTransaction_PurchaseOrderID",
                table: "StockTransaction",
                column: "PurchaseOrderID");

            migrationBuilder.CreateIndex(
                name: "IX_StockTransaction_RecordedByUserID",
                table: "StockTransaction",
                column: "RecordedByUserID");

            migrationBuilder.CreateIndex(
                name: "IX_StockTransaction_StockItemID",
                table: "StockTransaction",
                column: "StockItemID");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleID",
                table: "UserRoles",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_VerificationMeans_IndicatorID",
                table: "VerificationMeans",
                column: "IndicatorID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Feedback");

            migrationBuilder.DropTable(
                name: "FollowUpVisit");

            migrationBuilder.DropTable(
                name: "ItemizedBudgetDetail");

            migrationBuilder.DropTable(
                name: "ProjectReport");

            migrationBuilder.DropTable(
                name: "Salaries");

            migrationBuilder.DropTable(
                name: "StockTransaction");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "VerificationMeans");

            migrationBuilder.DropTable(
                name: "DetailedBudgetLine");

            migrationBuilder.DropTable(
                name: "Activity");

            migrationBuilder.DropTable(
                name: "Beneficiary");

            migrationBuilder.DropTable(
                name: "PurchaseOrder");

            migrationBuilder.DropTable(
                name: "StockItem");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "ProjectIndicator");

            migrationBuilder.DropTable(
                name: "BudgetSubCategory");

            migrationBuilder.DropTable(
                name: "BeneficiaryList");

            migrationBuilder.DropTable(
                name: "Purchase");

            migrationBuilder.DropTable(
                name: "Output");

            migrationBuilder.DropTable(
                name: "Budgets");

            migrationBuilder.DropTable(
                name: "Outcome");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Sections");
        }
    }
}
