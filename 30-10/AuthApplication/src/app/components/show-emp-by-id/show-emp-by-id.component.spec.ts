import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ShowEmpByIdComponent } from './show-emp-by-id.component';

describe('ShowEmpByIdComponent', () => {
  let component: ShowEmpByIdComponent;
  let fixture: ComponentFixture<ShowEmpByIdComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ShowEmpByIdComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ShowEmpByIdComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
