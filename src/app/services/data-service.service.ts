import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class DataService {
  url: string = "https://localhost:44380/api/Main/";
  body: string = "";
  constructor(private http: HttpClient) {
  }
  public setRequstData(rout: string, request: any) {
    return this.http
      .get(
        this.url + rout,
      );




  }
}
