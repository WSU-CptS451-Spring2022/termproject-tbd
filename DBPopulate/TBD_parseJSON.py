from datetime import datetime
import json
import psycopg2
from psycopg2 import Error

from attr import attr, attributes

def cleanStr4SQL(s):
    return s.replace("'","`").replace("\n"," ")

def parseBusinessData():
    try:
        connection = psycopg2.connect(user="postgres",
                                  password="password",
                                  host="127.0.0.1",
                                  port="5432",
                                  database="yelpdb")
        cursor = connection.cursor()
    except:
        print("couldn't connect")
    #read the JSON file
    # We assume that the Yelp data files are available in the current directory. If not, you should specify the path when you "open" the function. 
    with open('./yelp_business.JSON','r') as f: 
        line = f.readline()
        count_line = 0
        #read each JSON abject and extract data
        while line:
            data = json.loads(line)
            business_id = cleanStr4SQL(data['business_id'])
            name = cleanStr4SQL(data["name"])
            address = cleanStr4SQL(data["address"])
            state = cleanStr4SQL(data["state"])
            city = cleanStr4SQL(data["city"])
            postal_code = cleanStr4SQL(data["postal_code"])
            latitude = str(data["latitude"])
            longitude = str(data["longitude"])
            stars = str(data["stars"])
            is_open = str(data["is_open"])

            cursor.execute("INSERT INTO Business(business_id, business_name, address, city, state, zip, latitude, longitude, rating)" + 
            " VALUES(%s,%s,%s,%s,%s,%s,%s,%s,%s)", (business_id, name, address, city, state, postal_code, latitude, longitude, stars))

            #process business categories
            categories = data["categories"].split(', ')
            for cat in categories:
                cursor.execute("INSERT INTO Category(cat_name)" + 
                " VALUES(%s)" + " ON CONFLICT (cat_name) DO NOTHING", (cat,))
                connection.commit()
                cursor.execute("INSERT INTO BusinessCategory(cat_name, business_id)" + 
                " VALUES(%s, %s)", (str(cat), business_id))

            connection.commit()

        
            # TO-DO : write your own code to process attributes
            # make sure to **recursively** parse all attributes at all nesting levels. You should not assume a particular nesting level. 
            attributes = parseAttributes(data["attributes"], [])
            for attr in attributes:
                cursor.execute("INSERT INTO Attribute(att_name)" + 
                " VALUES(%s)" + " ON CONFLICT (att_name) DO NOTHING", (attr[0],))
                connection.commit()
                cursor.execute("INSERT INTO BusinessAttribute(att_name, business_id, value)" + 
                " VALUES(%s, %s, %s)", (attr[0], business_id, attr[1]))

            connection.commit()

            # TO-DO : write your own code to process hours data
            hours = data["hours"]
            hoursWrite = []
            for k,v in hours.items():
                time = v.split('-')
                hoursWrite.append((k, time))
            
            for hour in hoursWrite:
                cursor.execute("INSERT INTO Times(business_id, week_day, open_time, close_time)" + 
                " VALUES(%s, %s, %s, %s)", (business_id, hour[0], hour[1][0], hour[1][1]))
            
            connection.commit()
            line = f.readline()
            count_line +=1
    print(count_line)
    f.close()

def parseAttributes(a, ret):
    for k,v in a.items():
        if isinstance(v, dict):\
            parseAttributes(v, ret)
        else:
            ret.append((k, v))
    return ret

def parseUserData():
    try:
        connection = psycopg2.connect(user="postgres",
                                  password="password",
                                  host="127.0.0.1",
                                  port="5432",
                                  database="yelpdb")
        cursor = connection.cursor()
    except:
        print("couldn't connect")
    # TO-DO : write code to parse yelp_user.JSON
    with open('./yelp_user.JSON','r') as f:  
        line = f.readline()
        count_line = 0
        #read each JSON abject and extract data
        while line:
            data = json.loads(line)
            user_id = cleanStr4SQL(data["user_id"])
            username = cleanStr4SQL(data["name"])
            signed_up = cleanStr4SQL(data["yelping_since"])
            tip_count = str(data["tipcount"])
            fan_count = str(data["fans"])
            avg_stars = str(data["average_stars"])
            funny = str(data["funny"])
            useful = str(data["useful"])
            cool = str(data["cool"])

            cursor.execute("INSERT INTO Users(userid, username, signed_up, useful, cool, funny, fans_count, avg_stars, tip_count)" + 
            " VALUES(%s,%s,%s,%s,%s,%s,%s,%s,%s)", (user_id, username, signed_up, useful, cool, funny, fan_count, avg_stars, tip_count))
            line = f.readline()
            count_line +=1
    
    f.close()
    connection.commit()

def parseFriendsData():
    try:
    # Connect to an existing database
        connection = psycopg2.connect(user="postgres",
                                  password="password",
                                  host="127.0.0.1",
                                  port="5432",
                                  database="yelpdb")

        # Create a cursor to perform database operations
        cursor = connection.cursor()
        # Print PostgreSQL details
        print("PostgreSQL server information")
        print(connection.get_dsn_parameters(), "\n")
        # Executing a SQL query
        cursor.execute("SELECT version();")
        # Fetch result
        record = cursor.fetchone()
        print("You are connected to - ", record, "\n")

    except (Exception, Error) as error:
        print("Error while connecting to PostgreSQL", error)
    
    with open('./yelp_user.JSON','r') as f: 
        line = f.readline()
        count_line = 0
        #read each JSON abject and extract data
        while line:
            data = json.loads(line)
            user_id = cleanStr4SQL(data["user_id"])
            friends = data["friends"]
            for friend in friends:
                cursor.execute("INSERT INTO Friends(userid, friend_id)" + 
            " VALUES(%s,%s)", (user_id, friend))
            line = f.readline()
            count_line +=1
    print(count_line)
    connection.commit()
    f.close()

def parseCheckinData():
    try:
        connection = psycopg2.connect(user="postgres",
                                  password="password",
                                  host="127.0.0.1",
                                  port="5432",
                                  database="yelpdb")
        cursor = connection.cursor()
    except:
        print("couldn't connect")

    # TO-DO : write code to parse yelp_checkin.JSON
    with open('./yelp_checkin.JSON','r') as f:  
        line = f.readline()
        count_line = 1
        #read each JSON abject and extract data
        while line:
            data = json.loads(line)
            business_id = cleanStr4SQL(data["business_id"])
            datestr = data["date"]
            dateli = datestr.split(',')
            for date in dateli:
                tup = date.split(' ')
                cursor.execute("INSERT INTO Checkins(check_time, check_date, business_id)" + 
                " VALUES(%s,%s,%s)", (tup[1], tup[0], business_id))

            line = f.readline()
            count_line +=1
    connection.commit()
    print(count_line)
    f.close()

def parseTipData():
    try:
        connection = psycopg2.connect(user="postgres",
                                  password="password",
                                  host="127.0.0.1",
                                  port="5432",
                                  database="yelpdb")
        cursor = connection.cursor()
    except:
        print("couldn't connect")
    # TO-DO : write code to parse yelp_tip.JSON
    with open('./yelp_tip.JSON','r') as f:  
        outfile =  open('.//tip.txt', 'w')
        line = f.readline()
        count_line = 1
        #read each JSON abject and extract data
        while line:
            data = json.loads(line)
            business_id = cleanStr4SQL(data["business_id"]),
            date = cleanStr4SQL(data["date"]),
            likes = str(data["likes"]),
            text = cleanStr4SQL(data["text"]),
            user_id = cleanStr4SQL(data["user_id"])

            cursor.execute("INSERT INTO Tip(userid, business_id, tip_text, tip_date, num_of_likes)" + 
                " VALUES(%s,%s,%s,%s,%s)", (user_id, business_id, text, date, likes))
            line = f.readline()
            count_line +=1
        connection.commit()

    print(count_line)
    outfile.close()
    f.close()
    pass

if __name__ == "__main__":
    parseUserData()
    parseFriendsData()
    parseBusinessData()
    parseCheckinData()
    parseTipData()
