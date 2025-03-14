using System;

namespace DesafioProdutos.Exercicios;

public class Ex5
{
    //TODO Em relação aos fabricantes, quantos temos em nossa base? Crie um ranking dos 5 fabricantes com mais itens em estoque.
    public static void Exec()
    {
        Console.WriteLine("\n\nExercício 5: ");

        var totalFabricantes = Program.produtos.DistinctBy(prod => prod.Fabricante).Count();
        var estoque = Program.produtos.GroupBy(prod => prod.Fabricante)
        .Select(prod => new
        {
            nome = prod.Key,
            quant = prod.Select(p => p.Quantidade).Sum()
        })
        .OrderByDescending(prod => prod.quant)
        .Take(5);

        Console.WriteLine($"Temos {totalFabricantes} fabricantes cadastrados em nossa base.");

        int posicao = 1;
        foreach (var prod in estoque)
        {
            Console.WriteLine($"{posicao}º Lugar: {prod.nome} - {prod.quant} unidades");
            posicao++;
        }

        //RESPOSTA
        // Temos 19 fabricantes cadastrados em nossa base. 
        // 1º Lugar: Hella - 2712 unidades
        // 2º Lugar: Magna - 1888 unidades
        // 3º Lugar: Pilkington - 1788 unidades
        // 4º Lugar: Magneti Marelli - 1589 unidades
        // 5º Lugar: Thyssenkrupp - 1488 unidades
    }
}
