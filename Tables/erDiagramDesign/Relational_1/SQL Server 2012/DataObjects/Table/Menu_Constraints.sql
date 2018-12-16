ALTER TABLE Menu ADD constraint menu_pk PRIMARY KEY CLUSTERED (ID_Menu)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON ) go