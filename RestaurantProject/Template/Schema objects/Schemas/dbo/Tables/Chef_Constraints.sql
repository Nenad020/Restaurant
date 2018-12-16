ALTER TABLE Chef ADD constraint chef_pk PRIMARY KEY CLUSTERED (ID_Worker)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON ) 
     ON "default" 
	 go