public class Moto
{
    public Moto (string marca, string modelo) : base(string marca, string modelo) {}

    public string tipoguidao {get; set;}

    public Moto (string Tipoguidao)
    {
        Tipoguidao = tipoguidao;
    }

    public override Info()
    {
        Console.WriteLine($"Moto {Marca},{Modelo},{Tipoguidao}")
    }
}