# Appointment Queue System

angualr 8 application for ordering an appointment and display who is waiting and who getting service. The application uses an ASP.NEt Web api 2 for sending and changing the data on SQL Server DB.

the client application only wright to DB. You can use Postman for getting all current data by runing:
http://localhost:{port}/api/Queues

response example: //if there is data
```javascript
[
    {
        "Id": 1,
        "Number": 1,
        "Name": "Edo",
        "Status": 2,
        "Hour": "2020-06-24T15:03:01.197"
    },
    {
        "Id": 2,
        "Number": 2,
        "Name": "Alon",
        "Status": 1,
        "Hour": "2020-06-24T15:03:03.517"
    },
    {
        "Id": 3,
        "Number": 3,
        "Name": "Oz",
        "Status": 0,
        "Hour": "2020-06-24T15:03:06.42"
    }
]
```


### Installing

1) clone the solution. 

#### Instaling Api

2) Enter the folder called appointmentQueueApi and dubled click the .sln file and just run  Restore NuGet Packages.

#### Instaling DB

3) open sql server managment create db named QueueDB and run the SQL script for creating the tables.

#### Instaling client

inside the directory run npm install than ng serve --open 

### Application Usage

you enter your name in the form field. The application give you a number and show a list of appointment waiting. The application than save your details in DB with status 0, for waiting. 

when an appointment is getting called the application change the appointment status to 1 for getting treatment and also check if there was early appointment inside for changing is status to 2 in DB. 

