import { Component } from '@angular/core';
import { DatePipe } from '@angular/common';
import { Employee } from '../../models/employee.model';
import { CommonModule } from '@angular/common';


@Component({
  selector: 'app-list-employees',
  standalone: true,
  imports: [DatePipe, CommonModule],
  templateUrl: './list-employees.component.html',
  styleUrl: './list-employees.component.css'
})

export class ListEmployeesComponent {
    employees : Employee[]=[
      {
        id:1,
        name : "Rithin Samuel",
        gender: "Male",
        email: "rithin@gmail.com",
        phoneNumber: 8988379927,
        dateOfBirth: new Date('01-06-2002'),
        department: "Accounts",
        photoPath: "./2.jpg"
      },
      {
        id:1,
        name : "Vivek Krishna",
        gender: "Male",
        email: "vivek@gmail.com",
        phoneNumber: 9088377827,
        dateOfBirth: new Date('07-03-2002'),
        department: "Network",
        photoPath: "./3.jpg"
      },
      {
        id:1,
        name : "Nandana S Kumar",
        gender: "Female",
        email: "rithin@gmail.com",
        phoneNumber: 9488909675,
        dateOfBirth: new Date('01-06-2002'),
        department: "Cloud",
        photoPath: "./1.jpg"
      },
      {
        id:1,
        name : "Nandana S Kumar",
        gender: "Female",
        email: "rithin@gmail.com",
        phoneNumber: 9488909675,
        dateOfBirth: new Date('01-06-2002'),
        department: "Cloud",
        photoPath: "./1.jpg"
      },
      {
        id:1,
        name : "Nandana S Kumar",
        gender: "Female",
        email: "rithin@gmail.com",
        phoneNumber: 9488909675,
        dateOfBirth: new Date('01-06-2002'),
        department: "Cloud",
        photoPath: "./1.jpg"
      },
      
    ]

}
