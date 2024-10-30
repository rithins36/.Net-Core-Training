import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class StudentService {

  constructor(private http: HttpClient) { } 
  getStudents() { 
  return this.http.get("https://localhost:7088/api/TblStudents"); 
  } 
}
