-----Extraer los datos de la base de datos centralizada en postgres02l  a las tablas del NODO 02uito  --------

-----TALLER--------------------
INSERT INTO [TallerReparacionG].dbo.TALLER_02(ID_TALLER,ID_DIRECTOR,NOM_TALLER,LOCALIDAD_TALLER)

SELECT *

FROM [TallerReparacion].TallerReparacionVersion2.[public].taller

WHERE ID_TALLER='TALL002';

select * from TALLER_02

---------------	CLIENTE-----------------------------------------

INSERT INTO [TallerReparacionG].dbo.CLIENTE_02 (NOMBRE_CLIENTE,APELLIDO_CLIENTE,ID_TALLER,NUMCEDULA_CLIENTE,DIRECCION_CLIENTE)

SELECT *

FROM [TallerReparacion].TallerReparacionVersion2.[public].cliente

WHERE ID_TALLER='TALL002';

select * from CLIENTE_02

---------------------EMPLEADO--------------------------------

INSERT INTO [TallerReparacionG].dbo.EMPLEADO_02 (ID_EMPLEADO,ID_TALLER,NUMCED_EMPLEADO,NOMBRE_EMPLEADO,APELLIDO_EMPLEADO,SALARIO_EMPLEADO,FECHAINICIOCONTRATO_EMPLEADO)

SELECT *

FROM [TallerReparacion].TallerReparacionVersion2.[public].empleado

WHERE ID_TALLER='TALL002';

select * from EMPLEADO_02

-----------------numero_telefono---------
INSERT INTO [TallerReparacionG].dbo.NUMEROTELEFONO_02 (NUMEROTELEFONO, ID_EMPLEADO, ID_TALLER)

SELECT n.NUMEROTELEFONO, n.ID_EMPLEADO, 'TALL002'

FROM [TallerReparacion].TallerReparacionVersion2.[public].numerotelefono n

WHERE n.ID_EMPLEADO IN (

    SELECT e.ID_EMPLEADO 

    FROM [TallerReparacion].TallerReparacionVersion2.[public].empleado e 

    WHERE e.ID_TALLER = 'TALL002');

select * from NUMEROTELEFONO_02

------------VEHICULO------------------
INSERT INTO [TallerReparacionG].dbo.VEHICULO_02(NUMMATRICULA_VEHICULO,ID_TALLER,NOMBRE_CLIENTE,APELLIDO_CLIENTE,FECHACOMPRA_VEHICULO)

SELECT *

FROM [TallerReparacion].TallerReparacionVersion2.[public].vehiculo

WHERE ID_TALLER='TALL002';

select * from VEHICULO_02
---------------------REPARACION------------------------------
INSERT INTO [TallerReparacionG].dbo.REPARACION_02(NUMMATRICULA_VEHICULO, ID_REPARACION, TIPO_REPARACION, FECHA_REPARACION, OBSERVACIONES_REPARACION, PRECIO_REPARACION, ID_TALLER)

SELECT r.NUMMATRICULA_VEHICULO, r.ID_REPARACION, r.TIPO_REPARACION, r.FECHA_REPARACION, r.OBSERVACIONES_REPARACION, r.PRECIO_REPARACION, 'TALL002'

FROM [TallerReparacion].TallerReparacionVersion2.[public].reparacion r

WHERE r.nummatricula_vehiculo IN (

    SELECT v.nummatricula_vehiculo 

    FROM [TallerReparacion].TallerReparacionVersion2.[public].vehiculo v 

    WHERE v.ID_TALLER = 'TALL002'
);

select * from REPARACION_02

-----------------------FACTURA---------------------

INSERT INTO [TallerReparacionG].dbo.FACTURA_02(NUMMATRICULA_VEHICULO, ID_REPARACION, ID_FACTURA, FECHAEMISION_FACTURA, SUBTOTAL_FACTURA, IVA_FACTURA, TOTAL_FACTURA, ID_TALLER)

SELECT f.NUMMATRICULA_VEHICULO, f.ID_REPARACION, f.ID_FACTURA, f.FECHAEMISION_FACTURA, f.SUBTOTAL_FACTURA, f.IVA_FACTURA, f.TOTAL_FACTURA,'TALL002'

FROM [TallerReparacion].TallerReparacionVersion2.[public].factura f

WHERE f.NUMMATRICULA_VEHICULO IN (

    SELECT v.nummatricula_vehiculo 

    FROM [TallerReparacion].TallerReparacionVersion2.[public].vehiculo v 

    WHERE v.ID_TALLER = 'TALL002'

);
select * from FACTURA_02
------------------------------------



select * from PLACA_VEHICULO
select * from VEHICULO_02
select * from CLIENTE_02
select * from REPARACION_02

















select * from [TallerReparacionVersion2].TallerReparacionVersion2.[public].vehiculo

UPDATE TALLER_02 SET ID_DIRECTOR = 'EMP002' WHERE ID_TALLER = 'TALL002';


insert into VEHICULO (NUMMATRICULA_VEHICULO,ID_TALLER,NOMBRE_CLIENTE,APELLIDO_CLIENTE,FECHACOMPRA_VEHICULO) values ('VEH008    ','TALL002','Elena','Castro',GETDATE())

DELETE FROM VEHICULO
WHERE NUMMATRICULA_VEHICULO = 'VEH008';