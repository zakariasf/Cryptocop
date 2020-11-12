CREATE TABLE Users(
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