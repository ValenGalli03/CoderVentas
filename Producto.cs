namespace DesafioUno
{
    public class Producto
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public int precio { get; set; }
        public int precioVenta { get; set; }
        public int stock { get; set; }
        public int idUsuario { get; set; }

        public Producto(int id, string descripcion, int precio, int PrecioVenta, int stock, int idUsuario)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.precio = precio;
            this.precioVenta = PrecioVenta;
            this.stock = stock;
            this.idUsuario = idUsuario;
        }
    }
}
       