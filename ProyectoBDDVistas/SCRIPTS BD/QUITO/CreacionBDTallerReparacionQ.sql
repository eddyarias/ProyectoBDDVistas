USE MASTER
DROP DATABASE TallerReparacionQ
GO
CREATE DATABASE TallerReparacionQ
GO
USE TallerReparacionQ
/*==============================================================*/
/* Table: CLIENTE_01 FRAGMENTACION HORIZONTAL
*/
/*==============================================================*/
create table CLIENTE_01 (
 NOMBRE_CLIENTE char(30) not null,
 APELLIDO_CLIENTE char(30) not null,
 ID_TALLER char(10) not null,
 NUMCEDULA_CLIENTE char(10) not null,
 DIRECCION_CLIENTE char(60) null,
 constraint PK_CLIENTE_01 primary key (NOMBRE_CLIENTE,
APELLIDO_CLIENTE,ID_TALLER)
)
go
/*==============================================================*/
/* Table: EMPLEADO_01 FRAGMENTACION HORIZONTAL
*/
/*==============================================================*/
create table EMPLEADO_01 (
 ID_EMPLEADO char(10) not null,
 ID_TALLER char(10) not null,
 NUMCED_EMPLEADO char(10) not null,
 NOMBRE_EMPLEADO char(50) not null,
 APELLIDO_EMPLEADO char(50) not null,
 SALARIO_EMPLEADO decimal(7,2) not null,
 FECHAINICIOCONTRATO_EMPLEADO datetime not null,
 constraint PK_EMPLEADO_01 primary key (ID_EMPLEADO, ID_TALLER)
)
go
/*==============================================================*/
/* Table: TALLER_01 FRAGMENTACION HORIZONTAL
*/
/*==============================================================*/
create table TALLER_01 (
 ID_TALLER char(10) not null,
 ID_DIRECTOR char(10) null,
 NOM_TALLER char(60) not null,
 LOCALIDAD_TALLER char(60) not null,
 constraint PK_TALLER_01 primary key (ID_TALLER)
)
go
/*==============================================================*/
/* Table: FACTURA_01 FRAGMENTACION HORIZONTAL DERIVADA */
/*==============================================================*/
create table FACTURA_01 (
 ID_FACTURA char(256) not null,
 NUMMATRICULA_VEHICULO char(10) not null,
 ID_REPARACION char(10) not null,
 ID_TALLER char(10) NOT null,
 FECHAEMISION_FACTURA datetime not null,
 SUBTOTAL_FACTURA decimal(7,2) not null,
 IVA_FACTURA decimal(7,2) not null,
 TOTAL_FACTURA decimal(7,2) not null,
 constraint PK_FACTURA_01 primary key (ID_FACTURA, ID_TALLER)
)
go
/*==============================================================*/
/* Table: NUMEROTELEFONO_01 FRAGMENTACION HORIZONTAL DERIVADA */
/*==============================================================*/
create table NUMEROTELEFONO_01 (
 NUMEROTELEFONO char(10) not null,
 ID_EMPLEADO char(10) not null,
 ID_TALLER char(10) NOT null,
 constraint PK_NUMEROTELEFONO_01 primary key (NUMEROTELEFONO, ID_EMPLEADO,
ID_TALLER)
)
go
/*==============================================================*/
/* Table: REPARACION_01 FRAGMENTACION HORIZONTAL DERIVADA */
/*==============================================================*/
create table REPARACION_01 (
 NUMMATRICULA_VEHICULO char(10) not null,
 ID_REPARACION char(10) not null,
 ID_TALLER char(10) NOT null,
 TIPO_REPARACION char(10) not null,
 FECHA_REPARACION datetime not null,
 OBSERVACIONES_REPARACION char(100) not null,
 PRECIO_REPARACION decimal(7,2) not null,
 constraint PK_REPARACION_01 primary key (NUMMATRICULA_VEHICULO,
ID_REPARACION, ID_TALLER),
)
go
/*==============================================================*/
/* Table: VEHICULO_01 FRAGMENTACION HORIZONTAL
*/
/*==============================================================*/
create table VEHICULO_01 (
 NUMMATRICULA_VEHICULO char(10) not null,
 ID_TALLER char(10) not null,
 NOMBRE_CLIENTE char(30) not null,
 APELLIDO_CLIENTE char(30) not null,
 FECHACOMPRA_VEHICULO datetime not null,
 constraint PK_VEHICULO_01 primary key (NUMMATRICULA_VEHICULO, ID_TALLER)
)
go
/*Constraint para foreing key */
alter table CLIENTE_01
add constraint FK_CLIENTE__ATIENDE_TALLER_0 foreign key (ID_TALLER)
 references TALLER_01 (ID_TALLER)
go
alter table EMPLEADO_01
 add constraint FK_EMPLEADO_TRABAJA_TALLER_0 foreign key (ID_TALLER)
 references TALLER_01 (ID_TALLER)
go
alter table FACTURA_01
 add constraint FK_FACTURA__CORRESPON_REPARACI foreign key (NUMMATRICULA_VEHICULO, ID_REPARACION, ID_TALLER)
 references REPARACION_01 (NUMMATRICULA_VEHICULO, ID_REPARACION,
ID_TALLER)
go
alter table NUMEROTELEFONO_01
 add constraint FK_NUMEROTE_TIENETELE_EMPLEADO foreign key (ID_EMPLEADO,ID_TALLER )
 references EMPLEADO_01 (ID_EMPLEADO,ID_TALLER)
go
alter table REPARACION_01
 add constraint FK_REPARACI_TIENE_VEHICULO foreign key (NUMMATRICULA_VEHICULO, ID_TALLER)
 references VEHICULO_01 (NUMMATRICULA_VEHICULO,ID_TALLER)
go
alter table TALLER_01
 add constraint FK_TALLER_0_DIRIGE_EMPLEADO foreign key (ID_DIRECTOR,
ID_TALLER)
 references EMPLEADO_01 (ID_EMPLEADO,ID_TALLER)
go
alter table VEHICULO_01
 add constraint FK_VEHICULO_PERTENECE_CLIENTE_ foreign key (NOMBRE_CLIENTE,
APELLIDO_CLIENTE,ID_TALLER)
 references CLIENTE_01 (NOMBRE_CLIENTE, APELLIDO_CLIENTE,ID_TALLER)
go
alter table VEHICULO_01
 add constraint FK_VEHICULO_REGISTRA_TALLER_0 foreign key (ID_TALLER)
 references TALLER_01 (ID_TALLER)
go
