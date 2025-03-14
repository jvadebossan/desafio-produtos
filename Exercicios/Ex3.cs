using System;

namespace DesafioProdutos.Exercicios;

public class Ex3
{
    //TODO: Quantos produtos entraram no estoque por mês? Faça uma lista ordenada ascendente dos meses e as respectivas quantidades.
    public static void Exec()
    {
        var meses = Program.produtos.GroupBy(prod => new
        {
            mes = prod.DataEntrada.Month,
            ano = prod.DataEntrada.Year
        })
        .OrderBy(m => m.Key.ano).ThenBy(m => m.Key.mes)
        .Select(m => new
        {
            formato = new DateTime(m.Key.ano, m.Key.mes, 1).ToString("MMMM/yyyy"),
            quant = m.Select(c => c.Quantidade)
        });

        foreach (var mes in meses)
        {
            Console.WriteLine($"{mes.formato}: {mes.quant.Sum()} unidades");
        }

        //RESPOSTA:
        // março/2024: 1049 unidades
        // abril/2024: 1717 unidades
        // maio/2024: 2549 unidades
        // junho/2024: 1974 unidades
        // julho/2024: 1778 unidades
        // agosto/2024: 1880 unidades
        // setembro/2024: 2275 unidades
        // outubro/2024: 3099 unidades
        // novembro/2024: 2486 unidades
        // dezembro/2024: 1443 unidades
        // janeiro/2025: 2507 unidades
        // fevereiro/2025: 1722 unidades
        // março/2025: 572 unidades
    }
}
