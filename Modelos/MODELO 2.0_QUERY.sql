Create table Grupo (
	codigo_grupo Integer Identity NOT NULL,
	nombre Varchar(15) NOT NULL UNIQUE,
	contrasena Varchar(20) NOT NULL,
	eliminado Integer Default 0 NULL,
Primary Key (codigo_grupo)
) 
go

Create table Formulario (
	id_formulario Integer Identity NOT NULL,
	tipo Varchar(30) NOT NULL,
	fecha_llenado Datetime NOT NULL,
	dia_celula Varchar(15) NOT NULL,
	direccion Varchar(60) NOT NULL,
	es_ofrenda Integer Default 0 NOT NULL,
	monto Float NOT NULL,
	mensaje_consideracion Varchar(200) NOT NULL,
	codigo_grupo Integer NOT NULL,
	id_mensaje Integer NOT NULL,
Primary Key (id_formulario)
) 
go

Create table Persona (
	dni Varchar(10) NOT NULL,
	codigo_grupo Integer NOT NULL,
	nombre Varchar(20) NOT NULL,
	apellido Varchar(20) NOT NULL,
	telefono Varchar(30) NOT NULL,
	fecha_nacimiento Datetime NOT NULL,
	direccion Varchar(30) NOT NULL,
	es_pareja Integer NOT NULL,
	eliminado Integer Default 0 NULL,
Primary Key (dni)
) 
go

Create table Informe (
	id_informe Integer Identity NOT NULL,
	texto Varchar(200) NOT NULL,
	fecha_creacion Datetime NOT NULL,
	tipo Varchar(10) NOT NULL,
	codigo_grupo Integer NOT NULL,
Primary Key (id_informe)
) 
go

Create table Asistencias (
	id_asistencia Integer Identity NOT NULL,
	dni Varchar(10) NOT NULL,
	asistio Integer NOT NULL,
	fecha_creacion Datetime NOT NULL,
	id_mensaje Integer NOT NULL,
Primary Key (id_asistencia)
) 
go

Create table Mensaje_predica (
	id_mensaje Integer Identity NOT NULL,
	titulo Varchar(60) NOT NULL,
	versiculos Varchar(10) NOT NULL,
	texto_mensaje Varchar(300) NOT NULL,
	fecha_emitido Datetime NOT NULL,
Primary Key (id_mensaje)
) 
go


alter table Formulario add   foreign key(codigo_grupo) references Grupo (codigo_grupo) 
go
alter table Informe add   foreign key(codigo_grupo) references Grupo (codigo_grupo) 
go
alter table Persona add   foreign key(codigo_grupo) references Grupo (codigo_grupo) 
go
alter table Asistencias add   foreign key(dni) references Persona (dni) 
go
alter table Formulario add   foreign key(id_mensaje) references Mensaje_predica (id_mensaje) 
go
alter table Asistencias add   foreign key(id_mensaje) references Mensaje_predica (id_mensaje) 
go


