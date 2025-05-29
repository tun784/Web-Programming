go
CREATE DATABASE QLBANHOA
go
USE QLBANHOA
go
CREATE TABLE CUSTOMERS(
Id int PRIMARY KEY,
Name varchar(255),
Address varchar(255),
Phone varchar(20),
);

CREATE TABLE SUPPLIERS(
SupplierID int PRIMARY KEY,
SupplierName varchar(255),
AddressSupplier varchar(255),
PhoneNumber varchar(20));

CREATE TABLE PRODUCTS(
ProductID int PRIMARY KEY,
ProductName varchar(255),
Price float,
StockQuantity int,
ImageURL varchar(255),
SupplierID int FOREIGN KEY REFERENCES Suppliers(SupplierID));

CREATE TABLE ORDERS(
OrderID int PRIMARY KEY,
Id int FOREIGN KEY REFERENCES CUSTOMERS(Id),
OrderDate DateTime,
DeliveryAddress varchar(255),
TotalPrice float);

CREATE TABLE ORDERDETAIL(
OrderDetailsID int PRIMARY KEY,
OrderID int FOREIGN KEY REFERENCES ORDERS(OrderID),
ProductID int FOREIGN KEY REFERENCES PRODUCTS(ProductID),
Quantity int,
UnitPrice float);

-- Insert data into CUSTOMERS
INSERT INTO CUSTOMERS (Id, Name, Address, Phone) VALUES
(1, 'Nguyen Van A', '123 Le Loi, Q1, TP.HCM', '0909123456'),
(2, 'Tran Thi B', '456 Nguyen Trai, Q5, TP.HCM', '0911223344'),
(3, 'Le Van C', '789 Cach Mang Thang 8, Q10, TP.HCM', '0988776655');

-- Insert data into SUPPLIERS
INSERT INTO SUPPLIERS (SupplierID, SupplierName, AddressSupplier, PhoneNumber) VALUES
(1, 'Hoa Tuoi ABC', '12 Tran Hung Dao, Ha Noi', '0933445566'),
(2, 'Hoa Tuoi XYZ', '34 Phan Dang Luu, Da Nang', '0944556677');

-- Insert data into PRODUCTS
INSERT INTO PRODUCTS (ProductID, ProductName, Price, StockQuantity, ImageURL, SupplierID) VALUES
(1, 'Hoa Hong Đo', 50000, 100, 'hong_do.jpg', 1),
(2, 'Hoa Lan Tim', 120000, 50, 'lan_tim.jpg', 1),
(3, 'Hoa Cuc Trang', 30000, 200, 'cuc_trang.jpg', 2),
(4, 'Hoa Hong Trang', 300000, 23, 'rose_white.jpg', 2),
(5, 'Hoa Cam Tu Cau', 450000, 43, 'hydrangea.jpg', 1),
(6, 'Hoa Huong Duong', 280000, 29, 'sunflower.jpg', 1),
(7, 'Hoa Cuc Trang', 250000, 32, 'white_daisy.jpg', 1),
(8, 'Hoa Lan Ho Điep', 600000, 21, 'orchid.jpg', 2),
(9, 'Hoa Tulip', 400000, 30, 'tulip.jpg', 2);
-- Insert data into ORDERS
INSERT INTO ORDERS (OrderID, Id, OrderDate, DeliveryAddress, TotalPrice) VALUES
(1, 1, '2024-05-10', '123 Le Loi, Q1, TP.HCM', 150000),
(2, 2, '2024-05-11', '456 Nguyen Trai, Q5, TP.HCM', 60000);

-- Insert data into ORDERDETAIL
INSERT INTO ORDERDETAIL (OrderDetailsID, OrderID, ProductID, Quantity, UnitPrice) VALUES
(1, 1, 1, 2, 50000),
(2, 1, 3, 1, 30000),
(3, 2, 3, 2, 30000);