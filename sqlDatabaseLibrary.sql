CREATE DATABASE dblibrary;

CREATE TABLE dblibrary.tblBooks(
ISBN varchar(10) NOT NULL,
Title varchar(45) DEFAULT NULL,
Author varchar(45) DEFAULT NULL,
Abstract varchar(255) DEFAULT NULL,
Category varchar(45) DEFAULT NULL,
Quantity int(3) DEFAULT NULL,
PRIMARY KEY (ISBN)
);

CREATE TABLE dblibrary.tblBookTrans(
id int(5) NOT NULL AUTO_INCREMENT,
UserID varchar(45) DEFAULT NULL,
ISBN varchar(10) DEFAULT NULL,
Title varchar(45) DEFAULT NULL,
DateBorrowed date,
DateDue date,
DateReturned date,
PRIMARY KEY (id)
);
