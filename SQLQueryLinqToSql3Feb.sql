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

--Insert Employee
ALTER proc [dbo].[sp_InsertEmployee]
@empname varchar(20),
@esal float,
@deptId int
as
begin
Insert into EmployeeTab values(@empname, @esal,@deptId)
end

--Show Employee Details
ALTER proc [dbo].[sp_ShowEmpDetails]
@empid int
as
begin
select et.EmpName,et.Salary,et.DeptNo, dt.DeptName
from EmployeeTab et
join DeptTab dt
on et.DeptNo = dt.DeptId
where EmpId =@empid
end

--WithOutputParameter
ALTER proc [dbo].[sp_WithOutputParameter]
@empcnt int output
as 
begin
select @empcnt=count(empid)
from EmployeeTab
if(@empcnt is null)
print('Count is null')
else
print 'Count is not null'
end
