using System.ComponentModel.DataAnnotations;

namespace PizzaPlace_2024.Models
{
    public class Clientes
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Por favor proporcionar un Nombre.")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Por favor proporcionar una Calle con su número de casa.")]
        public string Calle { get; set; }
        [Required(ErrorMessage = "Por favor proporcionar una Ciudad.")]
        public string Ciudad { get; set; }
    }
}
