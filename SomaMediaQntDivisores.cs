using System;

class Program {
  public static void Main (string[] args) {
    int esc = 0; 
    int soma = 0;
    int cont = 0;
    double div;
    while (esc >=0 && esc <= 9){
    Console.WriteLine ("Insira os números");
    esc = int.Parse(Console.ReadLine());
    cont ++;
      if (esc >=0 && esc <= 9){
    soma = soma + esc;}
      else {Console.WriteLine ("Número fora de padrão");}
      };
    div = (double) soma / cont;
    Console.WriteLine("soma {0}; média {1:N2}; qtd divisores {2}", soma, div, cont);
  }
}