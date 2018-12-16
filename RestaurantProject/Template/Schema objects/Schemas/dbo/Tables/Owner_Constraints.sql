ALTER TABLE Owner ADD constraint owner_pk PRIMARY KEY CLUSTERED (ID_Owner)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON ) 
     ON "default" 
	 go