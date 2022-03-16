using backend.Models;
using backend.Models.Db;
using backend.Models.ManyToMany;

namespace backend.GraphQL
{
    public class Mutation
    {
        //----------------------------------------------------------------Commande Management --------------------------------

        public async Task<String> SaveCommandeAsync([Service] ApplicationDbContext context, Commande newCommande)
        {
            context.Commande.Add(newCommande);
            await context.SaveChangesAsync();
            return "saved";
        }
        public async Task<String> UpdateCommandeAsync([Service] ApplicationDbContext context, Commande commande)
        {
            context.Commande.Update(commande);
            await context.SaveChangesAsync();
            return "updated";
        }
        public async Task<String> DeleteCommandeAsync([Service] ApplicationDbContext context, int id)
        {
            var cmd = await context.Commande.FindAsync(id);
            if (cmd == null)
            {
                return "not found";
            }
            context.Commande.Remove(cmd);
            await context.SaveChangesAsync();
            return "deleted";
        }

        //----------------------------------------------------------------Entreprise Management --------------------------------
        public async Task<String> SaveEntrepriseAsync([Service] ApplicationDbContext context, Entreprise newEntreprise)
        {
            context.Entreprise.Add(newEntreprise);
            await context.SaveChangesAsync();
            return "saved";
        }
        public async Task<String> UpdateEntrepriseAsync([Service] ApplicationDbContext context, Entreprise entreprise)
        {
            context.Entreprise.Update(entreprise);
            await context.SaveChangesAsync();
            return "updated";
        }
        public async Task<String> DeleteEntrepriseAsync([Service] ApplicationDbContext context, int id)
        {
            var entreprise = await context.Entreprise.FindAsync(id);
            if (entreprise == null)
            {
                return "not found";
            }
            context.Entreprise.Remove(entreprise);
            await context.SaveChangesAsync();
            return "deleted";
        }

        //----------------------------------------------------------------Contact Management --------------------------------
        public async Task<String> SaveContactAsync([Service] ApplicationDbContext context, Contact newContact)
        {
            context.Contact.Add(newContact);
            await context.SaveChangesAsync();
            return "saved";
        }
        public async Task<String> UpdateContactAsync([Service] ApplicationDbContext context, Contact contact)
        {
            context.Contact.Update(contact);
            await context.SaveChangesAsync();
            return "updated";
        }
        public async Task<String> DeleteContactAsync([Service] ApplicationDbContext context, int id)
        {
            var contact = await context.Contact.FindAsync(id);
            if (contact == null)
            {
                return "not found";
            }
            context.Contact.Remove(contact);
            await context.SaveChangesAsync();
            return "deleted";
        }
        //----------------------------------------------------------------AdressesEntreprise Management --------------------------------

        public async Task<String> SaveAdresseAsync([Service] ApplicationDbContext context, AdresseEntreprise newAdresseEntreprise)
        {
            context.AdresseEntreprise.Add(newAdresseEntreprise);
            await context.SaveChangesAsync();
            return "saved";
        }
        public async Task<String> UpdateAdresseAsync([Service] ApplicationDbContext context, AdresseEntreprise adresseEntreprise)
        {
            context.AdresseEntreprise.Update(adresseEntreprise);
            await context.SaveChangesAsync();
            return "updated";
        }
        public async Task<String> DeleteAdresseAsync([Service] ApplicationDbContext context, int id)
        {
            var adresse = await context.AdresseEntreprise.FindAsync(id);
            if (adresse == null)
            {
                return "not found";
            }
            context.AdresseEntreprise.Remove(adresse);
            await context.SaveChangesAsync();
            return "deleted";
        }

        //----------------------------------------------------------------BudgetEotp Management --------------------------------
        public async Task<String> SaveBudgetEotpAsync([Service] ApplicationDbContext context, BudgetEotp newBudgetEotp)
        {
            context.BudgetEotp.Add(newBudgetEotp);
            await context.SaveChangesAsync();
            return "saved";
        }
        public async Task<String> UpdateBudgetEotpAsync([Service] ApplicationDbContext context, BudgetEotp budgetEotp)
        {
            context.BudgetEotp.Update(budgetEotp);
            await context.SaveChangesAsync();
            return "updated";
        }
        public async Task<String> DeleteBudgetEotpAsync([Service] ApplicationDbContext context, int id)
        {
            var budgetEotp = await context.BudgetEotp.FindAsync(id);
            if (budgetEotp == null)
                return "not found";
            context.BudgetEotp.Remove(budgetEotp);
            await context.SaveChangesAsync();
            return "deleted";
        }
        //----------------------------------------------------------------Document Management --------------------------------
        public async Task<String> SaveDocumentAsync([Service] ApplicationDbContext context, Document newDocument)
        {
            context.Document.Add(newDocument);
            await context.SaveChangesAsync();
            return "saved";
        }
        public async Task<String> UpdateDocumentAsync([Service] ApplicationDbContext context, Document document)
        {
            context.Document.Update(document);
            await context.SaveChangesAsync();
            return "updated";
        }
        public async Task<String> DeleteDocumentAsync([Service] ApplicationDbContext context, int id)
        {
            var document = await context.Document.FindAsync(id);
            if (document == null)
            {
                return "not found";
            }
            context.Document.Remove(document);
            await context.SaveChangesAsync();
            return "deleted";
        }
        //----------------------------------------------------------------Droit Management --------------------------------
        public async Task<String> SaveDroitAsync([Service] ApplicationDbContext context, Droit newDroit)
        {
            context.Droit.Add(newDroit);
            await context.SaveChangesAsync();
            return "saved";
        }
        public async Task<String> UpdateDroitAsync([Service] ApplicationDbContext context, Droit droit)
        {
            context.Droit.Update(droit);
            await context.SaveChangesAsync();
            return "updated";
        }
        public async Task<String> DeleteDroitAsync([Service] ApplicationDbContext context, int id)
        {
            var droit = await context.Droit.FindAsync(id);
            if (droit == null)
            {
                return "not found";
            }
            context.Droit.Remove(droit);
            await context.SaveChangesAsync();
            return "deleted";
        }
        //----------------------------------------------------------------Emos Management --------------------------------
        public async Task<String> SaveEmosAsync([Service] ApplicationDbContext context, Emos newEmos)
        {
            context.Emos.Add(newEmos);
            await context.SaveChangesAsync();
            return "saved";
        }
        public async Task<String> UpdateEmosAsync([Service] ApplicationDbContext context, Emos emos)
        {
            context.Emos.Update(emos);
            await context.SaveChangesAsync();
            return "updated";
        }
        public async Task<String> DeleteEmosAsync([Service] ApplicationDbContext context, int id)
        {
            var emos = await context.Emos.FindAsync(id);
            if (emos == null)
            {
                return "not found";
            }
            context.Emos.Remove(emos);
            await context.SaveChangesAsync();
            return "deleted";
        }
        //----------------------------------------------------------------Eotp Management --------------------------------
        public async Task<String> SaveEotpAsync([Service] ApplicationDbContext context, Eotp newEotp)
        {
            context.Eotp.Add(newEotp);
            await context.SaveChangesAsync();
            return "saved";
        }
        public async Task<String> UpdateEotpAsync([Service] ApplicationDbContext context, Eotp eotp)
        {
            context.Eotp.Update(eotp);
            await context.SaveChangesAsync();
            return "updated";
        }
        public async Task<String> DeleteEotpAsync([Service] ApplicationDbContext context, int id)
        {
            var eotp = await context.Eotp.FindAsync(id);
            if (eotp == null)
            {
                return "not found";
            }
            context.Eotp.Remove(eotp);
            await context.SaveChangesAsync();
            return "deleted";
        }
        //----------------------------------------------------------------FicheIntervention Management --------------------------------
        public async Task<String> SaveFicheInterventionAsync([Service] ApplicationDbContext context, FicheIntervention newFI)
        {
            context.FicheIntervention.Add(newFI);
            await context.SaveChangesAsync();
            return "saved";
        }
        public async Task<String> UpdateFicheInterventionAsync([Service] ApplicationDbContext context, FicheIntervention fi)
        {
            context.FicheIntervention.Update(fi);
            await context.SaveChangesAsync();
            return "updated";
        }
        public async Task<String> DeleteFicheInterventionAsync([Service] ApplicationDbContext context, int id)
        {
            var fi = await context.FicheIntervention.FindAsync(id);
            if (fi == null)
            {
                return "not found";
            }
            context.FicheIntervention.Remove(fi);
            await context.SaveChangesAsync();
            return "deleted";
        }
        //----------------------------------------------------------------Habilitation Management --------------------------------
        public async Task<String> SaveHabilitationAsync([Service] ApplicationDbContext context, Habilitation newHabilitation)
        {
            context.Habilitation.Add(newHabilitation);
            await context.SaveChangesAsync();
            return "saved";
        }
        public async Task<String> UpdateHabilitationAsync([Service] ApplicationDbContext context, Habilitation habilitation)
        {
            context.Habilitation.Update(habilitation);
            await context.SaveChangesAsync();
            return "updated";
        }
        public async Task<String> DeleteHabilitationAsync([Service] ApplicationDbContext context, int id)
        {
            var habilitation = await context.Habilitation.FindAsync(id);
            if (habilitation == null)
            {
                return "not found";
            }
            context.Habilitation.Remove(habilitation);
            await context.SaveChangesAsync();
            return "deleted";
        }
        //----------------------------------------------------------------Ordre Management --------------------------------
        public async Task<String> SaveOrdreAsync([Service] ApplicationDbContext context, Ordre newOrdre)
        {
            context.Ordre.Add(newOrdre);
            await context.SaveChangesAsync();
            return "saved";
        }
        public async Task<String> UpdateOrdreAsync([Service] ApplicationDbContext context, Ordre ordre)
        {
            context.Ordre.Update(ordre);
            await context.SaveChangesAsync();
            return "updated";
        }
        public async Task<String> DeleteOrdreAsync([Service] ApplicationDbContext context, int id)
        {
            var ordre = await context.Ordre.FindAsync(id);
            if (ordre == null)
            {
                return "not found";
            }
            context.Ordre.Remove(ordre);
            await context.SaveChangesAsync();
            return "deleted";
        }
        //----------------------------------------------------------------Personnel Management --------------------------------
        public async Task<String> SavePersonnelAsync([Service] ApplicationDbContext context, Personnel newPersonnel)
        {
            context.Personnel.Add(newPersonnel);
            await context.SaveChangesAsync();
            return "saved";
        }
        public async Task<String> UpdatePersonnelAsync([Service] ApplicationDbContext context, Personnel personnel)
        {
            context.Personnel.Update(personnel);
            await context.SaveChangesAsync();
            return "updated";
        }
        public async Task<String> DeletePersonnelAsync([Service] ApplicationDbContext context, int id)
        {
            var personnel = await context.Personnel.FindAsync(id);
            if (personnel == null)
            {
                return "not found";
            }
            context.Personnel.Remove(personnel);
            await context.SaveChangesAsync();
            return "deleted";
        }
        //----------------------------------------------------------------Poste Management --------------------------------
        public async Task<String> SavePosteAsync([Service] ApplicationDbContext context, Poste newPoste)
        {
            context.Poste.Add(newPoste);
            await context.SaveChangesAsync();
            return "saved";
        }
        public async Task<String> UpdatePosteAsync([Service] ApplicationDbContext context, Poste poste)
        {
            context.Poste.Update(poste);
            await context.SaveChangesAsync();
            return "updated";
        }
        public async Task<String> DeletePosteAsync([Service] ApplicationDbContext context, int id)
        {
            var poste = await context.Poste.FindAsync(id);
            if (poste == null)
            {
                return "not found";
            }
            context.Poste.Remove(poste);
            await context.SaveChangesAsync();
            return "deleted";
        }
        //----------------------------------------------------------------Role Management --------------------------------
        public async Task<String> SaveRoleAsync([Service] ApplicationDbContext context, Role newRole)
        {
            context.Role.Add(newRole);
            await context.SaveChangesAsync();
            return "saved";
        }
        public async Task<String> UpdateRoleAsync([Service] ApplicationDbContext context, Role role)
        {
            context.Role.Update(role);
            await context.SaveChangesAsync();
            return "updated";
        }
        public async Task<String> DeleteRoleAsync([Service] ApplicationDbContext context, int id)
        {
            var role = await context.Role.FindAsync(id);
            if (role == null)
            {
                return "not found";
            }
            context.Role.Remove(role);
            await context.SaveChangesAsync();
            return "deleted";
        }
        //----------------------------------------------------------------StatutCommande Management --------------------------------
        public async Task<String> SaveStatutCommandeAsync([Service] ApplicationDbContext context, StatutCommande newStatutCommande)
        {
            context.StatutCommande.Add(newStatutCommande);
            await context.SaveChangesAsync();
            return "saved";
        }
        public async Task<String> UpdateStatutCommandeAsync([Service] ApplicationDbContext context, StatutCommande statutCommande)
        {
            context.StatutCommande.Update(statutCommande);
            await context.SaveChangesAsync();
            return "updated";
        }
        public async Task<String> DeleteStatutCommandeAsync([Service] ApplicationDbContext context, int id)
        {
            var statutCommande = await context.StatutCommande.FindAsync(id);
            if (statutCommande == null)
            {
                return "not found";
            }
            context.StatutCommande.Remove(statutCommande);
            await context.SaveChangesAsync();
            return "deleted";
        }
        //----------------------------------------------------------------StatutFi Management --------------------------------
        public async Task<String> SaveStatutFiAsync([Service] ApplicationDbContext context, StatutFi newStatutFi)
        {
            context.StatutFi.Add(newStatutFi);
            await context.SaveChangesAsync();
            return "saved";
        }
        public async Task<String> UpdateStatutFiAsync([Service] ApplicationDbContext context, StatutFi statutFi)
        {
            context.StatutFi.Update(statutFi);
            await context.SaveChangesAsync();
            return "updated";
        }
        public async Task<String> DeleteStatutFiAsync([Service] ApplicationDbContext context, int id)
        {
            var statutFi = await context.StatutFi.FindAsync(id);
            if (statutFi == null)
            {
                return "not found";
            }
            context.StatutFi.Remove(statutFi);
            await context.SaveChangesAsync();
            return "deleted";
        }
        //----------------------------------------------------------------TypeEmos Management --------------------------------
        public async Task<String> SaveTypeEmosAsync([Service] ApplicationDbContext context, TypeEmos newTypeEmos)
        {
            context.TypeEmos.Add(newTypeEmos);
            await context.SaveChangesAsync();
            return "saved";
        }
        public async Task<String> UpdateTypeEmosAsync([Service] ApplicationDbContext context, TypeEmos typeEmos)
        {
            context.TypeEmos.Update(typeEmos);
            await context.SaveChangesAsync();
            return "updated";
        }
        public async Task<String> DeleteTypeEmosAsync([Service] ApplicationDbContext context, int id)
        {
            var typeEmos = await context.TypeEmos.FindAsync(id);
            if (typeEmos == null)
            {
                return "not found";
            }
            context.TypeEmos.Remove(typeEmos);
            await context.SaveChangesAsync();
            return "deleted";
        }
        //----------------------------------------------------------------TypeValidationEmos Management --------------------------------
        public async Task<String> SaveTypeValidationEmosAsync([Service] ApplicationDbContext context, TypeValidationEmos newTypeValidationEmos)
        {
            context.TypeValidationEmos.Add(newTypeValidationEmos);
            await context.SaveChangesAsync();
            return "saved";
        }
        public async Task<String> UpdateTypeValidationEmosAsync([Service] ApplicationDbContext context, TypeValidationEmos typeValidationEmos)
        {
            context.TypeValidationEmos.Update(typeValidationEmos);
            await context.SaveChangesAsync();
            return "updated";
        }
        public async Task<String> DeleteTypeValidationEmosAsync([Service] ApplicationDbContext context, int id)
        {
            var typeValidationEmos = await context.TypeValidationEmos.FindAsync(id);
            if (typeValidationEmos == null)
            {
                return "not found";
            }
            context.TypeValidationEmos.Remove(typeValidationEmos);
            await context.SaveChangesAsync();
            return "deleted";
        }
        //----------------------------------------------------------------TypeValidationFi Management --------------------------------
        public async Task<String> SaveTypeValidationFiAsync([Service] ApplicationDbContext context, TypeValidationFi newTypeValidationFi)
        {
            context.TypeValidationFi.Add(newTypeValidationFi);
            await context.SaveChangesAsync();
            return "saved";
        }
        public async Task<String> UpdateTypeValidationFiAsync([Service] ApplicationDbContext context, TypeValidationFi typeValidationFi)
        {
            context.TypeValidationFi.Update(typeValidationFi);
            await context.SaveChangesAsync();
            return "updated";
        }
        public async Task<String> DeleteTypeValidationFiAsync([Service] ApplicationDbContext context, int id)
        {
            var typeValidationFi = await context.TypeValidationFi.FindAsync(id);
            if (typeValidationFi == null)
            {
                return "not found";
            }
            context.TypeValidationFi.Remove(typeValidationFi);
            await context.SaveChangesAsync();
            return "deleted";
        }
        //----------------------------------------------------------------Unite Management --------------------------------
        public async Task<String> SaveUniteAsync([Service] ApplicationDbContext context, Unite newUnite)
        {
            context.Unite.Add(newUnite);
            await context.SaveChangesAsync();
            return "saved";
        }
        public async Task<String> UpdateUniteAsync([Service] ApplicationDbContext context, Unite unite)
        {
            context.Unite.Update(unite);
            await context.SaveChangesAsync();
            return "updated";
        }
        public async Task<String> DeleteUniteAsync([Service] ApplicationDbContext context, int id)
        {
            var unite = await context.Unite.FindAsync(id);
            if (unite == null)
            {
                return "not found";
            }
            context.Unite.Remove(unite);
            await context.SaveChangesAsync();
            return "deleted";
        }
        //----------------------------------------------------------------ValidationEmos Management --------------------------------
        public async Task<String> SaveValidationEmosAsync([Service] ApplicationDbContext context, ValidationEmos newValidationEmos)
        {
            context.ValidationEmos.Add(newValidationEmos);
            await context.SaveChangesAsync();
            return "saved";
        }
        public async Task<String> UpdateValidationEmosAsync([Service] ApplicationDbContext context, ValidationEmos validationEmos)
        {
            context.ValidationEmos.Update(validationEmos);
            await context.SaveChangesAsync();
            return "updated";
        }
        public async Task<String> DeleteValidationEmosAsync([Service] ApplicationDbContext context, int id)
        {
            var validationEmos = await context.ValidationEmos.FindAsync(id);
            if (validationEmos == null)
            {
                return "not found";
            }
            context.ValidationEmos.Remove(validationEmos);
            await context.SaveChangesAsync();
            return "deleted";
        }
        //----------------------------------------------------------------ValidationFi Management --------------------------------
        public async Task<String> SaveValidationFiAsync([Service] ApplicationDbContext context, ValidationFi newValidationFi)
        {
            context.ValidationFi.Add(newValidationFi);
            await context.SaveChangesAsync();
            return "saved";
        }
        public async Task<String> UpdateValidationFiAsync([Service] ApplicationDbContext context, ValidationFi validationFi)
        {
            context.ValidationFi.Update(validationFi);
            await context.SaveChangesAsync();
            return "updated";
        }
        public async Task<String> DeleteValidationFiAsync([Service] ApplicationDbContext context, int id)
        {
            var validationFi = await context.ValidationFi.FindAsync(id);
            if (validationFi == null)
            {
                return "not found";
            }
            context.ValidationFi.Remove(validationFi);
            await context.SaveChangesAsync();
            return "deleted";
        }
        //----------------------------------------------------------------CommandePoste Management --------------------------------
        public async Task<String> SaveCommandePosteAsync([Service] ApplicationDbContext context, CommandePoste newCommandePoste)
        {
            context.CommandePoste.Add(newCommandePoste);
            await context.SaveChangesAsync();
            return "saved";
        }
        public async Task<String> UpdateCommandePosteAsync([Service] ApplicationDbContext context, CommandePoste commandePoste)
        {
            context.CommandePoste.Update(commandePoste);
            await context.SaveChangesAsync();
            return "updated";
        }
        public async Task<String> DeleteCommandePosteAsync([Service] ApplicationDbContext context, int id)
        {
            var commandePoste = await context.CommandePoste.FindAsync(id);
            if (commandePoste == null)
            {
                return "not found";
            }
            context.CommandePoste.Remove(commandePoste);
            await context.SaveChangesAsync();
            return "deleted";
        }
        //----------------------------------------------------------------RoleDroit Management --------------------------------
        public async Task<String> SaveRoleDroitAsync([Service] ApplicationDbContext context, RoleDroit newRoleDroit)
        {
            context.RoleDroit.Add(newRoleDroit);
            await context.SaveChangesAsync();
            return "saved";
        }
        public async Task<String> UpdateRoleDroitAsync([Service] ApplicationDbContext context, RoleDroit roleDroit)
        {
            context.RoleDroit.Update(roleDroit);
            await context.SaveChangesAsync();
            return "updated";
        }
        public async Task<String> DeleteRoleDroitAsync([Service] ApplicationDbContext context, int id)
        {
            var roleDroit = await context.RoleDroit.FindAsync(id);
            if (roleDroit == null)
            {
                return "not found";
            }
            context.RoleDroit.Remove(roleDroit);
            await context.SaveChangesAsync();
            return "deleted";
        }
    }
}
