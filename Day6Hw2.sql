select Products.ProductName as [Ürün Adı],
sum([Order Details].UnitPrice*[Order Details].Quantity) as [Kazanılan Toplam Miktar]
from Products
INNER JOIN [Order Details] ON Products.ProductID = [Order Details].ProductID
INNER JOIN Orders ON Orders.OrderID = [Order Details].OrderID
group by Products.ProductName 