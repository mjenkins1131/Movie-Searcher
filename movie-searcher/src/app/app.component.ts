import { Component } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Movie } from './Movie';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  readonly ROOT_URL = 'https://localhost:44321'
  title = 'movie-searcher';

  movies!: Observable<Movie[]>;

  constructor(private http: HttpClient) {}

  
  getMovies(name: string){
    this.movies = this.http.get<Movie[]>(this.ROOT_URL + '/api/SearchMovie/' + name)
  }
}
