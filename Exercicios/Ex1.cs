using System;

namespace DesafioProdutos.Exercicios;

public class Ex1
{
    //TODO: Qual é o produto mais caro do estoque?
    public static void Exec()
    {
        var prodMaisCaro = Program.produtos.MaxBy(prod => prod.Preco);

        Console.WriteLine($"O produto mais caro é o {prodMaisCaro.Nome}, custando {prodMaisCaro.Preco:c}.");

        //RESPOSTA: O produto mais caro é o Para-choque Dianteiro Ford Fiesta, custando R$ 2.492,45.
    }
}
