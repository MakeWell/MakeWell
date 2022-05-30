import { Component, Input, OnInit } from '@angular/core';
import { NavigationViews } from './navigation-views.enum';

@Component({
  selector: 'application-navigation',
  templateUrl: './application-navigation.component.html',
  styleUrls: ['./application-navigation.component.css']
})
export class ApplicationNavigationComponent implements OnInit {

  @Input()
  public NavViewName: string = NavigationViews.list.toString();

  isRendered(name: string = "list") : boolean {
    if (this.NavViewName == name) {
      return true;
    } else {
        return false;
    }
  }
  constructor() { }

  ngOnInit() {}


}
