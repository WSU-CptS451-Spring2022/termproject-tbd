IF OBJECT_ID (N'dbo.getDistance', N'FN') IS NOT NULL  
    DROP FUNCTION getDistance;  
GO  
CREATE FUNCTION dbo.getDistance(@ulatitude float, @ulongitude float, @blatitude float, @blongitude float)  
RETURNS float   
AS 

BEGIN
	DECLARE @ret float;
	SET @ret = 2 * 3961 * asin(sqrt((sin(radians((@blatitude - @ulatitude) / 2))) ^ 2 + cos(radians(@ulatitude)) * cos(radians(@blatitude)) * (sin(radians((@blongitude - @ulongitude) / 2))) ^ 2))
	IF (@ret IS NULL)
		SET @ret = 0;
	RETURN @ret;
END;