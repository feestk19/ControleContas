USE ControleDeContas
GO

IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'ADICIONA_CONTAS')
BEGIN
	PRINT 'Dropping Procedure ADICIONA_CONTAS'
	DROP PROCEDURE ADICIONA_CONTAS
END
GO
PRINT 'Creating Procedure ADICIONA_CONTAS'
GO

CREATE PROCEDURE ADICIONA_CONTAS
	@NOME VARCHAR(50),
	@DESCRICAO VARCHAR(255),
	@DTVENCIMENTO SMALLDATETIME,
	@TIPO TINYINT,
	@STATUS TINYINT,
	@DTPAGAMENTO SMALLDATETIME,
	@VALOR MONEY
AS
BEGIN
	INSERT INTO CONTAS (NOMECONTA, DESCRICAOCONTA, DTVALCONTA, TIPOCONTA, STATUSCONTA, DTPAGCONTA, VALORCONTA)
	VALUES (@NOME, @DESCRICAO, @DTVENCIMENTO, @TIPO, @STATUS, @DTPAGAMENTO, @VALOR)

	SELECT SCOPE_IDENTITY()
END
GO

IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'ALTERA_CONTAS')
BEGIN
	PRINT 'Dropping Procedure ALTERA_CONTAS'
	DROP PROCEDURE ALTERA_CONTAS
END
GO
PRINT 'Creating Procedure ALTERA_CONTAS'
GO

CREATE PROCEDURE ALTERA_CONTAS
	@ID INT,
	@NOME VARCHAR(50),
	@DESCRICAO VARCHAR(255),
	@DTVENCIMENTO SMALLDATETIME,
	@TIPO TINYINT,
	@STATUS TINYINT,
	@DTPAGAMENTO SMALLDATETIME,
	@VALOR MONEY
AS
BEGIN
	UPDATE CONTAS
	SET
		NOMECONTA = @NOME,
		DESCRICAOCONTA = @DESCRICAO,
		DTVALCONTA = @DTVENCIMENTO,
		TIPOCONTA = @TIPO,
		STATUSCONTA = @STATUS,
		DTPAGCONTA = @DTPAGAMENTO,
		VALORCONTA = @VALOR
	WHERE IDCONTA = @ID
END
GO

IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'SELECIONA_CONTAS_ALL_V1')
BEGIN
	PRINT 'Dropping Procedure SELECIONA_CONTAS_ALL_V1'
	DROP PROCEDURE SELECIONA_CONTAS_ALL_V1
END
GO
PRINT 'Creating Procedure SELECIONA_CONTAS_ALL_V1'
GO

CREATE PROCEDURE SELECIONA_CONTAS_ALL_V1
AS
BEGIN
	SELECT IDCONTA, NOMECONTA,
	DESCRICAOCONTA, 
	CAST(VALORCONTA AS VARCHAR(25)) AS VALORCONTA,
	DTVALCONTA, 
	DTPAGCONTA, 
	CASE 
		WHEN TIPOCONTA = 1 THEN 'Boleto'
		WHEN TIPOCONTA = 2 THEN 'Fatura'
		WHEN TIPOCONTA = 3 THEN 'Despesa'
	END AS TIPOCONTA,
	CASE
		WHEN STATUSCONTA = 1 THEN 'Pendente'
		WHEN STATUSCONTA = 2 THEN 'Liquidado'
		WHEN STATUSCONTA = 3 THEN 'Vencido'
	END AS STATUSCONTA
	FROM CONTAS
END
go

IF EXISTS (SELECT * FROM sysobjects WHERE type = 'P' AND name = 'DELETA_CONTAS')
BEGIN
	PRINT 'Dropping Procedure DELETA_CONTAS'
	DROP PROCEDURE DELETA_CONTAS
END
GO
PRINT 'Creating Procedure DELETA_CONTAS'
GO

CREATE PROCEDURE DELETA_CONTAS
		@ID INT
AS
BEGIN
	DELETE CONTAS WHERE IDCONTA = @ID
END


