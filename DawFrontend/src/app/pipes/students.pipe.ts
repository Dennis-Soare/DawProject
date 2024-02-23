import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'students'
})
export class StudentsPipe implements PipeTransform {

  transform(value: unknown, ...args: unknown[]): unknown {
    return null;
  }

}
