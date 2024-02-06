using System;

class Program
{
    public static void Main(string[] args)
    {
       int contador = 0;

      Console.WriteLine("Informe o número: ");    
     int multiplicador = int.Parse(Console.ReadLine());

      
      for (contador = 0; contador < 11; contador ++){
        
        
int resultado = (contador * multiplicador);

        
          Console.WriteLine("{0}x{1}={2}", contador, multiplicador, resultado);    
        
      }
Console.WriteLine("Saiu do laço");

    }

  

}



