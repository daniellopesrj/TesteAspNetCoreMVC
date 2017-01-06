create table users
(
	id int not null identity,
	login varchar(20) not null,
	password varchar(10) not null,
	createdatetime datetime not null,
	name varchar(100) not null,
	email varchar(100) not null,
	address varchar(100) null,
	birthdate date
);

GO

alter table users add constraint PK_USER primary key id

GO

