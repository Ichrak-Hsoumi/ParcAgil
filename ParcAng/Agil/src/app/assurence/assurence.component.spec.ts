import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AssurenceComponent } from './assurence.component';

describe('AssurenceComponent', () => {
  let component: AssurenceComponent;
  let fixture: ComponentFixture<AssurenceComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AssurenceComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AssurenceComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
