CREATE TABLE [dbo].[tbl_Student]

(

 [StudentId] INT NOT NULL PRIMARY KEY IDENTITY,

 [StudentName] NVARCHAR(50) NULL,

 [StudentGrade ] NVARCHAR(50) NULL,

 [StudentRollNo] NVARCHAR(50) NULL,

 [IsActive] BIT NULL,

 [CreatedDate] DATETIME NULL,

 [ModifiedDate] DATETIME NULL

)