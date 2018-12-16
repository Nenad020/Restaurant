CREATE TABLE worker (
    id_worker            INTEGER NOT NULL,
    name_worker          VARCHAR(50) NOT NULL,
    lastname_worker      VARCHAR(50) NOT NULL,
    phonenumber_worker   VARCHAR(50) NOT NULL,
    email_worker         VARCHAR(70) NOT NULL,
    password_worker      VARCHAR(50) NOT NULL,
    owner_id_owner       INTEGER NOT NULL
)

go