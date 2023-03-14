using System;

class Program{
  static int calculcarre(int val){
    return val*val;
  }
  static void Main(string[] args){
    int i;
    Console.WriteLine("Veuillez entré un entier .");
    i = Convert.ToInt32(Console.ReadLine());
    i = calculcarre(i);
    Console.WriteLine($"Le carré de i est : {i} .");
  }
}
