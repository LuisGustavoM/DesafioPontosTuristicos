import { Injectable, EventEmitter } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class SpinnerService {

  spinnerStatus = new EventEmitter<boolean>();
  constructor() { }

  alterarSpinnerStatus(valor: boolean) {
    if (valor === false) {
      this.spinnerStatus.emit(valor);
    } else {
      this.spinnerStatus.emit(valor);
    }
  }

}
