import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-language',
  templateUrl: './language.component.html',
  styleUrls: ['./language.component.css']
})
export class LanguageComponent implements OnInit{
  'LanguageId': number;
  'LanguageName': string;
  ngOnInit(): void {
  }
}





// function ngOnInit() {
//   throw new Error('Function not implemented.');
// }

