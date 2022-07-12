create database  BDCRUDCORE;
use BDCRUDCORE;
create table contacto(
IdContacto  int primary key,
Nombre varchar(50),
Telefono varchar(20),
Correo varchar(40)
);

go 

create procedure sp_listar 
as
begin
select * from contacto
end;

go 
create procedure sp_obtener(
@Idcontacto int
)
as
begin
select * from contacto where IdContacto = @Idcontacto
end;

go 

create procedure sp_Guardar(
@Nombre varchar(50),
@Telefono varchar(20),
@Correo varchar(40)
)
as
begin
insert into contacto(Nombre,Telefono,Correo) values 
(@Nombre,@Telefono,@Correo)
end;

go 

create procedure sp_Editar(
@IdContacto int,
@Nombre varchar(50),
@Telefono varchar(20),
@Correo varchar(40)
)
as
begin
update contacto set Nombre = @Nombre,Telefono = @Telefono,
Correo = @Correo where IdContacto = @IdContacto
End;

go 

create procedure sp_Eliminar(
@IdContacto int
)
as
begin
delete from contacto where IdContacto = @IdContacto
end;
