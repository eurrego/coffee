USE [DBFinca]
GO
/****** Object:  StoredProcedure [dbo].[ActializarCantidadArboles]    Script Date: 11/03/2016 9:52:53 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ActializarCantidadArboles]
as

begin

update a
			set a.Cantidad = t1.total
			from Arboles a
			inner join  (select idArboles, sum(Cantidad)as total from MovimientosArboles
			group by idArboles) t1 
			on a.idArboles = t1.idArboles

end


