import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { GraphQLModule } from './graphql.module';
import { HttpClientModule } from '@angular/common/http';
import { NZ_I18N } from 'ng-zorro-antd/i18n';
import { fr_FR } from 'ng-zorro-antd/i18n';
import { registerLocaleData } from '@angular/common';
import fr from '@angular/common/locales/fr';
import { FormsModule } from '@angular/forms';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AddCommandeComponent } from './components/commande/add-commande/add-commande.component';

import { DetailsCommandeComponent } from './components/commande/details-commande/details-commande.component';
import { ListsCommandeComponent } from './components/commande/lists-commande/lists-commande.component';
import { ListsEntrepriseComponent } from './components/entreprise/lists-entreprise/lists-entreprise.component';
import { AddEntrepriseComponent } from './components/entreprise/add-entreprise/add-entreprise.component';
import { DetailsEntrepriseComponent } from './components/entreprise/details-entreprise/details-entreprise.component';
import { UpdateCommandeComponent } from './components/commande/update-commande/update-commande.component';
import { AideComponent } from './components/aide/aide.component';
import { PageNotFoundComponent } from './components/page-not-found/page-not-found.component';
import { UpdateEntrepriseComponent } from './components/entreprise/update-entreprise/update-entreprise.component';
import { FooterComponent } from './shared/components/footer/footer.component';
import { HeaderComponent } from './shared/components/header/header.component';
import { NzIconModule } from 'ng-zorro-antd/icon';
import { MenuComponent } from './shared/components/header/menu/menu.component';

registerLocaleData(fr);

@NgModule({
  declarations: [
    AppComponent,
    AddCommandeComponent,
    DetailsCommandeComponent,
    ListsCommandeComponent,
    ListsEntrepriseComponent,
    AddEntrepriseComponent,
    DetailsEntrepriseComponent,
    UpdateCommandeComponent,
    AideComponent,
    PageNotFoundComponent,
    UpdateEntrepriseComponent,
    FooterComponent,
    HeaderComponent,
    MenuComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    GraphQLModule,
    HttpClientModule,
    FormsModule,
    BrowserAnimationsModule,
    NzIconModule,
  ],
  providers: [{ provide: NZ_I18N, useValue: fr_FR }],
  bootstrap: [AppComponent]
})
export class AppModule { }
