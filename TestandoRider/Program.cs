// importações
using TestandoRider.Entities;

// Início Main
Console.WriteLine("<<<<<<<<<< Calculo de média >>>>>>>>>>");
Console.Write("Digite os dados do aluno: ");
var nome = Console.ReadLine() ?? string.Empty;
Console.Write("Digite a quantidade de avaliações: ");
var quantidade = int.Parse(Console.ReadLine() ?? string.Empty);
Console.WriteLine();

List<double> notas = [];

for (var i = 0; i < quantidade; i++)
{
    Console.Write($"Digite o valor da {i + 1}° Avaliação: ");
    notas.Add(double.Parse(Console.ReadLine() ?? throw new InvalidOperationException()));
}

var aluno = new Aluno(nome);
var media = aluno.Media(notas);
Console.WriteLine($"\nO aluno {aluno.Nome} obteve a média: {media:F2}");
Console.WriteLine($"Aluno foi : {aluno.Resultado(media)}");


