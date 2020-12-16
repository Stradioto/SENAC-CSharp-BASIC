using System;
using System.Collections.Generic;
using System.Linq;
			
public class Program
{
  public static void Main()
  {
    string comando,ataque;
    int hpPersonagem = 5,defPersonagem = 0,hpInimigo = 5,defInimigo = 0,atkPersonagem = 0,atkInimigo = 0,acaoInimigo;
    Random a = new Random();
    
    while (hpPersonagem > 0 && hpInimigo > 0) //Calculos da vida enquanto personagem|inimigo estiverem vivos
    {
    atkPersonagem = 0;
    atkInimigo = 0;
    defPersonagem = 0;
    defInimigo = 0;
    Console.WriteLine("Selecione entre a ou d:");
    comando = Console.ReadLine();
    
    if (comando == "a")
    {
    atkPersonagem = a.Next(0,3);
      Console.WriteLine("Atk:" +atkPersonagem);  
    }  
    if (comando == "d")
    {
    defPersonagem = a.Next(0,3);
      Console.WriteLine("Def:" +defPersonagem);
    }
    
    Console.WriteLine("Turno do inimigo:");
    acaoInimigo = a.Next(0,2);
    
    if (acaoInimigo == 1) 
    {
    atkInimigo = a.Next(0,3);
    Console.WriteLine("Atk:" +atkInimigo);
    }
    else
    {
    defInimigo = a.Next(0,3);
    Console.WriteLine("Def:" +defInimigo);
    }
    
    atkPersonagem = atkPersonagem - defInimigo;
    if (atkPersonagem > 0)
    {
    hpInimigo = hpInimigo - atkPersonagem;
   
    }
    if(atkInimigo > 0)
    {
    atkInimigo = atkInimigo - defPersonagem;
    hpPersonagem = hpPersonagem - atkInimigo;
    }
    Console.WriteLine("Seu HP: " + hpPersonagem +" HP do inimigo é: "+ hpInimigo);
    }
    if (hpPersonagem <= 0)
    {
    Console.WriteLine("Você morreu!");  
    }
    if (hpInimigo <= 0)
    {
    Console.WriteLine("Inimigo derrotado!");  
    }
  }
}