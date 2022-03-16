import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListsCommandeComponent } from './lists-commande.component';

describe('ListsCommandeComponent', () => {
  let component: ListsCommandeComponent;
  let fixture: ComponentFixture<ListsCommandeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ListsCommandeComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ListsCommandeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
