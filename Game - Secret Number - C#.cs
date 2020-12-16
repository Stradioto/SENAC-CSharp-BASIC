using System;
using System.Collections.Generic;
using System.Linq;
			
public class Program
{
  public static void Main()
  { 
    
   
    int numerosecreto = 0;
    int numerojogador = 0;
    int i = 0;
    
    Random r = new Random();   
    numerosecreto = r.Next(1,10);
    
    Console.WriteLine("Selecione um numero de 1 a 10:");
    while (numerojogador != numerosecreto && i <= 2)
    
    {
    numerojogador = int.Parse(Console.ReadLine());
   
    if (numerojogador == numerosecreto)
    {
    Console.WriteLine("Correto!");
    }
    else
    Console.WriteLine("Errado!");
    i++;
    }
    
    
    Console.WriteLine("O numero secreto era: " + numerosecreto);
  }
}