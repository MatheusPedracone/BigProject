import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { TooltipModule } from 'ngx-bootstrap/tooltip';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { CollapseModule } from 'ngx-bootstrap/collapse';
import { ModalModule } from 'ngx-bootstrap/modal';

import { defineLocale } from 'ngx-bootstrap/chronos';
import { ptBrLocale } from 'ngx-bootstrap/locale';
import { BsDatepickerModule } from 'ngx-bootstrap/datepicker';

import { ToastrModule } from 'ngx-toastr';
import { NgxSpinnerModule } from 'ngx-spinner';

import { AppRoutingModule } from './app-routing.module';
import { ContatosComponent } from './componets/contatos/contatos.component';
import { PerfilComponent } from './componets/user/perfil/perfil.component';
import { TittleComponent } from './shared/tittle/tittle.component';
import { AppComponent } from './app.component';
import { EventosComponent } from './componets/eventos/eventos.component';
import { PalestrantesComponent } from './componets/palestrantes/palestrantes.component';
import { NavComponent } from './shared/nav/nav.component';
import { DashboardComponent } from './componets/dashboard/dashboard.component';

import { EventoService } from './services/Evento.service';
import { DateTimeFormatPipe } from './helpers/DateTimeFormat.pipe';
import { EventoDetalheComponent } from './componets/eventos/evento-detalhe/evento-detalhe.component';
import { EventoListarComponent } from './componets/eventos/evento-listar/evento-listar.component';
import { UserComponent } from './componets/user/user.component';
import { LoginComponent } from './componets/user/login/login.component';
import { RegistrationComponent } from './componets/user/registration/registration.component';

defineLocale('pt-br', ptBrLocale);

@NgModule({
  declarations: [
    AppComponent,
    EventosComponent,
    PalestrantesComponent,
    NavComponent,
    DateTimeFormatPipe,
    ContatosComponent,
    PerfilComponent,
    DashboardComponent,
    PalestrantesComponent,
    TittleComponent,
    EventoListarComponent,
    EventoDetalheComponent,
    UserComponent,
    LoginComponent,
    RegistrationComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule,
    CollapseModule.forRoot(),
    FormsModule,
    ReactiveFormsModule,
    TooltipModule.forRoot(),
    BsDropdownModule.forRoot(),
    ModalModule.forRoot(),
    BsDatepickerModule.forRoot(),
    ToastrModule.forRoot({
      timeOut: 4000,
      positionClass: 'toast-bottom-right',
      preventDuplicates: true,
      progressBar: true,
    }),
    NgxSpinnerModule,
  ],
  providers: [EventoService],
  bootstrap: [AppComponent],
  schemas: [CUSTOM_ELEMENTS_SCHEMA],
})
export class AppModule {}
