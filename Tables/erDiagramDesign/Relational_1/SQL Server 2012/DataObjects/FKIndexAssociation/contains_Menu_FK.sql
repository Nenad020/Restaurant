ALTER TABLE "contains"
    ADD CONSTRAINT contains_menu_fk FOREIGN KEY ( menu_id_menu )
        REFERENCES menu ( id_menu )
ON DELETE NO ACTION 
    ON UPDATE no action go