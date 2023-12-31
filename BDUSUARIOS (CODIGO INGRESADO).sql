Use master

go

Create Database BDUSUARIO_LAB_HULE

Go
----------------------------------------------------------------------------------------------------

Use BDUSUARIO_LAB_HULE


Create Table TBJEFATURA 
(
	IDUSUARIO int Not Null,
	USUARIO VARCHAR (20) NOT NULL,
	NOMBRE varchar (50) Not Null,
	DEPARTAMENTO VARCHAR (100) NOT NULL,
	EXTENSION INT NOT NULL,
	EMAIL VARCHAR (100) NOT NULL,
	CONTRASENA VARCHAR(20) NOT NULL
);

Go

Create Table TBTECNICO
(
	IDUSUARIO int Not Null,
	USUARIO VARCHAR (20) NOT NULL,
	NOMBRE varchar (50) Not Null,
	DEPARTAMENTO VARCHAR (100) NOT NULL,
	EXTENSION INT NOT NULL,
	EMAIL VARCHAR (100) NOT NULL,
	CONTRASENA VARCHAR(20) NOT NULL
);

Go
--------------------------------------------------------------------------------------------------

INSERT INTO TBJEFATURA (IDUSUARIO,USUARIO,NOMBRE,DEPARTAMENTO,EXTENSION,EMAIL,CONTRASENA) VALUES
(101,'ADMIN','PRUEBA','LABORATORIO HULE',111,'PRUEBA@HULE.CO.CR',123456);

Go

INSERT INTO TBTECNICO (IDUSUARIO,USUARIO,NOMBRE,DEPARTAMENTO,EXTENSION,EMAIL,CONTRASENA) VALUES
(101,'TECNIC','PRUEBA','LABORATORIO HULE',111,'PRUEBA@HULE.CO.CR',123456);


--------------------------------------------------------------------------------------------------

CREATE PROCEDURE [dbo].[BUSCAR_JEFATURA]
-- ADD THE PARAMETERS FOR THE STORED PROCEDURE HERE

@USUARIO VARCHAR (20),
@MSJ VARCHAR(100) OUT

AS
	BEGIN
		IF (NOT EXISTS(SELECT * FROM TBJEFATURA WHERE USUARIO=@USUARIO))
			SET @MSJ = 'Usuario incorrecto'
		ELSE
			BEGIN
				SELECT * FROM  TBJEFATURA WHERE USUARIO=@USUARIO
				SET @MSJ = 'Usuario ingresado correctamente'
			END
	END


--------------------------------------------------------------------------------------------------

CREATE PROCEDURE [dbo].[BUSCAR_TECNICO]
-- ADD THE PARAMETERS FOR THE STORED PROCEDURE HERE

@USUARIO VARCHAR (20),
@MSJ VARCHAR(100) OUT

AS
	BEGIN
		IF (NOT EXISTS(SELECT * FROM TBTECNICO WHERE USUARIO=@USUARIO))
			SET @MSJ = 'Usuario incorrecto'
		ELSE
			BEGIN
				SELECT * FROM  TBTECNICO WHERE USUARIO=@USUARIO
				SET @MSJ = 'Usuario ingresado correctamente'
			END
	END

--------------------------------------------------------------------------------------------------

SELECT * FROM TBJEFATURA;
SELECT * FROM TBTECNICO;