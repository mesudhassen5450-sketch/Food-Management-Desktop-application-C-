# Restaurant Management System (CafeSystem Group7)

## Overview
Windows Desktop Application built using VB.NET Windows Forms.  
It simulates a restaurant workflow including ordering, kitchen processing, payment, and feedback.

## Features

### Customer Module
- Select food items
- Create orders automatically
- Payment simulation
- Balance validation

### Kitchen System
- Cook → Ready → Deliver → Finish workflow
- Live status updates
- Event logging

### Kitchen Dashboard
- Displays all orders with:
  - Order ID
  - Food Name
  - Price
  - Status
  - Rating
  - Feedback

### Feedback System
- Rating (1–5)
- Text comments
- Stored per order

### Revenue System
- Calculates total revenue
- Only includes DELIVERED orders

## Technologies Used
- VB.NET Windows Forms
- OOP (Object-Oriented Programming)
- Event-Driven Programming
- List(Of Order) in-memory storage

## How to Run

### Visual Studio
- Open project
- Press F5

### Executable
- Go to:
  bin/Debug/net8.0-windows/
- Run:
  CafeSystem Group7.exe

## Workflow
1. Customer selects food
2. Order created
3. Payment processed
4. Kitchen processes order:
   Cook → Ready → Deliver → Finish
5. Customer gives feedback after delivery
6. Revenue calculated from delivered orders

## Author
Group 7 – IT Department Project

## Future Improvements
- SQL Server integration
- Multi-user system
- Online ordering system
