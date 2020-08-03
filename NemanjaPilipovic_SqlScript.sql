IF DB_ID('PizzaRestourant') IS NULL
CREATE DATABASE PizzaRestourant
GO

USE PizzaRestourant
IF EXISTS (SELECT NAME FROM sys.sysobjects WHERE NAME = 'tblOrders')
DROP TABLE tblOrders
IF EXISTS (SELECT NAME FROM sys.sysobjects WHERE NAME = 'tblUsers')
DROP TABLE tblUsers

CREATE TABLE tblUsers(
Id int PRIMARY KEY IDENTITY(1,1),
Username nvarchar(30),
Password nvarchar(30)
);

CREATE TABLE tblOrders(
Id int PRIMARY KEY IDENTITY(1,1),
Price int,
State nvarchar(20),
CreatedDate Date,
CreatedTime Time,
FKUser int
);

ALTER TABLE tblOrders ADD FOREIGN KEY(FkUser) REFERENCES tblUsers(Id);

