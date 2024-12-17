public class Veiculo
{

    public string marca { get; set;}
    public string modelo { get; set; }
 
public Veiculo(string Marca, string Modelo)
{
    Marca = marca;
    Modelo = modelo;
}

public void Info()
{
    return Console.WriteLine($"Veículo: {Marca}, {Modelo}");
}
}