using System;
//Nesse código acho importante ressaltar algo que ouvi do professor durante está aula em específico, e fiquei de fato impactado.
/*Ao ser indagado por um aluno, sobre como utilizaria o código da busca binária na prática, o professor disse o seguinte:
Fulano, aí que está! Você usará busca binária no seu dia a dia, e chegará uma hora que sequer se dará conta de que está usando um algoritmo parecido com esse, visto que as linguagens já lhe dão um objeto para a busca. Mas aí eu lhe pergunto:
Quantos programadores sabem como funciona o objeto por debaixo dos panos? Quantos seriam capazes de refazer um algoritmo de busca binária na mão grande?

Resultado: Desde então estou tentando sintetizar a ideia desse algoritmo e o refazendo, para reproduzi-lo numa situação apocaliptica =O */

// código de busca binária - para busca binária o vetor precisa estar organizado em ordem crescente//
//calcular o logaritmo ajuda a saber quantidade máxima de voltas em uma busca binária

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Olá mundo");

        int valor = 49; //valor que quer encontrar a posição
        int inicio = 0; //posição inicial (trabalhe com ela (em referencia) se não quiser usar o zero)
        int fim = 9; //posição final (trabalhe com ela caso não use o 0)


        int[] elementos = new int[10] { 3, 4, 5, 7, 9, 10, 13, 40, 49, 50 }; //aqui o vetor

        int saporradevariavel = Buscabinaria(elementos, valor, inicio, fim); //chamando a função já declarando a variável "posição"


        Console.WriteLine("Retorno = " + saporradevariavel); //retorno





    }
//função busca binária. muita atenção aos parâmetros
    static int Buscabinaria(int[] elementos, int valor, int inicio, int fim)
    {

        int meio = inicio + ((fim - inicio) / 2);
        if (inicio > fim)
        {
            return -1;
        }
        if (valor == elementos[meio])
        {
            return meio;
        }

        else if (valor < elementos[meio])
        {
            return Buscabinaria(elementos, valor, inicio, meio - 1);
        }

        else
        {
            return Buscabinaria(elementos, valor, meio + 1, fim);
        }

    }
}













/*
int [] elementos = new int[] {39,29,49,40,22,25};

// código de busca linear//
int posicao = buscar(elementos, 39);

Console.WriteLine("meu pau " + posicao);
}
static int buscar(int[] elementos, int valor){

for(int i = 0; i < elementos.Length; i++){
if (elementos[i] == valor)
i++;
return i;
}
return -1;
}
}*/
