CREATE DATABASE SouthernBD
USE SouthernBD
go
CREATE TABLE Persona(
PersonaId INT PRIMARY KEY IDENTITY(1,1),
Nombre varchar(100),
Apellido varchar(100),
Documento varchar(20),
TipoDocumento varchar(20),
Edad int,
Estado char(1)
)
--SELECT * FROM Persona
--delete  FROM Persona
create PROC p_nuevapersona
(
@Nombre VARCHAR(100),
@Apellido VArchar(100),
@Documento varchar(20),
@TipoDocumento varchar(20),
@Edad int,
@Estado char(1)
)
AS
BEGIN

INSERT INTO dbo.Persona( Nombre ,Apellido ,Documento ,TipoDocumento ,Edad ,Estado)
values(@Nombre, @Apellido, @Documento, @TipoDocumento, @Edad,@Estado)

END
GO

create procedure p_buscapersona
@nombre nvarchar(150)
AS
BEGIN

DECLARE @valor CHAR(1),
@texto VARCHAR(100)

SET @valor=SUBSTRING(@nombre,1,1)
SET @texto=SUBSTRING(@nombre,3,150)

IF @valor='0'
BEGIN
 select PersonaId,nombre,Apellido,Documento,TipoDocumento,Edad,CASE WHEN Estado='D' THEN 'Desactivo' ELSE 'Activo' END Estado  from persona where nombre like '%'+ @texto +'%'
 END
 ELSE IF @valor='1'
 BEGIN
 select PersonaId,nombre,Apellido,Documento,TipoDocumento,Edad,CASE WHEN Estado='D' THEN 'Desactivo' ELSE 'Activo' END Estado  from persona where Apellido like '%'+ @texto +'%'	
 END
 ELSE
 BEGIN
 select PersonaId,nombre,Apellido,Documento,TipoDocumento,Edad,CASE WHEN Estado='D' THEN 'Desactivo' ELSE 'Activo' END Estado  from persona where Documento like '%'+ @texto +'%'
 END 
 END 
go

create procedure p_mostrartodopersona
as
select PersonaId,nombre,Apellido,Documento,TipoDocumento,Edad,CASE WHEN Estado='D' THEN 'Desactivo' ELSE 'Activo' END Estado from persona
GO

create procedure p_persona
as
select PersonaId,nombre + ' ' + Apellido from persona
GO

create procedure p_modificarpersona
@PersonaId INT,
@Nombre VARCHAR(100),
@Apellido VArchar(100),
@Documento varchar(20),
@TipoDocumento varchar(20),
@Edad int,
@Estado char(1)
as
update Persona set nombre=@nombre,Apellido=@apellido,Documento=@Documento
where PersonaId=@PersonaId
GO

create procedure p_eliminarpersona
@IdPersona nvarchar(150)
AS
BEGIN
DELETE	dbo.Persona WHERE PersonaId=@IdPersona
END

create procedure p_buscadocumento
@documento nvarchar(150)
AS
BEGIN
 select PersonaId,nombre,Apellido,Documento,TipoDocumento,Edad,CASE WHEN Estado='D' THEN 'Desactivo' ELSE 'Activo' END Estado  from persona where Documento like '%'+ @documento +'%'
 END 

GO
