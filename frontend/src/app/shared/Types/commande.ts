export interface Commande {
  id: number
  numCommnade: string
  libelle: string
  nomCourt: number
  montantTotal: number
  montantAnnuelEstimer: number
  seuilEMOS_Specifique: number
  dateDebut: Date
  dateFin: Date
  nombreMois: number
  commentaire: string
  statutCommandeId: number
  entrepriseId: number
  acheteurId: number
}
