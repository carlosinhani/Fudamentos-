using System;

class Program {
 public static void Main (string[] args) {
   Console.Write("Digite seu nome:"); 
   string r1 = Console.ReadLine();
   Console.WriteLine($"O seu nome é {r1} e possui {ContarLetras(r1)} caracteres.");
   MostrarDados();
  }

  public static void MostrarDados() {
    Console.WriteLine("Estes são os dados:");
    Console.WriteLine("Rua Paulino Tondatti, 132");
    Console.WriteLine("Cândido Mota/SP");
    Console.WriteLine("CEP 19880-072");
  }
  public static int ContarLetras( string palavra = "Seu Nome" ) {
    return palavra.Length;
  }
}