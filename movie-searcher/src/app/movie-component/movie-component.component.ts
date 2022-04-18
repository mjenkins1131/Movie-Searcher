import { Component, OnInit, ViewChild, ElementRef, Renderer2, Input, Directive } from '@angular/core';
import { Movie } from '../Movie';

@Component({
  selector: 'app-movie-component',
  templateUrl: './movie-component.component.html',
  styleUrls: ['./movie-component.component.css']
})
export class MovieComponentComponent implements OnInit {

  @Input() title !: Movie;

  @ViewChild('truncator') truncator !: ElementRef<HTMLElement>;

  constructor(private renderer: Renderer2) { }
  ngOnInit(): void { }

}
