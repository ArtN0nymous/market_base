/*
SQLyog Enterprise - MySQL GUI v6.07
Host - 5.6.24 : Database - punto_de_venta
*********************************************************************
Server version : 5.6.24
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

create database if not exists `punto_de_venta`;

USE `punto_de_venta`;

/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

/*Table structure for table `categorias` */

DROP TABLE IF EXISTS `categorias`;

CREATE TABLE `categorias` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `categoria` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=latin1;

/*Data for the table `categorias` */

insert  into `categorias`(`id`,`categoria`) values (1,'Bebidas'),(2,'Botanas'),(3,'Carnes'),(4,'Chocolates'),(5,'Dulces'),(6,'Embutidos'),(7,'Frutas'),(8,'Galletas'),(9,'Juguetes'),(10,'Limpieza'),(11,'Pan'),(12,'Otros');

/*Table structure for table `cliente` */

DROP TABLE IF EXISTS `cliente`;

CREATE TABLE `cliente` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) DEFAULT NULL,
  `apellido` varchar(100) DEFAULT NULL,
  `direccion` varchar(100) DEFAULT NULL,
  `telefono` varchar(100) DEFAULT NULL,
  `deuda_actual` double DEFAULT NULL,
  `ultimo_pago` double DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `estatus` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=latin1;

/*Data for the table `cliente` */

insert  into `cliente`(`id`,`nombre`,`apellido`,`direccion`,`telefono`,`deuda_actual`,`ultimo_pago`,`fecha`,`estatus`) values (1,'Juan','Ramirez','Calle Flores 3456','6678785643',3500,100,'2005-12-01',1),(2,'Juan','Ramirez','Calle Flores 3456',NULL,0,100,'2020-03-11',1),(3,'Juan','Ramirez','Calle Flores 3456',NULL,0,3500,'2020-03-11',1),(4,'Juan','Ramirez','Calle Flores 3456','6678785643',0,3500,'2020-03-11',1),(6,'nombre','apellido','direccion','telefono',0,0,'2020-03-11',1),(7,'Juan','Ramirez','Calle Flores 3456','6678785643',0,3500,'2020-03-11',1),(9,'nombre','apellido','direccion','telefono',89,0,'2020-03-11',1),(10,'Juan','Ramirez','Calle Flores 3456','6678785643',1625,3500,'2020-03-15',1),(11,'Juan','Ramirez','Calle Flores 3456','6678785643',1625,3500,'2020-03-15',1),(12,'Juan','Ramirez','Calle Flores 3456','6678785643',26000,3500,'2020-03-15',1),(13,'Pedro','Alvarez','CALLE TULA 3423',NULL,NULL,0,'2020-03-18',1),(15,'Oneida','Nuñez','Tamazula',NULL,NULL,0,'2020-03-18',1),(16,'Juan','Ramirez','Calle Flores 3456','6678785643',7,3500,'2020-03-18',1);

/*Table structure for table `comprass` */

DROP TABLE IF EXISTS `comprass`;

CREATE TABLE `comprass` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `codigo` int(100) DEFAULT NULL,
  `producto` varchar(100) DEFAULT NULL,
  `p_unidad` double NOT NULL,
  `p_mayoreo` double NOT NULL,
  `departamento` varchar(100) DEFAULT NULL,
  `categoria` varchar(100) DEFAULT NULL,
  `cantidad` int(100) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `comprass` */

/*Table structure for table `departamentos` */

DROP TABLE IF EXISTS `departamentos`;

CREATE TABLE `departamentos` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `Departamento` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

/*Data for the table `departamentos` */

insert  into `departamentos`(`id`,`Departamento`) values (1,'Alimentos'),(2,'Dulceria'),(3,'Jugueteria'),(4,'Salud'),(5,'Otros');

/*Table structure for table `importe` */

DROP TABLE IF EXISTS `importe`;

CREATE TABLE `importe` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) DEFAULT NULL,
  `estatus` tinyint(1) DEFAULT NULL,
  `cantidad` double DEFAULT NULL,
  `precio` double DEFAULT NULL,
  `importe` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `importe` */

/*Table structure for table `producto` */

DROP TABLE IF EXISTS `producto`;

CREATE TABLE `producto` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `codigo` int(11) DEFAULT NULL,
  `descripcion` varchar(100) DEFAULT NULL,
  `precio_unidad` double DEFAULT NULL,
  `precio_mayoreo` double DEFAULT NULL,
  `departamento` varchar(100) DEFAULT NULL,
  `categoria` varchar(100) DEFAULT NULL,
  `estatus` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=latin1;

/*Data for the table `producto` */

insert  into `producto`(`id`,`codigo`,`descripcion`,`precio_unidad`,`precio_mayoreo`,`departamento`,`categoria`,`estatus`) values (3,2020,'Manzana',7,5,'Alimentos','Frutas',1),(4,2021,'Pera',9,8,'Alimentos','Frutas',1),(5,2022,'Doritos Nachos',13,10,'Alimentos','Botanas',1),(6,2023,'Coca cola 600ml',14,12,'Alimentos','Bebidas',1),(11,2028,'Rosca Chica Chocolate',350,300,'Alimentos','Pan',0),(12,2029,'Piña dulce',45,35,'Alimentos','Frutas',1),(13,2030,'Atun aleta amarilla 230g',40,30,'Alimentos','Otros',1),(16,2024,'Pepsi 440ml',10,5,'Alimentos','Bebidas',1),(18,2025,'Yogurt',23,20,'Alimentos','Bebidas',1);

/*Table structure for table `registro` */

DROP TABLE IF EXISTS `registro`;

CREATE TABLE `registro` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) DEFAULT NULL,
  `apellido` varchar(100) DEFAULT NULL,
  `direccion` varchar(100) DEFAULT NULL,
  `telefono` varchar(100) DEFAULT NULL,
  `total` double DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=29 DEFAULT CHARSET=latin1;

/*Data for the table `registro` */

insert  into `registro`(`id`,`nombre`,`apellido`,`direccion`,`telefono`,`total`,`fecha`) values (8,'nombre','apellido','direccion','telefono',0,'2020-03-11'),(9,'Juan','Ramirez','Calle Flores 3456','6678785643',0,'2020-03-11'),(10,'nombre','apellido','direccion','telefono',0,'2020-03-11'),(11,'nombre','apellido','direccion','telefono',0,'2020-03-11'),(12,'nombre','apellido','direccion','telefono',0,'2020-03-11'),(13,'nombre','apellido','direccion','telefono',89,'2020-03-11'),(14,'nombre','apellido','direccion','telefono',411,'2020-03-15'),(15,'nombre','apellido','direccion','telefono',411,'2020-03-15'),(16,'nombre','apellido','direccion','telefono',45,'2020-03-15'),(17,'nombre','apellido','direccion','telefono',46,'2020-03-15'),(18,'nombre','apellido','direccion','telefono',0,'2020-03-15'),(19,'nombre','apellido','direccion','telefono',0,'2020-03-15'),(20,'nombre','apellido','direccion','telefono',1800,'2020-03-15'),(21,'nombre','apellido','direccion','telefono',150,'2020-03-15'),(22,'nombre','apellido','direccion','telefono',83,'2020-03-18'),(23,'nombre','apellido','direccion','telefono',2306,'2020-03-18'),(24,'nombre','apellido','direccion','telefono',0,'2020-03-18'),(25,'nombre','apellido','direccion','telefono',1800,'2020-03-18'),(26,'nombre','apellido','direccion','telefono',1350,'2020-03-18'),(27,'nombre','apellido','direccion','telefono',1350,'2020-03-18'),(28,'nombre','apellido','direccion','telefono',1350,'2020-03-18');

/*Table structure for table `reporte` */

DROP TABLE IF EXISTS `reporte`;

CREATE TABLE `reporte` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) DEFAULT NULL,
  `apellido` varchar(100) DEFAULT NULL,
  `telefono` varchar(100) DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  `report` varchar(250) DEFAULT NULL,
  `direccion` varchar(250) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

/*Data for the table `reporte` */

insert  into `reporte`(`id`,`nombre`,`apellido`,`telefono`,`fecha`,`report`,`direccion`) values (1,'Juan','Ramirez','Calle Flores 3456','2020-03-18','PAGO ATRAZADO',NULL);

/*Table structure for table `usuario` */

DROP TABLE IF EXISTS `usuario`;

CREATE TABLE `usuario` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `usuario` varchar(100) DEFAULT NULL,
  `password` varchar(100) DEFAULT NULL,
  `estatus` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;

/*Data for the table `usuario` */

insert  into `usuario`(`id`,`usuario`,`password`,`estatus`) values (3,'usuario','password',1),(5,'usuario3','password',1);

/*Table structure for table `venta` */

DROP TABLE IF EXISTS `venta`;

CREATE TABLE `venta` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) DEFAULT NULL,
  `apellido` varchar(100) DEFAULT NULL,
  `pago` double DEFAULT NULL,
  `fecha` date DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `venta` */

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
