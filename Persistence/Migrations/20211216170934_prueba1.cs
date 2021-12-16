using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class prueba1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Content",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", maxLength: 20000, nullable: true),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsPublic = table.Column<bool>(type: "bit", nullable: false),
                    Dato = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Draft = table.Column<bool>(type: "bit", nullable: false),
                    PublishDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Content", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Creator",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatorName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NickName = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    ContentDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Biography = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YoutubeLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatorImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoverImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatorCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WelcomeMsg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Followers = table.Column<int>(type: "int", nullable: false),
                    Category1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BanckAccountId = table.Column<int>(type: "int", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Creator", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DefaultPlans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<float>(type: "real", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubscriptionMsg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WelcomeVideoLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DefaultPlans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FinancialEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RUT = table.Column<int>(type: "int", maxLength: 12, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    Phone = table.Column<int>(type: "int", maxLength: 12, nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinancialEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Plans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<float>(type: "real", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubscriptionMsg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WelcomeVideoLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatorId = table.Column<int>(type: "int", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Plans_Creator_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "Creator",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LasLogin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: true, defaultValue: false),
                    ImgProfile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatorId = table.Column<int>(type: "int", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Creator_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "Creator",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DefaultBenefits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdDefaultPlan = table.Column<int>(type: "int", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DefaultBenefits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DefaultBenefits_DefaultPlans_IdDefaultPlan",
                        column: x => x.IdDefaultPlan,
                        principalTable: "DefaultPlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BanckAccounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountNumber = table.Column<long>(type: "bigint", nullable: false),
                    AccountHolder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatorId = table.Column<int>(type: "int", nullable: false),
                    FinancialEntityId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BanckAccounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BanckAccounts_Creator_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "Creator",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BanckAccounts_FinancialEntity_FinancialEntityId",
                        column: x => x.FinancialEntityId,
                        principalTable: "FinancialEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContentTags",
                columns: table => new
                {
                    IdContent = table.Column<int>(type: "int", nullable: false),
                    IdTag = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentTags", x => new { x.IdTag, x.IdContent });
                    table.ForeignKey(
                        name: "FK_ContentTags_Content_IdContent",
                        column: x => x.IdContent,
                        principalTable: "Content",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContentTags_Tags_IdTag",
                        column: x => x.IdTag,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Benefit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPlan = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Benefit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Benefit_Plans_IdPlan",
                        column: x => x.IdPlan,
                        principalTable: "Plans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ContentPlans",
                columns: table => new
                {
                    IdContent = table.Column<int>(type: "int", nullable: false),
                    IdPlan = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentPlans", x => new { x.IdContent, x.IdPlan });
                    table.ForeignKey(
                        name: "FK_ContentPlans_Content_IdContent",
                        column: x => x.IdContent,
                        principalTable: "Content",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContentPlans_Plans_IdPlan",
                        column: x => x.IdPlan,
                        principalTable: "Plans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Chats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCreator = table.Column<int>(type: "int", nullable: false),
                    IdUser = table.Column<int>(type: "int", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chats_Creator_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "Creator",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Chats_User_IdUser",
                        column: x => x.IdUser,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserCreators",
                columns: table => new
                {
                    IdCreator = table.Column<int>(type: "int", nullable: false),
                    IdUser = table.Column<int>(type: "int", nullable: false),
                    DateFollow = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Unfollow = table.Column<bool>(type: "bit", nullable: false),
                    DateUnfollow = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCreators", x => new { x.IdUser, x.IdCreator });
                    table.ForeignKey(
                        name: "FK_UserCreators_Creator_IdCreator",
                        column: x => x.IdCreator,
                        principalTable: "Creator",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserCreators_User_IdUser",
                        column: x => x.IdUser,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserPlans",
                columns: table => new
                {
                    IdPlan = table.Column<int>(type: "int", nullable: false),
                    IdUser = table.Column<int>(type: "int", nullable: false),
                    SusbscriptionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPlans", x => new { x.IdUser, x.IdPlan });
                    table.ForeignKey(
                        name: "FK_UserPlans_Plans_IdPlan",
                        column: x => x.IdPlan,
                        principalTable: "Plans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserPlans_User_IdUser",
                        column: x => x.IdUser,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUser = table.Column<int>(type: "int", nullable: false),
                    TipoEmisor = table.Column<int>(type: "int", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sended = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdChat = table.Column<int>(type: "int", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_Chats_IdChat",
                        column: x => x.IdChat,
                        principalTable: "Chats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Messages_User_IdUser",
                        column: x => x.IdUser,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExternalPaymentId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NickName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentAmount = table.Column<double>(type: "float", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expired = table.Column<bool>(type: "bit", nullable: false),
                    UserPlanIdP = table.Column<int>(type: "int", nullable: false),
                    UserPlanIdU = table.Column<int>(type: "int", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_UserPlans_UserPlanIdP_UserPlanIdU",
                        columns: x => new { x.UserPlanIdP, x.UserPlanIdU },
                        principalTable: "UserPlans",
                        principalColumns: new[] { "IdUser", "IdPlan" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PagosCreador",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    IdCreator = table.Column<int>(type: "int", nullable: false),
                    Nickname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlanName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pending = table.Column<bool>(type: "bit", nullable: false),
                    AdeedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PayDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdPayment = table.Column<int>(type: "int", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PagosCreador", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PagosCreador_Payments_IdPayment",
                        column: x => x.IdPayment,
                        principalTable: "Payments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PagosPlataforma",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    AdeedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdPayment = table.Column<int>(type: "int", nullable: false),
                    Deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PagosPlataforma", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PagosPlataforma_Payments_IdPayment",
                        column: x => x.IdPayment,
                        principalTable: "Payments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "DefaultPlans",
                columns: new[] { "Id", "Deleted", "Description", "Image", "Name", "Price", "SubscriptionMsg", "WelcomeVideoLink" },
                values: new object[,]
                {
                    { 1, false, "Plan Basico Free", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/Planes%2Fplan%20b.png?alt=media&token=e843ca33-19d8-4cd4-ba4d-342d9c798572", "Basico", 0f, "Bienvenidos a tod@s", "tuVideo.com" },
                    { 2, false, "Plan Estandar ", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/Planes%2Fplan%20e.png?alt=media&token=1525fdd8-8bcc-4666-b000-65de46fbdda9", "Estandar", 150f, "Bienvenidos a tod@s", "tuVideo.com" },
                    { 3, false, "Plan Premium", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/Planes%2Fplan%20p.jfif?alt=media&token=a5d3cfa1-864e-4e4a-9831-caa1b2ea83a6", "Premium", 350f, "Bienvenidos a tod@s", "tuVideo.com" }
                });

            migrationBuilder.InsertData(
                table: "FinancialEntity",
                columns: new[] { "Id", "Country", "Deleted", "Name", "Phone", "RUT" },
                values: new object[,]
                {
                    { 1, "URY", false, "BROU", 8001234, 147523001 },
                    { 2, "URY", false, "ITAU", 8002345, 258634112 },
                    { 3, "URY", false, "SANTANDER", 8003456, 369745223 },
                    { 4, "URY", false, "BBVA", 8004567, 470856334 },
                    { 5, "URY", false, "SCOTIABANK", 8005678, 581967445 }
                });

            migrationBuilder.InsertData(
                table: "DefaultBenefits",
                columns: new[] { "Id", "Deleted", "Description", "IdDefaultPlan" },
                values: new object[,]
                {
                    { 1, false, "Contenidos Libres", 1 },
                    { 2, false, "Todas los meses un contenido libre ", 1 },
                    { 3, false, "Plan Basico Free + Contenidos Exclusivos", 2 },
                    { 4, false, "Todas las semanas contenidos nuevos", 2 },
                    { 5, false, "Todos los dias contenidos nuevos", 3 },
                    { 6, false, "Plan Estandar + Contenidos Exclusivos", 3 },
                    { 7, false, "Chat", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BanckAccounts_CreatorId",
                table: "BanckAccounts",
                column: "CreatorId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BanckAccounts_FinancialEntityId",
                table: "BanckAccounts",
                column: "FinancialEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Benefit_IdPlan",
                table: "Benefit",
                column: "IdPlan");

            migrationBuilder.CreateIndex(
                name: "IX_Chats_IdCreator",
                table: "Chats",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_Chats_IdUser",
                table: "Chats",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_ContentPlans_IdPlan",
                table: "ContentPlans",
                column: "IdPlan");

            migrationBuilder.CreateIndex(
                name: "IX_ContentTags_IdContent",
                table: "ContentTags",
                column: "IdContent");

            migrationBuilder.CreateIndex(
                name: "IX_Creator_CreatorName",
                table: "Creator",
                column: "CreatorName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DefaultBenefits_IdDefaultPlan",
                table: "DefaultBenefits",
                column: "IdDefaultPlan");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_IdChat",
                table: "Messages",
                column: "IdChat");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_IdUser",
                table: "Messages",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_PagosCreador_IdPayment",
                table: "PagosCreador",
                column: "IdPayment");

            migrationBuilder.CreateIndex(
                name: "IX_PagosPlataforma_IdPayment",
                table: "PagosPlataforma",
                column: "IdPayment");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_UserPlanIdP_UserPlanIdU",
                table: "Payments",
                columns: new[] { "UserPlanIdP", "UserPlanIdU" });

            migrationBuilder.CreateIndex(
                name: "IX_Plans_CreatorId",
                table: "Plans",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_User_CreatorId",
                table: "User",
                column: "CreatorId",
                unique: true,
                filter: "[CreatorId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserCreators_IdCreator",
                table: "UserCreators",
                column: "IdCreator");

            migrationBuilder.CreateIndex(
                name: "IX_UserPlans_IdPlan",
                table: "UserPlans",
                column: "IdPlan");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BanckAccounts");

            migrationBuilder.DropTable(
                name: "Benefit");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "ContentPlans");

            migrationBuilder.DropTable(
                name: "ContentTags");

            migrationBuilder.DropTable(
                name: "DefaultBenefits");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "PagosCreador");

            migrationBuilder.DropTable(
                name: "PagosPlataforma");

            migrationBuilder.DropTable(
                name: "UserCreators");

            migrationBuilder.DropTable(
                name: "FinancialEntity");

            migrationBuilder.DropTable(
                name: "Content");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "DefaultPlans");

            migrationBuilder.DropTable(
                name: "Chats");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "UserPlans");

            migrationBuilder.DropTable(
                name: "Plans");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Creator");
        }
    }
}
