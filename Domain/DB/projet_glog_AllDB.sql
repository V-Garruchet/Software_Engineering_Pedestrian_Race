-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1
-- Généré le :  Dim 09 déc. 2018 à 19:02
-- Version du serveur :  10.1.30-MariaDB
-- Version de PHP :  7.2.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;


--
-- Base de données :  `projet_glog`
--

-- --------------------------------------------------------

--
-- Création de la BDD
--

DROP DATABASE if exists projet_glog;

create database if not exists projet_glog character set utf8 collate utf8_unicode_ci;
use projet_glog;

grant all privileges on projet_glog.* to 'glog'@'localhost' identified by 'mdp';

-- --------------------------------------------------------

--
-- Structure de la table `course`
--

CREATE TABLE `course` (
  `course_id` int(11) NOT NULL,
  `course_nom` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `course_longueur` int(11) NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `course`
--

INSERT INTO `course` (`course_id`, `course_nom`,`course_longueur`) VALUES
(1, 'Course Bordeaux-Pessac',30000);

-- --------------------------------------------------------

--
-- Structure de la table `participant`
--

CREATE TABLE `participant` (
  `participant_numDossard` int(11) NOT NULL,
  `participant_nom` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `participant_prenom` varchar(255) COLLATE utf8_unicode_ci NOT NULL,
  `participant_sexe` char(1) COLLATE utf8_unicode_ci DEFAULT NULL,
  `participant_dateNaissance` datetime DEFAULT NULL,
  `participant_mail` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL,
  `participant_license` varchar(255) COLLATE utf8_unicode_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `participant`
--

INSERT INTO `participant` (`participant_numDossard`, `participant_nom`, `participant_prenom`, `participant_sexe`, `participant_dateNaissance`, `participant_mail`, `participant_license`) VALUES
(1, 'Cerond', 'Michel', 'M', '1956-11-01 00:00:00', 'mimich@yahoo.fr', 'MC1868'),
(2, 'Fanzo', 'Robert', 'M', '1964-08-09 00:00:00', 'rob@yahoo.fr', 'RF7652');

-- --------------------------------------------------------

--
-- Structure de la table `resultat`
--

CREATE TABLE `resultat` (
  `resultat_id` int(11) NOT NULL,
  `resultat_temps` datetime NOT NULL,
  `participant_numDossard` int(11) NOT NULL,
  `course_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Déchargement des données de la table `resultat`
--

INSERT INTO `resultat` (`resultat_id`, `resultat_temps`, `participant_numDossard`, `course_id`) VALUES
(1, '2018-11-26 03:18:32', 1, 1),
(2, '2018-11-26 02:58:43', 2, 1);

--
-- Index pour les tables déchargées
--

--
-- Index pour la table `course`
--
ALTER TABLE `course`
  ADD PRIMARY KEY (`course_id`);

--
-- Index pour la table `participant`
--
ALTER TABLE `participant`
  ADD PRIMARY KEY (`participant_numDossard`);

--
-- Index pour la table `resultat`
--
ALTER TABLE `resultat`
  ADD PRIMARY KEY (`resultat_id`),
  ADD KEY `participant_numDossard` (`participant_numDossard`),
  ADD KEY `course_id` (`course_id`);

--
-- AUTO_INCREMENT pour les tables déchargées
--

--
-- AUTO_INCREMENT pour la table `course`
--
ALTER TABLE `course`
  MODIFY `course_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT pour la table `participant`
--
ALTER TABLE `participant`
  MODIFY `participant_numDossard` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT pour la table `resultat`
--
ALTER TABLE `resultat`
  MODIFY `resultat_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Contraintes pour les tables déchargées
--

--
-- Contraintes pour la table `resultat`
--
ALTER TABLE `resultat`
  ADD CONSTRAINT `FKACFA0EDED47B7BB7` FOREIGN KEY (`participant_numDossard`) REFERENCES `participant` (`participant_numDossard`),
  ADD CONSTRAINT `FKACFA0EDEE668396C` FOREIGN KEY (`course_id`) REFERENCES `course` (`course_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
