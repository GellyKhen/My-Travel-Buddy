CREATE DATABASE MyTravelBuddy_db
USE MyTravelBuddy_DB
GO
--Region
CREATE TABLE Region
( 
RegionID varchar(5) NOT NULL,
RegionName varchar(45) NOT NULL,
RegionDesc varchar(max) NOT NULL,
CONSTRAINT pk_regId PRIMARY KEY (RegionID)
)
GO
--Province 
CREATE TABLE Province
( 
RegId varchar(5) NOT NULL,
ProvinceID int identity (1,1) NOT NULL, 
ProvName varchar(45) NOT NULL,
ProvDesc varchar(max) NOT NULL,
CONSTRAINT pk_provId PRIMARY KEY (ProvinceID),
CONSTRAINT fk_pregId FOREIGN KEY (RegId) REFERENCES Region(RegionID)
)
GO
--City
CREATE TABLE City
(
ProvId int NOT NULL, 
CityID int identity (1,1) NOT NULL,
CityName varchar(45) NOT NULL,
CityDesc varchar(max) NOT NULL,
CityImage image NULL,
CONSTRAINT pk_cityId PRIMARY KEY (CityID),
CONSTRAINT fk_cprovId FOREIGN KEY (ProvId) REFERENCES Province(ProvinceID)
)
GO
--UserLogin 
CREATE TABLE UserLogin
( 
UserID int identity (1,1) NOT NULL,
UserName varchar(45) NOT NULL,
UPassword varchar(45) NOT NULL,
FName varchar(45) NOT NULL,
LName varchar(45) NOT NULL, 
MInitial varchar(2) NULL,
Email varchar(45) NULL,
BDay date NULL,
UAddress varchar(80) NOT NULL,
UserImage image NULL,
UPurgeFlag bit NOT NULL,
CityId int NOT NULL,
CONSTRAINT pk_userId PRIMARY KEY (UserID),
CONSTRAINT fk_ucityId FOREIGN KEY (CityId) REFERENCES City(CityID)
)
GO
--Landmark
CREATE TABLE Landmark 
( 
CityId int NOT NULL,
LandmarkID int identity (1,1) NOT NULL,
LmName varchar(45) NOT NULL,
LmDesc varchar(max) NOT NULL,
LmAddress varchar(80) NOT NULL,
LmImage image NOT NULL,
LmPurgeFlag bit NOT NULL,
CONSTRAINT pk_lmId PRIMARY KEY (LandmarkID),
CONSTRAINT fk_LmcityId FOREIGN KEY (CityId) REFERENCES City(CityID)
)
GO
--Restaurant
CREATE TABLE Restaurant
( 
CityId int NOT NULL,
RestaurantID int identity (1,1) NOT NULL,
RestauName varchar(45) NOT NULL,
RestauDesc varchar(max) NOT NULL,
RestauAddress varchar(80) NOT NULL,
RContactNo varchar(12) NOT NULL,
RestauImage image NOT NULL,
RPurgeFlag bit NOT NULL,
CONSTRAINT pk_restauId PRIMARY KEY (RestaurantID),
CONSTRAINT fk_rcityId FOREIGN KEY (CityId) REFERENCES City(CityID)
)
GO
--Restaurant Rating 
CREATE TABLE RestaurantRating 
( 
UserId int NOT NULL,
RestauId int NOT NULL,
RestauRating int NULL,
RestauComment varchar(255) NULL,
CONSTRAINT fk_rruserId FOREIGN KEY (UserId) REFERENCES UserLogin(UserID),
CONSTRAINT fk_rrrestauId FOREIGN KEY (RestauId) REFERENCES Restaurant(RestaurantID)
)
GO
--Hotel
CREATE TABLE Hotel
( 
CityId int NOT NULL, 
HotelID int identity (1,1) NOT NULL,
HotelName varchar(45) NOT NULL,
HotelDesc varchar(max) NOT NULL,
HotelAddress varchar(80) NOT NULL,
HContactNo varchar(12) NOT NULL,
HotelImage image NOT NULL,
HPurgeFlag bit NOT NULL,
CONSTRAINT pk_hotelId PRIMARY KEY (HotelID),
CONSTRAINT fk_cityId FOREIGN KEY (CityId) REFERENCES City(CityID)
)
GO
--Room
CREATE TABLE HotelRoom
( 
HotelId int NOT NULL,
RoomID int identity (1,1) NOT NULL,
RoomType varchar(45) NOT NULL,
RoomDesc varchar(max) NOT NULL,
RoomNo int NOT NULL,
RoomPrice varchar(45) NOT NULL,
RoomImage image NOT NULL,
CONSTRAINT pk_roomId PRIMARY KEY (RoomID),
CONSTRAINT fk_hrhotelId FOREIGN KEY (HotelId) REFERENCES Hotel(HotelID)
)
GO
--Hotel Rating
CREATE TABLE HotelRating
( 
UserId int NOT NULL,
HotelId int NOT NULL,
HotelRating int NULL,
HotelComment varchar(255) NULL,
CONSTRAINT fk_ratehotelId FOREIGN KEY (HotelId) REFERENCES Hotel(HotelID),
CONSTRAINT fk_hruserId FOREIGN KEY (UserId) REFERENCES UserLogin(UserID)
)
GO

