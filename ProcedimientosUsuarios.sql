/****PROCEDIMIENTOS USUARIOS******/
use HtBase2;
/*********

drop procedure RUD_Empleado
go
drop procedure verificarContraseña
go
drop procedure verificarEmpleado
go
drop procedure seleccionarEmpleado
***********/
go
create procedure RUD_Empleado(
@Id int ,
@Supervisor int,
@Nombre nvarchar(50),
@Estado bit,
@Clave varchar(10),
@tipoEmpleado int,
@accion as int) 
 as
 begin

 if @accion = 1 -- insert
 begin
    Insert into HtEmpleado( HtIdSupervisor, HtNombreEmpleado,HtIdTipoEmpleado,HtClave,HtEstado)
	 values (@Supervisor,@Nombre,@tipoEmpleado,@Clave,@Estado)
  end
  else if @accion = 2 -- update
  begin 
   update HtEmpleado set 
    HtNombreEmpleado= @Nombre, HtIdSupervisor=@Supervisor,
	HtClave=@Clave,HtIdTipoEmpleado= @tipoEmpleado,
	HtEstado=@Estado
   where HtIdEmpleado = @Id;
  end
  else if @accion = 3 -- delete
  begin
  delete from HtEmpleado where HtIdEmpleado = @Id;
  end


 end;


 go

 create procedure verificarContraseña(@Contraseña varchar(10))
 as 
 begin
  select HtIdEmpleado  from HtEmpleado where HtClave=@Contraseña;
 end ;
 go

 Create procedure verificarEmpleado(@Nombre nvarchar(50),@Contraseña varchar(10))
 as 
 begin
  select u.HtIdEmpleado,u.HtNombreEmpleado from HtEmpleado as u where u.HtNombreEmpleado=@Nombre and u.HtClave=@Contraseña;
 end ;
 go


create procedure seleccionarEmpleados
 as 
 begin 
 Select HtIdEmpleado,HtNombreEmpleado,HtIdSupervisor,
 HtClave,HtEstado, HtIdTipoEmpleado from HtEmpleado
 end;



 