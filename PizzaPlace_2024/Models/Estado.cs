namespace PizzaPlace_2024.Models
{
    public class Estado
    {
        public Menu Menu { get; } = new Menu();
        public CanastaCompras Canasta { get; } = new CanastaCompras();
        public UI UI { get; set; } = new UI();
        public decimal PrecioTotal => Canasta.Pedidos.Sum(id => Menu.GetPizza(id)!.Precio);
    }
}
