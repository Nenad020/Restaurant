CREATE TABLE reservation (
    id_reservation          INTEGER NOT NULL,
    name_reservation        VARCHAR(100) NOT NULL,
    starttime_reservation   VARCHAR(50) NOT NULL,
    endtime_reservation     VARCHAR(50) NOT NULL,
    manager_id_worker       INTEGER NOT NULL
)

go