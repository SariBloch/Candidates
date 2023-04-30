import { Component } from '@angular/core';
import { DataService } from './services/data-service.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'task';
  result: any;
  constructor(private svc: DataService) {
    debugger
    this.svc.setRequstData("GetData", null).subscribe((x: any) => {
      debugger
      this.result = x;;
    });
  }
}
