import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { NgxSpinnerModule } from 'ngx-spinner';
import { CabecalhoComponent } from './componentes/cabecalho/cabecalho.component';
import { SpinnerComponent } from './componentes/spinner/spinner.component';
import { BtnCabecalhoComponent } from './componentes/cabecalho/btn-cabecalho/btn-cabecalho.component';
import { HttpClientModule} from '@angular/common/http';
import { ToastrModule } from 'ngx-toastr';
import { PopoverModule } from 'ngx-bootstrap/popover';
import { NgxPaginationModule } from 'ngx-pagination';

@NgModule({
  imports: [
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule,
    NgxSpinnerModule.forRoot({ type: 'ball-scale-multiple' }),
    HttpClientModule,
    ToastrModule.forRoot(),
    PopoverModule.forRoot(),
    NgxPaginationModule
  ],
  declarations: [
    CabecalhoComponent,
    SpinnerComponent,
    BtnCabecalhoComponent
  ],
  exports:[
    SpinnerComponent,
    CabecalhoComponent,
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    NgxSpinnerModule,
    NgxPaginationModule,
    BtnCabecalhoComponent
  ]
})
export class CoreModule { }
