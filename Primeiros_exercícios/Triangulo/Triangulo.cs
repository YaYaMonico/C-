usingSystem;
 namespace Course {
 class Triangulo{
 publicdoubleA;
 publicdoubleB;
 publicdoubleC;
 publicdoubleArea() {
 doublep = (A + B + C) / 2.0;
 returnMath.Sqrt(p * (p -A) * (p -B) * (p -C));
 }
 }
 }