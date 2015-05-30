--INSERT INTO Competition
--	(DateStart, DateFinish)
--VALUES
--	('2014-09-20', '2014-12-20');

--INSERT INTO Question
--	(Question)
--VALUES
--	('When Aiming:');

--INSERT INTO Answer
--	(Answer, Correct)
--VALUES
--	('Focus on the target', 1),
--	('Focus on the dart', 0),
--	('Focus on your hand', 0);

--ALTER TABLE CompetitionQuestion
--ADD Ans2ID INT;

--ALTER TABLE CompetitionQuestion
--ADD Ans3ID INT;

--ALTER TABLE CompetitionQuestion
--ADD FOREIGN KEY (Ans2ID)
--REFERENCES Answer(AnsID);

--ALTER TABLE CompetitionQuestion
--ADD FOREIGN KEY (Ans3ID)
--REFERENCES Answer(AnsID);

INSERT INTO CompetitionQuestion
	(CompID, QuestionID, AnsID, Ans2ID, Ans3ID)
VALUES
	(3, 1, 1, 2, 3);
