CREATE TABLE Users (
        userid VARCHAR UNIQUE,
        username VARCHAR,
        signed_up DATE,
        latitude FLOAT DEFAULT 0, 
        longitude FLOAT DEFAULT 0,
        useful INTEGER DEFAULT 0,
        cool INTEGER DEFAULT 0,
        funny INTEGER DEFAULT 0,
        like_count INTEGER DEFAULT 0,
        fans_count INTEGER DEFAULT 0,
        avg_stars FLOAT DEFAULT 0,
        tip_count INTEGER DEFAULT 0,
        PRIMARY KEY (userid, username)
);

CREATE TABLE Friends (
        userid VARCHAR,
        friend_id VARCHAR,
        PRIMARY KEY (userid,friend_id),
        FOREIGN KEY (userid) REFERENCES Users(userid),
        FOREIGN KEY (friend_id) REFERENCES Users(userid)
);

CREATE TABLE Business (
        business_id VARCHAR UNIQUE,
        business_name VARCHAR,
        address VARCHAR,
        city VARCHAR,
        state VARCHAR,
        zip INTEGER,
        latitude FLOAT, 
        longitude FLOAT,
        rating FLOAT DEFAULT 0,
        checkins_count INTEGER DEFAULT 0,
        tip_count INTEGER DEFAULT 0,
        PRIMARY KEY (business_id, business_name)
);

CREATE TABLE Category (
        cat_name VARCHAR,
        PRIMARY KEY(cat_name)
);

CREATE TABLE BusinessCategory (
        cat_name VARCHAR,
        business_id VARCHAR,
        PRIMARY KEY (cat_name,business_id),
        FOREIGN KEY (cat_name) REFERENCES Category(cat_name),
        FOREIGN KEY (business_id) REFERENCES Business(business_id)
);

CREATE TABLE Tip (
        userid VARCHAR NOT NULL,
        business_id VARCHAR NOT NULL,
        tip_text VARCHAR,
        tip_date TIMESTAMP,
        num_of_likes INTEGER,
        PRIMARY KEY (userid,business_id,tip_date),
        FOREIGN KEY (userid) REFERENCES Users(userid),
        FOREIGN KEY (business_id) REFERENCES Business(business_id)
);

CREATE TABLE CheckIns (
      check_time TIME,
      check_date DATE,
      business_id VARCHAR,
      PRIMARY KEY (business_id, check_date, check_time),
      FOREIGN KEY (business_id) REFERENCES Business(business_id)
);

CREATE TABLE Times (
      business_id VARCHAR,
      week_day VARCHAR,
      open_time TIME,
      close_time TIME,
      PRIMARY KEY (business_id, week_day),
      FOREIGN KEY (business_id) REFERENCES Business(business_id)
);

CREATE TABLE Attribute (
        att_name VARCHAR,
        PRIMARY KEY (att_name)
);

CREATE TABLE BusinessAttribute (
        att_name VARCHAR,
        business_id VARCHAR,
        value VARCHAR,
        PRIMARY KEY (att_name,business_id),
        FOREIGN KEY (att_name) REFERENCES Attribute(att_name),
        FOREIGN KEY (business_id) REFERENCES Business(business_id)
);
