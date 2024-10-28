import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { CommonModule } from '@angular/common';
import { ListEmployeesComponent } from './employees/list-employees/list-employees.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet,ListEmployeesComponent,CommonModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'CardApplication';
}
