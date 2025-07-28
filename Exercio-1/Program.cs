Console.WriteLine("Exercio 1");

Cliente cliente = new(); //CRIACAO DE UMA NOVA INSTANCIA

Cliente c1 = new Cliente("Nicolas", "nvalentim824@gmail.com", 18);
Cliente.ExibirInfo("Nicolas");
Cliente.ExibirInfo("Nicolas", "nvalentim824@gmail.com");
Cliente.ExibirInfo("Nicolas", "nvalentim824@gmail.com", 18);



cliente.Nome = "Nícolas";
cliente.Email = "nvalentim824@gmail.com";
cliente.Idade = 18;

Cliente.ExibirInfo("Nícolas", "nvalentim824@gmail.com", 18);
Cliente.ExibirInfo("Nícolas", "nvalentim824@gmail.com");

        Console.ReadKey();


public struct Cliente //CRIANDO A STRUCT
{
    public string? Nome { get; set; } //PROPIEDADES GET E SET
    public string? Email { get; set; }

    private int idade;
    public int Idade
    {
        get { return idade; }
        set
        {
            if (value < 18)
                idade = 18;
        }
    }

    public Cliente(string nome, string email = "nvalentim824@gmail.com", int idade = 18) //CONSTRUTOR
    {
        Nome = nome;
        Email = email;
        Idade = idade;
    }

    public static void ExibirInfo(string nome, string email = "nvalentim824@gmail.com", int idade = 18) //PARAMETRO OPCIONAL
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Email: {email}");
        Console.WriteLine($"Idade: {idade}");
    }


}


