
namespace Modelo;
public class Prestamo
{
    public int Id { get; set; }
    public int UsuarioId { get; set; }
    public int ItemId { get; set; }
    public DateTime FechaPrestamo { get; set; }
    public DateTime? FechaDevolucion { get; set; }
}

