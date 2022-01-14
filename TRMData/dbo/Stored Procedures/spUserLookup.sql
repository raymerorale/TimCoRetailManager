CREATE PROCEDURE [dbo].[spUserLookup]
	@Id nvarchar(128)
AS
BEGIN
	SET nocount ON

	SELECT Id, FirstName, LastName, EmailAddress, DateCreated
	FROM [dbo].[User]
	WHERE Id = @Id;
END
