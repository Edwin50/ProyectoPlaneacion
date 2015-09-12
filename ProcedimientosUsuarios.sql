/****PROCEDIMIENTOS USUARIOS******/
use HtBase;
/*********

drop procedure RUD_Usuarios
go
drop procedure verificarContrase�a
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
@Contrase�a nvarchar(50),
@tipoUsuario int,
@accion as int) 
 as
 begin

 if @accion = 1 -- insert
 begin
    Insert into HtUsuario (Nombre,Apellido,Contrase�a,tipoUsuario) values (@Nombre,@Apellido,@Contrase�a,@tipoUsuario)
  end
  else if @accion = 2 -- update
  begin 
   update HtUsuario set 
   Nombre= @Nombre,Apellido=@Apellido,Contrase�a=@Contrase�a,tipoUsuario= @tipoUsuario
   where Id = @Id;
  end
  else if @accion = 3 -- delete
  begin
  delete from HtUsuario where Id = @Id;
  end


 end;


 go

 create procedure verificarContrase�a(@Contrase�a nvarchar(50))
 as 
 begin
  select Id  from HtUsuario where Contrase�a=@Contrase�a;
 end ;
 go

 Create procedure verificarUsuario(@Nombre nvarchar(20),@Contrase�a nvarchar(50))
 as 
 begin
  select u.Id,u.Nombre,u.Apellido from HtUsuario as u where u.Nombre=@Nombre and u.Contrase�a=@Contrase�a;
 end ;
 go



 create procedure seleccionarUsuarios
 as 
 begin 
 Select Id,Nombre,Apellido,Contrase�a,tipoUsuario from HtUsuario
 end;