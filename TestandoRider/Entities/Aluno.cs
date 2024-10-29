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
        if (media >= 6.0 && media < 10.0)
        {
            return "Aprovado";
        }
        if (media > 0.0 && media < 6.0)
        {
            return "Reprovado";
        }
        else
        {
            return "Erro de valores digitados";
        }
        
    }
}