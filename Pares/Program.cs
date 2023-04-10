// See https://aka.ms/new-console-template for more information
int startNumber, endNumber;
Console.WriteLine("Ingrese el rango inicial: ");
int.TryParse(Console.ReadLine(), out startNumber);
Console.WriteLine("Ingrese el rango final: ");
int.TryParse(Console.ReadLine(), out endNumber);

for (int i = startNumber; i <= endNumber; i++) {
  if (i % 2 == 0) {
    Console.WriteLine($"El número {i} es par.");
  } else {
    Console.WriteLine($"El número {i} es impar.");
  }
}


