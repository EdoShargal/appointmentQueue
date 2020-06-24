import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Appointment } from '../models/appointment.model';

@Injectable({
    providedIn: 'root',
  })
export class QueueService {

    URL = "http://localhost:65157/api/queues/"

    constructor(private http:  HttpClient){}

    addAppointment(appointment: Appointment){
        this.http.post(this.URL, appointment)
        .subscribe(
            (appointment: Appointment) => console.log(appointment),
            (err) => console.log(err)
        )
    }

    changeStatus(appointmentNumber: number, status: number){
        this.http.put(this.URL + appointmentNumber, status)
        .subscribe(
            (appointment: Appointment) => console.log(appointment),
            (err) => console.log(err)
        )
    }
}