-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 25-Jan-2021 às 16:01
-- Versão do servidor: 10.4.11-MariaDB
-- versão do PHP: 7.3.15

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `super`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `candidatos`
--

CREATE TABLE `candidatos` (
  `idcandidato` int(9) NOT NULL,
  `nome` varchar(200) DEFAULT NULL,
  `experiencia` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `candidatos`
--

INSERT INTO `candidatos` (`idcandidato`, `nome`, `experiencia`) VALUES
(1, 'João Paulo', 'Atendente de padaria'),
(2, 'Adamastor Júnior', 'Repositor'),
(3, 'Ana Cláudia', 'Atendente de caixa'),
(4, 'Daltron Silva', 'Mecânico de carros'),
(5, 'Tiel Evandro', 'Lavador de carros'),
(6, 'Amanda Carvalho', 'Atendente de caixa'),
(7, 'Clóvis Nogueira', 'Atendente de padaria'),
(8, 'Jorge Pereira', 'Coveiro');

-- --------------------------------------------------------

--
-- Estrutura da tabela `consumidor`
--

CREATE TABLE `consumidor` (
  `idConsumidor` int(11) NOT NULL,
  `tipoConsumidor` varchar(80) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `consumidor`
--

INSERT INTO `consumidor` (`idConsumidor`, `tipoConsumidor`) VALUES
(1, 'consumidor final');

-- --------------------------------------------------------

--
-- Estrutura da tabela `fornecedores`
--

CREATE TABLE `fornecedores` (
  `idfornecedor` int(9) NOT NULL,
  `nomeProduto` varchar(200) DEFAULT NULL,
  `valorProduto` double(9,2) DEFAULT NULL,
  `quantidadeProduto` int(9) DEFAULT NULL,
  `setor` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `fornecedores`
--

INSERT INTO `fornecedores` (`idfornecedor`, `nomeProduto`, `valorProduto`, `quantidadeProduto`, `setor`) VALUES
(1, 'Leite integral', 2.00, 100, 'Padaria'),
(2, 'Pão de manteiga', 3.50, 125, 'Padaria'),
(3, 'Manteiga', 5.99, 60, 'Padaria'),
(4, 'Doce de morango', 2.90, 50, 'Padaria'),
(5, 'Queijo fatiado', 18.90, 60, 'Padaria'),
(6, 'Desodorante', 8.99, 100, 'Perfumaria'),
(7, 'Xampu', 6.99, 200, 'Perfumaria'),
(8, 'Condicionador', 8.90, 50, 'Perfumaria'),
(9, 'Sabonete', 0.89, 500, 'Perfumaria'),
(10, 'Cotonete', 2.50, 100, 'Perfumaria'),
(11, 'Batata-branca', 1.90, 100, 'Hortifruti'),
(12, 'Tomate', 3.90, 58, 'Hortifruti'),
(13, 'Cebola roxa', 2.99, 50, 'Hortifruti'),
(14, 'Abóbora', 0.98, 90, 'Hortifruti'),
(15, 'Pimentão', 5.99, 60, 'Hortifruti'),
(16, 'Arroz', 2.50, 200, 'Alimentos'),
(17, 'Feijão', 3.69, 250, 'Alimentos'),
(18, 'Farinha', 2.19, 500, 'Alimentos'),
(19, 'Açúcar', 2.39, 100, 'Alimentos'),
(20, 'Óleo de soja', 2.99, 300, 'Alimentos');

-- --------------------------------------------------------

--
-- Estrutura da tabela `funcionarios`
--

CREATE TABLE `funcionarios` (
  `idFuncionario` int(11) NOT NULL,
  `nomeFuncionario` varchar(200) DEFAULT NULL,
  `setorFuncionario` varchar(80) DEFAULT NULL,
  `cpf` varchar(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `funcionarios`
--

INSERT INTO `funcionarios` (`idFuncionario`, `nomeFuncionario`, `setorFuncionario`, `cpf`) VALUES
(1, 'João Paulo', 'Atendente de padaria', '00061690935'),
(2, 'Adamastor Júnior', 'Repositor', '45061690935'),
(3, 'Amanda Carvalho', 'Atendente de caixa', '33256987525');

-- --------------------------------------------------------

--
-- Estrutura da tabela `itensvendidos`
--

CREATE TABLE `itensvendidos` (
  `idProduto` int(11) NOT NULL,
  `idVenda` int(11) NOT NULL,
  `quantidadeVendida` int(11) DEFAULT NULL,
  `valorProduto` double(9,2) DEFAULT NULL,
  `valorTotalProduto` double(9,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `itensvendidos`
--

INSERT INTO `itensvendidos` (`idProduto`, `idVenda`, `quantidadeVendida`, `valorProduto`, `valorTotalProduto`) VALUES
(1, 1, 40, 2.40, 96.00),
(2, 1, 100, 4.20, 420.00),
(3, 1, 10, 3.00, 30.00),
(4, 1, 5, 1.18, 5.90),
(5, 1, 90, 3.00, 270.00);

-- --------------------------------------------------------

--
-- Estrutura da tabela `produtos`
--

CREATE TABLE `produtos` (
  `idProduto` int(11) NOT NULL,
  `nomeProduto` varchar(200) DEFAULT NULL,
  `valorProduto` double(9,2) DEFAULT NULL,
  `quantidadeProduto` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `produtos`
--

INSERT INTO `produtos` (`idProduto`, `nomeProduto`, `valorProduto`, `quantidadeProduto`) VALUES
(1, 'Leite integral', 2.40, 50),
(2, 'Pão de manteiga', 4.20, 100),
(3, 'Cotonete', 3.00, 10),
(4, 'Abóbora', 1.18, 5),
(5, 'Arroz', 3.00, 100);

-- --------------------------------------------------------

--
-- Estrutura da tabela `selecionados`
--

CREATE TABLE `selecionados` (
  `idselecionado` int(9) NOT NULL,
  `idcandidato` int(11) DEFAULT NULL,
  `cpf` varchar(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `selecionados`
--

INSERT INTO `selecionados` (`idselecionado`, `idcandidato`, `cpf`) VALUES
(1, 1, '00061690935'),
(2, 2, '45061690935'),
(3, 3, '09865880935'),
(4, 4, '12348956365'),
(5, 5, '88896532535'),
(6, 6, '33256987525'),
(7, 7, '00235656565'),
(8, 8, '77785545855');

-- --------------------------------------------------------

--
-- Estrutura da tabela `venda`
--

CREATE TABLE `venda` (
  `idVenda` int(11) NOT NULL,
  `idConsumidor` int(11) NOT NULL,
  `valorTotalVenda` double(9,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `venda`
--

INSERT INTO `venda` (`idVenda`, `idConsumidor`, `valorTotalVenda`) VALUES
(1, 1, 821.90);

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `candidatos`
--
ALTER TABLE `candidatos`
  ADD PRIMARY KEY (`idcandidato`);

--
-- Índices para tabela `consumidor`
--
ALTER TABLE `consumidor`
  ADD PRIMARY KEY (`idConsumidor`);

--
-- Índices para tabela `fornecedores`
--
ALTER TABLE `fornecedores`
  ADD PRIMARY KEY (`idfornecedor`);

--
-- Índices para tabela `funcionarios`
--
ALTER TABLE `funcionarios`
  ADD PRIMARY KEY (`idFuncionario`);

--
-- Índices para tabela `itensvendidos`
--
ALTER TABLE `itensvendidos`
  ADD PRIMARY KEY (`idProduto`,`idVenda`),
  ADD KEY `fk_venda` (`idVenda`);

--
-- Índices para tabela `produtos`
--
ALTER TABLE `produtos`
  ADD PRIMARY KEY (`idProduto`);

--
-- Índices para tabela `selecionados`
--
ALTER TABLE `selecionados`
  ADD PRIMARY KEY (`idselecionado`),
  ADD KEY `candidatos` (`idcandidato`);

--
-- Índices para tabela `venda`
--
ALTER TABLE `venda`
  ADD PRIMARY KEY (`idVenda`),
  ADD KEY `fk_consumidor` (`idConsumidor`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `candidatos`
--
ALTER TABLE `candidatos`
  MODIFY `idcandidato` int(9) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT de tabela `consumidor`
--
ALTER TABLE `consumidor`
  MODIFY `idConsumidor` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT de tabela `fornecedores`
--
ALTER TABLE `fornecedores`
  MODIFY `idfornecedor` int(9) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT de tabela `funcionarios`
--
ALTER TABLE `funcionarios`
  MODIFY `idFuncionario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de tabela `produtos`
--
ALTER TABLE `produtos`
  MODIFY `idProduto` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT de tabela `selecionados`
--
ALTER TABLE `selecionados`
  MODIFY `idselecionado` int(9) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT de tabela `venda`
--
ALTER TABLE `venda`
  MODIFY `idVenda` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `itensvendidos`
--
ALTER TABLE `itensvendidos`
  ADD CONSTRAINT `fk_produtos` FOREIGN KEY (`idProduto`) REFERENCES `produtos` (`idProduto`),
  ADD CONSTRAINT `fk_venda` FOREIGN KEY (`idVenda`) REFERENCES `venda` (`idVenda`);

--
-- Limitadores para a tabela `selecionados`
--
ALTER TABLE `selecionados`
  ADD CONSTRAINT `candidatos` FOREIGN KEY (`idcandidato`) REFERENCES `candidatos` (`idcandidato`);

--
-- Limitadores para a tabela `venda`
--
ALTER TABLE `venda`
  ADD CONSTRAINT `fk_consumidor` FOREIGN KEY (`idConsumidor`) REFERENCES `consumidor` (`idConsumidor`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
