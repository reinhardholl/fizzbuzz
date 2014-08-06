CREATE FUNCTION GetTheFizz (@TestValue int)
RETURNS VARCHAR(8)
AS BEGIN
	IF (@TestValue %3 = 0 and @TestValue %5 = 0)
	BEGIN
		return 'FizzBuzz'
	END
	IF (@TestValue %3 = 0)
	BEGIN
		return 'Fizz'
	END
	IF (@TestValue %5 = 0)
	BEGIN
		return 'Buzz'
	END
	return cast(@TestValue as varchar(8))
END
GO

DECLARE @i int = 0
WHILE @i < 100 BEGIN
    SET @i = @i + 1

	PRINT dbo.GetTheFizz(@i)
END


DROP FUNCTION GetTheFizz