--DROP PROCEDURE HEALTHYPETVET.p_insertVet
CREATE PROCEDURE HEALTHYPETVET.p_insertVet (
		@nome varchar(150),
		@nif int,
		@contacto int,
		@dataNasc DATE)
AS
BEGIN TRAN
	BEGIN TRY
		INSERT INTO HEALTHYPETVET.VETERINARIO VALUES(@nome, @nif, @contacto, @dataNasc)
	END TRY
	BEGIN CATCH

	END CATCH
COMMIT TRAN;

--DROP PROCEDURE HEALTHYPETVET.p_insertEnf
CREATE PROCEDURE HEALTHYPETVET.p_insertEnf (
		@nome varchar(150),
		@nif int,
		@contacto int,
		@dataNasc DATE)
AS
BEGIN TRAN
	BEGIN TRY
		INSERT INTO HEALTHYPETVET.ENFERMEIRO VALUES(@nome, @nif, @contacto, @dataNasc)
	END TRY
	BEGIN CATCH

	END CATCH
COMMIT TRAN;

--DROP PROCEDURE HEALTHYPETVET.p_insertCli
CREATE PROCEDURE HEALTHYPETVET.p_insertCli (
		@nome varchar(150),
		@nif int,
		@contacto int,
		@dataNasc DATE,
		@morada varchar(200))
AS
BEGIN TRAN
	BEGIN TRY
		INSERT INTO HEALTHYPETVET.CLIENTE VALUES(@nome, @nif, @contacto, @dataNasc, @morada)
	END TRY
	BEGIN CATCH

	END CATCH
COMMIT TRAN;

--DROP PROCEDURE HEALTHYPETVET.p_insertAni
CREATE PROCEDURE HEALTHYPETVET.p_insertAni (
		@nome varchar(150),
		@sexo char(1),
		@raca varchar(150),
		@dataNasc DATE,
		@nif int)
AS
BEGIN TRAN
	BEGIN TRY
		INSERT INTO HEALTHYPETVET.ANIMAL VALUES(@nome, @sexo, @raca, @dataNasc, @nif)
	END TRY
	BEGIN CATCH
	END CATCH
COMMIT TRAN;

--DROP PROCEDURE HEALTHYPETVET.p_insertEpi
CREATE PROCEDURE HEALTHYPETVET.p_insertEpi (
		@hora time,
		@dataEpi DATE,
		@NDocAni int,
		@NLicencaVet int,
		@opcao varchar(150))
AS
BEGIN TRAN
	BEGIN TRY
		INSERT INTO HEALTHYPETVET.EPISODIO VALUES(@hora, @dataEpi, @NDocAni, @NLicencaVet)
		DECLARE @NEpisodio AS int
		SET @NEpisodio = (SELECT TOP 1 NEpisodio FROM HEALTHYPETVET.EPISODIO ORDER BY NEpisodio DESC)
		IF	(@opcao = 'Consulta')
			INSERT INTO HEALTHYPETVET.CONSULTA_EPISODIO VALUES(@NEpisodio)
		IF	(@opcao = 'Cirurgia')
			INSERT INTO HEALTHYPETVET.CIRURGIA_EPISODIO VALUES(@NEpisodio)
		IF	(@opcao = 'Internamento')
			INSERT INTO HEALTHYPETVET.INTERNAMENTO_EPISODIO VALUES(@NEpisodio)
		IF	(@opcao = 'Exame')
			INSERT INTO HEALTHYPETVET.EXAME_EPISODIO VALUES(@NEpisodio)
	END TRY
	BEGIN CATCH

	END CATCH
COMMIT TRAN;

--DROP PROCEDURE HEALTHYPETVET.p_editVet
CREATE PROCEDURE HEALTHYPETVET.p_editVet (
		@nome varchar(150),
		@nif int,
		@contacto int,
		@dataNasc DATE)
AS
BEGIN TRAN
	BEGIN TRY
		UPDATE HEALTHYPETVET.VETERINARIO SET Nome = @nome, Contacto = @contacto  WHERE NIF = @nif
	END TRY
	BEGIN CATCH

	END CATCH
COMMIT TRAN;

--DROP PROCEDURE HEALTHYPETVET.p_editEnf
CREATE PROCEDURE HEALTHYPETVET.p_editEnf (
		@nome varchar(150),
		@nif int,
		@contacto int,
		@dataNasc DATE)
AS
BEGIN TRAN
	BEGIN TRY
		UPDATE HEALTHYPETVET.ENFERMEIRO SET Nome = @nome, Contacto = @contacto  WHERE NIF = @nif
	END TRY
	BEGIN CATCH

	END CATCH
COMMIT TRAN;

--DROP PROCEDURE HEALTHYPETVET.p_editCli
CREATE PROCEDURE HEALTHYPETVET.p_editCli (
		@nome varchar(150),
		@nif int,
		@contacto int,
		@dataNasc DATE,
		@morada varchar(200))
AS
BEGIN TRAN
	BEGIN TRY
		UPDATE HEALTHYPETVET.CLIENTE SET Nome = @nome, Contacto = @contacto, Morada = @morada  WHERE NIF = @nif
	END TRY
	BEGIN CATCH

	END CATCH
COMMIT TRAN;

--DROP PROCEDURE HEALTHYPETVET.p_editAni
CREATE PROCEDURE HEALTHYPETVET.p_editAni (
		@nome varchar(150),
		@sexo char(1),
		@raca varchar(150),
		@nDoc int,
		@nif int)

AS
BEGIN TRAN
	BEGIN TRY
		UPDATE HEALTHYPETVET.ANIMAL SET Nome = @nome, Sexo = @sexo, Raca = @raca, NIFCliente = @nif WHERE NDocumento = @nDoc
		END TRY
	BEGIN CATCH

	END CATCH
COMMIT TRAN;

--DROP PROCEDURE HEALTHYPETVET.p_editEpi
CREATE PROCEDURE HEALTHYPETVET.p_editEpi (
		@hora time,
		@dataEpi DATE,
		@NDocAni int,
		@NLicencaVet int,
		@nEpisodio int)
AS
BEGIN TRAN
	BEGIN TRY
		UPDATE HEALTHYPETVET.EPISODIO SET Hora = @hora, DataEpi = @dataEpi, NDocumentoAnimal = @NDocAni, NLicencaVet = @NLicencaVet WHERE NEpisodio = @nEpisodio
	END TRY
	BEGIN CATCH

	END CATCH
COMMIT TRAN;

--DROP PROCEDURE HEALTHYPETVET.p_deleteVet
CREATE PROCEDURE HEALTHYPETVET.p_deleteVet (
		@nif int)
AS
BEGIN TRAN

	BEGIN TRY
		DELETE FROM HEALTHYPETVET.VETERINARIO WHERE NIF = (
            SELECT NIF FROM HEALTHYPETVET.VETERINARIO AS Table1 WHERE Table1.NIF = @nif
            );
	END TRY
	BEGIN CATCH

	END CATCH

COMMIT TRAN;

--DROP PROCEDURE HEALTHYPETVET.p_deleteEnf
CREATE PROCEDURE HEALTHYPETVET.p_deleteEnf (
		@nif int)
AS
BEGIN TRAN

	BEGIN TRY
		DELETE FROM HEALTHYPETVET.ENFERMEIRO WHERE NIF = (
            SELECT NIF FROM HEALTHYPETVET.ENFERMEIRO AS Table1 WHERE Table1.NIF = @nif
            );
	END TRY
	BEGIN CATCH

	END CATCH

COMMIT TRAN;

--DROP PROCEDURE HEALTHYPETVET.p_deleteCli
CREATE PROCEDURE HEALTHYPETVET.p_deleteCli (
		@nif int)
AS
BEGIN TRAN

	BEGIN TRY
		DELETE FROM HEALTHYPETVET.CLIENTE WHERE NIF = (
            SELECT NIF FROM HEALTHYPETVET.CLIENTE AS Table1 WHERE Table1.NIF = @nif
            );
	END TRY
	BEGIN CATCH

	END CATCH

COMMIT TRAN;

--DROP PROCEDURE HEALTHYPETVET.p_deleteEpi
CREATE PROCEDURE HEALTHYPETVET.p_deleteEpi (
		@nEpi int)
AS
BEGIN TRAN

	BEGIN TRY
		DELETE FROM HEALTHYPETVET.EPISODIO WHERE NEpisodio = (
            SELECT NEpisodio FROM HEALTHYPETVET.EPISODIO AS Table1 WHERE Table1.NEpisodio = @nEpi
            );
	END TRY
	BEGIN CATCH

	END CATCH

COMMIT TRAN;

CREATE PROCEDURE HEALTHYPETVET.p_deleteAni (
		@nDocumento int)
AS
BEGIN TRAN

	BEGIN TRY
		DELETE FROM HEALTHYPETVET.ANIMAL WHERE NDocumento = (
            SELECT NDocumento FROM HEALTHYPETVET.ANIMAL AS Table1 WHERE Table1.NDocumento = @nDocumento
            );
	END TRY
	BEGIN CATCH

	END CATCH

COMMIT TRAN;
