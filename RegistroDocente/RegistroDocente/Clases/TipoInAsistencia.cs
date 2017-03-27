﻿using SQLite.Net.Attributes;

namespace RegistroDocente.Clases
{
    public class TipoInAsistencia
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [NotNull]
        public string Nombre { get; set; }
    }
}
