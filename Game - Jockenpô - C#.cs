using System;
using System.Collections.Generic;
using System.Linq;
			
public class Program
{
  public static void Main()
  {
    
    string escolhaJogador;
    int escolhaIA,contIA,contJogador;
    
    contIA = 0;
    contJogador = 0;
    
    while (contIA != 3 || contJogador !=3)
    { 
    Random r = new Random();
    escolhaIA = r.Next(0,3);
    Console.WriteLine("Selecione entre pedra, papel e tesoura: ");
    escolhaJogador = Console.ReadLine();
    
    Console.WriteLine("Turno da IA: "); 
      switch (escolhaIA)
      {
          case 0:
              Console.WriteLine("pedra");
        			break;
          case 1:
              Console.WriteLine("papel");
              break;
          case 2:
              Console.WriteLine("tesoura");
        			break;
      }
    
    if (escolhaJogador == "papel" && escolhaIA == 0)
    {
    Console.WriteLine("Jogador vence o turno!");
    contJogador++;
    }
    if (escolhaJogador == "papel" && escolhaIA == 2)
    {
    Console.WriteLine("IA vence o turno!");
    contIA++;
    }
    if (escolhaJogador == "papel" && escolhaIA == 1)
    {
    Console.WriteLine("Empate!"); 
    }
      
     if (escolhaJogador == "pedra" && escolhaIA == 2)
    {
    Console.WriteLine("Jogador vence o turno!");
    contJogador++;
    }
    if (escolhaJogador == "pedra" && escolhaIA == 1)
    {
    Console.WriteLine("IA vence o turno!");
    contIA++;
    }
    if (escolhaJogador == "pedra" && escolhaIA == 0)
    {
    Console.WriteLine("Empate!");
    }
    
     if (escolhaJogador == "tesoura" && escolhaIA == 1)
    {
    Console.WriteLine("Jogador vence o turno!");
    contJogador++;
    }
    if (escolhaJogador == "tesoura" && escolhaIA == 0)
    {
    Console.WriteLine("IA vence o turno!");
    contIA++;
    }
    if (escolhaJogador == "tesoura" && escolhaIA == 2)
    {
    Console.WriteLine("Empate!");   
    }
    }
    }
  
}
