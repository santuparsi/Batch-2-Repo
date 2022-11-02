import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-demo1',
  templateUrl: './demo1.component.html',
  styleUrls: ['./demo1.component.css']
})
export class Demo1Component implements OnInit {
employeeName='Aman';
joinDate:Date=new Date(2022,6,12);
salary:number=12000;
projectName:'HMS';


  constructor() { }

  ngOnInit(): void {
  }

}
