import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class CalculateService {

  constructor() { }
  Add(a:number,b:number):number
  {
    let result=a+b;
    return result;
  }
  IsEven(n:number):boolean
  {
    if(n%2==0)
    return true;
    else
    return false;
  }
  GetNos():number[]
  {
    return [12,34,45,56,67,78];
  }
}
