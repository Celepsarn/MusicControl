-- MySQL dump 10.16  Distrib 10.1.13-MariaDB, for Win32 (AMD64)
--
-- Host: localhost    Database: db_musiccontrol
-- ------------------------------------------------------
-- Server version	10.1.13-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `tbl_album`
--

DROP TABLE IF EXISTS `tbl_album`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_album` (
  `id_album` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(30) DEFAULT NULL,
  `releaseyear` year(4) DEFAULT NULL,
  `fk_genre` int(11) NOT NULL,
  `fk_interpret` int(11) NOT NULL,
  PRIMARY KEY (`id_album`),
  KEY `fk_genre` (`fk_genre`),
  KEY `fk_interpret` (`fk_interpret`),
  CONSTRAINT `tbl_album_ibfk_1` FOREIGN KEY (`fk_genre`) REFERENCES `tbl_genre` (`id_genre`),
  CONSTRAINT `tbl_album_ibfk_2` FOREIGN KEY (`fk_interpret`) REFERENCES `tbl_interpret` (`id_interpret`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_album`
--

LOCK TABLES `tbl_album` WRITE;
/*!40000 ALTER TABLE `tbl_album` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_album` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_genre`
--

DROP TABLE IF EXISTS `tbl_genre`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_genre` (
  `id_genre` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`id_genre`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_genre`
--

LOCK TABLES `tbl_genre` WRITE;
/*!40000 ALTER TABLE `tbl_genre` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_genre` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_interpret`
--

DROP TABLE IF EXISTS `tbl_interpret`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_interpret` (
  `id_interpret` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(30) DEFAULT NULL,
  `foundationyear` year(4) DEFAULT NULL,
  `land` varchar(25) DEFAULT NULL,
  PRIMARY KEY (`id_interpret`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_interpret`
--

LOCK TABLES `tbl_interpret` WRITE;
/*!40000 ALTER TABLE `tbl_interpret` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_interpret` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_song`
--

DROP TABLE IF EXISTS `tbl_song`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_song` (
  `id_song` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(30) DEFAULT NULL,
  `trackno` int(11) DEFAULT NULL,
  `duration` varchar(5) DEFAULT NULL,
  `songtext` text,
  `fk_album` int(11) NOT NULL,
  PRIMARY KEY (`id_song`),
  KEY `fk_album` (`fk_album`),
  CONSTRAINT `tbl_song_ibfk_1` FOREIGN KEY (`fk_album`) REFERENCES `tbl_album` (`id_album`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_song`
--

LOCK TABLES `tbl_song` WRITE;
/*!40000 ALTER TABLE `tbl_song` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_song` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-05-16 16:18:39
