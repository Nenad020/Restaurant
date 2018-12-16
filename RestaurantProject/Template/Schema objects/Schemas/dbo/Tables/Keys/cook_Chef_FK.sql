ALTER TABLE cook
    ADD CONSTRAINT cook_chef_fk FOREIGN KEY ( chef_id_worker )
        REFERENCES chef ( id_worker )
ON DELETE NO ACTION 
    ON UPDATE no action 
	go