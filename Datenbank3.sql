CREATE SCHEMA InstaCar;

CREATE EXTENSION pgcrypto;

--*************************************************
-- alle drop statements
--*************************************************
ALTER TABLE InstaCar.rent DROP CONSTRAINT rent_car_fk;
ALTER TABLE InstaCar.rent DROP CONSTRAINT rent_customer_fk;
ALTER TABLE InstaCar.car DROP CONSTRAINT car_location_fk;
ALTER TABLE InstaCar.image DROP CONSTRAINT image_car_fk;

DROP SEQUENCE InstaCar.customer_seq;
DROP SEQUENCE InstaCar.account_seq;
DROP SEQUENCE InstaCar.rent_seq;
DROP SEQUENCE InstaCar.car_seq;
DROP SEQUENCE InstaCar.feature_seq;
DROP SEQUENCE InstaCar.image_seq;
DROP SEQUENCE InstaCar.location_seq;


DROP TABLE InstaCar.customer;
DROP TABLE InstaCar.account;
DROP TABLE InstaCar.rent;
DROP TABLE InstaCar.car;
DROP TABLE InstaCar.feature;
DROP TABLE InstaCar.image;
DROP TABLE InstaCar.location;

--*************************************************
-- Customer
--*************************************************
CREATE TABLE InstaCar.customer
(
	customer_id			NUMERIC(10) not null,
	customer_no			VARCHAR(250) not null,
	name				VARCHAR(250),
	familyname			VARCHAR(250),
	street				VARCHAR(250),
	housenr				NUMERIC(5),
	postcode			VARCHAR(50),
	city				VARCHAR(250),
	email				VARCHAR(250),
	telefon				VARCHAR(250),
	iban				VARCHAR(250),
	bic					VARCHAR(250),
	
	password			VARCHAR(250),
	nickname			VARCHAR(250),
	
	deleted				BOOLEAN,
	
	CONSTRAINT customer_no_uk UNIQUE (customer_no),
	CONSTRAINT costumer_pk PRIMARY KEY (customer_id)
	

);

CREATE SEQUENCE InstaCar.customer_seq START WITH 1 INCREMENT BY 1;
--*************************************************
-- Accounts
--*************************************************
CREATE TABLE InstaCar.account
(
	account_id			NUMERIC(10) not null,
	username			VARCHAR(250) not null unique,
	password			VARCHAR(250) not null,
	role				NUMERIC(1),
	tried				NUMERIC(1),
	blocked				BOOLEAN,
	
	deleted				BOOLEAN,

	
	
	CONSTRAINT account_pk PRIMARY KEY (account_id)
	

);

CREATE SEQUENCE InstaCar.account_seq START WITH 1 INCREMENT BY 1;

--*************************************************
-- Rent
--*************************************************
CREATE TABLE InstaCar.rent
(
	rent_id				NUMERIC(10) not null,
	customer_id			NUMERIC(10) not null,
	car_id				NUMERIC(10) not null,
	rent_no				VARCHAR(250) not null,
	datebegin			TIMESTAMP with time zone,
	dateend				TIMESTAMP with time zone,
	sumprice			NUMERIC(8,2),
	hours				NUMERIC(10),
	priceperhour		NUMERIC(8,2),
	deleted				BOOLEAN,
	
	CONSTRAINT rent_no_uk UNIQUE (rent_no),
	CONSTRAINT rent_pk PRIMARY KEY (rent_id)
	

);

CREATE SEQUENCE InstaCar.rent_seq START WITH 1 INCREMENT BY 1;




--*************************************************
-- Cars
--*************************************************
CREATE TABLE InstaCar.car
(
	car_id				NUMERIC(10) not null,
	location_id			NUMERIC(10) not null,
	modell				VARCHAR(250),
	brand				VARCHAR(250),
	hp					NUMERIC(4),
	price				NUMERIC(8,2),
	feature1			NUMERIC(2),
	feature2			NUMERIC(2),
	feature3			NUMERIC(2),
	feature4			NUMERIC(2),
	notavailable		BOOLEAN,
	reserved			TIMESTAMP with time zone,
	in_use				BOOLEAN,
	locked				BOOLEAN,
	deleted				BOOLEAN,
	
	CONSTRAINT car_pk PRIMARY KEY (car_id)
	

);

CREATE SEQUENCE InstaCar.car_seq START WITH 1 INCREMENT BY 1;

--*************************************************
-- Feature
--*************************************************
CREATE TABLE InstaCar.feature
(
	feature_id				NUMERIC(10) not null,
	featurename				VARCHAR(250),
	

	CONSTRAINT feature_pk PRIMARY KEY (feature_id)
	

);

CREATE SEQUENCE InstaCar.feature_seq START WITH 1 INCREMENT BY 1;



--*************************************************
-- Images
--*************************************************
CREATE TABLE InstaCar.image
(
	image_id			NUMERIC(10) not null,
	car_id				NUMERIC(10) not null,
	picture				Bytea,
	kind				VARCHAR(250),
	main				BOOLEAN,
	description			VARCHAR(1000),
	accident			BOOLEAN,
	
	CONSTRAINT image_pk PRIMARY KEY (image_id)
	

);

CREATE SEQUENCE InstaCar.image_seq START WITH 1 INCREMENT BY 1;

--*************************************************
-- Locations
--*************************************************
CREATE TABLE InstaCar.location
(
	location_id			NUMERIC(10) not null,
	name				VARCHAR(250),
	street				VARCHAR(250),
	housenr				NUMERIC(5),
	postcode			VARCHAR(50),
	city				VARCHAR(250),
	
	deleted				BOOLEAN,
	
	
	CONSTRAINT location_pk PRIMARY KEY (location_id)
	

);

CREATE SEQUENCE InstaCar.location_seq START WITH 1 INCREMENT BY 1;


--*************************************************
-- constraints
--*************************************************

alter table InstaCar.car add constraint	  car_location_fk      foreign key (location_id) references InstaCar.location (location_id);
alter table InstaCar.rent add constraint	  rent_customer_fk      foreign key (customer_id) references InstaCar.customer (customer_id);
alter table InstaCar.rent add constraint	  rent_car_fk    foreign key (car_id) references InstaCar.car (car_id);
alter table InstaCar.image add constraint	  image_car_fk    foreign key (car_id) references InstaCar.car (car_id);

--*************************************************
-- Grants
--*************************************************
GRANT USAGE ON SCHEMA InstaCar TO clerk;
grant select, insert, update, delete on InstaCar.customer to clerk;
grant select, insert, update, delete on InstaCar.account to clerk;
grant select, insert, update, delete on InstaCar.car to clerk;
grant select, insert, update, delete on InstaCar.feature to clerk;
grant select, insert, update, delete on InstaCar.image to clerk;
grant select, insert, update, delete on InstaCar.location to clerk;
grant select, insert, update, delete on InstaCar.rent to clerk;


GRANT SELECT, USAGE ON SEQUENCE InstaCar.customer_seq to clerk;
GRANT SELECT, USAGE ON SEQUENCE InstaCar.account_seq to clerk;
GRANT SELECT, USAGE ON SEQUENCE InstaCar.car_seq to clerk;
GRANT SELECT, USAGE ON SEQUENCE InstaCar.feature_seq to clerk;
GRANT SELECT, USAGE ON SEQUENCE InstaCar.image_seq to clerk;
GRANT SELECT, USAGE ON SEQUENCE InstaCar.location_seq to clerk;
GRANT SELECT, USAGE ON SEQUENCE InstaCar.rent_seq to clerk;

--*************************************************
-- TestDaten
--*************************************************
-- Account
INSERT INTO InstaCar.account (account_id, username, password, role, tried, blocked, deleted) values((SELECT NEXTVAL('InstaCar.account_seq')), 'admin', CRYPT('admin', GEN_SALT('bf')), 1, 0, false, false);
INSERT INTO InstaCar.account (account_id, username, password, role, tried, blocked, deleted) values((SELECT NEXTVAL('InstaCar.account_seq')), 'clerk', CRYPT('clerk', GEN_SALT('bf')), 2, 0, false, false);
-- Location
INSERT INTO InstaCar.location (location_id, name, street, housenr, postcode, city, deleted) values((SELECT NEXTVAL('InstaCar.location_seq')), 'In Benützung', 'Irgendwo', 1, '9999', 'Timbuktu', FALSE);
INSERT INTO InstaCar.location (location_id, name, street, housenr, postcode, city, deleted) values((SELECT NEXTVAL('InstaCar.location_seq')), 'Zentrale', 'Julius-Raab-Platz', 2, '5027', 'Salzburg', FALSE);
INSERT INTO InstaCar.location (location_id, name, street, housenr, postcode, city, deleted) values((SELECT NEXTVAL('InstaCar.location_seq')), 'Berufschulen', 'Schließstadtstraße', 7, '5020', 'Salzburg', FALSE);
INSERT INTO InstaCar.location (location_id, name, street, housenr, postcode, city, deleted) values((SELECT NEXTVAL('InstaCar.location_seq')), 'BFI', 'Schillerstraße', 26, '5020', 'Salzburg', FALSE);
INSERT INTO InstaCar.location (location_id, name, street, housenr, postcode, city, deleted) values((SELECT NEXTVAL('InstaCar.location_seq')), 'Warwitz', 'Warwitzstraße', 11, '5020', 'Salzburg', FALSE);
INSERT INTO InstaCar.location (location_id, name, street, housenr, postcode, city, deleted) values((SELECT NEXTVAL('InstaCar.location_seq')), 'Salzburger Hbf', 'Südtirolerplazu', 1, '5020', 'Salzburg', FALSE);
INSERT INTO InstaCar.location (location_id, name, street, housenr, postcode, city, deleted) values((SELECT NEXTVAL('InstaCar.location_seq')), 'Linzergasse', 'Glockengasse', 4, '5020', 'Salzburg', FALSE);
INSERT INTO InstaCar.location (location_id, name, street, housenr, postcode, city, deleted) values((SELECT NEXTVAL('InstaCar.location_seq')), 'LKH Salzburg', 'Rudolf Biebl Straße', 1, '5020', 'Salzburg', FALSE);
INSERT INTO InstaCar.location (location_id, name, street, housenr, postcode, city, deleted) values((SELECT NEXTVAL('InstaCar.location_seq')), 'Europark', 'Europastraße', 1, '5020', 'Salzburg', FALSE);
INSERT INTO InstaCar.location (location_id, name, street, housenr, postcode, city, deleted) values((SELECT NEXTVAL('InstaCar.location_seq')), 'Altstadt', 'Hildmannplatz', 1, '5020', 'Salzburg', FALSE);
INSERT INTO InstaCar.location (location_id, name, street, housenr, postcode, city, deleted) values((SELECT NEXTVAL('InstaCar.location_seq')), 'Alpenstraße', 'Alpenstraße', 67, '5020', 'Salzburg', FALSE);
-- Car
INSERT INTO InstaCar.car (car_id, location_id, modell, brand, hp, price, feature1, feature2, feature3, feature4, notavailable, in_use, locked, deleted) values((SELECT NEXTVAL('InstaCar.car_seq')),1 , '320i', 'BMW', 125, 20.00, 1,2,3,4, false, true, true, FALSE);                                 
INSERT INTO InstaCar.car (car_id, location_id, modell, brand, hp, price, feature1, feature2, feature3, feature4, notavailable, in_use, locked, deleted) values((SELECT NEXTVAL('InstaCar.car_seq')),2 , '520e', 'BMW', 200, 20.00, 1,2,3,4, false, true, true, FALSE);                                 
INSERT INTO InstaCar.car (car_id, location_id, modell, brand, hp, price, feature1, feature2, feature3, feature4, notavailable, in_use, locked, deleted) values((SELECT NEXTVAL('InstaCar.car_seq')),3 , 'A3', 'Audi', 130, 20.00, 1,2,3,4, false, true, true, FALSE);                                  
INSERT INTO InstaCar.car (car_id, location_id, modell, brand, hp, price, feature1, feature2, feature3, feature4, notavailable, in_use, locked, deleted) values((SELECT NEXTVAL('InstaCar.car_seq')),4 , 'Ocatvia', 'Skoda', 150, 20.00, 1,2,3,4, false, false, true, FALSE);                           
INSERT INTO InstaCar.car (car_id, location_id, modell, brand, hp, price, feature1, feature2, feature3, feature4, notavailable, in_use, locked, deleted) values((SELECT NEXTVAL('InstaCar.car_seq')),5 , 'Passat', 'Vw', 145, 20.00, 1,2,3,4, false, false, true, FALSE);                               
INSERT INTO InstaCar.car (car_id, location_id, modell, brand, hp, price, feature1, feature2, feature3, feature4, notavailable, in_use, locked, deleted) values((SELECT NEXTVAL('InstaCar.car_seq')),6 , 'A6', 'Audi', 175, 20.00, 1,2,3,4, false, false, true, FALSE);                                 
INSERT INTO InstaCar.car (car_id, location_id, modell, brand, hp, price, feature1, feature2, feature3, feature4, notavailable, in_use, locked, deleted) values((SELECT NEXTVAL('InstaCar.car_seq')),7 , 'Golf Kombi', 'Vw', 140, 20.00, 1,2,3,4, false, false, true, FALSE);                           
INSERT INTO InstaCar.car (car_id, location_id, modell, brand, hp, price, feature1, feature2, feature3, feature4, notavailable, in_use, locked, deleted) values((SELECT NEXTVAL('InstaCar.car_seq')),8 , 'Focus Kombi', 'Ford', 130, 20.00, 1,2,3,4, false, false, true, FALSE);                        
INSERT INTO InstaCar.car (car_id, location_id, modell, brand, hp, price, feature1, feature2, feature3, feature4, notavailable, in_use, locked, deleted) values((SELECT NEXTVAL('InstaCar.car_seq')),9 , 'Astra Kombi', 'Opel', 120, 20.00, 1,2,3,4, false, false, true, FALSE);                        
INSERT INTO InstaCar.car (car_id, location_id, modell, brand, hp, price, feature1, feature2, feature3, feature4, notavailable, in_use, locked, deleted) values((SELECT NEXTVAL('InstaCar.car_seq')),10 , 'E300', 'Mercedes Benz', 125, 20.00, 1,2,3,4, false, false, true, FALSE);

-- Feature
INSERT INTO InstaCar.feature (feature_id, featurename) values((SELECT NEXTVAL('InstaCar.feature_seq')),'Kein');
INSERT INTO InstaCar.feature (feature_id, featurename) values((SELECT NEXTVAL('InstaCar.feature_seq')),'Klimanlage');
INSERT INTO InstaCar.feature (feature_id, featurename) values((SELECT NEXTVAL('InstaCar.feature_seq')),'Tempomat');
INSERT INTO InstaCar.feature (feature_id, featurename) values((SELECT NEXTVAL('InstaCar.feature_seq')),'Mediacaenter');
INSERT INTO InstaCar.feature (feature_id, featurename) values((SELECT NEXTVAL('InstaCar.feature_seq')),'Ledersitze');
-- Customer
INSERT INTO InstaCar.customer (customer_id, customer_no, name, familyname, street, housenr, postcode, city, email, telefon, iban, bic, password, nickname, deleted) values((SELECT NEXTVAL('InstaCar.customer_seq')), '2019/000001','Thomas', 'Müller', 'Mayerstraße', 1, '5020', 'Salzburg', 'Example@gmail.com', '0664/1234567', 'AT1234456789', 'Bank123',CRYPT('1234', GEN_SALT('bf')), 'Tmueller' , FALSE);
INSERT INTO InstaCar.customer (customer_id, customer_no, name, familyname, street, housenr, postcode, city, email, telefon, iban, bic, password, nickname, deleted) values((SELECT NEXTVAL('InstaCar.customer_seq')), '2019/000002','Herbert', 'Maier', 'Müllerstraße', 23, '5020', 'Salzburg', 'Example@gmail.com', '0664/1234567','AT1234456789', 'Bank123',CRYPT('1234', GEN_SALT('bf')), 'Hmaier' , FALSE);
INSERT INTO InstaCar.customer (customer_id, customer_no, name, familyname, street, housenr, postcode, city, email, telefon, iban, bic, password, nickname, deleted) values((SELECT NEXTVAL('InstaCar.customer_seq')), '2019/000003','Ingrid', 'Mannsn', 'Mayerstraße', 1, '5020', 'Salzburg', 'Example@gmail.com', '0664/1234567','AT1234456789', 'Bank123',CRYPT('1234', GEN_SALT('bf')), 'Imannss' , FALSE);
INSERT INTO InstaCar.customer (customer_id, customer_no, name, familyname, street, housenr, postcode, city, email, telefon, iban, bic, password, nickname, deleted) values((SELECT NEXTVAL('InstaCar.customer_seq')), '2019/000004','Brigitte', 'Falken', 'Mayerstraße', 1, '5020', 'Salzburg', 'Example@gmail.com', '0664/1234567','AT1234456789', 'Bank123',CRYPT('1234', GEN_SALT('bf')), 'Bfalken' , FALSE);
INSERT INTO InstaCar.customer (customer_id, customer_no, name, familyname, street, housenr, postcode, city, email, telefon, iban, bic, password, nickname, deleted) values((SELECT NEXTVAL('InstaCar.customer_seq')), '2019/000005','Rudolf', 'Bayer', 'Mayerstraße', 1, '5020', 'Salzburg', 'Example@gmail.com', '0664/1234567','AT1234456789', 'Bank123',CRYPT('1234', GEN_SALT('bf')), 'Rbayer' , FALSE);
-- Rent
INSERT INTO InstaCar.rent (rent_id, customer_id, car_id, rent_no, datebegin, priceperhour, deleted) values((SELECT NEXTVAL('InstaCar.rent_seq')),1 , 1, '2019/03/000001', CURRENT_TIMESTAMP, 20.00, FALSE);
INSERT INTO InstaCar.rent (rent_id, customer_id, car_id, rent_no, datebegin, priceperhour, deleted) values((SELECT NEXTVAL('InstaCar.rent_seq')),2 , 2, '2019/03/000002', CURRENT_TIMESTAMP, 20.00, FALSE);
INSERT INTO InstaCar.rent (rent_id, customer_id, car_id, rent_no, datebegin, priceperhour, deleted) values((SELECT NEXTVAL('InstaCar.rent_seq')),3 , 3, '2019/03/000003', CURRENT_TIMESTAMP, 20.00, FALSE);

--*************************************************
-- Views
--*************************************************
CREATE VIEW get_rent as
Select 
	account_id,
	username,
	role,
	tried,
	blocked
from 
	InstaCar.account;


CREATE VIEW get_all_accounts as
Select 
	account_id,
	username,
	role,
	tried,
	blocked
from 
	InstaCar.account;


--*************************************************
-- otherstuff
--*************************************************
CREATE USER clerk WITH
	LOGIN
	NOSUPERUSER
	NOCREATEDB
	NOCREATEROLE
	INHERIT
	NOREPLICATION
	CONNECTION LIMIT -1;