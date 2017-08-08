import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrls: ['./user.component.css']
})
export class UserComponent implements OnInit {
  name:string;
  swap:boolean;
  age:number;
  email:string;
  address:Address;
  hobbies:string[];

  constructor() { 
    console.log("user constructor ran..");
  }

  ngOnInit() {
    this.name  = "Name Last";
    this.age = 26;
    this.swap = false;
    this.address = {
      street:"100 Main Street",
      city:"Orlando",
      state:"FL",
      zip: 32826
    }
    this.hobbies = ['Programming','Movies','Muay Thai'];
    this.email = "emailer@gmail.com";
    console.log("user ngOnInit ran..");
  }

  onClick() {
    console.log('User clicked');
    if(this.swap) {
      this.name ="Swap Name";
    }
    else {
      this.name = "Name Last";
    }
    this.swap = !this.swap;
  }
}

interface Address {
  street:string,
  city:string,
  state:string,
  zip:number
}