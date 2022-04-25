DROP FUNCTION getDistance;

CREATE FUNCTION getDistance(ulatitude FLOAT, ulongitude FLOAT, blatitude FLOAT, blongitude FLOAT)  
RETURNS float AS $$

BEGIN
	RETURN 2 * 3961 * asin(sqrt((sin(radians((blatitude - ulatitude) / 2))) ^ 2 + cos(radians(ulatitude)) * cos(radians(blatitude)) * (sin(radians((blongitude - ulongitude) / 2))) ^ 2));

END;
$$ LANGUAGE plpgsql;