
create table Product
(
	Id int identity(1, 1) primary key,
	Name varchar(500) not null
)

create table Category
(
	Id int identity(1, 1) primary key,
	Name varchar(500) not null
)

create table ProductCategory
(
	Id int identity(1, 1) primary key,
	ProductId int not null,
	CategoryId int not null
)

go

insert Product values
('Машина'),
('Машина-амфибия'),
('Мотоцикл'),
('Танк'),
('Лодка'),
('Самолёт')

insert Category values
('Двухколёсные ТС'),
('Четырёхколесное ТС'),
('ТС для движения по земле'),
('ТС для движения по воде')

insert ProductCategory values
(1, 2), (1, 3),			--Машина
(2, 2), (2, 3), (2, 4),	--Машина-амфибия
(3, 1), (3, 3),			--Мотоцикл
(4, 3),					--Танк
(5, 4)					--Лодка

go

select
	p.Name [Название продукта],
	isnull(c.Name, '') [Категория]
from product p
left join productCategory pc on p.Id = pc.productId
left join category c on c.Id = pc.categoryId
order by p.Name, c.Name

drop table product
drop table category
drop table productCategory