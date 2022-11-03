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
