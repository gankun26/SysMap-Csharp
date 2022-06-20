CREATE TRIGGER ENVIAR_EMAIL_PRODUTO
ON PRODUTOS
AFTER INSERT
AS
EXEC msdb.dbo.sp_send_dbmail
@profile_name = 'SysPerfil',
@recipients = 'contato@sysmap.com.br',
@subject = 'Novo Insert Produto',
@body = 'Um novo produto foi inserido na tabela TB_PRODUTOS',
@body_format = 'HTML';