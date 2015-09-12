/****PROCEDIMIENTOS USUARIOS******/
use HtBase;
/*********

drop procedure RUD_Usuarios
go
drop procedure verificarContraseña
go
drop procedure verificarUsuario
go
drop procedure seleccionarUsuarios
***********/
go
create procedure RUD_Usuarios(
@Id int ,
@Nombre nvarchar(20),
@Apellido nvarchar(50),
@Contraseña nvarchar(50),
@tipoUsuario int,
@accion as int) 
 as
 begin

 if @accion = 1 -- insert
 begin
    Insert into HtUsuario (Nombre,Apellido,Contraseña,tipoUsuario) values (@Nombre,@Apellido,@Contraseña,@tipoUsuario)
  end
  else if @accion = 2 -- update
  begin 
   update HtUsuario set 
   Nombre= @Nombre,Apellido=@Apellido,Contraseña=@Contraseña,tipoUsuario= @tipoUsuario
   where Id = @Id;
  end
  else if @accion = 3 -- delete
  begin
  delete from HtUsuario where Id = @Id;
  end


 end;


 go

 create procedure verificarContraseña(@Contraseña nvarchar(50))
 as 
 begin
  select Id  from HtUsuario where Contraseña=@Contraseña;
 end ;
 go

 Create procedure verificarUsuario(@Nombre nvarchar(20),@Contraseña nvarchar(50))
 as 
 begin
  select u.Id,u.Nombre,u.Apellido from HtUsuario as u where u.Nombre=@Nombre and u.Contraseña=@Contraseña;
 end ;
 go



 create procedure seleccionarUsuarios
 as 
 begin 
 Select Id,Nombre,Apellido,Contraseña,tipoUsuario from HtUsuario
 end;