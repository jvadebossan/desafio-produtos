using System;

namespace DesafioProdutos.Exercicios;

public class Ex5
{
    //TODO Em relação aos fabricantes, quantos temos em nossa base? Crie um ranking dos 5 fabricantes com mais itens em estoque.
    public static void Exec()
    {
        var totalFabricantes = Program.produtos.DistinctBy(prod => prod.Fabricante).Count();
        Console.WriteLine("");
        var estoque = Program.produtos.GroupBy(prod => prod.Fabricante)
        .Select(prod => new
        {
            nome = prod.Key,
            quant = prod.Select(p => p.Quantidade).Sum()
        })
        .OrderByDescending(prod => prod.quant)
        .Take(5);

        Console.WriteLine($"Temos {totalFabricantes} fabricantes cadastrados em nossa base. ");

        int posicao = 1;
        foreach (var prod in estoque)
        {
            Console.WriteLine($"{posicao}º Lugar: {prod.nome} - {prod.quant} unidades");
            posicao++;
        }
        // Temos 10 fabricantes cadastrados em nossa base. 
        // 1º Lugar: Para-choque Traseiro Volkswagen Polo - 243 unidades
        // 2º Lugar: Lanterna Dianteira Chevrolet Onix - 238 unidades
        // 3º Lugar: Farol de Neblina Chevrolet S10 - 236 unidades
        // 4º Lugar: Para-lama Dianteiro Fiat Strada - 233 unidades
        // 5º Lugar: Farol de Neblina Volkswagen Polo - 227 unidades
    }
}
