use GestionCCVC;


create or alter procedure [Sp_Ins_Venta]
@FechaVenta DATETIME,
@TotalVenta Decimal(10,000),
@MetodoPago VARCHAR(250),
@PuntosUsados int,
@EstadoVenta VARCHAR(250),
@CantidadVendido int,
@IDCosmeticos int,
@IDConsumidor int
as 
begin 
	INSERT INTO Ventas(FechaVenta, TotalVenta, MetodoPago, PuntosUsados, EstadoVenta, CantidadVendido, IDCosmeticos, IDConsumidor)
	Values ( @FechaVenta,@TotalVenta, @MetodoPago, @PuntosUsados, @EstadoVenta,@CantidadVendido, @IDCosmeticos, @IDConsumidor);

	print 'Consumidor insertado correctamente';
	end;
	go









	create or alter procedure [Sp_Upd_Venta]
	@IDVenta int,
	@FechaVenta DATETIME,
	@TotalVenta Decimal(10,000),
	@MetodoPago VARCHAR(250),
	@PuntosUsados int,
	@EstadoVenta VARCHAR(250),
	@CantidadVendido int,
	@IDCosmeticos int,
	@IDConsumidor int
as 
begin 
	UPDATE Ventas
	set 
	FechaVenta = @FechaVenta,
	TotalVenta = @TotalVenta,
	MetodoPago = @MetodoPago,
	PuntosUsados = @PuntosUsados,
	EstadoVenta = @EstadoVenta,
	CantidadVendido = @CantidadVendido, 
	IDCosmeticos = @IDCosmeticos,
	IDConsumidor = @IDConsumidor

	where IDVenta = @IDVenta;

	Print 'Venta actualizado';
	end;
	go

	exec [Sp_Upd_Venta]
	@IDVenta =2,
	@FechaVenta ="12/12/12",
	@TotalVenta =1,
	@MetodoPago ="si",
	@PuntosUsados= 2,
	@EstadoVenta = "si",
	@CantidadVendido =1,
	@IDCosmeticos =3,
	@IDConsumidor =1


	create or alter procedure [Sp_Del_Venta]
	@IdVenta int

	as 
	begin 
	Delete from Ventas
	where IDVenta = @IdVenta;
	PRINT 'Venta ELIMINADO';
	END;
	GO








	create or alter procedure [Sp_Most_EstadoVenta]
	@EstadoVenta VARCHAR(250)
	as 
	begin 
	select * from Ventas
	where EstadoVenta LIKE '%' + RTRIM(LTRIM(@EstadoVenta)) + '%'
	order by EstadoVenta;
	Print 'Busqueda completada';
	end;
	go





	create or alter procedure [Sp_Most_IDVenta]
	@IdVenta int
	as 
	begin
	select *
	from Ventas
	where IDVenta = @IdVenta;
	print 'Busqueda completada'

	end;
	go




