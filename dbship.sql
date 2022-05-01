-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Jul 01, 2017 at 07:30 AM
-- Server version: 5.6.17
-- PHP Version: 5.5.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `dbship`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbaccount`
--

CREATE TABLE IF NOT EXISTS `tbaccount` (
  `tid` int(11) NOT NULL AUTO_INCREMENT,
  `atype` varchar(30) NOT NULL,
  `tuname` varchar(30) NOT NULL,
  `tupass` varchar(15) NOT NULL,
  PRIMARY KEY (`tid`),
  UNIQUE KEY `tupass_2` (`tupass`),
  FULLTEXT KEY `tupass` (`tupass`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `tbclass`
--

CREATE TABLE IF NOT EXISTS `tbclass` (
  `id` int(6) NOT NULL AUTO_INCREMENT,
  `vname` varchar(25) NOT NULL,
  `tclass` varchar(15) NOT NULL,
  `tcapacity` varchar(4) NOT NULL,
  `tfare` decimal(12,2) NOT NULL,
  `temp` int(4) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `tbpassenger`
--

CREATE TABLE IF NOT EXISTS `tbpassenger` (
  `pid` int(6) NOT NULL AUTO_INCREMENT,
  `tid` varchar(11) NOT NULL,
  `tfirst` varchar(30) NOT NULL,
  `tlast` varchar(30) NOT NULL,
  `type` varchar(20) NOT NULL,
  `cbgen` varchar(10) NOT NULL,
  `tage` varchar(3) NOT NULL,
  `tseat` varchar(5) NOT NULL,
  `vname` varchar(50) NOT NULL,
  `torig` varchar(50) NOT NULL,
  `tdest` varchar(50) NOT NULL,
  `cbclass` varchar(15) NOT NULL,
  `tfare` decimal(12,2) NOT NULL,
  `depart` varchar(15) NOT NULL,
  `dtpdate` varchar(15) NOT NULL,
  `ttotal` decimal(12,2) NOT NULL,
  `tmoney` decimal(12,2) NOT NULL,
  `tchange` decimal(12,2) NOT NULL,
  PRIMARY KEY (`pid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `tbpdiscount`
--

CREATE TABLE IF NOT EXISTS `tbpdiscount` (
  `id` int(6) NOT NULL AUTO_INCREMENT,
  `ptype` varchar(30) NOT NULL,
  `discount` varchar(4) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `tbplist`
--

CREATE TABLE IF NOT EXISTS `tbplist` (
  `pid` int(11) NOT NULL AUTO_INCREMENT,
  `tfirst` varchar(30) NOT NULL,
  `tlast` varchar(30) NOT NULL,
  `tage` varchar(5) NOT NULL,
  `tgender` varchar(8) NOT NULL,
  `vname` varchar(40) NOT NULL,
  `dtpdate` varchar(20) NOT NULL,
  PRIMARY KEY (`pid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `tbptype`
--

CREATE TABLE IF NOT EXISTS `tbptype` (
  `id` int(6) NOT NULL AUTO_INCREMENT,
  `ptype` varchar(30) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `tbreports`
--

CREATE TABLE IF NOT EXISTS `tbreports` (
  `rid` int(4) NOT NULL AUTO_INCREMENT,
  `vname` varchar(40) NOT NULL,
  `tfirst` varchar(40) NOT NULL,
  `tlast` varchar(40) NOT NULL,
  `type` varchar(25) NOT NULL,
  `tclass` varchar(30) NOT NULL,
  `tfare` decimal(12,2) NOT NULL,
  `ttotal` decimal(12,2) NOT NULL,
  `tmoney` decimal(12,2) NOT NULL,
  `tchange` decimal(12,2) NOT NULL,
  `dfrom` varchar(25) NOT NULL,
  `dto` varchar(25) NOT NULL,
  PRIMARY KEY (`rid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `tbves`
--

CREATE TABLE IF NOT EXISTS `tbves` (
  `id` int(6) NOT NULL AUTO_INCREMENT,
  `vname` varchar(40) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `tbvessel`
--

CREATE TABLE IF NOT EXISTS `tbvessel` (
  `vid` int(6) NOT NULL AUTO_INCREMENT,
  `vname` varchar(50) NOT NULL,
  `torig` varchar(50) NOT NULL,
  `tdest` varchar(50) NOT NULL,
  `depart` varchar(15) NOT NULL,
  PRIMARY KEY (`vid`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
