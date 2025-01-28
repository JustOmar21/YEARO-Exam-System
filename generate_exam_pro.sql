-------------------------------------------------------------
create or alter procedure generate_exam
@examName nvarchar(100),
@startDate datetime,
@crsID int
with encryption
as
begin 
begin try
 begin transaction
	IF @crsID IS NULL
            PRINT 'Input Course ID cannot be NULL.';
	ELSE IF NOT EXISTS (SELECT 1 FROM COURSE WHERE ID = @CrsID)
	        PRINT 'Input Course ID cannot be found';
	else 
	begin
		insert into Exam (Name,StartDate,CrsID) values(@examName,@startDate,@crsID)
		declare @examID int=scope_identity();
		create table #selectedRandomQuestionIDS
		(
		QID int
		); 
		insert into #selectedRandomQuestionIDS
		SELECT TOP 10 id
				 FROM Question
				 WHERE CrsID = @crsID
				 ORDER BY NEWID();
	   insert into Answer_Exam (ExamID,QID,StdID) 
	   select @examID ,QID,sc.StdID from #selectedRandomQuestionIDS cross join Std_Crs SC where sc.CrsID=@crsID
	   print 'exam is generated successefully'
	 commit transaction;
 end
end try 
begin catch 
 print 'error occured in exam generation '
 rollback;
end catch
end
generate_exam 'exam6','2027-2-13 11:30:30',3