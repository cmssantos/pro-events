import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-events',
  templateUrl: './events.component.html',
  styleUrls: ['./events.component.scss']
})
export class EventsComponent implements OnInit {
  public events: any

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.getEvents()
  }

  public getEvents(): void {
    this.http
      .get('https://localhost:7220/api/events')
      .subscribe(
        {
            next: (response) => {
              this.events = response
            },
            error: (error) => {
              alert(error)
              console.log(error)
            }
        }
    )
  }


}
