SELECT MenuItem.ime
FROM Orders_FoodItems INNER JOIN MenuItem ON Orders_FoodItems.MenuItem=MenuItem.menu_item_id
WHERE Orders_FoodItems.masiId=14;