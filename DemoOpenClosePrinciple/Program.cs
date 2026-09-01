

using DemoOpenClosePrinciple;

AreaCalculator calculator = new AreaCalculator();

Circle circle1 = new Circle();
circle1.Radius = 2;

Circle circle2 = new Circle();
circle2.Radius = 3;

Circle circle3 = new Circle();
circle3.Radius = 4;


Square square1 = new Square();
square1.Size = 5;

Square square2 = new Square();
square2.Size = 4;

Square square3 = new Square();
square3.Size = 7;


Triangulo triangulo1 = new Triangulo();
triangulo1.Base = 5;
triangulo1.Altura = 2;

Triangulo triangulo2 = new Triangulo();
triangulo2.Base = 4;
triangulo2.Altura = 3;

Triangulo triangulo3= new Triangulo();
triangulo3.Base = 8;
triangulo3.Altura = 8;


//Nueva figura: Rectángulo
Rectangulo rectangulo1 = new Rectangulo();
rectangulo1.Base = 6;
rectangulo1.Altura = 4;

//Nueva figura: Trapecio
Trapecio trapecio1 = new Trapecio();
trapecio1.BaseMayor = 10;
trapecio1.BaseMenor = 6;
trapecio1.Altura = 4;


List<Shape> shapes = new List<Shape>();
shapes.Add(circle1);
shapes.Add(circle2);
shapes.Add(circle3);
shapes.Add(square1);
shapes.Add(square2);
shapes.Add(square3);
shapes.Add(triangulo1);
shapes.Add(triangulo2);
shapes.Add(triangulo3);
//Nuevas figuras
shapes.Add(rectangulo1);
shapes.Add(trapecio1);


var resultTotalArea = calculator.TotalArea(shapes);

Console.WriteLine($"El área total es {resultTotalArea}");