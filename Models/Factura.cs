using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pruebaTecnica.Models
{
    public class Factura
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Cliente")]

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        [ForeignKey("Mecanico")]

        public int MecanicoId { get; set; }
        public Mecanico Mecanico { get; set; }

        public float Total { get; set; }

        public DateTime Fecha { get; set; }



    }
}
