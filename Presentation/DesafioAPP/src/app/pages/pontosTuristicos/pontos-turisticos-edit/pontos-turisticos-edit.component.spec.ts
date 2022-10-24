/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { PontosTuristicosEditComponent } from './pontos-turisticos-edit.component';

describe('PontosTuristicosEditComponent', () => {
  let component: PontosTuristicosEditComponent;
  let fixture: ComponentFixture<PontosTuristicosEditComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PontosTuristicosEditComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PontosTuristicosEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
