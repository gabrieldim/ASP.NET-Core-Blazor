CREATE TABLE Car (
    name VARCHAR(255) PRIMARY KEY,
    year INT,
    price INT,
    km FLOAT
);

INSERT INTO Car (name, year, price, km)
VALUES
    ('Toyota', 2008, 6000, 205000),
    ('Golf 5 Plus', 2009, 5000, 180000),
    ('Citroen C4', 2006, 3800, 210000),
    ('KIA', 2012, 5300, 165000),
    ('Nissan', 2010, 4800, 170000),
    ('Citroen C3', 2004, 3500, 193000);


CREATE TABLE Revenue (
    year FLOAT PRIMARY KEY,
    amount FLOAT
);

INSERT INTO Revenue (year, amount)
VALUES
    (2018, 230000),
    (2019, 280000),
    (2020, 400000),
    (2021, 350000),
    (2022, 580000),
    (2023, 480000);


CREATE TABLE Contact (
    firstName VARCHAR(255),
    lastName VARCHAR(255),
    email VARCHAR(255)
);


INSERT INTO Contact (firstName, lastName, email)
VALUES
    ('John', 'Smith', 'john.smith@example.com'),
    ('Emma', 'Johnson', 'emma.johnson@example.com'),
    ('Michael', 'Davis', 'michael.davis@example.com'),
	('Nicola', 'Williams', 'nicola.williams@example.com');


SELECT * FROM Car
SELECT * FROM Contact
SELECT * FROM Revenue

