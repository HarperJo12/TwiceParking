# SQL Manager 2005 Lite for MySQL 3.7.6.2
# ---------------------------------------
# Host     : localhost
# Port     : 3306
# Database : sistem_parkir


SET FOREIGN_KEY_CHECKS=0;

DROP DATABASE IF EXISTS `sistem_parkir`;

CREATE DATABASE `sistem_parkir`
    CHARACTER SET 'latin1'
    COLLATE 'latin1_swedish_ci';

USE `sistem_parkir`;

#
# Structure for the `admin` table : 
#

DROP TABLE IF EXISTS `admin`;

CREATE TABLE `admin` (
  `no_ID` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(30) DEFAULT NULL,
  `password` char(41) DEFAULT NULL,
  PRIMARY KEY (`no_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Structure for the `member` table : 
#

DROP TABLE IF EXISTS `member`;

CREATE TABLE `member` (
  `no_ID` int(11) NOT NULL AUTO_INCREMENT,
  `nama` varchar(50) DEFAULT NULL,
  `alamat` varchar(50) DEFAULT NULL,
  `telepon` varchar(20) DEFAULT NULL,
  `wallet` int(11) DEFAULT NULL,
  `email` varchar(100) NOT NULL,
  PRIMARY KEY (`no_ID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

#
# Structure for the `kartu` table : 
#

DROP TABLE IF EXISTS `kartu`;

CREATE TABLE `kartu` (
  `Id_kartu` varchar(30) NOT NULL,
  `no_ID` int(11) DEFAULT NULL,
  PRIMARY KEY (`Id_kartu`),
  KEY `No_ID` (`no_ID`),
  CONSTRAINT `kartu_Idmember_fk` FOREIGN KEY (`no_ID`) REFERENCES `member` (`no_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Structure for the `parkiran` table : 
#

DROP TABLE IF EXISTS `parkiran`;

CREATE TABLE `parkiran` (
  `no_parkiran` int(11) NOT NULL AUTO_INCREMENT,
  `jml` int(6) DEFAULT NULL,
  `tarif_per_jam` int(9) DEFAULT NULL,
  `jumlah_tersedia` int(6) DEFAULT NULL,
  PRIMARY KEY (`no_parkiran`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

#
# Structure for the `pin` table : 
#

DROP TABLE IF EXISTS `pin`;

CREATE TABLE `pin` (
  `pin` varchar(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

#
# Structure for the `transaksi_parkir` table : 
#

DROP TABLE IF EXISTS `transaksi_parkir`;

CREATE TABLE `transaksi_parkir` (
  `no_transaksi` int(11) NOT NULL AUTO_INCREMENT,
  `jam_masuk` datetime DEFAULT NULL,
  `jam_keluar` datetime DEFAULT NULL,
  `total_biaya` int(15) DEFAULT NULL,
  `noID` int(11) DEFAULT NULL,
  `no_parkir` int(11) DEFAULT NULL,
  PRIMARY KEY (`no_transaksi`),
  KEY `noID` (`noID`),
  KEY `no_parkir` (`no_parkir`),
  CONSTRAINT `transaksi_parkir_noid_fk` FOREIGN KEY (`noID`) REFERENCES `member` (`no_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `transaksi_parkir_noparkir_fk` FOREIGN KEY (`no_parkir`) REFERENCES `parkiran` (`no_parkiran`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

#
# Structure for the `transaksi_topup` table : 
#

DROP TABLE IF EXISTS `transaksi_topup`;

CREATE TABLE `transaksi_topup` (
  `no_transaksi` int(11) NOT NULL AUTO_INCREMENT,
  `tgl_transaksi` date DEFAULT NULL,
  `id_member` int(11) DEFAULT NULL,
  `wallet` int(11) DEFAULT NULL,
  `topup` int(11) DEFAULT NULL,
  PRIMARY KEY (`no_transaksi`),
  KEY `id_member` (`id_member`),
  CONSTRAINT `transaksi_topup_idmember_fk` FOREIGN KEY (`id_member`) REFERENCES `member` (`no_ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;

#
# Definition for the `deleteAdmin` procedure : 
#

DROP PROCEDURE IF EXISTS `deleteAdmin`;

CREATE PROCEDURE `deleteAdmin`(IN a INTEGER(11))
    NOT DETERMINISTIC
    CONTAINS SQL
    SQL SECURITY INVOKER
    COMMENT ''
BEGIN
     DECLARE CONTINUE HANDLER FOR 1011
     SELECT 'Gagal Hapus data admin';
     DELETE FROM `admin`  WHERE no_ID = a;
     SELECT 'Data berhasil dihapus !';
END;

#
# Definition for the `deleteKartu` procedure : 
#

DROP PROCEDURE IF EXISTS `deleteKartu`;

CREATE PROCEDURE `deleteKartu`(IN a VARCHAR(30))
    NOT DETERMINISTIC
    CONTAINS SQL
    SQL SECURITY INVOKER
    COMMENT ''
BEGIN
     DECLARE CONTINUE HANDLER FOR 1011
     SELECT 'Gagal Hapus data kartu';
     DELETE FROM `kartu`  WHERE Id_kartu = a;
     SELECT 'Data berhasil dihapus !';
END;

#
# Definition for the `deleteMember` procedure : 
#

DROP PROCEDURE IF EXISTS `deleteMember`;

CREATE PROCEDURE `deleteMember`(IN a INTEGER(11))
    NOT DETERMINISTIC
    CONTAINS SQL
    SQL SECURITY INVOKER
    COMMENT ''
BEGIN
     DECLARE CONTINUE HANDLER FOR 1011
     SELECT 'Gagal Hapus data member';
     DELETE FROM `member`  WHERE no_ID = a;
     SELECT 'Data berhasil dihapus !';
END;

#
# Definition for the `deleteParkiran` procedure : 
#

DROP PROCEDURE IF EXISTS `deleteParkiran`;

CREATE PROCEDURE `deleteParkiran`(IN a INTEGER(11))
    NOT DETERMINISTIC
    CONTAINS SQL
    SQL SECURITY INVOKER
    COMMENT ''
BEGIN
     DECLARE CONTINUE HANDLER FOR 1011
     SELECT 'Gagal Hapus data parkiran';
     DELETE FROM `parkiran`  WHERE no_parkiran = a;
     SELECT 'Data berhasil dihapus !';
END;

#
# Definition for the `insertAdmin` procedure : 
#

DROP PROCEDURE IF EXISTS `insertAdmin`;

CREATE PROCEDURE `insertAdmin`(IN a VARCHAR(30), IN b VARCHAR(50))
    NOT DETERMINISTIC
    CONTAINS SQL
    SQL SECURITY INVOKER
    COMMENT ''
BEGIN
     DECLARE CONTINUE HANDLER FOR 1062
     SELECT 'ID Admin SUDAH ADA';
     INSERT INTO admin(username, password)
     VALUES (a, password(b));
     SELECT 'Data Berhasil ditambahkan !';
END;

#
# Definition for the `insertKartu` procedure : 
#

DROP PROCEDURE IF EXISTS `insertKartu`;

CREATE PROCEDURE `insertKartu`(IN a VARCHAR(30), IN b INTEGER(11))
    NOT DETERMINISTIC
    CONTAINS SQL
    SQL SECURITY INVOKER
    COMMENT ''
BEGIN
     DECLARE CONTINUE HANDLER FOR 1062
     SELECT 'ID Kartu SUDAH ADA';
     INSERT INTO kartu(Id_kartu, No_ID)
     VALUES (a, b);
     SELECT 'Data Berhasil ditambahkan !';
END;

#
# Definition for the `insertMember` procedure : 
#

DROP PROCEDURE IF EXISTS `insertMember`;

CREATE PROCEDURE `insertMember`(IN a VARCHAR(50), IN b VARCHAR(50), IN c VARCHAR(20), IN d INTEGER(11), IN e VARCHAR(100))
    NOT DETERMINISTIC
    CONTAINS SQL
    SQL SECURITY INVOKER
    COMMENT ''
BEGIN
     DECLARE CONTINUE HANDLER FOR 1062
     SELECT 'ID Member SUDAH ADA';
     INSERT INTO Member(nama, alamat, telepon, wallet, email)
     VALUES (a, b, c, d, e);
     SELECT 'Data Berhasil ditambahkan !';
END;

#
# Definition for the `insertParkiran` procedure : 
#

DROP PROCEDURE IF EXISTS `insertParkiran`;

CREATE PROCEDURE `insertParkiran`(IN a INTEGER(6), IN b INTEGER(9))
    NOT DETERMINISTIC
    CONTAINS SQL
    SQL SECURITY INVOKER
    COMMENT ''
BEGIN
     DECLARE CONTINUE HANDLER FOR 1062
     SELECT 'No Parkiran SUDAH ADA';
     INSERT INTO parkiran(jml, tarif_per_jam)
     VALUES (a, b);
     SELECT 'Data Berhasil ditambahkan !';
END;

#
# Definition for the `insertTransaksiParkiran` procedure : 
#

DROP PROCEDURE IF EXISTS `insertTransaksiParkiran`;

CREATE PROCEDURE `insertTransaksiParkiran`(IN a DATETIME, IN b DATETIME, IN c INTEGER(15), IN d INTEGER(11),IN e INTEGER(11))
    NOT DETERMINISTIC
    CONTAINS SQL
    SQL SECURITY INVOKER
    COMMENT ''
BEGIN
     DECLARE CONTINUE HANDLER FOR 1062
     SELECT 'No Transaksi SUDAH ADA';
     INSERT INTO `transaksi_parkir`(jam_masuk,jam_keluar,total_biaya,noID, no_parkir)
     VALUES (a, b,c, d, e);
     SELECT 'Data Berhasil ditambahkan !';
END;

#
# Definition for the `insertTransaksiTopup` procedure : 
#

DROP PROCEDURE IF EXISTS `insertTransaksiTopup`;

CREATE PROCEDURE `insertTransaksiTopup`(IN a DATE, IN b INTEGER(11), IN c INTEGER(11), IN d INTEGER(11))
    NOT DETERMINISTIC
    CONTAINS SQL
    SQL SECURITY INVOKER
    COMMENT ''
BEGIN
     DECLARE CONTINUE HANDLER FOR 1062
     SELECT 'No Transaksi SUDAH ADA';
     INSERT INTO `transaksi_topup` (tgl_transaksi,id_member,wallet,topup)
     VALUES (a, b,c, d);
     SELECT 'Data Berhasil ditambahkan !';
END;

#
# Definition for the `updateAdmin` procedure : 
#

DROP PROCEDURE IF EXISTS `updateAdmin`;

CREATE PROCEDURE `updateAdmin`(IN a INTEGER(11), IN b VARCHAR(30), IN c VARCHAR(50))
    NOT DETERMINISTIC
    CONTAINS SQL
    SQL SECURITY INVOKER
    COMMENT ''
BEGIN
     UPDATE `admin` SET username = b, password = password(c)
     WHERE no_ID = a;
     SELECT 'Data Berhasil diperbaharui !';
END;

#
# Definition for the `updateJumlahTersedia` procedure : 
#

DROP PROCEDURE IF EXISTS `updateJumlahTersedia`;

CREATE PROCEDURE `updateJumlahTersedia`(IN a INTEGER(11), IN b INTEGER(6))
    NOT DETERMINISTIC
    CONTAINS SQL
    SQL SECURITY INVOKER
    COMMENT ''
BEGIN
     UPDATE `parkiran` SET jumlah_tersedia = b
     WHERE no_parkiran = a;
     SELECT 'Data Berhasil diperbaharui !';
END;

#
# Definition for the `updateKartu` procedure : 
#

DROP PROCEDURE IF EXISTS `updateKartu`;

CREATE PROCEDURE `updateKartu`(IN a VARCHAR(30), IN B INTEGER(11))
    NOT DETERMINISTIC
    CONTAINS SQL
    SQL SECURITY INVOKER
    COMMENT ''
BEGIN
     UPDATE `kartu` SET No_ID = b
     WHERE Id_kartu = a;
     SELECT 'Data Berhasil diperbaharui !';
END;

#
# Definition for the `updateMember` procedure : 
#

DROP PROCEDURE IF EXISTS `updateMember`;

CREATE PROCEDURE `updateMember`(IN a INTEGER(11), IN b VARCHAR(50), IN c VARCHAR(50), IN d VARCHAR(20), IN e INTEGER(11), IN f VARCHAR(100))
    NOT DETERMINISTIC
    CONTAINS SQL
    SQL SECURITY INVOKER
    COMMENT ''
BEGIN
     UPDATE `member` SET nama = b, alamat = c, telepon = d, wallet = e, email=f
     WHERE no_ID = a;
     SELECT 'Data Berhasil diperbaharui !';
END;

#
# Definition for the `updateParkiran` procedure : 
#

DROP PROCEDURE IF EXISTS `updateParkiran`;

CREATE PROCEDURE `updateParkiran`(IN a INTEGER(11), IN b INTEGER(6), IN c INTEGER(9), IN d INTEGER(6))
    NOT DETERMINISTIC
    CONTAINS SQL
    SQL SECURITY INVOKER
    COMMENT ''
BEGIN
     UPDATE `parkiran` SET jml = b, tarif_per_jam = c, jumlah_tersedia = d
     WHERE no_parkiran = a;
     SELECT 'Data Berhasil diperbaharui !';
END;

#
# Definition for the `updateTransaksiParkiran` procedure : 
#

DROP PROCEDURE IF EXISTS `updateTransaksiParkiran`;

CREATE PROCEDURE `updateTransaksiParkiran`(IN a INTEGER(11), IN b DATETIME, IN c INTEGER(15))
    NOT DETERMINISTIC
    CONTAINS SQL
    SQL SECURITY INVOKER
    COMMENT ''
BEGIN
     UPDATE `transaksi_parkir` SET jam_keluar = b, total_biaya=c
     WHERE no_transaksi = a;
     SELECT 'Data Berhasil diperbaharui !';
END;

