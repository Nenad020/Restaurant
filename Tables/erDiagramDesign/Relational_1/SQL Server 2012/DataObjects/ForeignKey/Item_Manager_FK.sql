ALTER TABLE Item
    ADD CONSTRAINT item_manager_fk FOREIGN KEY ( manager_id_worker )
        REFERENCES manager ( id_worker )
ON DELETE NO ACTION 
    ON UPDATE no action go