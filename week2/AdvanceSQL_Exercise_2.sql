use master
go

if DB_ID('AdvanceSQL_exercise4') is not null
begin
	alter database AdvanceSQL_exercise4 set single_user with rollback immediate;
	drop database AdvanceSQL_exercise4;
end

create database AdvanceSQL_exercise4;
go

use AdvanceSQL_exercise4;
go

-- Creating tables
--Creating Departments table
if not exists (
    select * from INFORMATION_SCHEMA.TABLES 
    where TABLE_NAME = 'Departments' and TABLE_SCHEMA = 'dbo'
)
begin
    create table Departments (
        DepartmentID int primary key,
        DepartmentName varchar(100)
    );
end;

--Creating Employees table
if not exists (
    select * from INFORMATION_SCHEMA.TABLES 
    where TABLE_NAME = 'Employees' and TABLE_SCHEMA = 'dbo'
)
begin
    create table Employees (
        EmployeeID int primary key,
        FirstName varchar(50),
        LastName varchar(50),
        DepartmentID int foreign key REFERENCES Departments(DepartmentID),
        Salary decimal(10,2),
        JoinDate date
    );
end;

--Inserting data into Departments
insert into Departments (DepartmentID, DepartmentName) values
(1, 'HR'),
(2, 'Finance'),
(3, 'IT'),
(4, 'Marketing');

-- Inserting date into Employees
insert into Employees (EmployeeID, FirstName, LastName, DepartmentID, Salary, JoinDate) values
(1, 'John', 'Doe', 1, 5000.00, '2020-01-15'),
(2, 'Jane', 'Smith', 2, 6000.00, '2019-03-22'),
(3, 'Michael', 'Johnson', 3, 7000.00, '2018-07-30'),
(4, 'Emily', 'Davis', 4, 5500.00, '2021-11-05');
go





-- Exersice 1: Create a stored procedure

create procedure sp_GetEmployeesByDepartment(@DeptID as INT) AS
BEGIN
    SELECT EmployeeID, FirstName, LastName, Salary, JoinDate
    FROM Employees
    WHERE DepartmentID = @DeptID;
END;
go

-- Executing it
execute sp_GetEmployeesByDepartment @DeptID = 3;
go


-- Creating stored procedure named sp_InsertEmployee
create procedure sp_InsertEmployee (
    @EmployeeID int,
    @FirstName varchar(50),
    @LastName varchar(50),
    @DepartmentID int,
    @Salary decimal(10,2),
    @JoinDate date
) as
begin
    insert into Employees (EmployeeID, FirstName, LastName, DepartmentID, Salary, JoinDate) values
    (@EmployeeID ,@FirstName, @LastName, @DepartmentID, @Salary, @JoinDate);
end;
go

-- executing it
execute sp_InsertEmployee 
    @EmployeeID = 5,
    @FirstName = 'Satyam',
    @LastName = 'Thakur',
    @DepartmentID = 3,
    @Salary = 120000.00,
    @JoinDate = '2023-08-08';
go

select * from Employees;




--Exercise 5: Return data from a stored Procedure

create procedure sp_CountEmployeesByDepartment
    @DeptID int
as
begin
    declare @Total INT;

    select @Total = COUNT(*)
    from Employees
    where DepartmentID = @DeptID;

    return @Total;
end;


declare @Result INT;

exec @Result = sp_CountEmployeesByDepartment @DeptID = 3;

print 'Total Employees in Department: ' + CAST(@Result as varchar);
go
