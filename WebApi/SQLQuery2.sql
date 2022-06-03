CREATE DATABASE CRUD
GO
USE CRUD
GO

CREATE TABLE Usuario(
	id_usuario varchar(3) primary key NOT NULL,
	nombre varchar(50) NULL,
	apellido varchar(50) NULL,
	 edad integer NULL,
	numero_cuenta integer NULL,
	
)

INSERT INTO Usuario values('001',	'Sebastian',	'Tejada', '23','12345'	),
('002',	'Juan',	'Perez', '20','12346'	),
('003',	'Alba',	'Martinez', '56','12347'	),
('004',	'Luis',	'Albuja', '34','12348'	)



select * from Usuario