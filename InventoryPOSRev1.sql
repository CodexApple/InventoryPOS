CREATE DATABASE  IF NOT EXISTS `inventory_pos` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `inventory_pos`;
-- MySQL dump 10.13  Distrib 8.0.32, for Win64 (x86_64)
--
-- Host: localhost    Database: inventory_pos
-- ------------------------------------------------------
-- Server version	8.0.32

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
-- Table structure for table `pos_sales`
--

DROP TABLE IF EXISTS `pos_sales`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pos_sales` (
  `sales_id` int DEFAULT NULL,
  `order_id` int DEFAULT NULL,
  `total_amount` decimal(10,0) DEFAULT NULL,
  `created_at` bigint DEFAULT NULL,
  `updated_at` bigint DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pos_sales`
--

LOCK TABLES `pos_sales` WRITE;
/*!40000 ALTER TABLE `pos_sales` DISABLE KEYS */;
/*!40000 ALTER TABLE `pos_sales` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pos_users`
--

DROP TABLE IF EXISTS `pos_users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pos_users` (
  `id` int NOT NULL AUTO_INCREMENT,
  `username` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `password` varchar(255) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `user_type` int DEFAULT NULL,
  `created_at` bigint DEFAULT NULL,
  `updated_at` bigint DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pos_users`
--

LOCK TABLES `pos_users` WRITE;
/*!40000 ALTER TABLE `pos_users` DISABLE KEYS */;
INSERT INTO `pos_users` VALUES (1,'admin','admin',3,1677686608,1677686608),(2,'user','user',2,1677687099,1677687099);
/*!40000 ALTER TABLE `pos_users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_orders`
--

DROP TABLE IF EXISTS `tbl_orders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_orders` (
  `id` int NOT NULL AUTO_INCREMENT,
  `order_id` int DEFAULT NULL,
  `product_id` int DEFAULT NULL,
  `order_quantity` varchar(255) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `order_date` bigint DEFAULT NULL,
  `created_at` bigint DEFAULT NULL,
  `updated_at` bigint DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_orders`
--

LOCK TABLES `tbl_orders` WRITE;
/*!40000 ALTER TABLE `tbl_orders` DISABLE KEYS */;
INSERT INTO `tbl_orders` VALUES (1,1,3,'5',1677696689,1677696689,1677696689),(2,1,2,'1',1677696689,1677696689,1677696689),(3,1,1,'2',1677696689,1677696689,1677696689),(4,2,1,'1',1677699517,1677699517,1677699517),(5,3,1,'2',1677699604,1677699604,1677699604),(6,3,2,'1',1677699604,1677699604,1677699604),(7,4,2,'1',1677700220,1677700220,1677700220),(8,4,1,'1',1677700220,1677700220,1677700220),(9,4,3,'1',1677700220,1677700220,1677700220),(10,4,3,'1',1677700220,1677700220,1677700220),(11,4,3,'1',1677700220,1677700220,1677700220),(12,5,3,'3',1677700456,1677700456,1677700456),(13,5,3,'1',1677700456,1677700456,1677700456),(14,5,1,'5',1677700456,1677700456,1677700456);
/*!40000 ALTER TABLE `tbl_orders` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_products`
--

DROP TABLE IF EXISTS `tbl_products`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_products` (
  `product_id` int NOT NULL AUTO_INCREMENT,
  `prod_name` varchar(255) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `prod_discount` int DEFAULT NULL,
  `prod_barcode` varchar(255) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `prod_dimension` varchar(255) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `prod_stock` int DEFAULT NULL,
  `prod_price` decimal(10,0) DEFAULT NULL,
  `prod_status` int DEFAULT NULL,
  `created_at` bigint DEFAULT NULL,
  `updated_at` bigint DEFAULT NULL,
  PRIMARY KEY (`product_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_products`
--

LOCK TABLES `tbl_products` WRITE;
/*!40000 ALTER TABLE `tbl_products` DISABLE KEYS */;
INSERT INTO `tbl_products` VALUES (1,'Product 1',0,'0000001','2x2',10,1000,1,1677688365,1677688365),(2,'Product 2',0,'0000002','3x3',10,2000,1,1677688365,1677688365),(3,'Product 3',0,'0000003','4s4',10,3000,1,1677688365,1677688365);
/*!40000 ALTER TABLE `tbl_products` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-03-02  4:04:09
