CREATE DATABASE M_Peoples;
GO

USE M_Peoples;
GO

CREATE TABLE TBL_Funcionario(
	IdFuncionario INT PRIMARY KEY IDENTITY,
	Nome VARCHAR(255) NOT NULL,
	Sobrenome VARCHAR(200) NOT NULL
);

SELECT*FROM TBL_Funcionario;
