/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { PontosTuristicosComponent } from './pontos-turisticos.component';

describe('PontosTuristicosComponent', () => {
  let component: PontosTuristicosComponent;
  let fixture: ComponentFixture<PontosTuristicosComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PontosTuristicosComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PontosTuristicosComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
