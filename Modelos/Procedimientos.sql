/*ESTOS SON LOS PROCEDIMIENTOS DE LA TABLA PERSONA*/
CREATE PROCEDURE sp_Agregar_Persona (
			@dni int,
			@codigo_grupo int, 
			@nombre varchar (20),
			@apellido varchar(20),
			@telefono varchar(30), 
			@fecha_nacimiento datetime,
			@direccion varchar(30),
			@es_pareja int)
AS
BEGIN
	insert into dbo.Persona values(@dni,@codigo_grupo,@nombre,@apellido,@telefono,@fecha_nacimiento,@direccion,@es_pareja,0)
END
/************************/
ALTER PROCEDURE sp_ListarPersonas
AS 
BEGIN 
	SELECT p.dni,g.nombre nombre_grupo,p.nombre,p.apellido,p.telefono,p.fecha_nacimiento,p.direccion,p.es_pareja
		FROM dbo.Persona p
		LEFT JOIN grupo g
		ON (g.codigo_grupo = p.codigo_grupo)
		WHERE p.eliminado = 0
END
/***********************/
/*en visual deberia estar en la clase GRUPO*/
ALTER PROCEDURE sp_ListarIntegrantes 
			@codigo_grupo int
AS
BEGIN
	SELECT * 
		FROM dbo.Persona 
		WHERE codigo_grupo = @codigo_grupo
		AND
			  eliminado = 0
		AND
			  es_pareja = 0
END
/***********************/
CREATE PROCEDURE sp_Modificar_Persona 
			@dni int,@codigo_grupo int,
			@nombre varchar (20),
			@apellido varchar(20),
			@telefono varchar(30),
			@fecha_nacimiento datetime,
			@direccion varchar(30),
			@es_pareja int
AS
BEGIN
	update dbo.Persona set codigo_grupo=@codigo_grupo where dni=@dni
	update dbo.Persona set nombre=@nombre where dni=@dni
	update dbo.Persona set apellido=@apellido where dni=@dni
	update dbo.Persona set telefono=@telefono where dni=@dni
	update dbo.Persona set fecha_nacimiento=@fecha_nacimiento where dni=@dni
	update dbo.Persona set direccion=@direccion where dni=@dni
	update dbo.Persona set es_pareja=@es_pareja where dni=@dni
END
/***********************/
ALTER PROCEDURE sp_Eliminar_Persona 
			@dni int
AS
BEGIN
	UPDATE persona SET codigo_grupo = null WHERE dni = @dni
	UPDATE persona SET eliminado = 1 WHERE dni = @dni
END
/***********************/
/*CON ESTE TRAERE LOS DATOS DE LAS PAREJAS*/
ALTER PROCEDURE sp_Buscar_Parejas 
				@codigo_grupo int
AS
BEGIN
	SELECT p.codigo_grupo,p.nombre,p.apellido,p.telefono,p.direccion 
		FROM Persona p
		JOIN
			Grupo g
		ON (p.codigo_grupo = g.codigo_grupo)
		WHERE p.codigo_grupo = @codigo_grupo
		AND
			p.es_pareja = 1
		AND p.eliminado = 0
END


/*PROCEDIMIENTOS DE LA TABLA GRUPO*/
CREATE PROCEDURE sp_Agregar_Grupo 
					@nombre varchar(15),
					@contrasena varchar(20)
AS
BEGIN
	INSERT INTO grupo VALUES (@nombre,@contrasena,0)
END
/***********************/
CREATE PROCEDURE sp_Eliminar_Grupo @codigo_grupo int
AS
BEGIN
	UPDATE persona SET codigo_grupo = NULL WHERE codigo_grupo = @codigo_grupo
	UPDATE dbo.Grupo SET eliminado = 1 WHERE codigo_grupo = @codigo_grupo
END
/**********************/
ALTER PROCEDURE sp_Conectar_Grupo 
		@nombre varchar(15),
		@contraseña varchar(20)
AS 
BEGIN
	SELECT * 
			FROM dbo.Grupo 
			WHERE codigo_grupo in ( SELECT codigo_grupo
									FROM persona
									WHERE es_pareja = 1
									GROUP BY codigo_grupo
									HAVING COUNT(codigo_grupo) = 2
									OR codigo_grupo = 2)
			AND nombre = @nombre and contrasena = @contraseña
			AND
				eliminado = 0 
			
END
/**********************/
ALTER PROCEDURE sp_ListarGrupos
AS 
BEGIN
	SELECT * 
			FROM dbo.Grupo 
			WHERE nombre <> 'admin'
			AND 
				  eliminado = 0
END
/***********************/
CREATE PROCEDURE sp_GrupoConParejas
AS
BEGIN
		SELECT codigo_grupo
			FROM persona
			WHERE es_pareja = 1
			GROUP BY codigo_grupo
			HAVING COUNT(codigo_grupo) = 2
END
/***********************/
ALTER PROCEDURE sp_BuscarGrupo 
		@usuario varchar (15)
AS
BEGIN
	SELECT * 
			FROM dbo.Grupo 
			WHERE nombre = @usuario
			AND 
				  eliminado = 0
END
/***********************/
/*ACA BUSCO GRUPOS SIN PAREJAS O CON UNA PERSONA*/
ALTER PROCEDURE sp_ListarGrupos_SinPareja
AS
BEGIN
	SELECT codigo_grupo,nombre
	FROM grupo
	WHERE codigo_grupo IN(SELECT g.codigo_grupo 
								FROM persona p
								RIGHT JOIN grupo g
								ON (p.codigo_grupo = g.codigo_grupo)
								WHERE g.codigo_grupo IN (SELECT codigo_grupo FROM persona)
								AND p.es_pareja = 1
								OR p.codigo_grupo IS NULL
								AND g.nombre <> 'admin'
								GROUP BY g.codigo_grupo
								HAVING COUNT(g.codigo_grupo)<2)
	AND
		eliminado = 0
END
/***********************/
ALTER PROCEDURE sp_Grupo_No_Formulario
AS
BEGIN
	SELECT * 
		FROM grupo
		WHERE codigo_grupo NOT IN(SELECT codigo_grupo FROM formulario)
		AND nombre <> 'admin'
END
/***********************/

/*PROCEDIMIENTOS DE LA TABLA INFORME*/
ALTER PROCEDURE sp_Agregar_Informe 
			@titulo varchar(20),
			@texto varchar(200),
			@fecha_creacion datetime,
			@tipo varchar (10),
			@codigo_grupo int
AS
BEGIN
	insert into dbo.Informe values(@titulo,@texto,@fecha_creacion,@tipo,@codigo_grupo)
END
/************************/
CREATE PROCEDURE sp_ListarInformes 
AS
BEGIN
	select * from dbo.Informe
END
/************************/
ALTER PROCEDURE sp_Informes_Grupo
			@codigo_grupo int
AS
BEGIN
	SELECT * 
			FROM dbo.Informe
			WHERE tipo = 'de Grupo'
			AND codigo_grupo = @codigo_grupo
END
/************************/
CREATE PROCEDURE sp_Informes_Admin
AS
BEGIN
	SELECT * 
			FROM dbo.Informe
			WHERE tipo = 'de Admin'
END



/*PROCEDIMIENTOS DE LA TABLA FORMULARIO*/
CREATE PROCEDURE sp_Agregar_Formulario 
				@tipo varchar(30),
				@fecha_llenado datetime,				
				@dia_celula varchar(15),
				@direccion varchar(60),
				@es_ofrenda char(1),
				@monto float,
				@mensaje_consideracion varchar (200),
				@codigo_grupo int,
				@id_mensaje int
AS
BEGIN
	insert into dbo.Formulario values(@tipo,@fecha_llenado,@dia_celula,@direccion,@es_ofrenda,@monto,@mensaje_consideracion,@codigo_grupo,@id_mensaje)
END
/***********************/
CREATE PROCEDURE sp_Modificar_Formulario 
				@id_formulario int, 
				@tipo varchar(30),
				@fecha_llenado datetime,
				@dia_celula varchar(15),
				@direccion varchar(60),
				@es_ofrenda char(1),
				@monto float,
				@mensaje_consideracion varchar (200)
AS
BEGIN
	update dbo.Formulario set tipo = @tipo where id_formulario = @id_formulario
	update dbo.Formulario set fecha_llenado = @fecha_llenado  where id_formulario = @id_formulario
	update dbo.Formulario set dia_celula = @dia_celula where id_formulario = @id_formulario
	update dbo.Formulario set direccion = @direccion where id_formulario = @id_formulario
	update dbo.Formulario set es_ofrenda = @es_ofrenda where id_formulario = @id_formulario
	update dbo.Formulario set monto = @monto where id_formulario = @id_formulario
	update dbo.Formulario set mensaje_consideracion = @mensaje_consideracion where id_formulario = @id_formulario
END
/************************/
ALTER PROCEDURE sp_Listar_Formularios
AS
BEGIN
	SELECT * FROM dbo.Formulario
END
/***********************/
CREATE PROCEDURE sp_Formulario_Reciente
				@codigo_grupo int
AS
BEGIN
	SELECT * 
		FROM dbo.Formulario 
		WHERE codigo_grupo = @codigo_grupo order by fecha_llenado desc
END
/***********************/
CREATE PROCEDURE sp_Buscar_Formulario_mensaje
				@codigo_grupo int ,
				@id_mensaje int
AS
BEGIN
	SELECT	
		f.codigo_grupo,
		f.tipo, 
		f.fecha_llenado,
		f.dia_celula,
		f.direccion,
		f.es_ofrenda,
		f.monto,
		f.mensaje_consideracion,
		m.titulo,
		m.versiculos,
		m.texto_mensaje,
		g.nombre

		FROM Formulario f
		JOIN
			 Mensaje_predica m
		ON (m.id_mensaje = f.id_mensaje)
		JOIN 
			 Grupo g
		ON (g.codigo_grupo = f.codigo_grupo)
		WHERE f.codigo_grupo = @codigo_grupo AND f.id_mensaje = @id_mensaje
END
/****************************/
/*con este SP verifico si ya se cargo un formulario por grupo*/
ALTER PROCEDURE sp_Hay_Formulario
				@codigo_grupo int
AS
BEGIN
	SELECT * 
	FROM formulario f
	JOIN
		 mensaje_predica m
	ON  (m.id_mensaje = f.id_mensaje)
	WHERE f.id_mensaje  in(SELECT id_mensaje
								FROM Mensaje_predica
								WHERE fecha_emitido between DATEADD(wk,DATEDIFF(wk,0,GETDATE()),-1) 
								AND DATEADD(wk,DATEDIFF(wk,0,GETDATE()),6))
	AND 
		f.codigo_grupo = @codigo_grupo
END
/****************************/
ALTER PROCEDURE sp_Listar_Formularios_Mensaje_Grupo
AS
BEGIN
	SELECT m.id_mensaje,g.codigo_grupo,m.titulo,g.nombre,f.tipo,f.fecha_llenado,f.dia_celula,f.direccion,f.es_ofrenda,f.monto,f.mensaje_consideracion
	FROM formulario f
	JOIN 
		 mensaje_predica m
	ON (f.id_mensaje = m.id_mensaje)
	JOIN
		 grupo g
	ON (f.codigo_grupo = g.codigo_grupo)
END
/***********************/
/*PROCEDIMIENTOS DE LA TABLA ASISTENCIAS*/
CREATE PROCEDURE sp_Agregar_Asistencia 
				@dni varchar(10),
				@id_mensaje int,
				@asistio int,
				@fecha_creacion datetime
AS
BEGIN
	insert into dbo.asistencias values(@dni,@asistio,@fecha_creacion,@id_mensaje)
END
/***********************/
/*COMO USAR JOIN Y DECLARAR NOMBRE DE TABLA*/
/***********************/
CREATE PROCEDURE sp_Listar_Asistencias 
			@codigo_grupo int
AS
BEGIN
	SELECT p.dni,p.nombre,apellido,asistio,titulo
				FROM dbo.Persona p
				JOIN 
					 dbo.Asistencias a
				ON (p.dni = a.dni)
				JOIN
					 dbo.Grupo g
				ON (g.codigo_grupo = p.codigo_grupo)
				JOIN
					 dbo.Mensaje_predica m
				ON (m.id_mensaje = a.id_mensaje)
				WHERE g.codigo_grupo = @codigo_grupo
END
/***********************//*poner titulo*/


/*PROCEDIMIENTOS DE LA TABLA MENSAJE_PREDICA*/
CREATE PROCEDURE sp_ListarMensajes
AS
BEGIN
	select * from dbo.Mensaje_predica
END
/*******************************************/
/*CON ESTA CONSULTA OBTENGO EL ULTIMO MENSAJE EMITIDO(EN REALIDAD PREGUNTO SI HAY MENSAJE DE LA SEMANA CORRIENTE)*/
ALTER PROCEDURE sp_MensajeReciente
AS
BEGIN
	SELECT * 
		FROM Mensaje_predica
		WHERE fecha_emitido between DATEADD(wk,DATEDIFF(wk,0,GETDATE()),-1) 
		AND DATEADD(wk,DATEDIFF(wk,0,GETDATE()),6)
	
END
/*******************************************/
CREATE PROCEDURE sp_AgregarMensajePredica 
				@titulo varchar(60),
				@versiculos varchar(10),
				@texto_mensaje varchar(300),
				@fecha_emitido datetime
AS
BEGIN
	insert into dbo.Mensaje_predica values (@titulo,@versiculos,@texto_mensaje,@fecha_emitido)
END
/*******************************************/