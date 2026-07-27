# CinemaManagementSystem

A simple object-oriented cinema management project built with C# and Windows Forms. The solution is composed of a library for the core concepts and a demo application for the user interface.

## 1. Introduction
This project was created for OOP class as an exercise to create a library for a cinema system. A demo showcasing the use of this library was also implemented. It demonstrates how classes, inheritance, composition, and collections can be used to represent real-world entities such as movies, customers, tickets, snacks, and bookings.

## 2. System Overview
The system allows users to browse movies, view now-showing and coming-soon films, and manage a simple booking flow. The library handles the core domain objects, while the demo application provides a graphical interface for interacting with them.

## 3. Project Structure
```
project/  
├── CinemaManagementLibrary/: contains the core business logic and domain classes.  
│   ├── Booking.cs  
│   ├── ComingSoonMovie.cs  
│   ├── Customer.cs  
│   ├── Enums.cs  
│   ├── Hall.cs  
│   ├── Item.cs  
│   ├── Movie.cs  
│   ├── MovieRepository.cs  
│   ├── Seat.cs  
│   ├── ShowTime.cs  
│   ├── Snack.cs  
│   └──  Ticket.cs  
├── CinemaManagementDemo/: contains the Windows Forms user interface and the program entry point.  
│   ├── Program.cs  
│   ├── MovieDetailsForm.cs  
│   ├── Movies.cs  
│   ├── SnackSelectionForm.cs  
│   └──  TicketReceiptForm.cs
├── CinemaManagementSystem.slnx: solution file for opening the project in Visual Studio.  
└── README.md: project documentation.
```

## 4. OOP Concepts Used
- Encapsulation: class properties and methods keep data organized and controlled.
- Inheritance: ComingSoonMovie extends the Movie class.
- Abstraction: each class represents a real-world concept in a simple and clear way.
- Polymorphism: methods such as getMovieInfo() can be reused or overridden in derived classes.
- Composition: Booking contains objects such as Customer, ShowTime, Ticket, and Snack.

## 5. UML Class Diagram
<figure>
    <img src=""
         alt="UML">
    <figcaption>UML diagram showcasing the relations between classes of the library.</figcaption>
</figure>

## 6. Demo Application
The demo application provides a Windows Forms interface with the following features:

- 1st page : movie dashboard displaying now-showing and coming soon movies.
- 2nd page : view details of the selected film, choose showtime, seats and price category per seat (adult, child or student)
- 3rd page : choose snacks, enter the customer name and email, show the order summary
- 4th page : view a summary of the order and print the receipt

## 7. Installation & Setup
1. Open CinemaManagementSystem.slnx in Visual Studio.
2. Make sure CinemaManagementDemo is set as the startup project.
3. Build and run the application.

> This project targets .NET 10, so the appropriate SDK should be installed on the machine.

## 8. How to Use the Library
The CinemaManagementLibrary project can be reused in other applications by referencing it as a class library with the code :
```
using CinemaManagementLibrary;
```

 It contains classes for:
- Movie and ComingSoonMovie
- Customer and Booking
- ShowTime, Hall, Seat, and Ticket
- Snack and Item
- MovieRepository for loading and saving data

These classes can be instantiated and used to build custom cinema-related applications or extend the current demo system.

## 9. GitHub Repository
The GitHub repository is available via the link https://github.com/erinazanie/CinemaManagementSystem.git .

## 10. Future Improvements
- create an interface for the cinema staff to update the film list and manage halls and showtimes.
- Add database persistence instead of JSON files.
- Implement user authentication and admin management.
- Improve payment integration.
- Add more validation and error handling.
- Create unit tests for the library classes.
