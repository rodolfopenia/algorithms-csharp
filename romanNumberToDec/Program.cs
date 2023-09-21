int [] arrRomanValues = {1000, 500, 100, 50, 10, 5, 1};
string romanLetters = "MDCLXVI";
string? romanNumber;
int position;
int number = 0;
int lastValue = 0;

Console.WriteLine("Ingrese un número romano: ");
romanNumber = Console.ReadLine();

for(int i = 0; i < romanNumber!.Length; i++) {
  position = romanLetters.IndexOf(romanNumber[i]);
  number = number + arrRomanValues[position];

  if (arrRomanValues[position] > lastValue) {
    number = number - (2 * lastValue);
  }

  lastValue = arrRomanValues[position];
}

Console.WriteLine($"El número romano en decimal es: {number}");
