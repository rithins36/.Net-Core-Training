import { HttpClient } from '@angular/common/http';
import { Component, inject } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-add-student',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './add-student.component.html',
  styleUrl: './add-student.component.css'
})
export class AddStudentComponent {
    studentObj: any = { 
      "studentId": 0, 
      "studentName": "", 
      "studentGrade": "", 
      "studentRollNo": "", 
      "isActive": true, 
      "createdDate": "", 
      "modifiedDate": ""
    } 

    http = inject(HttpClient); 
    
    onSubmit() { 
      debugger; 
      this.http.post("https://localhost:7088/api/TblStudents",this.studentObj).subscribe((res: any) => { 
        debugger; 
        if (res.studentId >= 0) 
          alert("Student Record Created!"); 
        else { 
          alert("Some Problem in Student Creation") 
        } 
      }) 
    } 
   
}
