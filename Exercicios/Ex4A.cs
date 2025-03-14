using System;

namespace DesafioProdutos.Exercicios;

public class Ex4A
{
    //TODO Crie um ranking das 5 categorias com mais produtos em estoque
    public static void Exec()
    {
        var estoque = Program.produtos.GroupBy(prod => prod.Categoria)
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

        //RESPOSTA
        // 1º Lugar: Vidros - 4268 unidades
        // 2º Lugar: Farois - 4249 unidades
        // 3º Lugar: Retrovisores - 3948 unidades
        // 4º Lugar: Para-lamas - 3564 unidades
        // 5º Lugar: Lanternas - 3550 unidades
    }
}
