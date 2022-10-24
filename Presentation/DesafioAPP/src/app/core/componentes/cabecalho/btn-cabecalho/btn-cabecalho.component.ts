import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-btn-cabecalho',
  templateUrl: './btn-cabecalho.component.html',
  styleUrls: ['./btn-cabecalho.component.scss']
})
export class BtnCabecalhoComponent implements OnInit {
  btn = document.getElementById("button");

  constructor() { }

  ngOnInit(): void {
    this.adicionarEventoBtn();
  }

  public adicionarEventoBtn(): void {
    this.btn!.addEventListener('click', function() {
        if (this.classList.contains("active")) {
            this.classList.remove("active")
            this.classList.add('not-active')
        } else {
            this.classList.add("active")
            this.classList.remove('not-active')
        }
    });
   }
}
