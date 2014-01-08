
    if exists (select * from dbo.sysobjects where id = object_id(N'MyEntity1s') and OBJECTPROPERTY(id, N'IsUserTable') = 1) drop table MyEntity1s

    create table MyEntity1s (
        MyEntity1Id INT IDENTITY NOT NULL,
       primary key (MyEntity1Id)
    )
