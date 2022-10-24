import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

// componentes
import { PontosTuristicosRoutingModule } from './pontos-turisticos-routing.module';
import { PontosTuristicosComponent } from './pontos-turisticos.component';
import { PontosTuristicosEditComponent } from './pontos-turisticos-edit/pontos-turisticos-edit.component';
import { CoreModule } from 'src/app/core/core.module';


@NgModule({
  declarations: [
    PontosTuristicosComponent,
    PontosTuristicosEditComponent
  ],
  imports: [
    CommonModule,
    CoreModule,
    PontosTuristicosRoutingModule
  ]
})
export class PontosTuristicosModule { }
