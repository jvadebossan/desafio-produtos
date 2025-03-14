using System;

namespace DesafioProdutos.Exercicios;

public class Ex4C
{
    //TODO Crie um ranking dos 5 produtos que mais possuem estoque.
    public static void Exec()
    {
        var estoque = Program.produtos.GroupBy(prod => prod.Nome)
        .Select(prod => new
        {
            nome = prod.Key,
            quant = prod.Select(p => p.Quantidade).Sum()
        })
        .OrderByDescending(prod => prod.quant)
        .Take(5);

        int posicao = 1;
        foreach (var prod in estoque)
        {
            Console.WriteLine($"{posicao}º Lugar: {prod.nome} - {prod.quant} unidades");
            posicao++;
        }
        // 1º Lugar: Para-choque Traseiro Volkswagen Polo - 243 unidades
        // 2º Lugar: Lanterna Dianteira Chevrolet Onix - 238 unidades
        // 3º Lugar: Farol de Neblina Chevrolet S10 - 236 unidades
        // 4º Lugar: Para-lama Dianteiro Fiat Strada - 233 unidades
        // 5º Lugar: Farol de Neblina Volkswagen Polo - 227 unidades
    }
}
