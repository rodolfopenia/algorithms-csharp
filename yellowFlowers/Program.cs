/*

*     * * *
* *   * *
* * * *
    * * * *
  * *   * *
* * *     *
   *
  *
  *
   *
     *
*/

int number = 5;

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("*********************");
Thread.Sleep(200);
Console.WriteLine("**FOR YU MAI LOF!!!!**");
Thread.Sleep(200);
Console.WriteLine("*********************");
Thread.Sleep(200);

Console.ForegroundColor = ConsoleColor.Yellow;

for(int i = 0; i < number; i++){
  for(int j = 0; j < i + 1; j++){
    Console.Write(" *");
  }

  for(int j = number; j > i + 1; j--){
    Console.Write("  ");
  }

  for(int j = number; j > i; j--){
    Console.Write(" *");
  }
  Console.WriteLine();
  Thread.Sleep(200);
}

for(int i = 0; i < number; i++){
  for(int j = number; j > i + 1; j--){
    Console.Write("  ");
  }

  for(int j = 0; j < i + 1; j++){
    Console.Write(" *");
  }

  for(int j = 0; j < i; j++){
    Console.Write("  ");
  }

  for(int j = number; j > i; j--){
    Console.Write(" *");
  }
  Console.WriteLine();
  Thread.Sleep(200);
}

// stem
Console.ForegroundColor = ConsoleColor.Green;
for(int i = 0; i < 6; i++){
  for(int j = 0; j < number - 2; j++){
    Console.Write("  ");
  }
  Console.Write(" *");
  if(i <= 0) number -= 1;
  if(i >= 3) number += 1;
  Console.WriteLine();
  Thread.Sleep(200);
}