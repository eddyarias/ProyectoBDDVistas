-----Extraer los datos de la base de datos centralizada en postgres01l a las tablas del NODO Quito --------
-----TALLER--------------------

INSERT INTO
[TallerReparacionQ].dbo.TALLER_01(ID_TALLER,ID_DIRECTOR,NOM_TALLER,LOCALIDAD_TALLER)
SELECT *
FROM [TallerReparacionV2].TallerReparacionVersion2.[public].taller
WHERE ID_TALLER='TALL001';
select * from TALLER_01
--------------- CLIENTE-----------------------------------------
INSERT INTO [TallerReparacionQ].dbo.CLIENTE_01
(NOMBRE_CLIENTE,APELLIDO_CLIENTE,ID_TALLER,NUMCEDULA_CLIENTE,DIRECCION_CLIENTE)
SELECT *
FROM [TallerReparacionV2].TallerReparacionVersion2.[public].cliente
WHERE ID_TALLER='TALL001';
select * from CLIENTE_01
---------------------EMPLEADO--------------------------------
INSERT INTO [TallerReparacionQ].dbo.EMPLEADO_01
(ID_EMPLEADO,ID_TALLER,NUMCED_EMPLEADO,NOMBRE_EMPLEADO,APELLIDO_EMPLEADO,SALARIO_EMPLEADO,FECHAINICIOCONTRATO_EMPLEADO)
SELECT *
FROM [TallerReparacionV2].TallerReparacionVersion2.[public].empleado
WHERE ID_TALLER='TALL001';
select * from EMPLEADO_01
-----------------numero_telefono---------
INSERT INTO [TallerReparacionQ].dbo.NUMEROTELEFONO_01 (NUMEROTELEFONO,ID_EMPLEADO, ID_TALLER)
SELECT n.NUMEROTELEFONO, n.ID_EMPLEADO, 'TALL001'
FROM [TallerReparacionV2].TallerReparacionVersion2.[public].numerotelefono n
WHERE n.ID_EMPLEADO IN (
 SELECT e.ID_EMPLEADO
 FROM [TallerReparacionV2].TallerReparacionVersion2.[public].empleado e
 WHERE e.ID_TALLER = 'TALL001');
select * from [TallerReparacionV2].TallerReparacionVersion2.[public].empleado
where id_taller='TALL001';
select * from NUMEROTELEFONO_01
-----------------INFO CLIENTE----------------
INSERT INTO
[TallerReparacionQ].dbo.INFO_CLIENTE(NOMBRE_CLIENTE,APELLIDO_CLIENTE)
SELECT nombre_cliente,apellido_cliente
FROM [TallerReparacionV2].TallerReparacionVersion2.[public].cliente
select * from [TallerReparacionV2].TallerReparacionVersion2.[public].vehiculo
select * from INFO_CLIENTE
------------VEHICULO------------------
INSERT INTO
[TallerReparacionQ].dbo.VEHICULO_01(NUMMATRICULA_VEHICULO,ID_TALLER,NOMBRE_CLIENTE,APELLIDO_CLIENTE,FECHACOMPRA_VEHICULO)
SELECT *
FROM [TallerReparacionV2].TallerReparacionVersion2.[public].vehiculo
WHERE ID_TALLER='TALL001';

select * from VEHICULO_01
-------------------PLACAVEHICULO---------------------
INSERT INTO [TallerReparacionQ].dbo.PLACA_VEHICULO(NUMMATRICULA_VEHICULO)
SELECT nummatricula_vehiculo
FROM [TallerReparacionV2].TallerReparacionVersion2.[public].vehiculo
select * from PLACA_VEHICULO
---------------------REPARACION------------------------------
INSERT INTO [TallerReparacionQ].dbo.REPARACION_01(NUMMATRICULA_VEHICULO,ID_REPARACION, TIPO_REPARACION, FECHA_REPARACION, OBSERVACIONES_REPARACION,PRECIO_REPARACION, ID_TALLER)
SELECT r.NUMMATRICULA_VEHICULO, r.ID_REPARACION, r.TIPO_REPARACION,
r.FECHA_REPARACION, r.OBSERVACIONES_REPARACION, r.PRECIO_REPARACION, 'TALL001'
FROM [TallerReparacionV2].TallerReparacionVersion2.[public].reparacion r
WHERE r.nummatricula_vehiculo IN (
 SELECT v.nummatricula_vehiculo
 FROM [TallerReparacionV2].TallerReparacionVersion2.[public].vehiculo v
 WHERE v.ID_TALLER = 'TALL001'
);
select * from REPARACION_01
-----------------------FACTURA---------------------
INSERT INTO [TallerReparacionQ].dbo.FACTURA_01(NUMMATRICULA_VEHICULO,ID_REPARACION, ID_FACTURA, FECHAEMISION_FACTURA, SUBTOTAL_FACTURA, IVA_FACTURA,TOTAL_FACTURA, ID_TALLER)
SELECT f.NUMMATRICULA_VEHICULO, f.ID_REPARACION, f.ID_FACTURA,
f.FECHAEMISION_FACTURA, f.SUBTOTAL_FACTURA, f.IVA_FACTURA,
f.TOTAL_FACTURA,'TALL001'
FROM [TallerReparacionV2].TallerReparacionVersion2.[public].factura f
WHERE f.NUMMATRICULA_VEHICULO IN (
 SELECT v.nummatricula_vehiculo
 FROM [TallerReparacionV2].TallerReparacionVersion2.[public].vehiculo v
 WHERE v.ID_TALLER = 'TALL001'
);
select * from FACTURA_01
---------------------ASIGNAR DIRECTOR--------------------
--Se necesita colocar un director en cada taller, en este cado para quito será
el empleado cuyo codigo es EMP001
UPDATE TALLER_01 SET ID_DIRECTOR = 'EMP001' WHERE ID_TALLER = 'TALL001';

exec sp_addlinkedserver
@server='LAPTOP-VF0SV152'
go
exec sp_addlinkedserver
@server='LAPTOP-MQ2NT5FG\MSSQLSERVERI'

go
--1.
---QUEREMOS SABER LA INFORMACION DE LOS VEHICULOS QUE FUERON AL REALIZAR UNA
REPARACION EN LA FECHA 2023-03-21
SELECT
 R.NUMMATRICULA_VEHICULO COLLATE Modern_Spanish_CI_AS AS NumMatriculaVehiculo,
 R.ID_REPARACION COLLATE Modern_Spanish_CI_AS AS IdReparacion,
 R.ID_TALLER COLLATE Modern_Spanish_CI_AS AS IdTaller,
 R.TIPO_REPARACION COLLATE Modern_Spanish_CI_AS AS TipoReparacion,
 R.FECHA_REPARACION AS FechaReparacion,
 R.OBSERVACIONES_REPARACION COLLATE Modern_Spanish_CI_AS AS ObservacionesReparacion,
 R.PRECIO_REPARACION AS PrecioReparacion
FROM [LAPTOP-MQ2NT5FG\MSSQLSERVERI].[TallerReparacionQ].[dbo].[REPARACION_01]
AS R
WHERE R.FECHA_REPARACION = '2023-03-21'
UNION
SELECT
 Q.NUMMATRICULA_VEHICULO COLLATE Modern_Spanish_CI_AS AS NumMatriculaVehiculo,
 Q.ID_REPARACION COLLATE Modern_Spanish_CI_AS AS IdReparacion,
 Q.ID_TALLER COLLATE Modern_Spanish_CI_AS AS IdTaller,
 Q.TIPO_REPARACION COLLATE Modern_Spanish_CI_AS AS TipoReparacion,
 Q.FECHA_REPARACION AS FechaReparacion,
 Q.OBSERVACIONES_REPARACION COLLATE Modern_Spanish_CI_AS AS ObservacionesReparacion,
 Q.PRECIO_REPARACION AS PrecioReparacion
FROM [LAPTOP-VF0SV152].[TallerReparacionG].[dbo].[REPARACION_02] AS Q
WHERE Q.FECHA_REPARACION = '2023-03-21'
go
--2.
--Comparación de Salarios de Empleados
--Objetivo: Comparar los salarios de los empleados entre
--los talleres de las bases de datos TallerReparacionQ y TallerReparacionG.
SELECT
 E.ID_EMPLEADO COLLATE Modern_Spanish_CI_AS AS IdEmpleado,
 E.NOMBRE_EMPLEADO COLLATE Modern_Spanish_CI_AS AS NombreEmpleado,
 E.APELLIDO_EMPLEADO COLLATE Modern_Spanish_CI_AS AS ApellidoEmpleado,
 E.SALARIO_EMPLEADO AS SalarioEmpleado,
 E.ID_TALLER COLLATE Modern_Spanish_CI_AS AS IdTaller,
 'TallerReparacionQ' AS Fuente
FROM [LAPTOP-MQ2NT5FG\MSSQLSERVERI].[TallerReparacionQ].[dbo].[EMPLEADO_01] AS
E
UNION ALL
SELECT
 G.ID_EMPLEADO COLLATE Modern_Spanish_CI_AS AS IdEmpleado,
 G.NOMBRE_EMPLEADO COLLATE Modern_Spanish_CI_AS AS NombreEmpleado,
 G.APELLIDO_EMPLEADO COLLATE Modern_Spanish_CI_AS AS ApellidoEmpleado,
 G.SALARIO_EMPLEADO AS SalarioEmpleado,
 G.ID_TALLER COLLATE Modern_Spanish_CI_AS AS IdTaller,
 'TallerReparacionG' AS Fuente
FROM [LAPTOP-VF0SV152].[TallerReparacionG].[dbo].[EMPLEADO_02] AS G
ORDER BY SALARIO_EMPLEADO DESC;
go
--3.
--Clientes y sus Vehículos en Ambas Bases de Datos
--Objetivo: Obtener una lista de clientes y los
-- detalles de sus vehículos registrados en ambos talleres.
SELECT
 C.NOMBRE_CLIENTE COLLATE Modern_Spanish_CI_AS AS NombreCliente,
 C.APELLIDO_CLIENTE COLLATE Modern_Spanish_CI_AS AS ApellidoCliente,
 V.NUMMATRICULA_VEHICULO COLLATE Modern_Spanish_CI_AS AS NumMatriculaVehiculo,
 V.FECHACOMPRA_VEHICULO AS FechaCompraVehiculo,
 C.ID_TALLER COLLATE Modern_Spanish_CI_AS AS IdTaller,
 'TallerReparacionQ' AS Fuente
FROM [LAPTOP-MQ2NT5FG\MSSQLSERVERI].[TallerReparacionQ].[dbo].[CLIENTE_01] AS C
JOIN [LAPTOP-MQ2NT5FG\MSSQLSERVERI].[TallerReparacionQ].[dbo].[VEHICULO_01] AS
V ON C.NOMBRE_CLIENTE = V.NOMBRE_CLIENTE AND C.APELLIDO_CLIENTE =
V.APELLIDO_CLIENTE
UNION
SELECT
 C.NOMBRE_CLIENTE COLLATE Modern_Spanish_CI_AS AS NombreCliente,
 C.APELLIDO_CLIENTE COLLATE Modern_Spanish_CI_AS AS ApellidoCliente,
 V.NUMMATRICULA_VEHICULO COLLATE Modern_Spanish_CI_AS AS NumMatriculaVehiculo,
 V.FECHACOMPRA_VEHICULO AS FechaCompraVehiculo,
 C.ID_TALLER COLLATE Modern_Spanish_CI_AS AS IdTaller,
 'TallerReparacionG' AS Fuente
FROM [LAPTOP-VF0SV152].[TallerReparacionG].[dbo].[CLIENTE_02] AS C
JOIN [LAPTOP-VF0SV152].[TallerReparacionG].[dbo].[VEHICULO_02] AS V ON
C.NOMBRE_CLIENTE = V.NOMBRE_CLIENTE AND C.APELLIDO_CLIENTE =
V.APELLIDO_CLIENTE;
go
--4.
--Números de Teléfono de Empleados por Taller
--Objetivo: Listar todos los números de teléfono
-- de los empleados en ambos talleres.
SELECT
 M.ID_EMPLEADO COLLATE Modern_Spanish_CI_AS AS IdEmpleado,
 M.NUMEROTELEFONO COLLATE Modern_Spanish_CI_AS AS NumeroTelefono,
 M.ID_TALLER COLLATE Modern_Spanish_CI_AS AS IdTaller,
 'TallerReparacionQ' AS Fuente
FROM [LAPTOPMQ2NT5FG\MSSQLSERVERI].[TallerReparacionQ].[dbo].[NUMEROTELEFONO_01] AS M
UNION ALL
SELECT
 N.ID_EMPLEADO COLLATE Modern_Spanish_CI_AS AS IdEmpleado,
 N.NUMEROTELEFONO COLLATE Modern_Spanish_CI_AS AS NumeroTelefono,
 N.ID_TALLER COLLATE Modern_Spanish_CI_AS AS IdTaller,
 'TallerReparacionG' AS Fuente
FROM [LAPTOP-VF0SV152].[TallerReparacionG].[dbo].[NUMEROTELEFONO_02] AS N;
go

--5.
--Reparaciones y Empleados Involucrados
--Objetivo: Listar las reparaciones realizadas en ambos
--talleres con detalles de la reparación y los empleados
-- involucrados, adecuado para entornos con configuraciones de intercalación
diferentes.
SELECT
 R.ID_REPARACION COLLATE Modern_Spanish_CI_AS AS IdReparacion,
 R.TIPO_REPARACION COLLATE Modern_Spanish_CI_AS AS TipoReparacion,
 R.FECHA_REPARACION AS FechaReparacion,
 E.ID_EMPLEADO COLLATE Modern_Spanish_CI_AS AS IdEmpleado,
 E.NOMBRE_EMPLEADO COLLATE Modern_Spanish_CI_AS AS NombreEmpleado,
 E.APELLIDO_EMPLEADO COLLATE Modern_Spanish_CI_AS AS ApellidoEmpleado,
E.ID_TALLER COLLATE Modern_Spanish_CI_AS, 'TallerReparacionQ' AS Fuente
FROM [LAPTOP-MQ2NT5FG\MSSQLSERVERI].[TallerReparacionQ].[dbo].[REPARACION_01]
AS R
JOIN [LAPTOP-MQ2NT5FG\MSSQLSERVERI].[TallerReparacionQ].[dbo].[EMPLEADO_01] AS
E ON R.ID_TALLER = E.ID_TALLER
UNION ALL
SELECT
 R.ID_REPARACION COLLATE Modern_Spanish_CI_AS AS IdReparacion,
 R.TIPO_REPARACION COLLATE Modern_Spanish_CI_AS AS TipoReparacion,
 R.FECHA_REPARACION AS FechaReparacion,
 E.ID_EMPLEADO COLLATE Modern_Spanish_CI_AS AS IdEmpleado,
 E.NOMBRE_EMPLEADO COLLATE Modern_Spanish_CI_AS AS NombreEmpleado,
 E.APELLIDO_EMPLEADO COLLATE Modern_Spanish_CI_AS AS ApellidoEmpleado,
E.ID_TALLER COLLATE Modern_Spanish_CI_AS,
 'TallerReparacionG' AS Fuente
FROM [LAPTOP-VF0SV152].[TallerReparacionG].[dbo].[REPARACION_02] AS R
JOIN [LAPTOP-VF0SV152].[TallerReparacionG].[dbo].[EMPLEADO_02] AS E ON
R.ID_TALLER = E.ID_TALLER;
