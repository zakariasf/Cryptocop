﻿CREATE TABLE Users(
	id serial PRIMARY KEY,
	fullName character varying NOT NULL,
	email character varying UNIQUE NOT NULL,
	hashedPassword character varying NOT NULL
);

CREATE TABLE Addresses(
	id serial PRIMARY KEY,
	userId int not null,
	streetName character varying NOT NULL,
	houseNumber character varying Not NULL,
	ZipCode character varying not null,
	country character varying not null,
	city character varying not null,
	FOREIGN KEY(userId) REFERENCES Users(id)
);

CREATE TABLE JwTokens(
	id serial PRIMARY KEY,
    Blacklisted boolean NOT NULL
);


CREATE TABLE Orders(
	id serial PRIMARY KEY,
	Email character varying NOT NULL,
	FullName character varying NOT NULL,
	streetName character varying NOT NULL,
	HouseNumber character varying NOT NULL,
	ZipCode character varying NOT NULL,
	Country character varying NOT NULL,
	City character varying NOT NULL,
	CardHolderName character varying NOT NULL,
	MaskedCreditCard character varying NOT NULL,
	orderDate date NOT NULL,
	totalPrice real NOT NULL,
);


CREATE TABLE OrderItems(
	id serial PRIMARY KEY,
	orderId int NOT NULL,
	productIdentifier character varying NOT NULL,
	quantity real NOT NULL,
	UnitPrice real NOT NULL,
	TotalPrice real NOT NULL,
	FOREIGN KEY(OrderId) REFERENCES Orders(id)
);

CREATE TABLE PaymentCard(
	id serial PRIMARY KEY,
    userId int not null,
	cardholderName character varying NOT NULL,
	cardNumber character varying NOT NULL,
	month int NOT NULL,
	year int NOT NULL,
	FOREIGN KEY(userId) REFERENCES Users(id)
);



CREATE TABLE ShoppingCart(
	id serial PRIMARY KEY,
	userId int not null,
	FOREIGN KEY(userId) REFERENCES Users(id)
    
);


CREATE TABLE ShoppingCartItem(
	id serial PRIMARY KEY,
	shoppingCartId int not null,
	productIdentifier character varying NOT NULL,
	quantity real NOT NULL,
	unitPrice real NOT NULL,
	FOREIGN KEY(shoppingCartId) REFERENCES ShoppingCart(id)
    
);


        



		
