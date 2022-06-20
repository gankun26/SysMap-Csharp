use SysMap
go

CREATE TRIGGER ENVIAR_EMAIL_VENDA
ON VENDAS
AFTER INSERT
AS
EXEC msdb.dbo.sp_send_dbmail
@profile_name = 'SysPerfil',
@recipients = 'contato@sysmap.com.br',
@subject = 'Novo Insert Produto',
@body = 'Uma nova venda foi criada!',
@body_format 