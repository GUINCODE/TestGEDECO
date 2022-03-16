using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    public partial class InitialeCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Droit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Droit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Entreprise",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Siren = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entreprise", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personnel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Matricule = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UltimusResp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    ResponsableId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personnel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personnel_Personnel_ResponsableId",
                        column: x => x.ResponsableId,
                        principalTable: "Personnel",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StatutCommande",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatutCommande", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StatutFi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatutFi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeValidationEmos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeValidationEmos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeValidationFi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeValidationFi", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Unite",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActif = table.Column<bool>(type: "bit", nullable: false),
                    CodePostale = table.Column<int>(type: "int", nullable: true),
                    Ville = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Region = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Telephone = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Fax = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Direction = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Departement = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Service = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Bureau = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unite", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AdresseEntreprise",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adresse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CondePostale = table.Column<int>(type: "int", nullable: true),
                    Ville = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntrepriseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdresseEntreprise", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AdresseEntreprise_Entreprise_EntrepriseId",
                        column: x => x.EntrepriseId,
                        principalTable: "Entreprise",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelephonePro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MailPro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDefault = table.Column<bool>(type: "bit", nullable: true),
                    EntrepriseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contact_Entreprise_EntrepriseId",
                        column: x => x.EntrepriseId,
                        principalTable: "Entreprise",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RoleDroit",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    DroitId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleDroit", x => new { x.RoleId, x.DroitId });
                    table.ForeignKey(
                        name: "FK_RoleDroit_Droit_DroitId",
                        column: x => x.DroitId,
                        principalTable: "Droit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleDroit_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Commande",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumCommnade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NomCourt = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MontantTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MontantAnnuelEstimer = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SeuilEMOS_Specifique = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DateDebut = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateFin = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NombreMois = table.Column<int>(type: "int", nullable: false),
                    Commentaire = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatutCommandeId = table.Column<int>(type: "int", nullable: true),
                    EntrepriseId = table.Column<int>(type: "int", nullable: true),
                    AcheteurId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Commande", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Commande_Entreprise_EntrepriseId",
                        column: x => x.EntrepriseId,
                        principalTable: "Entreprise",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Commande_Personnel_AcheteurId",
                        column: x => x.AcheteurId,
                        principalTable: "Personnel",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Commande_StatutCommande_StatutCommandeId",
                        column: x => x.StatutCommandeId,
                        principalTable: "StatutCommande",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Habilitation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: true),
                    UniteId = table.Column<int>(type: "int", nullable: true),
                    Personnelid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habilitation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Habilitation_Personnel_Personnelid",
                        column: x => x.Personnelid,
                        principalTable: "Personnel",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Habilitation_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Habilitation_Unite_UniteId",
                        column: x => x.UniteId,
                        principalTable: "Unite",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Document",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Commentaire = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AttachmentId = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CommandeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Document_Commande_CommandeId",
                        column: x => x.CommandeId,
                        principalTable: "Commande",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Ordre",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Chrono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CommandeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ordre", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ordre_Commande_CommandeId",
                        column: x => x.CommandeId,
                        principalTable: "Commande",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Eotp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrdreId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eotp", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Eotp_Ordre_OrdreId",
                        column: x => x.OrdreId,
                        principalTable: "Ordre",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TypeEmos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrdreId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeEmos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TypeEmos_Ordre_OrdreId",
                        column: x => x.OrdreId,
                        principalTable: "Ordre",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BudgetEotp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Annee = table.Column<int>(type: "int", nullable: false),
                    BudgetInitiale = table.Column<double>(type: "float", nullable: true),
                    BudgetPrevisionnel = table.Column<double>(type: "float", nullable: true),
                    Budgetrevise1 = table.Column<double>(type: "float", nullable: true),
                    Budgetrevise2 = table.Column<double>(type: "float", nullable: true),
                    Budgetrevise3 = table.Column<double>(type: "float", nullable: true),
                    EotpId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BudgetEotp", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BudgetEotp_Eotp_EotpId",
                        column: x => x.EotpId,
                        principalTable: "Eotp",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Emos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    MontantInitiale = table.Column<double>(type: "float", nullable: false),
                    Montant = table.Column<double>(type: "float", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsAvancement = table.Column<bool>(type: "bit", nullable: false),
                    Avancement = table.Column<double>(type: "float", nullable: false),
                    IsEmisEM = table.Column<bool>(type: "bit", nullable: false),
                    DateEmisEM = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsHorsForfait = table.Column<bool>(type: "bit", nullable: false),
                    IsCancel = table.Column<bool>(type: "bit", nullable: false),
                    IsWorkflowSuccessuful = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    TypeEmosId = table.Column<int>(type: "int", nullable: true),
                    CommandeId = table.Column<int>(type: "int", nullable: true),
                    CreerParId = table.Column<int>(type: "int", nullable: true),
                    EotpId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Emos_Commande_CommandeId",
                        column: x => x.CommandeId,
                        principalTable: "Commande",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Emos_Eotp_EotpId",
                        column: x => x.EotpId,
                        principalTable: "Eotp",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Emos_Personnel_CreerParId",
                        column: x => x.CreerParId,
                        principalTable: "Personnel",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Emos_TypeEmos_TypeEmosId",
                        column: x => x.TypeEmosId,
                        principalTable: "TypeEmos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FicheIntervention",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Installation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateDevis = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateFinTravaux = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCloture = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Montant = table.Column<double>(type: "float", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Regularisation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EotpId = table.Column<int>(type: "int", nullable: true),
                    EmosId = table.Column<int>(type: "int", nullable: true),
                    CommandeId = table.Column<int>(type: "int", nullable: true),
                    DemandeurId = table.Column<int>(type: "int", nullable: true),
                    OrdreId = table.Column<int>(type: "int", nullable: true),
                    StatusFiId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FicheIntervention", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FicheIntervention_Commande_CommandeId",
                        column: x => x.CommandeId,
                        principalTable: "Commande",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FicheIntervention_Emos_EmosId",
                        column: x => x.EmosId,
                        principalTable: "Emos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FicheIntervention_Eotp_EotpId",
                        column: x => x.EotpId,
                        principalTable: "Eotp",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FicheIntervention_Ordre_OrdreId",
                        column: x => x.OrdreId,
                        principalTable: "Ordre",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FicheIntervention_Personnel_DemandeurId",
                        column: x => x.DemandeurId,
                        principalTable: "Personnel",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FicheIntervention_StatutFi_StatusFiId",
                        column: x => x.StatusFiId,
                        principalTable: "StatutFi",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Poste",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MontantInitiale = table.Column<double>(type: "float", nullable: false),
                    MontantEngage = table.Column<double>(type: "float", nullable: false),
                    MontantRestant = table.Column<double>(type: "float", nullable: false),
                    IsForfait = table.Column<bool>(type: "bit", nullable: false),
                    IsCloture = table.Column<bool>(type: "bit", nullable: false),
                    EotpId = table.Column<int>(type: "int", nullable: true),
                    EmosId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Poste", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Poste_Emos_EmosId",
                        column: x => x.EmosId,
                        principalTable: "Emos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Poste_Eotp_EotpId",
                        column: x => x.EotpId,
                        principalTable: "Eotp",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ValidationEmos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmosId = table.Column<int>(type: "int", nullable: true),
                    TypeValidationEmosId = table.Column<int>(type: "int", nullable: true),
                    ValideurId = table.Column<int>(type: "int", nullable: true),
                    DateValidation = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StatutFiId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ValidationEmos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ValidationEmos_Emos_EmosId",
                        column: x => x.EmosId,
                        principalTable: "Emos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ValidationEmos_Personnel_ValideurId",
                        column: x => x.ValideurId,
                        principalTable: "Personnel",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ValidationEmos_StatutFi_StatutFiId",
                        column: x => x.StatutFiId,
                        principalTable: "StatutFi",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ValidationEmos_TypeValidationEmos_TypeValidationEmosId",
                        column: x => x.TypeValidationEmosId,
                        principalTable: "TypeValidationEmos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ValidationFi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeValidationId = table.Column<int>(type: "int", nullable: true),
                    FicheInterventionId = table.Column<int>(type: "int", nullable: true),
                    ValideurId = table.Column<int>(type: "int", nullable: true),
                    DateValidation = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ValidationFi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ValidationFi_FicheIntervention_FicheInterventionId",
                        column: x => x.FicheInterventionId,
                        principalTable: "FicheIntervention",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ValidationFi_Personnel_ValideurId",
                        column: x => x.ValideurId,
                        principalTable: "Personnel",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ValidationFi_TypeValidationFi_TypeValidationId",
                        column: x => x.TypeValidationId,
                        principalTable: "TypeValidationFi",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CommandePoste",
                columns: table => new
                {
                    CommandeId = table.Column<int>(type: "int", nullable: false),
                    PosteId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommandePoste", x => new { x.CommandeId, x.PosteId });
                    table.ForeignKey(
                        name: "FK_CommandePoste_Commande_CommandeId",
                        column: x => x.CommandeId,
                        principalTable: "Commande",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CommandePoste_Poste_PosteId",
                        column: x => x.PosteId,
                        principalTable: "Poste",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdresseEntreprise_EntrepriseId",
                table: "AdresseEntreprise",
                column: "EntrepriseId");

            migrationBuilder.CreateIndex(
                name: "IX_BudgetEotp_EotpId",
                table: "BudgetEotp",
                column: "EotpId");

            migrationBuilder.CreateIndex(
                name: "IX_Commande_AcheteurId",
                table: "Commande",
                column: "AcheteurId");

            migrationBuilder.CreateIndex(
                name: "IX_Commande_EntrepriseId",
                table: "Commande",
                column: "EntrepriseId");

            migrationBuilder.CreateIndex(
                name: "IX_Commande_StatutCommandeId",
                table: "Commande",
                column: "StatutCommandeId");

            migrationBuilder.CreateIndex(
                name: "IX_CommandePoste_PosteId",
                table: "CommandePoste",
                column: "PosteId");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_EntrepriseId",
                table: "Contact",
                column: "EntrepriseId");

            migrationBuilder.CreateIndex(
                name: "IX_Document_CommandeId",
                table: "Document",
                column: "CommandeId");

            migrationBuilder.CreateIndex(
                name: "IX_Emos_CommandeId",
                table: "Emos",
                column: "CommandeId");

            migrationBuilder.CreateIndex(
                name: "IX_Emos_CreerParId",
                table: "Emos",
                column: "CreerParId");

            migrationBuilder.CreateIndex(
                name: "IX_Emos_EotpId",
                table: "Emos",
                column: "EotpId");

            migrationBuilder.CreateIndex(
                name: "IX_Emos_TypeEmosId",
                table: "Emos",
                column: "TypeEmosId");

            migrationBuilder.CreateIndex(
                name: "IX_Eotp_OrdreId",
                table: "Eotp",
                column: "OrdreId");

            migrationBuilder.CreateIndex(
                name: "IX_FicheIntervention_CommandeId",
                table: "FicheIntervention",
                column: "CommandeId");

            migrationBuilder.CreateIndex(
                name: "IX_FicheIntervention_DemandeurId",
                table: "FicheIntervention",
                column: "DemandeurId");

            migrationBuilder.CreateIndex(
                name: "IX_FicheIntervention_EmosId",
                table: "FicheIntervention",
                column: "EmosId");

            migrationBuilder.CreateIndex(
                name: "IX_FicheIntervention_EotpId",
                table: "FicheIntervention",
                column: "EotpId");

            migrationBuilder.CreateIndex(
                name: "IX_FicheIntervention_OrdreId",
                table: "FicheIntervention",
                column: "OrdreId");

            migrationBuilder.CreateIndex(
                name: "IX_FicheIntervention_StatusFiId",
                table: "FicheIntervention",
                column: "StatusFiId");

            migrationBuilder.CreateIndex(
                name: "IX_Habilitation_Personnelid",
                table: "Habilitation",
                column: "Personnelid");

            migrationBuilder.CreateIndex(
                name: "IX_Habilitation_RoleId",
                table: "Habilitation",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Habilitation_UniteId",
                table: "Habilitation",
                column: "UniteId");

            migrationBuilder.CreateIndex(
                name: "IX_Ordre_CommandeId",
                table: "Ordre",
                column: "CommandeId");

            migrationBuilder.CreateIndex(
                name: "IX_Personnel_ResponsableId",
                table: "Personnel",
                column: "ResponsableId");

            migrationBuilder.CreateIndex(
                name: "IX_Poste_EmosId",
                table: "Poste",
                column: "EmosId");

            migrationBuilder.CreateIndex(
                name: "IX_Poste_EotpId",
                table: "Poste",
                column: "EotpId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleDroit_DroitId",
                table: "RoleDroit",
                column: "DroitId");

            migrationBuilder.CreateIndex(
                name: "IX_TypeEmos_OrdreId",
                table: "TypeEmos",
                column: "OrdreId");

            migrationBuilder.CreateIndex(
                name: "IX_ValidationEmos_EmosId",
                table: "ValidationEmos",
                column: "EmosId");

            migrationBuilder.CreateIndex(
                name: "IX_ValidationEmos_StatutFiId",
                table: "ValidationEmos",
                column: "StatutFiId");

            migrationBuilder.CreateIndex(
                name: "IX_ValidationEmos_TypeValidationEmosId",
                table: "ValidationEmos",
                column: "TypeValidationEmosId");

            migrationBuilder.CreateIndex(
                name: "IX_ValidationEmos_ValideurId",
                table: "ValidationEmos",
                column: "ValideurId");

            migrationBuilder.CreateIndex(
                name: "IX_ValidationFi_FicheInterventionId",
                table: "ValidationFi",
                column: "FicheInterventionId");

            migrationBuilder.CreateIndex(
                name: "IX_ValidationFi_TypeValidationId",
                table: "ValidationFi",
                column: "TypeValidationId");

            migrationBuilder.CreateIndex(
                name: "IX_ValidationFi_ValideurId",
                table: "ValidationFi",
                column: "ValideurId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdresseEntreprise");

            migrationBuilder.DropTable(
                name: "BudgetEotp");

            migrationBuilder.DropTable(
                name: "CommandePoste");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "Document");

            migrationBuilder.DropTable(
                name: "Habilitation");

            migrationBuilder.DropTable(
                name: "RoleDroit");

            migrationBuilder.DropTable(
                name: "ValidationEmos");

            migrationBuilder.DropTable(
                name: "ValidationFi");

            migrationBuilder.DropTable(
                name: "Poste");

            migrationBuilder.DropTable(
                name: "Unite");

            migrationBuilder.DropTable(
                name: "Droit");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "TypeValidationEmos");

            migrationBuilder.DropTable(
                name: "FicheIntervention");

            migrationBuilder.DropTable(
                name: "TypeValidationFi");

            migrationBuilder.DropTable(
                name: "Emos");

            migrationBuilder.DropTable(
                name: "StatutFi");

            migrationBuilder.DropTable(
                name: "Eotp");

            migrationBuilder.DropTable(
                name: "TypeEmos");

            migrationBuilder.DropTable(
                name: "Ordre");

            migrationBuilder.DropTable(
                name: "Commande");

            migrationBuilder.DropTable(
                name: "Entreprise");

            migrationBuilder.DropTable(
                name: "Personnel");

            migrationBuilder.DropTable(
                name: "StatutCommande");
        }
    }
}
