SELECT avg([Value]) as 'AVGContractValue' FROM contract
where [Client_Id] = 1

--SELECT [Client_Id], avg([Value]) as 'AVGContractValue' FROM contract
--group by [Client_Id]
