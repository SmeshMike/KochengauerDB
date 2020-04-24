CREATE TABLE [dbo].[Kochenyuk_abonent] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [surname]        NVARCHAR (50) NOT NULL,
    [name]     NVARCHAR (50) NOT NULL,
    [pathronomic] NVARCHAR (50) NOT NULL,
    [birthdate]   DATETIME      NOT NULL,
    [comments]    NVARCHAR (50) NULL,
    [adress]      NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

