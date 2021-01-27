-- Select
--select CategoryID, COUNT(*)  from Products  group by CategoryID having count(*) <10


--select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
--from Products inner join Categories
--on Products.CategoryID = Categories.CategoryID
--where Products.UnitPrice>10;

-- DTO -> Data Transformation object



select * from Products p left join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID = od.OrderID

select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID where o.CustomerID is null