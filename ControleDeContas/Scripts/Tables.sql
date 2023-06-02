﻿USE ControleDeContas
go

CREATE TABLE CONTAS(
	IDCONTA INT IDENTITY PRIMARY KEY NOT NULL,
	NOMECONTA VARCHAR(255) NOT NULL,
	DESCRICAOCONTA VARCHAR(255) NOT NULL,
	DTVALCONTA SMALLDATETIME NOT NULL,
	DTPAGCONTA SMALLDATETIME NOT NULL,
	TIPOCONTA TINYINT NOT NULL,
	STATUSCONTA TINYINT NOT NULL,
	VALORCONTA MONEY NOT NULL
)
go