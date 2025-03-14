using System;

namespace DesafioProdutos.Exercicios;

public class Ex6
{
    //TODO Quais os produtos com maior valor total em estoque?
    public static void Exec()
    {
        var estoque = Program.produtos.GroupBy(prod => prod.Nome)
        .Select(prod => new
        {
            nome = prod.Key,
            quant = prod.Select(p => p.Quantidade).Sum(),
            precoTotal = prod.Select(p => p.Preco).Sum(),
        })
        .OrderByDescending(prod => prod.precoTotal)
        .Take(5);

        foreach (var prod in estoque)
        {
            Console.WriteLine($"{prod.nome} - {prod.precoTotal:c} ({prod.quant}un X {prod.precoTotal / prod.quant:c})");
        }

        //RESPOSTA
        // Farol de Neblina Chevrolet S10 - R$ 7.955,96 (236un X R$ 33,71)
        // Retrovisor Manual Chevrolet S10 - R$ 7.698,34 (192un X R$ 40,10)
        // Para-choque Dianteiro Volkswagen Saveiro - R$ 7.630,15 (28un X R$ 272,51)
        // Para-lama Dianteiro Volkswagen Saveiro - R$ 7.240,43 (122un X R$ 59,35)
        // Lanterna Dianteira Toyota Corolla - R$ 6.819,47 (189un X R$ 36,08)
    }
}