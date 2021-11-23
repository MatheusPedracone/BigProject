
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { DashboardComponent } from './componets/dashboard/dashboard.component';
import { PalestrantesComponent } from './componets/palestrantes/palestrantes.component';

import { UserComponent } from './componets/user/user.component';
import { LoginComponent } from './componets/user/login/login.component';
import { RegistrationComponent } from './componets/user/registration/registration.component';
import { PerfilComponent } from './componets/user/perfil/perfil.component';

import { EventoDetalheComponent } from './componets/eventos/evento-detalhe/evento-detalhe.component';
import { EventoListarComponent } from './componets/eventos/evento-listar/evento-listar.component';
import { EventosComponent } from './componets/eventos/eventos.component';

import { ContatosComponent } from './componets/contatos/contatos.component';

const routes: Routes = [
  {
    path: 'user', component: UserComponent,
    children: [
      { path: 'login', component: LoginComponent },
      { path: 'registration', component: RegistrationComponent },
    ],
  },
  {
    path: 'eventos', redirectTo: 'eventos/listar'
  },
  {
    path: 'eventos', component: EventosComponent,
    children: [
      { path: "detalhe/:id", component: EventoDetalheComponent },
      { path: 'detalhe', component: EventoDetalheComponent},
      { path: 'listar', component: EventoListarComponent }
    ],
  },
  { path: 'palestrantes', component: PalestrantesComponent },
  { path: 'dashboard', component: DashboardComponent },
  { path: 'contatos', component: ContatosComponent },
  { path: 'user/perfil', component: PerfilComponent },
  { path: '', redirectTo: 'dashboard', pathMatch: 'full' },
  { path: '**', redirectTo: 'dashboard', pathMatch: 'full' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
