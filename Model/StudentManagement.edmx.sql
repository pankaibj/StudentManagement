



-- -----------------------------------------------------------
-- Entity Designer DDL Script for MySQL Server 4.1 and higher
-- -----------------------------------------------------------
-- Date Created: 04/01/2013 11:13:26
-- Generated from EDMX file: E:\Student\StudentManagement\Model\StudentManagement.edmx
-- Target version: 3.0.0.0
-- --------------------------------------------------

DROP DATABASE IF EXISTS `students`;
CREATE DATABASE `students`;
USE `students`;

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- NOTE: if the constraint does not exist, an ignorable error will be reported.
-- --------------------------------------------------

--    ALTER TABLE `Students` DROP CONSTRAINT `FK_ClassesStudents`;

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------
SET foreign_key_checks = 0;
    DROP TABLE IF EXISTS `Students`;
    DROP TABLE IF EXISTS `Classes`;
SET foreign_key_checks = 1;

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

CREATE TABLE `Students`(
	`Id` int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Name` varchar (1000) NOT NULL, 
	`Class_Id` int NOT NULL);

ALTER TABLE `Students` ADD PRIMARY KEY (Id);




CREATE TABLE `Classes`(
	`Id` int NOT NULL AUTO_INCREMENT UNIQUE, 
	`Name` varchar (1000) NOT NULL);

ALTER TABLE `Classes` ADD PRIMARY KEY (Id);






-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on `Class_Id` in table 'Students'

ALTER TABLE `Students`
ADD CONSTRAINT `FK_ClassesStudents`
    FOREIGN KEY (`Class_Id`)
    REFERENCES `Classes`
        (`Id`)
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ClassesStudents'

CREATE INDEX `IX_FK_ClassesStudents` 
    ON `Students`
    (`Class_Id`);

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
