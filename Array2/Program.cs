using static System.Console;

// Criar uma Console application para encontrar um número inteiro em um array;

public class Program
{
    static int EncontrarNumero(int[] numeros, int numero)
    {
        for(int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] == numero)
             return i;
        }
             return -1;
    }
    public static void Main()
    {
        int[] numeros = new int[] {0,2,4,6,8};
        WriteLine($"Digite o número que gostaria de encontrar");
        var numero = int.Parse(ReadLine());
        var idxEncontrado = EncontrarNumero(numeros, numero);

        if(idxEncontrado >= 0)
        {
            WriteLine($"O número digitado está na posição {idxEncontrado}");
        }
        else
        {
            WriteLine("O número digitado não foi encontrado!");
        }        
    }
}
