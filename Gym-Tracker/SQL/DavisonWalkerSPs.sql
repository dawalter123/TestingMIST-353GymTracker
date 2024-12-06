


--Creating procedure for name input on the web app. 
use GymTrackerDB
go



create proc Customer_Name_Input
@First_Name nvarchar(225), @Last_Name nvarchar(225)
as 
begin 

insert into Customer
(First_Name, Last_Name)
values 
(@First_Name, @Last_Name)

end 

--Executing procedure

exec Customer_Name_Input 
@First_Name='John', @Last_Name='Matthews'
go 

--Creating procedure for email input on the web app. 
use GymTrackerDB
go

create proc Customer_Email_Input
    @Email NVARCHAR(255)
as
begin
   
    insert into Customer_Email (Email)
    values (@Email);
end;




--Executing procedure 

exec Customer_Email_Input @Email='josh.patrick@gmail.com'
go 
