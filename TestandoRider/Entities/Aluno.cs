namespace TestandoRider.Entities;

public class Aluno(string nome)
{
    public string Nome { get; set; } = nome;

    public double Media(List<double> notas)
    {
        double total = 0.0;
        foreach (var x in notas)
        {
            total += x;
        }
        return total / notas.Count;
    }


    public string Resultado(double media)
    {
        return media switch
        {
            >= 6.0 and < 10.0 => "Aprovado",
            > 0.0 and < 6.0 => "Reprovado",
            _ => "Erro de valores digitados"
        };
    }
}