ALTER TABLE Drink ADD constraint drink_pk PRIMARY KEY CLUSTERED (ID_Item)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON ) 
     ON "default" 
	 go