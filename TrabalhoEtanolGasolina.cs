using System;

class Program {
  public static void Main (string[] args) {

    int resp;
    
    do{
    Console.Write ("Insira valor etanol: R$");
      double eta1 = double.Parse(Console.ReadLine());
    Console.Write ("Insira valor etanol: R$");
      double gas1 = double.Parse(Console.ReadLine());
    
   double resultado = result(eta1, gas1);

  if(resultado>0.7){
  Console.WriteLine("Compensa Etanol.");
  }
    else if(resultado<0.7){
    Console.WriteLine("Compensa Gasolina.");}

      else{
      Console.WriteLine("Tanto faz");
      }
Console.WriteLine("Gostaria de fazer o cálculo novamente? Digite 1 para Sim e 2 para Não");
      resp = int.Parse(Console.ReadLine());
    } while(resp == 1);
    Console.WriteLine("Fim do programa");
  }
  
static double result(double eta1, double gas1){

double res1 = eta1 / gas1;
  return res1;
  
  }
}