USE [HtBase2]
GO
/****** Object:  StoredProcedure [dbo].[sp_ObtenerAngo]    Script Date: 16/10/2015 16:40:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[sp_ObtenerEmpleados]

	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
SELECT        HtIdEmpleado, HtNombreEmpleado
FROM            HtEmpleado
END

