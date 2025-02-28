use GestionCCVC;


create or alter procedure [Sp_Ins_Consumidor]
	@NombreCompleto VARCHAR(250),
	@Telefono VARCHAR(250),
	@CorreoElectronico VARCHAR(250),
	@FechaRegistro DATETIME,
	@FrecuenciaCompra VARCHAR(250), 
	@PuntosFidelidad int,
	@Direccion VARCHAR(500)
as 
begin 
	INSERT INTO Consumidores(NombreCompleto, Telefono, CorreoElectronico, FechaRegistro, FrecuenciaCompra, PuntosFidelidad, Direccion)
	Values ( @NombreCompleto, @Telefono, @CorreoElectronico, @FechaRegistro,@FrecuenciaCompra, @PuntosFidelidad, @Direccion);

	print 'Consumidor insertado correctamente';
	end;
	go









	create or alter procedure [Sp_Upd_Consumidor]
	@IDConsumidor int, 
	@NombreCompleto VARCHAR(250),
	@Telefono VARCHAR(250),
	@CorreoElectronico VARCHAR(250),
	@FechaRegistro DATETIME,
	@FrecuenciaCompra VARCHAR(250), 
	@PuntosFidelidad int,
	@Direccion VARCHAR(500)
as 
begin 
	UPDATE Consumidores
	set 
	NombreCompleto = @NombreCompleto,
	Telefono = @Telefono,
	CorreoElectronico = @CorreoElectronico,
	FechaRegistro = @FechaRegistro,
	FrecuenciaCompra = @FrecuenciaCompra, 
	PuntosFidelidad = @PuntosFidelidad
	where IDConsumidor = @IDConsumidor;

	Print 'consumidor actualizado';
	end;
	go




	create or alter procedure [Sp_Del_Consumidor]
	@IDConsumidor int

	as 
	begin 
	Delete from Consumidores
	where IDConsumidor = @IDConsumidor;
	PRINT 'uUSUARIO ELIMINADO';
	END;
	GO








	create or alter procedure [Sp_Most_ConsumidorNombre]
	@NombreCompleto VARCHAR(250)
	as 
	begin 
	select * from Consumidores
	where NombreCompleto LIKE '%' + RTRIM(LTRIM(@NombreCompleto)) + '%'
	order by NombreCompleto;
	Print 'Busqueda completada';
	end;
	go





	create or alter procedure [Sp_Most_IDConsumidor]
	@IDConsumidor int
	as 
	begin
	select *
	from Consumidores
	where IDConsumidor = @IDConsumidor;
	print 'Busqueda completada'

	end;
	go




