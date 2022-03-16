import { gql } from 'apollo-angular';

export const _CREATE_COMMANDE = gql`
mutation($newCommande: CommandeInput!){
  saveCommande(newCommande:$newCommande)
}`;
