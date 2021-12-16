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
                table: "Category",
                columns: new[] { "Id", "Deleted", "Name" },
                values: new object[,]
                {
                    { 1, false, "Arte" },
                    { 2, false, "Musica" },
                    { 3, false, "Trading" },
                    { 4, false, "Comida" }
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
                    { 5, "URY", false, "SCOTIABANK", 8005678, 581967445 },
                    { 4, "URY", false, "BBVA", 8004567, 470856334 },
                    { 2, "URY", false, "ITAU", 8002345, 258634112 },
                    { 1, "URY", false, "BROU", 8001234, 147523001 },
                    { 3, "URY", false, "SANTANDER", 8003456, 369745223 }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Created", "CreatorId", "Deleted", "Description", "Email", "ImgProfile", "LasLogin", "Name", "Password" },
                values: new object[,]
                {
                    { 336, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7698), null, false, null, "SueannJeramiah@hotmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "SueannJeramiah", "SueannJeramiah" },
                    { 333, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7682), null, false, null, "PabloIsabelle@live.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "PabloIsabelle", "PabloIsabelle" },
                    { 334, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7687), null, false, null, "ShericaSerene@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "ShericaSerene", "ShericaSerene" },
                    { 335, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7694), null, false, null, "OfeliaLynnea@outlook.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "OfeliaLynnea", "OfeliaLynnea" },
                    { 337, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7705), null, false, null, "IsaShanequa@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "IsaShanequa", "IsaShanequa" },
                    { 343, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7742), null, false, null, "EmelyRenato@live.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "EmelyRenato", "EmelyRenato" },
                    { 339, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7717), null, false, null, "MarcTeddy@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "MarcTeddy", "MarcTeddy" },
                    { 340, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7723), null, false, null, "SallyJamey@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "SallyJamey", "SallyJamey" },
                    { 341, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7728), null, false, null, "BrentonEvans@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "BrentonEvans", "BrentonEvans" },
                    { 342, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7735), null, false, null, "KiannaRolando@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "KiannaRolando", "KiannaRolando" },
                    { 332, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7675), null, false, null, "JettStefany@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "JettStefany", "JettStefany" },
                    { 338, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7710), null, false, null, "OfeliaOtto@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "OfeliaOtto", "OfeliaOtto" },
                    { 331, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7668), null, false, null, "KeturahHerminia@live.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "KeturahHerminia", "KeturahHerminia" },
                    { 325, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7622), null, false, null, "ToneyDavita@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "ToneyDavita", "ToneyDavita" },
                    { 329, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7656), null, false, null, "RaeannaVictoria@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "RaeannaVictoria", "RaeannaVictoria" },
                    { 328, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7648), null, false, null, "BobbieEverette@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "BobbieEverette", "BobbieEverette" },
                    { 327, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7641), null, false, null, "JamesKarie@hotmail.fr", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "JamesKarie", "JamesKarie" },
                    { 326, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7628), null, false, null, "KeithQuintella@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "KeithQuintella", "KeithQuintella" },
                    { 344, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7748), null, false, null, "JulieannCaesar@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "JulieannCaesar", "JulieannCaesar" },
                    { 324, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7616), null, false, null, "ChantaKy@hotmail.fr", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "ChantaKy", "ChantaKy" },
                    { 323, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7609), null, false, null, "LorissaCrystal@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "LorissaCrystal", "LorissaCrystal" },
                    { 322, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7605), null, false, null, "DavionTrevon@live.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "DavionTrevon", "DavionTrevon" },
                    { 321, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7598), null, false, null, "DaylonMei@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "DaylonMei", "DaylonMei" },
                    { 320, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7591), null, false, null, "VasilikiJocelynn@hotmail.fr", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "VasilikiJocelynn", "VasilikiJocelynn" },
                    { 319, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7586), null, false, null, "CarolanneZev@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "CarolanneZev", "CarolanneZev" },
                    { 318, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7578), null, false, null, "AubrieKrystall@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "AubrieKrystall", "AubrieKrystall" },
                    { 317, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7572), null, false, null, "TavonSunny@hotmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "TavonSunny", "TavonSunny" },
                    { 330, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7662), null, false, null, "DevonnaJashua@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "DevonnaJashua", "DevonnaJashua" },
                    { 345, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7762), null, false, null, "KeondraAbbi@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "KeondraAbbi", "KeondraAbbi" },
                    { 351, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7798), null, false, null, "RochelKatherine@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "RochelKatherine", "RochelKatherine" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Created", "CreatorId", "Deleted", "Description", "Email", "ImgProfile", "LasLogin", "Name", "Password" },
                values: new object[,]
                {
                    { 347, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7775), null, false, null, "KashiaBess@outlook.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "KashiaBess", "KashiaBess" },
                    { 375, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7958), null, false, null, "DarrahDemetruis@hotmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "DarrahDemetruis", "DarrahDemetruis" },
                    { 374, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7952), null, false, null, "RishawnTou@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "RishawnTou", "RishawnTou" },
                    { 373, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7945), null, false, null, "NealAudrey@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "NealAudrey", "NealAudrey" },
                    { 372, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7939), null, false, null, "JerriJennine@outlook.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "JerriJennine", "JerriJennine" },
                    { 371, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7932), null, false, null, "RaphealThurman@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "RaphealThurman", "RaphealThurman" },
                    { 370, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7926), null, false, null, "EstevanDione@hotmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "EstevanDione", "EstevanDione" },
                    { 369, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7921), null, false, null, "MckennaCherish@hotmail.fr", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "MckennaCherish", "MckennaCherish" },
                    { 368, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7915), null, false, null, "RevaMartha@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "RevaMartha", "RevaMartha" },
                    { 367, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7909), null, false, null, "BrooksLucretia@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "BrooksLucretia", "BrooksLucretia" },
                    { 366, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7903), null, false, null, "CarlyeLyndsie@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "CarlyeLyndsie", "CarlyeLyndsie" },
                    { 365, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7897), null, false, null, "TracyAden@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "TracyAden", "TracyAden" },
                    { 364, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7890), null, false, null, "JanetDarnisha@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "JanetDarnisha", "JanetDarnisha" },
                    { 363, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7884), null, false, null, "EmaleeTrae@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "EmaleeTrae", "EmaleeTrae" },
                    { 346, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7769), null, false, null, "HarmonyJohannah@hotmail.fr", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "HarmonyJohannah", "HarmonyJohannah" },
                    { 362, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7877), null, false, null, "JalilGinny@hotmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "JalilGinny", "JalilGinny" },
                    { 360, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7858), null, false, null, "AspenChristain@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "AspenChristain", "AspenChristain" },
                    { 359, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7852), null, false, null, "EdieTyne@outlook.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "EdieTyne", "EdieTyne" },
                    { 358, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7847), null, false, null, "PhoebeLetha@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "PhoebeLetha", "PhoebeLetha" },
                    { 357, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7841), null, false, null, "KyeKile@hotmail.fr", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "KyeKile", "KyeKile" },
                    { 356, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7835), null, false, null, "AdanJenette@outlook.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "AdanJenette", "AdanJenette" },
                    { 355, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7825), null, false, null, "AnderaDelana@hotmail.fr", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "AnderaDelana", "AnderaDelana" },
                    { 354, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7819), null, false, null, "BethaniBradly@hotmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "BethaniBradly", "BethaniBradly" },
                    { 353, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7812), null, false, null, "GabriellaKaydee@hotmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "GabriellaKaydee", "GabriellaKaydee" },
                    { 352, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7805), null, false, null, "LavelleZahra@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "LavelleZahra", "LavelleZahra" },
                    { 316, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7565), null, false, null, "TeenaLaurel@hotmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "TeenaLaurel", "TeenaLaurel" },
                    { 350, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7793), null, false, null, "QuianaMassiel@hotmail.fr", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "QuianaMassiel", "QuianaMassiel" },
                    { 349, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7787), null, false, null, "ChelaMariela@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "ChelaMariela", "ChelaMariela" },
                    { 348, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7781), null, false, null, "FrankieNickie@live.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "FrankieNickie", "FrankieNickie" },
                    { 361, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7863), null, false, null, "GarryTammi@hotmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "GarryTammi", "GarryTammi" },
                    { 315, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7560), null, false, null, "LorinaIsreal@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "LorinaIsreal", "LorinaIsreal" },
                    { 309, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7521), null, false, null, "MarkettaJerrad@hotmail.fr", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "MarkettaJerrad", "MarkettaJerrad" },
                    { 313, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7546), null, false, null, "RaeValene@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "RaeValene", "RaeValene" },
                    { 280, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7330), null, false, null, "ShebaErnest@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "ShebaErnest", "ShebaErnest" },
                    { 279, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7324), null, false, null, "GeradLashaun@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "GeradLashaun", "GeradLashaun" },
                    { 278, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7318), null, false, null, "BristolCharlie@live.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "BristolCharlie", "BristolCharlie" },
                    { 277, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7311), null, false, null, "LizethJolyn@hotmail.fr", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "LizethJolyn", "LizethJolyn" },
                    { 276, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7307), null, false, null, "CainEman@hotmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "CainEman", "CainEman" },
                    { 275, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7301), null, false, null, "CristyKrystale@hotmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "CristyKrystale", "CristyKrystale" },
                    { 274, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7295), null, false, null, "DewayneVanity@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "DewayneVanity", "DewayneVanity" },
                    { 273, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7282), null, false, null, "AbnerArnaldo@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "AbnerArnaldo", "AbnerArnaldo" },
                    { 272, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7276), null, false, null, "CorrinneDina@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "CorrinneDina", "CorrinneDina" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Created", "CreatorId", "Deleted", "Description", "Email", "ImgProfile", "LasLogin", "Name", "Password" },
                values: new object[,]
                {
                    { 271, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7270), null, false, null, "LacieImmanuel@live.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "LacieImmanuel", "LacieImmanuel" },
                    { 270, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7264), null, false, null, "ShavonKathlene@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "ShavonKathlene", "ShavonKathlene" },
                    { 269, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7259), null, false, null, "KerwinEmma@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "KerwinEmma", "KerwinEmma" },
                    { 268, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7253), null, false, null, "UlyssesTatum@outlook.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "UlyssesTatum", "UlyssesTatum" },
                    { 267, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7249), null, false, null, "MathieuJulius@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "MathieuJulius", "MathieuJulius" },
                    { 266, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7242), null, false, null, "DeboraLucus@outlook.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "DeboraLucus", "DeboraLucus" },
                    { 265, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7235), null, false, null, "ChasityKellyn@live.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "ChasityKellyn", "ChasityKellyn" },
                    { 264, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7229), null, false, null, "AmmieIsidoro@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "AmmieIsidoro", "AmmieIsidoro" },
                    { 263, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7224), null, false, null, "CarleeJamil@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "CarleeJamil", "CarleeJamil" },
                    { 262, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7217), null, false, null, "DarenShadonna@hotmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "DarenShadonna", "DarenShadonna" },
                    { 261, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7212), null, false, null, "MillieMariah@outlook.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "MillieMariah", "MillieMariah" },
                    { 260, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7206), null, false, null, "DennyLauretta@hotmail.fr", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "DennyLauretta", "DennyLauretta" },
                    { 259, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7199), null, false, null, "GriselUrsula@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "GriselUrsula", "GriselUrsula" },
                    { 258, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7193), null, false, null, "ChelsieDomonick@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "ChelsieDomonick", "ChelsieDomonick" },
                    { 257, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7179), null, false, null, "AliyaNader@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "AliyaNader", "AliyaNader" },
                    { 256, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7173), null, false, null, "TakeshiaGeorgia@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "TakeshiaGeorgia", "TakeshiaGeorgia" },
                    { 255, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7166), null, false, null, "PetraRomeo@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "PetraRomeo", "PetraRomeo" },
                    { 254, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7160), null, false, null, "ChristipherKyli@outlook.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "ChristipherKyli", "ChristipherKyli" },
                    { 281, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7336), null, false, null, "JasmynFaviola@live.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "JasmynFaviola", "JasmynFaviola" },
                    { 282, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7342), null, false, null, "SamanthiaNavid@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "SamanthiaNavid", "SamanthiaNavid" },
                    { 283, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7349), null, false, null, "JaneaElliot@hotmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "JaneaElliot", "JaneaElliot" },
                    { 284, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7355), null, false, null, "NyssaSomer@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "NyssaSomer", "NyssaSomer" },
                    { 312, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7539), null, false, null, "TobyKip@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "TobyKip", "TobyKip" },
                    { 311, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7533), null, false, null, "KerraAmbria@hotmail.fr", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "KerraAmbria", "KerraAmbria" },
                    { 310, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7527), null, false, null, "CharleenRita@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "CharleenRita", "CharleenRita" },
                    { 376, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7964), null, false, null, "TeonAshly@outlook.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "TeonAshly", "TeonAshly" },
                    { 308, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7511), null, false, null, "FalonJens@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "FalonJens", "FalonJens" },
                    { 307, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7504), null, false, null, "TalyaCharis@outlook.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "TalyaCharis", "TalyaCharis" },
                    { 306, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7499), null, false, null, "UsmanAdele@hotmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "UsmanAdele", "UsmanAdele" },
                    { 305, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7492), null, false, null, "DeneshiaLeann@hotmail.fr", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "DeneshiaLeann", "DeneshiaLeann" },
                    { 304, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7485), null, false, null, "CharlineKaitlyn@live.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "CharlineKaitlyn", "CharlineKaitlyn" },
                    { 303, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7478), null, false, null, "DonelleMerideth@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "DonelleMerideth", "DonelleMerideth" },
                    { 302, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7472), null, false, null, "EnedinaBillie@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "EnedinaBillie", "EnedinaBillie" },
                    { 301, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7466), null, false, null, "LamarSonali@hotmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "LamarSonali", "LamarSonali" },
                    { 300, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7460), null, false, null, "ChipKalah@live.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "ChipKalah", "ChipKalah" },
                    { 314, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7553), null, false, null, "MariahJosue@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "MariahJosue", "MariahJosue" },
                    { 299, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7452), null, false, null, "JosephErnest@hotmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "JosephErnest", "JosephErnest" },
                    { 297, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7441), null, false, null, "SpencerGeneva@hotmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "SpencerGeneva", "SpencerGeneva" },
                    { 296, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7434), null, false, null, "MarlainaRishawn@hotmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "MarlainaRishawn", "MarlainaRishawn" },
                    { 295, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7429), null, false, null, "TakiraShanae@live.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "TakiraShanae", "TakiraShanae" },
                    { 294, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7422), null, false, null, "KingCarolynn@outlook.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "KingCarolynn", "KingCarolynn" },
                    { 293, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7418), null, false, null, "AntonAiden@live.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "AntonAiden", "AntonAiden" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Created", "CreatorId", "Deleted", "Description", "Email", "ImgProfile", "LasLogin", "Name", "Password" },
                values: new object[,]
                {
                    { 292, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7412), null, false, null, "JustnShelia@outlook.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "JustnShelia", "JustnShelia" },
                    { 291, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7407), null, false, null, "VinsonChristoper@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "VinsonChristoper", "VinsonChristoper" },
                    { 290, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7393), null, false, null, "BrianaGennifer@outlook.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "BrianaGennifer", "BrianaGennifer" },
                    { 289, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7387), null, false, null, "ArronWaleed@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "ArronWaleed", "ArronWaleed" },
                    { 288, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7379), null, false, null, "GrahamRasheda@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "GrahamRasheda", "GrahamRasheda" },
                    { 287, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7373), null, false, null, "AnndreaJoey@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "AnndreaJoey", "AnndreaJoey" },
                    { 286, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7367), null, false, null, "LatarshaTysen@hotmail.fr", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "LatarshaTysen", "LatarshaTysen" },
                    { 285, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7362), null, false, null, "MarquisSven@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "MarquisSven", "MarquisSven" },
                    { 298, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7448), null, false, null, "RyanYehuda@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "RyanYehuda", "RyanYehuda" },
                    { 377, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7970), null, false, null, "CallyCriselda@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "CallyCriselda", "CallyCriselda" },
                    { 383, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8012), null, false, null, "EdgardMarymargaret@outlook.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "EdgardMarymargaret", "EdgardMarymargaret" },
                    { 379, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7980), null, false, null, "AnsonShareen@hotmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "AnsonShareen", "AnsonShareen" },
                    { 469, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8602), null, false, null, "JarelShanta@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "JarelShanta", "JarelShanta" },
                    { 468, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8598), null, false, null, "AmanTausha@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "AmanTausha", "AmanTausha" },
                    { 467, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8591), null, false, null, "AngelenaMeridith@live.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "AngelenaMeridith", "AngelenaMeridith" },
                    { 466, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8586), null, false, null, "JohnSandee@outlook.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "JohnSandee", "JohnSandee" },
                    { 465, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8580), null, false, null, "HavenCorbin@hotmail.fr", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "HavenCorbin", "HavenCorbin" },
                    { 464, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8574), null, false, null, "SammieHoney@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "SammieHoney", "SammieHoney" },
                    { 463, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8568), null, false, null, "DarrelCaley@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "DarrelCaley", "DarrelCaley" },
                    { 462, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8563), null, false, null, "JansonPoonam@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "JansonPoonam", "JansonPoonam" },
                    { 461, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8558), null, false, null, "JeffKennisha@live.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "JeffKennisha", "JeffKennisha" },
                    { 460, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8552), null, false, null, "RanaShasta@outlook.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "RanaShasta", "RanaShasta" },
                    { 459, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8539), null, false, null, "FranzKeela@hotmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "FranzKeela", "FranzKeela" },
                    { 458, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8532), null, false, null, "MarloToan@hotmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "MarloToan", "MarloToan" },
                    { 457, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8527), null, false, null, "ArielDathan@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "ArielDathan", "ArielDathan" },
                    { 456, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8521), null, false, null, "JulianaDixie@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "JulianaDixie", "JulianaDixie" },
                    { 455, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8515), null, false, null, "TristenValentine@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "TristenValentine", "TristenValentine" },
                    { 454, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8510), null, false, null, "DeloreanAlfonso@live.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "DeloreanAlfonso", "DeloreanAlfonso" },
                    { 453, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8503), null, false, null, "RoelBlanche@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "RoelBlanche", "RoelBlanche" },
                    { 452, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8497), null, false, null, "MelindaMelody@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "MelindaMelody", "MelindaMelody" },
                    { 451, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8491), null, false, null, "SheaCarolina@outlook.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "SheaCarolina", "SheaCarolina" },
                    { 450, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8485), null, false, null, "SheriMagaly@outlook.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "SheriMagaly", "SheriMagaly" },
                    { 449, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8480), null, false, null, "NancyBrock@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "NancyBrock", "NancyBrock" },
                    { 448, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8458), null, false, null, "ArnoldoKandie@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "ArnoldoKandie", "ArnoldoKandie" },
                    { 447, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8450), null, false, null, "ByronJaquan@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "ByronJaquan", "ByronJaquan" },
                    { 446, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8446), null, false, null, "MakenzieTawana@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "MakenzieTawana", "MakenzieTawana" },
                    { 445, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8440), null, false, null, "JaquelineWillian@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "JaquelineWillian", "JaquelineWillian" },
                    { 444, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8434), null, false, null, "TavisVikram@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "TavisVikram", "TavisVikram" },
                    { 443, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8428), null, false, null, "YoelKieth@outlook.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "YoelKieth", "YoelKieth" },
                    { 470, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8609), null, false, null, "GiselaZoila@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "GiselaZoila", "GiselaZoila" },
                    { 471, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8617), null, false, null, "CaryBeatrice@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "CaryBeatrice", "CaryBeatrice" },
                    { 472, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8621), null, false, null, "ZaidaLeda@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "ZaidaLeda", "ZaidaLeda" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Created", "CreatorId", "Deleted", "Description", "Email", "ImgProfile", "LasLogin", "Name", "Password" },
                values: new object[] { 473, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8629), null, false, null, "KeoniAndrae@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "KeoniAndrae", "KeoniAndrae" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Created", "CreatorId", "Deleted", "Description", "Email", "ImgProfile", "IsAdmin", "LasLogin", "Name", "Password" },
                values: new object[] { 501, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8808), null, false, null, "admin@admin", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", true, null, "admin", "admin123" });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Created", "CreatorId", "Deleted", "Description", "Email", "ImgProfile", "LasLogin", "Name", "Password" },
                values: new object[,]
                {
                    { 500, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8805), null, false, null, "DevronHieu@live.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "DevronHieu", "DevronHieu" },
                    { 499, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8799), null, false, null, "OsamaCecilio@hotmail.fr", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "OsamaCecilio", "OsamaCecilio" },
                    { 498, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8794), null, false, null, "CorynShanna@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "CorynShanna", "CorynShanna" },
                    { 497, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8789), null, false, null, "TynishaLetia@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "TynishaLetia", "TynishaLetia" },
                    { 496, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8781), null, false, null, "KimberleeJanay@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "KimberleeJanay", "KimberleeJanay" },
                    { 495, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8773), null, false, null, "GilNichelle@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "GilNichelle", "GilNichelle" },
                    { 494, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8760), null, false, null, "DarbyKaitlin@live.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "DarbyKaitlin", "DarbyKaitlin" },
                    { 493, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8753), null, false, null, "PhyllisMariaelena@hotmail.fr", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "PhyllisMariaelena", "PhyllisMariaelena" },
                    { 492, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8748), null, false, null, "BlaineShanika@hotmail.fr", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "BlaineShanika", "BlaineShanika" },
                    { 491, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8742), null, false, null, "CheriseJaylene@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "CheriseJaylene", "CheriseJaylene" },
                    { 490, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8738), null, false, null, "ShatoyaMarkell@live.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "ShatoyaMarkell", "ShatoyaMarkell" },
                    { 489, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8731), null, false, null, "RashadJewel@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "RashadJewel", "RashadJewel" },
                    { 442, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8421), null, false, null, "AlineAntionette@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "AlineAntionette", "AlineAntionette" },
                    { 488, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8725), null, false, null, "GarrisonCheri@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "GarrisonCheri", "GarrisonCheri" },
                    { 486, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8713), null, false, null, "DevonnaSamantha@hotmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "DevonnaSamantha", "DevonnaSamantha" },
                    { 485, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8707), null, false, null, "BridgetteMaegen@hotmail.fr", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "BridgetteMaegen", "BridgetteMaegen" },
                    { 484, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8701), null, false, null, "AntoneCheri@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "AntoneCheri", "AntoneCheri" },
                    { 483, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8696), null, false, null, "ColetteCirilo@hotmail.fr", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "ColetteCirilo", "ColetteCirilo" },
                    { 482, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8690), null, false, null, "JamielShakira@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "JamielShakira", "JamielShakira" },
                    { 481, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8683), null, false, null, "DuncanChrystle@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "DuncanChrystle", "DuncanChrystle" },
                    { 480, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8677), null, false, null, "DelfinaKevin@outlook.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "DelfinaKevin", "DelfinaKevin" },
                    { 479, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8671), null, false, null, "ViancaChardae@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "ViancaChardae", "ViancaChardae" },
                    { 478, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8665), null, false, null, "KermitGabriele@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "KermitGabriele", "KermitGabriele" },
                    { 477, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8652), null, false, null, "CorieAntonina@live.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "CorieAntonina", "CorieAntonina" },
                    { 476, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8645), null, false, null, "AndreaOrville@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "AndreaOrville", "AndreaOrville" },
                    { 475, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8639), null, false, null, "NatalyaGeorgia@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "NatalyaGeorgia", "NatalyaGeorgia" },
                    { 474, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8634), null, false, null, "HeleneHenri@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "HeleneHenri", "HeleneHenri" },
                    { 487, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8719), null, false, null, "StaffordNikole@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "StaffordNikole", "StaffordNikole" },
                    { 378, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7976), null, false, null, "KarolinaAnisa@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "KarolinaAnisa", "KarolinaAnisa" },
                    { 441, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8408), null, false, null, "DarvinEbone@hotmail.fr", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "DarvinEbone", "DarvinEbone" },
                    { 439, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8396), null, false, null, "JannahJonthan@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "JannahJonthan", "JannahJonthan" },
                    { 406, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8155), null, false, null, "KandraJaylene@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "KandraJaylene", "KandraJaylene" },
                    { 405, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8150), null, false, null, "ShataraVicent@hotmail.fr", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "ShataraVicent", "ShataraVicent" },
                    { 404, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8145), null, false, null, "JohnmarkCarrie@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "JohnmarkCarrie", "JohnmarkCarrie" },
                    { 403, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8139), null, false, null, "UyenFaron@hotmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "UyenFaron", "UyenFaron" },
                    { 402, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8133), null, false, null, "DemetriosKennard@live.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "DemetriosKennard", "DemetriosKennard" },
                    { 401, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8126), null, false, null, "DeangelaJermy@outlook.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "DeangelaJermy", "DeangelaJermy" },
                    { 400, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8121), null, false, null, "GustaveSherman@hotmail.fr", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "GustaveSherman", "GustaveSherman" },
                    { 399, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8116), null, false, null, "SaulMicheala@hotmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "SaulMicheala", "SaulMicheala" },
                    { 398, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8109), null, false, null, "EboneyBertha@hotmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "EboneyBertha", "EboneyBertha" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Created", "CreatorId", "Deleted", "Description", "Email", "ImgProfile", "LasLogin", "Name", "Password" },
                values: new object[,]
                {
                    { 397, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8103), null, false, null, "JudeDelonte@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "JudeDelonte", "JudeDelonte" },
                    { 396, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8090), null, false, null, "JameliaNorman@live.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "JameliaNorman", "JameliaNorman" },
                    { 395, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8084), null, false, null, "RoseFay@live.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "RoseFay", "RoseFay" },
                    { 394, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8078), null, false, null, "ShawneeBrodie@outlook.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "ShawneeBrodie", "ShawneeBrodie" },
                    { 393, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8072), null, false, null, "MauriceCatina@hotmail.fr", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "MauriceCatina", "MauriceCatina" },
                    { 392, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8067), null, false, null, "JaylaAmir@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "JaylaAmir", "JaylaAmir" },
                    { 391, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8059), null, false, null, "SharhondaThomasina@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "SharhondaThomasina", "SharhondaThomasina" },
                    { 390, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8053), null, false, null, "SheilaLondon@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "SheilaLondon", "SheilaLondon" },
                    { 389, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8047), null, false, null, "KedraKatasha@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "KedraKatasha", "KedraKatasha" },
                    { 388, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8040), null, false, null, "BernardSilas@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "BernardSilas", "BernardSilas" },
                    { 387, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8035), null, false, null, "TyshawnBenzion@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "TyshawnBenzion", "TyshawnBenzion" },
                    { 386, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8029), null, false, null, "KarenaNickolas@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "KarenaNickolas", "KarenaNickolas" },
                    { 385, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8024), null, false, null, "BraulioDejuan@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "BraulioDejuan", "BraulioDejuan" },
                    { 384, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8018), null, false, null, "JeanieMyriah@hotmail.fr", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "JeanieMyriah", "JeanieMyriah" },
                    { 253, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7153), null, false, null, "MalorieJacklyn@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "MalorieJacklyn", "MalorieJacklyn" },
                    { 382, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8006), null, false, null, "KamariaShasta@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "KamariaShasta", "KamariaShasta" },
                    { 381, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7999), null, false, null, "ReaganTalisha@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "ReaganTalisha", "ReaganTalisha" },
                    { 380, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7993), null, false, null, "RichelleVeronique@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "RichelleVeronique", "RichelleVeronique" },
                    { 407, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8160), null, false, null, "FrancoisMarni@live.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "FrancoisMarni", "FrancoisMarni" },
                    { 408, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8166), null, false, null, "RachealChera@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "RachealChera", "RachealChera" },
                    { 409, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8171), null, false, null, "RhianaLashandra@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "RhianaLashandra", "RhianaLashandra" },
                    { 410, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8179), null, false, null, "GlenNaquita@hotmail.fr", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "GlenNaquita", "GlenNaquita" },
                    { 438, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8390), null, false, null, "BrieSharayah@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "BrieSharayah", "BrieSharayah" },
                    { 437, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8384), null, false, null, "KamieZacharias@hotmail.fr", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "KamieZacharias", "KamieZacharias" },
                    { 436, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8378), null, false, null, "SynthiaShavonna@live.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "SynthiaShavonna", "SynthiaShavonna" },
                    { 435, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8369), null, false, null, "CarltonMarino@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "CarltonMarino", "CarltonMarino" },
                    { 434, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8363), null, false, null, "TamikoKeva@hotmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "TamikoKeva", "TamikoKeva" },
                    { 433, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8357), null, false, null, "JamielAngelia@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "JamielAngelia", "JamielAngelia" },
                    { 432, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8351), null, false, null, "SalinaAmit@hotmail.fr", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "SalinaAmit", "SalinaAmit" },
                    { 431, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8314), null, false, null, "NadineElena@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "NadineElena", "NadineElena" },
                    { 430, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8307), null, false, null, "JamaineRobin@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "JamaineRobin", "JamaineRobin" },
                    { 429, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8301), null, false, null, "CathleenErrin@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "CathleenErrin", "CathleenErrin" },
                    { 428, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8295), null, false, null, "LanishaElvis@hotmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "LanishaElvis", "LanishaElvis" },
                    { 427, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8289), null, false, null, "SherekaTrumaine@live.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "SherekaTrumaine", "SherekaTrumaine" },
                    { 426, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8282), null, false, null, "ChristoherRobbin@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "ChristoherRobbin", "ChristoherRobbin" },
                    { 440, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8402), null, false, null, "TraceLisandro@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "TraceLisandro", "TraceLisandro" },
                    { 425, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8275), null, false, null, "BethaneyAnders@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "BethaneyAnders", "BethaneyAnders" },
                    { 423, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8262), null, false, null, "JamaEfrem@hotmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "JamaEfrem", "JamaEfrem" },
                    { 422, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8257), null, false, null, "SharelleJerrid@hotmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "SharelleJerrid", "SharelleJerrid" },
                    { 421, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8252), null, false, null, "DesereeLyla@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "DesereeLyla", "DesereeLyla" },
                    { 420, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8245), null, false, null, "LizDavin@outlook.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "LizDavin", "LizDavin" },
                    { 419, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8240), null, false, null, "LizaAnuj@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "LizaAnuj", "LizaAnuj" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Created", "CreatorId", "Deleted", "Description", "Email", "ImgProfile", "LasLogin", "Name", "Password" },
                values: new object[,]
                {
                    { 418, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8234), null, false, null, "RuebenTela@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "RuebenTela", "RuebenTela" },
                    { 417, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8229), null, false, null, "KeeshaRueben@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "KeeshaRueben", "KeeshaRueben" },
                    { 416, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8224), null, false, null, "SaidaClifford@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "SaidaClifford", "SaidaClifford" },
                    { 415, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8215), null, false, null, "AideSelina@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "AideSelina", "AideSelina" },
                    { 414, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8201), null, false, null, "LizetDung@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "LizetDung", "LizetDung" },
                    { 413, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8197), null, false, null, "ShantelleCaitlynn@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "ShantelleCaitlynn", "ShantelleCaitlynn" },
                    { 412, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8190), null, false, null, "DorindaRaynor@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "DorindaRaynor", "DorindaRaynor" },
                    { 411, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8184), null, false, null, "ShekitaKeely@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "ShekitaKeely", "ShekitaKeely" },
                    { 424, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(8269), null, false, null, "ReubenTashauna@outlook.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "ReubenTashauna", "ReubenTashauna" },
                    { 252, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7147), null, false, null, "ThurstonDarris@live.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "ThurstonDarris", "ThurstonDarris" },
                    { 246, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7104), null, false, null, "RobbyTristin@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "RobbyTristin", "RobbyTristin" },
                    { 250, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7135), null, false, null, "SiriAmirah@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "SiriAmirah", "SiriAmirah" },
                    { 90, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5922), null, false, null, "OmayraShawntay@hotmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "OmayraShawntay", "OmayraShawntay" },
                    { 89, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5902), null, false, null, "KameshaMaxwell@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "KameshaMaxwell", "KameshaMaxwell" },
                    { 88, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5894), null, false, null, "MissyMeena@live.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "MissyMeena", "MissyMeena" },
                    { 87, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5886), null, false, null, "BronsonReed@hotmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "BronsonReed", "BronsonReed" },
                    { 86, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5879), null, false, null, "KionaKanisha@live.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "KionaKanisha", "KionaKanisha" },
                    { 85, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5868), null, false, null, "FosterMorgen@hotmail.fr", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "FosterMorgen", "FosterMorgen" },
                    { 84, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5861), null, false, null, "GunnarSequoia@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "GunnarSequoia", "GunnarSequoia" },
                    { 83, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5853), null, false, null, "NedraAllyson@hotmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "NedraAllyson", "NedraAllyson" },
                    { 82, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5846), null, false, null, "CyndiHasan@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "CyndiHasan", "CyndiHasan" },
                    { 81, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5838), null, false, null, "LupeCandra@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "LupeCandra", "LupeCandra" },
                    { 80, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5831), null, false, null, "ParkerDelonte@hotmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "ParkerDelonte", "ParkerDelonte" },
                    { 79, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5823), null, false, null, "SadeSerafin@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "SadeSerafin", "SadeSerafin" },
                    { 78, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5815), null, false, null, "KathyrnLindsi@outlook.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "KathyrnLindsi", "KathyrnLindsi" },
                    { 77, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5808), null, false, null, "NickyJudi@live.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "NickyJudi", "NickyJudi" },
                    { 76, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5800), null, false, null, "OrrinNels@outlook.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "OrrinNels", "OrrinNels" },
                    { 75, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5789), null, false, null, "AsiaCambria@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "AsiaCambria", "AsiaCambria" },
                    { 74, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5775), null, false, null, "ChristineDontavious@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "ChristineDontavious", "ChristineDontavious" },
                    { 73, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5766), null, false, null, "StefanoDurell@outlook.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "StefanoDurell", "StefanoDurell" },
                    { 72, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5759), null, false, null, "AlexiaLorin@live.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "AlexiaLorin", "AlexiaLorin" },
                    { 71, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5752), null, false, null, "AnikaErnestine@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "AnikaErnestine", "AnikaErnestine" },
                    { 70, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5742), null, false, null, "GemmaTerrie@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "GemmaTerrie", "GemmaTerrie" },
                    { 69, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5735), null, false, null, "IrmaVernita@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "IrmaVernita", "IrmaVernita" },
                    { 68, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5728), null, false, null, "MaximoKeli@outlook.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "MaximoKeli", "MaximoKeli" },
                    { 67, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5721), null, false, null, "PetrinaTonisha@outlook.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "PetrinaTonisha", "PetrinaTonisha" },
                    { 66, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5710), null, false, null, "FerdinandTerica@live.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "FerdinandTerica", "FerdinandTerica" },
                    { 65, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5700), null, false, null, "SashaAramis@hotmail.fr", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "SashaAramis", "SashaAramis" },
                    { 64, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5694), null, false, null, "EliOmer@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "EliOmer", "EliOmer" },
                    { 91, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5932), null, false, null, "DecarlosAlexandro@hotmail.fr", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "DecarlosAlexandro", "DecarlosAlexandro" },
                    { 92, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5939), null, false, null, "KendellMarisa@outlook.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "KendellMarisa", "KendellMarisa" },
                    { 93, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5947), null, false, null, "JanmichaelJorge@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "JanmichaelJorge", "JanmichaelJorge" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Created", "CreatorId", "Deleted", "Description", "Email", "ImgProfile", "LasLogin", "Name", "Password" },
                values: new object[,]
                {
                    { 94, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5956), null, false, null, "GustavTenaya@hotmail.fr", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "GustavTenaya", "GustavTenaya" },
                    { 122, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6189), null, false, null, "MarleySerita@hotmail.fr", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "MarleySerita", "MarleySerita" },
                    { 121, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6179), null, false, null, "RobynLexie@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "RobynLexie", "RobynLexie" },
                    { 120, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6172), null, false, null, "JeremiasMarcelle@hotmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "JeremiasMarcelle", "JeremiasMarcelle" },
                    { 119, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6165), null, false, null, "LolitaKaylen@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "LolitaKaylen", "LolitaKaylen" },
                    { 118, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6158), null, false, null, "CarynKeegan@outlook.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "CarynKeegan", "CarynKeegan" },
                    { 117, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6150), null, false, null, "LucianKirsten@live.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "LucianKirsten", "LucianKirsten" },
                    { 116, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6143), null, false, null, "TyanaDave@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "TyanaDave", "TyanaDave" },
                    { 115, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6125), null, false, null, "AngeloKatiria@live.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "AngeloKatiria", "AngeloKatiria" },
                    { 114, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6117), null, false, null, "TommiIsac@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "TommiIsac", "TommiIsac" },
                    { 113, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6110), null, false, null, "CassieEctor@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "CassieEctor", "CassieEctor" },
                    { 112, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6102), null, false, null, "KarenaRia@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "KarenaRia", "KarenaRia" },
                    { 111, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6094), null, false, null, "AdrainLorri@hotmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "AdrainLorri", "AdrainLorri" },
                    { 110, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6086), null, false, null, "WebsterBentley@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "WebsterBentley", "WebsterBentley" },
                    { 63, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5686), null, false, null, "TruongEloy@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "TruongEloy", "TruongEloy" },
                    { 109, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6079), null, false, null, "AmritaBilli@outlook.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "AmritaBilli", "AmritaBilli" },
                    { 107, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6064), null, false, null, "RaeanneDarcel@live.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "RaeanneDarcel", "RaeanneDarcel" },
                    { 106, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6056), null, false, null, "JaquitaRoxann@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "JaquitaRoxann", "JaquitaRoxann" },
                    { 105, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6048), null, false, null, "JacindaCailyn@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "JacindaCailyn", "JacindaCailyn" },
                    { 104, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6041), null, false, null, "MinaSilvia@hotmail.fr", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "MinaSilvia", "MinaSilvia" },
                    { 103, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6034), null, false, null, "LatrinaBritton@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "LatrinaBritton", "LatrinaBritton" },
                    { 102, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6025), null, false, null, "JerradYisroel@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "JerradYisroel", "JerradYisroel" },
                    { 101, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6018), null, false, null, "JenniNicholes@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "JenniNicholes", "JenniNicholes" },
                    { 100, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6010), null, false, null, "VivekKarissa@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "VivekKarissa", "VivekKarissa" },
                    { 99, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6002), null, false, null, "RandelRonaldo@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "RandelRonaldo", "RandelRonaldo" },
                    { 98, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5994), null, false, null, "CindyMontell@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "CindyMontell", "CindyMontell" },
                    { 97, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5978), null, false, null, "MadonnaGodfrey@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "MadonnaGodfrey", "MadonnaGodfrey" },
                    { 96, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5972), null, false, null, "ElvisMarisol@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "ElvisMarisol", "ElvisMarisol" },
                    { 95, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5965), null, false, null, "KaycieBrandee@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "KaycieBrandee", "KaycieBrandee" },
                    { 108, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6071), null, false, null, "BlaiseJarell@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "BlaiseJarell", "BlaiseJarell" },
                    { 123, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6196), null, false, null, "AurelioKashawn@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "AurelioKashawn", "AurelioKashawn" },
                    { 62, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5678), null, false, null, "KeeleyShae@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "KeeleyShae", "KeeleyShae" },
                    { 60, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5663), null, false, null, "ErickaKavita@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "ErickaKavita", "ErickaKavita" },
                    { 27, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5372), null, false, null, "KeilaCheng@live.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "KeilaCheng", "KeilaCheng" },
                    { 26, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5364), null, false, null, "DrewKiri@live.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "DrewKiri", "DrewKiri" },
                    { 25, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5357), null, false, null, "AmiraAmbrea@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "AmiraAmbrea", "AmiraAmbrea" },
                    { 24, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5349), null, false, null, "LonnellJarrad@live.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "LonnellJarrad", "LonnellJarrad" },
                    { 23, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5342), null, false, null, "ChevyJett@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "ChevyJett", "ChevyJett" },
                    { 22, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5333), null, false, null, "KaArmand@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "KaArmand", "KaArmand" },
                    { 21, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5324), null, false, null, "CarsonMallory@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "CarsonMallory", "CarsonMallory" },
                    { 20, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5316), null, false, null, "BrendanDereck@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "BrendanDereck", "BrendanDereck" },
                    { 19, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5308), 19, false, null, "TreasureBreann@live.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "TreasureBreann", "TreasureBreann" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Created", "CreatorId", "Deleted", "Description", "Email", "ImgProfile", "LasLogin", "Name", "Password" },
                values: new object[,]
                {
                    { 18, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5300), 18, false, null, "JeanpaulRomel@outlook.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "JeanpaulRomel", "JeanpaulRomel" },
                    { 17, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5287), 17, false, null, "TyshawnLeandra@live.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "TyshawnLeandra", "TyshawnLeandra" },
                    { 16, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5279), 16, false, null, "RosioRufino@live.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "RosioRufino", "RosioRufino" },
                    { 15, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5270), 15, false, null, "RamondAmity@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "RamondAmity", "RamondAmity" },
                    { 14, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5241), 14, false, null, "CoriTessa@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "CoriTessa", "CoriTessa" },
                    { 13, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5231), 13, false, null, "NikkieDaren@hotmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "NikkieDaren", "NikkieDaren" },
                    { 12, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5203), 12, false, null, "ElyshaJonatha@live.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "ElyshaJonatha", "ElyshaJonatha" },
                    { 11, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5195), 11, false, null, "NelsDeirdre@hotmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "NelsDeirdre", "NelsDeirdre" },
                    { 10, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5187), 10, false, null, "JamaicaLanell@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "JamaicaLanell", "JamaicaLanell" },
                    { 9, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5178), 9, false, null, "FerminNathalie@hotmail.fr", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "FerminNathalie", "FerminNathalie" },
                    { 8, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5170), 8, false, null, "StanleyAdam@live.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "StanleyAdam", "StanleyAdam" },
                    { 7, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5159), 7, false, null, "LandonVarun@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "LandonVarun", "LandonVarun" },
                    { 6, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5150), 6, false, null, "PageGerry@hotmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "PageGerry", "PageGerry" },
                    { 5, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5138), 5, false, null, "JasmyneDetra@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "JasmyneDetra", "JasmyneDetra" },
                    { 4, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5129), 4, false, null, "MiloTerell@live.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "MiloTerell", "MiloTerell" },
                    { 3, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5102), 3, false, null, "TrangRico@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "TrangRico", "TrangRico" },
                    { 2, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5063), 2, false, null, "AnthoneyNeill@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "AnthoneyNeill", "AnthoneyNeill" },
                    { 1, new DateTime(2021, 12, 16, 13, 43, 24, 259, DateTimeKind.Local).AddTicks(9994), 1, false, null, "LukasAdriana@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "LukasAdriana", "LukasAdriana" },
                    { 28, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5379), null, false, null, "JeanieNickolas@live.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "JeanieNickolas", "JeanieNickolas" },
                    { 29, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5387), null, false, null, "PhuongRobbin@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "PhuongRobbin", "PhuongRobbin" },
                    { 30, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5405), null, false, null, "JessiccaShemekia@live.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "JessiccaShemekia", "JessiccaShemekia" },
                    { 31, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5413), null, false, null, "CristyCalen@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "CristyCalen", "CristyCalen" },
                    { 59, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5656), null, false, null, "RodgerCharly@hotmail.fr", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "RodgerCharly", "RodgerCharly" },
                    { 58, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5641), null, false, null, "DainMarisha@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "DainMarisha", "DainMarisha" },
                    { 57, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5631), null, false, null, "TommieShantavia@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "TommieShantavia", "TommieShantavia" },
                    { 56, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5622), null, false, null, "LamarcusLakeia@hotmail.fr", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "LamarcusLakeia", "LamarcusLakeia" },
                    { 55, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5614), null, false, null, "MoriaSamia@hotmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "MoriaSamia", "MoriaSamia" },
                    { 54, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5607), null, false, null, "CollenKisha@hotmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "CollenKisha", "CollenKisha" },
                    { 53, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5599), null, false, null, "SixtoKady@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "SixtoKady", "SixtoKady" },
                    { 52, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5592), null, false, null, "NicklausAmeer@outlook.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "NicklausAmeer", "NicklausAmeer" },
                    { 51, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5583), null, false, null, "RonSorangel@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "RonSorangel", "RonSorangel" },
                    { 50, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5575), null, false, null, "JessycaThao@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "JessycaThao", "JessycaThao" },
                    { 49, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5567), null, false, null, "ShouaJo@hotmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "ShouaJo", "ShouaJo" },
                    { 48, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5559), null, false, null, "KayeBoone@hotmail.fr", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "KayeBoone", "KayeBoone" },
                    { 47, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5551), null, false, null, "RaymundoGermaine@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "RaymundoGermaine", "RaymundoGermaine" },
                    { 61, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5671), null, false, null, "ImranGian@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "ImranGian", "ImranGian" },
                    { 46, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5544), null, false, null, "DelinaGeronimo@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "DelinaGeronimo", "DelinaGeronimo" },
                    { 44, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5529), null, false, null, "EvansYancey@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "EvansYancey", "EvansYancey" },
                    { 43, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5522), null, false, null, "MakenzieSawyer@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "MakenzieSawyer", "MakenzieSawyer" },
                    { 42, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5514), null, false, null, "NoemiKanesha@live.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "NoemiKanesha", "NoemiKanesha" },
                    { 41, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5506), null, false, null, "LatikaTeal@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "LatikaTeal", "LatikaTeal" },
                    { 40, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5489), null, false, null, "PatrickMiller@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "PatrickMiller", "PatrickMiller" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Created", "CreatorId", "Deleted", "Description", "Email", "ImgProfile", "LasLogin", "Name", "Password" },
                values: new object[,]
                {
                    { 39, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5482), null, false, null, "BradleyTito@hotmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "BradleyTito", "BradleyTito" },
                    { 38, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5474), null, false, null, "HaleeMarketta@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "HaleeMarketta", "HaleeMarketta" },
                    { 37, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5462), null, false, null, "FlintAngelina@hotmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "FlintAngelina", "FlintAngelina" },
                    { 36, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5455), null, false, null, "AmbroseRamiro@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "AmbroseRamiro", "AmbroseRamiro" },
                    { 35, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5447), null, false, null, "LilaPrice@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "LilaPrice", "LilaPrice" },
                    { 34, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5439), null, false, null, "MaximillianMatthew@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "MaximillianMatthew", "MaximillianMatthew" },
                    { 33, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5429), null, false, null, "LarsAnil@outlook.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "LarsAnil", "LarsAnil" },
                    { 32, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5420), null, false, null, "AsifMaura@live.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "AsifMaura", "AsifMaura" },
                    { 45, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(5536), null, false, null, "TristenTerrah@outlook.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "TristenTerrah", "TristenTerrah" },
                    { 124, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6203), null, false, null, "NikaDorthy@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "NikaDorthy", "NikaDorthy" },
                    { 125, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6210), null, false, null, "KaneishaYasmin@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "KaneishaYasmin", "KaneishaYasmin" },
                    { 126, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6218), null, false, null, "GypsyMaggie@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "GypsyMaggie", "GypsyMaggie" },
                    { 217, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6928), null, false, null, "HaywoodVernice@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "HaywoodVernice", "HaywoodVernice" },
                    { 216, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6922), null, false, null, "ElwoodLauren@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "ElwoodLauren", "ElwoodLauren" },
                    { 215, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6916), null, false, null, "AdriannaKristle@live.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "AdriannaKristle", "AdriannaKristle" },
                    { 214, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6909), null, false, null, "FredericaNichole@outlook.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "FredericaNichole", "FredericaNichole" },
                    { 213, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6902), null, false, null, "ErwinJacquelin@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "ErwinJacquelin", "ErwinJacquelin" },
                    { 212, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6894), null, false, null, "BrittanAkilah@live.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "BrittanAkilah", "BrittanAkilah" },
                    { 211, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6881), null, false, null, "ShawnNicolette@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "ShawnNicolette", "ShawnNicolette" },
                    { 210, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6873), null, false, null, "JorelTuesday@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "JorelTuesday", "JorelTuesday" },
                    { 209, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6868), null, false, null, "CardellMarnie@hotmail.fr", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "CardellMarnie", "CardellMarnie" },
                    { 208, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6861), null, false, null, "DemetricStormie@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "DemetricStormie", "DemetricStormie" },
                    { 207, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6855), null, false, null, "LigiaCrystal@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "LigiaCrystal", "LigiaCrystal" },
                    { 206, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6848), null, false, null, "SloanKristi@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "SloanKristi", "SloanKristi" },
                    { 205, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6842), null, false, null, "GageAspen@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "GageAspen", "GageAspen" },
                    { 204, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6837), null, false, null, "LavrenMarcia@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "LavrenMarcia", "LavrenMarcia" },
                    { 203, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6830), null, false, null, "JaimeeSherra@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "JaimeeSherra", "JaimeeSherra" },
                    { 202, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6824), null, false, null, "GorgeGeorgette@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "GorgeGeorgette", "GorgeGeorgette" },
                    { 201, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6818), null, false, null, "LacrishaBarron@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "LacrishaBarron", "LacrishaBarron" },
                    { 200, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6810), null, false, null, "PorfirioLucero@live.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "PorfirioLucero", "PorfirioLucero" },
                    { 199, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6803), null, false, null, "AbdulOctavious@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "AbdulOctavious", "AbdulOctavious" },
                    { 198, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6795), null, false, null, "ShenekaJeremias@hotmail.fr", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "ShenekaJeremias", "ShenekaJeremias" },
                    { 197, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6768), null, false, null, "TheraLashana@live.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "TheraLashana", "TheraLashana" },
                    { 196, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6762), null, false, null, "AndrianaKira@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "AndrianaKira", "AndrianaKira" },
                    { 195, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6756), null, false, null, "MarlainaMeryl@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "MarlainaMeryl", "MarlainaMeryl" },
                    { 194, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6750), null, false, null, "AugustAshley@outlook.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "AugustAshley", "AugustAshley" },
                    { 193, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6745), null, false, null, "BreanaDenisse@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "BreanaDenisse", "BreanaDenisse" },
                    { 192, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6738), null, false, null, "FidelKylene@hotmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "FidelKylene", "FidelKylene" },
                    { 191, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6732), null, false, null, "SharitaMiya@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "SharitaMiya", "SharitaMiya" },
                    { 218, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6934), null, false, null, "JevonRodger@hotmail.fr", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "JevonRodger", "JevonRodger" },
                    { 219, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6939), null, false, null, "RoniGriffin@hotmail.fr", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "RoniGriffin", "RoniGriffin" },
                    { 220, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6944), null, false, null, "BobbyElysha@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "BobbyElysha", "BobbyElysha" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Created", "CreatorId", "Deleted", "Description", "Email", "ImgProfile", "LasLogin", "Name", "Password" },
                values: new object[,]
                {
                    { 221, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6950), null, false, null, "YadiraLaurel@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "YadiraLaurel", "YadiraLaurel" },
                    { 249, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7129), null, false, null, "ClementeAhsley@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "ClementeAhsley", "ClementeAhsley" },
                    { 248, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7122), null, false, null, "LindseyJenell@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "LindseyJenell", "LindseyJenell" },
                    { 247, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7116), null, false, null, "MelyssaJedediah@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "MelyssaJedediah", "MelyssaJedediah" },
                    { 502, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(9272), null, false, null, "usuario@usuario", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "usuario", "usuario123" },
                    { 245, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7098), null, false, null, "RamondShekita@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "RamondShekita", "RamondShekita" },
                    { 244, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7091), null, false, null, "MarcellusKing@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "MarcellusKing", "MarcellusKing" },
                    { 243, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7084), null, false, null, "JeredEfrem@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "JeredEfrem", "JeredEfrem" },
                    { 242, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7078), null, false, null, "CarminKreg@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "CarminKreg", "CarminKreg" },
                    { 241, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7072), null, false, null, "KeriannMaha@live.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "KeriannMaha", "KeriannMaha" },
                    { 240, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7067), null, false, null, "KieranCecelia@hotmail.fr", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "KieranCecelia", "KieranCecelia" },
                    { 239, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7061), null, false, null, "KalynnTiffay@hotmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "KalynnTiffay", "KalynnTiffay" },
                    { 238, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7056), null, false, null, "EddyMarcello@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "EddyMarcello", "EddyMarcello" },
                    { 237, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7051), null, false, null, "JoycePayton@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "JoycePayton", "JoycePayton" },
                    { 190, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6725), null, false, null, "KeriannNoam@hotmail.fr", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "KeriannNoam", "KeriannNoam" },
                    { 236, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7046), null, false, null, "KathryneIsreal@hotmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "KathryneIsreal", "KathryneIsreal" },
                    { 234, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7036), null, false, null, "MitchellTarra@hotmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "MitchellTarra", "MitchellTarra" },
                    { 233, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7029), null, false, null, "KiranMontoya@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "KiranMontoya", "KiranMontoya" },
                    { 232, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7023), null, false, null, "ChandaAcacia@live.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "ChandaAcacia", "ChandaAcacia" },
                    { 231, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7016), null, false, null, "IainBradley@hotmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "IainBradley", "IainBradley" },
                    { 230, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7011), null, false, null, "SulemaPeri@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "SulemaPeri", "SulemaPeri" },
                    { 229, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6998), null, false, null, "AlaineShain@hotmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "AlaineShain", "AlaineShain" },
                    { 228, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6994), null, false, null, "ShaunnaFelica@live.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "ShaunnaFelica", "ShaunnaFelica" },
                    { 227, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6989), null, false, null, "EleshaLucretia@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "EleshaLucretia", "EleshaLucretia" },
                    { 226, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6982), null, false, null, "RoshundaFelisa@live.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "RoshundaFelisa", "RoshundaFelisa" },
                    { 225, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6977), null, false, null, "NinaLynette@hotmail.fr", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "NinaLynette", "NinaLynette" },
                    { 224, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6970), null, false, null, "CharlitaDung@hotmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "CharlitaDung", "CharlitaDung" },
                    { 223, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6963), null, false, null, "TywanNohemi@outlook.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "TywanNohemi", "TywanNohemi" },
                    { 222, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6957), null, false, null, "JacindaThong@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "JacindaThong", "JacindaThong" },
                    { 235, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7040), null, false, null, "BrannonSiobhan@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "BrannonSiobhan", "BrannonSiobhan" },
                    { 189, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6720), null, false, null, "EmmittTory@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "EmmittTory", "EmmittTory" },
                    { 188, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6713), null, false, null, "DavieErika@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "DavieErika", "DavieErika" },
                    { 187, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6706), null, false, null, "NolanFrancine@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "NolanFrancine", "NolanFrancine" },
                    { 154, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6449), null, false, null, "AviNed@hotmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "AviNed", "AviNed" },
                    { 153, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6440), null, false, null, "GenoStephenie@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "GenoStephenie", "GenoStephenie" },
                    { 152, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6431), null, false, null, "CheriFederico@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "CheriFederico", "CheriFederico" },
                    { 151, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6423), null, false, null, "RosamariaChristina@live.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "RosamariaChristina", "RosamariaChristina" },
                    { 150, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6415), null, false, null, "StefanieLavinia@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "StefanieLavinia", "StefanieLavinia" },
                    { 149, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6407), null, false, null, "ShavonneChristophe@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "ShavonneChristophe", "ShavonneChristophe" },
                    { 148, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6399), null, false, null, "HeatherRashanda@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "HeatherRashanda", "HeatherRashanda" },
                    { 147, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6392), null, false, null, "BrianaTai@hotmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "BrianaTai", "BrianaTai" },
                    { 146, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6383), null, false, null, "NicklasShina@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "NicklasShina", "NicklasShina" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Created", "CreatorId", "Deleted", "Description", "Email", "ImgProfile", "LasLogin", "Name", "Password" },
                values: new object[,]
                {
                    { 145, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6369), null, false, null, "BenjimanPayton@hotmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "BenjimanPayton", "BenjimanPayton" },
                    { 144, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6362), null, false, null, "MarcellaJessamyn@hotmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "MarcellaJessamyn", "MarcellaJessamyn" },
                    { 143, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6355), null, false, null, "CarmenArnaldo@live.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "CarmenArnaldo", "CarmenArnaldo" },
                    { 142, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6348), null, false, null, "MaryDonnell@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "MaryDonnell", "MaryDonnell" },
                    { 155, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6457), null, false, null, "SyWaldo@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "SyWaldo", "SyWaldo" },
                    { 141, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6340), null, false, null, "KarahRian@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "KarahRian", "KarahRian" },
                    { 139, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6325), null, false, null, "DeontaBritney@outlook.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "DeontaBritney", "DeontaBritney" },
                    { 138, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6317), null, false, null, "ReedPrice@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "ReedPrice", "ReedPrice" },
                    { 137, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6312), null, false, null, "PavielleKassandra@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "PavielleKassandra", "PavielleKassandra" },
                    { 136, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6303), null, false, null, "DomeniqueShandy@hotmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "DomeniqueShandy", "DomeniqueShandy" },
                    { 135, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6296), null, false, null, "ContessaChadd@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "ContessaChadd", "ContessaChadd" },
                    { 134, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6288), null, false, null, "BrittannyRock@outlook.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "BrittannyRock", "BrittannyRock" },
                    { 133, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6280), null, false, null, "CarlitaLara@live.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "CarlitaLara", "CarlitaLara" },
                    { 132, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6272), null, false, null, "JennipherCheryl@live.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "JennipherCheryl", "JennipherCheryl" },
                    { 131, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6264), null, false, null, "NakitaVicent@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "NakitaVicent", "NakitaVicent" },
                    { 130, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6258), null, false, null, "BryceKonstantinos@hotmail.fr", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "BryceKonstantinos", "BryceKonstantinos" },
                    { 129, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6240), null, false, null, "KameshaHerminia@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "KameshaHerminia", "KameshaHerminia" },
                    { 128, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6233), null, false, null, "RubiCaylin@outlook.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "RubiCaylin", "RubiCaylin" },
                    { 127, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6225), null, false, null, "GregroyIrvin@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "GregroyIrvin", "GregroyIrvin" },
                    { 140, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6333), null, false, null, "AnielBari@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "AnielBari", "AnielBari" },
                    { 251, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(7141), null, false, null, "GladysDerric@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "GladysDerric", "GladysDerric" },
                    { 156, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6465), null, false, null, "JesiHong@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "JesiHong", "JesiHong" },
                    { 158, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6480), null, false, null, "JasperRandolph@hotmail.fr", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "JasperRandolph", "JasperRandolph" },
                    { 186, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6699), null, false, null, "DeannaTalena@live.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "DeannaTalena", "DeannaTalena" },
                    { 185, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6694), null, false, null, "RashidLakeisha@outlook.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "RashidLakeisha", "RashidLakeisha" },
                    { 184, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6687), null, false, null, "CorneliaDanielle@hotmail.fr", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "CorneliaDanielle", "CorneliaDanielle" },
                    { 183, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6682), null, false, null, "ShaniqueNaftali@hotmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "ShaniqueNaftali", "ShaniqueNaftali" },
                    { 182, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6677), null, false, null, "KaralynShamika@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "KaralynShamika", "KaralynShamika" },
                    { 181, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6669), null, false, null, "StephonRenard@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "StephonRenard", "StephonRenard" },
                    { 180, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6656), null, false, null, "SaranShena@hotmail.fr", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "SaranShena", "SaranShena" },
                    { 179, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6649), null, false, null, "NatividadKristopher@hotmail.fr", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "NatividadKristopher", "NatividadKristopher" },
                    { 178, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6641), null, false, null, "JeannetteAvis@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "JeannetteAvis", "JeannetteAvis" },
                    { 177, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6635), null, false, null, "KaylieVan@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "KaylieVan", "KaylieVan" },
                    { 176, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6626), null, false, null, "PortiaMontel@hotmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "PortiaMontel", "PortiaMontel" },
                    { 175, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6619), null, false, null, "MeghanCristobal@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "MeghanCristobal", "MeghanCristobal" },
                    { 174, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6612), null, false, null, "GianBernie@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "GianBernie", "GianBernie" },
                    { 157, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6473), null, false, null, "TrumaineDarci@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "TrumaineDarci", "TrumaineDarci" },
                    { 173, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6604), null, false, null, "SharaeDonte@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "SharaeDonte", "SharaeDonte" },
                    { 171, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6588), null, false, null, "MarcelaRayn@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "MarcelaRayn", "MarcelaRayn" },
                    { 170, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6582), null, false, null, "JonnieTennille@live.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "JonnieTennille", "JonnieTennille" },
                    { 169, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6573), null, false, null, "LucienJeanmarie@outlook.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu2?alt=media&token=eae2ebd5-9f56-4b34-b0e4-c400ef4e9d83", null, "LucienJeanmarie", "LucienJeanmarie" },
                    { 168, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6566), null, false, null, "SyreetaKristena@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "SyreetaKristena", "SyreetaKristena" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Created", "CreatorId", "Deleted", "Description", "Email", "ImgProfile", "LasLogin", "Name", "Password" },
                values: new object[,]
                {
                    { 167, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6558), null, false, null, "RowenaJannelle@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "RowenaJannelle", "RowenaJannelle" },
                    { 166, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6550), null, false, null, "ElyshaJonerik@hotmail.co.uk", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "ElyshaJonerik", "ElyshaJonerik" },
                    { 165, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6544), null, false, null, "MiyaMeng@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "MiyaMeng", "MiyaMeng" },
                    { 164, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6536), null, false, null, "MieshaIrene@outlook.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "MieshaIrene", "MieshaIrene" },
                    { 163, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6520), null, false, null, "ReubenNavid@yahoo.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/usuarios%2Fusu1?alt=media&token=150dcf3c-9b94-48c4-b3b0-15df78215526", null, "ReubenNavid", "ReubenNavid" },
                    { 162, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6512), null, false, null, "AngellaIsabella@gmail.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "AngellaIsabella", "AngellaIsabella" },
                    { 161, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6505), null, false, null, "DestiniRashaad@outlook.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "DestiniRashaad", "DestiniRashaad" },
                    { 160, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6496), null, false, null, "RebekahGarnett@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "RebekahGarnett", "RebekahGarnett" },
                    { 159, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6488), null, false, null, "JordanJeramiah@outlook.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre1?alt=media&token=2e98808e-e4ec-4b26-846b-e97b425ecaed", null, "JordanJeramiah", "JordanJeramiah" },
                    { 172, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(6596), null, false, null, "BilliDov@aol.com", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "BilliDov", "BilliDov" },
                    { 503, new DateTime(2021, 12, 16, 13, 43, 24, 261, DateTimeKind.Local).AddTicks(9279), 19, false, null, "creador@creador", "https://firebasestorage.googleapis.com/v0/b/creadoresuy-674c1.appspot.com/o/creadores%2Fcre2?alt=media&token=957cc0e3-6e4a-420a-8624-dd61d0680aff", null, "creador", "creador123" }
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
