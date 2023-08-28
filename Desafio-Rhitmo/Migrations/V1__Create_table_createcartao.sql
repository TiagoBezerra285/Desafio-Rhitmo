
CREATE TABLE IF NOT EXISTS `cadastroCartao` (
  `id` bigint(20) NOT NULL AUTO_INCREMENT,
  `name` varchar(80) NOT NULL,
  `email` varchar(80) NOT NULL,
  `cpf` varchar(15) NOT NULL,
  `endereco` varchar(100) NOT NULL,
  `cep` varchar(20) NOT NULL,
  `estado` varchar(20) NOT NULL,
  `codade` varchar(20) NOT NULL,
  `tipo_cartao` varchar(20) NOT NULL,
  `nome_cartao` varchar(20) NOT NULL,
  `numero_cartao` varchar(20) NOT NULL,
  `codigo_seguranca` varchar(100) NOT NULL,
  `data_expiracao` varchar(100) NOT NULL,
  PRIMARY KEY (`id`)
) 