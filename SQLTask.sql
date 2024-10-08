DECLARE @Products TABLE(ID int, Name nvarchar(100))
DECLARE @Categories TABLE(ID int, Name nvarchar(100))
DECLARE @ProductsCategories TABLE(ProductID int, CategoryID int)

INSERT INTO @Products VALUES
	(0, 'Apple')
   ,(1, 'Bread')
   ,(2, 'Book')

INSERT INTO @Categories VALUES
	(0, 'Fruits')
   ,(1, 'Bakery')

INSERT INTO @ProductsCategories VALUES
	(0, 0)
   ,(1, 1)

SELECT p.Name [Имя продукта], c.Name [Имя категории]
FROM @Products p
LEFT JOIN @ProductsCategories pc ON pc.ProductID = p.ID
LEFT JOIN @Categories c ON c.ID = pc.CategoryID