use [YEARO Exam System] EXEC sp_changedbowner 'sa'
CREATE or alter PROCEDURE pro_insert_question_choice
    @Body NVARCHAR(MAX),
    @Type NVARCHAR(10) ,
    @Degree INT ,
	@CorrectChoice INT,
	@CrsName NVARCHAR(MAX),
    @Choice1 NVARCHAR(MAX) = NULL,
    @Choice2 NVARCHAR(MAX) = NULL,
    @Choice3 NVARCHAR(MAX) = NULL,
    @Choice4 NVARCHAR(MAX) = NULL
	 
AS
BEGIN

    declare @CrsID int;
	select @CrsID=id from Course where Name=@CrsName;

    IF @@ROWCOUNT = 0
    PRINT 'No course found with the specified name';

	INSERT INTO Question (Body, [Type], Degree, CorrectChoice, CrsID)
	VALUES (@Body, @Type, @Degree, @CorrectChoice, @CrsID);

	DECLARE @question_id INT;
    SELECT @question_id = SCOPE_IDENTITY();

	if( @Type='mcq')
	begin
		 if( @Choice1 IS NOT NULL AND @Choice2 IS NOT NULL AND
		      @Choice3 IS NOT NULL AND @Choice4 IS NOT NULL )
			 begin 
				  INSERT INTO Choice(QID,Choice,body)
				  VALUES (@question_id,1, @Choice1);
				  INSERT INTO Choice(QID,Choice,body)
				  VALUES (@question_id,2, @Choice2);
				  INSERT INTO Choice(QID,Choice,body)
				  VALUES (@question_id,3, @Choice3);
				  INSERT INTO Choice(QID,Choice,body)
				  VALUES (@question_id,4, @Choice4);
			 end

	      ELSE
            BEGIN
                RAISERROR('All choices must be provided for MCQ questions.', 16, 1);
            END
	 end
    else 
		begin 
				INSERT INTO Choice(QID,Choice,body)
				VALUES (@question_id,1, 'T');
				INSERT INTO Choice(QID,Choice,body)
				VALUES (@question_id,2, 'F');
		end
END;

EXEC pro_insert_question_choice 
    'What is not the main feature of OOP?', 
    'MCQ', 
    3, 
    4, 
    'Data Structures', 
    'Encapsulation', 
    'Polymorphism', 
    'Inheritance', 
    'primary key';


CREATE or alter PROCEDURE generate_random_questions
@CrsName NVARCHAR(MAX)
As 
begin

   declare @CrsID int;
	select @CrsID=id from Course where Name=@CrsName;

    IF @@ROWCOUNT = 0
    PRINT 'No course found with the specified name';

	SELECT 
			q.Body AS QuestionBody,
			MAX(CASE WHEN c.Choice = 1 THEN c.body END) AS Choice1,
			MAX(CASE WHEN c.Choice = 2 THEN c.body END) AS Choice2,
			MAX(CASE WHEN c.Choice = 3 THEN c.body END) AS Choice3,
			MAX(CASE WHEN c.Choice = 4 THEN c.body END) AS Choice4
		FROM 
			(SELECT TOP 10 *
			 FROM Question
			 WHERE CrsID = @CrsID
			 ORDER BY NEWID()) q
		inner JOIN 
			Choice c ON q.ID = c.QID
		GROUP BY 
			q.ID, q.Body;
end 

EXEC generate_random_questions 'Data Structures';




CREATE or alter PROCEDURE generate_ALLCourse_questions
@CrsName NVARCHAR(MAX)
As 
begin

    declare @CrsID int;
	select @CrsID=id from Course where Name=@CrsName;

    IF @@ROWCOUNT = 0
    PRINT 'No course found with the specified name';

	SELECT 
			q.Body AS QuestionBody,
			MAX(CASE WHEN c.Choice = 1 THEN c.body END) AS Choice1,
			MAX(CASE WHEN c.Choice = 2 THEN c.body END) AS Choice2,
			MAX(CASE WHEN c.Choice = 3 THEN c.body END) AS Choice3,
			MAX(CASE WHEN c.Choice = 4 THEN c.body END) AS Choice4
		FROM Question q
		inner JOIN 
			Choice c ON q.ID = c.QID and q.CrsID = @CrsID
		GROUP BY 
			q.ID, q.Body;
end

exec generate_ALLCourse_questions 'Calculus I';


CREATE or alter PROCEDURE delete_course_question
@CrsName NVARCHAR(MAX), 
@QuesID Int
As 
begin

    declare @CrsID int;
	select @CrsID=id from Course where Name=@CrsName;

    IF @@ROWCOUNT = 0
       PRINT 'No course found with the specified name';
	 else
		 begin
		   IF EXISTS (SELECT 1 FROM Question WHERE ID = @QuesID)
			   begin
					update Question
					set isDeleted = 1
					where ID = @QuesID and CrsID =  @CrsID
				end
			else 
			 PRINT 'No  Question found with the specified id';
		 end
end

exec delete_course_question 'oop', 18;

CREATE or alter PROCEDURE delete_course_questions
@CrsName NVARCHAR(MAX)
As 
begin

    declare @CrsID int;
	select @CrsID=id from Course where Name=@CrsName;

    IF @@ROWCOUNT = 0
       PRINT 'No course found with the specified name';
	 else
		 begin
					update Question
					set isDeleted = 1
					where CrsID =  @CrsID
          end
end

exec delete_course_questions 'Calculus I';