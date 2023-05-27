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

INSERT INTO  Medicine		 VALUES		(N'�������', N'��������������',N'250',N'100'),
										(N'������� �', N'��������',N'140',N'50'),
                                        (N'���������� (������� D)', N'��������',N'435',N'50'),
										(N'���������', N'���������������',N'150',N'150'),
										(N'�������� ����', N'���������������',N'529',N'340'),
										(N'������������� ���������� �����', N'�����',N'1714',N'500'),
										(N'���������� ���������� �����', N'�����',N'2114',N'500'),
										(N'�����������', N'������',N'440',N'100'),
										(N'���������', N'������������',N'400',N'380'),
										(N'�������������� �����', N'�����������������',N'120',N'970');
									    
	

Go

INSERT INTO  Orders	 VALUES		    (2, 1,N'���������'),	 
									(4,  7,N'������'),
									(10,  1,N'�������'), 
									(6,  4,N'� ����'), 
									(5,  5,N'������������'),
									(8,  2,N'�����'),
									(7,  3,N'� ����'),
									(3,9,N'������'),
									(3, 2,N'������'), 
									(9,  6,N'������������'),
									(1,  8,N'�����'),
									(5, 2,N'������'); 

GO

INSERT INTO Client VALUES			(N'����������� ����� ��������',	'+7-954-454-63-73'),
									(N'������������ ����� ������������',	'+7-924-635-36-13'),
									(N'������� ��������� �����������',	'+7-901-546-23-96'),
									(N'���������� ���� ���������',' +7-912-999-99-99'),
									(N'���������� ������� ���������',	'+7-900-888-44-43'),
									(N'������� ����� �������������',	'+7-945-545-45-54'),
									(N'������ ������� ��������',	'+7-923-465-56-34'),
									(N'����������� ���� ��������',		'+7-974-734-82-94'),
									(N'������� ������� ����������',	'+7-943-244-56-46');
								

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