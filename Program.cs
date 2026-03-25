namespace EXAMEN_PARCIAL_P
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SISTEMA DE GESTION DE INVENTARIO");

            ProductoElectronico LAPTOP = new ProductoElectronico("LAPTOP", "P1002", 25000m, 3, 24);
            LAPTOP.MostrarProducto();
            Console.WriteLine($"EL IMPUESTO DEL PRODUCTO ELECTRONICO ES: {LAPTOP.CalcularImpuesto():C}");
            Console.WriteLine();

            ProductoAlimento SALDINAS = new ProductoAlimento(
                            NOMBRE: "SALDINAS JAJA",
                            CODIGO: "A2003",
                            PRECIO: 300m,
                            CANTIDAD: 5,
                            FECHAVENCIMIENTO: new DateTime(2026, 09, 21)
                        );

            SALDINAS.MostrarProducto();
            Console.WriteLine($"EL IMPUESTO DEL ESTE ALIMENTO : {SALDINAS.CalcularImpuesto():C}");
            Console.WriteLine();

        }
    }
    class Producto
    {
        private string NOMBRE;
        private string CODIGO;
        private decimal PRECIO;
        private int CANTIDAD;
        public Producto(string NOMBRE, string CODIGO, decimal PRECIO, int CANTIDAD)
        {
            this.NOMBRE = NOMBRE;
            this.CODIGO = CODIGO;
            this.PRECIO = PRECIO;
            this.CANTIDAD = CANTIDAD;
        }
        public string Nombre
        {
            get { return NOMBRE; }
            set { NOMBRE = value; }
        }
        public string Codigo
        {
            get { return CODIGO; }
            set { CODIGO = value; }
        }
        public decimal Precio
        {
            get { return PRECIO; }
            set { PRECIO = value; }
        }
        public int Cantidad
        {
            get { return CANTIDAD; }
            set { CANTIDAD = value; }
        }
        public void MostrarProducto()
        {
            Console.WriteLine($"NOMBRE: {NOMBRE}");
            Console.WriteLine($"CODIGO: {CODIGO}");
            Console.WriteLine($"PRECIO: {PRECIO:C}");
            Console.WriteLine($"CANTIDAD: {CANTIDAD}");
        }
        public virtual decimal CalcularImpuesto()
        {
            return 0;
        }
    }
    class ProductoElectronico : Producto
    {
        private int GARANTIAMESES;

        public ProductoElectronico(string NOMBRE, string CODIGO, decimal PRECIO, int CANTIDAD, int GARANTIAMESES)
            : base(NOMBRE, CODIGO, PRECIO, CANTIDAD)
        {
            this.GARANTIAMESES = GARANTIAMESES;
        }
        public int GarantiaMeses
        {
            get { return GARANTIAMESES; }
            set { GARANTIAMESES = value; }
        }
        public override decimal CalcularImpuesto()
        {
            return Precio * 0.18m;
        }
    }
    class ProductoAlimento : Producto
    {
        private DateTime FECHAVENCIMIENTO;
        public ProductoAlimento(string NOMBRE, string CODIGO, decimal PRECIO, int CANTIDAD, DateTime FECHAVENCIMIENTO)
            : base(NOMBRE, CODIGO, PRECIO, CANTIDAD)
        {
            this.FECHAVENCIMIENTO = FECHAVENCIMIENTO;
        }
        public DateTime FechaVencimiento
        {
            get { return FECHAVENCIMIENTO; }
            set { FECHAVENCIMIENTO = value; }
        }
        public override decimal CalcularImpuesto()
        {
            return Precio * 0.08m;
        }
    }
}
