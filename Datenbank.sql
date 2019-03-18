CREATE SCHEMA InstaCar;

CREATE EXTENSION pgcrypto;

--*************************************************
-- alle drop statements
--*************************************************
ALTER TABLE InstaCar.rent DROP CONSTRAINT rent_car_fk;
ALTER TABLE InstaCar.rent DROP CONSTRAINT rent_customer_fk;

DROP SEQUENCE InstaCar.customer_seq;
DROP SEQUENCE InstaCar.account_seq;
DROP SEQUENCE InstaCar.car_seq;
DROP SEQUENCE InstaCar.location_seq;


DROP TABLE InstaCar.customer;
DROP TABLE InstaCar.account;
DROP TABLE InstaCar.car;
DROP TABLE InstaCar.location;

--*************************************************
-- Customer
--*************************************************
CREATE TABLE InstaCar.customer
(
	customer_id			NUMERIC(10) not null,
	name				VARCHAR(250),
	familyname			VARCHAR(250),
	street				VARCHAR(250),
	housenr				NUMERIC(5),
	postcode			VARCHAR(50),
	city				VARCHAR(250),
	
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
	units				NUMERIC(10),	
	
	CONSTRAINT rent_pk PRIMARY KEY (rent_id)
	

);

CREATE SEQUENCE InstaCar.rent_seq START WITH 1 INCREMENT BY 1;




--*************************************************
-- Cars
--*************************************************
CREATE TABLE InstaCar.car
(
	car_id				NUMERIC(10) not null,
	modell				VARCHAR(250),
	brand				VARCHAR(250),
	hp					NUMERIC(4),
	price				NUMERIC(8,2),
	feature1			VARCHAR(250),
	feature2			VARCHAR(250),
	feature3			VARCHAR(250),
	feature4			VARCHAR(250),
	notavailable		BOOLEAN,
	
	CONSTRAINT car_pk PRIMARY KEY (car_id)
	

);

CREATE SEQUENCE InstaCar.car_seq START WITH 1 INCREMENT BY 1;


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
	
	
	CONSTRAINT location_pk PRIMARY KEY (location_id)
	

);

CREATE SEQUENCE InstaCar.location_seq START WITH 1 INCREMENT BY 1;


--*************************************************
-- constraints
--*************************************************

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


GRANT SELECT, USAGE ON SEQUENCE InstaCar.customer_seq to clerk;
GRANT SELECT, USAGE ON SEQUENCE InstaCar.account_seq to clerk;
GRANT SELECT, USAGE ON SEQUENCE InstaCar.car_seq to clerk;
GRANT SELECT, USAGE ON SEQUENCE InstaCar.location_seq to clerk;

--*************************************************
-- TestDaten
--*************************************************

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