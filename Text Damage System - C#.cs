using System;
using System.Collections.Generic;
using System.Linq;
			
public class Program
{
  public static void Main()
  {
    int vidapersonagem = 100,numerodisparos,danoarma,resto,vidaperdida;
    
    Console.WriteLine("Você possui " + vidapersonagem + " de vida!");
    
    Console.WriteLine("Informe o dano da arma:");
    danoarma = int.Parse(Console.ReadLine());
    
    Console.WriteLine("Informe a quantidade de disparos: ");
    numerodisparos = int.Parse(Console.ReadLine());
   
    resto = vidapersonagem - danoarma * numerodisparos;
    vidaperdida = vidapersonagem - resto;
    
    if (resto >= 1)
  {
    Console.WriteLine(resto +"/100 "+ "você perdeu " + vidaperdida + " de vida");
      
  }   
  }
}
