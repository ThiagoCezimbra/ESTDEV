using System;
//vetor
class Program
{
    public static void Main(string[] args)
    {


      int [] vetortabuada = new int[11];
        
      Console.WriteLine("Informe o número: ");    
     int multiplicador = int.Parse(Console.ReadLine());

      
      for (int contador = 0; contador < 10; contador ++){
        
    int x = contador * multiplicador;    
        
    vetortabuada[contador] = x;
        

        
          Console.WriteLine("{0}x{1}={2}", contador, multiplicador, x);    
        
      }

      Console.WriteLine(vetortabuada[5]);
Console.WriteLine("Saiu do laço");
      

    }



  /* 


  int [] nomevetor = new int {quantidade};

  

  
  */

}



