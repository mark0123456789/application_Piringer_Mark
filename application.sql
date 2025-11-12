-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2025. Nov 12. 08:32
-- Kiszolgáló verziója: 10.4.32-MariaDB
-- PHP verzió: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `application`
--
CREATE DATABASE IF NOT EXISTS `application` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `application`;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `datas`
--

CREATE TABLE IF NOT EXISTS `datas` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Version` int(50) NOT NULL,
  `Username` varchar(50) NOT NULL,
  `Password` varchar(36) NOT NULL,
  `RegTime` datetime NOT NULL DEFAULT current_timestamp(),
  `ModTime` datetime NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
