USE [master]

GO

CREATE DATABASE [apteka]
GO
USE [apteka]
GO

CREATE TABLE Logins (    ID			INT				IDENTITY		PRIMARY KEY,
						UserName	VARCHAR(20)		NOT NULL,
						Password	VARCHAR(20));

Go
INSERT INTO Logins VALUES ( 'admin', 'admin'),
                         ( 'user','user');

GO



Go

CREATE TABLE Medicine (  MedicinesID			INT				IDENTITY		PRIMARY KEY,
						  MedicinesName		NVARCHAR(55)		NOT NULL,
						  Category          NVARCHAR(30)     NOT NULL,
						  Price             VARCHAR(50)		NOT NULL,
						  kolvo VARCHAR(50)		NOT NULL );
Go


CREATE TABLE Client (	 ClientID			INT				IDENTITY		PRIMARY KEY,
						 ClientName			NVARCHAR (100)	NOT NULL,
						 PhoneN				VARCHAR(50)		NOT NULL ) ;


GO

CREATE TABLE Orders ( OrdersID INT				IDENTITY		PRIMARY KEY,
                      MedicinesID			INT REFERENCES		Medicine (MedicinesID),
                      ClientID				INT				REFERENCES		Client (ClientID),
					  Statusorders    NVARCHAR (50)	NOT NULL);          

GO		


CREATE TABLE Serviceserv ( RegistrationID			INT				IDENTITY		PRIMARY KEY,
						ClientID				INT				REFERENCES		Client (ClientID),
						DateofServ				DATE);



GO

INSERT INTO  Medicine		 VALUES		(N'Аскофен', N'Обезболивающие',N'250',N'100'),
										(N'Витамин С', N'Витамины',N'140',N'50'),
                                        (N'Аквадетрим (Витамин D)', N'Витамины',N'435',N'50'),
										(N'Супрастин', N'Антигистаминное',N'150',N'150'),
										(N'Фенистил мазь', N'Антигистаминное',N'529',N'340'),
										(N'Двухнедельные контактные линзы', N'Линзы',N'1714',N'500'),
										(N'Одноневные контактные линзы', N'Линзы',N'2114',N'500'),
										(N'Энтерофурил', N'Диарея',N'440',N'100'),
										(N'Гутталакс', N'Слабительное',N'400',N'380'),
										(N'активированный уголь', N'Энтеросорбирующее',N'120',N'970');
									    
	

Go

INSERT INTO  Orders	 VALUES		    (2, 1,N'доставлен'),	 
									(4,  7,N'собран'),
									(10,  1,N'оплачен'), 
									(6,  4,N'в пути'), 
									(5,  5,N'отсортирован'),
									(8,  2,N'выдан'),
									(7,  3,N'в пути'),
									(3,9,N'собран'),
									(3, 2,N'собран'), 
									(9,  6,N'отсортирован'),
									(1,  8,N'выдан'),
									(5, 2,N'собран'); 

GO

INSERT INTO Client VALUES			(N'Лукьянченко Елена Игоревна',	'+7-954-454-63-73'),
									(N'Пшеничникова Мария Владимировна',	'+7-924-635-36-13'),
									(N'Чернова Екатерина Анатольевна',	'+7-901-546-23-96'),
									(N'Ахметьянов Азат Ришатович',' +7-912-999-99-99'),
									(N'Меньшикова Наталья Сергеевна',	'+7-900-888-44-43'),
									(N'Задумин Роман Александрович',	'+7-945-545-45-54'),
									(N'Алешин Алексей Иванович',	'+7-923-465-56-34'),
									(N'Феоктистова Нина Ивановна',		'+7-974-734-82-94'),
									(N'Горшков Артемий Савельевич',	'+7-943-244-56-46');
								

GO

INSERT INTO Serviceserv VALUES  (1, 2, '2023-05-21'),		
										(2, 5, '2023-05-28'),
										(3, 9, '2023-05-28'),		
										(4, 8, '2023-06-1'),		
										(5, 4, '2023-06-5'),
										(6, 6, '2023-06-5'),	
										(7, 3, '2023-06-5'),
										(8, 1, '2023-06-10'),
										(9, 7, '2023-06-10');