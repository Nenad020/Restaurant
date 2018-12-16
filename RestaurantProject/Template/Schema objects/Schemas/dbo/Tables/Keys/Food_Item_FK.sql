ALTER TABLE Food
    ADD CONSTRAINT food_item_fk FOREIGN KEY ( id_item )
        REFERENCES item ( id_item )
ON DELETE NO ACTION 
    ON UPDATE no action 
	go