CREATE PROCEDURE GetCarCountWithNameStartingWith
    @name NVARCHAR(100)
AS
BEGIN
    SELECT COUNT(*) AS CarCount
    FROM Car
    WHERE name LIKE @name + '%';
END

