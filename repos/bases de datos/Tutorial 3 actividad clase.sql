create database  BDCRUDCORE2;

use BDCRUDCORE2;

create table Cliente(
IdCliente int primary key,
Nombre varchar(25),
Apellido varchar(25),
Correo varchar (50),
Empresa varchar (30),
NumTel varchar(25),
Direccion varchar (40),
CodPostal varchar(25),
Poblacion varchar (25)

);

go 

create procedure sp_listar 
as
begin
select IdCliente, Nombre, Apellido, Correo,Empresa, NumTel as 'Número de teléfono', Direccion as Dirección,  CodPostal as 'Código postal', 
Poblacion as Población from Cliente
end;

go 
create procedure sp_obtener(
@IdCliente int
)
as
begin
select * from Cliente where IdCliente  = @IdCliente 
end;

go 

create procedure sp_Guardar(
@IdCliente int,
@Nombre varchar(25),
@Apellido varchar(25),
@Correo varchar (50),
@Empresa varchar (30),
@NumTel varchar(25),
@Direccion varchar (40),
@CodPostal varchar(25),
@Poblacion varchar (25)
)
as
begin
insert into Cliente(IdCliente,Nombre,Apellido,Correo,Empresa,NumTel,Direccion,CodPostal,Poblacion) values 
(@IdCliente,@Nombre,@Apellido,@Correo,@Empresa,@NumTel,@Direccion,@CodPostal,@Poblacion)
end;

go 

create procedure sp_Editar(
@IdCliente int,
@Nombre varchar(25),
@Apellido varchar(25),
@Correo varchar (50),
@Empresa varchar (30),
@NumTel varchar(25),
@Direccion varchar (40),
@CodPostal varchar(25),
@Poblacion varchar (25)
)
as
begin
update Cliente set Nombre = @Nombre,Apellido = @Apellido, Correo = @Correo, Empresa = @Empresa, NumTel = @NumTel,
Direccion = @Direccion,CodPostal = @CodPostal,Poblacion = @Poblacion 
where IdCliente = @IdCliente
End;

go 

create procedure sp_Eliminar(
@IdCliente int
)
as
begin
delete from Cliente where IdCliente = @IdCliente
end;
 
 go


insert into Cliente (IdCliente,Nombre,Apellido,Correo,Empresa,NumTel,Direccion,CodPostal,Poblacion)
values ( 1,'Felipe','Villalobos','lfvm92@misena.edu.co','sena',3506749182, 'Calle 86A #69t-81', 12345,'Cundinamarca'),
	( 2,'Miguel','Garzon','Miguel@misena.edu.co','sena',3206749182, 'Calle 90A #69t-81', 874965,'Bogota'),
	( 3,'William','Montañezs','william@misena.edu.co','sena',3006159161, 'Calle 100A #15-20', 3156874,'Antioquia'),
	( 4,'Camilo','Alvarez','camilo@misena.edu.co','sena',3112659982, 'Calle 14 #42-60', 4587169,'Cordoba'),
( 5,'Andrea','Chacon','andrea@misena.edu.co','sena',3004486759, 'Calle 86A #69t-81', 659823,'tolima');

	
Select * from Cliente

exec sp_listar