import { Routes } from '@angular/router';
import { StudentListComponent } from './components/student-list/student-list.component';
import { AddStudentComponent } from './components/add-student/add-student.component';
import { StudentDetailsComponent } from './components/student-details/student-details.component';
import { DeleteStudentComponent } from './components/delete-student/delete-student.component';
import { EditStudentComponent } from './components/edit-student/edit-student.component';

export const routes: Routes = [
    { 
        path: 'student-list', 
        component: StudentListComponent
    }, 
    { 
        path: 'add-student', 
        component: AddStudentComponent
    }, 
    { 
        path: 'student-details', 
        component: StudentDetailsComponent
    }, 
    { 
        path: 'delete-student', 
        component: DeleteStudentComponent
    }, 
    {
        path :'edit-student',
        component : EditStudentComponent    
    }
];
