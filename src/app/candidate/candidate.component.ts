import { identifierName } from '@angular/compiler';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-candidate',
  templateUrl: './candidate.component.html',
  styleUrls: ['./candidate.component.css'],
    template: `
    <h1>{{myObject.name}}</h1>
    <p>{{myObject.description}}</p>
    `
})
export class CandidateComponent implements OnInit {  
   "id": number;
   "name": string;
   'beginYear':Date;
  'lastUpdateDate':Date;

ngOnInit(): void {
}

}

// Languages:
  // ngOnInit() {
  // //  this.dataService.getData().subscribe(data => {
  //     this.id = CandidateComponent.id;
  //     this.description = data.description;
  //   });

