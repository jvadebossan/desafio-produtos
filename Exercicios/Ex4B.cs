using System;

namespace DesafioProdutos.Exercicios;

public class Ex4B
{
    //TODO Crie um ranking dos 3 centros de distribuição com mais estoque. 
    public static void Exec()
    {
        Console.WriteLine("\n\nExercício 4 B: ");

        var estoque = Program.produtos.GroupBy(prod => prod.Empresa)
        .Select(prod => new
        {
            nome = prod.Key,
            quant = prod.Select(p => p.Quantidade).Sum()
        })
        .OrderByDescending(prod => prod.quant)
        .Take(3);

        int posicao = 1;
        foreach (var prod in estoque)
        {
            Console.WriteLine($"{posicao}º Lugar: {prod.nome} - {prod.quant} unidades");
            posicao++;
        }

        //RESPOSTA
        // 1º Lugar: Filial MG - 5449 unidades
        // 2º Lugar: Filial SP - 5442 unidades
        // 3º Lugar: Filial PR - 5222 unidades
        // 4º Lugar: Filial RJ - 4738 unidades
        // 5º Lugar: Filial RS - 4200 unidades
    }
}
