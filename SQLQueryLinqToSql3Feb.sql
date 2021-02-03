--Update Employee
ALTER proc [dbo].[sp_UpdateEmp]
@empid int,
@empname varchar(20),
@esal float,
@deptId int
as
begin
update EmployeeTab set EmpName=@empname, Salary =@esal,DeptNo=@deptId
where EmpId=@empid
end

execute sp_UpdateEmp 40,'Rajat',213.3,12

--Insert Employee
ALTER proc [dbo].[sp_InsertEmployee]
@empname varchar(20),
@esal float,
@deptId int
as
begin
Insert into EmployeeTab values(@empname, @esal,@deptId)
end

execute sp_InsertEmployee 'Kishan',4342.56,10

select * from EmployeeTab