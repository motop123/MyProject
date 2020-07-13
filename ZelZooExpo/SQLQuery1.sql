﻿create table Страна
(
ID_Страны int not null,
Название nvarchar(20) not null,
constraint PK_ID_Страны primary key (ID_Страны)
)
create table Награды
 (
 ID_Награды int not null,
 Наименование nvarchar(100) not null,
 Количество_животных_получивших_награду int null,
 constraint PK_ID_Награды primary key (ID_Награды)
 )
 create table ОтчегоПрививка
(
ID_отЧего int not null,
Прививка_от nvarchar(20) not null,
constraint PK_ID_отЧего primary key (ID_отЧего)
)
 -- drop table ОтчегоПрививка
 create table Прививка
(
ID_прив int not null,
Название_прививки nvarchar(20) not null,
Страна_производитель nvarchar(20) not null,
Количество_привитых int null,
constraint PK_ID_прив primary key (ID_прив)
)
-- drop table Прививка
create table Место_размещения_электронного_чипа
(
ID_Место int not null,
Где nvarchar(20) not null,
constraint PK_ID_Место primary key (ID_Место)
)
-- drop table Место_размещения_электронного_чипа

create table Породы
(
ID_Породы int not null,
Название nvarchar(20) not null,
constraint PK_ID_Породы primary key (ID_Породы)
)
 --drop table Пароды

create table Владельцы
(
ID_Владельца int not null,
ФИО nvarchar(30) not null,
Дата_рождения date not null,
Страна int not null,
Город nvarchar(20) not null,
Улица nvarchar(20) not null,
Номер_дома int not null,
constraint PK_ID_Владельца primary key (ID_Владельца),
constraint FK_Страна foreign key (Страна) references Страна(ID_Страны)
)
--drop table Владельцы

create table Паспорт_животного
(
ID_Животного int not null,
Владелец int not null,
Номер_родословной int not null,
Кличка nvarchar(20) not null,
Порода int not null,
Дата_рождения date not null,
Группа nvarchar(20) not null,
Окрас nvarchar(20) not null,
Пол nvarchar(1) not null,
Имя_мамы nvarchar(20) not null,
Имя_папы nvarchar(20) not null,
Номер_чипа int not null,
Дата_имплантации date not null,
Место_размещения int not null,
constraint PK_ID_Животного primary key (ID_Животного),
constraint FK_Владелец foreign key (Владелец) references Владельцы(ID_Владельца),
constraint FK_Порода foreign key (Порода) references Породы(ID_Породы),
constraint FK_Место_размещения foreign key (Место_размещения) references Место_размещения_электронного_чипа(ID_Место)
)
-- drop table Паспорт_животного

create table Получение_награды
(
ID_Получ int not null,
Кличка_животного int not null,
Наименование_награды int not null,
Дата_получения date not null,
Прошлая_дата_получения date not null,
constraint PK_ID_Получ primary key (ID_Получ),
constraint FK_Кличка_животного foreign key (Кличка_животного) references Паспорт_животного(ID_Животного),
constraint FK_Наименование_награды foreign key (Наименование_награды) references Награды(ID_Награды)
)
--drop table Получение_награды

create table Ветеринарное_свидетельство
(
ID_Вет int not null,
Имя_животного int not null,
Наименование_прививки int not null,
Привика_от int not null,
Дата_принятия date not null,
Срок_действия_прививки date not null,
Имя_картинки nvarchar(20) not null,
Формат_картинки nvarchar(4) not null,
constraint PK_ID_Вет primary key (ID_Вет),
constraint FK_Имя_животного foreign key (Имя_животного) references Паспорт_животного(ID_Животного),
constraint FK_Наименование_прививки foreign key (Наименование_прививки) references Прививка(ID_прив),
constraint FK_Привика_от foreign key (Привика_от) references ОтчегоПрививка(ID_отЧего)
)
--drop table Ветеринарное_свидетельство
select * from Награды

Create trigger trigger_add_info_NAGRAD
on Получение_награды
for insert
as
update Награды
set Количество_животных_получивших_награду = s.Количество_животных_получивших_награду +1
from Награды s join
inserted i 
on s.ID_Награды = i.Наименование_награды

Create trigger trigger_del_info_NAGRAD
on Получение_награды
for delete
as
update Награды
set Количество_животных_получивших_награду = s.Количество_животных_получивших_награду -1
from Награды s join
deleted d 
on s.ID_Награды = d.Наименование_награды

Create trigger trigger_add_info_PRIV
on Ветеринарное_свидетельство
for insert
as
update Прививка
set Количество_привитых = s.Количество_привитых +1
from Прививка s join
inserted i 
on s.ID_прив = i.Наименование_прививки

Create trigger trigger_del_info_PRIV
on Ветеринарное_свидетельство
for delete
as
update Прививка
set Количество_привитых = s.Количество_привитых -1
from Прививка s join
deleted d 
on s.ID_прив = d.Наименование_прививки
/*заполнение таблицы Страна*/

insert into Страна(ID_Страны, Название)
values (1,N'Беларусь')
insert into Страна(ID_Страны, Название)
values (2,N'Россия')
insert into Страна(ID_Страны, Название)
values (3,N'Польша')
insert into Страна(ID_Страны, Название)
values (4,N'Германия')
insert into Страна(ID_Страны, Название)
values (5,N'Латвия')

/*заполнение таблицы Награды*/
insert into Награды(ID_Награды,Наименование,Количество_животных_получивших_награду)
values (1,N'Награда за хорошее выполнение команд',0)
insert into Награды(ID_Награды,Наименование,Количество_животных_получивших_награду)
values (2,N'Награда за лучший номер',0)
insert into Награды(ID_Награды,Наименование,Количество_животных_получивших_награду)
values (3,N'Награда за быстрое преодоление препятствий',0)
insert into Награды(ID_Награды,Наименование,Количество_животных_получивших_награду)
values (4,N'Лучший щенок породы',0)
insert into Награды(ID_Награды,Наименование,Количество_животных_получивших_награду)
values (5,N'Лучший кот породы',0)
insert into Награды(ID_Награды,Наименование,Количество_животных_получивших_награду)
values (6,N'Лучший юниор',0)
insert into Награды(ID_Награды,Наименование,Количество_животных_получивших_награду)
values (7,N'Лучший юниор породы',0)
insert into Награды(ID_Награды,Наименование,Количество_животных_получивших_награду)
values (8,N'Победитель класса',0)
insert into Награды(ID_Награды,Наименование,Количество_животных_получивших_награду)
values (9,N'Лучший ветеран',0)
insert into Награды(ID_Награды,Наименование,Количество_животных_получивших_награду)
values (10,N'Лучший ветеран породы',0)
insert into Награды(ID_Награды,Наименование,Количество_животных_получивших_награду)
values (11,N'Лучшая сука породы',0)
insert into Награды(ID_Награды,Наименование,Количество_животных_получивших_награду)
values (12,N'Лучший кобель породы',0)
insert into Награды(ID_Награды,Наименование,Количество_животных_получивших_награду)
values (13,N'Лучший представитель породы',0)
insert into Награды(ID_Награды,Наименование,Количество_животных_получивших_награду)
values (14,N'Лучший в группе',0)
insert into Награды(ID_Награды,Наименование,Количество_животных_получивших_награду)
values (15,N'Лучшая собака выставки',0)
insert into Награды(ID_Награды,Наименование,Количество_животных_получивших_награду)
values (16,N'Лучшая кошка выставки',0)
insert into Награды(ID_Награды,Наименование,Количество_животных_получивших_награду)
values (17,N'Награда за красоту  породы',0)
insert into Награды(ID_Награды,Наименование,Количество_животных_получивших_награду)
values (18,N'Награда за милату породы',0)
insert into Награды(ID_Награды,Наименование,Количество_животных_получивших_награду)
values (19,N'Награда за милату котят',0)
insert into Награды(ID_Награды,Наименование,Количество_животных_получивших_награду)
values (20,N'Награда за милату щенят',0)
/*заполенеие таблицы  отчего прививка*/

insert into ОтчегоПрививка(ID_отЧего,Прививка_от)
values (1,N'Эхинококкоза')
insert into ОтчегоПрививка(ID_отЧего,Прививка_от)
values (2,N'Клещей')
insert into ОтчегоПрививка(ID_отЧего,Прививка_от)
values (3,N'Гриппа')
insert into ОтчегоПрививка(ID_отЧего,Прививка_от)
values (4,N'Бешенства')
insert into ОтчегоПрививка(ID_отЧего,Прививка_от)
values (5,N'Лептоспироза')
insert into ОтчегоПрививка(ID_отЧего,Прививка_от)
values (6,N' Чумы')
insert into ОтчегоПрививка(ID_отЧего,Прививка_от)
values (7,N' Панлейкопении')
insert into ОтчегоПрививка(ID_отЧего,Прививка_от)
values (8,N' Энтерита')
/*Заполнение таблицы Прививка*/
insert into Прививка(ID_прив,Название_прививки,Страна_производитель,Количество_привитых)
values (1,N'Анти-Эхинококк',N'Россия',0)
insert into Прививка(ID_прив,Название_прививки,Страна_производитель,Количество_привитых)
values (2,N'ЭнцеВир',N'Россия',0)
insert into Прививка(ID_прив,Название_прививки,Страна_производитель,Количество_привитых)
values (3,N'Анти-грипп',N'Россия',0)
insert into Прививка(ID_прив,Название_прививки,Страна_производитель,Количество_привитых)
values (4,N'Nobivac Rabies',N'Голландия',0)
insert into Прививка(ID_прив,Название_прививки,Страна_производитель,Количество_привитых)
values (5,N'Nobivac L',N'Голландия',0)
insert into Прививка(ID_прив,Название_прививки,Страна_производитель,Количество_привитых)
values (6,N'Nobivac DH',N'Голландия',0)
insert into Прививка(ID_прив,Название_прививки,Страна_производитель,Количество_привитых)
values (7,N'Мультифел-4',N'Россия',0)
insert into Прививка(ID_прив,Название_прививки,Страна_производитель,Количество_привитых)
values (8,N'Nobivac Puppy DP',N'Голландия',0)

/*Заполнение таблицы Место_размещения_электронного_чипа*/

insert into Место_размещения_электронного_чипа(ID_Место,Где)
values (1,N'Шея')
insert into Место_размещения_электронного_чипа(ID_Место,Где)
values (2,N'Крестцовая область')
insert into Место_размещения_электронного_чипа(ID_Место,Где)
values (3,N'Между лопатками')

/*Заполнение таблицы пароды*/

insert into Породы(ID_Породы,Название)
Values (1,N'Акита-ину')
insert into Породы(ID_Породы,Название)
Values (2,N'Бигль')
insert into Породы(ID_Породы,Название)
Values (3,N'Бладхаунд')
insert into Породы(ID_Породы,Название)
Values (4,N'Боксёр')
insert into Породы(ID_Породы,Название)
Values (5,N'Кавказкая овчарка')
insert into Породы(ID_Породы,Название)
Values (6,N'Лабрадор')
insert into Породы(ID_Породы,Название)
Values (7,N'Немецкая_овчарка')
insert into Породы(ID_Породы,Название)
Values (8,N'Такса')
insert into Породы(ID_Породы,Название)
Values (9,N'Ротвейлер')
insert into Породы(ID_Породы,Название)
Values (10,N'Пудель')
insert into Породы(ID_Породы,Название)
Values (11,N'Мэйн-кун')
insert into Породы(ID_Породы,Название)
Values (12,N'Ашера')
insert into Породы(ID_Породы,Название)
Values (13,N'Бурмила')
insert into Породы(ID_Породы,Название)
Values (14,N'Корат')
insert into Породы(ID_Породы,Название)
Values (15,N'Саванна')
insert into Породы(ID_Породы,Название)
Values (16,N'Тойгер')
insert into Породы(ID_Породы,Название)
Values (17,N'Сноу шу')
insert into Породы(ID_Породы,Название)
Values (18,N'Оцикет')
insert into Породы(ID_Породы,Название)
Values (19,N'Манчкин')
insert into Породы(ID_Породы,Название)
Values (20,N'Ориентальная кошка')

/*Заполнение таблицы Владельцы*/

insert into Владельцы(ID_Владельца,ФИО,Дата_рождения,Страна,Город,Улица,Номер_дома) /*ZAPOLNENO*/
values (1,N'Зеленко Д.А.','2000-07-17',1,N'Минск',N'Аэродромная',40)

insert into Владельцы(ID_Владельца,ФИО,Дата_рождения,Страна,Город,Улица,Номер_дома)
values (2,N'Прокопчик Н.С','2000-05-22',1,N'Минск',N'Аэродромная',34)

insert into Владельцы(ID_Владельца,ФИО,Дата_рождения,Страна,Город,Улица,Номер_дома)
values (3,N'Суходольский А.А','2000-05-08',1,N'Заславль',N'Советская',15)

insert into Владельцы(ID_Владельца,ФИО,Дата_рождения,Страна,Город,Улица,Номер_дома)
values (4,N'Камран В.Р.','2000-05-05',1,N'Минск',N'Козлова',31)

insert into Владельцы(ID_Владельца,ФИО,Дата_рождения,Страна,Город,Улица,Номер_дома)
values (5,N'Васильев Н.В.','1998-01-21',2,N'Москва',N'Вавилова',81)

insert into Владельцы(ID_Владельца,ФИО,Дата_рождения,Страна,Город,Улица,Номер_дома)
values (6,N'Михайлов А.Д.','1978-12-12',2,N'Москва',N'Доватора',8)

insert into Владельцы(ID_Владельца,ФИО,Дата_рождения,Страна,Город,Улица,Номер_дома)
values (7,N'Зайцева Е.С.','1995-01-13',2,N'Тула',N'Мосина',24)

insert into Владельцы(ID_Владельца,ФИО,Дата_рождения,Страна,Город,Улица,Номер_дома)
values (8,N'Крылова А.Д.','1996-11-25',2,N'Тула',N'Ленина',26)

insert into Владельцы(ID_Владельца,ФИО,Дата_рождения,Страна,Город,Улица,Номер_дома)
values (9,N'Новак В.М.','1990-06-14',3,N'Варшава',N'Торуньская',15)

insert into Владельцы(ID_Владельца,ФИО,Дата_рождения,Страна,Город,Улица,Номер_дома)
values (10,N'Возняк М.К.','1989-06-24',3,N'Варшава',N'Гручевская',34)

insert into Владельцы(ID_Владельца,ФИО,Дата_рождения,Страна,Город,Улица,Номер_дома)
values (11,N'Возняк М.К.','1989-06-24',3,N'Варшава',N'Гручевская',34)

insert into Владельцы(ID_Владельца,ФИО,Дата_рождения,Страна,Город,Улица,Номер_дома)
values (12,N'Шиманьский С.В.','1991-02-15',3,N'Белосток',N'Молодых',12)

insert into Владельцы(ID_Владельца,ФИО,Дата_рождения,Страна,Город,Улица,Номер_дома)
values (13,N'Шмидт П.Ф.','1991-02-15',4,N'Берлин',N'Митте',15)

insert into Владельцы(ID_Владельца,ФИО,Дата_рождения,Страна,Город,Улица,Номер_дома)
values (14,N'Шнайдер С.П.','1988-03-16',4,N'Берлин',N'Панков',34)

insert into Владельцы(ID_Владельца,ФИО,Дата_рождения,Страна,Город,Улица,Номер_дома)
values (15,N'Вебер Х.К.','1980-01-20',4,N'Магдербург',N'Лостау',15)

insert into Владельцы(ID_Владельца,ФИО,Дата_рождения,Страна,Город,Улица,Номер_дома)
values (16,N'Гофман М.А.','1996-07-15',4,N'Магдербург',N'Холзвек',45)

insert into Владельцы(ID_Владельца,ФИО,Дата_рождения,Страна,Город,Улица,Номер_дома)
values (17,N'Берзиньш М.Я.','1979-07-25',5,N'Рига',N'Матиса',13)

insert into Владельцы(ID_Владельца,ФИО,Дата_рождения,Страна,Город,Улица,Номер_дома)
values (18,N'Калныньш И.В.','2000-04-12',5,N'Рига',N'Краста',28)

insert into Владельцы(ID_Владельца,ФИО,Дата_рождения,Страна,Город,Улица,Номер_дома)
values (19,N'Озолиньш М.А.','1999-11-11',5,N'Елгава',N'Ригас',55)

insert into Владельцы(ID_Владельца,ФИО,Дата_рождения,Страна,Город,Улица,Номер_дома)
values (20,N'Лиепиньш П.М.','1999-12-12',5,N'Елгава',N'Гарозас',14)

/*Заполнение таблицы  Паспорт_животного*/
insert into Паспорт_животного(ID_Животного,Номер_родословной,Владелец,Группа,Кличка,Порода,Дата_рождения,Окрас,Пол,Имя_мамы,Имя_папы,Дата_имплантации,Номер_чипа,Место_размещения)
values (1,20151,1,N'Собака',N'Шэрлок',1,'2012-05-05',N'Белый',N'М',N'Агата',N'Амур','2012-08-15',3245,1)

insert into Паспорт_животного(ID_Животного,Номер_родословной,Владелец,Группа,Кличка,Порода,Дата_рождения,Окрас,Пол,Имя_мамы,Имя_папы,Дата_имплантации,Номер_чипа,Место_размещения)
values (2,21547,2,N'Собака',N'Биг бэн',2,'2012-06-04',N'Чёрный',N'М',N'Бада',N'Рио','2012-10-10',3455,1)

insert into Паспорт_животного(ID_Животного,Номер_родословной,Владелец,Группа,Кличка,Порода,Дата_рождения,Окрас,Пол,Имя_мамы,Имя_папы,Дата_имплантации,Номер_чипа,Место_размещения)
values (3,26548,3,N'Собака',N'Бэн',3,'2013-04-07',N'Серый',N'М',N'Вайда',N'Нарзан','2013-10-10',4785,2)

insert into Паспорт_животного(ID_Животного,Номер_родословной,Владелец,Группа,Кличка,Порода,Дата_рождения,Окрас,Пол,Имя_мамы,Имя_папы,Дата_имплантации,Номер_чипа,Место_размещения)
values (4,24875,4,N'Собака',N'Мэрлин',4,'2013-10-17',N'Тёмно-серый',N'М',N'Волга',N'Пегас','2014-01-10',5548,2)

insert into Паспорт_животного(ID_Животного,Номер_родословной,Владелец,Группа,Кличка,Порода,Дата_рождения,Окрас,Пол,Имя_мамы,Имя_папы,Дата_имплантации,Номер_чипа,Место_размещения)
values (5,27834,5,N'Собака',N'Мерс',5,'2012-10-10',N'Светло-серый',N'М',N'Гизель',N'Принц','2013-01-10',8754,3)

insert into Паспорт_животного(ID_Животного,Номер_родословной,Владелец,Группа,Кличка,Порода,Дата_рождения,Окрас,Пол,Имя_мамы,Имя_папы,Дата_имплантации,Номер_чипа,Место_размещения)
values (6,24579,6,N'Собака',N'Гэби',6,'2012-12-10',N'Светло-серый',N'Ж',N'Дымка',N'Клайд','2013-01-10',9877,1)

insert into Паспорт_животного(ID_Животного,Номер_родословной,Владелец,Группа,Кличка,Порода,Дата_рождения,Окрас,Пол,Имя_мамы,Имя_папы,Дата_имплантации,Номер_чипа,Место_размещения)
values (7,45784,7,N'Собака',N'Дира',7,'2013-01-10',N'Белый',N'Ж',N'Жуча',N'Лео','2013-09-01',7777,3)

insert into Паспорт_животного(ID_Животного,Номер_родословной,Владелец,Группа,Кличка,Порода,Дата_рождения,Окрас,Пол,Имя_мамы,Имя_папы,Дата_имплантации,Номер_чипа,Место_размещения)
values (8,31548,8,N'Собака',N'Жура',8,'2015-05-10',N'Белый',N'Ж',N'Жуча',N'Лукас','2015-09-11',6666,3)


insert into Паспорт_животного(ID_Животного,Номер_родословной,Владелец,Группа,Кличка,Порода,Дата_рождения,Окрас,Пол,Имя_мамы,Имя_папы,Дата_имплантации,Номер_чипа,Место_размещения)
values (9,78542,9,N'Собака',N'Зея',9,'2012-05-10',N'Чёрный',N'Ж',N'Жуч',N'Ларион','2015-09-11',5555,2)

insert into Паспорт_животного(ID_Животного,Номер_родословной,Владелец,Группа,Кличка,Порода,Дата_рождения,Окрас,Пол,Имя_мамы,Имя_папы,Дата_имплантации,Номер_чипа,Место_размещения)
values (10,59789,10,N'Собака',N'Каа',10,'2014-05-10',N'Чёрный',N'Ж',N'Жуч',N'Ларион','2015-10-05',4444,1)

insert into Паспорт_животного(ID_Животного,Номер_родословной,Владелец,Группа,Кличка,Порода,Дата_рождения,Окрас,Пол,Имя_мамы,Имя_папы,Дата_имплантации,Номер_чипа,Место_размещения)
values (11,65775,11,N'Кошка',N'Ренджровер',11,'2016-08-11',N'Чёрный',N'М',N'Супер',N'Спорт','2016-10-05',1111,1)

insert into Паспорт_животного(ID_Животного,Номер_родословной,Владелец,Группа,Кличка,Порода,Дата_рождения,Окрас,Пол,Имя_мамы,Имя_папы,Дата_имплантации,Номер_чипа,Место_размещения)
values (12,67158,12,N'Кошка',N'Бобик',12,'2015-04-12',N'Рыжий',N'М',N'Мила',N'Тритон','2015-10-25',1441,3)

insert into Паспорт_животного(ID_Животного,Номер_родословной,Владелец,Группа,Кличка,Порода,Дата_рождения,Окрас,Пол,Имя_мамы,Имя_папы,Дата_имплантации,Номер_чипа,Место_размещения)
values (13,46482,13,N'Кошка',N'Трой',13,'2015-04-13',N'Рыжий',N'М',N'Ли-ли',N'Марс','2015-02-24',1548,2)

insert into Паспорт_животного(ID_Животного,Номер_родословной,Владелец,Группа,Кличка,Порода,Дата_рождения,Окрас,Пол,Имя_мамы,Имя_папы,Дата_имплантации,Номер_чипа,Место_размещения)
values (14,87546,14,N'Кошка',N'Максим',14,'2016-04-13',N'Серый',N'М',N'Линда',N'Ричерд','2016-09-29',5748,1)

insert into Паспорт_животного(ID_Животного,Номер_родословной,Владелец,Группа,Кличка,Порода,Дата_рождения,Окрас,Пол,Имя_мамы,Имя_папы,Дата_имплантации,Номер_чипа,Место_размещения)
values (15,53467,15,N'Кошка',N'Ричерд',15,'2012-05-21',N'Белый',N'М',N'Луя',N'Луиджи','2012-12-20',3415,3)

insert into Паспорт_животного(ID_Животного,Номер_родословной,Владелец,Группа,Кличка,Порода,Дата_рождения,Окрас,Пол,Имя_мамы,Имя_папы,Дата_имплантации,Номер_чипа,Место_размещения)
values (16,46317,16,N'Кошка',N'Ася',16,'2013-05-21',N'Рыжий',N'Ж',N'Дайра',N'Баста','2013-12-20',4785,2)

insert into Паспорт_животного(ID_Животного,Номер_родословной,Владелец,Группа,Кличка,Порода,Дата_рождения,Окрас,Пол,Имя_мамы,Имя_папы,Дата_имплантации,Номер_чипа,Место_размещения)
values (17,31548,17,N'Кошка',N'Анита',17,'2012-06-11',N'Рыжий',N'Ж',N'Багира',N'Баки','2012-12-20',4615,1)

insert into Паспорт_животного(ID_Животного,Номер_родословной,Владелец,Группа,Кличка,Порода,Дата_рождения,Окрас,Пол,Имя_мамы,Имя_папы,Дата_имплантации,Номер_чипа,Место_размещения)
values (18,31548,18,N'Кошка',N'Арина',18,'2012-07-19',N'Белый',N'Ж',N'Ася',N'Джэк','2012-12-12',4567,1)

insert into Паспорт_животного(ID_Животного,Номер_родословной,Владелец,Группа,Кличка,Порода,Дата_рождения,Окрас,Пол,Имя_мамы,Имя_папы,Дата_имплантации,Номер_чипа,Место_размещения)
values (19,89548,19,N'Кошка',N'Пушинка',19,'2012-07-21',N'Чёрный',N'Ж',N'Атика',N'Вафля','2013-01-10',7646,3)

insert into Паспорт_животного(ID_Животного,Номер_родословной,Владелец,Группа,Кличка,Порода,Дата_рождения,Окрас,Пол,Имя_мамы,Имя_папы,Дата_имплантации,Номер_чипа,Место_размещения)
values (20,78453,20,N'Кошка',N'Венера',19,'2012-07-21',N'Серый',N'Ж',N'Веста',N'Боря','2013-01-10',4567,2)

/*Заполнение таблицы Получение_нарграды*/

insert into Получение_награды(ID_Получ,Кличка_животного,Наименование_награды,Дата_получения,Прошлая_дата_получения)
values(1,1,1,'2018-09-25','2017-09-25')

insert into Получение_награды(ID_Получ,Кличка_животного,Наименование_награды,Дата_получения,Прошлая_дата_получения)
values(2,2,2,'2018-09-25','2017-09-25')

insert into Получение_награды(ID_Получ,Кличка_животного,Наименование_награды,Дата_получения,Прошлая_дата_получения)
values(3,3,3,'2018-09-25','2017-09-25')

insert into Получение_награды(ID_Получ,Кличка_животного,Наименование_награды,Дата_получения,Прошлая_дата_получения)
values(4,4,4,'2018-09-25','2017-09-25')

insert into Получение_награды(ID_Получ,Кличка_животного,Наименование_награды,Дата_получения,Прошлая_дата_получения)
values(5,5,5,'2018-09-25','2017-09-25')

insert into Получение_награды(ID_Получ,Кличка_животного,Наименование_награды,Дата_получения,Прошлая_дата_получения)
values(6,6,6,'2018-09-25','2017-09-25')

insert into Получение_награды(ID_Получ,Кличка_животного,Наименование_награды,Дата_получения,Прошлая_дата_получения)
values(7,7,7,'2018-09-25','2017-09-25')

insert into Получение_награды(ID_Получ,Кличка_животного,Наименование_награды,Дата_получения,Прошлая_дата_получения)
values(8,8,8,'2018-09-25','2017-09-25')

insert into Получение_награды(ID_Получ,Кличка_животного,Наименование_награды,Дата_получения,Прошлая_дата_получения)
values(9,9,9,'2018-09-25','2017-09-25')

insert into Получение_награды(ID_Получ,Кличка_животного,Наименование_награды,Дата_получения,Прошлая_дата_получения)
values(10,10,10,'2018-09-25','2017-09-25')

insert into Получение_награды(ID_Получ,Кличка_животного,Наименование_награды,Дата_получения,Прошлая_дата_получения)
values(11,11,11,'2018-09-25','2017-09-25')

insert into Получение_награды(ID_Получ,Кличка_животного,Наименование_награды,Дата_получения,Прошлая_дата_получения)
values(12,12,12,'2018-09-25','2017-09-25')

insert into Получение_награды(ID_Получ,Кличка_животного,Наименование_награды,Дата_получения,Прошлая_дата_получения)
values(13,13,13,'2018-09-25','2017-09-25')

insert into Получение_награды(ID_Получ,Кличка_животного,Наименование_награды,Дата_получения,Прошлая_дата_получения)
values(14,14,14,'2018-09-25','2017-09-25')

insert into Получение_награды(ID_Получ,Кличка_животного,Наименование_награды,Дата_получения,Прошлая_дата_получения)
values(15,15,15,'2018-09-25','2017-09-25')

insert into Получение_награды(ID_Получ,Кличка_животного,Наименование_награды,Дата_получения,Прошлая_дата_получения)
values(16,16,16,'2018-09-25','2017-09-25')

insert into Получение_награды(ID_Получ,Кличка_животного,Наименование_награды,Дата_получения,Прошлая_дата_получения)
values(17,17,17,'2018-09-25','2017-09-25')

insert into Получение_награды(ID_Получ,Кличка_животного,Наименование_награды,Дата_получения,Прошлая_дата_получения)
values(18,18,18,'2018-09-25','2017-09-25')

insert into Получение_награды(ID_Получ,Кличка_животного,Наименование_награды,Дата_получения,Прошлая_дата_получения)
values(19,19,19,'2018-09-25','2017-09-25')

insert into Получение_награды(ID_Получ,Кличка_животного,Наименование_награды,Дата_получения,Прошлая_дата_получения)
values(20,20,20,'2018-09-25','2017-09-25')

/*Заполнение таблицы Ветеринарное свидетельство*/
insert into Ветеринарное_свидетельство(ID_Вет,Имя_животного,Наименование_прививки,Привика_от,Дата_принятия,Срок_действия_прививки,Имя_картинки,Формат_картинки)
values(1,1,1,1,'2018-09-25','2018-10-23','akita-iny','jpg')

insert into Ветеринарное_свидетельство(ID_Вет,Имя_животного,Наименование_прививки,Привика_от,Дата_принятия,Срок_действия_прививки,Имя_картинки,Формат_картинки)
values(2,2,2,2,'2018-10-25','2018-11-23','bigl','jpg')

insert into Ветеринарное_свидетельство(ID_Вет,Имя_животного,Наименование_прививки,Привика_от,Дата_принятия,Срок_действия_прививки,Имя_картинки,Формат_картинки)
values(3,3,3,3,'2018-12-25','2018-01-23','bladxaynd','jpg')

insert into Ветеринарное_свидетельство(ID_Вет,Имя_животного,Наименование_прививки,Привика_от,Дата_принятия,Срок_действия_прививки,Имя_картинки,Формат_картинки)
values(4,4,4,4,'2018-01-25','2018-02-23','bokser','jpg')

insert into Ветеринарное_свидетельство(ID_Вет,Имя_животного,Наименование_прививки,Привика_от,Дата_принятия,Срок_действия_прививки,Имя_картинки,Формат_картинки)
values(5,5,5,5,'2018-02-25','2018-03-23','Kovkaz_ovchar','jpg')

insert into Ветеринарное_свидетельство(ID_Вет,Имя_животного,Наименование_прививки,Привика_от,Дата_принятия,Срок_действия_прививки,Имя_картинки,Формат_картинки)
values(6,6,6,6,'2018-04-25','2018-05-23','labrador','jpg')

insert into Ветеринарное_свидетельство(ID_Вет,Имя_животного,Наименование_прививки,Привика_от,Дата_принятия,Срок_действия_прививки,Имя_картинки,Формат_картинки)
values(7,7,7,7,'2018-05-25','2018-06-23','nemetsk_ovchar','jpg')

insert into Ветеринарное_свидетельство(ID_Вет,Имя_животного,Наименование_прививки,Привика_от,Дата_принятия,Срок_действия_прививки,Имя_картинки,Формат_картинки)
values(8,8,8,8,'2018-06-25','2018-07-23','taksa','jpg')

insert into Ветеринарное_свидетельство(ID_Вет,Имя_животного,Наименование_прививки,Привика_от,Дата_принятия,Срок_действия_прививки,Имя_картинки,Формат_картинки)
values(9,9,1,1,'2018-07-25','2018-08-23','Rotveler','jpg')

insert into Ветеринарное_свидетельство(ID_Вет,Имя_животного,Наименование_прививки,Привика_от,Дата_принятия,Срок_действия_прививки,Имя_картинки,Формат_картинки)
values(10,10,2,2,'2018-09-25','2018-10-23','pudel','jpg')

insert into Ветеринарное_свидетельство(ID_Вет,Имя_животного,Наименование_прививки,Привика_от,Дата_принятия,Срок_действия_прививки,Имя_картинки,Формат_картинки)
values(11,11,3,3,'2018-10-25','2018-11-23','mei_kun','jpg')

insert into Ветеринарное_свидетельство(ID_Вет,Имя_животного,Наименование_прививки,Привика_от,Дата_принятия,Срок_действия_прививки,Имя_картинки,Формат_картинки)
values(12,12,4,4,'2018-11-25','2018-12-23','ashera','jpg')

insert into Ветеринарное_свидетельство(ID_Вет,Имя_животного,Наименование_прививки,Привика_от,Дата_принятия,Срок_действия_прививки,Имя_картинки,Формат_картинки)
values(13,13,5,5,'2018-09-25','2018-10-23','burmila','jpg')

insert into Ветеринарное_свидетельство(ID_Вет,Имя_животного,Наименование_прививки,Привика_от,Дата_принятия,Срок_действия_прививки,Имя_картинки,Формат_картинки)
values(14,14,6,6,'2018-09-25','2018-10-23','korat','jpg')

insert into Ветеринарное_свидетельство(ID_Вет,Имя_животного,Наименование_прививки,Привика_от,Дата_принятия,Срок_действия_прививки,Имя_картинки,Формат_картинки)
values(15,15,7,7,'2018-09-25','2018-10-23','cavanna','jpg')

insert into Ветеринарное_свидетельство(ID_Вет,Имя_животного,Наименование_прививки,Привика_от,Дата_принятия,Срок_действия_прививки,Имя_картинки,Формат_картинки)
values(16,16,8,8,'2018-09-25','2018-10-23','toiger','jpg')

insert into Ветеринарное_свидетельство(ID_Вет,Имя_животного,Наименование_прививки,Привика_от,Дата_принятия,Срок_действия_прививки,Имя_картинки,Формат_картинки)
values(17,17,1,1,'2018-09-25','2018-10-23','show_shy','jpg')

insert into Ветеринарное_свидетельство(ID_Вет,Имя_животного,Наименование_прививки,Привика_от,Дата_принятия,Срок_действия_прививки,Имя_картинки,Формат_картинки)
values(18,18,2,2,'2018-09-25','2018-10-23','otiket','jpg')

insert into Ветеринарное_свидетельство(ID_Вет,Имя_животного,Наименование_прививки,Привика_от,Дата_принятия,Срок_действия_прививки,Имя_картинки,Формат_картинки)
values(19,19,3,3,'2018-09-25','2018-10-23','manchkin','jpg')

insert into Ветеринарное_свидетельство(ID_Вет,Имя_животного,Наименование_прививки,Привика_от,Дата_принятия,Срок_действия_прививки,Имя_картинки,Формат_картинки)
values(20,20,4,4,'2018-09-25','2018-10-23','orientalnaay_koshka','jpg')