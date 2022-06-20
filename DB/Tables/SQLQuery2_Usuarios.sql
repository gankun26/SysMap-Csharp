USE SysMap
GO
CREATE TABLE USUARIOS(
ID INT NOT NULL PRIMARY KEY,
NOME VARCHAR(100) NULL,
DAT_NASCIMENTO DATE NULL,
DAT_CRIACAO DATETIME NULL,
DAT_ALTERACAO DATETIME NULL,
DAT_EXCLUSAO DATETIME NULL,
CRIADO_POR_USU_ID INT NULL,
ALTERADO_POR_USU_ID INT NULL,
EXCLUIDO_POR_USU_ID INT NULL,
IND_ATIVO BIT NULL
);