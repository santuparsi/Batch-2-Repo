import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-demo2',
  templateUrl: './demo2.component.html',
  styleUrls: ['./demo2.component.css']
})
export class Demo2Component implements OnInit {
customers:any[]
  constructor() { 
    this.customers=[
{name:'Rakesh',gender:'Male'},
{name:'Aishwarya',gender:'Female'},
{name:'Vasanth',gender:'Male'},
{name:'Rani',gender:'Female'},
{name:'Dinesh',gender:'Male'},
{name:'Indu',gender:'Female'},
    ];
  }

  ngOnInit(): void {
  }

}
