-- server ALONSO-PC\Alonso
-- server ALONSO-PC\SQLEXPRESS
/*
use master
create database HtBase2;
-- drop database HtBase
 use HtBase;
 */

 
create table HtTrimestre(
HtIdTrimestre int identity primary key,
HtDescTrimestre nvarchar(50),
HtTrimestreHabitado bit
);


create table HtMes(
  HtIdMes int identity primary key,
  HtDescMes nvarchar(50),
  HtIdTrimestre int,
  constraint fk_HtTrimestre_Mes foreign key(HtIdTrimestre) references HtTrimestre(HtIdTrimestre)
);

create table HtAngo(
  HtAngo int identity primary key,
  HtAngoHabilitado bit,
  HtFecha datetime,
  HtIdTrimestre int,
  constraint fk_HtTrimestre_Ango foreign key(HtIdTrimestre) references HtTrimestre(HtIdTrimestre)
);

create table HtTipoEmpleado(
  HtIdTipoEmpleado int identity primary key,
  HtDescripcion nvarchar(50)
);

create table HtEmpleado(
  HtIdEmpleado int identity primary key,
  HtIdSupervisor int,
  HtNombreEmpleado nvarchar(50),
  HtIdTipoEmpleado int,
  HtClave varchar(10),
  HtEstado bit,
  constraint fk_HtTipoEmpleado_HtEmpleado foreign key(HtIdTipoEmpleado) references HtTipoEmpleado(HtIdTipoEmpleado)
);

alter table HtEmpleado add unique(HtClave);


create table HtResultado(
  HtIdResultadoEntrevista int identity primary key,
  HtDescriResultado varchar(50),
  HtEstado tinyint
);

create table HtMoneda(
  HtIdTipoMoneda int identity primary key,
  HtDescripMoneda varchar(50)
);

create table HtRazonSocial(
  HtNumRazonSocial int identity primary key,
  HtDescRazonSocial varchar(50)
);


create table  HtProvincias(
  ProIdProvincia int identity primary key,
  ProNumProvincia tinyint,
  ProNomProvincia nvarchar(50)

);

create table HtCantones(
  CanIDCanton int identity primary key,
  CanIDProvincia int,
  CanNomCanton nvarchar(50),
  CanNumCanton int,
  constraint fk_Provincia_Canton foreign key(CanIDProvincia) references HtProvincias(ProIdProvincia)
);

create table HtRegiones(
  HtIDRegiones int identity primary key,
  HtDescRegion nvarchar(50)
);


create  table HtDistrito(
  DisIDDistrito int identity primary key,
  DisIDCanton int,
  DisNumDistrito tinyint,
  DisNomDistrito nvarchar(100),
  DisIDRegion int,
  DisIDZona int,
  DisIDAreaGeografica int,
  constraint fk_Distrito_Canton foreign key(DisIDCanton) references HtCantones(CanIDCanton),
  constraint fk_Distrito_Region foreign key(DisIDRegion) references HtRegiones(HtIDRegiones)
);

create table HtRamaActividadCIIU4(
  HtIdRamaActividad int identity primary key,
  HtLetraRamaActividad varchar(1),
  HtDescrRamaActividad nvarchar(255),
  HtInicio varchar(7),
  HtFinal varchar(7),
  HtIdEspecial smallint,
  HtLeyendaEspecial varchar(50)
);

create table HtCIIU4(
 HtNumCiiu4 varchar(7) primary key,
 HtDescCiiu4 nvarchar(255),
 HtIdRama int,
 HtNumCii4DosDigitos varchar(2),
 HtNumCii4CuatroDigitos varchar(4),
 HtIdSectorCiiu4 tinyint,
 constraint fk_CIIU4_Rama foreign key (HtIdRama) references HtRamaActividadCIIU4(HtIdRamaActividad)
);

create table HtGrupoRubro(
  HtIdGrupo int identity primary key,
  HtDescripGrupoRubro varchar(50)
)  ;

create table HtRubro(
  HtIdRubro int identity primary key,
  HtDescripRubro varchar(50),
  HtIdGrupo int,
  constraint fk_Rubro_Grupo foreign key(HtIdGrupo) references HtGrupoRubro(HtIdGrupo)
);

create table HtTipoContrato(
  HtIdContrato int identity primary key,
  HtDescripTipoContrato varchar(50)

);

create table HtGenero(
  HtIdGenero int identity primary key,
  HtDescripGenero varchar(50)
);

create table HtGrupoOcupacional(
  HtIdGrupoOcupacional int identity primary key,
  HtDescripGrupoOcupacional varchar(100)

);

create table HtOutsourcing(
  HtConsecutivo int,
  HtNumActividad int,
  HtIdMes int,
  HtAngo int,
  HtNumLinea int,
  HtIdGenero int,
  HtCantidadPersonas int,
  HtIdGrupoOcupacional int,
  /*puede ser que haga falta la relacion con el numero de actividad que este relacionado
  RamaActividad       */
  constraint fk_Out_Ango foreign key(HtAngo) references HtAngo(HtAngo),
  constraint fk_Out_Mes foreign key(HtIdMes) references HtMes(HtIdMes),
  constraint fk_Out_Genero foreign key(HtIdGenero) references HtGenero(HtIdGenero),
  constraint fk_Out_GrupoOcu foreign key(HtIdGrupoOcupacional) references HtGrupoOcupacional(HtIdGrupoOcupacional),
  constraint pk_OutSourcing primary key(HtConsecutivo,HtNumActividad,HtIdMes,HtAngo,HtNumLinea)
);



create table HtBoleta(
  HtIdDistrito int,
  HtConsecutivo int,
  HtNumActividad int,
  HtIdMes int,
  HtAngo int,
  HtNumIdentificacionNegocio varchar(20),
  HtNomNegocio nvarchar(200),
  HtNomLegal nvarchar(200),
  HtNumRazonSocial int,
  HtDirNegocio nvarchar(400),
  HtTel1Negocio int,
  HtExt1Negocio int,
  HtEmail nvarchar(50),
  HtCantidadTrabajadores smallint,
  HtCantidadTrabajadoresHombres smallint,
  HtCantidadTrabajadoresNujeres smallint,
  HtDescCIIUProductoPrincipal nvarchar(400),
  HtNumCiiu4 varchar(7),
  HtNombreInformante nvarchar(50),
  HtCargoDelInformante nvarchar(50),
  HtTelefonoInformante int,
  HtEmailInformante nvarchar(50),
  HtIdResultadoEntrevista int,
  HtObservaciones nvarchar(400),
  HtIdEmpleado int,
  HtHoraInicio datetime,
  HtHoraFinal datetime,
  HtDuracionEntrevista varchar(5),
  HtFechaEntrevista datetime,
  HtFechaUltimaModificacion datetime,
  HtIntentosEntrevista smallint,
  HtTipoDeCambio smallint,
  HtIdTipoMoneda int,
  HtTotalDirectivosMujer int,
  HtTotalDirectivosHombre int,
  HtTotalDirectivos int,
  HtTotalProfesionalesMujer int,
  HtTotalProfesionalesHombre int,
  HtTotalProfesionales int,
  HtTotalTecnicosMujer int,
  HtTotalTecnicosHombre int,
  HtTotalTecnicos int,
  HtTotalApoyoAdminMujer int,
  HtTotalApoyoAdminHombre int,
  HtTotalApoyoAdmin int,
  HtTotalServiciosMujer int,
  HtTotalServiciosHombre int,
  HtTotalServicios int,
  HtTotalAgricultoresMujer int,
  HtTotalAgricultoresHombre int,
  HtTotalAgricultores int,
  HtTotalOperariosMujer int,
  HtTotalOperariosHombre int,
  HtTotalOperarios int,
  HtTotalOperadoresMujer int,
  HtTotalOperadoresHombre int,
  HtTotalOperadores int,
  HtTotalOcupElementalesMujer int,
  HtTotalOcupElementalesHombre int,
  HtTotalOcupElementales int,
  HtSalarioBaseTotal int,
  HtSalEspecieTotal int,
  HtPagoHrsExtraTotal int,
  HtAguinaldoTotal int,
  HtSalEscolarTotal int,
  HtRemuneracionesTotal int,
  HtTotalCostoDirectivos int,
  HtTotalCostoProfecionales int,
  HtTotalCostoTecnicos int,
  HtTotalCostoApoyoAdmin int,
  HtTotalCostoServicios int,
  HtTotalCostoAgricultores int,
  HtTotalCostoOperarios int,
  HtTotalCostoOperadores int,
  HtTotalCostoOcupElementales int,
  HtTotalCosto int,
  HtDeducccionTotal int,
  HtTotalHorasDerectivos int,
  HtTotalHorasProfecionales int,
  HtTotalHorasTecnicos int,
  HtTotalHorasApoyoAdmin int,
  HtTotalHorasServicios int,
  HtTotalHorasAgricultores int,
  HtTotalHorasOperarios int,
  HtTotalHorasOperadores int,
  HtTotalHorasOcupElementales int,
  HtTotalHorasOrdinarias int,
  HtTotalHorasExtra int,
  HtTotalHoras int,
  HtTotalOutsourcing int,
  HtTotalOutsourcingMujer int,
  HtTotalOutsourcingHombre int,
  HtIdEntrevistador int,
   constraint fk_Boleta_Mes foreign key(HtIdMes) references HtMes(HtIdMes),
  constraint fk_Boleta_Ango foreign key(HtAngo) references HtAngo(HtAngo),
  constraint fk_Boleta_Moneda foreign key(HtIdTipoMoneda) references HtMoneda(HtIdTipoMoneda),
  constraint fk_Boleta_Empleado foreign key(HtIdEmpleado) references HtEmpleado(HtIdEmpleado),
  constraint fk_Boleta_Resultado foreign key(HtIdResultadoEntrevista) references HtResultado(HtIdResultadoEntrevista),
  constraint fk_Boleta_CIIU foreign key(HtNumCiiu4) references HtCIIU4(HtNumCiiu4),
  constraint fk_Boleta_Razon foreign key(HtNumRazonSocial) references HtRazonSocial(HtNumRazonSocial),
  constraint fk_Boleta_Distrito foreign key(HtIdDistrito) references HtDistrito(DisIDDistrito),
  constraint pk_Boleta primary key(HtConsecutivo,HtNumActividad,HtIdMes,HtAngo)
);


create table HtDetalleTotales(
  HtConsecutivo int,
  HtNumActividad int,
  HtIdMes int,
  HtAngo int,
  HtNumLinea int,
  HtIdGrupoOcupacional int,
  HtNombre varchar(50),
  HtApellido varchar(50),
  HtCantidad int,
  HtIdGenero int,
  HtIdTipoContrato int,
  HtCedula varchar(20),
  HtIdRubro int,
  HtIdCamino int,
  HtObservaciones nvarchar(400),
  /*puede ser que haga falta la relacion con el numero de actividad que este relacionado
  RamaActividad       */
  constraint fk_DetalleTotal_Contrato foreign key(HtIdTipoContrato) references HtTipoContrato(HtIdContrato),
  constraint fk_DetalleTotal_Rubro foreign key(HtIdRubro) references HtRubro(HtIdRubro),
  constraint fk_DetalleTotal_Boleta foreign key(HtConsecutivo,HtNumActividad,HtIdMes,HtAngo) references HtBoleta(HtConsecutivo,HtNumActividad,HtIdMes,HtAngo),
  constraint fk_DetalleTotal_Genero foreign key(HtIdGenero) references HtGenero(HtIdGenero),
  constraint fk_DetalleTotal_GrupoOcu foreign key(HtIdGrupoOcupacional) references HtGrupoOcupacional(HtIdGrupoOcupacional),
  constraint pk_DetalleTotal primary key(HtConsecutivo,HtNumActividad,HtIdMes,HtAngo,HtNumLinea,HtIdCamino)
);

