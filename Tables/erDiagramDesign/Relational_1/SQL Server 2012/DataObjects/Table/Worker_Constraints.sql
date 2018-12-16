ALTER TABLE Worker ADD constraint worker_pk PRIMARY KEY CLUSTERED (ID_Worker)
     WITH (
     ALLOW_PAGE_LOCKS = ON , 
     ALLOW_ROW_LOCKS = ON ) go