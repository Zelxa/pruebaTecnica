using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pruebaTecnica.Models
{
    public class DesgloseServicios
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public string NombreServicio { get; set; }

        [StringLength(100)]
        public string precioManoDeObra { get; set; }

        public int descuento { get; set; }

        [ForeignKey("Factura")]

        public int FacturaId { get; set; }
        public Factura Factura { get; set; }
    }
}
