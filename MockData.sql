-- Insert into Intake Table
INSERT INTO Intake (Name, StartDate) VALUES
('Intake 2023', '2023-01-01'),
('Intake 2024', '2024-01-01');

-- Insert into Department Table
INSERT INTO Department (Name, Describe) VALUES
('Computer Science', 'Department of Computer Science and Engineering'),
('Mathematics', 'Department of Mathematics and Statistics'),
('Physics', 'Department of Physics and Astronomy');

-- Insert into Person Table
INSERT INTO Person (Name, Email, NID, Address, Gender, Salary, DOB, Phone, Role, Password, DeptID) VALUES
('John Doe', 'john@example.com', '12345678901234', '123 Main St', 'M', 50000.00, '1980-01-01', '123-456-7890', 'Admin', '123', 1),
('Jane Smith', 'jane@example.com', '23456789012345', '456 Elm St', 'F', 60000.00, '1985-05-15', '234-567-8901', 'Instructor', '321', 2),
('Alice Johnson', 'alice@example.com', '34567890123456', '789 Oak St', 'F', NULL, '2000-10-20', '345-678-9012', 'Student', '123', 1),
('Bob Brown', 'bob@example.com', '45678901234567', '101 Pine St', 'M', NULL, '2001-03-25', '456-789-0123', 'Student', '321', 2),
('Charlie Davis', 'charlie@example.com', '56789012345678', '202 Maple St', 'M', NULL, '2002-07-12', '567-890-1234', 'Student', '123', 3),
('Diana Evans', 'diana@example.com', '67890123456789', '303 Birch St', 'F', NULL, '2001-11-30', '678-901-2345', 'Student', '321', 1),
('Eve Green', 'eve@example.com', '78901234567890', '404 Cedar St', 'F', 70000.00, '1988-09-22', '789-012-3456', 'Instructor', '123', 3);

-- Insert into Student Table
INSERT INTO Student (StdID, IntakeID, College) VALUES
(3, 1, 'College of Engineering'),
(4, 1, 'College of Science'),
(5, 1, 'College of Engineering'),
(6, 1, 'College of Science');

-- Insert into Instructor Table
INSERT INTO Instructor (InsID, Hiredate) VALUES
(2, '2010-08-15'),
(7, '2015-03-10');

-- Insert into Course Table
INSERT INTO Course (Name, Hours) VALUES
('Introduction to Programming', 30),
('Calculus I', 45),
('Physics for Engineers', 50),
('Data Structures', 40),
('Linear Algebra', 35);

-- Insert into Topic Table
INSERT INTO Topic (Name, CrsID) VALUES
('Variables and Data Types', 1),
('Functions', 1),
('Limits and Continuity', 2),
('Kinematics', 3),
('Arrays', 4),
('Matrices', 5);

-- Insert into Std_Crs Table
INSERT INTO Std_Crs (StdID, CrsID) VALUES
(3, 1), (3, 2), (3, 3),
(4, 2), (4, 3),
(5, 1), (5, 4),
(6, 3), (6, 5);

-- Insert into Ins_Crs Table
INSERT INTO Ins_Crs (InsID, CrsID) VALUES
(2, 1), (2, 2),
(7, 3), (7, 4), (7, 5);

-- Insert into Exam Table
INSERT INTO Exam (Name, StartDate, CrsID) VALUES
('Midterm Exam', '2023-06-15 09:00:00', 1),
('Final Exam', '2023-12-15 09:00:00', 1),
('Midterm Exam', '2023-06-20 09:00:00', 2),
('Final Exam', '2023-12-20 09:00:00', 2),
('Midterm Exam', '2023-06-25 09:00:00', 3);

-- Insert into Student_Exam Table
INSERT INTO Student_Exam (StdID, ExamID, Grade) VALUES
(3, 1, 85), (3, 2, 90),
(4, 3, 78), (4, 4, 88),
(5, 1, 92), (5, 5, 85),
(6, 5, 80);

-- Insert into Question Table
INSERT INTO Question (Body, Type, Degree, CorrectChoice) VALUES
('What is 2 + 2?', 'MCQ', 2, 4),
('Is the Earth flat?', 'T/F', 1, 2),
('What is the derivative of x^2?', 'MCQ', 3, 3),
('Which of the following is a linear data structure?', 'MCQ', 2, 1),
('What is the value of π (pi) to two decimal places?', 'MCQ', 1, 2),
('Is Python a compiled language?', 'T/F', 1, 2),
('What is the time complexity of binary search?', 'MCQ', 3, 4),
('What is the capital of France?', 'MCQ', 1, 3),
('Is the sun a star?', 'T/F', 1, 1),
('What is the square root of 64?', 'MCQ', 1, 4);

-- Insert into Choice Table
INSERT INTO Choice (QID, Choice) VALUES
(1, 1), (1, 2), (1, 3), (1, 4), -- Choices for Q1
(2, 1), (2, 2), -- Choices for Q2 (True/False)
(3, 1), (3, 2), (3, 3), (3, 4), -- Choices for Q3
(4, 1), (4, 2), (4, 3), (4, 4), -- Choices for Q4
(5, 1), (5, 2), (5, 3), (5, 4), -- Choices for Q5
(6, 1), (6, 2), -- Choices for Q6 (True/False)
(7, 1), (7, 2), (7, 3), (7, 4), -- Choices for Q7
(8, 1), (8, 2), (8, 3), (8, 4), -- Choices for Q8
(9, 1), (9, 2), -- Choices for Q9 (True/False)
(10, 1), (10, 2), (10, 3), (10, 4); -- Choices for Q10

-- Insert into Answer_Exam Table
INSERT INTO Answer_Exam (ExamID, QID, StdID, Answer) VALUES
(1, 1, 3, 1), (1, 2, 3, 2), (1, 3, 3, 3), -- Student 3 answers for Exam 1
(2, 1, 3, 4), (2, 2, 3, 2), (2, 3, 3, 3), -- Student 3 answers for Exam 2
(3, 4, 4, 1), (3, 5, 4, 2), -- Student 4 answers for Exam 3
(4, 4, 4, 1), (4, 5, 4, 2), -- Student 4 answers for Exam 4
(5, 6, 5, 2), (5, 7, 5, 4), -- Student 5 answers for Exam 5
(5, 6, 6, 2), (5, 7, 6, 3); -- Student 6 answers for Exam 5