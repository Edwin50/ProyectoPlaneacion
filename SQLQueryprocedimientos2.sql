

use HtBase2;


go
create procedure sp_cantidadTrabajadoresPorGeneroDistrito(@genero int ,@distrito int)
as
begin
select g.HtDescripGenero,dis.DisNomDistrito,count(det.HtConsecutivo)as 'Cantidad de Empleados' 
from HtDetalleTotales as det inner join
HtGenero as g on det.HtIdGenero = g.HtIdGenero
inner join HtBoleta as bol on det.HtConsecutivo = bol.HtConsecutivo and 
det.HtNumActividad = bol.HtNumActividad and det.HtIdMes = bol.HtIdMes
and det.HtAngo = bol.HtAngo
inner join HtDistrito as dis on bol.HtIdDistrito = dis.DisIDDistrito
where det.HtIdGenero = @genero and dis.DisIDDistrito = @distrito
group by  g.HtDescripGenero,dis.DisNomDistrito
end;

go 
create procedure sp_ObtenerGeneros
as 
begin
Select HtIdGenero, HtDescripGenero from HtGenero
end;

go

create procedure sp_CantidadEmpresasOutSourcing
as 
begin
select count(bol.HtConsecutivo)as 'Cantidad de empresas apoyadas en outsourcing' from HtBoleta as bol 
inner join HtOutsourcing as ot on
bol.HtConsecutivo = ot.HtConsecutivo and 
bol.HtNumActividad = ot.HtNumActividad and
bol.HtIdMes = ot.HtIdMes and
bol.HtAngo = ot.HtAngo;
end;


go

create procedure sp_rangoHoras
as
begin
select max(CONVERT(VARCHAR(8),HtHoraInicio,108))as 'Maxima hora de inicio',min(CONVERT(VARCHAR(8),HtHoraInicio,108))as 'Minima hora de inicio',max(CONVERT(VARCHAR(8),HtHoraFinal,108)) as 'Maxima hora final',min(CONVERT(VARCHAR(8),HtHoraFinal,108)) as'Minima hora final' from HtBoleta as bol

end;
