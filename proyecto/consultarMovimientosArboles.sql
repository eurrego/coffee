USE [DBFinca]
GO
/****** Object:  StoredProcedure [dbo].[consultarMovimientosArboles]    Script Date: 11/03/2016 9:52:35 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[consultarMovimientosArboles]
(@idArbol int)

as

begin

	select ma.idMovimientosArboles,ta.NombreTipoArbol,ma.Cantidad,ma.Fecha from TipoArbol ta
	inner join Arboles a
	on ta.idTipoArbol = a.idTIpoArbol
	inner join MovimientosArboles ma
	on a.idArboles = ma.idArboles
	where a.idArboles = @idArbol

end







