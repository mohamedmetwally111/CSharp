use iti;

-- 1 

insert into student
values(2112,'mohamed','metwally','Giza',20,30,null)

-- 2

insert into instructor(Ins_Id,Ins_Name,Salary,Dept_Id)
values(16,'Ahmed',4000,30)

-- 3 

update Instructor
set salary=salary+(salary*.02)

-------------------------------------------------------------------------------------------

use MyCompany

-- 4 

select *
from Employee

-- 5 

select fname,lname,salary,Dno
from Employee

-- 6 

select pname,plocation,Dnum
from project

-- 7
select fname+' '+lname as "full name" ,
(salary*12)*0.10 as "ANNUAL COMM"
from Employee

--8 

select SSN,fname+' '+lname as namee
from employee
where salary>1000

-- 9 

select SSN,fname+' '+lname as  namee
from employee
where Salary*12 >10000

-- 10 

select fname+' '+lname as namee,salary
from employee
where sex='F'

-------------------------------------------------------------------------------------------

use iti;

-- 11 

select *
from Student
where st_age is not null

-------------------------------------------------------------------------------------------

--bonus
--@@AnyExpression      any  exepression starting with @@ is a system variables
select @@VERSION     --display version of sql server
select @@SERVERNAME  --display name of sql server 

/*
                             self study report

 1: Research the difference between dec and dec(n1, n2) data types in SQL Server :
           Dec:
		   is an integer number without any decimal places 
		   Ex: Dec(10)    7387356983

		   Dec(n1,n2):
		   n1 =total number of digits(precision)
		   n2 =number  of digits after the decimal point (scales)
		   Ex: Dec(10,2)   28394643.57


2: Research built in stored procedures :
           Built-in stored procedures are ready-made tools in
		   SQL Server for managing databases, monitoring them, 
		   and retrieving information without the need to write custom querie

		   Ex: EXEC sp_helpdb-> Displays information about all databases on the server
		   EX: EXEC sp_rename 'OldTable', 'NewTable' -> Renames a table, column, or other object


3: Research sql injection :
           SQL Injection is an attack that exploits unprotected user input in SQL queries
           It allows attackers to access sensitive data or control the database
           Protection requires parameterized queries, input validation, and proper user permissions.

*/