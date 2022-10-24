import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PontosTuristicosEditComponent } from './pontos-turisticos-edit/pontos-turisticos-edit.component';
import { PontosTuristicosComponent } from './pontos-turisticos.component';

const routes: Routes = [
  { path: '', component: PontosTuristicosComponent},
  { path: 'detalhes', component: PontosTuristicosEditComponent},
  { path: 'detalhes/:id', component: PontosTuristicosEditComponent}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class PontosTuristicosRoutingModule { }
