import { HttpClient } from '@angular/common/http';
import { Component, inject } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent {
  userObj : any ={
    EmailId:'',
    Password:''
  };

  constructor(private http : HttpClient){}
  router = inject(Router);


  onLogin(){
    if(this.userObj.EmailId == 'admin' && this.userObj.Password == "1234"){
      localStorage.setItem('loginUser', this.userObj.EmailId)
      this.router.navigateByUrl('layout')
      alert("Login successfull");
    }
    else{
      alert('Wrong Credentials')
    }
  }
}
