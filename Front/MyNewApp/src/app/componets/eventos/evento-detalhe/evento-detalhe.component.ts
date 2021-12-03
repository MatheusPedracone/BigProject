import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';

import { BsLocaleService } from 'ngx-bootstrap/datepicker';
import { NgxSpinnerService } from 'ngx-spinner';
import { ToastrService } from 'ngx-toastr';

import { Evento } from 'src/app/models/Evento';
import { EventoService } from 'src/app/services/Evento.service';

@Component({
  selector: 'new FormControl(),evento-detalhe',
  templateUrl: './evento-detalhe.component.html',
  styleUrls: ['./evento-detalhe.component.scss'],
})
export class EventoDetalheComponent implements OnInit {
  form!: FormGroup;

  evento = {} as Evento;

  locale = 'pt-br';

  get f(): any {
    return this.form.controls;
  }

  get bsConfig(): any {
    return {
      dateInputFormat: 'DD/MM/YYYY hh:mm A',
      containerClass: 'theme-default',
      showWeekNumbers: false,
      adaptivePosition: true,
    };
  }

  constructor(
    private fb: FormBuilder,
    private localeService: BsLocaleService,
    private router: ActivatedRoute,
    private eventoService: EventoService,
    private toastr: ToastrService,
  ) {
    this.localeService.use(this.locale);
  }

  public loadEvento(): void {
    const eventoIdParam = this.router.snapshot.paramMap.get('id');

    if (eventoIdParam !== null) {

      this.eventoService.getEventoById(+eventoIdParam).subscribe({
      next: (evento: Evento) => {
        this.evento = {...evento};
          this.form.patchValue(this.evento);
        },
        error: (error) => {
          this.toastr.error('Evento não encontrado.', 'Erro!');
          console.error(error);
        },
        complete: () => {}
      });
    }
  }

  ngOnInit(): void {
    this.validation();
    this.loadEvento();
  }

  public validation(): void {
    this.form = this.fb.group({
      tema: [
        '',
        [
          Validators.required,
          Validators.minLength(4),
          Validators.maxLength(50),
        ],
      ],
      local: ['', Validators.required],
      dataEvento: ['', Validators.required],
      qtdPessoas: ['', Validators.required],
      telefone: ['', Validators.required],
      email: ['', [Validators.required, Validators.email]],
      // imagemURL: ['', Validators.required],
    });
  }

  public resetForm(): void {
    this.form.reset();
  }
}
