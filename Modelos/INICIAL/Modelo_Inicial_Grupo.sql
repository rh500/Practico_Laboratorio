Create table Grupo (
	codigo_grupo Integer Identity NOT NULL,
	nombre Varchar(15) NOT NULL,
	contrasena Varchar(20) NOT NULL,
	eliminado int,
Primary Key (codigo_grupo)
) 

Create table Formulario (
	id_formulario Integer Identity NOT NULL,
	titulo Varchar(50) NOT NULL,
	versiculos Varchar(200) NOT NULL,
	mensaje_predica Varchar(200) NOT NULL,
	tipo Varchar(30) NULL,
	fecha_emitido Datetime NOT NULL,
	fecha_llenado Datetime NULL,
	dia_celula Char(2) NULL,
	direccion Varchar(60) NULL,
	es_ofrenda Char(1) Default 0 NULL,
	monto Float NULL,
	mensaje_consideracion Varchar(200) NULL,
	codigo_grupo Integer NOT NULL,
Primary Key (id_formulario)
) 

Create table Persona (
	dni Int NOT NULL,
	codigo_grupo Int NOT NULL,
	nombre Varchar(20) NOT NULL,
	apellido Varchar (20) NOT NULL,
	telefono Varchar(30) NOT NULL,
	fecha_nacimiento Datetime NOT NULL,
	direccion varchar(30) NOT NULL,
	es_pareja Char(2) NOT NULL,
	eliminado int,
Primary Key (dni)
) 

Create table Informe (
	id_informe Integer Identity NOT NULL,
	texto Varchar(200) NOT NULL,
	fecha_creacion Datetime NOT NULL,
	codigo_grupo Integer NOT NULL,
	tipo varchar(20) NOT NULL,
Primary Key (id_recomendacion)
) 

Create table Asistencias (
	id_asistencias Int Identity Primary Key,
	dni Integer NOT NULL,
	id_formulario Integer NOT NULL,
) 

alter table Formulario add   foreign key(codigo_grupo) references Grupo (codigo_grupo) 
alter table Recomendacion add   foreign key(codigo_grupo) references Grupo (codigo_grupo) 
alter table Persona add   foreign key(codigo_grupo) references Grupo (codigo_grupo) 
alter table Asistencias add   foreign key(id_formulario) references Formulario (id_formulario) 
alter table Asistencias add   foreign key(dni) references Persona (dni) 

/******modificaciones menores******/
alter table dbo.Persona alter column direccion varchar(30)
alter table dbo.Persona add eliminado int
alter table dbo.Grupo add eliminado int

/*11/01/2015*/
alter table dbo.Informe add tipo varchar(20) NOT NULL
alter table dbo.Grupo add constraint nombre_unico unique (nombre)
