--5
--e. Calculate the total number of contrats open currently.

--Select Count([ContractNo]) as ContractsStillOpen from [contract] 
--where convert(date, GETDATE()) < [EndDate] 

--Select [ContractNo], convert(date, GETDATE()) as currentDate, [EndDate] as EndDate  from [contract]
--where convert(date, GETDATE()) < [EndDate]   



--SELECT convert(date, GETDATE());

--Select [Client_Id], [EndDate], convert(date, GETDATE()) from [contract]

--SELECT [EndDate],,
--IF([EndDate] > convert(date, GETDATE()), "YES", "NO") from [contract]

--IF convert(date, GETDATE())  IN (select [EndDate] from [contract])
--       SELECT 'Still active';
--ELSE 
--       SELECT 'Inactive';

--IF ((select [EndDate] from [contract]) >= convert(date, GETDATE()))
--select 'hello'



--4
--d. Calculate the average contract value per client.
--SELECT [Client_Id], avg([Value]) as 'AVGContractValue' FROM contract
--group by [Client_Id]



--3
--c. Estimate the time remaining on a specific contract.
	--SELECT [ContractNo], DATEDIFF(MONTH, StartDate, EndDate ) as 'ContractLength' FROM contract
--where ContractNo = 1;


--SELECT [ContractNo], [StartDate],[EndDate] FROM [contract]


--2
--b. Calculate the average contract duration.
--SELECT sum(DATEDIFF(MONTH, StartDate, EndDate ))/COUNT (distinct ContractNo) as 'AvgContractLength' FROM contract 


--SELECT [ContractNo], DATEDIFF(MONTH, StartDate, EndDate ) as 'ContractLength' FROM contract
--group by ContractNo
--SELECT DATEDIFF(month, '2017/08/25', '2011/08/25') AS DateDiff;
--SELECT sum(DATEDIFF(MONTH, StartDate, EndDate )) FROM contract



--1
--Calculate the overall average number of contracts per client.
--SELECT Count(ContractNo)/COUNT (distinct Client_Id) as 'AverageNoOfContractsPerCustomer'
--FROM contract 

--SELECT Count(ContractNo) as 'AverageNoOfContractsPerCustomer'
--FROM contract 
--group by Client_Id

--group by Client_Id
--having Client_Id

--avg no of contracts per client