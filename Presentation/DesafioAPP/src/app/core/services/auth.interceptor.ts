import { Injectable } from '@angular/core';
import {
  HttpInterceptor,
  HttpEvent,
  HttpRequest,
  HttpHandler,
  HttpHeaders,
} from '@angular/common/http';
import { Router } from '@angular/router';
import { Observable, throwError } from 'rxjs';
import { catchError, finalize, map } from 'rxjs/operators';
import { SpinnerService } from './spinner.service';

@Injectable({ providedIn: 'root' })
export class AuthInterceptor implements HttpInterceptor {
  constructor(private router: Router, private spinnerService: SpinnerService) {}

  intercept(
    req: HttpRequest<any>,
    next: HttpHandler
  ): Observable<HttpEvent<any>> {
    this.spinnerService.alterarSpinnerStatus(true);
    const cabecalho = new HttpHeaders();
    cabecalho.set('Content-Type', 'application/json; charset=utf-8')
    const cloneReq = req.clone({
      headers: cabecalho,
    });


    return next.handle(cloneReq).pipe(
      map((event) => {
        return event;
      }),
      catchError((error) => {
        if (error.status === 401) {
        }
        this.spinnerService.alterarSpinnerStatus(false);
        return throwError(error);
      }),
      finalize(() => {
        this.spinnerService.alterarSpinnerStatus(false);
      })
    );
  }
}
