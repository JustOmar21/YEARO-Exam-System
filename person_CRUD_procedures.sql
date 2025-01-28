--create or alter procedure sp_add_person
--@name nvarchar(max),
--@mail nvarchar(max),
--@nationalID nvarchar(max),
--@address nvarchar(max),
--@gender char(1),
--@salary decimal(18,2),
--@date_of_birth date,
--@phone nvarchar(max),
--@role nvarchar(30),
--@password nvarchar(255),
--@deptID int =null,
--@intakeID int = null,
--@college nvarchar(255) =null,
--@hireDate date =null
--as with encryption 
--begin 
--    begin try 
--	    begin transaction 
--		  if exists(select 1 from Department where ID=@deptID) or @deptID is null
--		 begin 
--			  INSERT INTO [dbo].[Person]
--			   ([Name]
--			   ,[Email]
--			   ,[NID]
--			   ,[Address]
--			   ,[Gender]
--			   ,[Salary]
--			   ,[DOB]
--			   ,[Phone]
--			   ,[Role]
--			   ,[Password]
--			   ,[DeptID])
--		 VALUES
--			   (@name,@mail,@nationalID,@address,@gender,@salary ,@date_of_birth,@phone,@role,@password,@deptID)
--		 declare @lastpersonID int = scope_identity();
	 
--	 -------------insert into student------------
--	 if(@role = 'Student')
--		 begin 
--		 if exists(select 1 from Intake where ID=@intakeID) or @intakeID is null
--		  begin 
--		    insert into Student values (@lastpersonID,@intakeID,@college)
--			print 'person inserted as a student successfully'
--		  end
--		  else
--		    print 'there is no intake with the specified intake id'
--		 end 
--	else if(@role = 'Instructor')
--	    begin 
--		    insert into Instructor values (@lastpersonID,@hireDate)
--			print 'person inserted as a instructor successfully'
--		 end 
--		 commit transaction;

		 
--	 end 
--	 else 
--	   print 'the department id you provided is not found '
--	end try ;
--	begin catch 
--	  print 'the data is invalid'
--	  rollback;
--	end catch 
--end;
CREATE OR ALTER PROCEDURE sp_add_person
    @name nvarchar(max),
    @mail nvarchar(max),
    @nationalID nvarchar(max),
    @address nvarchar(max),
    @gender char(1),
    @salary decimal(18, 2),
    @date_of_birth date,
    @phone nvarchar(max),
    @role nvarchar(30),
    @password nvarchar(255),
    @deptID int = NULL,
    @intakeID int = NULL,
    @college nvarchar(255) = NULL,
    @hireDate date = NULL
WITH ENCRYPTION
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;

        -- Check if the department exists or is null
        IF EXISTS (SELECT 1 FROM Department WHERE ID = @deptID) OR @deptID IS NULL
        BEGIN
            -- Insert into Person table
            INSERT INTO [dbo].[Person]
                ([Name], [Email], [NID], [Address], [Gender], [Salary], [DOB], [Phone], [Role], [Password], [DeptID])
            VALUES
                (@name, @mail, @nationalID, @address, @gender, @salary, @date_of_birth, @phone, @role, @password, @deptID);

            -- Get the last inserted Person ID
            DECLARE @lastpersonID INT = SCOPE_IDENTITY();

            -- Handle Student role
            IF (@role = 'Student')
            BEGIN
                IF EXISTS (SELECT 1 FROM Intake WHERE ID = @intakeID) OR @intakeID IS NULL
                BEGIN
                    INSERT INTO Student (StdID, IntakeID, College)
                    VALUES (@lastpersonID, @intakeID, @college);
                    PRINT 'Person inserted as a student successfully';
                END
                ELSE
                BEGIN
                    PRINT 'There is no intake with the specified intake ID';
                END
            END
            -- Handle Instructor role
            ELSE IF (@role = 'Instructor')
            BEGIN
                INSERT INTO Instructor (InsID, HireDate)
                VALUES (@lastpersonID, @hireDate);
                PRINT 'Person inserted as an instructor successfully';
            END
			else 
			  PRINT 'Person inserted as an admin successfully';
            COMMIT TRANSACTION;
        END
        ELSE
        BEGIN
            PRINT 'The department ID you provided is not found.';
        END
    END TRY
    BEGIN CATCH
        -- Handle errors and roll back transaction
        PRINT 'The data is invalid';
        ROLLBACK TRANSACTION;
    END CATCH
END;
EXEC sp_add_person 
    @name = 'nada',
    @mail = 'nada.doe@example.com',
    @nationalID = '12345678910325',
    @address = '123 Main Street',
    @gender = 'F',
    @salary = 55000.00,
    @date_of_birth = '1990-05-10',
    @phone = '555-1234',
    @role = 'admin',
    @password = 'securepassword123',
    @deptID = 3    ,
	@hireDate='1990-05-10';
-------------------------------------------------------------------------------------------------
CREATE OR ALTER PROCEDURE sp_get_all_students
WITH ENCRYPTION
AS
BEGIN
    SELECT 
        p.*, 
        s.IntakeID, 
        s.College
    FROM 
        Person p
    INNER JOIN 
        Student s 
    ON 
        p.ID = s.StdID;
END;
CREATE OR ALTER PROCEDURE sp_get_all_instructors
WITH ENCRYPTION
AS
BEGIN
    SELECT 
        p.*, 
        I.Hiredate
    FROM 
        Person p
    INNER JOIN 
        Instructor I
    ON 
        p.ID = I.InsID;
END;
exec  sp_get_all_instructors
--------------------------------------------------------------------------------------
CREATE OR ALTER PROCEDURE sp_get_student_byID
@stdID int =null
WITH ENCRYPTION
AS
BEGIN 
 IF @stdID is null
           print 'student ID should not be null OR EMPTY'
 ELSE IF EXISTS (SELECT * FROM student WHERE StdID = @stdID)
 begin
    SELECT 
        p.*, 
        s.IntakeID, 
        s.College
    FROM 
        Person p
    INNER JOIN 
        Student s 
    ON 
        p.ID = s.StdID and s.StdID=@stdID;
 end 
 else 
   print 'the student does not exist in the student table '
END;
exec sp_get_student_byID null
-------------------------------------------------------------------------------
CREATE OR ALTER PROCEDURE sp_get_instructor_byID
@insID int =null
WITH ENCRYPTION
AS
BEGIN 
 IF @insID is null
           print 'instructor ID should not be null OR EMPTY'
 ELSE IF EXISTS (SELECT * FROM Instructor WHERE InsID = @insID)
 begin
    SELECT 
        p.*, 
        I.Hiredate
    FROM 
        Person p
    INNER JOIN 
        Instructor I 
    ON 
        p.ID = I.InsID and I.InsID=@insID;
 end 
 else 
   print 'the instructor does not exist in the instructor table '
END;
exec sp_get_instructor_byID 12
---------------------------------------------------------------
CREATE OR ALTER PROCEDURE sp_get_all_persons
WITH ENCRYPTION
AS
BEGIN
    SELECT 
        *
    FROM 
        Person 
END;
exec sp_get_all_persons
----------------------------------------------------------------------
CREATE OR ALTER PROCEDURE sp_get_person_role
@personID int 
WITH ENCRYPTION
AS
BEGIN
    IF @personID is null
           print 'person ID should not be null OR EMPTY'
 ELSE IF EXISTS (SELECT * FROM Person WHERE ID = @personID)
 begin
    SELECT 
        name,role
    FROM 
        Person where ID=@personID;
 end 
 else 
   print 'the person does not exist in the person table '
END;
exec sp_get_person_role 1 
-----------------------------------------------------------
CREATE OR ALTER PROCEDURE sp_delete_person
@personID int = null
WITH ENCRYPTION
AS
BEGIN 
 IF @personID is null
           print 'person ID should not be null OR EMPTY'
 ELSE IF EXISTS (SELECT * FROM Person WHERE id = @personID)
 begin
    delete 
    FROM 
        Person  
    where 
        ID=@personID;
 end 
 else 
   print 'the person you want to delete does not exist in the person table'
END;
exec sp_delete_person 10