ALTER TABLE Food ADD constraint food_pk PRIMARY KEY CLUSTERED (ID_Item)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON ) go