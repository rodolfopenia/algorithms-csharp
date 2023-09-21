string [] arrUnits = {"", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"};
string [] arrTens = {"", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC"};
string [] arrHundreds = {"", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM"};
string [] arrThousands = {"", "M", "MM", "MMM"};
int number;
int units;
int tens;
int hundreds;
int thousands;
string romanNumber = "";
Console.WriteLine("Ingrese un número: ");
int.TryParse(Console.ReadLine(), out number);
units = number % 10;
number = number / 10;
tens = number % 10;
number = number / 10;
hundreds = number % 10;
number = number / 10;
thousands = number % 10;
romanNumber = $"{arrThousands[thousands]}";
romanNumber = $"{romanNumber}{arrHundreds[hundreds]}";
romanNumber = $"{romanNumber}{arrTens[tens]}";
romanNumber = $"{romanNumber}{arrUnits[units]}";
Console.WriteLine($"El número en romano es: {romanNumber}");



