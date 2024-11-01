import { Component, inject } from '@angular/core';
import { StudentService } from '../../services/student.service';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-edit-student',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './edit-student.component.html',
  styleUrl: './edit-student.component.css'
})
export class EditStudentComponent {
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
  
  studentObj: any = { 
    "studentId": 0, 
    "studentName": "", 
    "studentGrade": "", 
    "studentRollNo": "", 
    "isActive": true, 
    "createdDate": "", 
    "modifiedDate": ""
  } 

  handleEdit(){
    
  }
}
