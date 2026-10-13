namespace BlazorDbzPersonagem.Models;

public class Personagem
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Race { get; set; } = "";
    public string Image { get; set; } = "";
    public Planeta? OriginPlanet { get; set; }
    public List<Transformacao> Transformations { get; set; } = new();
}

public class Planeta
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
}

public class Transformacao
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Ki { get; set; } = "";
}