USE disenio_tp
GO

CREATE SCHEMA TP_DISENIO;
GO	

-------------------------------------------
--Drop de Tablas creadas
-------------------------------------------
DROP TABLE TP_DISENIO.Inscripciones
GO
DROP TABLE TP_DISENIO.Criticas
GO
DROP TABLE TP_DISENIO.Infracciones
GO
DROP TABLE TP_DISENIO.Jugadores
GO
DROP TABLE TP_DISENIO.Partidos
GO
DROP TABLE TP_DISENIO.Tipo_Inscripciones
GO
-------------------------------------------
--Fin de Drop Tablas creadas
-------------------------------------------


CREATE TABLE TP_DISENIO.Jugadores
(
	[id_user] [varchar](10),
	[pass] [varchar](10),
	[nombre][varchar](20),
	[apellido][varchar](20),
	[fecha_nac][datetime],
	[activo][bit],
CONSTRAINT PK_Jugadores PRIMARY KEY (id_user)
);
GO

CREATE TABLE TP_DISENIO.Partidos
(
	[fecha_hora_partido] [datetime],
	[nombre_partido] [varchar](10),
	[activo][bit],
CONSTRAINT PK_Partido PRIMARY KEY (fecha_hora_partido)
);
GO

CREATE TABLE TP_DISENIO.Criticas
(
	[id_critica] [int] IDENTITY(1,1),
	[puntuacion] [int],
	[fecha_hora_partido][datetime],
	[id_user][varchar](10),
	[critica][varchar](255)
CONSTRAINT PK_Critica PRIMARY KEY (id_critica)
CONSTRAINT FK_Critica_id_partido FOREIGN KEY (fecha_hora_partido) REFERENCES TP_DISENIO.Partidos(fecha_hora_partido),
CONSTRAINT FK_Critica_id_user FOREIGN KEY (id_user) REFERENCES TP_DISENIO.Jugadores (id_user)
);
GO

CREATE TABLE TP_DISENIO.Infracciones
(
	[id_infraccion] [int]IDENTITY(1,1),
	[fecha_infraccion] [datetime],
	[motivo][varchar](255),
	[id_user][varchar](10),
	[fecha_hora_partido][datetime],
CONSTRAINT PK_Infraccion PRIMARY KEY (id_infraccion),
CONSTRAINT FK_Infraccion_id_user FOREIGN KEY (id_user) REFERENCES TP_DISENIO.Jugadores (id_user),
CONSTRAINT FK_Infraccion_id_partido FOREIGN KEY (fecha_hora_partido) REFERENCES TP_DISENIO.Partidos(fecha_hora_partido)
);
GO


CREATE TABLE TP_DISENIO.Inscripciones
(
	[id_inscripcion][int] IDENTITY (1,1),
	[id_user][varchar](10),
	[fecha_hora_partido][datetime],
	[cod_inscripcion][int],
	[activo][bit]
CONSTRAINT PK_Inscripcion PRIMARY KEY (id_inscripcion),
CONSTRAINT FK_Inscripcion_id_user FOREIGN KEY (id_user) REFERENCES TP_DISENIO.Jugadores (id_user),
CONSTRAINT FK_Inscripcion_id_partido FOREIGN KEY (fecha_hora_partido) REFERENCES TP_DISENIO.Partidos(fecha_hora_partido)
);
GO

CREATE TABLE TP_DISENIO.Tipo_Inscripciones
(
	[cod_inscripcion][int],
	[nombre][varchar](15),
	[descripcion][varchar](255)
CONSTRAINT PK_Tipo_Inscripciones PRIMARY KEY (cod_inscripcion)
);
GO
						/*Fin de Creación de Tablas*/
						
						
						/*Inicio de Relleno de Tablas*/
INSERT INTO TP_DISENIO.Tipo_Inscripciones(cod_inscripcion,nombre,descripcion)VALUES (1,'Estandar','Inscripción definitiva')
GO
INSERT INTO TP_DISENIO.Tipo_Inscripciones(cod_inscripcion,nombre,descripcion)VALUES (2,'Solidario','Juego si no hay otro')
GO
INSERT INTO TP_DISENIO.Tipo_Inscripciones(cod_inscripcion,nombre,descripcion)VALUES (3,'Condicional','Juego si...')
GO



INSERT INTO TP_DISENIO.Jugadores(id_user,nombre,apellido,pass,fecha_nac,activo) VALUES ('admin','admin','admin','admin','10/11/1992 07:00:00',1)
GO

						/*Fin de Relleno de Tablas*/







-------------------------------------------
--Drop de Procedures creados
-------------------------------------------
DROP PROCEDURE TP_DISENIO.alta
GO
DROP PROCEDURE TP_DISENIO.verificarUsuario
GO
DROP PROCEDURE TP_DISENIO.bajarPartido
GO
DROP PROCEDURE TP_DISENIO.selectInscripciones
GO
DROP PROCEDURE TP_DISENIO.selectJugadores
GO
-------------------------------------------
--Fin de Drop de Tablas creadas
-------------------------------------------




			/*Inicio de Stored Procedure*/

-----------------------------------
--SP Verificar Usuario y Contraseña
--Output:
--1: No existe el usuario
--2: Contraseña incorrecta
--3: Login exitoso
-----------------------------------
CREATE PROCEDURE TP_DISENIO.verificarUsuario
(@id_user varchar (10),@pass varchar(10),@retorno int output)
AS
IF NOT EXISTS (SELECT * FROM TP_DISENIO.Jugadores WHERE id_user=@id_user AND activo=1)
	BEGIN 
		SET @retorno=1
	END
ELSE
	BEGIN
		IF EXISTS (SELECT * FROM TP_DISENIO.Jugadores WHERE id_user=@id_user AND pass=@pass AND activo=1)
			BEGIN 
				SET @retorno=2
			END
		ELSE 
			BEGIN
				SET @retorno=3
			END 
		
	END
GO
--Fin SP Verificar Usuario y Contraseña


--------------------------------------
--SP Dar de alta un Jugador al sistema
--OUTPUT: 
--1: Alta exitosa
--2: El nombre de usuario ya existe
--------------------------------------
CREATE PROCEDURE TP_DISENIO.alta
(@nombre varchar(20),@apellido varchar(20),@fecha_nac varchar(20),@id_user varchar(10),@pass varchar(10),@retorno int output)
AS
IF EXISTS(SELECT * FROM TP_DISENIO.Jugadores WHERE id_user=@id_user AND activo=1)--Verifica si es usuario existe
	BEGIN 
		SET @retorno=2
	END
ELSE
	BEGIN
		INSERT INTO TP_DISENIO.Jugadores (id_user,pass,nombre,apellido,fecha_nac)VALUES (@id_user,@pass,@nombre,@apellido,@fecha_nac)
		SET @retorno=1
	END

GO
--Fin de SP Dar de alta un Jugador al sistema


--SP Darse de baja de un Partido

--------------------------------------
--Realiza la baja lógica de un partido
--------------------------------------
CREATE PROCEDURE TP_DISENIO.bajarPartido
(@id_inscripcion varchar(10))
AS
UPDATE TP_DISENIO.Inscripciones 
SET activo=0
WHERE id_inscripcion=@id_inscripcion
GO
-------------------------------------
--Fin de SP de baja de un Partido
-------------------------------------


---------------------------------------
--SP TRAE TODAS LAS INSCRIPCIONES
---------------------------------------
CREATE PROCEDURE TP_DISENIO.selectInscripciones
(@id_user varchar(10))
AS
SELECT I.id_user as Usuario,I.fecha_hora_partido as Fecha_Partido,P.nombre_partido as Nombre_Partido
FROM TP_DISENIO.Inscripciones as I
JOIN TP_DISENIO.Partidos as P ON P.fecha_hora_partido=I.fecha_hora_partido
WHERE id_user=@id_user
GO
----------------------------------------
--Fin de SP trae todas las Inscripciones
----------------------------------------

----------------------------------------
--SP da de baja 




----------------------------------------
--SP Trae todos los jugadores 
--Trae todos los jugadores que están
--activos pero que no están incriptos
--en el partido.
----------------------------------------

CREATE PROCEDURE TP_DISENIO.selectJugadores
(@fecha_hora_partido datetime)
AS
SELECT J.id_user as Usuario, J.nombre as Nombre, J.apellido as Apellido
FROM TP_DISENIO.Jugadores as J
JOIN TP_DISENIO.Inscripciones as I ON J.id_user=I.id_user
WHERE J.activo=1 AND I.fecha_hora_partido<>@fecha_hora_partido
GO
----------------------------------------
--Fin de SP trae todas los jugadores
----------------------------------------






































































/*Da de alta un Partido*/
CREATE PROCEDURE TP_DISENIO.altaPartido
(@tiempoYHora datetime,@nombre varchar (20))
AS
INSERT INTO TP_DISENIO.Partidos
(id_partido,fecha_hora,activo) VALUES (@tiempoYHora,@nombre,1)
GO

/*Me devuelve todos los registros de un Jugador dado el id_user*/
CREATE PROCEDURE TP_DISENIO.buscarJugador
(@id_user varchar(10))
AS
SELECT *
FROM TP_DISENIO.Jugadores
WHERE id_user=@id_user AND activo=1
GO

/*Verifica si el usuario existe, devuelve 1 en caso de éxito y 0 en caso de fallo*/
CREATE PROCEDURE TP_DISENIO.verificarUsuario
(@id_user varchar(10))
AS 
	IF EXISTS (SELECT * FROM TP_DISENIO.Jugadores WHERE id_user=@id_user)
		BEGIN
			RETURN 1		
		END
	ELSE
		BEGIN
			RETURN 0
		END
GO
/*Verifica la contraseña de un usuario, retorna 1 en caso de éxito, 0 en caso de fallo*/
CREATE PROCEDURE TP_DISENIO.verificarUserYPass
(@id_user varchar(10),@pass varchar(10))
AS
IF EXISTS (SELECT * FROM TP_DISENIO.Jugadores WHERE id_user=@id_user AND pass=@pass)
	BEGIN
		RETURN 1
	END 
ELSE
	BEGIN
		RETURN 0
	END
GO

CREATE PROCEDURE TP_DISENIO.buscarPartido
(@id_partido varchar(10))
AS
	SELECT * 
	FROM TP_DISENIO.Partidos
	WHERE id_partido=@id_partido AND activo=1
GO





























/*Devuelve la cantidad de Partidos Activos*/
CREATE PROCEDURE TP_DISENIO.cantidadPartidos
AS
	SELECT COUNT(*) as cantidad
	FROM TP_DISENIO.Partidos
	WHERE activo=1
GO
/*Nota: Un partido está activo cuando no ha sido jugado todavía*/


/*Trae todas los Jugadores dado un Partido determinado*/
CREATE PROCEDURE TP_DISENIO.jugadoresPorPartido
(@id_partido varchar (10))
AS
	SELECT *
	FROM TP_DISENIO.Inscripciones as I
	JOIN TP_DISENIO.Jugadores as J ON I.id_user=J.id_user
	WHERE I.id_partido=@id_partido AND J.activo=1
GO

/*Verifica si hay jugadores dados de alta para cargarlos o no*/
CREATE PROCEDURE TP_DISENIO.hayJugadoresDadosDeAlta
AS
	IF EXISTS (SELECT * FROM TP_DISENIO.Jugadores)
		BEGIN
			RETURN 1
		END
	ELSE
		BEGIN 
			RETURN 0
		END
GO
/*Busca todos los Jugadores activos*/
CREATE PROCEDURE TP_DISENIO.Jugadores
AS
	SELECT nombre, apellido,id_user
	FROM TP_DISENIO.Jugadores
	WHERE activo=1
GO
/*Ver si solamente dejar el id_user*/

CREATE PROCEDURE TP_DISENIO.todosLosJugadoresMenosElLogueado
(@id_user varchar(10))
AS
	SELECT nombre,apellido,id_user
	FROM TP_DISENIO.Jugadores
	WHERE id_user!=@id_user
GO


CREATE PROCEDURE TP_DISENIO.altaJugador
(@nombre varchar(20),@apellido varchar(20),@fecha_nacimiento datetime,@pass varchar(10),@id_user varchar(10))
AS 
INSERT
INTO TP_DISENIO.Jugadores
(nombre,apellido,fecha_nac,pass,id_user,activo) VALUES(@nombre,@apellido,@fecha_nacimiento,@pass,@id_user,1)
GO


/*Ver que un jugador se pueda inscribir a un partido una sola vez*/
CREATE PROCEDURE TP_DISENIO.bajaDeUnPartido
(@id_partido varchar(10),@id_user varchar(10))
AS
	UPDATE TP_DISENIO.Inscripciones
	SET act
	WHERE id_partido=@id_partido AND id_user=@id_user
	

GO































/*Procedures de ejemplo*/
BEGIN
--OBJETIVO: LOGRAR EL LOGIN DE USUARIO, TAMBIEN DESHABILITARLO SI ES ERRONEO (NO CONSIDERA COMO LOGIN A LA FUNCIONALIDAD
--PARAMETROS: SE INGRESA EL USUARIO, LA PASSWORD, Y EL CODIGO DE ROL, Y RETORNA EL EXITO DE LA PROC 
--PUBL_ESTADO = 0 LOGIN CORRECTO
--PUBL_ESTADO = 1 INGRESO MAL LA CLAVE
--PUBL_ESTADO = 2 USUARIO NO CORRESPONDE A ESE ROL
--PUBL_ESTADO = 3 USUARIO INHABILITADO, CONTACTAR ADMINISTRADOR
--PUBL_ESTADO = 4 USUARIO INHABILITADO POR INGRESAR 3 VECES MAL LA PASSWORD
--PUBL_ESTADO = 5 USUARIO DEBE CAMBIAR LA PASSWORD
DECLARE @CONTADORUSU INT;
declare @contadorrol smallint;
DECLARE @cantidad_f int;
declare @estado char(1);
SET @CONTADORUSU = 0;
SET @cantidad_f = 0;
SELECT @estado = US_ESTADO FROM USUARIO where @auxnombre = US_nombre;
--VERIFICA QUE EL USUARIO ESTE HABILITADO
if (@estado =0)
BEGIN
 SELECT @CONTADORUSU = COUNT(*) FROM USUARIO where @auxnombre = US_nombre and @auxpass = US_clave ;
-- VERIFICA EL MATCH DEL USUARIO Y EL PASSWORD 
      if (@CONTADORUSU = 0)
       begin
--NO ACERTÓ LA PASSWORD
        SELECT @cantidad_f = US_INTENTOSFALLIDOS FROM USUARIO WHERE @auxnombre = US_nombre;
        if (@cantidad_f = 2)
         begin
--NO TIENE MAS OPORTUNIDADES (SE BLOQUEA Y SE CUENTA 3)
 UPDATE USUARIO SET US_INTENTOSFALLIDOS = 3, US_ESTADO = 1 WHERE @auxnombre = US_nombre;
          set @retorno = 4;
         end
        ELSE
         BEGIN
--ACUMULA UN ERROR FALLIDO
          UPDATE USUARIO set US_INTENTOSFALLIDOS = (@cantidad_f + 1) WHERE @auxnombre = US_nombre;
          set @retorno = 1;
         END
       end
      else
       BEGIN
--ACERTÓ. VERIFICA EL ROL
        select @contadorrol = count(*) from USUARIO_ROL where USROL_USUARIO = @auxnombre and USROL_ROL = @idrol;
        if (@contadorrol = 1)
          begin
  UPDATE USUARIO SET US_INTENTOSFALLIDOS = 0 WHERE @auxnombre = US_nombre;
      IF (SELECT US_PRIMERA_VEZ FROM USUARIO WHERE @auxnombre = US_nombre) = 'N'
       BEGIN
        set @retorno = 0; 
       END
      ELSE
       BEGIN
        set @retorno = 5;
       END
          END
        else
         BEGIN
-- NO SE PUDO REHABILITAR EL LOGIN
          set @retorno = 2;
         END 
       END
       END
    ELSE
     BEGIN
-- USUARIO DESHABILITADO
      SET @retorno = 3;
     END
END
GO

/*Fin de procedures de ejemplo*/