CREATE DATABASE dblibrary;

CREATE TABLE dblibrary.tblBooks(
`ISBN` varchar(10) NOT NULL,
`Title` varchar(125) DEFAULT NULL,
`Author` varchar(125) DEFAULT NULL,
`Abstract` varchar(5000) DEFAULT NULL,
`Category` varchar(125) DEFAULT NULL,
`Quantity` INT(3) NOT NULL,
PRIMARY KEY(`ISBN`)
);

CREATE TABLE dblibrary.tblBookTrans(
`id` int(5) NOT NULL AUTO_INCREMENT,
`UserID` varchar(12) DEFAULT NULL,
`ISBN` varchar(10) DEFAULT NULL,
`Title` varchar(125) DEFAULT NULL,
`DateBorrowed` date,
`DateDue` date,
`DateReturned` date,
PRIMARY KEY(`id`)
);

CREATE TABLE dblibrary.tblMembership(
`UserID` varchar(12) NOT NULL,
`DateJoined` date,
`Validity` date,
PRIMARY KEY (`UserID`)
);

CREATE TABLE dblibrary.tblReserveTrans(
`id` int(5) NOT NULL AUTO_INCREMENT,
`UserID` varchar(12) DEFAULT NULL,
`ISBN` varchar(10) DEFAULT NULL,
`Title` varchar(125) DEFAULT NULL,
`DateReserve` date,
PRIMARY KEY(`id`)
);

CREATE TABLE dblibrary.tblUsers(
`UserID` varchar(12) NOT NULL,
`FirstName` varchar(45) DEFAULT NULL,
`LastName` varchar(45) DEFAULT NULL,
`MiddleName` varchar(45) DEFAULT NULL,
`Address` varchar(255) DEFAULT NULL,
`ContactNo` varchar(18) DEFAULT NULL,
`EmailAdd` varchar(45) DEFAULT NULL,
`username` varchar(45) DEFAULT NULL,
`password` varchar(45) DEFAULT NULL,
`role` varchar(45) DEFAULT NULL,
PRIMARY KEY(`UserID`)
);
