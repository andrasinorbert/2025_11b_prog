CREATE DATABASE IF NOT EXISTS `2025_11b` DEFAULT CHARACTER SET utf8 COLLATE utf8_hungarian_ci;
USE `2025_11b`;


CREATE TABLE `névkor` (
  `Név` varchar(50) DEFAULT NULL,
  `Kor` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;
INSERT INTO `névkor` (`Név`, `Kor`) VALUES
('Micimackó', 20),
('Malacka', 12);

CREATE TABLE `szeret` (
  `név` varchar(50) DEFAULT NULL,
  `gyümölcs` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;
INSERT INTO `szeret` (`név`, `gyümölcs`) VALUES
('Micimackó', 'méz'),
('Micimackó', 'málna'),
('Malacka', 'méz'),
('Kanga', 'banán');