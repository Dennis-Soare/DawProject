import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'students'
})
export class StudentsPipe implements PipeTransform {

  transform(value: string, ...args: unknown[]): unknown {
    switch (value.length) {
      case 0:
        return '0';
      case 1:
        return '1';
      case 2:
        return '2';
      default:
        return '3';
    }
  }

}
