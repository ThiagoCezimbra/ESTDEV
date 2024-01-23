using System;
//* soma de 1 a número (função com laço de repetição)
class Program
{
    public static void Main(string[] args)
    {
      Console.Write("Digite o número: ");
      int num = int.Parse(Console.ReadLine());
      int soma = contadoresoma(num);
    Console.WriteLine(soma);
    
  }
static int contadoresoma(int n){
if (n<=0){
  return  0;
}
  int soma = 1;
for (int ct=2; ct<=n; ct++){
soma = soma + ct;
}
return soma;
}
  
  /* vai rolar um cont++ (contador)
  somar 1+2+3+4+5
  
/*static double retorno(double num1, double num2){

double m; 
  if (num1 >= num2) {

m = num1;
    
  }

  else {

m = num2;
  }
return m;
  
}
  
  /*
static int Funcaosoma(int num1, int num2){

  int num3 = num1 + num2;
  return num3;}
  /*
  static void Funcdevolv(string nomef){

    Console.WriteLine("Olá, "+ nomef);
  }*/

  
}
 