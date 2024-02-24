import { Directive, ElementRef, HostListener } from '@angular/core';

@Directive({
  selector: '[appMouseenter]'
})
export class MouseenterDirective {

  constructor(private htmlElement: ElementRef) { }

  @HostListener('mouseleave') OnMouseLeave(): void {
    this.htmlElement.nativeElement.style.background = 'blue';
  }

  @HostListener('mouseenter') OnMouseEnter(): void {
    this.htmlElement.nativeElement.style.background = 'red';
  }

}
