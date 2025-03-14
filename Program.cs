using DesafioProdutos.Exercicios;
using DesafioProdutos.Models;

namespace DesafioProdutos;

class Program
{
    static string caminhoArquivo = Path.Combine(Environment.CurrentDirectory, "Produtos.xlsx");
    public static List<Produto> produtos = [];

    public static void Main(string[] args)
    {
        Ex1.Exec();
        //Ex2.Exec();
        //Ex3.Exec();
        //Ex4A.Exec();
        //Ex4B.Exec();
        //Ex4C.Exec();
        //Ex5.Exec();
        //Ex6.Exec();
    }
}