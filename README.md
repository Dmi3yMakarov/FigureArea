# FigureArea

Вычисляет площадь круга по радиусу и треугольника по трем сторонам.
Дополнительно реализовано:
- Юнит-тесты
- Легкость добавления других фигур
- Вычисление площади фигуры без знания типа фигуры в compile-time
- Проверку на то, является ли треугольник прямоугольным


# Задача на знание SQL
В базе данных MS SQL Server есть продукты и категории. 
Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. 
Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». 
Если у продукта нет категорий, то его имя все равно должно выводиться.

таблица товаров
CREATE TABLE products(
id INT PRIMARY KEY IDENTITY, 
name VARCHAR(255) NOT NULL);

таблица категорий товаров

CREATE TABLE categories(
id INT PRIMARY KEY IDENTITY,
name VARCHAR(255) NOT NULL);

отношение многие ко многим

CREATE TABLE prod_cat(
id INT PRIMARY KEY IDENTITY,
product_id INT NOT NULL,
category_id INT NOT NULL,
FOREIGN KEY(product_id) REFERENCES products(id) ON DELETE CASCADE,
FOREIGN KEY(category_id) REFERENCES categories(id) ON DELETE CASCADE);

заполняем некоторыми данными таблицу

INSERT INTO products VALUES('Сыр'), ('Молоко'), ('Тарелка'), ('Шоколадный батончик');
INSERT INTO categories VALUES('Молочные продукты'), ('Посуда'), ('Продовольственные продукты'), ('Непродовольственные продукты');
INSERT INTO prod_cat VALUES(1, 1), (2, 1), (3, 2), (1, 3), (2, 3);

запрос решения задачи

SELECT p.name AS product, c.name AS categories FROM products AS p
LEFT JOIN prod_cat AS pc ON p.id = pc.product_id
LEFT JOIN categories AS c ON c.id = pc.category_id
ORDER BY product;
