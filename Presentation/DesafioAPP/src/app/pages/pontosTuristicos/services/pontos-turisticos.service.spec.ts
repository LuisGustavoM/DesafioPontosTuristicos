/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { PontosTuristicosService } from './pontos-turisticos.service';

describe('Service: PontosTuristicos', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [PontosTuristicosService]
    });
  });

  it('should ...', inject([PontosTuristicosService], (service: PontosTuristicosService) => {
    expect(service).toBeTruthy();
  }));
});
