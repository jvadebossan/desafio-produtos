using System;

namespace DesafioProdutos.Models;

public class Produto
{
    public int Codigo { get; protected set; }
    public string Nome { get; protected set; }
    public string Categoria { get; protected set; }
    public string Fabricante { get; protected set; }
    public double Preco { get; protected set; }
    public int Quantidade { get; protected set; }
    public DateTime DataEntrada { get; protected set; }
    public string Empresa { get; protected set; }

    public Produto(int codigo, string nome, string categoria, string fabricante, double preco, int quantidade, DateTime dataEntrada, string empresa)
    {
        Codigo = codigo;
        Nome = nome;
        Categoria = categoria;
        Fabricante = fabricante;
        Preco = preco;
        Quantidade = quantidade;
        DataEntrada = dataEntrada;
        Empresa = empresa;
    }

    public void SetEmpresa(string empresa)
    {
        if (string.IsNullOrWhiteSpace(empresa))
            throw new ArgumentException("O campo \"empresa\" não pode estar vazio.");
        Empresa = empresa;
    }
    public void SetDataEntrada(DateTime dataEntrada)
    {
        if (dataEntrada == DateTime.MinValue)
        {
            throw new Exception("O campo DataEntrada deve ser preenchido corretamente");
        }
        DataEntrada = dataEntrada;
    }
    public void SetQuantidade(int quantidade)
    {
        if (quantidade < 0)
        {
            throw new Exception("O campo Quantidade não pode ser negativo");
        }
        Quantidade = quantidade;
    }
    public void SetPreco(double preco)
    {
        if (preco <= 0)
        {
            throw new Exception("O campo Preco deve ser maior que zero");
        }
        Preco = preco;
    }
    public void SetFabricante(string fabricante)
    {
        if (string.IsNullOrWhiteSpace(fabricante))
            throw new ArgumentException("O campo \"fabricante\" não pode estar vazio.");
        Fabricante = fabricante;
    }
    public void SetCategoria(string categoria)
    {
        if (string.IsNullOrWhiteSpace(categoria))
            throw new ArgumentException("O campo \"categoria\" não pode estar vazio.");
        Categoria = categoria;
    }
    public void SetNome(string nome)
    {
        if (string.IsNullOrWhiteSpace(nome))
            throw new ArgumentException("O campo \"nome\" não pode estar vazio.");
        Nome = nome;
    }
    public void SetCodigo(int codigo)
    {
        if (codigo <= 0)
            throw new Exception("O campo Quantidade deve ser maior do que zero");
        Codigo = codigo;
    }
}
