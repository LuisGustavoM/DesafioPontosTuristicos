import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Cidade } from '../Models/cidade';
import { Estado } from '../Models/estado';

@Injectable({
  providedIn: 'root'
})
export class SharedService {

  baseUrlIbge = 'https://servicodados.ibge.gov.br/api/v1/localidades/estados/';
  baseUrlBrasilAPI = 'https://brasilapi.com.br/api/ibge/municipios/v1';
  providers = 'providers=dados-abertos-br,gov,wikipedia';
  constructor(private http: HttpClient) { }

  BuscarEstados(): Observable<Estado[]> {
    return this.http.get<Estado[]>(`${this.baseUrlIbge}`);
  }

  BuscarCidadePorEstado(sigla: string): Observable<Cidade[]> {
    return this.http.get<Cidade[]>(`${this.baseUrlBrasilAPI}/${sigla}?${this.providers}`);
  }
}
