import { Component, OnInit } from '@angular/core';
import { PontosTuristicosModel } from './models/pontos-turisticos-model';
import { PontosTuristicosService } from './services/pontos-turisticos.service';
import { ToastrService } from 'ngx-toastr';
import { FiltroPontosTuristicos } from './models/filtro-pontos-turisticos';

@Component({
  selector: 'app-pontos-turisticos',
  templateUrl: './pontos-turisticos.component.html',
  styleUrls: ['./pontos-turisticos.component.scss']
})
export class PontosTuristicosComponent implements OnInit {

  filtroPontosTuristicos: FiltroPontosTuristicos = new FiltroPontosTuristicos();
  pontosTuristicos: PontosTuristicosModel[] = [];

  ordernagemColuna = 'descricao';
  ordenagemCrescente  = true;
  paginaAtual = 1;

  constructor(
    private pontosTuristicosService: PontosTuristicosService,
    private toastr: ToastrService,

  ) {
    this.pontosTuristicosService.recarregaPontosTuristicos.subscribe(() => {
      this.buscarServicosPorFiltro();
    });
  }

  ngOnInit() {
    this.buscarServicosPorFiltro();
  }

  ordenar(){
    this.filtroPontosTuristicos = Object.assign(this.filtroPontosTuristicos,
      {
        ordenarCrescente: this.ordenagemCrescente,
        ordenarPor: this.ordernagemColuna
      });
    this.buscarServicosPorFiltro();

  }

  buscarServicosPorFiltro() {
     var request = this.pontosTuristicosService.BuscarTodosPorFiltro(this.filtroPontosTuristicos);
    request.subscribe({
      next: (data) => {
        this.pontosTuristicos = data;
      },
      error: (error) => {
        this.toastr.error('Ocorreu um erro! Informe ao administrador do sistema');
        console.log(error);
      },
    });
  }

}
