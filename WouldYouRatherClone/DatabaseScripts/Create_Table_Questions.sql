CREATE TABLE [dbo].[Questions] (
    [Id]           INT            NOT NULL IDENTITY,
    [QuestionText] NVARCHAR (256) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

