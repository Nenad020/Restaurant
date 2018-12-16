ALTER TABLE Drink
    ADD CONSTRAINT drink_item_fk FOREIGN KEY ( id_item )
        REFERENCES item ( id_item )
ON DELETE NO ACTION 
    ON UPDATE no action go