ALTER TABLE cook
    ADD CONSTRAINT cook_food_fk FOREIGN KEY ( food_id_item )
        REFERENCES food ( id_item )
ON DELETE NO ACTION 
    ON UPDATE no action 
	go