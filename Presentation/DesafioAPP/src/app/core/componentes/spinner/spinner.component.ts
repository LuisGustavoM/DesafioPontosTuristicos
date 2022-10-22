import { ChangeDetectionStrategy, ChangeDetectorRef, Component, OnInit } from '@angular/core';
import { NgxSpinnerService } from 'ngx-spinner';
import { trigger, state, style, transition, animate } from '@angular/animations';
import { SpinnerService } from '../../services/spinner.service';

@Component({
  selector: 'app-spinner',
  templateUrl: './spinner.component.html',
  styleUrls: ['./spinner.component.css'],
  changeDetection: ChangeDetectionStrategy.OnPush,
  animations: [
    trigger('fadeIn', [
      state('in', style({ opacity: 1 })),
      transition(':enter', [
        style({ opacity: 0 }),
        animate(300)
      ]),
      transition(':leave',
        animate(200, style({ opacity: 0 })))
    ])
  ]
})

export class SpinnerComponent implements OnInit {

  constructor(
    private spinnerService: SpinnerService,
    private changeDetector: ChangeDetectorRef,
    private spinner: NgxSpinnerService) { }

    ngOnInit() {
      this.spinnerService.spinnerStatus.subscribe((status: boolean) => {
        if (status === true) {
          this.spinner.show(undefined,
            {
              type: 'ball-scale-pulse',
              size: 'medium',
              bdColor: 'rgba(97,96,96,0.76)',
              color: 'white',
              fullScreen: true
            }
          );
          } else {
          this.spinner.hide();
        }
        this.changeDetector.detectChanges();
      });
    }

    ngOnDestroy(): void {
      this.spinner;
    }
}
