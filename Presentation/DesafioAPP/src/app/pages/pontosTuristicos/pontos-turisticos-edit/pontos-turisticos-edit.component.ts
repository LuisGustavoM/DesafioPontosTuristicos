import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, MaxLengthValidator, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { Cidade } from 'src/app/shared/Models/cidade';
import { Estado } from 'src/app/shared/Models/estado';
import { SharedService } from 'src/app/shared/services/shared.service';
import { PontosTuristicosModel } from '../models/pontos-turisticos-model';
import { PontosTuristicosService } from '../services/pontos-turisticos.service';

@Component({
  selector: 'app-pontos-turisticos-edit',
  templateUrl: './pontos-turisticos-edit.component.html',
  styleUrls: ['./pontos-turisticos-edit.component.scss']
})
export class PontosTuristicosEditComponent implements OnInit {

  componentPai = '';
  id: string = '';
  textoBotao: string = 'Cadastrar';
  estados: Estado[];
  cidades: Cidade[];
  estadoSelecionado: Estado;
  cidadeSelecionada: Cidade;
  formGroup: FormGroup;
  pontoTuristico: PontosTuristicosModel;

  constructor(private route: ActivatedRoute,
              private fb: FormBuilder,
              private sharedService: SharedService,
              private toastr: ToastrService,
              private router: Router,
              private pontosTuristicosService: PontosTuristicosService,
    ) {
      this.validarForm()
     }

  ngOnInit() {
    this.id = this.route.snapshot.params["id"];
    this.buscarEstados();
    if(this.id != null && this.id !== undefined){
      this.carregar();
    }
  }

  validarForm() {
    this.formGroup = this.fb.group({
      nome: ['', Validators.required],
      descricao: ['', Validators.required,],
      referencia: ['', Validators.required],
      estado: ['', Validators.required],
      cidade: ['', Validators.required],
      dataHoraCadastro: [''],
    });
    if(this.id === undefined && this.formGroup.controls['estado'].value){
      this.formGroup.controls['cidade'].disable();
    }
  }

  carregar() {
    var request = this.pontosTuristicosService.BuscarPorId(this.id);
    request.subscribe({
      next: (data) => {
        this.pontoTuristico = Object.assign(data);
        this.textoBotao = 'Editar';
      },
      error: (error) => {
        this.toastr.error('Ocorreu um erro! Informe ao administrador do sistema');
        console.log(error);
      },
      complete: () => {
        let estadoConsulta = Object.assign({
          value: this.pontoTuristico.estado
        });
        this.buscarCidades(estadoConsulta);
        this.formGroup.patchValue(this.pontoTuristico);
      }
    });
  }

  buscarEstados(): void{
    var request = this.sharedService.BuscarEstados();
    request.subscribe({
      next: (data) => {
        this.estados = data;
      },
      error: (error) => {
        this.toastr.error('Ocorreu um erro! Informe ao administrador do sistema');
        console.log(error);
      }
    });
  }

  buscarCidades(event: any): void{
   if(event !== null){
      if(event.value == "0"|| event.value == 0){
        this.toastr.warning('Selecione o estado');
      } else {
        var request = this.sharedService.BuscarCidadePorEstado(event.value);
        request.subscribe({
          next: (data) => {
            this.cidades = data
          },
          error: (error) => {
            this.toastr.error('Ocorreu um erro! Informe ao administrador do sistema');
            console.log(error);
          }
        });
      }
    }
  }

  salvar() {
    let mensagemRetorno = '';
    this.pontoTuristico = Object.assign(this.formGroup.value);
    let request;
    if (this.formGroup.valid) {
      if(this.id !== undefined){
        this.pontoTuristico = Object.assign(this.pontoTuristico, {
          id: this.id
        });
        request = this.pontosTuristicosService.Editar(this.pontoTuristico);
      } else {
        this.pontoTuristico.dataHoraCadastro = new Date();
        request = this.pontosTuristicosService.Cadastrar(this.pontoTuristico);
      }
      request.subscribe({
        next: () => {
          mensagemRetorno = 'Item salvo';
          this.pontosTuristicosService.RecarregarPontosTuristicos();
          this.toastr.success(mensagemRetorno);
          this.router.navigate(['/pontos-turisticos']);
        },
        error: (error) => {
          this.toastr.error('Ocorreu um erro! Informe ao administrador do sistema');
          console.log(error);
        }
    })
  } else {
      this.toastr.error('Valide os campos do formulário!')
    }
  }


  excluir() {
    var request = this.pontosTuristicosService.Excluir(this.id);;
    request.subscribe({
      next: () => {
        this.pontosTuristicosService.RecarregarPontosTuristicos();
        this.toastr.success('Item excluido!');
        this.router.navigate(['/pontos-turisticos']);
      },
      error: (error) => {
        this.toastr.error('Ocorreu um erro! Informe ao administrador do sistema');
        console.log(error);
      }
    })
  }

}
