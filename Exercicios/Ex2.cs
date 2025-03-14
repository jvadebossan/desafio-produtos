using System;

namespace DesafioProdutos.Exercicios;

public class Ex2
{
    //TODO: Quantos produtos com nomes diferentes há no estoque?
    public static void Exec()
    {
        Console.WriteLine("\n\nExercício 2: ");

        var quantProds = Program.produtos.DistinctBy(prod => prod.Nome)
        .Count();

        Console.WriteLine($"Temos {quantProds} produtos com nomes diferentes disponíveis em nosso catálogo.");

        //RESPOSTA: Temos 279 produtos com nomes diferentes disponíveis em nosso catálogo.
    }
}
