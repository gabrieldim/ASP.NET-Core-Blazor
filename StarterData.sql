CREATE TABLE Car (
    id INT PRIMARY KEY,
    name VARCHAR(255),
    year INT,
    price INT,
    km FLOAT
);


INSERT INTO Car (id, name, year, price, km)
VALUES
    (1, 'Toyota', 2008, 6000, 205000),
    (2, 'Golf 5 Plus', 2009, 5000, 180000),
    (3, 'Citroen C4', 2006, 3800, 210000),
    (4, 'KIA', 2012, 5300, 165000),
    (5, 'Nissan', 2010, 4800, 170000),
    (6, 'Citroen C3', 2004, 3500, 193000),
    (7, 'BMW 5 Series', 2010, 21000, 183000),
    (8, 'BMW 4 Series', 2009, 17000, 230000),
    (9, 'BMW 3 Series', 2007, 14500, 183000);



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

