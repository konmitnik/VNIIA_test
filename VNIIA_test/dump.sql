-- Database: vniia_sharp

-- DROP DATABASE IF EXISTS vniia_sharp;

CREATE DATABASE vniia_sharp
    WITH
    OWNER = postgres
    ENCODING = 'UTF8'
    LC_COLLATE = 'Russian_Russia.1251'
    LC_CTYPE = 'Russian_Russia.1251'
    LOCALE_PROVIDER = 'libc'
    TABLESPACE = pg_default
    CONNECTION LIMIT = -1
    IS_TEMPLATE = False;



-- SCHEMA: public

-- DROP SCHEMA IF EXISTS public ;

CREATE SCHEMA IF NOT EXISTS public
    AUTHORIZATION pg_database_owner;

COMMENT ON SCHEMA public
    IS 'standard public schema';

GRANT USAGE ON SCHEMA public TO PUBLIC;

GRANT ALL ON SCHEMA public TO pg_database_owner;


-- Table: public.document

-- DROP TABLE IF EXISTS public.document;

CREATE TABLE IF NOT EXISTS public.document
(
    id integer NOT NULL DEFAULT nextval('document_id_seq'::regclass),
    "number" integer NOT NULL,
    date date NOT NULL,
    comment text COLLATE pg_catalog."default",
    CONSTRAINT document_pkey PRIMARY KEY (id)
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.document
    OWNER to postgres;


-- Table: public.position

-- DROP TABLE IF EXISTS public."position";

CREATE TABLE IF NOT EXISTS public."position"
(
    id integer NOT NULL DEFAULT nextval('position_id_seq'::regclass),
    "number" integer NOT NULL,
    name character varying COLLATE pg_catalog."default" NOT NULL,
    sum double precision NOT NULL,
    doc_id integer,
    CONSTRAINT position_pkey PRIMARY KEY (id),
    CONSTRAINT position_doc_id_fkey FOREIGN KEY (doc_id)
        REFERENCES public.document (id) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public."position"
    OWNER to postgres;