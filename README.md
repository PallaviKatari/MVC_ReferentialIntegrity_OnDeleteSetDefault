# MVC_ReferentialIntegrity_OnDeleteSetDefault
use EntityFramework

create table Employee (
EId int primary key identity(1,1),
EName varchar(20),
EDesignation varchar(20),
DepId int default 1 constraint FK__Employee__DepId foreign key(DepId) references Department(DepId) on delete set default ,
ESalary int ,
EImage varbinary(max)
)

create table Department (
DepId int primary key identity(1,1),
DName varchar(20),
IsDeleted  bit not null default 0
)
insert into Department values ('DOT NET' ,0),('PHP' ,0),('REACT',0)
