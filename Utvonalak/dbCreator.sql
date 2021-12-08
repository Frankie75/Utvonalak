create table turazo (
id				int primary key,
vezeteknev		varchar(30),
keresztnev		varchar(30),
varos			varchar(50),
telefonszam		varchar(11) );

create table utvonal (
id				int primary key identity,
turazoID		int,
honnan			varchar(50),
hova			varchar(50),
km				int,
foreign key (turazoID) references turazo );

