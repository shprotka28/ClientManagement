﻿CREATE TABLE customers (
customer_id int NOT NULL PRIMARY KEY IDENTITY,
ID VARCHAR (3) NOT NULL,
FirstName VARCHAR (15) NOT NULL,
LastName VARCHAR (15) NOT NULL,
EGN VARCHAR(10) NOT NULL UNIQUE,
DateOfBirth VARCHAR(8) NOT NULL);
CREATE TABLE Emails(
id int NOT NULL PRIMARY KEY IDENTITY,
Email VARCHAR(50) NOT NULL,
customer_id INT NOT NULL FOREIGN KEY REFERENCES customers(customer_id)
);
CREATE TABLE Phones(
id int NOT NULL PRIMARY KEY IDENTITY,
Phone VARCHAR(13) NOT NULL,
customer_id INT NOT NULL FOREIGN KEY REFERENCES customers(customer_id)
);
CREATE TABLE Addresses (
id int NOT NULL PRIMARY KEY IDENTITY,
CountryCode VARCHAR(3) NOT NULL,
City VARCHAR(176) NOT NULL,
Address VARCHAR (200) NOT NULL,
customer_id INT NOT NULL FOREIGN KEY REFERENCES customers(customer_id)
);
