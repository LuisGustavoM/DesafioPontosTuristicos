import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { NgxSpinnerModule } from 'ngx-spinner';
import { CabecalhoComponent } from './componentes/cabecalho/cabecalho.component';
import { SpinnerComponent } from './componentes/spinner/spinner.component';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule,
    NgxSpinnerModule,
  ],
  declarations: [
    CabecalhoComponent,
    SpinnerComponent,
  ],
  exports:[
    SpinnerComponent,
    CabecalhoComponent,
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    NgxSpinnerModule
  ]
})
export class CoreModule { }
