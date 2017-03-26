CREATE TABLE [dbo].[Answers] (
    [Id]         INT            NOT NULL IDENTITY,
    [QuestionId] INT            NOT NULL,
    [AnswerText] NVARCHAR (256) NOT NULL,
    [Score]      INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

