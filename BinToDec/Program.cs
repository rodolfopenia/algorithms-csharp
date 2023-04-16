string? binaryNumber;
string digit;
int product;
int pow = 0;
int number = 0;
Console.WriteLine("Ingrese un número binario: ");
binaryNumber = Console.ReadLine();

for(int i = binaryNumber!.Length - 1; i >= 0; i--) {
  digit = binaryNumber[i].ToString();
  product = int.Parse(digit) * (int) Math.Pow(2,pow);
  number = number + product;
  pow++;
}

Console.WriteLine($"El número convertido a sistema decimal es: {number}");