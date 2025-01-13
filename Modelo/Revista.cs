
namespace Modelo;
public class Revista : ItemBiblioteca
{
    public int NumeroEdicion { get; set; }
    public DateTime FechaPublicacion { get; set; }

    public override string ToString()
    {
        return $"{Titulo} - Edición {NumeroEdicion} ({FechaPublicacion:yyyy-MM-dd})";
    }
}

