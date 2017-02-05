use master
ALTER DATABASE teste SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
DROP DATABASE teste;
create database teste
use teste

-- 1 to many Table1->Table2
CREATE TABLE Table1 (Table1ID int identity primary key, Info int)
CREATE TABLE Table2 (Table2ID int identity primary key, Table1ID int)
ALTER TABLE Table2 ADD CONSTRAINT [FK_Table2_Table1ID] FOREIGN KEY([Table1ID]) REFERENCES Table1 (Table1ID)


-- Many to many Table1 x Table3
CREATE TABLE Table3 (Table3ID int identity primary key, Info int)
CREATE TABLE Table1To3 (Table1ID int, Table3ID int, primary key (Table1ID, Table3ID))
ALTER TABLE Table1To3 ADD CONSTRAINT [FK_Table1To3_Table1ID] FOREIGN KEY([Table1ID]) REFERENCES Table1 (Table1ID)
ALTER TABLE Table1To3 ADD CONSTRAINT [FK_Table1To3_Table3ID] FOREIGN KEY([Table3ID]) REFERENCES Table3 (Table3ID)

-- Many to many WITH ATTRIBUTES Table1 x Table6
CREATE TABLE Table6 (Table6ID int identity primary key, Info int)
CREATE TABLE Table1To6 (Table1ID int, Table6ID int, Info int, primary key (Table1ID, Table6ID))
ALTER TABLE Table1To6 ADD CONSTRAINT [FK_Table1To6_Table1ID] FOREIGN KEY([Table1ID]) REFERENCES Table1 (Table1ID)
ALTER TABLE Table1To6 ADD CONSTRAINT [FK_Table1To6_Table6ID] FOREIGN KEY([Table6ID]) REFERENCES Table6 (Table6ID)


-- 1 to many Table1 ALTERNATE KEY (unique index) -> Table4
CREATE UNIQUE INDEX AK_Table1 ON Table1 (Info);   
CREATE TABLE Table4 (Table4ID int identity primary key, Info int)
ALTER TABLE Table4 ADD CONSTRAINT [FK_Table4_Table1Info] FOREIGN KEY([Info]) REFERENCES Table1 (Info)

-- 1 to one Table1 to Table5
CREATE TABLE Table5 (Table5ID int primary key, Info int)
ALTER TABLE Table5 ADD CONSTRAINT [FK_Table5_Table1ID] FOREIGN KEY([Table5ID]) REFERENCES Table1 (Table1ID)


-- Composite Key
CREATE TABLE Table7 (Table7AID int, Table7BID int, Info int, primary key (Table7AID, Table7BID))

CREATE TABLE Table8 (Table7AID int, Table7BID int, Info int, primary key (Table7BID, Table7AID))
CREATE TABLE Table9 (Table7BID int, Table7AID int, Info int, primary key (Table7BID, Table7AID))
ALTER TABLE Table8 ADD CONSTRAINT [FK_Table8_Table7] FOREIGN KEY([Table7AID],[Table7BID]) REFERENCES Table7 ([Table7AID],[Table7BID]) -- FK same order as PK, and same order in child
ALTER TABLE Table9 ADD CONSTRAINT [FK_Table9_Table7] FOREIGN KEY([Table7BID],[Table7AID]) REFERENCES Table7 ([Table7AID],[Table7BID]) -- FK same order as PK, but different order in child





select * from Table1
select * from Table2
select * from Table3
select * from Table4
select * from Table5

