
namespace Modelo;
public abstract class Usuario
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string TipoUsuario { get; protected set; }
    public List<ItemBiblioteca> PrestamosActivos { get; private set; }

    protected Usuario()
    {
        PrestamosActivos = new List<ItemBiblioteca>();
    }

    public void PrestarItem(ItemBiblioteca item)
    {
        if (PrestamosActivos.Count >= 5)
        {
            throw new InvalidOperationException("Límite de préstamos alcanzado.");
        }
        item.Prestar();
        PrestamosActivos.Add(item);
    }

    public void DevolverItem(ItemBiblioteca item)
    {
        if (PrestamosActivos.Remove(item))
        {
            item.Devolver();
        }
    }
}

