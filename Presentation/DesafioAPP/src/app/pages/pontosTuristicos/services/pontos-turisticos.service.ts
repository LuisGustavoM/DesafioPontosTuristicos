import { EventEmitter, Injectable } from '@angular/core';
import { PontosTuristicosModel } from '../models/pontos-turisticos-model';
import { HttpClient } from '@angular/common/http';
import { FiltroPontosTuristicos } from '../models/filtro-pontos-turisticos';
import { Observable } from 'rxjs';
import { BASEURL } from 'src/app/core/constantes/conexao';

@Injectable({
  providedIn: 'root'
})
export class PontosTuristicosService {

  url = BASEURL + 'PontosTuristicos';
  recarregaPontosTuristicos = new EventEmitter<PontosTuristicosModel>();

  constructor(private http: HttpClient) { }

  RecarregarPontosTuristicos(){
    this.recarregaPontosTuristicos.emit();
  }

  BuscarTodosPorFiltro(filtro: FiltroPontosTuristicos): Observable<PontosTuristicosModel[]> {
    return this.http.post<PontosTuristicosModel[]>(`${this.url}/BuscarTodosPorFiltro`, filtro);
  }

  BuscarTodos(): Observable<PontosTuristicosModel[]> {
    return this.http.get<PontosTuristicosModel[]>(`${this.url}`);
  }

  BuscarPorId(id: any): Observable<PontosTuristicosModel> {
    return this.http.get<PontosTuristicosModel>(`${this.url}/${id}`);
  }

  Cadastrar(pontoTuristico: PontosTuristicosModel) {
    return this.http.post(`${this.url}`, pontoTuristico);
  }

  Editar(pontoTuristico: PontosTuristicosModel) {
    console.log(pontoTuristico);
    console.log( this.http.put(`${this.url}/${pontoTuristico.id}`, pontoTuristico))
    return this.http.put(`${this.url}/${pontoTuristico.id}`, pontoTuristico);
  }

  Excluir(id: string) {
    return this.http.delete(`${this.url}/${id}`);
  }

}
