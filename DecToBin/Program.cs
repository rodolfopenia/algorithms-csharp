// See https://aka.ms/new-console-template for more information
int number;
int residue;
string binaryNumber = "";
Console.WriteLine("Ingrese un número: ");
int.TryParse(Console.ReadLine(), out number);

while(number >= 2) {
  residue = number % 2;
  number = number / 2;

  if(number == 1) {
    binaryNumber = number.ToString() + residue.ToString() + binaryNumber;
  } else {
    binaryNumber = residue.ToString() + binaryNumber;
  }
}

Console.WriteLine($"El número binario es: {binaryNumber}");