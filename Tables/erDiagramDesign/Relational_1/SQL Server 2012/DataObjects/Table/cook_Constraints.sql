ALTER TABLE cook ADD constraint cook_pk PRIMARY KEY CLUSTERED (Chef_ID_Worker, Food_ID_Item)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON ) go