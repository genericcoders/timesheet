import { Directive, ElementRef, Input } from '@angular/core';

@Directive({ selector: '[navHighlight]' })
export class HighlightDirective {
    constructor(el: ElementRef) {
       el.nativeElement.style.backgroundColor = 'grey';
    }
}