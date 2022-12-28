-- MySQL dump 10.13  Distrib 8.0.18, for Win64 (x86_64)
--
-- Host: localhost    Database: garage
-- ------------------------------------------------------
-- Server version	8.0.18

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `parts_ch`
--

DROP TABLE IF EXISTS `parts_ch`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `parts_ch` (
  `parts_changed` varchar(40) DEFAULT NULL,
  `quantity` int(11) DEFAULT NULL,
  `price` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `parts_ch`
--

LOCK TABLES `parts_ch` WRITE;
/*!40000 ALTER TABLE `parts_ch` DISABLE KEYS */;
INSERT INTO `parts_ch` VALUES ('wheels',1,3000),('wheels',1,3000),('jdksjd',1,9000),('sfdf',2,6000),('kjj',1,1000),('fgd',1,2000),('hjh',1,1000),('jkkj',2,2000),('sdhj',3,3000),('jjj',1,1000),('bnns',2,3000),('jksj',3,2000),('jjj',1,1000),('bnns',2,3000),('jksj',3,2000),('jjj',1,1000),('bnns',2,3000),('jksj',3,2000),('kjas',1,1000),('bbxn',2,50),('dssjd',3,1000),('kjas',1,1000),('bbxn',2,50),('dssjd',3,1000),('hgh',4,100),('hgh',4,100),('dffd',1,100),('dss',1,1111),('wqu',1,1000),('dfdf',1,1000),('wqe',1,1000),('kd',1,1000),('SD',3,1000),('GG',8,1000),('JK',9,1000),('DG',10,9000),('GG',17,100),('V',11,1000),('9',9,1000),('HJ',89,1000),('WE',13,1000),('WE',13,1000),('DS',19,1000),('S',11,1000),('WHEELS',11,1000),('WHKK',18,1000),('FGGG',11,1000),('dffhjd',11,1000),('hjj',10,1000),('tires',4,3000),('drive shaft',1,2000),('turbo charger',2,2700),('wheels',4,1000),('wheels',4,1000),('wheels',3,3000),('wheels',3,3000);
/*!40000 ALTER TABLE `parts_ch` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-11-05 10:00:18
