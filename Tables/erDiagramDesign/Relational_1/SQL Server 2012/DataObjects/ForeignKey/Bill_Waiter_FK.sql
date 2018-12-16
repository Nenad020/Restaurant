ALTER TABLE Bill
    ADD CONSTRAINT bill_waiter_fk FOREIGN KEY ( waiter_id_worker )
        REFERENCES waiter ( id_worker )
ON DELETE NO ACTION 
    ON UPDATE no action go