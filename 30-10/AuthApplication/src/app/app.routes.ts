import { Routes } from '@angular/router';
import { LoginComponent } from './components/login/login.component';
import { LayoutComponent } from './components/layout/layout.component';
import { AddEmpComponent } from './components/add-emp/add-emp.component';
import { EditEmpComponent } from './components/edit-emp/edit-emp.component';
import { DeleteEmpComponent } from './components/delete-emp/delete-emp.component';
import { ListEmpComponent } from './components/list-emp/list-emp.component';
import { ShowEmpByIdComponent } from './components/show-emp-by-id/show-emp-by-id.component';

export const routes: Routes = [
    {
        path: '',
        redirectTo:'login',
        pathMatch:'full'
    },
    {
        path:'login',
        component: LoginComponent
    },
    {
        path:'layout',
        component: LayoutComponent,
        children:[
            {
                path:'add-emp',
                component: AddEmpComponent
            },
            {
                path:'edit-emp',
                component: EditEmpComponent
            },
            {
                path:'delete-emp',
                component: DeleteEmpComponent
            },
            {
                path:'list-emp',
                component: ListEmpComponent
            },
            {
                path:'show-emp-by-id',
                component: ShowEmpByIdComponent
            },
        ]
    }
];
