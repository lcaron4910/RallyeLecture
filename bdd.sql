drop database if exists Rallyebd ;
create database Rallyebd ;
use Rallyebd ;

create table 'auteur' (
	'id' int(11) not null primary key,
	'nom' varchar(60) not null	
);

create table 'editeur' (
	'id' int(11) not null primary key,
	'nom' varchar(60) not null
);

create table 'quizz' (
	'id' int(11) not null primary key,
	'idFiche' int(11) not null
);

create table 'niveau' (
	'id' int(11) not null primary key,
	'niveauScolaire' varchar(45)
);

create table 'enseignant' (
	'id' int(11) not null primary key,
	'nom' varchar(45),
	'prenom' varchar(45),
	'login' varchar(100),
	'idAuth' int(11)
);

create table 'classe' (
	'id' int(11) not null primary key,
	'idEnseignant' int(11) not null,
	'anneeScolaire' varchar(45),
	'idNiveau' int(11) not null);