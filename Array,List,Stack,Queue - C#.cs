using System;
using System.Collections.Generic;
using System.Linq;
			
public class Program
{
  public static void Main()
  {
    /*
    
    int[] n = new int[]{1,2,3,4,5,6,7,8,9};
    for (int i=n.Length-1;i>=0;i--)
    { 
    Console.WriteLine(n[i]);
    }        Descrecente */
    
    /*int[] n = new int[]{1,2,3,4,5,6,7,8,9};
    for (int i=0;i<n.Length;i++)
    { 
    Console.WriteLine(n[i]);
    }    */     
   
    /* List String
    
    List<string> listacompras = new List<string>();
    string item = Console.ReadLine();
    while(item!="fim")
    {
    listacompras.Add(item);
    item = Console.ReadLine();    
    }
    for (int i=0;i<listacompras.Count;i++)
    { 
    Console.WriteLine("Lista de compras:");
    Console.WriteLine(listacompras[i]);
    } */
    
    
    /* Stack<int> pilha = new Stack <int>();
    int entrada = int.Parse(Console.ReadLine());
    while (entrada>0)
    {
     pilha.Push(entrada);
     entrada= int.Parse(Console.ReadLine());
    }
     while(pilha.Count > 0)
     {
      int desempilhado = pilha.Pop();
       Console.WriteLine(desempilhado);
     } */
    
    /*Queue<string> fila = new Queue<string>();
    string entrada = Console.ReadLine();
    while (entrada != "fim")
    {
      fila.Enqueue(entrada);
      entrada = Console.ReadLine();
    }
    while (fila.Count>0)
    {
      Console.WriteLine(fila.Dequeue());
    }*/
    
    }
}