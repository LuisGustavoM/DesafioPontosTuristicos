import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  { path: 'pontos-turisticos', loadChildren: () => import('./pages/pontosTuristicos/pontos-turisticos.module').then(m => m.PontosTuristicosModule)},
  { path: 'sobre', loadChildren: () => import('./pages/sobre/sobre.module').then(m => m.SobreModule)},

  { path: '', redirectTo: 'inicio', pathMatch: 'full'},
  { path: '**', redirectTo: 'inicio', pathMatch: 'full'},

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
