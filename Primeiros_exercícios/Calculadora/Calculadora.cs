namespace Course {
 class Calculadora {
 public static double Pi = 3.14;
 public static double Circunferencia(double r) {
 return 2.0 * Pi * r;
 }
 public static double Volume(double r) {
 return 4.0 / 3.0 * Pi * r * r * r;
 }
 }
 }

 Console.Write("Entre o valor do raio: ");
 doubleraio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
 doublecirc= Calculadora.Circunferencia(raio);
 doublevolume = Calculadora.Volume(raio);
 Console.WriteLine("Circunferência: "+ circ.ToString("F2", CultureInfo.InvariantCulture));
 Console.WriteLine("Volume: "+ volume.ToString("F2", CultureInfo.InvariantCulture));
 Console.WriteLine("Valor de PI: "+ Calculadora.Pi.ToString("F2", 
CultureInfo.InvariantCulture));