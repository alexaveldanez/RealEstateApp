import { Component } from '@angular/core';

@Component({
  selector: 'app-property-card',
  // template: ``
  templateUrl: 'property-card.component.html',
  // styles: ['']
  styleUrls: ['property-card.component.css']
})
export class PropertyCardComponent {
  Property: any = {
    "Id": 1,
    "Name": "Aveldanez House",
    "Type": "House",
    "Price": 12000
  }
}
