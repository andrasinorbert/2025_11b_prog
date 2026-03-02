class Ember:
    pass

x=Ember()
x.nev="Karcsi"
print(x.nev)

class Ember2:
    
    def __init__(self, nev:str, kor:int):
        """
        Ez a konstruktor
        """
        self.nev=nev
        self.kor=kor

x=Ember2("János", 23)
print(x.nev)

import pymysql
# C:/Users/User/AppData/Local/Programs/Python/Python312/python.exe -m pip install pymysql

def select(sql:str):
    conn=pymysql.connect(
        host="localhost",
        user="root",
        password="",
        port=3306,
        database="2025_11b"
        )
    cursor=conn.cursor()
    sql_query=sql
    cursor.execute(sql_query)
    rows=cursor.fetchall()
    conn.close()
    return rows

def insert(sql:str):
    conn=pymysql.connect(
        host="localhost",
        user="root",
        password="",
        port=3306,
        database="2025_11b"
        )
    cursor=conn.cursor()
    sql_query=sql
    cursor.execute(sql_query)
    conn.commit()
    conn.close()

rows=select("SELECT név FROM névkor;")
print(rows)
insert("INSERT INTO névkor (név, kor) VALUES ('Kanga', 15);")

class OwnDB:
    def __init__(self,host,user,password,port,database):
        self.host=host
        self.user=user
        self.password=password
        self.port=port
        self.database=database
        
    def connect(self):
        return pymysql.connect(
            host=self.host,
            user=self.user,
            password=self.password,
            port=self.port,
            database=self.database
            )
    def select(self, oszlopnevek:str, tablanev:str, feltetel:str=1):
        conn=self.connect()
        cursor=conn.cursor()
        sql_query=f"SELECT {oszlopnevek} FROM {tablanev} WHERE {feltetel};"
        cursor.execute(sql_query)
        rows=cursor.fetchall()
        conn.close()
        return rows
    
db=OwnDB(host="localhost",
        user="root",
        password="",
        port=3306,
        database="2025_11b")

rows=db.select("név", "névkor", "név like 'M%'")
print(rows)