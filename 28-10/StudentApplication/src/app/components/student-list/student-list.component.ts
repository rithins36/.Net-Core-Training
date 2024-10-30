import { Component, OnInit, inject } from '@angular/core';
import { StudentService } from '../../services/student.service';

@Component({
  selector: 'app-student-list',
  standalone: true,
  imports: [],
  templateUrl: './student-list.component.html',
  styleUrl: './student-list.component.css'
})

export class StudentListComponent implements OnInit 
{ 
  studentService = inject(StudentService) 
  studentList: any[] = []; 
  ngOnInit(): void 
  { 
    this.loadStudents(); 
  } 
  loadStudents() { 
    this.studentService.getStudents().subscribe((res: any) => { 
      this.studentList = res; 
    }) 
  } 
} 
 
