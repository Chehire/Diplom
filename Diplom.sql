set ansi_padding on
go
set quoted_identifier on
go
set ansi_nulls on
go

create database [Compo]
go

use [Compo]
go
------------------------------\
--Областьб объявления таблиц--|
------------------------------/

Create table [dbo].[Dolj]
(
	[ID_Dolj] [int] not null identity(1,1) Primary key,
	[Dolj][varchar](20) not null,
	[Oklad] [int] not null,
	[Dolj_Logical_Delete] [int] not null,
	constraint [UQ_Dolj_Profile] unique ([Dolj]),
	constraint [CH_Dolj_Cyrill_Upper] check ([Dolj] like ('%[А-Я]%')),
	constraint [CH_Dolj_Cyrill_Lower] check ([Dolj] like ('%[а-я]%')),
	constraint [CH_Dolj_Logical_Delete] check ([Dolj_Logical_Delete] in (0,1)),
)
go

Create table [dbo].[Sotr]
(
	[ID_Sotr] [int] not null identity(1,1) Primary key,
	[Fam_Sotr]	[varchar](25) not null,
	[Name_Sotr] [varchar](20) not null,
	[Otch_Sotr]	[varchar](25) null default ('Нет данных'),
	[Ser_Pas] [int] not null,
	[Num_Pas] [int] not null,
	[Date_Birth] [varchar](10) not null,
	[Dolj_ID] [int] not null,
	[Login_Sotr] [varchar] (16) not null,
	[Password_Sotr] [varchar] (40) not null,
	[Sotr_Logical_Delete] [int] not null,
	constraint [FK_Dolj] foreign key ([Dolj_ID])
	references [Dolj] ([ID_Dolj]),
	constraint [UQ_Passport] unique ([Ser_Pas],[Num_Pas]),
	constraint [UQ_Login_Sotr] unique ([Login_Sotr]),
	constraint [CH_Sotr_Name_Cyrill_Upper] check ([Name_Sotr] like ('%[А-Я]%')),
	constraint [CH_Sotr_Name_Cyrill_Lower] check ([Name_Sotr] like ('%[а-я]%')),
	constraint [CH_Sotr_Fam_Cyrill_Upper] check ([Fam_Sotr] like ('%[А-Я]%')),
	constraint [CH_Sotr_Fam_Cyrill_Lower] check ([Fam_Sotr] like ('%[а-я]%')),
	constraint [CH_Sotr_Otch_Cyrill_Upper] check ([Otch_Sotr] like ('%[А-Я]%')),
	constraint [CH_Sotr_Otch_Cyrill_Lower] check ([Otch_Sotr] like ('%[а-я]%')),
	constraint [CH_Password_Sotr_Latin_Upper] check ([Password_Sotr] like ('%[A-Z]%')),
	constraint [CH_Password_Sotr_Latin_Lower] check ([Password_Sotr] like ('%[a-z]%')),
	constraint [CH_Password_Sotr_Spec_Numbers] check ([Password_Sotr] like ('%[0-9]%')),
	constraint [CH_Num_Pas_Legth] check (len([Num_Pas])=6),
	constraint [CH_Ser_Pas_Legth] check (len([Ser_Pas])=4),
	constraint [CH_Num_Pas_Spec_Numbers] check ([Num_Pas] like ('%[0-9]%')),
	constraint [CH_Ser_Pas_Spec_Numbers] check ([Ser_Pas] like ('%[0-9]%')),
	constraint [CH_Login_Sotr_Latin_Upper] check ([Login_Sotr] not in ('%[А-Я]%')),
	constraint [CH_Login_Sotr_Latin_Lower] check ([Login_Sotr] not in ('%[а-я]%')),
	constraint [CH_Sotr_Logical_Delete] check ([Sotr_Logical_Delete] in (0,1))
)
go

create table [dbo].[TT]
(
	[ID_TT] [int] not null identity(1,1) Primary key,
	[TT_Name] [varchar](32)	not null,
	[Kol_vo_Ust_nix_Polok] [int] not null,
	[Adres][varchar](255) not null,
	[TT_Logical_Delete] [int] not null,

	constraint [CH_TT_Logical_Delete] check ([TT_Logical_Delete] in (0,1))
)
go

create table [dbo].[Group]
(
	[ID_Group][int] not null identity(1,1) Primary key,
	[Date] [varchar](10) not null,
	[Group_Logical_Delete] [int] not null,
	
	constraint [CH_Group_Logical_Delete] check ([Group_Logical_Delete] in (0,1))	
)
go

create table [dbo].[Sostav_Group]
(
	[ID] [int] not null identity(1,1) Primary key,
	[Group_ID] [int] not null,
	[Sotr_ID] [int] not null,
	constraint [FK_Sostav_Group] foreign key ([Group_ID])
	references [Group] ([ID_Group]),
	constraint [FK_Sotr] foreign key ([Sotr_ID])
	references [Sotr] ([ID_Sotr]),
)
go

create table [dbo].[Status]
(
	[ID_Status] [int] not null identity(1,1) Primary key,
	[Status_Name] [varchar](16) not null,
	[Status_Logical_Delete] [int] not null,

	constraint [CH_Status_Cyrill_Upper] check ([Status_Name] like ('%[А-Я]%')),
	constraint [CH_Status_Cyrill_Lower] check ([Status_Name] like ('%[а-я]%')),
	constraint [CH_Status_Logical_Delete] check ([Status_Logical_Delete] in (0,1))	
)
go

create table[dbo].[Zayavka]
(
	[ID_Zayavka][int] not null identity(1,1) Primary key,
	[Group_ID] [int] not null,
	[TT_ID] [int] not null,
	[Status_ID][int] not null,
	[Data_Podachi] [varchar](16)not null,
	[Data_Nachala_Rabot] [varchar](16),
	[Data_Okonchania_Rabot] [varchar](16),
	[Data_Zakritia_Zayavki] [varchar](16),
	[Spisok_Rapot][varchar](255) not null,
	[Spisok_Materialov][varchar](255) not null,
	[Kommentariy_TT][varchar](255),
	[Kommentariy_Group][varchar](255),
	[Zayavka_Logical_Delete] [int] not null,
	
	constraint [FK_TT] foreign key ([TT_ID])
	references [TT] ([ID_TT]),
	constraint [FK_Status] foreign key ([Status_ID])
	references [Status] ([ID_Status]),
	constraint [FK_Group] foreign key ([Group_ID])
	references [Group] ([ID_Group]),
	constraint [CH_Zayavka_Logical_Delete] check ([Zayavka_Logical_Delete] in (0,1))
)
go

create table [dbo].[Tip_Rabot]
(
	[ID_Tip_Rabot] [int] not null identity(1,1) Primary key,
	[Name_Tip_Rabot] [varchar](63) not null,
	[Tip_Rabot_Logical_Delete][int] not null,

	constraint [CH_Name_Tip_Rabot_Cyrill_Upper] check ([Name_Tip_Rabot] like ('%[А-Я]%')),
	constraint [CH_Name_Tip_Rabot_Cyrill_Lower] check ([Name_Tip_Rabot] like ('%[а-я]%')),
	constraint [CH_Tip_Rabot_Logical_Delete] check ([Tip_Rabot_Logical_Delete] in (0,1))
)
go

create table [dbo].[Vip_no_Rabot]
(
	[ID_Vip_no_Rabot][int] not null identity(1,1) Primary key,
	[Zayavka_ID][int]not null,
	[Tip_Rabot_ID][int]not null,
	[Vip_no_Rabot_Logical_Delete][int] not null,
	constraint [FK_Zayavka] foreign key ([Zayavka_ID])
	references [Zayavka] ([ID_Zayavka]),
	constraint [FK_Tip_Rabot] foreign key ([Tip_Rabot_ID])
	references [Tip_Rabot] ([ID_Tip_Rabot]),
	constraint [CH_Vip_no_Rabot_Logical_Delete] check ([Vip_no_Rabot_Logical_Delete] in (0,1))
)
go

create view [dbo].[View_Sotr] ("ID","Фамилия","Имя","Отчество","Серия паспорта","Номер паспорта","Дата рождения","Должность","Оклад","Sotr_Logical_Delete")
as
SELECT
	dbo.Sotr.ID_Sotr,
	dbo.Sotr.Fam_Sotr, 
	dbo.Sotr.Name_Sotr, 
	dbo.Sotr.Otch_Sotr, 
	dbo.Sotr.Ser_Pas, 
	dbo.Sotr.Num_Pas,
	dbo.Sotr.Date_Birth,
	dbo.Dolj.Dolj, 
	dbo.Dolj.Oklad,
	dbo.Sotr.Sotr_Logical_Delete
FROM   dbo.Dolj INNER JOIN
             dbo.Sotr ON dbo.Dolj.ID_Dolj = dbo.Sotr.Dolj_ID
go

create view [dbo].[View_Group]("ID","№ Группы","ФИО","Дата")
as
SELECT 
	dbo.[Sostav_Group].ID,
	dbo.[Group].ID_Group, 
	dbo.Sotr.Fam_Sotr+' '+dbo.Sotr.Name_Sotr+' '+dbo.Sotr.Otch_Sotr, 
	dbo.[Group].Date
FROM   dbo.[Group] INNER JOIN
             dbo.Sostav_Group ON dbo.[Group].ID_Group = dbo.Sostav_Group.Group_ID INNER JOIN
             dbo.Sotr ON dbo.Sostav_Group.Sotr_ID = dbo.Sotr.ID_Sotr
go

create view [dbo].[View_Zayavka] 
(
	"ID",
	"№ Группы",
	"ТТ",
	"Адрес ТТ",
	"Статус",
	"Дата подачи", 
	"Дата начала работ",
	"Дата окончания работ",
	"Дата закрытия заявки", 
	"Список работ", 
	"Список материалов", 
	"Комментарий торговой точки", 
	"Комментарий группы",
	"Zayavka_Logical_Delete"
)
as
SELECT 
	
	dbo.Zayavka.ID_Zayavka, 
	dbo.Zayavka.Group_ID, 
	dbo.TT.TT_Name, 
	dbo.TT.Adres, 
	dbo.Status.Status_Name, 
	dbo.Zayavka.Data_Podachi, 
	dbo.Zayavka.Data_Nachala_Rabot, 
	dbo.Zayavka.Data_Okonchania_Rabot, 
	dbo.Zayavka.Data_Zakritia_Zayavki, 
    dbo.Zayavka.Spisok_Rapot, 
	dbo.Zayavka.Spisok_Materialov, 
	dbo.Zayavka.Kommentariy_TT, 
	dbo.Zayavka.Kommentariy_Group, 
	dbo.Zayavka.Zayavka_Logical_Delete
FROM   dbo.Zayavka INNER JOIN
             dbo.[Group] ON dbo.Zayavka.Group_ID = dbo.[Group].ID_Group INNER JOIN
             dbo.TT ON dbo.Zayavka.TT_ID = dbo.TT.ID_TT INNER JOIN
             dbo.Status ON dbo.Zayavka.Status_ID = dbo.Status.ID_Status
go

create view [dbo].[View_Vip_no_Rabot] 
(
	"ID",
	"Тип работы",
	"ТТ",
	"Vip_no_Rabot_Logical_Delete"
)
as
SELECT 
	dbo.Vip_no_Rabot.ID_Vip_no_Rabot, 
	dbo.Tip_Rabot.Name_Tip_Rabot, 
	dbo.TT.TT_Name,
	dbo.Vip_no_Rabot.Vip_no_Rabot_Logical_Delete
FROM   dbo.Vip_no_Rabot INNER JOIN
             dbo.Zayavka ON dbo.Vip_no_Rabot.Zayavka_ID = dbo.Zayavka.ID_Zayavka INNER JOIN
             dbo.Tip_Rabot ON dbo.Vip_no_Rabot.Tip_Rabot_ID = dbo.Tip_Rabot.ID_Tip_Rabot INNER JOIN
             dbo.TT ON dbo.Zayavka.TT_ID = dbo.TT.ID_TT
go

----------------------------------------\
--Область объявления хранимых процедур--|
----------------------------------------/

create procedure [dbo].[Dolj_Insert]
	@Dolj [varchar](20),
	@Oklad [int]
as
	insert into [dbo].[Dolj]([Dolj],[Oklad],[Dolj_Logical_Delete])
values 
(
	@Dolj,
	@Oklad,
	0
)
go

create procedure [dbo].[Dolj_Update]
	@ID_Dolj [int],
	@Dolj [varchar](20),
	@Oklad [int]
as
	update [dbo].[Dolj] set
	[Dolj]=@Dolj,
	[Oklad]=@Oklad
where 
	[ID_Dolj]=@ID_Dolj
go

Create procedure [dbo].[Dolj_Delete]
	@ID_Dolj [int]
as 
	delete from [dbo].[Dolj]
	where [ID_Dolj]=@ID_Dolj
go

Create procedure [dbo].[Dolj_Logical_Delete]
	@ID_Dolj [int]
as
update [dbo].[Dolj] set 
	Dolj_Logical_Delete = 1
where
	ID_Dolj=@ID_Dolj
go

Create procedure [dbo].[Sotr_Insert]
	@Fam_Sotr [varchar](25),
	@Name_Sotr [varchar](20),
	@Otch_Sotr [varchar](25),
	@Ser_Pas [int],
	@Num_Pas [int],
	@Date_Birth [varchar](10),
	@Dolj_ID [int],
	@Login_Sotr [varchar](16),
	@Password_Sotr [varchar](40)
as
insert into [dbo].[Sotr]
(
	[Fam_Sotr],
	[Name_Sotr],
	[Otch_Sotr],
	[Ser_Pas],
	[Num_Pas],
	[Date_Birth],
	[Dolj_ID],
	[Login_Sotr],
	[Password_Sotr],
	[Sotr_Logical_Delete]
)
values 
(
	@Fam_Sotr,
	@Name_Sotr,
	@Otch_Sotr,
	@Ser_Pas ,
	@Num_Pas ,
	@Date_Birth,
	@Dolj_ID ,
	@Login_Sotr ,
	@Password_Sotr,
	0
)
go

create procedure [dbo].[Sotr_Update]
	@ID_Sotr [int],
	@Fam_Sotr [varchar](25),
	@Name_Sotr [varchar](20),
	@Otch_Sotr [varchar](25),
	@Ser_Pas [int],
	@Num_Pas [int],
	@Date_Birth [varchar](10),
	@Dolj_ID [int]
as
update [dbo].[Sotr] set
	[Fam_Sotr] = @Fam_Sotr,
	[Name_Sotr]= @Name_Sotr,
	[Otch_Sotr]= @Otch_Sotr,
	[Ser_Pas] = @Ser_Pas,
	[Num_Pas] = @Num_Pas,
	[Date_Birth] = @Date_Birth,
	[Dolj_ID] = @Dolj_ID
where 
	ID_Sotr = @ID_Sotr
go

Create procedure [dbo].[Sotr_Delete]
	@ID_Sotr [int]
as 
	delete from [dbo].[Sotr]
	where [ID_Sotr]=@ID_Sotr
go	

Create procedure [dbo].[Sotr_Logical_Delete]
	@ID_Sotr [int]
as
update [dbo].[Sotr] set
	[Sotr_Logical_Delete]=1
where
	[ID_Sotr]= @ID_Sotr
go

create procedure [dbo].[Sotr_Password_Update]
	@Login_Sotr [varchar](16),
	@Password_Sotr [varchar](40)
as 
update [dbo].[Sotr] set
	[Password_Sotr] = @Password_Sotr
where [Login_Sotr]=@Login_Sotr
go

Create procedure [dbo].[TT_Insert]

	@TT_Name [varchar](32),	
	@Kol_vo_Ust_nix_Polok [int], 
	@Adres[varchar](255), 
	@TT_Logical_Delete [int]
as
insert into [dbo].[TT] 
(
	[TT_Name], 
	[Kol_vo_Ust_nix_Polok], 
	[Adres],
	[TT_Logical_Delete]
)
values
(
	@TT_Name ,	
	@Kol_vo_Ust_nix_Polok, 
	@Adres, 
	0
)
go

create procedure [dbo].[TT_Update]
	@ID_TT [int],
	@TT_Name [varchar](32),	
	@Kol_vo_Ust_nix_Polok [int], 
	@Adres[varchar](255)
as
update [dbo].[TT] set
	[TT_Name]=@TT_Name, 
	[Kol_vo_Ust_nix_Polok]=@Kol_vo_Ust_nix_Polok, 
	[Adres]=@Adres
where 
	ID_TT = @ID_TT
go

Create procedure [dbo].[TT_Delete]
	@ID_TT [int]
as 
	delete from [dbo].[TT]
	where [ID_TT]=@ID_TT
go	

Create procedure [dbo].[TT_Logical_Delete]
	@ID_TT [int]
as
update [dbo].[TT] set
	[TT_Logical_Delete]=1
where
	[ID_TT]= @ID_TT
go

Create procedure [dbo].[Group_Insert]
	@Date [varchar](10),
	@Group_Logical_Delete [int]
as
insert into [dbo].[Group] 
(
	[Date],
	[Group_Logical_Delete]
)
values
(
	@Date,
	0
)
go

create procedure [dbo].[Group_Update]
	@ID_Group[int],
	@Date [varchar](10)
as
update [dbo].[Group] set
	[Date]=@Date
where 
	ID_Group = @ID_Group
go

Create procedure [dbo].[Group_Delete]
	@ID_Group [int]
as 
	delete from [dbo].[Group]
	where [ID_Group]=@ID_Group
go	

Create procedure [dbo].[Group_Logical_Delete]
	@ID_Group [int]
as
update [dbo].[Group] set
	[Group_Logical_Delete]=1
where
	[ID_Group]= @ID_Group
go

Create procedure [dbo].[Sostav_Group_Insert]
	@Group_ID[int],
	@Sotr_ID [int]
as
insert into [dbo].[Sostav_Group] 
(
	[Group_ID],
	[Sotr_ID]
)
values
(
	@Group_ID,
	@Sotr_ID
)
go

create procedure [dbo].[Sostav_Group_Update]
	@ID[int],
	@Group_ID[int],
	@Sotr_ID [int]
as
update [dbo].[Sostav_Group] set
	[Group_ID]=@Group_ID, 
	[Sotr_ID]=@Sotr_ID
where 
	[ID]= @ID
go

Create procedure [dbo].[Sostav_Group_Delete]
	@ID [int]
as 
	delete from [dbo].[Sostav_Group]
	where [ID]=@ID
go	


Create procedure [dbo].[Status_Insert]
	@Status_Name[varchar](16),
	@Status_Logical_Delete [int]
as
insert into [dbo].[Status] 
(
	[Status_Name],
	[Status_Logical_Delete]
)
values
(
	@Status_Name,
	0
)
go

create procedure [dbo].[Status_Update]
	@ID_Status[int],
	@Status_Name[varchar](16)
as
update [dbo].[Status] set
	[Status_Name]=@Status_Name
where 
	ID_Status = @ID_Status
go

Create procedure [dbo].[Status_Delete]
	@ID_Status [int]
as 
	delete from [dbo].[Status]
	where [ID_Status]=@ID_Status
go	

Create procedure [dbo].[Status_Logical_Delete]
	@ID_Status [int]
as
update [dbo].[Status] set
	[Status_Logical_Delete]=1
where
	[ID_Status]= @ID_Status
go

Create procedure [dbo].[Zayavka_Insert]
	@Group_ID [int],
	@TT_ID [int],
	@Status_ID[int],
	@Data_Podachi [varchar](16),
	@Data_Nachala_Rabot [varchar](16),
	@Data_Okonchania_Rabot [varchar](16),
	@Data_Zakritia_Zayavki [varchar](16),
	@Spisok_Rapot[varchar](255),
	@Spisok_Materialov[varchar](255),
	@Kommentariy_TT[varchar](255),
	@Kommentariy_Group[varchar](255),
	@Zayavka_Logical_Delete [int]
as
insert into [dbo].[Zayavka]
(
	[Group_ID],
	[TT_ID],
	[Status_ID],
	[Data_Podachi],
	[Data_Nachala_Rabot],
	[Data_Okonchania_Rabot],
	[Data_Zakritia_Zayavki],
	[Spisok_Rapot],
	[Spisok_Materialov],
	[Kommentariy_TT],
	[Kommentariy_Group],
	[Zayavka_Logical_Delete]
)
values 
(
	@Group_ID,
	@TT_ID,
	@Status_ID,
	@Data_Podachi ,
	@Data_Nachala_Rabot ,
	@Data_Okonchania_Rabot,
	@Data_Zakritia_Zayavki,
	@Spisok_Rapot,
	@Spisok_Materialov,
	@Kommentariy_TT,
	@Kommentariy_Group,
	0
)
go

create procedure [dbo].[Zayavka_Update]
	@ID_Zayavka [int],
	@Group_ID [int],
	@TT_ID [int],
	@Status_ID[int],
	@Data_Podachi [varchar],
	@Data_Nachala_Rabot [varchar],
	@Data_Okonchania_Rabot [varchar],
	@Data_Zakritia_Zayavki [varchar],
	@Spisok_Rapot[varchar](255),
	@Spisok_Materialov[varchar](255),
	@Kommentariy_TT[varchar](255),
	@Kommentariy_Group[varchar](255)
as
update [dbo].[Zayavka] set
	[Group_ID]=@Group_ID,
	[TT_ID]=@TT_ID,
	[Status_ID]=@Status_ID,
	[Data_Podachi]=@Data_Podachi,
	[Data_Nachala_Rabot]=@Data_Nachala_Rabot,
	[Data_Okonchania_Rabot]=Data_Okonchania_Rabot,
	[Data_Zakritia_Zayavki]=Data_Zakritia_Zayavki,
	[Spisok_Rapot]=@Spisok_Rapot,
	[Spisok_Materialov]=@Spisok_Materialov,
	[Kommentariy_TT]=@Kommentariy_TT,
	[Kommentariy_Group]=@Kommentariy_Group
where 
	ID_Zayavka = @ID_Zayavka
go

Create procedure [dbo].[Zayavka_Delete]
	@ID_Zayavka [int]
as 
	delete from [dbo].[Zayavka]
	where [ID_Zayavka]=@ID_Zayavka
go	

Create procedure [dbo].[Zayavka_Logical_Delete]
	@ID_Zayavka [int]
as
update [dbo].[Zayavka] set
	[Zayavka_Logical_Delete]=1
where
	[ID_Zayavka]= @ID_Zayavka
go

Create procedure [dbo].[Tip_Rabot_Insert]
	@Name_Tip_Rabot[varchar](16),
	@Tip_Rabot_Logical_Delete [int]
as
insert into [dbo].[Tip_Rabot] 
(
	[Name_Tip_Rabot],
	[Tip_Rabot_Logical_Delete]
)
values
(
	@Name_Tip_Rabot,
	0
)
go

create procedure [dbo].[Tip_Rabot_Update]
	@ID_Tip_Rabot[int],
	@Name_Tip_Rabot[varchar](16)
as
update [dbo].[Tip_Rabot] set
	[Name_Tip_Rabot]=@Name_Tip_Rabot
where 
	ID_Tip_Rabot = @ID_Tip_Rabot
go

Create procedure [dbo].[Tip_Rabot_Delete]
	@ID_Tip_Rabot [int]
as 
	delete from [dbo].[Tip_Rabot]
	where [ID_Tip_Rabot]=@ID_Tip_Rabot
go	

Create procedure [dbo].[Tip_Rabot_Logical_Delete]
	@ID_Tip_Rabot [int]
as
update [dbo].[Tip_Rabot] set
	[Tip_Rabot_Logical_Delete]=1
where
	[ID_Tip_Rabot]= @ID_Tip_Rabot
go

	Create procedure [dbo].[Vip_no_Rabot_Insert]
	@Zayavka_ID [int],
	@Tip_Rabot_ID[int],
	@Vip_no_Rabot_Logical_Delete [int]
as
insert into [dbo].[Vip_no_Rabot] 
(
	[Zayavka_ID],
	[Tip_Rabot_ID],
	[Vip_no_Rabot_Logical_Delete]
)
values
(
	@Zayavka_ID,
	@Tip_Rabot_ID,
	0
)
go

create procedure [dbo].[Vip_no_Rabot_Update]
	@ID_Vip_no_Rabot[int],
	@Zayavka_ID [int],
	@Tip_Rabot_ID[int]
as
update [dbo].[Vip_no_Rabot] set
	[Zayavka_ID]=@Zayavka_ID,
	[Tip_Rabot_ID]=@Tip_Rabot_ID
where 
	[ID_Vip_no_Rabot] = @ID_Vip_no_Rabot
go

Create procedure [dbo].[Vip_no_Rabot_Delete]
	@ID_Vip_no_Rabot [int]
as 
	delete from [dbo].[Vip_no_Rabot]
	where [ID_Vip_no_Rabot]=@ID_Vip_no_Rabot
go	

Create procedure [dbo].[Vip_no_Rabot_Logical_Delete]
	@ID_Vip_no_Rabot [int]
as
update [dbo].[Vip_no_Rabot] set
	[Vip_no_Rabot_Logical_Delete]=1
where
	[ID_Vip_no_Rabot]= @ID_Vip_no_Rabot
go

insert into [dbo].[Dolj] ([Dolj],[Oklad],[Dolj_Logical_Delete])
values
	('Администратор',90000,0),
	('Старший инженер',60000,0),
	('Инженер',50000,0)
go

insert into [dbo].[Sotr] ([Fam_Sotr],[Name_Sotr],[Otch_Sotr],[Ser_Pas],[Num_Pas],[Date_Birth],[Dolj_ID],[Login_Sotr],[Password_Sotr],[Sotr_Logical_Delete])
values
	('Иванов','Андрей','Дмитриевич',4514,551866,'19.05.2000',1,'Root','PMMc0kYUmuxoB5JB5x6Y9g==',0),
	('Антонов','Евгений','Владимирович',4514,545456,'23.07.2000',3,'@nton0v','PMMc0kYUmuxoB5JB5x6Y9g==',0),
	('Козленков','Михаил','Андреевич',4519,435556,'31.10.1999',3,'Koz1enk0v','PMMc0kYUmuxoB5JB5x6Y9g==',0),
	('Литвина','Екатерина','Игоревна',4385,565656,'20.04.1985',2,'Letv1n@','PMMc0kYUmuxoB5JB5x6Y9g==',0),
	('Бофт','Александр','Нет данных',4180,434553,'03.02.1980',2,'@lexB0ft','PMMc0kYUmuxoB5JB5x6Y9g==',0),
	('Смирнова','Ксения','Нет данных',4514,556876,'21.11.2000',3,'Ksen1@','PMMc0kYUmuxoB5JB5x6Y9g==',0),
	('Иванов','Алексей','Петрович',4514,545458,'13.11.2000',3,'Iv@nov','PMMc0kYUmuxoB5JB5x6Y9g==',0),
	('Иванов','Алексей','Петрович',4514,785458,'25.02.2000',3,'Iv@n0v','PMMc0kYUmuxoB5JB5x6Y9g==',0)
go

insert into [dbo].[TT]([TT_Name],[Kol_vo_Ust_nix_Polok], [Adres], [TT_Logical_Delete])
values
 ('L212 Аэропорт Домодедово',9,'аэропорт Домодедово имени М.В. Ломоносова, 1',0),
 ('L003 Аэропорт Домодедово2',12,'аэропорт Домодедово имени М.В. Ломоносова, 1',0),
 ('L153 ТЦ Бум',9,'ул. Перерва, 43, корп. 1, Москва',0),
 ('L131 ТРЦ Афимолл',12,'Пресненская наб., 2, Москва',0),
 ('L135 ТЦ Европейский',9,'площадь Киевского Вокзала, 2, Москва',0),
 ('L145 ТРЦ Фестиваль',12,'ул. Мичуринский Проспект, Олимпийская Деревня, 3, корп. 1, Москва',0),
 ('MV78 ТЦ Европейский 2',42,'площадь Киевского Вокзала, 2, Москва',0),
 ('L446 ТРЦ Вегас Каширский',9,'МКАД, 24-й километр, 1, Москва',0),
 ('L515 Мега Белая Дача 5',36,'1-й Покровский пр., 5, Котельники',0),
 ('L504 Ашан Белая Дача',33,'1-й Покровский пр., 5, Котельники',0),
 ('L157 ТЦ Домодедовский',27,'Ореховый бул., 14, корп. 3, Москва',0)
go

insert into [dbo].[Group] ([Date], [Group_Logical_Delete])
values
	('20.05.2020',0),
	('20.05.2020',0)
go

insert into [dbo].[Status] ([Status_Name], [Status_Logical_Delete])
values
	('Создана',0),
	('Обсуждена',0),
	('Утверждена',0),
	('Выполняется',0),
	('Выполнена',0),
	('Возвращена',0),
	('Закрыта',0)
go

insert into [dbo].[Sostav_Group]([Group_ID], [Sotr_ID])
values
	(1,2),
	(1,3),
	(1,4),
	(2,5),
	(2,6),
	(2,7)
go

insert into [dbo].[Tip_Rabot] ([Name_Tip_Rabot],[Tip_Rabot_Logical_Delete])
values
	('Замена полки',0),
	('Замена донгла',0),
	('Замена кабеля питания',0),
	('Обновление прошивки',0),
	('Замена крепежа',0),
	('Замена батареек',0),
	('Сбор информации о прейскуранте',0),
	('Линковка ценников',0),
	('Подсчет ценников',0)
go
insert into [dbo].[Zayavka] ([Group_ID],[TT_ID],[Status_ID],[Data_Podachi],[Data_Nachala_Rabot],[Data_Okonchania_Rabot],[Data_Zakritia_Zayavki],[Spisok_Rapot],[Spisok_Materialov],[Kommentariy_Group],[Kommentariy_TT],[Zayavka_Logical_Delete])
values
(2,7,4,'19.05.2020 22:45', '20.05.2020 09:00',	 ' .  .       :	  ', '  .  .       :	', 'Не работает полка',	'Новая полка и ТСД',	'ТСД на точке', '',0),
(1,10,5,'20.05.2020 23:00',	'21.05.2020 09:00',	'27.05.2020 18:00', '	  .  .       :	', 'Неработает полка',	'Новая полка',' ','',0),
(2,8,1,'	  .  .       :	  ', '.  .       :	  ', '.  .       :	  ','.  .       :	','','','','',0)
go

insert into [dbo].[Vip_no_Rabot] ([Zayavka_ID],[Tip_Rabot_ID],[Vip_no_Rabot_Logical_Delete])
values
	(1,1,0),
	(1,8,0)
go
