using DesafioProdutos.Exercicios;
using DesafioProdutos.Models;
using NPOI.SS.UserModel;

namespace DesafioProdutos;

class Program
{
    static string caminhoArquivo = Path.Combine(Environment.CurrentDirectory, "Produtos.xlsx");
    public static List<Produto> produtos = [];

    public static void Main(string[] args)
    {
        ImportarExcel();
        Ex1.Exec();
        // Ex2.Exec();
        // Ex3.Exec();
        // Ex4A.Exec();
        // Ex4B.Exec();
        // Ex4C.Exec();
        // Ex5.Exec();
        // Ex6.Exec();
    }

    public static void ImportarExcel()
    {
        try
        {
            IWorkbook pastaTrabalho = WorkbookFactory.Create(caminhoArquivo);

            ISheet planilha = pastaTrabalho.GetSheetAt(0);

            for (int i = 1; i < planilha.PhysicalNumberOfRows; i++)
            {
                IRow linha = planilha.GetRow(i);

                int codigo = (int)linha.GetCell(0).NumericCellValue;
                string nome = linha.GetCell(1).StringCellValue;
                string categoria = linha.GetCell(2).StringCellValue;
                string fabricante = linha.GetCell(3).StringCellValue;
                double preco = linha.GetCell(4).NumericCellValue;
                int quantidade = (int)linha.GetCell(5).NumericCellValue;
                DateTime dataEntrada = linha.GetCell(6).DateCellValue ?? DateTime.Now;
                string empresa = linha.GetCell(7).StringCellValue;

                var musica = new Produto(codigo, nome, categoria, fabricante, preco, quantidade, dataEntrada, empresa);

                produtos.Add(musica);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}