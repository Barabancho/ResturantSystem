Select * from Orders;
CREATE Table Orders(
	id int IDENTITY,
	PRIMARY KEY(id),
	customerId int,
	FOREIGN KEY (customerId) references Customers(customer_id),
	masiId int,
	FOREIGN KEY (masiId) references Masi(masi_id),
	orderDate date,
	totalAmount decimal(10,2),
	pickUpDate date

);
DROP TABLE Orders;
ALTER TABLE Chefs DROP COLUMN order_id;
ALTER TABLE Chefs DROP COnSTRAINT FK__Chefs__order_id__4F7CD00D;
CREATE Table Orders_FoodItems (
	id int IDENTITY,
	PRIMARY KEY(id),
	foodItemId int,
	FOREIGN KEY (foodItemId) references FoodItem(food_item_id),
	ordersId int,
	FOREIGN KEY (ordersId) references Orders(id),
);