using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pruebaTecnica.Models
{
    public class DesgloseRepuestos
    {
        [Key]
        public int Id { get; set; }

        public float precioUnidad { get; set; }

        
        public int numeroUnidades { get; set; }

        public int descuento { get; set; }

        [ForeignKey("Factura")]

        public int FacturaId { get; set; }
        public Factura Factura { get; set; }
    }
}
