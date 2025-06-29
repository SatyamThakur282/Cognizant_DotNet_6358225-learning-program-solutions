use master
go


if DB_ID('AdvanceSQL_exercise1') is not null
begin
	alter database AdvanceSQL_exercise1 set single_user with rollback immediate;
	drop database AdvanceSQL_exercise1;
end

create database AdvanceSQL_exercise1;
go

use AdvanceSQL_exercise1;
go

-- Create a sample Products table
if not exists (
    select * from INFORMATION_SCHEMA.TABLES 
    where TABLE_NAME = 'Departments' and TABLE_SCHEMA = 'dbo'
)
begin
CREATE TABLE Products (
    ProductID INT,
    ProductName VARCHAR(100),
    Category VARCHAR(50),
    Price DECIMAL(10, 2)
);
end;

-- Insert sample data
INSERT INTO Products (ProductID, ProductName, Category, Price) VALUES
(1, 'Laptop', 'Electronics', 1200.00),
(2, 'Smartphone', 'Electronics', 800.00),
(3, 'Tablet', 'Electronics', 800.00),
(4, 'Monitor', 'Electronics', 300.00),
(5, 'Keyboard', 'Electronics', 100.00),
(6, 'Sofa', 'Furniture', 700.00),
(7, 'Chair', 'Furniture', 700.00),
(8, 'Table', 'Furniture', 500.00),
(9, 'Bookshelf', 'Furniture', 300.00),
(10, 'Desk', 'Furniture', 500.00);

select * from Products;

select * from (
    select * ,
    ROW_NUMBER() over(partition by Category order by Price desc) as rownumber
    from Products
) as Ranked
where rownumber <= 3;


select * from (
    select * ,
    RANK() over(partition by Category order by Price desc) as ranknumber
    from Products
) as Ranked
where ranknumber <=3;

select * from (
    select *,
    DENSE_RANK() over(partition by Category order by Price desc) as denseRankNumber
    from Products
) as DenseRank
where denseRankNumber <=3;



