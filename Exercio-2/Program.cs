using System.Diagnostics.Contracts;
using CarroEnum;
Console.WriteLine("=== Bem-Vindo ===");

Carro c1 = new Carro();

Console.WriteLine("Digite o modelo do carro: ");
c1.Modelo = Console.ReadLine();

Console.WriteLine("Digite a marca do carro: ");
c1.Marca = Console.ReadLine();

Console.WriteLine("Digite o ano do carro: ");
c1.Ano = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a cor do carro: ");
Console.WriteLine($"Branco: {(int)Cores.Branco}, Vermelho: {(int)Cores.Vermelho}, Preto: {(int)Cores.Preto}, Cinza: {(int)Cores.Cinza}, Prata: {(int)Cores.Prata}, Azul: {(int)Cores.Azul}");int valor = Convert.ToInt32(Console.ReadLine());
var corEnum = (Cores)valor;
c1.Cor = valor;
c1.ExibirInfo(c1.Modelo, c1.Marca, c1.Ano, c1.Cor);

Console.ReadKey();

public class Carro
{
    public string? Modelo;
    public string? Marca;
    public int Ano;
    public int Cor;

    public void ExibirInfo(string? modelo, string marca, int ano, int cor = 1)
    {
        string? nomeCor = Enum.GetName(typeof(Cores), cor);

        Console.WriteLine("\n=== Informações do carro ===");
        Console.WriteLine($"Modelo: {modelo}");
        Console.WriteLine($"Marca: {marca}");
        Console.WriteLine($"Ano: {ano}");
        Console.WriteLine($"Cor: {nomeCor ?? "Cor invalida!"}");
    }

    public Carro(string modelo, string marca, int ano, int cor)
    {
        Modelo = modelo;
        Marca = marca;
        Ano = ano;
        Cor = cor;
    }
    public Carro()
    {}
 
}