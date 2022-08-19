// Здесь координаты точки 1 соответствуют points[0] и points[1]
// Координаты точки 2 соответствуют points[2] и points[3]
// Координаты точки 3 соответствуют points[4] и points[5]
// Координаты точки 4 соответствуют points[6] и points[7]

void ScaleFigure()
{
int[] points = {0, 0, 2, 0, 2, 2, 0, 2};
double k = 0.5;
int n = points.Length;  
Console.Write($"Отмасштабированные координаты точки фигуры: ");  
for (int i = 1; i < n; i++)
{
    double scalePoint = k * points[i];    
    Console.Write($"{scalePoint} ");
}
Console.WriteLine();
}

ScaleFigure();