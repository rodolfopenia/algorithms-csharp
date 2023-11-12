double radio;
double area, girth;

Console.WriteLine("Ingrese un radio del círculo:");
radio = double.Parse(Console.ReadLine());

girth = 2 * radio * Math.PI;

area = Math.PI * Math.Pow(radio, 2);

girth = Math.Round(girth, 2);
area = Math.Round(area, 2);

Console.WriteLine($"La circunferencia del círculo es: {girth}");
Console.WriteLine($"El área del círculo es: {area}");
