CREATE PROCEDURE sp_BuscarFirstLastName 
	-- Add the parameters for the stored procedure here
	@FirstName nvarchar(40), 
	@LastNAme nvarchar(20)
AS
BEGIN
	SET NOCOUNT ON;
    -- Insert statements for procedure here
	SELECT CustomerId from Customer where FirstName=@FirstName and LastName=@LastName
END
GO
