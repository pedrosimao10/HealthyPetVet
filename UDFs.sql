--DROP FUNCTION getAnimaisPorRaca
CREATE FUNCTION getAnimaisPorRaca(@raca VARCHAR(150)) RETURNS Table AS
	RETURN(SELECT *
			FROM HEALTHYPETVET.ANIMAL AS Table1
			WHERE Table1.Raca = @raca)

--DROP FUNCTION getAnimaisPorSexo
CREATE FUNCTION getAnimaisPorSexo(@sexo CHAR(1)) RETURNS Table AS
	RETURN(SELECT *
			FROM HEALTHYPETVET.ANIMAL AS Table1
			WHERE Table1.Sexo = @sexo)

--DROP FUNCTION getAnimaisPorSexoRaca
CREATE FUNCTION getAnimaisPorSexoRaca(@raca VARCHAR(150), @sexo CHAR(1)) RETURNS Table AS
	RETURN(SELECT *
			FROM HEALTHYPETVET.ANIMAL AS Table1
			WHERE Table1.Raca = @raca AND Table1.Sexo = @sexo)