ALTER TABLE Bill ADD constraint bill_pk PRIMARY KEY CLUSTERED (ID_Bill)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON ) go