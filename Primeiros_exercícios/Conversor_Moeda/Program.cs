 using System;
 using System.Globalization;
 namespace Course{
 class Program{
 static void Main(string[] args) {
 Console.Write("Qual é a cotação do dólar? ");
 doublecotacao= double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
 Console.Write("Quantos dólares você vai comprar? ");
 doublequantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
 doubleresult= ConversorDeMoeda.DolarParaReal(quantia, cotacao);
 Console.WriteLine("Valor a ser pago em reais = "+ result.ToString("F2", CultureInfo.InvariantCulture));
 }
 }
 }