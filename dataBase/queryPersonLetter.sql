create procedure ShowTPL
as
select * from TblPersonLetter

create procedure ShowTPLbyId
@idLetter int
as
select * from TblPersonLetter where Id_Letter like @idLetter

create procedure SaveTPL
@nameLetter nvarchar(50),@dataRegistration date, @destination nvarchar(50), @sender nvarchar(50), @tags nvarchar(50), @contentLetter nvarchar(50)
as 
insert into TblPersonLetter (Name_Letter ,Data_registration ,Destination ,Sender, Tags, Content_Letter ) 
values(@nameLetter, @dataRegistration, @destination, @sender, @tags, @contentLetter)

create procedure UpdateTPL
@nameLetter nvarchar(50),@dataRegistration date, @destination nvarchar(50), @sender nvarchar(50), @tags nvarchar(50), @contentLetter nvarchar(50), @idLetter int
as 
update TblPersonLetter set Name_Letter=@nameLetter ,Data_registration=@dataRegistration ,Destination=@destination ,Sender=@sender, Tags=@tags, Content_Letter=@contentLetter 
where Id_Letter=@idLetter

create procedure DeleteTPL
@idLetter int
as 
delete TblPersonLetter where Id_Letter=@idLetter