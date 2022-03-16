using backend.Models.ManyToMany;
using Microsoft.EntityFrameworkCore;

namespace backend.Models.Db
{
    public class ApplicationDbContext : DbContext
    {
        // public ApplicationDbContext() { }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Initial Catalog=DBName;Integrated Security=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configuration many To many relationships
            modelBuilder.Entity<CommandePoste>().HasKey(sc => new { sc.CommandeId, sc.PosteId });   

            modelBuilder.Entity<CommandePoste>()
                            .HasOne<Commande>(sc => sc.Commande)
                            .WithMany(s => s.CommandePostes)
                            .HasForeignKey(sc => sc.CommandeId);

            modelBuilder.Entity<CommandePoste>()
                            .HasOne<Poste>(sc => sc.Poste)
                            .WithMany(s => s.CommandePostes)
                            .HasForeignKey(sc => sc.PosteId);

            modelBuilder.Entity<RoleDroit>().HasKey(sc => new { sc.RoleId, sc.DroitId }); 

            modelBuilder.Entity<RoleDroit>()
                            .HasOne<Role>(sc => sc.Role)
                            .WithMany(s => s.RoleDroits)
                            .HasForeignKey(sc => sc.RoleId);

            modelBuilder.Entity<RoleDroit>()
                              .HasOne<Droit>(sc => sc.Droit)
                              .WithMany(s => s.RoleDroits)
                              .HasForeignKey(sc => sc.DroitId);
        }

        public DbSet<CommandePoste> CommandePoste { get; set; }
        public DbSet<RoleDroit> RoleDroit { get; set; }
        public DbSet<AdresseEntreprise> AdresseEntreprise { get; set; }
        public DbSet<BudgetEotp> BudgetEotp { get; set; }
        public DbSet<Commande> Commande { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Document> Document { get; set; }
        public DbSet<Droit> Droit { get; set; }
        public DbSet<Emos> Emos { get; set; }
        public DbSet<Entreprise> Entreprise { get; set; }
        public DbSet<Eotp> Eotp { get; set; }
        public DbSet<FicheIntervention> FicheIntervention { get; set; }
        public DbSet<Ordre> Ordre { get; set; }
        public DbSet<Personnel> Personnel { get; set; }
        public DbSet<Poste> Poste { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<StatutCommande> StatutCommande { get; set; }
        public DbSet<StatutFi> StatutFi { get; set; }
        public DbSet<TypeEmos> TypeEmos { get; set; }
        public DbSet<TypeValidationEmos> TypeValidationEmos { get; set; }
        public DbSet<TypeValidationFi> TypeValidationFi { get; set; }
        public DbSet<Unite> Unite { get; set; }
        public DbSet<ValidationEmos> ValidationEmos { get; set; }
        public DbSet<ValidationFi> ValidationFi { get; set; }
        public DbSet<Habilitation> Habilitation { get; set; }
    }
}