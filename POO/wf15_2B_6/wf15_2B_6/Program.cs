using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace wf15_2B_6
{
    public partial class Form1 : Form
    {
        private Producto producto;
        private Archivo archivo;
        private BinaryWriter archivoEscritura;
        private BinaryReader archivoLectura;
        public Form1()
        {
            InitializeComponent();
            archivo = new Archivo("uno.dat");

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txNoProducto.Text = "";
            txNombre.Text = "";
            txDescripcion.Text = "";
            txPrecio.Text = "";
            txCantidad.Text = "";
            btnAgregar.Enabled = true;
        }
        private void Actualiza()
        { // Creamos el producto con los contenidos de los textos
            producto = new Producto(
            int.Parse(txNoProducto.Text.ToString()),
            txNombre.Text.ToString(),
            txDescripcion.Text.ToString(),
            Double.Parse(txPrecio.Text.ToString()),

            int.Parse(txCantidad.Text.ToString()));
        }
        public Boolean Capturado()
        {
            int noCampo = 0;
            if (txNoProducto.Text.Length > 0)
                noCampo++;
            if (txNombre.Text.Length > 0)
                noCampo++;
            if (txDescripcion.Text.Length > 0)
                noCampo++;
            if (txCantidad.Text.Length > 0)
                noCampo++;
            if (txPrecio.Text.Length > 0)
                noCampo++;
            if (noCampo == 5)
                return true;
            else
                return false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (archivo.Lectura)
                archivoLectura.Close();
            if (archivo.Creacion)
                if (archivo.Alta == false)
                {

                    archivo.Alta = true;
                    archivoEscritura = new BinaryWriter(File.Open(archivo.Nombre(),
                    FileMode.Append));
                }
            if (archivo.Alta == true)
            {
                Actualiza();
                if (Capturado())
                {
                    archivoEscritura.Write(producto.NoProducto());
                    archivoEscritura.Write(producto.Nombre());
                    archivoEscritura.Write(producto.Descripcion());
                    archivoEscritura.Write(producto.Precio());
                    archivoEscritura.Write(producto.Cantidad());
                }
                else
                {
                    archivoEscritura.Close();
                    MessageBox.Show("Campo vacio");
                    btnNuevo_Click(sender, e);
                }
            }
            btnNuevo_Click(sender, e);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (archivo.Alta)

            {
                archivoEscritura.Close();
                archivo.Alta = false;
            }
            if (archivo.Lectura != true)
            {
                archivo.Lectura = true;
                archivoLectura = new BinaryReader(File.Open(archivo.Nombre(),
                FileMode.Open));
            }
            if (archivo.Lectura == true)
                if (archivoLectura.PeekChar() > -1)
                {
                    txNoProducto.Text = archivoLectura.ReadInt32().ToString();
                    txNombre.Text = archivoLectura.ReadString().ToString();
                    txDescripcion.Text = archivoLectura.ReadString().ToString();
                    txPrecio.Text = archivoLectura.ReadDouble().ToString();
                    txCantidad.Text = archivoLectura.ReadInt32().ToString();
                }
                else
                {
                    archivo.Lectura = false;
                    MessageBox.Show("Fin del archivo"); //KAM
                }
        }
    }
    public class Producto
    {

        private int noProducto;
        private String nombre;
        private String descripcion;
        private Double precio;
        private int cantidad;
        public Producto(int noProducto, string nombre, String descripcion, Double
        precio,
        int cantidad)
        {
            Actualiza(noProducto, nombre, descripcion, precio, cantidad);
        }
        public void Actualiza(int noProducto, string nombre, String descripcion,
        Double precio,
        int cantidad)
        {
            this.noProducto = noProducto;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.precio = precio;
            this.cantidad = cantidad;
        }
        public int NoProducto() { return noProducto; }
        public String Nombre() { return nombre; }
        public String Descripcion() { return descripcion; }
        public Double Precio() { return precio; }
        public int Cantidad() { return cantidad; }
    }
    public class Archivo
    {

        private String nombre;
        public Boolean Creacion;
        public Boolean Alta;
        public Boolean Lectura;
        public Boolean Existe;
        public Archivo(String nombre)
        {
            BinaryWriter archivoEscribe;
            this.nombre = nombre;
            if (File.Exists(nombre))
                Creacion = true;
            else
            {
                archivoEscribe = new BinaryWriter(File.Open(nombre,
                FileMode.OpenOrCreate));
                archivoEscribe.Close();
            }
        }
        public String Nombre() { return nombre; }
    }
}