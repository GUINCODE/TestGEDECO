import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
export class HeaderComponent implements OnInit {
cheminImage:any ="assets/logos/logoPrincipale.png"
userLoginIcon:any ="assets/icons/userLogin.png"
userBell:any ="assets/icons/bellAucun.png"
settingsIcon:any ="assets/icons/settingsIcon.png"
helpIcon:any ="assets/icons/helpIcon.png"
  constructor() { }

  ngOnInit(): void {
  }

}
