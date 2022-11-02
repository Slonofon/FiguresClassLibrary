SELECT Product.name, Category.Name
FROM Product 
LEFT JOIN ProdoctAndCategory
ON Product.id = ProductAndCategory.ProductId
LEFT JOIN Category
ON ProdoctAndCategory.CategoryId = Category.id