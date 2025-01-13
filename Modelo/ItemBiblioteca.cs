
namespace Modelo;
public abstract class ItemBiblioteca
{
    public int Id { get; set; }
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public bool Disponible { get; private set; }

    public ItemBiblioteca()
    {
        Disponible = true;
    }

    public virtual void Prestar()
    {
        if (!Disponible)
        {
            throw new InvalidOperationException("El ítem no está disponible.");
        }
        Disponible = false;
    }

    public virtual void Devolver()
    {
        Disponible = true;
    }
}


