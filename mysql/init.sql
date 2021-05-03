USE parkingrightdb;

 CREATE TABLE IF NOT EXISTS ParkingRights (
    ParkingRightId bigint not null AUTO_INCREMENT,
    LicensePlate varchar(20) not null,
    OperatorId varchar(255) not null,
    ParkingZoneId bigint not null,
	StartDate datetime not null,
	EndDate datetime not null,
	Amount decimal(8,2) not null,
	UserProfile int not null,
    PRIMARY KEY (ParkingRightId)
);