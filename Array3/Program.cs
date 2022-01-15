using static System.Console;

// Alterando nome de uma lista (arrays)

public class Program
{
    static void AlterarNome(string[] nomes, string nome, string nomeNovo)
    {   
        for(int i = 0; i < nomes.Length; i++)
        {
            if(nomes[i] == nome)
            {
                nomes[i] = nomeNovo;
            }
        }
    }
    static void Main()
    {
        var nomes = new string[]{"Pedro", "José", "Maria", "Júlio", "Pablo"};
        WriteLine($@"A lista de nomes é:
            {string.Join(", \n", nomes)}
            ");

        WriteLine("Qual nome você gosta de trocar?");
        var nome = ReadLine();
        WriteLine("Digite o nome novo:");
        var nomeNovo = ReadLine();

        AlterarNome(nomes, nome, nomeNovo);

        WriteLine($@"A lista de nomes alterada é:
            {string.Join(", \n", nomes)}
            ");
    }
}