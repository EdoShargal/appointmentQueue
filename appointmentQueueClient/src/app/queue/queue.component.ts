import { Component, OnInit } from '@angular/core';
import { Appointment } from '../shared/models/appointment.model';
import { QueueService } from '../shared/services/queue.service';

@Component({
  selector: 'app-queue',
  templateUrl: './queue.component.html',
  styleUrls: ['./queue.component.css']
})
export class QueueComponent implements OnInit {

  name: string = ""
  appointments: Appointment[]
  current: number = 0
  
  constructor(private queueService: QueueService) {
    this.appointments = []
  }

  ngOnInit() {
  }

  appointmentOrder(){
    //Checking if client enter a name
    if (!this.name) return console.log("No name entered")

    //getting last number appointment
    let lastNumber = this.appointments.reduce((max, curr) => curr.number > max ? curr.number: max, 0)

    // make an appointment object. 
    let appointment: Appointment = new Appointment(lastNumber + 1, this.name, new Date(), 0)

    // add it to the appointment array
    this.appointments.push(appointment)

    // add into db with stauts 0
      this.queueService.addAppointment(appointment)

    // reset name input
    this.name = ""
  }

  orderInvite(){
    // Checking if there is waiting number
    if (!(this.appointments.length > 0)) return console.log("No waiting number")

    // checking if there is finish appointment
    if (!(this.current == 0)) { 
      // changing in db status 2 // finish appointment
      this.queueService.changeStatus(this.current, 2)
    }

    // getting the next in line
    let nextAppointment: Appointment = this.appointments.shift()

    // change status to 1 in db where number is nextAppointment.number
      this.queueService.changeStatus(nextAppointment.number, 1)

    // change this.current to current nextAppointment.number
    this.current = nextAppointment.number
  }

}
