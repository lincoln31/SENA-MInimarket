-- Active: 1680237838456@@127.0.0.1@3306@minimarket

CREATE DATABASE Minimarket;

use Minimarket;

CREATE TABLE minimarket(
    idMinimarket int AUTO_INCREMENT,
    nit VARCHAR(12) NOT NULL,
    razonSocial varchar(50) NOT NULL,
    telefono VARCHAR(10) NOT null ,
    nomeclatura varchar (50) NOT NULL,
    ciudad varchar (50) NOT NULL,
    departamento VARCHAR(50) not null ,
    correo varchar (50) not null ,
    sitioweb VARCHAR(50) not NULL ,
    facebook varchar (50) not null ,
    whastapp varchar (10) not null ,
    CONSTRAINT  pk_minimarket PRIMARY key (idMinimarket),
    CONSTRAINT unico_nit UNIQUE (nit),
    CONSTRAINT unico_razonSocal UNIQUE (razonSocial)
);


CREATE TABLE proveedor(
    idProveedor  INT AUTO_INCREMENT,
    nit VARCHAR (15) not null ,
    razonSocial VARCHAR (50) not null ,
    telefono varchar(10) not null ,
    correo varchar(50) not null,
    nomeclaturas VARCHAR(50) not null,
    ciudad varchar (50) not null ,
    departamento VARCHAR(50) not null ,
    CONSTRAINT pk_proveedor PRIMARY KEY (idProveedor),
    CONSTRAINT  unico_nit_proveedor unique (nit),
    CONSTRAINT unico_razonSocial_proveedor unique (razonSocial)
);


CREATE table categoria(
    idCategoria INT AUTO_INCREMENT,
    nombre VARCHAR(50) not null ,
    descripcion varchar(200) null,
    CONSTRAINT pk_categoria PRIMARY key (idCategoria),
    CONSTRAINT unico_nombre UNIQUE (nombre)
);

CREATE table cliente(
    idCliente int AUTO_INCREMENT,
    tipoDoc ENUM ("CC","TI","PAS","PEP","PPt","CE","Otro"),
        identificacion VARCHAR(11) not null,
        nombres VARCHAR(50) not null ,
        apellidos VARCHAR(50) not null ,
        correo VARCHAR (50) not null,
        celular VARCHAR(11) not null ,
        CONSTRAINT pk_Cliente PRIMARY KEY (idCliente),
        CONSTRAINT unico_identicacion UNIQUE(identificacion)
);


CREATE Table producto (
    idProducto int AUTO_INCREMENT,
    nombre VARCHAR(50)not null ,
    marca VARCHAR (50)not null,
    stock int not null DEFAULT  0,
    pvp int not NULL DEFAULT 0,
    descripcion VARCHAR(200),
    unidadMedida enum ('UND','gr'),
    idCategoria int NOT NULL,
    CONSTRAINT pk_producto PRIMARY KEY (idProducto),
    CONSTRAINT unico_nombre  UNIQUE(nombre),
    CONSTRAINT FOREIGN KEY (idCategoria)REFERENCES Categoria  (idCategoria)
);



CREATE table empleado (
    idEmpleado  int AUTO_INCREMENT,
    tipoDoc ENUM ("CC","TI","PAS","PEP","PPt","CE","Otro"),
    identificacion VARCHAR(11) not null,
        nombres VARCHAR(50) not null ,
        apellidos VARCHAR(50) not null ,
        correo VARCHAR (50) not null,
        celular VARCHAR(11) not null ,
        clave varchar(8)not null,
        idMinimarket int not null ,
        CONSTRAINT Pk_empleado PRIMARY KEY(idEmpleado),
        CONSTRAINT unico_identificacion_empelado UNIQUE(identificacion),
        CONSTRAINT unico_correo_empledo UNIQUE(correo),
        CONSTRAINT fk_minimarket FOREIGN KEY (idMinimarket)REFERENCES Minimarket (idMinimarket )
     
    
);


CREATE TABLE factura(
    idFactura int AUTO_INCREMENT,
    codigoFactura  varchar(8) not null,
    FechaGeneracion DATETIME not null ,
    iva int not null ,
    SinIva int not null,
    total int not null ,
    idEmpleado int not null,
    idCliente int not null,
    CONSTRAINT pk_factura PRIMARY key (idFactura),
    CONSTRAINT unico_factura UNIQUE (codigoFactura),
    CONSTRAINT fk_empleado FOREIGN KEY (idEmpleado) REFERENCES Empleado ( idEmpleado),
    CONSTRAINT fk_cliente FOREIGN key (idCliente) REFERENCES Cliente (idCliente )
);

CREATE table  detalleFactura (
    idDetalleFactura int AUTO_INCREMENT,
    cantidadProduntos int NOT null ,
    precioventa int NOT null ,
    subtotal  int not null ,
    idProducto int not null ,
    idFactura int not null,
    CONSTRAINT pk_detalleFactura PRIMARY key (idDetalleFactura),
    CONSTRAINT fk_producto FOREIGN key (idProducto) REFERENCES Producto (idProducto ),
    CONSTRAINT fk_factura FOREIGN KEY (idFactura) REFERENCES Factura (IdFactura)
);


INSERT INTO minimarket (nit, razonSocial, telefono, nomeclatura, ciudad, departamento, correo, sitioweb, facebook, whastapp)
VALUES ('123456789', 'ADSO Minimarket', '3166527534', '#72 d 23', 'Cali', 'valle del cauca', 'ADSOMINIo@market.com', 'www.ADSOMINIMARKET.com', 'Adso-Minimarket_fb', '9876543210');







INSERT INTO proveedor (nit, razonSocial, telefono, correo, nomeclaturas, ciudad, departamento)
VALUES ('456789012', 'Bavaria', '6789012345', 'Bavaria@Gmail.com', 'Cr56 # 23g -43', 'Pasto', 'Nariño');
INSERT INTO proveedor (nit, razonSocial, telefono, correo, nomeclaturas, ciudad, departamento)
VALUES ('789012345', 'Colombina', '5678901234', 'Colombina@Gmail.com', 'Cr 24 #34 A -12', 'Cali', 'Valle del cauca');
-- Add more entries here
INSERT INTO proveedor (nit, razonSocial, telefono, correo, nomeclaturas, ciudad, departamento)
VALUES ('78901245', 'Postobon', '5678901234', 'Postobon@Gmail.com', 'Cr 67 # 54H - 8', 'Pereira', 'Risaralda');

INSERT INTO proveedor (nit, razonSocial, telefono, correo, nomeclaturas, ciudad, departamento)
VALUES ('45689012', 'Frutiño', '6789012345', 'Frutiño@Gmail.com', 'Cr 52 # 10 l- 5', 'Medellin', 'Antioquia');


INSERT INTO proveedor (nit, razonSocial, telefono, correo, nomeclaturas, ciudad, departamento)
VALUES ('78912345', 'Bucanero', '5678901234', 'Buacanero@Gmail.com', 'calle 7N # 23 - 4', 'Bogota', 'Bogota');





INSERT INTO categoria (nombre, descripcion)
VALUES ('Bebidas alcohólica', 'Bebias con alcohol');

INSERT INTO categoria (nombre, descripcion)
VALUES ('Carnicos', 'Toda clase de carnicos que necesitan refrigeracion');

INSERT INTO categoria (nombre, descripcion)
VALUES ('Gaseosas', 'Bebidas carbonatadas');

INSERT INTO categoria (nombre, descripcion)
VALUES ('Dulces', 'Dulces');
INSERT INTO categoria (nombre, descripcion)
VALUES ('Refresco en polvo', 'Polvo que da cancer');

SELECT*FROM categoria;



INSERT INTO cliente (tipoDoc, identificacion, nombres, apellidos, correo, celular)
VALUES ('CC', '1005785359', 'Juan', 'Valencia', 'juan@Gmail.com', '3168074695');

INSERT INTO cliente (tipoDoc, identificacion, nombres, apellidos, correo, celular)
VALUES ('TI', '9876543210', 'María', 'Herrera', 'mariaherrera@example.com', '7890123456');
INSERT INTO cliente (tipoDoc, identificacion, nombres, apellidos, correo, celular)
VALUES ('CC', '987654320', 'María', 'Bautista', 'mariabautista@example.com', '7890123456');
INSERT INTO cliente (tipoDoc, identificacion, nombres, apellidos, correo, celular)
VALUES ('CC', '987543210', 'Camila', 'Chavez', 'camilachavez@example.com', '7890123456');
INSERT INTO cliente (tipoDoc, identificacion, nombres, apellidos, correo, celular)
VALUES ('CC', '876543210', 'Lina', 'Hernandez', 'linahernadez@example.com', '7890123456');



INSERT INTO producto (nombre, marca, stock, pvp, descripcion, unidadMedida, idCategoria)
VALUES ('Poker', 'Bavaria', 5000, 2500, 'Cerveza Poker en lata de 350ml', 'UND', 1);

INSERT INTO producto (nombre, marca, stock, pvp, descripcion, unidadMedida, idCategoria)
VALUES ('Baloncitos de Chocolate', 'Colombina', 1000, 200, 'Balancitos de chcolate ', 'UND', 4);
INSERT INTO producto (nombre, marca, stock, pvp, descripcion, unidadMedida, idCategoria)
VALUES ('Pollo', 'Bucanero', 100, 20000, 'medio pollo  1100', 'gr', 2);
INSERT INTO producto (nombre, marca, stock, pvp, descripcion, unidadMedida, idCategoria)
VALUES ('Frutiño de salpicon', 'Frutiño', 10000,500, 'Frutiño de salpicon de 18g', 'UND', 5);
INSERT INTO producto (nombre, marca, stock, pvp, descripcion, unidadMedida, idCategoria)
VALUES ('Postobon de uva', 'Postobon', 1000, 2000, 'Postobon de uva en envase plastico de 2L', 'UND', 3);

-- Add more entries here

