use Chat

insert into tbCreateAccount values('akki','Akshay','Jain','7441','Male','Administrator')
insert into tbAddContact values('akki')
insert into tbContactList values('akki','Offline')
select * from tbOnlineUserMessage

drop table tbCreateAccount

Create Table tbCreateAccount(loginName Varchar(100) Not Null Primary Key,
firstName Varchar(100) Not Null,
lastName Varchar(100) Not Null,
[passwd] Varchar(100) Not Null,
gender Varchar(10) Not Null,
[type] Varchar(20) Not Null)

Drop Table tbCreateAccount

Create Table tbAddContact(loginName Varchar(100) Not Null Primary Key Foreign Key References tbCreateAccount(loginName))

Create Table tbContactList(loginName Varchar(100) Not Null Primary Key Foreign Key References tbCreateAccount(loginName),
userStatus Varchar(10) Not Null)

Create Table tbOfflineUserMessage(ToLoginName Varchar(100) Not Null Foreign Key References tbCreateAccount(loginName),
FromLoginName Varchar(100) Not Null Foreign Key References tbCreateAccount(loginName),
[Message] Varchar(1000) Null )

Create Table tbOnlineUserMessage(ToLoginName Varchar(100) Not Null Foreign Key References tbCreateAccount(loginName),
FromLoginName Varchar(100) Not Null Foreign Key References tbCreateAccount(loginName),
[Message] Varchar(1000) Null )

Create Table tbContactListChanged([status] Varchar(10) Null)

/*Create Trigger trgForContactListChanged
On tbContactList
For Insert, Update, Delete
As
Begin
Insert into tbContactListChanged Values('true')
End*/

