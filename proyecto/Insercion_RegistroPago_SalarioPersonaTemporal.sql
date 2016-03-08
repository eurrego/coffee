USE [DBFinca]
GO
/****** Object:  StoredProcedure [dbo].[Insercion_RegistroPago_SalarioPersonaTemporal]    Script Date: 07/03/2016 14:24:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


ALTER PROCEDURE [dbo].[Insercion_RegistroPago_SalarioPersonaTemporal]
	
AS
	INSERT INTO RegistroPago (Fecha)
        values (CONVERT (date, GETDATE())) ;

     DECLARE @UltimoIdRegistroPago int
	 set @UltimoIdRegistroPago=  (SELECT top 1 idRegistroPago FROM  RegistroPago order by idRegistroPago desc);




		
	
	INSERT INTO RegistroPagoSalario(idRegistroPago,idSalarioPersonaTemporal)
        (SELECT @UltimoIdRegistroPago,spt.idSalarioPersonaTemporal from SalarioPersonaTemporal spt
				 WHERE spt.EstadoCuenta = 'D')



		update SalarioPersonaTemporal 
				   set
				   EstadoCuenta = 'P'
				  
				   WHERE EstadoCuenta = 'D'
	
		
		