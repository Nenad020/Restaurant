ALTER TABLE have ADD constraint have_pk PRIMARY KEY CLUSTERED (Bill_ID_Bill, Item_ID_Item)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON ) go