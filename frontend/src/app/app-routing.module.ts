import { PageNotFoundComponent } from './components/page-not-found/page-not-found.component';
import { AideComponent } from './components/aide/aide.component';
import { UpdateCommandeComponent } from './components/commande/update-commande/update-commande.component';
import { AddCommandeComponent } from './components/commande/add-commande/add-commande.component';
import { DetailsCommandeComponent } from './components/commande/details-commande/details-commande.component';
import { ListsCommandeComponent } from './components/commande/lists-commande/lists-commande.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes =  [
  {path :'commandes',  children: [
      {path : '', component: ListsCommandeComponent},
      { path: ':id', component: DetailsCommandeComponent },
      { path: 'add', component: AddCommandeComponent },
      { path: 'update/:id', component: UpdateCommandeComponent }
    ]},
  {path :'aide', component: AideComponent},
    // { path: '',   redirectTo: 'commandes', pathMatch: 'full' },  //redirect To ListsCommandeComponent
  { path: '**', component: PageNotFoundComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
