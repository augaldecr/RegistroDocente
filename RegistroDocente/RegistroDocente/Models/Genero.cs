using SQLite.Net.Attributes;

namespace RegistroDocente.Models
{
    public class Genero
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull]
        public string Nombre { get; set; }
    }
}
