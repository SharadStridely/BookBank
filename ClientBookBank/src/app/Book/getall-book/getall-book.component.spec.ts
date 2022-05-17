import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GetallBookComponent } from './getall-book.component';

describe('GetallBookComponent', () => {
  let component: GetallBookComponent;
  let fixture: ComponentFixture<GetallBookComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ GetallBookComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(GetallBookComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
