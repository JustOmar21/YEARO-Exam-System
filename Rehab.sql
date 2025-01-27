use [Trial-Database];
-----------------STORED PROCEDURE FOR INSERT INTAKE DATA-------------------------
CREATE PROCEDURE InsertIntake
    @Name NVARCHAR(100),
    @StartDate DATE
AS
BEGIN
    IF @Name IS NULL OR LTRIM(RTRIM(@Name)) = ''
    BEGIN
        print 'Name cannot be empty or NULL.';
    END

    ELSE IF @StartDate < GETDATE()  --2023 > 2022
    BEGIN
        print 'StartDate cannot be in the past.';
    END

    ELSE

	BEGIN try
    INSERT INTO Intake (Name, StartDate)
    VALUES (@Name, @StartDate);

	print 'Data inserted successfully.';
	END try
	begin catch
	     select 'invalid input'
	end catch

    
END;


exec InsertIntake 'intake-42' , '2/2/2026'
select * from intake
--notic: if we need handle start date & identity

-------------------stored procedre for delete----------------------------

create proc deleteIntake @name varchar(100)
as 
  IF EXISTS (SELECT 1 FROM Intake WHERE Name = @Name)
  begin
   delete from intake  where name=@name
   print 'deleted successfully.';
  end 

  else
  begin
    print 'The intake is not exists'
  end

--CALL
 EXEC deleteIntake 'intake-48'

 select * from intake


--------------------Stored procedure update update Intake Name-----------------

create PROCEDURE updateIntakeName
    @oldName NVARCHAR(100), @newName NVARCHAR(100)
AS
BEGIN
    IF @oldName IS NULL OR LTRIM(RTRIM(@oldName)) = ''
    BEGIN
        print 'Name cannot be empty or NULL.';
    END

  else IF EXISTS (SELECT 1 FROM Intake WHERE Name = @oldName)
     begin
       UPDATE Intake SET Name = @newName
       WHERE Name = @oldName
       print 'Update intake name successfully.';
     end 

    ELSE
	begin
	  print 'the intake name is not exists'
	end
end;

EXEC updateIntakeName 'intake-42' ,'intake-44' 

select * from intake 

----------STORED PROCEDURE TO UPDATE INTAKE START DATE BY INTAKE NAME-------------


create PROCEDURE updateIntakeStartDate
    @intake_Name NVARCHAR(100), @St_date date 
AS
BEGIN
    IF @intake_Name IS NULL OR LTRIM(RTRIM(@intake_Name)) = ''
    BEGIN
        print 'Name cannot be empty or NULL.';
    END

  else IF EXISTS (SELECT 1 FROM Intake WHERE Name = @intake_Name)
     begin
       UPDATE Intake SET StartDate = @St_date
       WHERE Name = @intake_Name
       print 'Update Start date for intake ' + @intake_Name +  ' successfully.';
     end 

    ELSE
	begin
	  print 'the intake name is not exists.'
	end
end;

--call
EXEC updateIntakeStartDate 'intake-44' , '2/2/2028'
select * from intake

---------------------------STORED PROCEDURE FOR UPDATE INTAKE NAME & START DATE TOGETHER-----------------

create PROCEDURE updateIntakeNameAndDate
    @oldName NVARCHAR(100), 
    @NewName NVARCHAR(100),  
    @New_date DATE 
AS
BEGIN
    -- Check if the old name is NULL or empty
    IF @oldName IS NULL OR LTRIM(RTRIM(@oldName)) = ''
    BEGIN
        PRINT 'Name cannot be empty or NULL.';
        RETURN; -- Exit procedure if old name is invalid
    END

    -- Check if the intake with the old name exists
    IF EXISTS (SELECT 1 FROM Intake WHERE Name = @oldName)
    BEGIN
        BEGIN TRANSACTION;
            BEGIN TRY
                -- Update the intake record with new name and date
                UPDATE Intake 
                SET StartDate = @New_date, Name = @NewName
                WHERE Name = @oldName;

                COMMIT TRANSACTION;
                PRINT 'Update intake name ' + @oldName + ' to ' + @NewName + ' and start date to ' + CONVERT(NVARCHAR(20), @New_date, 120) + ' successfully.';
            END TRY
            BEGIN CATCH
                -- Rollback if an error occurs
                ROLLBACK TRANSACTION;
                PRINT 'An error occurred: please check again on your data may intake name do not follow rules ';
            END CATCH
    END
    ELSE
    BEGIN
        PRINT 'The intake name does not exist.';
    END
END;

--call

EXEC updateIntakeNameAndDate 'intake-44' , 'intake-45',  '2/2/2026';
select * from intake

---------------------------------STORED PROC TO RETRIVE all INTAKEs INFO --------

Create Proc ViewAIntakesInfo 
with encryption 
as 
  begin
      select * from  intake 
  end


--call
exec ViewAIntakesInfo


-------------------------STORED PROCEDURE TO RETRIVE INFO ABOUT SPECIFIC INTAKE USING NAME------------------


create PROCEDURE ViewSpecificIntakeInfo
    @intake_Name NVARCHAR(100)
AS
BEGIN
    IF @intake_Name IS NULL OR LTRIM(RTRIM(@intake_Name)) = ''
    BEGIN
        print 'Name cannot be empty or NULL.';
    END

  else IF EXISTS (SELECT 1 FROM Intake WHERE Name = @intake_Name)
     begin
	   select * from intake 
	   where Name=@intake_Name
       
     end 

    ELSE
	begin
	  print 'the intake name is not exists.'
	end
end;

--call
EXEC ViewSpecificIntakeInfo 'intake-45'
select * from intake



----------------------------DEPARTMENT--------------------------------
SELECT * FROM Department

-----------------------STORED PROCEDURE FOR INSERT DEPARTMENT---------

Create PROCEDURE InsertDepartment
    @Name NVARCHAR(100),
    @Describe NVARCHAR(255)
with encryption
AS
BEGIN
    IF @Name IS NULL OR LTRIM(RTRIM(@Name)) = ''  
    BEGIN
        print 'Input cannot be empty or NULL.';
    END

  ElSE IF EXISTS (SELECT 1 FROM Department WHERE Name = @Name) 
     begin
       print 'The Department ' + @Name +  ' Is already exists.';
     end 

    ELSE
	BEGIN try
       INSERT INTO Department(Name, Describe)
       VALUES (@Name, @Describe);
	   print 'Data inserted successfully.';
	END try
	begin catch
	     select 'invalid input'
	end catch
    
END;

--call
exec InsertDepartment 'data sc' , ''
select * from department

------------------------STORED PROCEDURE FOR DELETE Depatment------------

Create PROCEDURE DeleteSpecificDepartment
    @DID NVARCHAR(100)
with encryption
AS
BEGIN
    IF @DID IS NULL OR LTRIM(RTRIM(@DID)) = ''  
    BEGIN
        print 'Input cannot be empty or NULL.';
    END

  ElSE IF EXISTS (SELECT 1 FROM Department WHERE ID = @DID) 
     begin
	   delete from Department WHERE ID = @DID
       print 'The Department ' + @DID +  ' deleted.';
     end 

    ELSE
	   print 'The department is not exsists.';
   
END;

--call
exec DeleteSpecificDepartment 4 
select * from department

----------------------STORED PROCEDURE FOR DELETE ALL  DEPARTMENTS------------
CREATE proc deleteAllDepartments 
with encryption
as 
  begin
      delete from department
	  print 'The departments deleted';
  end

--call
EXEC deleteAllDepartments


----update id for previuos proc
------------------------STORED PROCEDURE FOR Update Department Name AND DESCRIPTION USING ID ----------

CREATE PROCEDURE updateDepartmentName
    @DID INT, @newName NVARCHAR(100) , @Describe NVARCHAR(255)
With encryption
AS
BEGIN
    IF @DID IS NULL OR LTRIM(RTRIM(@DID)) = '' 
	and @newName is null OR LTRIM(RTRIM(@DID)) = ''
    BEGIN
        print 'input cannot be empty or NULL.';
    END

  else IF EXISTS (SELECT 1 FROM Department WHERE ID = @DID) 
     begin
       UPDATE Department SET Name = @newName  , Describe=@Describe
       WHERE ID = @DID
       print 'Update intake name successfully.';
     end 

    ELSE
	begin
	  print 'the intake name is not exists'
	end
end;

EXEC updateDepartmentName  6,'data analysis ', ' ' 

select * from Department  




---------------------------------STORED PROC TO RETRIVE all DEPARTMENTS INFO --------

Create Proc ViewADepartmentsInfo 
with encryption 
as 
  begin
      select * from  Department 
  end


--call
exec ViewADepartmentsInfo


-------------------------STORED PROCEDURE TO RETRIVE INFO ABOUT SPECIFIC DEPT USING NAME------------------


create PROCEDURE ViewSpecificDepartmentInfo
    @DID INT
AS
BEGIN
    IF @DID IS NULL OR LTRIM(RTRIM(@DID)) = ''
    BEGIN
        print 'Department id cannot be empty or NULL.';
    END

  else IF EXISTS (SELECT 1 FROM Department WHERE ID = @DID)
     begin
	   select * from Department 
	   where ID=@DID
       
     end 

    ELSE
	begin
	  print 'the Department is not exists.'
	end
end;

--call
EXEC ViewSpecificDepartmentInfo 2
select * from Department


--------------------------STORED PROCEDURE FOR EXAM ---------------------
--view specific exam     done
--view all exam          done
--insert exam data       done
--delete specific exam   done
--delete all             done
--update exam start date done
--generate exam          NOPE


--CREATE PROC GENERATE EXAM (
      --EXEC INSERT EXAM
	  --EXEC INSERT QUSTION INTO EXAM 
--)
select * from Exam
select * from Answer_Exam
-------------------------STORED PROCEDURE FOR Retrive data about specific exam------------------------


create PROCEDURE ViewSpecificExamInfo
    @EX_ID INT
WITH ENCRYPTION
AS
BEGIN
    IF @EX_ID IS NULL OR LTRIM(RTRIM(@EX_ID)) = ''
    BEGIN
        print 'Department id cannot be empty or NULL.';
    END

  else IF EXISTS (SELECT 1 FROM Exam WHERE ID = @EX_ID)
     begin
	   select * from Department 
	   where ID=@EX_ID   
     end 

    ELSE
	begin
	  print 'the EXAM is not exists.'
	end
end;

--call
EXEC ViewSpecificExamInfo 2
select * from Department


---------------------------------STORED PROC TO RETRIVE all EXAMS INFO --------

CREATE Proc ViewExamsInfo 
with encryption 
as 
  begin
      select * from  Exam 
  end


--call
exec ViewExamsInfo



-----------------------STORED PROCEDURE FOR INSERT EXAM---------
-----WAIT FOR TESTING INSERT COURSE
select * from exam

CREATE PROCEDURE InsertExam
    @Name NVARCHAR(100),
    @StartDate DATETIME,  --'YYYY-MONTH-D  HOURS-MIN-SEC'
    @CrsID INT
WITH ENCRYPTION
AS
BEGIN
  BEGIN TRY
     IF @Name IS NULL OR LTRIM(RTRIM(@Name)) = ''
            PRINT 'Input Name cannot be empty or NULL.';

     ELSE IF @CrsID IS NULL
            PRINT 'Input Course ID cannot be NULL.';

     ELSE IF NOT EXISTS (SELECT 1 FROM COURSE WHERE ID = @CrsID)
            PRINT 'The Course with ID: ' + CAST(@CrsID AS NVARCHAR(10)) + ' is not found.';
     else IF @StartDate <= GETDATE()
            PRINT 'StartDate cannot be in the past or today or empty.';
     ELSE
        BEGIN
            INSERT INTO Exam (Name,  StartDate, CrsID)
            VALUES (@Name,@StartDate, @CrsID);
			PRINT 'Data inserted successfully.';
	    END
   END TRY
   BEGIN CATCH
            PRINT 'An error occurred.';
   END CATCH
END;

-- CALL
EXEC InsertExam 'Data Structure9' ,'2/2/2026' ,4


------------------------STORED PROCEDURE FOR DELETE Department------------

create PROCEDURE DeleteSpecificExam
    @EX_ID NVARCHAR(100)
with encryption
AS
BEGIN
    IF @EX_ID IS NULL OR LTRIM(RTRIM(@EX_ID)) = ''  
    BEGIN
        print 'Input cannot be empty or NULL.';
    END

  ElSE IF EXISTS (SELECT 1 FROM Exam WHERE ID = @EX_ID) 
     begin
	   delete from Exam WHERE ID = @EX_ID
       print 'The EXAM ' + @EX_ID +  ' deleted.';
     end 

    ELSE
	   print 'The Exam is not exsists.';
   
END;

--call
exec DeleteSpecificExam 17
select * from Exam

----------------------STORED PROCEDURE FOR DELETE ALL EXAMS------------
CREATE proc deleteAllExams 
with encryption
as 
  begin
      delete from department
	  print 'The departments deleted';
  end

--call
EXEC deleteAllExams

--------------------------STORED PROCEDURE TO UPDATE START DATE FOR EXAM-----------------
CREATE PROCEDURE updateExamStartDate
    @EX_id INT, @newdate DATETIME 
With encryption
AS
BEGIN
   begin try
    IF @EX_id is null
        print 'Exam id cannot be empty or NULL.'
	else IF @newdate <= GETDATE()
            PRINT 'StartDate cannot be in the past or today or empty.';
    else IF EXISTS (SELECT 1 FROM EXAM WHERE ID = @EX_id) 
     begin
       UPDATE Exam SET StartDate = @newdate  
       WHERE ID = @EX_id
       print 'Update exam start date successfully.';
     end 
	 else
	    PRINT 'Exam with the given ID does not exist.';
  end try
  begin catch
	  print 'there are error occured'
  end catch

end;

EXEC updateExamStartDate  12,'9/9/2029  13:45:30'

---------------------------INSTRUCTOR-COURSE ---------------------------

--VIEW ALL INSTRUCTOR COURSE                         DONE
--VIEW SPECIFIC EACH COURSE FOR INSTRUCTOR           done   
--DELETE ANY INSTRUCOR WITH ALL COURSES              DONE      
--DELETE ANY INSTRUCTOR WITH SPECIFIC COURSE         done  
--DELETE ALL INS_CR TABLE                            DONE
--UPDATE COURSE FOR INSTRUCTOR   RAMI C -->C++       done                                                     
--UPDATE INSTRUCTOR FOR COURSE                       DONE
--INSERT INTO                                        DONE
SELECT * FROM EXAM
SELECT * FROM Ins_Crs
--------------------------STORED PROCEDURE TO VIEW ALL INSTRUCTOR COURSE-------------   

CREATE PROC ViewAllInstructorCourse
WITH ENCRYPTION
AS
  BEGIN
  	   select ic.InsID as [instructorID],p.Name as[Instructor_Name]  , c.Name as [Cpurse_Name]  ,ic.CrsID
	   from Ins_Crs ic join person p
	   on p.ID=ic.InsID
	   join Course c on  c.ID=ic.CrsID 
  END

--CALL
EXEC ViewAllInstructorCourse


-------------------------STORED PROCEDURE TO VIEW  COURSES FOR SPECIFIC INSTRUCTOR------------------------


CREATE PROCEDURE GetCoursesByInstructor

    @INS_ID INT = NULL  
WITH ENCRYPTION
AS
BEGIN
  begin try
    IF @INS_ID IS NULL 
    BEGIN
        print 'Instructor id cannot be empty or NULL.';
    END

    else IF EXISTS (SELECT 1 FROM Ins_Crs WHERE InsID = @INS_ID)
     begin
	   select InsID as [instructorID],p.Name as[Instructor_Name] ,  c.Name as [Course_Name]  , ic.CrsID AS [Course_ID] 
	   from Ins_Crs ic join person p
	   on p.ID=ic.InsID
	   join Course c on  c.ID=ic.CrsID
	   where InsID=@INS_ID   
     end 

    ELSE
	begin
	  PRINT 'The Instructor with ID ' + CAST(@INS_ID AS NVARCHAR(10)) + ' does not exist.';
	end
  end try
    BEGIN CATCH
        PRINT 'An error occurred, please try again.';
    END CATCH
end;

--call
EXEC GetCoursesByInstructor 7


select * from Ins_Crs
select * from course
select * from person



------------------------STORED PROCEDURE FOR DELETE all courses for specific instructor ------------

create PROCEDURE DeleteInstructorCourses
    @INS_ID INT = NULL  
with encryption
AS
BEGIN
  begin try
    IF @INS_ID IS NULL 
    BEGIN
        print 'Input cannot be empty or NULL.';
    END

  ElSE IF EXISTS (SELECT * FROM Ins_Crs WHERE InsID = @INS_ID) 
     begin
	   delete from Ins_Crs WHERE InsID = @INS_ID
       print 'The courses for instructor ' + CAST(@INS_ID AS NVARCHAR(10))+ ' deleted.';
     end 
    
	ELSE
	   PRINT 'The Instructor with ID ' + CAST(@INS_ID AS NVARCHAR(10)) + ' does not exist.';
    end try
    BEGIN CATCH
       PRINT 'An error occurred, please try again.';
    END CATCH
   
END;

--call
EXEC DeleteInstructorCourses 


select * from Ins_Crs
------------------------STORED PROCEDURE TO DELETE ASSIGNED OR SPCECIFFIC course for specific instructor ------------

CREATE PROCEDURE DeleteInstructorAssignedToCourse
    @INS_ID INT = NULL  ,  @CRS_ID INT = NULL        
with encryption
AS
BEGIN
  begin try
    IF @INS_ID IS NULL OR @CRS_ID IS NULL
    BEGIN
        print 'Input cannot be empty or NULL.';
    END

  ElSE IF EXISTS (SELECT 1 FROM Ins_Crs WHERE InsID = @INS_ID and CRSid=@CRS_ID) 
     begin
	   delete from Ins_Crs WHERE  InsID = @INS_ID and CRSid=@CRS_ID
       print 'The course with ID : '+CAST(@CRS_ID AS NVARCHAR(10)) +' for instructor ' + CAST(@INS_ID AS NVARCHAR(10))+ ' deleted.';
     end 
    
	ELSE
	   PRINT 'The Assignation coures for this instructor does not exist.';
    end try
    BEGIN CATCH
       PRINT 'An error occurred, please try again.';
    END CATCH
   
END;

--call
EXEC DeleteInstructorAssignedToCourse 7 , 5


select * from Ins_Crs




----------------------STORED PROCEDURE FOR DELETE ALL data into instructor_course ------------
CREATE proc deleteAllInstructorCourseData 
with encryption
as 
  begin
      delete from Ins_Crs
	  print 'The Instructor_Course table deleted';
  end

--call
EXEC deleteAllInstructorCourseData
select * from Ins_Crs



-----------------------------------STORED PROCEDURE TO INSERT INSTRUCTOR COURSE ------------------
CREATE PROCEDURE InsertInstructorCourse
     @INS_ID INT = NULL  ,  @CRS_ID INT = NULL
WITH ENCRYPTION
AS
BEGIN
  BEGIN TRY
     IF @INS_ID IS NULL 
       BEGIN
        print 'Input INS_ID cannot be empty or NULL.';
       END

     ELSE IF @CRS_ID IS NULL
            PRINT 'Input Course ID cannot be NULL.';

     ELSE IF NOT EXISTS (SELECT * FROM COURSE WHERE ID = @CRS_ID)
            PRINT 'The Course with ID: ' + CAST(@CRS_ID AS NVARCHAR(10)) + ' is not found.';
	 ELSE IF NOT EXISTS (SELECT * FROM Instructor WHERE InsID = @INS_ID)
            PRINT 'The INSTRUCTOR with ID: ' + CAST(@INS_ID AS NVARCHAR(10)) + ' is not found.';
	ELSE IF EXISTS (SELECT * FROM Ins_Crs WHERE InsID = @INS_ID and CrsID=@CRS_ID)
            PRINT 'The Assigned Between ' + CAST(@INS_ID AS NVARCHAR(10))+' and'+CAST(@CRS_ID AS NVARCHAR(10)) + ' is already exists.';
     ELSE
        BEGIN
            INSERT INTO Ins_Crs( InsID, CrsID)
            VALUES (@INS_ID,@CRS_ID);
			PRINT 'Data inserted successfully.';
	    END
   END TRY
   BEGIN CATCH
            PRINT 'An error occurred.';
   END CATCH
END;

-- CALL
EXEC InsertInstructorCourse  75 , 10

---------------------------------STORED PROCEDURE TO UPDATE COURSE FOR INSTRUCTOR   RAMI  C --> RAMI  C++ -------------
CREATE PROCEDURE ModifyInstructorCourse
    @INS_ID INT = NULL  ,  @Old_CRS_ID INT = NULL   ,@new_CRS_ID INT = NULL 
with encryption
AS
BEGIN
  begin try
     IF @INS_ID IS NULL 
       BEGIN
        print 'Input INSTRUCTOR_ID cannot be empty or NULL.';
       END

     ELSE IF @Old_CRS_ID IS NULL OR @new_CRS_ID IS NULL 
            PRINT 'Input Course ID cannot be NULL.';
     ELSE IF NOT EXISTS (SELECT * FROM Instructor WHERE InsID =@INS_ID)
            PRINT 'The instructor with ID: ' + CAST(@INS_ID AS NVARCHAR(10)) + ' is not found.';
	 ELSE IF NOT EXISTS (SELECT * FROM COURSE WHERE ID = @Old_CRS_ID)
            PRINT 'The old Course with ID: ' + CAST(@Old_CRS_ID AS NVARCHAR(10)) + ' is not found.';
     ELSE IF NOT EXISTS (SELECT * FROM COURSE WHERE ID = @new_CRS_ID)
            PRINT 'The new Course with ID: ' + CAST(@new_CRS_ID AS NVARCHAR(10)) + ' is not found.';

     ElSE IF EXISTS (SELECT 1 FROM Ins_Crs WHERE InsID = @INS_ID and CRSid=@Old_CRS_ID)  --ins_id  , old
	   begin
	     IF not EXISTS (SELECT 1 FROM Ins_Crs WHERE InsID = @INS_ID and CRSid=@new_CRS_ID)
		     begin
			    update Ins_Crs set CrsID=@new_CRS_ID
				where InsID=@INS_ID and CrsID=@Old_CRS_ID 
		      end
		 else
		 begin
		     print 'the assgination with instructor id: '+CAST(@INS_ID AS NVARCHAR(10))+' and course id: '+CAST(@new_CRS_ID AS NVARCHAR(10))+ ' already exists'
		 end
	   end
    else
     begin
          print 'the assgination with instructor id: '+CAST(@INS_ID AS NVARCHAR(10))+' and course id: '+CAST(@Old_CRS_ID AS NVARCHAR(10))+ ' is not exists'
     end 	
    end try
    BEGIN CATCH
       PRINT 'An error occurred, please try again.';
    END CATCH
   
END;
--call
 EXEC ModifyInstructorCourse 75,11 , 9


 ---------------------------------STORED PROCEDURE TO UPDATE COURSE FOR INSTRUCTOR   RAMI  C --> hani  C-------------
create PROCEDURE ModifyCourseInstructor
    @oldINS_ID INT = NULL  ,  @CRS_ID INT = NULL   ,@newIns_ID INT = NULL 
with encryption
AS
BEGIN
  begin try
     IF @oldINS_ID IS NULL or @newins_ID is null
       BEGIN
        print 'Input INSTRUCTOR_ID cannot be empty or NULL.';
       END

     ELSE IF @CRS_ID IS NULL  
            PRINT 'Input Course ID cannot be NULL.';
     ELSE IF NOT EXISTS (SELECT * FROM Instructor WHERE InsID =@oldINS_ID)
            PRINT 'The old instructor with ID: ' + CAST(@oldINS_ID AS NVARCHAR(10)) + ' is not found.';
	 ELSE IF NOT EXISTS (SELECT * FROM COURSE WHERE ID = @CRS_ID)
            PRINT 'The Course with ID: ' + CAST(@CRS_ID AS NVARCHAR(10)) + ' is not found.';
     ELSE IF NOT EXISTS (SELECT * FROM Instructor WHERE InsID = @newIns_ID)
            PRINT 'The new Instructor with ID: ' + CAST(@newIns_ID AS NVARCHAR(10)) + ' is not found.';

     ElSE IF EXISTS (SELECT 1 FROM Ins_Crs WHERE InsID = @oldINS_ID and CRSid=@CRS_ID)  --ins_id  , old
	   begin
	     IF not EXISTS (SELECT 1 FROM Ins_Crs WHERE InsID = @newIns_ID and CRSid=@CRS_ID)
		     begin
			    update Ins_Crs set InsID=@newIns_ID
				where InsID=@oldINS_ID and CrsID=@CRS_ID 
		      end
		 else
		 begin
		     print 'the assgination with instructor id: '+CAST(@newIns_ID AS NVARCHAR(10))+' and course id: '+CAST(@CRS_ID AS NVARCHAR(10))+ ' already exists'
		 end
	   end
    else
     begin
          print 'the assgination with instructor id: '+CAST(@oldINS_ID AS NVARCHAR(10))+' and course id: '+CAST(@CRS_ID AS NVARCHAR(10))+ ' is not exists'
     end 	
    end try
    BEGIN CATCH
       PRINT 'An error occurred, please try again.';
    END CATCH
   
END;
--CALL
EXEC ModifyCourseInstructor 76 , 9, 75



------------------------------------------STUDENT_COURSE---------------------
--1: VIEW ALL STUDENT COURSE                              DONE 
--2: VIEW ALL COURSE BY STUDENT                           DONE
--3: VIEW ALL STUDETN WITH SAME COURSE                    DONE
--4: DELETE STUDENT WITH ALL HIS COURSE                   DONE
--5: DELETE COURSE THAT WILL DELETE ALL STUDENT TOO       DONE
--6: DELETE TABLE                                         DONE
--7: INSERT STUDENT WITH COURSE                           DONE

---------------------------------STORED PROCEDURE VIEW ALL STUDENT COURSE --------------------------------------------
CREATE PROC ViewStudentCourse
WITH ENCRYPTION
AS 

   BEGIN
      SELECT s.StdID as [student_id] ,p.Name as [student_name]  ,s.CrsID as [course_id],c.Name as [course_name] 
	  FROM Std_Crs s join person p 
	  on s.StdID=p.id
	  join Course c on CrsID=c.ID
   END 

--CALL 
EXEC ViewStudentCourse



---------------------------------STORED PROCEDURE VIEW ALL COURSE BY STUDENT    --------------------------------------------
ALTER PROC ViewCoursesByStudent
    @St_id int=null
WITH ENCRYPTION
AS 
 begin
 if @St_id is null
        print 'student ID should not be null OR EMPTY'
 ELSE IF EXISTS (SELECT * FROM Std_Crs WHERE StdID = @St_id)
       BEGIN
          SELECT s.StdID as [student_id] ,p.Name as [student_name]  ,s.CrsID as [course_id],c.Name as [course_name] 
	      FROM Std_Crs s join person p 
	      on s.StdID=p.id
	      join Course c on CrsID=c.ID
	     where StdID=@St_id
        END

 else
   begin
     print 'student id: '+CAST(@St_id AS NVARCHAR(10))+ ' not fount'
   end
end
--CALL 
EXEC ViewCoursesByStudent 5
---------------------------------STORED PROCEDURE  VIEW ALL STUDETN WITH SAME COURSE    --------------------------------------------
create PROC ListStudentsForCourse
    @Cr_id int=null
WITH ENCRYPTION
AS 
 begin
 if @Cr_id is null
        print 'Course ID should not be null OR EMPTY'
 ELSE IF EXISTS (SELECT * FROM Std_Crs WHERE CrsID = @Cr_id)
       BEGIN
          SELECT s.StdID as [student_id] ,p.Name as [student_name]  ,c.Name as [course_name] 
	      FROM Std_Crs s join person p 
	      on s.StdID=p.id
	      join Course c on CrsID=c.ID
	     where CrsID = @Cr_id
        END

 else
   begin
     print 'course id: '+CAST(@Cr_id AS NVARCHAR(10))+ ' not fount'
   end
end
--CALL 
EXEC ListStudentsForCourse 2

----------------------STORED PROCEDURE TO DELETE STUDENT WITH ALL HIS COURSE----------
ALTER proc  DeleteStudentAndAssociatedCourses
  @ST_ID INT=NULL
WITH ENCRYPTION
AS 
BEGIN
    BEGIN TRY
	    IF @ST_ID is null
           print 'STUDENT ID should not be null OR EMPTY'

		ELSE IF EXISTS (SELECT * FROM Std_Crs WHERE StdID = @ST_ID)
           BEGIN
		     DELETE FROM Std_Crs WHERE StdID=@ST_ID
			 PRINT 'COURSES FOR STUDENT '+CAST(@ST_ID AS NVARCHAR(10))+' DELETED'
           END
	   else
           begin
             print 'STUDENT id: '+CAST(@ST_ID AS NVARCHAR(10))+ ' not fount'
            end
	END TRY
	BEGIN CATCH
	   PRINT 'ERROR OCCURED.'
	END CATCH
END

--CALL
EXECUTE DeleteStudentAndAssociatedCourses 6

----------------------STORED PROCEDURE TO Drop Course And IT'S Enrolled Students----------
CREATE proc  DropCourseAndEnrolledStudents
  @CRS_ID INT=NULL
WITH ENCRYPTION
AS 
BEGIN
    BEGIN TRY
	    IF @CRS_ID is null
           print 'COURSE ID should not be null OR EMPTY'

		ELSE IF EXISTS (SELECT * FROM Std_Crs WHERE CrsID = @CRS_ID)
           BEGIN
		     DELETE FROM Std_Crs WHERE CrsID=@CRS_ID
			 PRINT 'COURSE AND IT IS ENROLLED STUDENT '+CAST(@CRS_ID AS NVARCHAR(10))+' ARE DELETED'
           END
	   else
           begin
             print 'COURSE id: '+CAST(@CRS_ID AS NVARCHAR(10))+ ' not fount'
            end
	END TRY
	BEGIN CATCH
	   PRINT 'ERROR OCCURED.'
	END CATCH
END

--CALL
EXECUTE DropCourseAndEnrolledStudents 3

----------------------STORED PROCEDURE TO Drop STUDENT_COURSE----------
Create PROC DeleteStudentCoureTable
WITH ENCRYPTION
AS 
BEGIN
    BEGIN TRY
           BEGIN
		     DELETE FROM Std_Crs 
			 PRINT 'STUDENT_COURSE DATA DELETED' 
           END

	END TRY
	BEGIN CATCH
	   PRINT 'ERROR OCCURED.'
	END CATCH
END

--CALL
EXECUTE DeleteStudentCoureTable
-----------------------------------STORED PROCEDURE TO INSERT STUDENT COURSE ------------------
alter PROCEDURE InsertStudentCourse
     @St_ID INT = NULL  ,  @CRS_ID INT = NULL
WITH ENCRYPTION
AS
BEGIN
  BEGIN TRY
     IF @St_ID IS NULL 
       BEGIN
        print 'Input Student_ID cannot be empty or NULL.';
       END

     ELSE IF @CRS_ID IS NULL
            PRINT 'Input Course ID cannot be NULL.';
	 ELSE IF NOT EXISTS (SELECT * FROM Student WHERE StdID = @St_ID)
            PRINT 'The Student with ID: ' + CAST(@St_ID AS NVARCHAR(10)) + ' is not found.';
     ELSE IF NOT EXISTS (SELECT * FROM COURSE WHERE ID = @CRS_ID)
            PRINT 'The Course with ID: ' + CAST(@CRS_ID AS NVARCHAR(10)) + ' is not found.';
	ELSE IF EXISTS (SELECT * FROM Std_Crs WHERE StdID = @St_ID and CrsID=@CRS_ID)
            PRINT 'The Assigned Between ' + CAST(@St_ID AS NVARCHAR(10))+' and'+CAST(@CRS_ID AS NVARCHAR(10)) + ' is already exists.';
    ELSE
        BEGIN
            INSERT INTO Std_Crs( StdID, CrsID)
            VALUES (@St_ID,@CRS_ID);
			PRINT 'Data inserted successfully.';
	    END
   END TRY
   BEGIN CATCH
            PRINT 'An error occurred.';
   END CATCH
END;

-- CALL
EXEC InsertStudentCourse  6, 4
