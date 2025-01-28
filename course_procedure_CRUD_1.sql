-----------------------------course procedures CRUD---------------------------------
CREATE or alter PROCEDURE sp_AddCourse
    @Name NVARCHAR(100),
    @Hours INT
AS
BEGIN
    IF (@Hours < 3 OR @Hours > 100)
    BEGIN
        RAISERROR ('Course hours must be between 3 and 100.', 16, 1);
        RETURN;
    END
	else
		begin
		INSERT INTO Course (Name, Hours)
		VALUES (@Name, @Hours);
		end
END;

CREATE or alter PROCEDURE sp_DeleteCourse
    @name NVARCHAR(100)
AS
BEGIN
    declare @id int;
	select @id=id from Course where Name=@name;
	IF @@ROWCOUNT = 0
        PRINT 'No course found with the specified name';
	else
			IF EXISTS (SELECT 1 FROM Topic WHERE CrsID = @id)
				BEGIN
					DELETE FROM Topic
					WHERE CrsID = @id
				END
			CREATE TABLE #questionIDS (
			questionID INT
			);
			insert into #questionIDS 
			select id from Question where CrsID=@id;
			DECLARE @QID INT;

			DECLARE question_cursor CURSOR FOR
			SELECT questionID from #questionIDS

			OPEN question_cursor;

			FETCH NEXT FROM question_cursor INTO @QID;

			WHILE @@FETCH_STATUS = 0
				BEGIN
				Delete from Choice
				where  QID = @QID

				FETCH NEXT FROM question_cursor INTO @QID;
				END;

			CLOSE question_cursor;
			DEALLOCATE question_cursor;
			delete from Course where ID=@id;
END;
exec sp_DeleteCourse 'Data Structures';

CREATE or alter PROCEDURE sp_GetCourse
    @name NVARCHAR(100)
AS
BEGIN
    declare @id int;
	select @id=id from Course where Name=@name;
	IF @@ROWCOUNT = 0
        PRINT 'No course found with the specified name';
	else 
		begin 
			SELECT 
			c.name AS courseName,c.Hours as courseHour,
			ISNULL(STRING_AGG(t.Name, ', '), 'No topics') AS Topics 
		FROM 
			course c
		left JOIN 
			topic t ON c.ID = t.CrsID where c.Name=@name
			group by c.name,c.Hours
		end
END;
exec sp_GetCourse 'oop'
CREATE OR ALTER PROCEDURE sp_get_all_courses
AS
BEGIN
    SELECT Name,Hours 
    FROM Course;
END;
exec sp_get_all_courses
CREATE or alter PROCEDURE sp_GetAllCoursesWithTopics
AS
BEGIN
    SELECT 
        C.Name AS CourseName,
        C.Hours AS CourseHours,
        ISNULL( STRING_AGG(T.Name, ', '),'no topic') AS Topics 
    FROM Course C
    LEFT JOIN Topic T ON C.ID = T.CrsID
    GROUP BY  C.Name, C.Hours; 
END;
exec sp_GetAllCoursesWithTopics;

CREATE or alter PROCEDURE sp_UpdateCourseName
    @oldName NVARCHAR(100),
    @newName NVARCHAR(100)
AS
BEGIN
    declare @id int;
	select @id=id from Course where Name=@oldName;
	IF @@ROWCOUNT = 0
        PRINT 'No course found with the specified name';
    else
	   update course set Name=@newName where ID=@id
END;
CREATE or alter PROCEDURE sp_UpdateCourseHour
    @Name NVARCHAR(100),
    @Hour int
AS
BEGIN
    declare @id int;
	select @id=id from Course where Name=@Name;
	IF @@ROWCOUNT = 0
        PRINT 'No course found with the specified name';
    else if (@Hour not between 3 and 100 )
	  RAISERROR ('Course hours must be between 3 and 100.', 16, 1);
	else
	   update course set Hours=@Hour where ID=@id
END;