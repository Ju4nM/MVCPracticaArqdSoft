# Practica del patrón MVC - Arquitectura de Software
El presente proyecto es una práctica del patrón MVC llevada a cabo para la materia de Arquitectura de Software impartida por el docente: [Eric Armando Herrera Alfonso](https://github.com/ehalfonso).

## Script de la base de datos
```sql
create database MVCPracticaArqdSoft;

use MVCPracticaArqdSoft;

create table Contact (
	ContactId int primary key identity,
	ContactName varchar(50) not null,
	PhoneNumber varchar(10) not null,
	ContactEmail varchar(50) not null,
	ContactPassword varchar(50) not null
);

create procedure spContact_findAll as
begin
	select * from Contact;
end;

create procedure spContact_findOne (@contactId int) as
begin
	select * from Contact where ContactId = @contactId;
end;

create procedure spContact_saveOne (
	@contactName varchar(50),
	@phoneNumber varchar(10),
	@contactEmail varchar(50),
	@contactPassword varchar(50)
) as
begin
	insert into Contact values (@contactName, @phoneNumber, @contactEmail, @contactPassword);
end;

create procedure spContact_updateOne (
	@contactId int,
	@contactName varchar(50),
	@phoneNumber varchar(10),
	@contactEmail varchar(50),
	@contactPassword varchar(50)
) as
begin
	update Contact set ContactName = @contactName, PhoneNumber = @phoneNumber, ContactEmail = @contactEmail, ContactPassword = @contactPassword where ContactId = @contactId;
end;

create procedure spContact_deleteOne (@contactId int) as
begin
	delete from Contact where ContactId = @contactId;
end;
```
