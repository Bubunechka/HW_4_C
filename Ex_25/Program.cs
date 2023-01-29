// Задача 25: Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Не использовать Math.Pow() и аналоги!

class HelloWorld {

static double power3(double a, int b) {
  if (b < 0) {
    (a, b) = (1.0 / a, -b);
  }
  double res = 1.0;
  for (; b != 0; a *= a, b /= 2) {
    if (b % 2 != 0) { res *= a; }
  }
  return res;  
}

static void Main() {
    Console.WriteLine(power3(2, 4));
  }
}