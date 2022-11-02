import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'title'
})
export class TitlePipe implements PipeTransform {

  transform(value: string,gender?:string): string {
    if(gender=='Male')
    return 'Mrs. '+value
    else if(gender=='Female')
    return 'Miss. '+value
    else
    return value;
  }

}
