-- Insert into Intake Table (Unchanged)
INSERT INTO Intake (Name, StartDate) VALUES
('Intake 2023', '2023-01-01'),
('Intake 2024', '2024-01-01');

-- Insert into Department Table (Unchanged)
INSERT INTO Department (Name, Describe) VALUES
('Computer Science', 'Department of Computer Science and Engineering'),
('Mathematics', 'Department of Mathematics and Statistics'),
('Physics', 'Department of Physics and Astronomy');

-- Insert into Person Table (Unchanged)
INSERT INTO Person (Name, Email, NID, Address, Gender, Salary, DOB, Phone, Role, Password, DeptID) VALUES
('John Doe', 'john@example.com', '12345678901234', '123 Main St', 'M', 50000.00, '1980-01-01', '123-456-7890', 'Admin', '123', 1),
('Jane Smith', 'jane@example.com', '23456789012345', '456 Elm St', 'F', 60000.00, '1985-05-15', '234-567-8901', 'Instructor', '321', 2),
('Alice Johnson', 'alice@example.com', '34567890123456', '789 Oak St', 'F', NULL, '2000-10-20', '345-678-9012', 'Student', '123', 1),
('Bob Brown', 'bob@example.com', '45678901234567', '101 Pine St', 'M', NULL, '2001-03-25', '456-789-0123', 'Student', '321', 2),
('Charlie Davis', 'charlie@example.com', '56789012345678', '202 Maple St', 'M', NULL, '2002-07-12', '567-890-1234', 'Student', '123', 3),
('Diana Evans', 'diana@example.com', '67890123456789', '303 Birch St', 'F', NULL, '2001-11-30', '678-901-2345', 'Student', '321', 1),
('Eve Green', 'eve@example.com', '78901234567890', '404 Cedar St', 'F', 70000.00, '1988-09-22', '789-012-3456', 'Instructor', '123', 3);

-- Insert into Student Table (Unchanged)
INSERT INTO Student (StdID, IntakeID, College) VALUES
(3, 1, 'College of Engineering'),
(4, 1, 'College of Science'),
(5, 1, 'College of Engineering'),
(6, 1, 'College of Science');

-- Insert into Instructor Table (Unchanged)
INSERT INTO Instructor (InsID, Hiredate) VALUES
(2, '2010-08-15'),
(7, '2015-03-10');

-- Insert into Course Table (Unchanged)
INSERT INTO Course (Name, Hours) VALUES
('Introduction to Programming', 30),
('Calculus I', 45),
('Physics for Engineers', 50),
('Data Structures', 40),
('Linear Algebra', 35);

-- Insert into Topic Table (Unchanged)
INSERT INTO Topic (Name, CrsID) VALUES
('Variables and Data Types', 1),
('Functions', 1),
('Limits and Continuity', 2),
('Kinematics', 3),
('Arrays', 4),
('Matrices', 5);

-- Insert into Std_Crs Table (Unchanged)
INSERT INTO Std_Crs (StdID, CrsID) VALUES
(3, 1), (3, 2), (3, 3),
(4, 2), (4, 3),
(5, 1), (5, 4),
(6, 3), (6, 5);

-- Insert into Ins_Crs Table (Unchanged)
INSERT INTO Ins_Crs (InsID, CrsID) VALUES
(2, 1), (2, 2),
(7, 3), (7, 4), (7, 5);

-- Insert into Exam Table (Unchanged)
INSERT INTO Exam (Name, StartDate, CrsID) VALUES
('Midterm Exam', '2023-06-15 09:00:00', 1),
('Final Exam', '2023-12-15 09:00:00', 1),
('Midterm Exam', '2023-06-20 09:00:00', 2),
('Final Exam', '2023-12-20 09:00:00', 2),
('Midterm Exam', '2023-06-25 09:00:00', 3); -- Fixed comment: Now correctly maps to CrsID=3 (Physics)

-- Insert into Student_Exam Table (Unchanged)
INSERT INTO Student_Exam (StdID, ExamID, Grade) VALUES
(3, 1, 4), (3, 2, 6),
(4, 3, 3), (4, 4, 3),
(5, 1, 0), (5, 5, 4),
(6, 5, 1);

-- Insert into Question Table (Fixed: Added missing questions for CrsID=3,4,5)
INSERT INTO Question (Body, Type, Degree, CorrectChoice, CrsID) VALUES
-- CrsID=1 (Intro to Programming)
('What is 2 + 2?', 'MCQ', 2, 4, 1),
('Is the Earth flat?', 'T/F', 1, 2, 1),
('What is the derivative of x^2?', 'MCQ', 3, 3, 1),
('Which of the following is a linear data structure?', 'MCQ', 2, 1, 1),
('What is the value of π (pi) to two decimal places?', 'MCQ', 1, 2, 1),
-- CrsID=2 (Calculus I)
('Is Python a compiled language?', 'T/F', 1, 2, 2),
('What is the time complexity of binary search?', 'MCQ', 3, 4, 2),
('What is the capital of France?', 'MCQ', 1, 3, 2),
('Is the sun a star?', 'T/F', 1, 1, 2),
('What is the square root of 64?', 'MCQ', 1, 4, 2),
-- CrsID=3 (Physics for Engineers) - NEW QUESTIONS
('Newton’s First Law applies to objects at rest.', 'T/F', 1, 1, 3),
('Energy is conserved in a closed system.', 'T/F', 1, 1, 3),
-- CrsID=4 (Data Structures) - NEW QUESTIONS
('A linked list uses:', 'MCQ', 2, 1, 4),
('Bubble sort has a worst-case time complexity of:', 'MCQ', 3, 3, 4),
-- CrsID=5 (Linear Algebra) - NEW QUESTIONS
('A vector space is defined by:', 'MCQ', 2, 1, 5),
('Eigenvalues are associated with:', 'MCQ', 3, 2, 5);

-- Insert into Choice Table (Fixed: Added choices for new questions)
INSERT INTO Choice (QID, Choice, Body) VALUES
-- Existing choices for Q1-Q10 (unchanged)
(1, 1, '3'), (1, 2, '5'), (1, 3, '6'), (1, 4, '4'),
(2, 1, 'True'), (2, 2, 'False'),
(3, 1, 'x'), (3, 2, '2x²'), (3, 3, '2x'), (3, 4, 'x³'),
(4, 1, 'Array'), (4, 2, 'Tree'), (4, 3, 'Graph'), (4, 4, 'Hash Table'),
(5, 1, '3.1416'), (5, 2, '3.14'), (5, 3, '22/7'), (5, 4, '3.1429'),
(6, 1, 'True'), (6, 2, 'False'),
(7, 1, 'O(n)'), (7, 2, 'O(n²)'), (7, 3, 'O(1)'), (7, 4, 'O(log n)'),
(8, 1, 'London'), (8, 2, 'Berlin'), (8, 3, 'Paris'), (8, 4, 'Madrid'),
(9, 1, 'True'), (9, 2, 'False'),
(10, 1, '6'), (10, 2, '7'), (10, 3, '7.5'), (10, 4, '8'),
-- New choices for Q11-Q16
(11, 1, 'True'), (11, 2, 'False'), -- Q11 (Physics)
(12, 1, 'True'), (12, 2, 'False'), -- Q12 (Physics)
(13, 1, 'Nodes and pointers'), (13, 2, 'Contiguous memory'), (13, 3, 'Key-value pairs'), (13, 4, 'Binary trees'), -- Q13 (Data Structures)
(14, 1, 'O(n)'), (14, 2, 'O(n log n)'), (14, 3, 'O(n²)'), (14, 4, 'O(1)'), -- Q14 (Data Structures)
(15, 1, 'Closure under addition/scalar multiplication'), (15, 2, 'Matrix determinants'), (15, 3, 'Polynomial roots'), (15, 4, 'Geometric transformations'), -- Q15 (Linear Algebra)
(16, 1, 'Scalar multipliers'), (16, 2, 'Vector directions'), (16, 3, 'Matrix traces'), (16, 4, 'Differential equations'); -- Q16 (Linear Algebra)

-- Insert into Answer_Exam Table (Fixed: Questions now match their courses)
INSERT INTO Answer_Exam (ExamID, QID, StdID, Answer) VALUES
-- Exams for Course 1 (CrsID=1)
(1, 1, 3, 1), (1, 2, 3, 2), (1, 3, 3, 3), -- Valid QIDs 1-3
(2, 1, 3, 4), (2, 2, 3, 2), (2, 3, 3, 3), -- Valid QIDs 1-3
-- Exams for Course 2 (CrsID=2)
(3, 6, 4, 2), (3, 7, 4, 4), -- Valid QIDs 6-10 (now Q6, Q7)
(4, 8, 4, 3), (4, 9, 4, 1), -- Valid QIDs 8, 9
-- Exams for Course 3 (CrsID=3)
(5, 11, 5, 1), (5, 12, 5, 1), -- Valid QIDs 11-12
(5, 11, 6, 1), (5, 12, 6, 1); 