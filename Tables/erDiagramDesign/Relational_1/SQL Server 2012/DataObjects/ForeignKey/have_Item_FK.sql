ALTER TABLE have
    ADD CONSTRAINT have_item_fk FOREIGN KEY ( item_id_item )
        REFERENCES item ( id_item )
ON DELETE NO ACTION 
    ON UPDATE no action go