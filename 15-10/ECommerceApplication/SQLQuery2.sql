USE ECommerce;
GO

-- Inserting dummy data into Customers table
INSERT INTO Customers (Name, Email, Address)
VALUES 
('Pranaya', 'Pranaya@example.com', 'Some Street, Some City, Some State, 12345'),
('Priyanka', 'Priyanka@example.com', 'Other Street, Other City, Other State, 67890'),
('Ramesh', 'Ramesh@example.com', 'Another Street, Another City, Anothe rState, 13579');

-- Inserting dummy data into Products table
INSERT INTO Products (Name, Price, Quantity, Description)
VALUES 
('Laptop', 1200.00, 10, 'High-performance laptop suitable for gaming and professional work'),
('Smartphone', 800.00, 15, 'Latest model smartphone with high-resolution camera'),
('Headphones', 150.00, 30, 'Noise-cancelling headphones with over 20 hours of battery life');

-- Inserting dummy data into Orders table
INSERT INTO Orders (CustomerId, TotalAmount, OrderDate)
VALUES 
(1, 2400.00, GETDATE()),   -- Order Id = 1
(2, 800.00, GETDATE()),     -- Order Id = 2
(1, 300.00, GETDATE());     -- Order Id = 3

-- Inserting dummy data into OrderItems table
INSERT INTO OrderItems (OrderId, ProductId, Quantity, PriceAtOrder)
VALUES 
(1, 1, 2, 1200.00),    -- 2 laptops ordered by Customer 1
(2, 2, 1, 800.00),      -- 1 smartphone ordered by Customer 2
(3, 3, 2, 150.00);      -- 2 headphones ordered by Customer 1
GO

-- Inserting dummy data into Payments table
INSERT INTO Payments (OrderId, Amount, PaymentType, PaymentDate)
VALUES 
(1, 2400.00, 'CC', GETDATE()),   -- CC => Credit Card
(2, 800.00, 'DC', GETDATE()),     -- DC => Debit Card
(3, 300.00, 'COD', GETDATE());  -- COD => Cash On Delivery