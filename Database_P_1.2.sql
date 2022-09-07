drop database [Facturacion_P1.2]
use sandbox2
create database [Facturacion_P1.2]

use [Facturacion_P1.2] 

CREATE TABLE "FormaPago"(
    "id_fPago" INT identity(1,1) NOT NULL,
    "nombre" NVARCHAR(255) NOT NULL
	CONSTRAINT "formapago_id_fpago_primary" PRIMARY KEY("id_fPago")
);
CREATE TABLE "Cliente"(
    "id_Cliente" INT identity(1,1) NOT NULL,
    "nombre" NVARCHAR(255) NOT NULL
	CONSTRAINT "cliente_id_Cliente_primary" PRIMARY KEY("id_Cliente")
);
CREATE TABLE "Articulo"(
    "id_art" INT identity(1,1) NOT NULL,
    "nombre" NVARCHAR(255) NOT NULL,
    "precioUnitario" INT NOT NULL
	CONSTRAINT "articulo_id_art_primary" PRIMARY KEY("id_art")
); 
CREATE TABLE "Factura"(
    "nroFactura" INT identity(1,1) NOT NULL,
    "fecha" DATE NOT NULL,
    "id_fPago" INT NOT NULL,
    "id_cliente" INT NOT NULL
	cONSTRAINT "factura_nrofactura_primary" PRIMARY KEY("nroFactura"),
	CONSTRAINT "factura_id_fpago_foreign" FOREIGN KEY("id_fPago") REFERENCES "FormaPago"("id_fPago"),
	CONSTRAINT "factura_id_cliente_foreign" FOREIGN KEY("id_cliente") REFERENCES Cliente("id_cliente")
);
CREATE TABLE "DetalleFactura"(
    "id_dFactura" INT identity(1,1) NOT NULL,
    "id_art" INT NOT NULL,
    "nroFactura" INT NOT NULL,
    "cantidad" INT NOT NULL
	CONSTRAINT "detallefactura_id_dfactura_primary" PRIMARY KEY("id_dFactura"),
	CONSTRAINT "detallefactura_id_art_foreign" FOREIGN KEY("id_art") REFERENCES "Articulo"("id_art"),
	CONSTRAINT "detallefactura_nrofactura_foreign" FOREIGN KEY("nroFactura") REFERENCES "Factura"("nroFactura")
);

insert into formaPago values ('Efectivo'),('Credito'),('Debito');
insert into Articulo values ('Chicle',15),('Leche',80),('Alfajor',50);
insert into Cliente values ('Juan'), ('Pedro');
insert into Factura values (GETDATE(),1,1);
insert into Factura values (GETDATE(),2,2);
insert into DetalleFactura values (1,1,3), (2,1,2),(3,1,3);
insert into DetalleFactura values (2,2,3), (1,2,3),(3,2,1);

create proc sp_AddArt(
@nroFact int,
@id_art int,
@cant int = 1
)
as 
begin
insert into DetalleFactura values 
(@id_art,@nroFact,@cant)
end

create proc sp_NewArt
(@name varchar(50),
@price int)
as
insert into Articulo values (@name,@price)

create proc sp_Articulos
as
begin
select id_art as 'ID', nombre as 'Nombre', precioUnitario as 'Precio Unitario', fecha_baja as 'Fecha Baja'
from Articulo a 
where fecha_baja is null
end

create proc sp_Facturas
as
select nroFactura as 'id', cast(nroFactura as varchar(10)) + ' - ' + c.nombre + ' - ' + cast(fecha as varchar(10)) as 'string'
from Factura f
join Cliente c on c.id_Cliente = f.id_cliente


create proc sp_DetallesFactura (
@nroFact int )
as
select a.id_art 'ID Articulo',a.nombre 'Articulo', d.cantidad as 'Cantidad' , a.precioUnitario*d.cantidad 'Subtotal'
from DetalleFactura d
join Articulo a on d.id_art = a.id_art
where nroFactura = @nroFact

create proc sp_FormasPago 
as
select cast(id_fPago as varchar(10)) + ' - ' + nombre as 'string', id_fPago as 'ID',nombre
from FormaPago 

create proc sp_Clientes
as
select cast(id_cliente as varchar(10)) + ' - ' + nombre as 'string',id_Cliente as 'ID',nombre
from 
Cliente

create proc sp_NewFact
(@formPago int,
@id_cliente int,
@date date output,
@id int output)
as
begin
set @date = getDate();
insert into Factura values (@date,@formPago,@id_cliente);
set @id = SCOPE_IDENTITY();
end





create proc sp_RemoveArt(
@id_art int
)
as 
update Articulo 
set fecha_baja = getDate()
where 
id_art = @id_art;


create proc sp_BuscArt
(@nroFact int,
@id_art int)
as
select * from DetalleFactura where id_art=@id_art and nroFactura = @nroFact

