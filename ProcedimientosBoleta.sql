/***************Procedimientos Boletas******************/
use HtBase2;
 go
create procedure RUD_Boleta(
  @HtIdDistrito int,
  @HtConsecutivo int,
  @HtNumActividad int,
  @HtIdMes int,
  @HtAngo int,
  @HtNumIdentificacionNegocio varchar(20),
  @HtNomNegocio nvarchar(200),
  @HtNomLegal nvarchar(200),
  @HtNumRazonSocial int,
  @HtDirNegocio nvarchar(400),
  @HtTel1Negocio int,
  @HtExt1Negocio int,
  @HtEmail nvarchar(50),
  @HtCantidadTrabajadores smallint,
  @HtCantidadTrabajadoresHombres smallint,
  @HtCantidadTrabajadoresNujeres smallint,
  @HtDescCIIUProductoPrincipal nvarchar(400),
  @HtNumCiiu4 varchar(7),
  @HtNombreInformante nvarchar(50),
  @HtCargoDelInformante nvarchar(50),
  @HtTelefonoInformante int,
  @HtEmailInformante nvarchar(50),
  @HtIdResultadoEntrevista int,
  @HtObservaciones nvarchar(400),
  @HtIdEmpleado int,
  @HtHoraInicio datetime,
  @HtHoraFinal datetime,
  @HtDuracionEntrevista varchar(5),
  @HtFechaEntrevista datetime,
  @HtFechaUltimaModificacion datetime,
  @HtIntentosEntrevista smallint,
  @HtTipoDeCambio smallint,
  @HtIdTipoMoneda int,
  @HtTotalDirectivosMujer int,
  @HtTotalDirectivosHombre int,
  @HtTotalDirectivos int,
  @HtTotalProfesionalesMujer int,
  @HtTotalProfesionalesHombre int,
  @HtTotalProfesionales int,
  @HtTotalTecnicosMujer int,
  @HtTotalTecnicosHombre int,
  @HtTotalTecnicos int,
  @HtTotalApoyoAdminMujer int,
  @HtTotalApoyoAdminHombre int,
  @HtTotalApoyoAdmin int,
  @HtTotalServiciosMujer int,
  @HtTotalServiciosHombre int,
  @HtTotalServicios int,
  @HtTotalAgricultoresMujer int,
  @HtTotalAgricultoresHombre int,
  @HtTotalAgricultores int,
  @HtTotalOperariosMujer int,
  @HtTotalOperariosHombre int,
  @HtTotalOperarios int,
  @HtTotalOperadoresMujer int,
  @HtTotalOperadoresHombre int,
  @HtTotalOperadores int,
  @HtTotalOcupElementalesMujer int,
  @HtTotalOcupElementalesHombre int,
  @HtTotalOcupElementales int,
  @HtSalarioBaseTotal int,
  @HtSalEspecieTotal int,
  @HtPagoHrsExtraTotal int,
  @HtAguinaldoTotal int,
  @HtSalEscolarTotal int,
  @HtRemuneracionesTotal int,
  @HtTotalCostoDirectivos int,
  @HtTotalCostoProfecionales int,
  @HtTotalCostoTecnicos int,
  @HtTotalCostoApoyoAdmin int,
  @HtTotalCostoServicios int,
  @HtTotalCostoAgricultores int,
  @HtTotalCostoOperarios int,
  @HtTotalCostoOperadores int,
  @HtTotalCostoOcupElementales int,
  @HtTotalCosto int,
  @HtDeducccionTotal int,
  @HtTotalHorasDerectivos int,
  @HtTotalHorasProfecionales int,
  @HtTotalHorasTecnicos int,
  @HtTotalHorasApoyoAdmin int,
  @HtTotalHorasServicios int,
  @HtTotalHorasAgricultores int,
  @HtTotalHorasOperarios int,
  @HtTotalHorasOperadores int,
  @HtTotalHorasOcupElementales int,
  @HtTotalHorasOrdinarias int,
  @HtTotalHorasExtra int,
  @HtTotalHoras int,
  @HtTotalOutsourcing int,
  @HtTotalOutsourcingMujer int,
  @HtTotalOutsourcingHombre int,
  @HtIdEntrevistador int,
  @accion int) 
 as
 begin

 if @accion = 1 -- insert
 begin
    Insert into HtBoleta( 
	HtIdDistrito ,
HtConsecutivo ,
HtNumActividad ,
HtIdMes ,
HtAngo ,
HtNumIdentificacionNegocio ,
HtNomNegocio ,
HtNomLegal ,
HtNumRazonSocial ,
HtDirNegocio ,
HtTel1Negocio ,
HtExt1Negocio ,
HtEmail ,
HtCantidadTrabajadores ,
HtCantidadTrabajadoresHombres ,
HtCantidadTrabajadoresNujeres ,
HtDescCIIUProductoPrincipal ,
HtNumCiiu4 ,
HtNombreInformante ,
HtCargoDelInformante ,
HtTelefonoInformante ,
HtEmailInformante ,
HtIdResultadoEntrevista ,
HtObservaciones ,
HtIdEmpleado ,
HtHoraInicio ,
HtHoraFinal ,
HtDuracionEntrevista ,
HtFechaEntrevista ,
HtFechaUltimaModificacion,
HtIntentosEntrevista ,
HtTipoDeCambio ,
HtIdTipoMoneda ,
HtTotalDirectivosMujer ,
HtTotalDirectivosHombre ,
HtTotalDirectivos ,
HtTotalProfesionalesMujer ,
HtTotalProfesionalesHombre ,
HtTotalProfesionales ,
HtTotalTecnicosMujer ,
HtTotalTecnicosHombre ,
HtTotalTecnicos ,
HtTotalApoyoAdminMujer ,
HtTotalApoyoAdminHombre ,
HtTotalApoyoAdmin ,
HtTotalServiciosMujer ,
HtTotalServiciosHombre ,
HtTotalServicios ,
HtTotalAgricultoresMujer ,
HtTotalAgricultoresHombre ,
HtTotalAgricultores ,
HtTotalOperariosMujer ,
HtTotalOperariosHombre ,
HtTotalOperarios ,
HtTotalOperadoresMujer ,
HtTotalOperadoresHombre ,
HtTotalOperadores ,
HtTotalOcupElementalesMujer ,
HtTotalOcupElementalesHombre ,
HtTotalOcupElementales ,
HtSalarioBaseTotal ,
HtSalEspecieTotal ,
HtPagoHrsExtraTotal ,
HtAguinaldoTotal ,
HtSalEscolarTotal ,
HtRemuneracionesTotal ,
HtTotalCostoDirectivos ,
HtTotalCostoProfecionales ,
HtTotalCostoTecnicos ,
HtTotalCostoApoyoAdmin ,
HtTotalCostoServicios ,
HtTotalCostoAgricultores ,
HtTotalCostoOperarios ,
HtTotalCostoOperadores ,
HtTotalCostoOcupElementales ,
HtTotalCosto ,
HtDeducccionTotal ,
HtTotalHorasDerectivos ,
HtTotalHorasProfecionales ,
HtTotalHorasTecnicos ,
HtTotalHorasApoyoAdmin ,
HtTotalHorasServicios ,
HtTotalHorasAgricultores ,
HtTotalHorasOperarios ,
HtTotalHorasOperadores ,
HtTotalHorasOcupElementales ,
HtTotalHorasOrdinarias ,
HtTotalHorasExtra ,
HtTotalHoras ,
HtTotalOutsourcing ,
HtTotalOutsourcingMujer ,
HtTotalOutsourcingHombre ,
HtIdEntrevistador 
)
	 values (
	 @HtIdDistrito ,
	 @HtConsecutivo ,
@HtNumActividad ,
@HtIdMes ,
@HtAngo ,
@HtNumIdentificacionNegocio ,
@HtNomNegocio ,
@HtNomLegal ,
@HtNumRazonSocial ,
@HtDirNegocio ,
@HtTel1Negocio ,
@HtExt1Negocio ,
@HtEmail ,
@HtCantidadTrabajadores ,
@HtCantidadTrabajadoresHombres ,
@HtCantidadTrabajadoresNujeres ,
@HtDescCIIUProductoPrincipal ,
@HtNumCiiu4 ,
@HtNombreInformante ,
@HtCargoDelInformante ,
@HtTelefonoInformante ,
@HtEmailInformante ,
@HtIdResultadoEntrevista ,
@HtObservaciones ,
@HtIdEmpleado ,
@HtHoraInicio ,
@HtHoraFinal ,
@HtDuracionEntrevista ,
@HtFechaEntrevista ,
@HtFechaUltimaModificacion,
@HtIntentosEntrevista ,
@HtTipoDeCambio ,
@HtIdTipoMoneda ,
@HtTotalDirectivosMujer ,
@HtTotalDirectivosHombre ,
@HtTotalDirectivos ,
@HtTotalProfesionalesMujer ,
@HtTotalProfesionalesHombre ,
@HtTotalProfesionales ,
@HtTotalTecnicosMujer ,
@HtTotalTecnicosHombre ,
@HtTotalTecnicos ,
@HtTotalApoyoAdminMujer ,
@HtTotalApoyoAdminHombre ,
@HtTotalApoyoAdmin ,
@HtTotalServiciosMujer ,
@HtTotalServiciosHombre ,
@HtTotalServicios ,
@HtTotalAgricultoresMujer ,
@HtTotalAgricultoresHombre ,
@HtTotalAgricultores ,
@HtTotalOperariosMujer ,
@HtTotalOperariosHombre ,
@HtTotalOperarios ,
@HtTotalOperadoresMujer ,
@HtTotalOperadoresHombre ,
@HtTotalOperadores ,
@HtTotalOcupElementalesMujer ,
@HtTotalOcupElementalesHombre ,
@HtTotalOcupElementales ,
@HtSalarioBaseTotal ,
@HtSalEspecieTotal ,
@HtPagoHrsExtraTotal ,
@HtAguinaldoTotal ,
@HtSalEscolarTotal ,
@HtRemuneracionesTotal ,
@HtTotalCostoDirectivos ,
@HtTotalCostoProfecionales ,
@HtTotalCostoTecnicos ,
@HtTotalCostoApoyoAdmin ,
@HtTotalCostoServicios ,
@HtTotalCostoAgricultores ,
@HtTotalCostoOperarios ,
@HtTotalCostoOperadores ,
@HtTotalCostoOcupElementales ,
@HtTotalCosto ,
@HtDeducccionTotal ,
@HtTotalHorasDerectivos ,
@HtTotalHorasProfecionales ,
@HtTotalHorasTecnicos ,
@HtTotalHorasApoyoAdmin ,
@HtTotalHorasServicios ,
@HtTotalHorasAgricultores ,
@HtTotalHorasOperarios ,
@HtTotalHorasOperadores ,
@HtTotalHorasOcupElementales ,
@HtTotalHorasOrdinarias ,
@HtTotalHorasExtra ,
@HtTotalHoras ,
@HtTotalOutsourcing ,
@HtTotalOutsourcingMujer ,
@HtTotalOutsourcingHombre ,
@HtIdEntrevistador)
  end
  else if @accion = 2 -- update
  begin 
update HtBoleta set 
HtIdDistrito = @HtIdDistrito,
HtNumIdentificacionNegocio = @HtNumIdentificacionNegocio ,
HtNomNegocio = @HtNomNegocio ,
HtNomLegal = @HtNomLegal ,
HtNumRazonSocial = @HtNumRazonSocial ,
HtDirNegocio = @HtDirNegocio ,
HtTel1Negocio = @HtTel1Negocio ,
HtExt1Negocio = @HtExt1Negocio ,
HtEmail = @HtEmail , 
HtCantidadTrabajadores = @HtCantidadTrabajadores ,
HtCantidadTrabajadoresHombres = @HtCantidadTrabajadoresHombres ,
HtCantidadTrabajadoresNujeres = @HtCantidadTrabajadoresNujeres ,
HtDescCIIUProductoPrincipal = @HtDescCIIUProductoPrincipal ,
HtNumCiiu4 = @HtNumCiiu4 ,
HtNombreInformante = @HtNombreInformante ,
HtCargoDelInformante =  @HtCargoDelInformante,
HtTelefonoInformante = @HtTelefonoInformante ,
HtEmailInformante = @HtEmailInformante ,
HtIdResultadoEntrevista = @HtIdResultadoEntrevista ,
HtObservaciones = @HtObservaciones ,
HtIdEmpleado = @HtIdEmpleado ,
HtHoraInicio = @HtHoraInicio ,
HtHoraFinal = @HtHoraFinal ,
HtDuracionEntrevista = @HtDuracionEntrevista ,
HtFechaEntrevista = @HtFechaEntrevista ,
HtFechaUltimaModificacion= @HtFechaUltimaModificacion,
HtIntentosEntrevista = @HtIntentosEntrevista ,
HtTipoDeCambio = @HtTipoDeCambio ,
HtIdTipoMoneda = @HtIdTipoMoneda ,
HtTotalDirectivosMujer = @HtTotalDirectivosMujer ,
HtTotalDirectivosHombre = @HtTotalDirectivosHombre ,
HtTotalDirectivos = @HtTotalDirectivos ,
HtTotalProfesionalesMujer = @HtTotalProfesionalesMujer ,
HtTotalProfesionalesHombre = @HtTotalProfesionalesHombre ,
HtTotalProfesionales = @HtTotalProfesionales ,
HtTotalTecnicosMujer = @HtTotalTecnicosMujer ,
HtTotalTecnicosHombre = @HtTotalTecnicosHombre ,
HtTotalTecnicos = @HtTotalTecnicos ,
HtTotalApoyoAdminMujer = @HtTotalApoyoAdminMujer ,
HtTotalApoyoAdminHombre = @HtTotalApoyoAdminHombre ,
HtTotalApoyoAdmin = @HtTotalApoyoAdmin ,
HtTotalServiciosMujer = @HtTotalServiciosMujer ,
HtTotalServiciosHombre = @HtTotalServiciosHombre ,
HtTotalServicios = @HtTotalServicios ,
HtTotalAgricultoresMujer = @HtTotalAgricultoresMujer ,
HtTotalAgricultoresHombre = @HtTotalAgricultoresHombre ,
HtTotalAgricultores = @HtTotalAgricultores ,
HtTotalOperariosMujer = @HtTotalOperariosMujer ,
HtTotalOperariosHombre = @HtTotalOperariosHombre ,
HtTotalOperarios = @HtTotalOperarios ,
HtTotalOperadoresMujer = @HtTotalOperadoresMujer ,
HtTotalOperadoresHombre = @HtTotalOperadoresHombre ,
HtTotalOperadores = @HtTotalOperadores ,
HtTotalOcupElementalesMujer = @HtTotalOcupElementalesMujer ,
HtTotalOcupElementalesHombre = @HtTotalOcupElementalesHombre ,
HtTotalOcupElementales = @HtTotalOcupElementales ,
HtSalarioBaseTotal = @HtSalarioBaseTotal ,
HtSalEspecieTotal = @HtSalEspecieTotal ,
HtPagoHrsExtraTotal = @HtPagoHrsExtraTotal ,
HtAguinaldoTotal = @HtAguinaldoTotal ,
HtSalEscolarTotal = @HtSalEscolarTotal ,
HtRemuneracionesTotal = @HtRemuneracionesTotal ,
HtTotalCostoDirectivos = @HtTotalCostoDirectivos ,
HtTotalCostoProfecionales = @HtTotalCostoProfecionales ,
HtTotalCostoTecnicos = @HtTotalCostoTecnicos ,
HtTotalCostoApoyoAdmin = @HtTotalCostoApoyoAdmin ,
HtTotalCostoServicios = @HtTotalCostoServicios ,
HtTotalCostoAgricultores = @HtTotalCostoAgricultores ,
HtTotalCostoOperarios = @HtTotalCostoOperarios ,
HtTotalCostoOperadores = @HtTotalCostoOperadores ,
HtTotalCostoOcupElementales = @HtTotalCostoOcupElementales ,
HtTotalCosto = @HtTotalCosto ,
HtDeducccionTotal = @HtDeducccionTotal ,
HtTotalHorasDerectivos = @HtTotalHorasDerectivos ,
HtTotalHorasProfecionales = @HtTotalHorasProfecionales ,
HtTotalHorasTecnicos = @HtTotalHorasTecnicos ,
HtTotalHorasApoyoAdmin = @HtTotalHorasApoyoAdmin ,
HtTotalHorasServicios = @HtTotalHorasServicios ,
HtTotalHorasAgricultores = @HtTotalHorasAgricultores ,
HtTotalHorasOperarios = @HtTotalHorasOperarios ,
HtTotalHorasOperadores = @HtTotalHorasOperadores ,
HtTotalHorasOcupElementales = @HtTotalHorasOcupElementales ,
HtTotalHorasOrdinarias = @HtTotalHorasOrdinarias ,
HtTotalHorasExtra = @HtTotalHorasExtra ,
HtTotalHoras = @HtTotalHoras ,
HtTotalOutsourcing = @HtTotalOutsourcing ,
HtTotalOutsourcingMujer = @HtTotalOutsourcingMujer ,
HtTotalOutsourcingHombre = @HtTotalOutsourcingHombre ,
HtIdEntrevistador = @HtIdEntrevistador
   where HtConsecutivo = @HtConsecutivo and HtNumActividad = @HtNumActividad and HtIdMes = @HtIdMes  and HtAngo = @HtAngo;
  end
  else if @accion = 3 -- delete
  begin
  delete from HtBoleta where HtConsecutivo = @HtConsecutivo and HtNumActividad = @HtNumActividad and HtIdMes = @HtIdMes  and HtAngo = @HtAngo;
  end


 end;


 go

 

create procedure seleccionarBoletas
 as 
 begin 
 Select 
 HtIdDistrito ,
HtConsecutivo ,
HtNumActividad ,
HtIdMes ,
HtAngo ,
HtNumIdentificacionNegocio ,
HtNomNegocio ,
HtNomLegal ,
HtNumRazonSocial ,
HtDirNegocio ,
HtTel1Negocio ,
HtExt1Negocio ,
HtEmail ,
HtCantidadTrabajadores ,
HtCantidadTrabajadoresHombres ,
HtCantidadTrabajadoresNujeres ,
HtDescCIIUProductoPrincipal ,
HtNumCiiu4 ,
HtNombreInformante ,
HtCargoDelInformante ,
HtTelefonoInformante ,
HtEmailInformante ,
HtIdResultadoEntrevista ,
HtObservaciones ,
HtIdEmpleado ,
HtHoraInicio ,
HtHoraFinal ,
HtDuracionEntrevista ,
HtFechaEntrevista ,
HtFechaUltimaModificacion,
HtIntentosEntrevista ,
HtTipoDeCambio ,
HtIdTipoMoneda ,
HtTotalDirectivosMujer ,
HtTotalDirectivosHombre ,
HtTotalDirectivos ,
HtTotalProfesionalesMujer ,
HtTotalProfesionalesHombre ,
HtTotalProfesionales ,
HtTotalTecnicosMujer ,
HtTotalTecnicosHombre ,
HtTotalTecnicos ,
HtTotalApoyoAdminMujer ,
HtTotalApoyoAdminHombre ,
HtTotalApoyoAdmin ,
HtTotalServiciosMujer ,
HtTotalServiciosHombre ,
HtTotalServicios ,
HtTotalAgricultoresMujer ,
HtTotalAgricultoresHombre ,
HtTotalAgricultores ,
HtTotalOperariosMujer ,
HtTotalOperariosHombre ,
HtTotalOperarios ,
HtTotalOperadoresMujer ,
HtTotalOperadoresHombre ,
HtTotalOperadores ,
HtTotalOcupElementalesMujer ,
HtTotalOcupElementalesHombre ,
HtTotalOcupElementales ,
HtSalarioBaseTotal ,
HtSalEspecieTotal ,
HtPagoHrsExtraTotal ,
HtAguinaldoTotal ,
HtSalEscolarTotal ,
HtRemuneracionesTotal ,
HtTotalCostoDirectivos ,
HtTotalCostoProfecionales ,
HtTotalCostoTecnicos ,
HtTotalCostoApoyoAdmin ,
HtTotalCostoServicios ,
HtTotalCostoAgricultores ,
HtTotalCostoOperarios ,
HtTotalCostoOperadores ,
HtTotalCostoOcupElementales ,
HtTotalCosto ,
HtDeducccionTotal ,
HtTotalHorasDerectivos ,
HtTotalHorasProfecionales ,
HtTotalHorasTecnicos ,
HtTotalHorasApoyoAdmin ,
HtTotalHorasServicios ,
HtTotalHorasAgricultores ,
HtTotalHorasOperarios ,
HtTotalHorasOperadores ,
HtTotalHorasOcupElementales ,
HtTotalHorasOrdinarias ,
HtTotalHorasExtra ,
HtTotalHoras ,
HtTotalOutsourcing ,
HtTotalOutsourcingMujer ,
HtTotalOutsourcingHombre ,
HtIdEntrevistador
 from HtBoleta
 end;


 go