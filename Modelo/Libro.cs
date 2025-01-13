
namespace Modelo;

public class Libro : ItemBiblioteca
{
    public string Genero { get; set; }
    public int NumeroPaginas { get; set; }

    public override string ToString()
    {
        return $"{Titulo} - {Autor} ({Genero})";
    }
}
