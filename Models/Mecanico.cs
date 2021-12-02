using System;
using System.ComponentModel.DataAnnotations;

namespace pruebaTecnica.Models
{
    public class Mecanico
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public string primerNombre { get; set; }

        [StringLength(100)]
        public string segundoNombre { get; set; }

        [StringLength(100)]
        public string primerApellido { get; set; }

        [StringLength(100)]
        public string segundoApellido { get; set; }

        [StringLength(100)]
        public string tipoDocumento { get; set; }

        [StringLength(100)]
        public string numeroDocumento { get; set; }

        [StringLength(100)]
        public string celular { get; set; }

        [StringLength(100)]
        public string direccion { get; set; }

        [StringLength(100)]
        public string correoElectronico { get; set; }

        [StringLength(100)]
        public string estado { get; set; }
    }
}
