Console.Clear();
// Vetores: declaração, atribuição e acesso
Console.WriteLine("--Vetores: declaração, atribuição e acesso");
int[] numeros = new int[4];
numeros[0] = 8;
numeros[1] = 3;
numeros[2] = 0;
numeros[3] = -8;

int soma = numeros[0] + numeros[1] +
           numeros[2] + numeros[3];

Console.WriteLine($"Soma: {soma}");

// Inicialização
/*
string[] linguagens = new string[4];
linguagens[0] = "C#";
linguagens[1] = "Python";
linguagens[2] = "Java";
linguagens[3] = "Javascript";
string[] linguagens1 = ["C#", "Python", "Java", "Javascript"];
string[] linguagens2 = new string [] { "C#", "Python", "Java", "Javascript" };
*/

string[] linguagens = { "C#", "Python", "Java", "Javascript" };

Console.WriteLine($"\nLinguagem utilizada: {linguagens[0]}");

// Tamanho de um array
Console.WriteLine($"Nosso array de números possui {numeros.Length} valores");
Console.WriteLine($"Nosso array de nomes possui {linguagens.Length} valores");

// Percorrendo matrizes com laços usando while
int contador = 0;
while (contador < numeros.Length)
{
    Console.WriteLine($"numeros[{contador}] = {numeros[contador]}");
    contador++;
}

contador = 0;
Console.Write("\nNúmeros: | ");
while (contador < numeros.Length)
{
    Console.Write($"{contador + 1}. {numeros[contador]} | ");
    contador++;
}

// Percorrendo matrizes com laços usando for
Console.WriteLine($"\n\n--Linguagens (for)");
for (int i = 0; i < linguagens.Length; i++)
{
    Console.WriteLine($"A {i + 1}ª linguagem é {linguagens[i]}");
}

// Percorrendo matrizes com laços usando for, reverso
Console.WriteLine($"\n\n--Linguagens (for, reverso)");
for (int i = linguagens.Length - 1; i >= 0; i--)
{
    Console.WriteLine($"A {i + 1}ª linguagem é {linguagens[i]}");
}

// Percorrendo matrizes com laços usando foreach
Console.WriteLine("\n--Percorrendo matrizes com laços usando foreach");
foreach (string linguagem in linguagens)
{
    Console.Write($"{linguagem} ");
}

// Matrizes: arrays multidimensionais
Console.WriteLine("\n\n--Matrizes: arrays multidimensionais");
int[,] a2 = new int[3, 4];
a2[0, 3] = 3;

int[,] m2 = {
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 },
                { 9, 10, 11, 12 },
            };

int itemDesejado = m2[1, 2];
Console.WriteLine($"m2[1, 2] = {itemDesejado}");

// Informações sobre uma matriz
Console.WriteLine("\n\n-- Informações sobre uma matriz");
Console.WriteLine($"Tamanho: {m2.Length}");
Console.WriteLine($"Número de dimensões: {m2.Rank}");
Console.WriteLine($"Limite inferior da primeira dimensão (0): {m2.GetLowerBound(0)}");
Console.WriteLine($"Limite superior da primeira dimensão (0): {m2.GetUpperBound(0)}");
Console.WriteLine($"Limite inferior da segunda dimensão (1): {m2.GetLowerBound(1)}");
Console.WriteLine($"Limite superior da segunda dimensão (1): {m2.GetUpperBound(1)}");

// Percorrendo uma matriz com for
Console.WriteLine("\n\n--Percorrendo uma matriz com for");
for (int i = m2.GetLowerBound(0); i <= m2.GetUpperBound(0); i++)
{
    for (int j = m2.GetLowerBound(1); j <= m2.GetUpperBound(1); j++)
    {
        Console.WriteLine($"m2[{i}, {j}] = {m2[i, j]}");
    }
}
// Percorrendo uma matriz com foreach
Console.WriteLine("\n\n--Percorrendo uma matriz com foreach");
foreach (int item in m2)
{
    Console.Write($"{item} ");
}

// Matrizes irregulares
Console.WriteLine("\n\nMatrizes irregulares");

Console.WriteLine("Selecione um filme: ");
Console.WriteLine("1. Matrix");
Console.WriteLine("2. Senhor dos anéis");
Console.WriteLine("3. Titanic");

int selecao;
while (!int.TryParse(Console.ReadLine(), out selecao))
{
    Console.WriteLine("Informe um número!");
}

string[] filmes =
{
    "Matrix",
    "Senhor dos Anéis",
    "Titanic"
};

Console.Write($"Filme: {filmes[selecao-1]} ");

string[][] generoDosFilmes =
[
    ["Ação", "Ficção Científica" ],
    ["Fantasia"],
    ["Romance", "Baseado em fatos reais"]
];

// Percorrendo uma matriz irregular com for
Console.WriteLine($", gênero(s): ");
string[] generoDoFilmeSelecionado = generoDosFilmes[selecao - 1];
for (int i = 0; i < generoDoFilmeSelecionado.Length; i++)
{
    Console.Write($"{generoDoFilmeSelecionado[i]}, ");
}

// Percorrendo uma matriz irregular com foreach
Console.WriteLine("\n\n--Percorrendo uma matriz irregular com foreach");
foreach (string[] generosDoFilme in generoDosFilmes)
{
    foreach (string generoDoFilme in generosDoFilme)
    {
        Console.WriteLine(generoDoFilme);
    }
}
// Alterando um vetor "in-place"
// Aplicação: entrada de itens em uma lista
// Aplicação: guardar muitos valores
// Aplicação: sorteando valores em uma lista