select m.Id , v.ManufacturerId , V.MemberId from Members m 
left join Vaccinations v 
on m.id =  v.MemberId
where v.MemberId is null

