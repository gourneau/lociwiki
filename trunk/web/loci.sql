-- phpMyAdmin SQL Dump
-- version 2.9.2
-- http://www.phpmyadmin.net
-- 
-- Host: localhost
-- Generation Time: May 03, 2007 at 08:37 AM
-- Server version: 5.0.33
-- PHP Version: 5.2.0
-- 
-- Database: `loci`
-- 

-- --------------------------------------------------------

-- 
-- Table structure for table `map`
-- 

CREATE TABLE `map` (
  `id` int(10) unsigned NOT NULL auto_increment,
  `time` timestamp NOT NULL default CURRENT_TIMESTAMP on update CURRENT_TIMESTAMP,
  `lat` double NOT NULL,
  `lng` double NOT NULL,
  `msg` varchar(10000) NOT NULL,
  `cat` varchar(1000) NOT NULL,
  `title` varchar(255) NOT NULL,
  PRIMARY KEY  (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- 
-- Dumping data for table `map`
-- 

