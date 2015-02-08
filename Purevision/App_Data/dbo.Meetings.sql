CREATE TABLE [dbo].[Meetings] (
    [MeetingID]           INT      IDENTITY (1, 1) NOT NULL,
    [Start]               DATETIME NOT NULL,
    [End]                 DATETIME NOT NULL,
    [Title]               NTEXT    NOT NULL,
    [Description]         NTEXT    NULL,
    [RoomID]              INT      NULL,
    [IsAllDay]            BIT      NOT NULL,
    [RecurrenceRule]      NTEXT    NULL,
    [RecurrenceID]        INT      NULL,
    [RecurrenceException] NTEXT    NULL,
    [StartTimezone]       NTEXT    NULL,
    [EndTimezone]         NTEXT    NULL,
    CONSTRAINT [PK_Meeting] PRIMARY KEY CLUSTERED ([MeetingID] ASC),
    CONSTRAINT [FK_Meetings_Meetings] FOREIGN KEY ([RecurrenceID]) REFERENCES [dbo].[Meetings] ([MeetingID])
);

