ALTER TABLE Worker
    ADD CONSTRAINT worker_owner_fk FOREIGN KEY ( owner_id_owner )
        REFERENCES owner ( id_owner )
ON DELETE NO ACTION 
    ON UPDATE no action go