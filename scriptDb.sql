create database TiendaPalma;
use TiendaPalma
create table Product(
	Id varchar(100) primary key,
	Name varchar(75) not null,
	Price decimal(6,2) not null,
	DateCreated datetime2 not null,
	Quantity int not null
)