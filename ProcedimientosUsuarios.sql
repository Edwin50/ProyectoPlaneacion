/****PROCEDIMIENTOS USUARIOS******/
use HtBase;
/*********

drop procedure RUD_Usuarios
go
drop procedure verificarContraseņa
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
@Contraseņa nvarchar(50),
@tipoUsuario int,
@accion as int) 
 as
 begin

 if @accion = 1 -- insert
 begin
    Insert into HtUsuario (Nombre,Apellido,Contraseņa,tipoUsuario) values (@Nombre,@Apellido,@Contraseņa,@tipoUsuario)
  end
  else if @accion = 2 -- update
  begin 
   update HtUsuario set 
   Nombre= @Nombre,Apellido=@Apellido,Contraseņa=@Contraseņa,tipoUsuario= @tipoUsuario
   where Id = @Id;
  end
  else if @accion = 3 -- delete
  begin
  delete from HtUsuario where Id = @Id;
  end


 end;


 go

 create procedure verificarContraseņa(@Contraseņa nvarchar(50))
 as 
 begin
  select Id  from HtUsuario where Contraseņa=@Contraseņa;
 end ;
 go

 Create procedure verificarUsuario(@Nombre nvarchar(20),@Contraseņa nvarchar(50))
 as 
 begin
  select u.Id,u.Nombre,u.Apellido from HtUsuario as u where u.Nombre=@Nombre and u.Contraseņa=@Contraseņa;
 end ;
 go



 create procedure seleccionarUsuarios
 as 
 begin 
 Select Id,Nombre,Apellido,Contraseņa,tipoUsuario from HtUsuario
 end;