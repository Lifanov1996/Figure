# Вычисление площади фигур
Библиотека, влючает static class Maths для вычесление площади фигур

Match.GetArea имее 3 перегрузки, для вычесление площади у разных фигур.

Чтобы избавиться от исключения ArgumentException все числа входных параметров проходят через метод Math.Abs()

**Класс**
[Maths](https://github.com/Lifanov1996/Figure/blob/main/AreaFigures/Maths.cs)

**Тесты:**

[Треугольник](https://github.com/Lifanov1996/Figure/blob/main/AreaFigure.Tests/MathsGetAreaTriangleTests.cs)

[Круг](https://github.com/Lifanov1996/Figure/blob/main/AreaFigure.Tests/MatshGetAreaCircleTests.cs)

[Не зная тип фигуры](https://github.com/Lifanov1996/Figure/blob/main/AreaFigure.Tests/MathsGetAreaTests.cs)


# База данных MS SQL

В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.
```
SELECT p.name [продукт], c.name [категория] 
FROM Products p
JOIN ProdCat pc ON p.id = pc.products_id
JOIN Category c ON c.id = pc.category_id
ORDER BY p.name;
```


