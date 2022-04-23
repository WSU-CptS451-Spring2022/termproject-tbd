--numtips trigger
CREATE OR REPLACE FUNCTION UpdateTipCount() RETURNS trigger AS '
BEGIN 
   UPDATE Users
   SET tip_count = tip_count+1
   WHERE Users.userid=NEW.userid;
   UPDATE Business
   SET tip_count = tip_count+1
   WHERE Business.business_id = NEW.business_id;
   RETURN NEW;
END
' LANGUAGE plpgsql; 

CREATE OR REPLACE TRIGGER TipCount
AFTER INSERT on Tip
FOR EACH ROW
EXECUTE PROCEDURE UpdateTipCount();

--numtips test
INSERT INTO Tip (userid, business_id, tip_text, tip_date, num_of_likes) VALUES ('---1lKK3aKOuomHnwAkAow', '--ab39IjZR_xUf81WyTyHg', 'Test tip', '2013-03-16 21:02:54', '0');

--clean numtips test
DELETE FROM Tip WHERE userid='---1lKK3aKOuomHnwAkAow' and tip_text = 'Test tip';
UPDATE Users
SET tip_count = tip_count-1
WHERE Users.userid ='---1lKK3aKOuomHnwAkAow';
UPDATE Business
SET tip_count = tip_count-1
WHERE Business.business_id = '--ab39IjZR_xUf81WyTyHg';



--numcheck trigger
CREATE OR REPLACE FUNCTION UpdateCheckInsCount() RETURNS trigger AS '
BEGIN 
   UPDATE Business
   SET checkins_count = checkins_count+1
   WHERE Business.business_id = NEW.business_id;
   RETURN NEW;
END
' LANGUAGE plpgsql; 

CREATE OR REPLACE TRIGGER CheckInsCount
AFTER INSERT on CheckIns
FOR EACH ROW
EXECUTE PROCEDURE UpdateCheckInsCount();

--numcheck test
INSERT INTO CheckIns (check_time, check_date, business_id) VALUES ('00:00:01', '2010-08-14', '--ab39IjZR_xUf81WyTyHg');

--clean numcheck test
DELETE FROM CheckIns WHERE business_id='--ab39IjZR_xUf81WyTyHg' and check_time = '00:00:01' and check_date = '2010-08-14';
UPDATE Business
SET tip_count = tip_count-1
WHERE business_id = '--ab39IjZR_xUf81WyTyHg';



--likes trigger
CREATE OR REPLACE FUNCTION UpdateLikeCount() RETURNS trigger AS '
BEGIN 
   UPDATE Users
   SET like_count = like_count+1
   WHERE Users.userid=NEW.userid;
   RETURN NEW;
END
' LANGUAGE plpgsql; 

CREATE OR REPLACE TRIGGER LikeCount
AFTER UPDATE on Tip
FOR EACH ROW
EXECUTE PROCEDURE UpdateLikeCount();

--likes test
UPDATE Tip
SET num_of_likes = num_of_likes+1
WHERE userid = '---1lKK3aKOuomHnwAkAow' and business_id = 'RRw9I8pHt5PzgYGT2QeODw' and tip_text = 'Phone number should be 1531';

--clean likes test
UPDATE Tip
SET num_of_likes = num_of_likes-1
WHERE userid = '---1lKK3aKOuomHnwAkAow' and business_id = 'RRw9I8pHt5PzgYGT2QeODw' and tip_text = 'Phone number should be 1531';
UPDATE Users
   SET like_count = like_count-1
   WHERE userid='---1lKK3aKOuomHnwAkAow';