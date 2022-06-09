CREATE TRIGGER NUM_FLIGHTS ON FLIGHTS
AFTER UPDATE,INSERT 
AS BEGIN
	DECLARE @numA int
	DECLARE @numS int
	DECLARE @numF char(20)
	SELECT @numA=numAvail,@numS=numSeats,@numF=flightNum FROM inserted 
	IF (@numA>@numS) 
		UPDATE FLIGHTS SET numAvail=@numS WHERE flightNum=@numF
END;

