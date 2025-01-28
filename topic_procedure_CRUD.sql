-----------------------------topic procedures CRUD----------------------------------------
CREATE or alter PROCEDURE sp_AddTopic
    @topicName NVARCHAR(100),
    @CrsName NVARCHAR(100)
AS
BEGIN
    declare @id int;
	select @id=id from Course where Name=@CrsName;
	IF @@ROWCOUNT = 0
        PRINT 'No course found with the specified name';
	else 
		INSERT INTO [dbo].[Topic] ([Name], [CrsID])
		VALUES (@topicName, @id);
END;
CREATE PROCEDURE sp_UpdateTopicName
    @oldTopicName NVARCHAR(100),
	@newTopicName NVARCHAR(100)
AS
BEGIN
    IF EXISTS (SELECT 1 FROM Topic WHERE name = @oldTopicName)
	begin
		UPDATE [dbo].[Topic]
		SET [Name] = @newTopicName
		WHERE [Name] = @oldTopicName;
	end
	else
	 print 'No topic found with the specified name'
END;
CREATE or alter PROCEDURE sp_ChangeTopicCourse
    @TopicName NVARCHAR(100),
	@oldCourseName NVARCHAR(100),
	@newCourseName NVARCHAR(100)
AS
BEGIN
    IF EXISTS (SELECT 1 FROM Topic WHERE name = @TopicName)and 
	    EXISTS (SELECT 1 FROM course WHERE name = @oldCourseName ) and
		EXISTS (SELECT 1 FROM course WHERE name = @newCourseName )
		begin
			declare @oldCourseId int;
			declare @newCourseId int;
			select @oldCourseId=id from Course where Name=@oldCourseName;
			select @newCourseId=id from Course where Name=@newCourseName;
			UPDATE [dbo].[Topic]
			SET [CrsID] = @newCourseId
			WHERE [CrsID] = @oldCourseId and Name=@TopicName;
		end
	else if not EXISTS (SELECT 1 FROM Topic WHERE name = @TopicName)
	 print 'No topic found with the specified name'
	else if not EXISTS (SELECT 1 FROM course WHERE name = @oldCourseName )
	 print 'the course  you want to move the topic from does not exist '
	else if not EXISTS (SELECT 1 FROM course WHERE name = @newCourseName )
	 print 'the course  you want to move the topic to does not exist '
END;
CREATE PROCEDURE sp_DeleteTopic
    @TopicName NVARCHAR(100),
	@CourseName NVARCHAR(100)
AS
BEGIN
    IF EXISTS (SELECT 1 FROM Topic WHERE name = @TopicName)and 
	    EXISTS (SELECT 1 FROM course WHERE name = @CourseName )
    DELETE FROM [dbo].[Topic]
    WHERE [CrsID] = (select id from Course where Name=@CourseName) and name =@TopicName;
	else if not EXISTS (SELECT 1 FROM Topic WHERE name = @TopicName)
	 print 'No topic found with the specified name'
	else if not EXISTS (SELECT 1 FROM course WHERE name = @CourseName )
	 print 'the course you want to remove the topic from does not exist '
END;
--exec sp_DeleteTopic 'polymorphism','jke'
--exec sp_ChangeTopicCourse 'polymorphism','oop','dataStructure'
--exec sp_UpdateTopicName 'inheritacne','abstraction'
--exec sp_AddTopic 'linked list','dataStructure'