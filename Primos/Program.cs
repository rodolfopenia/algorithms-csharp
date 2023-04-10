// See https://aka.ms/new-console-template for more information
int startNumber, endNumber;
int count = 0;
Console.WriteLine("Ingrese un rango inicial: ");
int.TryParse(Console.ReadLine(), out startNumber);
Console.WriteLine("Ingrese un rango final: ");
int.TryParse(Console.ReadLine(), out endNumber);

for(int i = startNumber; i <= endNumber; i++) {
  count = 0;
  for(int j = 1; j <= i; j++){
    if (i % j == 0) {
      count++;
    }
  }

  if (count == 2) {
    Console.WriteLine($"El número {i} es primo.");
  } else {
    Console.WriteLine($"El número {i} no es primo.");
  }
}



