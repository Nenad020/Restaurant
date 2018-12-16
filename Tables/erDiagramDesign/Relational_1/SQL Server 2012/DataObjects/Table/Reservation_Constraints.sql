ALTER TABLE Reservation ADD constraint reservation_pk PRIMARY KEY CLUSTERED (ID_Reservation)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON ) go