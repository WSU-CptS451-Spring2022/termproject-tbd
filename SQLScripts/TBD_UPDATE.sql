--Update business check in count
CREATE TEMP TABLE checkin_temp
AS
SELECT business_id, count(business_id) as count
FROM CheckIns
GROUP BY business_id;

UPDATE Business
SET checkins_count = checkin_temp.count
FROM checkin_temp
WHERE Business.business_id = checkin_temp.business_id;

DROP TABLE checkin_temp;

--Update business tip count
CREATE TEMP TABLE tip_temp
AS
SELECT business_id, count(business_id) as count
FROM Tip
GROUP BY business_id;

UPDATE Business
SET tip_count = tip_temp.count
FROM tip_temp
WHERE Business.business_id = tip_temp.business_id;

DROP TABLE tip_temp;

--Update user like count
UPDATE Users
SET like_count = 
    (SELECT sum(num_of_likes)
    FROM Tip
    WHERE Users.userid = Tip.userid
    GROUP BY userid);

UPDATE Users
SET like_count = 0
WHERE like_count is NULL;

--Update user tip count
UPDATE Users
SET tip_count = 
    (SELECT count(userid)
    FROM Tip
    WHERE Users.userid = Tip.userid
    GROUP BY userid);

UPDATE Users
SET tip_count = 0
WHERE tip_count is NULL;