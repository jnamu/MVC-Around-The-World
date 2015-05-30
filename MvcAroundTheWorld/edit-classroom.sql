--ALTER TABLE Classroom
--ADD SchoolName NVARCHAR(50);


--Help......
--ALTER TABLE Classroom
--ADD FOREIGN KEY (SchoolName)
--REFERENCES School(Name);


----------------------------
UPDATE Classroom
SET SchoolName = 'Auckland Point School'
WHERE SchoolID = 5;

UPDATE Classroom
SET SchoolName = 'Broadgreen Intermediate'
WHERE SchoolID = 6;

UPDATE Classroom
SET SchoolName = 'Nelson Intermediate'
WHERE SchoolID = 7;

UPDATE Classroom
SET SchoolName = 'Waimea Intermediate'
WHERE SchoolID = 8;

--DELETE FROM Classroom
--WHERE SchoolName = 'Broadgreen Intermediate';