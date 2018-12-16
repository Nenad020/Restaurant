ALTER TABLE "contains" ADD constraint contains_pk PRIMARY KEY CLUSTERED (Menu_ID_Menu, Item_ID_Item)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON ) go