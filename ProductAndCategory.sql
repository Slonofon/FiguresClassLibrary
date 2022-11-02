SELECT Product.name, Category.Name
FROM Product 
LEFT JOIN ProductAndCategory
ON Product.id = ProductAndCategory.ProductId
LEFT JOIN Category
ON ProductAndCategory.CategoryId = Category.id