ALTER TABLE Waiter
    ADD CONSTRAINT waiter_worker_fk FOREIGN KEY ( id_worker )
        REFERENCES worker ( id_worker )
ON DELETE NO ACTION 
    ON UPDATE no action go