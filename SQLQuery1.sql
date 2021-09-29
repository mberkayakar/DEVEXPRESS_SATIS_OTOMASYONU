Create Database BerkayAkarDevexpressTicariOtomasyon

use BerkayAkarDevexpressTicariOtomasyon

create table musteriler (
ID int identity(1,1) primary key,
AD varchar(50),
SOYAD varchar(50),
TELEFON varchar(15),
TELEFON2 varchar(15),
TC char(11),
MAIL varchar(100),
IL varchar(20),
ILCE varchar(80),
ADRES varchar(1000),
-- VERGIDAIRESI varchar(50),
)

create table personeller (
ID int identity(1,1) primary key,
AD varchar(50),
SOYAD varchar(50),
POSISYON varchar(50),
TELEFON varchar(15),
TELEFON2 varchar(15),
TC char(11),
MAIL varchar(100),
IL varchar(20),
ILCE varchar(80),
ADRES varchar(1000),
)


create table Firma (
ID int identity(1,1) primary key,
AD varchar(50),
SEKTOR varchar(50),
POSISYON varchar(50),
TELEFON varchar(15),
IL varchar(20),
ILCE varchar(80),
ADRES varchar(1000),
)


create table Urunler(
ID int identity(1,1) primary key,
URUNAD NVARCHAR(50),
MARKA NVARCHAR(50),
URUNMODEL NVARCHAR(50),
URUNACIKLAMA NVARCHAR(4000),
URUNKATEGORI int,
STOKADET int,
DURUM BIT,
)


create table STOKLAR(
ID int identity(1,1) primary key,
STOKTUR varchar(20),
STOKADET int,
)

create table faturabilgi (
ID int identity(1,1) primary key,
SERINO char(1),
TARIH DATE,
ALICIAD varchar(50),
TESLIMEDEN varchar(50),
TESLIMALAN varchar(50),
)

create table faturabilgi (
ID int identity(1,1) primary key,
SERINO char(1),
TARIH DATE,
ALICIAD varchar(50),
TESLIMEDEN varchar(50),
TESLIMALAN varchar(50),
)

create table fatura (
ID int primary key,
URUNADI varchar(20),
MIKTAR int,
BIRIMFIYAT decimal(15,2),
TOPLAMTUTAR decimal(15,2),  -- Bu kısım otomatik olarak sql üzerinde hesaplanacaktır.
FATURABILGIID int,
)


create table notlar(
ID int identity(1,1) primary key,
TARIH date,
BASLIK varchar(250),
DETAY VARCHAR(4999),
OLUSTURAN int,
)

 

