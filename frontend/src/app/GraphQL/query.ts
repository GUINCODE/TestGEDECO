import { gql } from 'apollo-angular';

export const   _GET_ENTREPRISES = gql`
 query{
  entreprises{
    id
    nom
    siren
  }
}
`;
