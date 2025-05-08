/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2017                    */
/* Created on:     5/17/2024 9:38:30 PM                         */
/*==============================================================*/
use University_Library;

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BOOK') and o.name = 'FK_BOOK_WRITTEN_B_AUTHOR')
alter table BOOK
   drop constraint FK_BOOK_WRITTEN_B_AUTHOR
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BOOK_COPY') and o.name = 'FK_BOOK_COP_HAS_BOOK')
alter table BOOK_COPY
   drop constraint FK_BOOK_COP_HAS_BOOK
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BORROW') and o.name = 'FK_BORROW_BORROW_ACCOUNT')
alter table BORROW
   drop constraint FK_BORROW_BORROW_ACCOUNT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BORROW') and o.name = 'FK_BORROW_BORROW2_BOOK')
alter table BORROW
   drop constraint FK_BORROW_BORROW2_BOOK
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CATEGORY') and o.name = 'FK_CATEGORY_FALLS_UND_BOOK')
alter table CATEGORY
   drop constraint FK_CATEGORY_FALLS_UND_BOOK
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PHONE_NO_') and o.name = 'FK_PHONE_NO_OWN_ACCOUNT')
alter table PHONE_NO_
   drop constraint FK_PHONE_NO_OWN_ACCOUNT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ACCOUNT')
            and   type = 'U')
   drop table ACCOUNT
go

if exists (select 1
            from  sysobjects
           where  id = object_id('AUTHOR')
            and   type = 'U')
   drop table AUTHOR
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BOOK')
            and   name  = 'WRITTEN_BY_FK'
            and   indid > 0
            and   indid < 255)
   drop index BOOK.WRITTEN_BY_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BOOK')
            and   type = 'U')
   drop table BOOK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BOOK_COPY')
            and   name  = 'HAS_FK'
            and   indid > 0
            and   indid < 255)
   drop index BOOK_COPY.HAS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BOOK_COPY')
            and   type = 'U')
   drop table BOOK_COPY
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BORROW')
            and   name  = 'BORROW2_FK'
            and   indid > 0
            and   indid < 255)
   drop index BORROW.BORROW2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BORROW')
            and   name  = 'BORROW_FK'
            and   indid > 0
            and   indid < 255)
   drop index BORROW.BORROW_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BORROW')
            and   type = 'U')
   drop table BORROW
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('CATEGORY')
            and   name  = 'FALLS_UNDER_FK'
            and   indid > 0
            and   indid < 255)
   drop index CATEGORY.FALLS_UNDER_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CATEGORY')
            and   type = 'U')
   drop table CATEGORY
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PHONE_NO_')
            and   name  = 'OWN_FK'
            and   indid > 0
            and   indid < 255)
   drop index PHONE_NO_.OWN_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PHONE_NO_')
            and   type = 'U')
   drop table PHONE_NO_
go

/*==============================================================*/
/* Table: ACCOUNT                                               */
/*==============================================================*/
create table ACCOUNT (
   FNAME                varchar(20)          not null,
   LNAME                varchar(20)          null,
   USER_NAME            varchar(40)          not null,
   PASSWORD             varchar(40)          not null,
   EMAIL                varchar(100)         not null,
   USERID               int identity(1,1)    not null,
   ADMIN_FLAG           bit                  not null,
   SID                  int                  null,
   LEVEL                int                  null,
   ACCESS_CODE          int                  null,
   constraint PK_ACCOUNT primary key (USERID),
   constraint AK_AK_SID_ACCOUNT unique (USER_NAME, SID, ACCESS_CODE)
)
go

/*==============================================================*/
/* Table: AUTHOR                                                */
/*==============================================================*/
create table AUTHOR (
   AUTHORID             int   identity(1,1)  not null,
   PERSONAL_BACKGROUND  text                 null,
   NAME                 varchar(40)          not null,
   NATIONALLITY         varchar(50)          null,
   constraint PK_AUTHOR primary key (AUTHORID)
)
go

/*==============================================================*/
/* Table: BOOK                                                  */
/*==============================================================*/
create table BOOK (
   PUBLISH_YEAR         int                  null,
   ISBN                 int                  not null,
   TITLE                varchar(70)          not null,
   PUBLISHER            varchar(50)          null,
   BOOK_ID              int identity(1,1)    not null,
   AUTHORID             int                  not null,
   BORROWED             int                  null,
   AVAILABLE            bit                  null,
   constraint PK_BOOK primary key (BOOK_ID),
   constraint AK_AK_BOOK_BOOK unique (ISBN)
)
go

/*==============================================================*/
/* Index: WRITTEN_BY_FK                                         */
/*==============================================================*/




create nonclustered index WRITTEN_BY_FK on BOOK (AUTHORID ASC)
go

/*==============================================================*/
/* Table: BOOK_COPY                                             */
/*==============================================================*/
create table BOOK_COPY (
   BOOK_ID              int                  not null,
   COPY_ID              int                  not null,
   constraint PK_BOOK_COPY primary key (BOOK_ID, COPY_ID)
)
go

/*==============================================================*/
/* Index: HAS_FK                                                */
/*==============================================================*/




create nonclustered index HAS_FK on BOOK_COPY (BOOK_ID ASC)
go

/*==============================================================*/
/* Table: BORROW                                                */
/*==============================================================*/
create table BORROW (
   USERID               int                  not null,
   BOOK_ID              int                  not null,
   BORROW_DATE          datetime             not null,
   RETURN_DATE          datetime             not null,
   constraint PK_BORROW primary key (USERID, BOOK_ID)
)
go

/*==============================================================*/
/* Index: BORROW_FK                                             */
/*==============================================================*/




create nonclustered index BORROW_FK on BORROW (USERID ASC)
go

/*==============================================================*/
/* Index: BORROW2_FK                                            */
/*==============================================================*/




create nonclustered index BORROW2_FK on BORROW (BOOK_ID ASC)
go

/*==============================================================*/
/* Table: CATEGORY                                              */
/*==============================================================*/
create table CATEGORY (
   GENRE                varchar(20)          not null,
   BOOK_ID              int                  not null,
   constraint PK_CATEGORY primary key (GENRE, BOOK_ID)
)
go

/*==============================================================*/
/* Index: FALLS_UNDER_FK                                        */
/*==============================================================*/




create nonclustered index FALLS_UNDER_FK on CATEGORY (BOOK_ID ASC)
go

/*==============================================================*/
/* Table: PHONE_NO_                                             */
/*==============================================================*/
create table PHONE_NO_ (
   PHONE_NO_            int                  not null,
   USERID               int                  not null,
   constraint PK_PHONE_NO_ primary key (PHONE_NO_, USERID)
)
go

/*==============================================================*/
/* Index: OWN_FK                                                */
/*==============================================================*/




create nonclustered index OWN_FK on PHONE_NO_ (USERID ASC)
go

alter table BOOK
   add constraint FK_BOOK_WRITTEN_B_AUTHOR foreign key (AUTHORID)
      references AUTHOR (AUTHORID)
go

alter table BOOK_COPY
   add constraint FK_BOOK_COP_HAS_BOOK foreign key (BOOK_ID)
      references BOOK (BOOK_ID)
go

alter table BORROW
   add constraint FK_BORROW_BORROW_ACCOUNT foreign key (USERID)
      references ACCOUNT (USERID)
go

alter table BORROW
   add constraint FK_BORROW_BORROW2_BOOK foreign key (BOOK_ID)
      references BOOK (BOOK_ID)
go

alter table CATEGORY
   add constraint FK_CATEGORY_FALLS_UND_BOOK foreign key (BOOK_ID)
      references BOOK (BOOK_ID)
go

alter table PHONE_NO_
   add constraint FK_PHONE_NO_OWN_ACCOUNT foreign key (USERID)
      references ACCOUNT (USERID)
go

insert into Author (NAME, NATIONALLITY,PERSONAL_BACKGROUND) VALUES ('Charles Dickens', 'English','Charles John Huffam Dickens was an English novelist and social critic who created some of the worlds best-known fictional characters, and is regarded by many as the greatest novelist of the Victorian era.' )
insert into AUTHOR (NAME, NATIONALLITY,PERSONAL_BACKGROUND) Values ('Stephen King', 'American', 'One of the most popular names that almost everybody knows who reads books. Stephen King is an American fiction writer. His books mostly belong to genres like horror, supernatural, and crime. Stephen King is now in his 70s and has spent his life writing best-selling books that are popular all over the world.')
insert into AUTHOR (NAME, NATIONALLITY,PERSONAL_BACKGROUND) VALUES ('J. K. Rowling', 'British', 'Joanne Rowling CH OBE FRSL, known by her pen name J. K. Rowling, is a British author and philanthropist. She wrote Harry Potter, a seven-volume fantasy series published from 1997 to 2007.')
insert into AUTHOR (NAME, NATIONALLITY,PERSONAL_BACKGROUND) VALUES ('Jane Austen', 'English', 'Jane Austen was an English novelist known primarily for her six novels, which implicitly interpret, critique, and comment upon the British landed gentry at the end of the 18th century. Austens plots often explore the dependence of women on marriage for the pursuit of favourable social standing and economic security.')

select* from AUTHOR;

select* from PHONE_NO_;

select * from ACCOUNT;

select * from BOOK;

select * from BOOK_COPY;

select * from BORROW;

select * from CATEGORY;

DBCC CHECKIDENT ('BOOK.BOOK_ID', RESEED, 0);
DBCC CHECKIDENT ('ACCOUNT', RESEED, 2);
DBCC CHECKIDENT ('AUTHOR', RESEED, 0);

SELECT Title, ISBN, PUBLISHER, PUBLISH_YEAR, BORROWED, AVAILABLE
FROM BOOK
where 1=1

insert into BOOK (TITLE,ISBN, AUTHORID,BORROWED , AVAILABLE) VALUES ('Harry Potter' ,1, 1,0, 1);
insert into BOOK (TITLE,ISBN, AUTHORID,BORROWED , AVAILABLE) VALUES ('P&P' ,2, 1,0, 1);

insert into BOOK_COPY values(3, 1)
insert into BOOK_COPY values(3, 2)
insert into BOOK_COPY values(3, 3)
insert into BOOK_COPY values(2, 1)
insert into BOOK_COPY values(2, 2)

select COUNT(*) from BOOK;

SELECT Title, ISBN, AUTHOR.NAME ,CATEGORY.GENRE, PUBLISHER, PUBLISH_YEAR, BORROWED, AVAILABLE
FROM BOOK inner join CATEGORY
on CATEGORY.BOOK_ID = BOOK.BOOK_ID 
inner join AUTHOR on BOOK.AUTHORID=AUTHOR.AUTHORID
where 1=1 and BOOK.AUTHORID = (SELECT AUTHORID from Author where AUTHOR.NAME = 'Charles Dickens') AND ISBN = 2


SELECT Title, ISBN, AUTHOR.NAME ,CATEGORY.GENRE, PUBLISHER, PUBLISH_YEAR, BORROWED, AVAILABLE
FROM BOOK , CATEGORY, AUTHOR 
where CATEGORY.BOOK_ID = BOOK.BOOK_ID AND BOOK.AUTHORID=AUTHOR.AUTHORID

insert into CATEGORY values('fantasy',3)
insert into CATEGORY values('comedy', 3)
insert into CATEGORY values('romance',2)
insert into CATEGORY values('horror', 2)

set IDENTITY_INSERT BOOK_COPY OFF;

select Count(*) from BORROW where BOOK_ID = 1;

update account set USER_NAME='noran2' where USER_NAME = 'noran';

update account set SID = 200 where USER_NAME = 'noran1';

select * from AUTHOR;

insert into ACCOUNT values ('Noran', 'mahmoud', 'noran', 'aerba', '@email', 0, 3, NULL, NULL);


select sum(AUTHORID)
FROM AUTHOR
GROUP BY NATIONALLITY;