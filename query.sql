
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
('������'),
('������-�������'),
('��������'),
('����'),
('�����'),
('������')

insert Category values
('����������� ��'),
('�������������� ��'),
('�� ��� �������� �� �����'),
('�� ��� �������� �� ����')

insert ProductCategory values
(1, 2), (1, 3),			--������
(2, 2), (2, 3), (2, 4),	--������-�������
(3, 1), (3, 3),			--��������
(4, 3),					--����
(5, 4)					--�����

go

select
	p.Name [�������� ��������],
	isnull(c.Name, '') [���������]
from product p
left join productCategory pc on p.Id = pc.productId
left join category c on c.Id = pc.categoryId
order by p.Name, c.Name

drop table product
drop table category
drop table productCategory