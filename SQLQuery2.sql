CREATE TABLE [dbo].[Member] (
    [RefNo]     VARCHAR (10)  NOT NULL,
    [UserType]  VARCHAR (20)  NULL,
    [Fname]     VARCHAR (50)  NULL,
    [Lname]     VARCHAR (50)  NULL,
    [Gender]    VARCHAR (10)  NULL,
    [Address]   VARCHAR (100) NULL,
    [Email]     VARCHAR (100) NULL,
    [Contact]   VARCHAR (20)  NULL,
    [Emname]    VARCHAR (50)  NULL,
    [EmContact] VARCHAR (20)  NULL,
    [MC]        VARCHAR (20)  NULL,
    [Sport]     VARCHAR (50)  NULL,
    [Skill]     VARCHAR (50)  NULL,
    [Username]  VARCHAR (50)  NULL,
    [Password]  VARCHAR (50)  NULL,
    PRIMARY KEY CLUSTERED ([RefNo] ASC)
);
