import { Component, OnInit } from '@angular/core';
import { ETheme } from 'src/app/shared/enums/ETheme.enum';

@Component({
  selector: 'app-cabecalho',
  templateUrl: './cabecalho.component.html',
  styleUrls: ['./cabecalho.component.scss']
})
export class CabecalhoComponent implements OnInit {
  btn = document.getElementById("button");
  public icone: string = '';
  public textoTema: string = '';

  constructor() { }

  ngOnInit() {
    this.icone = ETheme.ICONE_ESCURO;
    this.textoTema = ETheme.ICONE_ESCURO;
  }

  public alterarTema(){
    var theme = document.body.classList.toggle('dark-theme');
    let meuElemento = document.querySelector("#tabela");
    console.log(meuElemento?.className);
    meuElemento!.className = '';
    console.log(theme);
    if(theme) {
      meuElemento!.className = "table table-striped table-dark";
      this.icone = ETheme.ICONE_CLARO;
      this.textoTema = ETheme.TEXTO_CLARO;
      return this.icone;
    }
    meuElemento!.className = "table table-striped table-light";
    this.icone = ETheme.ICONE_ESCURO;
    this.textoTema = ETheme.TEXTO_ESCURO;
    console.log(meuElemento?.className);

    return this.icone;
  }

}
