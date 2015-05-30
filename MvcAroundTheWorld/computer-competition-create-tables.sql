CREATE TABLE [dbo].[School] (
	[SchoolID] INT IDENTITY(1,1) NOT NULL,
	[Name] NVARCHAR(50) NOT NULL,
	[Address] NVARCHAR(100) NOT NULL,
	[Telephone] NVARCHAR(10) NOT NULL,
	PRIMARY KEY ([SchoolID])
);

CREATE TABLE [dbo].[Classroom](
	[ClassroomName] NVARCHAR(50) NOT NULL,
	[SchoolID] INT NOT NULL,
	PRIMARY KEY ([ClassroomName]),
	CONSTRAINT [FK_dbo.Classroom_dbo.School_SchoolID] FOREIGN KEY ([SchoolID])
		REFERENCES [dbo].[School] ([SchoolID]) ON DELETE CASCADE
);

CREATE TABLE [dbo].[Pupil] (
	[PupilID] INT IDENTITY(1,1) NOT NULL,
	[PupilName] NVARCHAR(50) NOT NULL,
	[ClassroomName] NVARCHAR(50) NOT NULL,
	[PupilEmail] NVARCHAR(50) NOT NULL,
	PRIMARY KEY ([PupilID]),
	CONSTRAINT [FK_dbo.Pupil_dbo.Classroom_ClassroomName] FOREIGN KEY ([ClassroomName])
		REFERENCES [dbo].[Classroom] ([ClassroomName]) ON DELETE CASCADE
);

CREATE TABLE [dbo].[Competition] (
	[CompID] INT IDENTITY(1,1) NOT NULL,
	[DateStart] DATE NOT NULL,
	[DateFinish] DATE NOT NULL,
	PRIMARY KEY ([CompID])
);

CREATE TABLE [dbo].[Answer] (
	[AnsID] INT IDENTITY(1,1) NOT NULL,
	PRIMARY KEY ([AnsID])
);

CREATE TABLE [dbo].[Question] (
	[QuestionID] INT IDENTITY(1,1) NOT NULL,
	[Question] NVARCHAR(50) NOT NULL,
	PRIMARY KEY ([QuestionID])
);

CREATE TABLE [dbo].[CompetitionQuestion] (
	[CQID] INT IDENTITY(1,1) NOT NULL,
	[CompID] INT NOT NULL,
	[QuestionID] INT NOT NULL,
	[AnsID] INT NOT NULL,
	PRIMARY KEY ([CQID]),
	CONSTRAINT [FK_dbo.CompetitionQuestion_dbo.Competition_CompID] FOREIGN KEY ([CompID])
		REFERENCES [dbo].[Competition] ([CompID]) ON DELETE CASCADE,
	CONSTRAINT [FK_dbo.CompetitionQuestion_dbo.Question_QuestionID] FOREIGN KEY ([QuestionID])
		REFERENCES [dbo].[Question] ([QuestionID]) ON DELETE CASCADE,
	CONSTRAINT [FK_dbo.CompetitionQuestion_dbo.Answer_AnsID] FOREIGN KEY ([AnsID])
		REFERENCES [dbo].[Answer] ([AnsID]) ON DELETE CASCADE
);

CREATE TABLE [dbo].[CompetitionSubmission] (
	[CSID] INT NOT NULL,
	[CompID] INT NOT NULL,
	[PupilID] INT NOT NULL,
	[CQID] INT NOT NULL,
	[Correct] BIT NOT NULL,
	PRIMARY KEY ([CSID]),
	CONSTRAINT [FK_dbo.CompetitionSubmission_dbo.Competition_CompID] FOREIGN KEY ([CompID])
		REFERENCES [dbo].[Competition] ([CompID]) ON DELETE CASCADE,
	CONSTRAINT [FK_dbo.CompetitionSubmission_dbo.Pupil_PupilID] FOREIGN KEY ([PupilID])
		REFERENCES [dbo].[Pupil] ([PupilID]) ON DELETE CASCADE,
	--CONSTRAINT [FK_dbo.CompetitionSubmission_dbo.CompetitionQuestion_CQID] FOREIGN KEY ([CQID])
	--	REFERENCES [dbo].[CompetitionQuestion] ([CQID]) ON DELETE CASCADE
);
