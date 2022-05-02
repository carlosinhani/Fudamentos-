using System;

class Program {
 public static void Main (string[] args) {
   Console.Write("Digite seu nome:"); 
   string r1 = Console.ReadLine();
   Console.WriteLine($"O seu nome é {r1}.");
   MostrarDados();
  }

  public static void MostrarDados() {
    Console.WriteLine("Estes são os dados:");
    Console.WriteLine("Rua Paulino Tondatti, 132");
    Console.WriteLine("Cândido Mota/SP");
    Console.WriteLine("CEP 19880-072");
  }
}