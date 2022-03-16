import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListsEntrepriseComponent } from './lists-entreprise.component';

describe('ListsEntrepriseComponent', () => {
  let component: ListsEntrepriseComponent;
  let fixture: ComponentFixture<ListsEntrepriseComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ListsEntrepriseComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ListsEntrepriseComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
