ALTER TABLE have
    ADD CONSTRAINT have_bill_fk FOREIGN KEY ( bill_id_bill )
        REFERENCES bill ( id_bill )
ON DELETE NO ACTION 
    ON UPDATE no action go