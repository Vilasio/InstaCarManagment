CREATE SCHEMA InstaCar;

CREATE EXTENSION pgcrypto;

--*************************************************
-- alle drop statements
--*************************************************
ALTER TABLE InstaCar.car DROP CONSTRAINT car_locaton_fk;
ALTER TABLE InstaCar.car DROP CONSTRAINT car_price_fk;
ALTER TABLE InstaCar.rent DROP CONSTRAINT rent_car_fk;
ALTER TABLE InstaCar.rent DROP CONSTRAINT rent_customer_fk;

DROP SEQUENCE InstaCar.customer_seq;
DROP SEQUENCE InstaCar.account_seq;
DROP SEQUENCE InstaCar.car_seq;
DROP SEQUENCE InstaCar.location_seq;
DROP SEQUENCE InstaCar.price_seq;
DROP SEQUENCE InstaCar.feature_seq;


DROP TABLE InstaCar.customer;
DROP TABLE InstaCar.account;
DROP TABLE InstaCar.car;
DROP TABLE InstaCar.location;
DROP TABLE InstaCar.feature;
DROP TABLE InstaCar.price;

--*************************************************
-- Customer
--*************************************************
CREATE TABLE InstaCar.customer
(
	customer_id			NUMERIC(10) not null,
	nickname			VARCHAR(250),
	name				VARCHAR(250),
	familyname			VARCHAR(250),
	street				VARCHAR(250),
	housenr				NUMERIC(5),
	postcode			VARCHAR(50),
	city				VARCHAR(250),
	password			VARCHAR(250),
	iban				VARCHAR(250),
	bic					VARCHAR(250),
	
	deleted				BOOLEAN,
	
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
	datebegin			TIMESTAMP with time zone,
	dateend				TIMESTAMP with time zone,
	sumprice			NUMERIC(8,2),
	priceperhour		NUMERIC(8,2),
	deleted				BOOLEAN,	
	
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
	price_id			NUMERIC(10) not null,
	modell				VARCHAR(250),
	brand				VARCHAR(250),
	hp					NUMERIC(4),
	feature1			NUMERIC(10),
	feature2			NUMERIC(10),
	feature3			NUMERIC(10),
	feature4			NUMERIC(10),
	notavailable		BOOLEAN,
	deleted				BOOLEAN,
	
	CONSTRAINT car_pk PRIMARY KEY (car_id)
	

);

CREATE SEQUENCE InstaCar.car_seq START WITH 1 INCREMENT BY 1;

--*************************************************
-- Price
--*************************************************

CREATE TABLE InstaCar.price
(
	price_id			NUMERIC(10) not null,
	priceclass			VARCHAR(5),
	priceperhour		NUMERIC(8,2),
	
	
	CONSTRAINT price_pk PRIMARY KEY (price_id)
	

);

CREATE SEQUENCE InstaCar.price_seq START WITH 1 INCREMENT BY 1;

--*************************************************
-- Feature
--*************************************************
CREATE TABLE InstaCar.feature
(
	feature_id			NUMERIC(10) not null,
	feature				VARCHAR(250),
	deleted				BOOLEAN,
	
	
	CONSTRAINT feature_pk PRIMARY KEY (feature_id)
	

);

CREATE SEQUENCE InstaCar.feature_seq START WITH 1 INCREMENT BY 1;

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

alter table InstaCar.car add constraint	  car_locaton_fk      foreign key (location_id) references InstaCar.location (location_id);
alter table InstaCar.car add constraint	  car_price_fk      foreign key (price_id) references InstaCar.price (price_id);
alter table InstaCar.rent add constraint	  rent_customer_fk      foreign key (customer_id) references InstaCar.customer (customer_id);
alter table InstaCar.rent add constraint	  rent_car_fk    foreign key (car_id) references InstaCar.car (car_id);

--*************************************************
-- Grants
--*************************************************
GRANT USAGE ON SCHEMA InstaCar TO clerk;
grant select, insert, update, delete on InstaCar.customer to clerk;
grant select, insert, update, delete on InstaCar.account to clerk;
grant select, insert, update, delete on InstaCar.car to clerk;
grant select, insert, update, delete on InstaCar.location to clerk;
grant select, insert, update, delete on InstaCar.price to clerk;
grant select, insert, update, delete on InstaCar.feature to clerk;


GRANT SELECT, USAGE ON SEQUENCE InstaCar.customer_seq to clerk;
GRANT SELECT, USAGE ON SEQUENCE InstaCar.account_seq to clerk;
GRANT SELECT, USAGE ON SEQUENCE InstaCar.car_seq to clerk;
GRANT SELECT, USAGE ON SEQUENCE InstaCar.location_seq to clerk;
GRANT SELECT, USAGE ON SEQUENCE InstaCar.price_seq to clerk;
GRANT SELECT, USAGE ON SEQUENCE InstaCar.feature_seq to clerk;

--*************************************************
-- TestDaten
--*************************************************

--Features
INSERT INTO InstaCar.feature (feature_id, feature, deleted) 
values((SELECT NEXTVAL('InstaCar.feature_seq')), "Keine", false);
INSERT INTO InstaCar.feature (feature_id, feature, deleted) 
values((SELECT NEXTVAL('InstaCar.feature_seq')), "Klimanalage", false);
INSERT INTO InstaCar.feature (feature_id, feature, deleted) 
values((SELECT NEXTVAL('InstaCar.feature_seq')), "Multinfunktionslenkrad", false);
INSERT INTO InstaCar.feature (feature_id, feature, deleted) 
values((SELECT NEXTVAL('InstaCar.feature_seq')), "Tempomat", false);
INSERT INTO InstaCar.feature (feature_id, feature, deleted) 
values((SELECT NEXTVAL('InstaCar.feature_seq')), "Entertainmentcenter", false);

--Prices
INSERT INTO InstaCar.price (price_id, priceclass, priceperhour) 
values((SELECT NEXTVAL('InstaCar.price_seq')), A, 50.00);
INSERT INTO InstaCar.price (price_id, priceclass, priceperhour) 
values((SELECT NEXTVAL('InstaCar.price_seq')), B, 40.00);
INSERT INTO InstaCar.price (price_id, priceclass, priceperhour) 
values((SELECT NEXTVAL('InstaCar.price_seq')), C, 30.00);
INSERT INTO InstaCar.price (price_id, priceclass, priceperhour) 
values((SELECT NEXTVAL('InstaCar.price_seq')), D, 20.00);

--Accounts
INSERT INTO InstaCar.account (account_id, username, password, role, tried, blocked) 
values((SELECT NEXTVAL('InstaCar.account_seq')), 'admin', CRYPT('admin', GEN_SALT('bf')), 1, 0, false);
INSERT INTO InstaCar.account (account_id, username, password, role, tried, blocked) 
values((SELECT NEXTVAL('InstaCar.account_seq')), 'clerk', CRYPT('clerk', GEN_SALT('bf')), 2, 0, false);

--*************************************************
-- Views
--*************************************************

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