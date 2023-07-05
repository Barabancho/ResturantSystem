SELECT Masi.capacity,Masi.taken,Orders.order_date FROM Masi JOIN Orders on Masi.masi_id = Orders.order_id;
SELECT * FROM Masi;
SELECT * FROM Orders;