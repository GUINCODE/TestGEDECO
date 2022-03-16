using backend.Models;
using backend.Models.Db;
using backend.Models.ManyToMany;

namespace backend.GraphQL
{
    public class Query
    {
        [UseDbContext(typeof(ApplicationDbContext))]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Commande> GetCommandes([ScopedService] ApplicationDbContext context)
        {
            return context.Commande;
        }

        [UseDbContext(typeof(ApplicationDbContext))]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Entreprise> GetEntreprises([ScopedService] ApplicationDbContext context)
        {
            return context.Entreprise;
        }

        [UseDbContext(typeof(ApplicationDbContext))]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Contact> GetContacts([ScopedService] ApplicationDbContext context)
        {
            return context.Contact;
        }

        [UseDbContext(typeof(ApplicationDbContext))]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<CommandePoste> GetCommandePoste([ScopedService] ApplicationDbContext context)
        {
            return context.CommandePoste;
        }
        [UseDbContext(typeof(ApplicationDbContext))]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<RoleDroit> GetRoleDroit([ScopedService] ApplicationDbContext context)
        {
            return context.RoleDroit;
        }
        [UseDbContext(typeof(ApplicationDbContext))]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<AdresseEntreprise> GetAdresses([ScopedService] ApplicationDbContext context)
        {
            return context.AdresseEntreprise;
        }

        [UseDbContext(typeof(ApplicationDbContext))]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<BudgetEotp> GetBudgetEotps([ScopedService] ApplicationDbContext context)
        {
            return context.BudgetEotp;
        }

        [UseDbContext(typeof(ApplicationDbContext))]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Document> GetDocuments([ScopedService] ApplicationDbContext context)
        {
            return context.Document;
        }
        [UseDbContext(typeof(ApplicationDbContext))]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Droit> GetDroits([ScopedService] ApplicationDbContext context)
        {
            return context.Droit;
        }
        [UseDbContext(typeof(ApplicationDbContext))]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Emos> GetEmos([ScopedService] ApplicationDbContext context)
        {
            return context.Emos;
        }
        [UseDbContext(typeof(ApplicationDbContext))]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Eotp> GetEotps([ScopedService] ApplicationDbContext context)
        {
            return context.Eotp;
        }
        [UseDbContext(typeof(ApplicationDbContext))]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<FicheIntervention> GetFicheInterventions([ScopedService] ApplicationDbContext context)
        {
            return context.FicheIntervention;
        }
        [UseDbContext(typeof(ApplicationDbContext))]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Habilitation> GetHabilitations([ScopedService] ApplicationDbContext context)
        {
            return context.Habilitation;
        }
        [UseDbContext(typeof(ApplicationDbContext))]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Ordre> GetOrdres([ScopedService] ApplicationDbContext context)
        {
            return context.Ordre;
        }
        [UseDbContext(typeof(ApplicationDbContext))]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Personnel> GetPersonnels([ScopedService] ApplicationDbContext context)
        {
            return context.Personnel;
        }
        [UseDbContext(typeof(ApplicationDbContext))]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Poste> GetPostes([ScopedService] ApplicationDbContext context)
        {
            return context.Poste;
        }
        [UseDbContext(typeof(ApplicationDbContext))]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Role> GetRoles([ScopedService] ApplicationDbContext context)
        {
            return context.Role;
        }
        [UseDbContext(typeof(ApplicationDbContext))]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<StatutCommande> GetStatutCommandes([ScopedService] ApplicationDbContext context)
        {
            return context.StatutCommande;
        }
        [UseDbContext(typeof(ApplicationDbContext))]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<StatutFi> GetStatutFis([ScopedService] ApplicationDbContext context)
        {
            return context.StatutFi;
        }
        [UseDbContext(typeof(ApplicationDbContext))]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<TypeEmos> GetTypeEmos([ScopedService] ApplicationDbContext context)
        {
            return context.TypeEmos;
        }
        [UseDbContext(typeof(ApplicationDbContext))]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<TypeValidationEmos> GetTypeValidationEmos([ScopedService] ApplicationDbContext context)
        {
            return context.TypeValidationEmos;
        }

        [UseDbContext(typeof(ApplicationDbContext))]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<TypeValidationFi> GetTypeValidationFi([ScopedService] ApplicationDbContext context)
        {
            return context.TypeValidationFi;
        }
        [UseDbContext(typeof(ApplicationDbContext))]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Unite> GetUnites([ScopedService] ApplicationDbContext context)
        {
            return context.Unite;
        }
        [UseDbContext(typeof(ApplicationDbContext))]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<ValidationEmos> GetValidationEmos([ScopedService] ApplicationDbContext context)
        {
            return context.ValidationEmos;
        }
        [UseDbContext(typeof(ApplicationDbContext))]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<ValidationFi> GetValidationFi([ScopedService] ApplicationDbContext context)
        {
            return context.ValidationFi;
        }
    }
}