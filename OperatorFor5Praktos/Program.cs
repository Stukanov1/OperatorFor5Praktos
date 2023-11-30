
var anltFunc = Math.Pow(Math.PI, 4) / 90;
var sumFunc = 0.0;

for (int n = 1; n <= 12; n++)
{
    sumFunc += 1 / Math.Pow(n, 4);
};
Console.WriteLine($"Расчетная функция\t=\t{Math.Round(sumFunc, 3)}\n" +
                  $"Аналитическая функция\t=\t{Math.Round(anltFunc, 3)}");
Console.ReadKey();
